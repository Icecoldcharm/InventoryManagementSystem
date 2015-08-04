Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmEquipment

    Private Sub GridViewEquipment_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewEquipment.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewEquipment.CalcHitInfo(e.Location)

            Session.curEquipment = Session.Equipment(GridViewEquipment.GetDataSourceRowIndex(hi.RowHandle))
            EquipmentBinding.DataSource = Session.curEquipment
            navbarEquipment.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the Equipment grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectEquipmentItem(ByVal item As Integer)
        GridViewEquipment.FocusedRowHandle = item
        If GridViewEquipment.FocusedRowHandle >= 0 Then
            Session.curEquipment = Session.Equipment(GetSelectedHandleFromGrid(GridViewEquipment))
            EquipmentBinding.DataSource = Session.curEquipment
            navbarEquipment.Enabled = True
        Else
            navbarEquipment.Enabled = False
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

    Public Sub AddEquipment()
        Dim newEquipment As New Equipment

        newEquipment.Id = Guid.NewGuid
        newEquipment.RoomID = Session.curRoom.Id
        newEquipment.Quantity = 1

        Session.Equipment.Add(newEquipment)
        Session.Context.Equipments.AddObject(newEquipment)
        Session.Context.SaveChanges()
        newEquipment = Nothing

        'Display the new item
        SelectEquipmentItem(GridViewEquipment.RowCount - 1)
    End Sub

    Private Sub GridViewEquipment_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewEquipment.CustomUnboundColumnData
        'Update the equipment total column
        If e.Column.FieldName = "colEquipmentTotal" And e.IsGetData Then
            If (Session.Equipment.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.Equipment(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub frmEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class