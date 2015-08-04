Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmMonitor

    Private Sub GridViewMonitor_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewMonitor.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewMonitor.CalcHitInfo(e.Location)

            Session.curMonitor = Session.Monitors(GridViewMonitor.GetDataSourceRowIndex(hi.RowHandle))
            MonitorBinding.DataSource = Session.curMonitor
            navbarMonitor.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the Monitor grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectMonitorItem(ByVal item As Integer)
        GridViewMonitor.FocusedRowHandle = item
        If GridViewMonitor.FocusedRowHandle >= 0 Then
            Session.curMonitor = Session.Monitors(GetSelectedHandleFromGrid(GridViewMonitor))
            MonitorBinding.DataSource = Session.curMonitor
            navbarMonitor.Enabled = True
        Else
            navbarMonitor.Enabled = False
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

    Public Sub AddMonitor()
        Dim mon As New Monitor
        mon.Id = Guid.NewGuid
        mon.RoomID = Session.curRoom.Id
        Session.Monitors.Add(mon)
        Session.Context.Monitors.AddObject(mon)
        Session.Context.SaveChanges()
        mon = Nothing

        'Display the new item
        SelectMonitorItem(GridViewMonitor.RowCount - 1)
    End Sub

    Private Sub frmMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class