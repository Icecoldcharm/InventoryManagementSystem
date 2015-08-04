Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmTextbook

    Private Sub GridViewTextbook_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewTextbook.CustomUnboundColumnData
        'Update the textbooks total column
        If e.Column.FieldName = "colTextbooksTotal" And e.IsGetData Then
            If (Session.Textbooks.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.Textbooks(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub GridViewTextbook_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewTextbook.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewTextbook.CalcHitInfo(e.Location)

            Session.curTextbook = Session.Textbooks(GridViewTextbook.GetDataSourceRowIndex(hi.RowHandle))
            TextbookBinding.DataSource = Session.curTextbook
            navbarTextbook.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the textbook grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectTextbookItem(ByVal item As Integer)
        'Select the first item in the grid
        If item = -1 Then
            item = 0
        End If

        GridViewTextbook.FocusedRowHandle = item
        If GridViewTextbook.FocusedRowHandle >= 0 Then
            Session.curTextbook = Session.Textbooks(GetSelectedHandleFromGrid(GridViewTextbook))
            TextbookBinding.DataSource = Session.curTextbook
            navbarTextbook.Enabled = True
        Else
            navbarTextbook.Enabled = False
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

    Public Sub AddTextbook()
        Dim newTextbook As New Textbook

        newTextbook.Id = Guid.NewGuid
        newTextbook.RoomID = Session.curRoom.Id
        newTextbook.Quantity = 1

        Session.Textbooks.Add(newTextbook)
        Session.Context.Textbooks.AddObject(newTextbook)
        Session.Context.SaveChanges()
        newTextbook = Nothing

        'Display the new item
        SelectTextbookItem(GridViewTextbook.RowCount - 1)
    End Sub

    Private Sub frmTextbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class