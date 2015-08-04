Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData
Imports System.Net

Public Class frmComputers

    Private Sub GridViewPC_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewPC.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewPC.CalcHitInfo(e.Location)

            Session.curComputer = Session.Computers(GridViewPC.GetDataSourceRowIndex(hi.RowHandle))
            ComputerBinding.DataSource = Session.curComputer
            navbarComputer.Enabled = True
            GetQRCode()
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    Private Sub GetQRCode()
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        Dim tmpGUID As String
        Dim tmpCodeImage As Image

        tmpGUID = Session.curComputer.Id.ToString
        request = WebRequest.Create("https://chart.googleapis.com/chart?chs=128x128&cht=qr&chld=M|2&chl=Computer%20" + tmpGUID)
        request.Timeout = 5000
        request.ReadWriteTimeout = 20000

        response = request.GetResponse()
        tmpCodeImage = Image.FromStream(response.GetResponseStream())
        'response.ContentType = "image/gif"

        picQR.Image = tmpCodeImage
    End Sub

    ''' <summary>
    ''' Select the first item in the computer grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectComputerItem(ByVal item As Integer)
        GridViewPC.FocusedRowHandle = item
        If GridViewPC.FocusedRowHandle >= 0 Then
            Session.curComputer = Session.Computers(GetSelectedHandleFromGrid(GridViewPC))
            ComputerBinding.DataSource = Session.curComputer
            navbarComputer.Enabled = True
        Else
            navbarComputer.Enabled = False
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

    Public Sub AddComputer()
        TabManager.DisplayComputerTab(0)

        Dim pc As New Computer
        pc.Id = Guid.NewGuid
        pc.ComputerName = "New Computer"
        pc.RoomID = Session.curRoom.Id

        Session.Computers.Add(pc)
        Session.Context.Computers.AddObject(pc)
        Session.Context.SaveChanges()
        pc = Nothing

        'Select the new item
        SelectComputerItem(GridViewPC.RowCount - 1)
    End Sub

    Private Sub frmComputers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class