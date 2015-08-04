Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData
Imports InventoryLogic

Public Class frmFurniture

    Private Sub gridViewFurniture_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewFurniture.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewFurniture.CalcHitInfo(e.Location)

            Session.curFurniture = Session.Furniture(GridViewFurniture.GetDataSourceRowIndex(hi.RowHandle))
            FurnitureBinding.DataSource = Session.curFurniture
            navbarFurniture.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the Furniture grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectFurnitureItem(ByVal item As Integer)
        GridViewFurniture.FocusedRowHandle = item
        If GridViewFurniture.FocusedRowHandle >= 0 Then
            Session.curFurniture = Session.Furniture(GetSelectedHandleFromGrid(GridViewFurniture))
            FurnitureBinding.DataSource = Session.curFurniture
            navbarFurniture.Enabled = True
        Else
            navbarFurniture.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Returns the datasource index for the first selected row in the given gridview
    ''' </summary>
    ''' <param name="view"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetSelectedHandleFromGrid(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView) As Integer
        If view.SelectedRowsCount = 0 Then
            Return Nothing
        End If

        Dim rowHandle As Integer = view.GetSelectedRows()(0)

        Return view.GetDataSourceRowIndex(rowHandle)
    End Function

    Public Sub AddFurniture()
        If Session.Furniture Is Nothing Then
            Using furn As New FurnitureLogic
                Session.Furniture = furn.GetFurnitureForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        Dim newFurniture As New Furniture

        newFurniture.Id = Guid.NewGuid
        newFurniture.RoomID = Session.curRoom.Id
        newFurniture.Quantity = 1

        Session.Furniture.Add(newFurniture)
        Session.Context.Furnitures.AddObject(newFurniture)
        Session.Context.SaveChanges()
        newFurniture = Nothing

        'Display the furniture tab
        SelectFurnitureItem(GridViewFurniture.RowCount - 1)
    End Sub

    Private Sub GridViewFurniture_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewFurniture.CustomUnboundColumnData
        'Update the furniture total column
        If e.Column.FieldName = "colFurnitureTotal" And e.IsGetData Then
            If (Session.Furniture.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.Furniture(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub frmFurniture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class