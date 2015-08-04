Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmAV

    Private Sub GridViewAV_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewAV.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewAV.CalcHitInfo(e.Location)

            Session.curAV = Session.AV(GridViewAV.GetDataSourceRowIndex(hi.RowHandle))
            AVBinding.DataSource = Session.curAV
            navbarAV.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the AV grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectAVItem(ByVal item As Integer)
        GridViewAV.FocusedRowHandle = item
        If GridViewAV.FocusedRowHandle >= 0 Then
            Session.curAV = Session.AV(GetSelectedHandleFromGrid(GridViewAV))
            AVBinding.DataSource = Session.curAV
            navbarAV.Enabled = True
        Else
            navbarAV.Enabled = False
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

    Public Sub AddAV()
        Dim av As New AudioVideo
        av.Id = Guid.NewGuid
        av.RoomID = Session.curRoom.Id
        Session.AV.Add(av)
        Session.Context.AudioVideos.AddObject(av)
        Session.Context.SaveChanges()
        av = Nothing

        'Display the new item
        SelectAVItem(GridViewAV.RowCount - 1)
    End Sub

    Private Sub GridViewAV_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewAV.CustomUnboundColumnData
        'Update the software total column
        If e.Column.FieldName = "colAVTotal" And e.IsGetData Then
            If (Session.AV.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.AV(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub frmAV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class