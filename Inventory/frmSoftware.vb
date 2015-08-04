Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmSoftware

    Private Sub GridViewSoftware_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewSoftware.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewSoftware.CalcHitInfo(e.Location)

            Session.curSoftware = Session.Software(GridViewSoftware.GetDataSourceRowIndex(hi.RowHandle))
            SoftwareBinding.DataSource = Session.curSoftware
            navbarSoftware.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the Software grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectSoftwareItem(ByVal item As Integer)
        GridViewSoftware.FocusedRowHandle = item
        If GridViewSoftware.FocusedRowHandle >= 0 Then
            Session.curSoftware = Session.Software(GetSelectedHandleFromGrid(GridViewSoftware))
            SoftwareBinding.DataSource = Session.curSoftware
            navbarSoftware.Enabled = True
        Else
            navbarSoftware.Enabled = False
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

    Public Sub AddSoftware()
        Dim sft As New Software
        sft.Id = Guid.NewGuid
        sft.RoomID = Session.curRoom.Id
        Session.Software.Add(sft)
        Session.Context.Softwares.AddObject(sft)
        Session.Context.SaveChanges()
        sft = Nothing

        'Display the new item
        SelectSoftwareItem(GridViewSoftware.RowCount - 1)
    End Sub

    Private Sub GridViewSoftware_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewSoftware.CustomUnboundColumnData
        'Update the software total column
        If e.Column.FieldName = "colSoftwareTotal" And e.IsGetData Then
            If (Session.Software.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.Software(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub frmSoftware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class