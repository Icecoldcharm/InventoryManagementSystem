Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmPrinters

    Private Sub GridViewPrinter_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewPrinter.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewPrinter.CalcHitInfo(e.Location)

            Session.curPrinter = Session.Printers(GridViewPrinter.GetDataSourceRowIndex(hi.RowHandle))
            PrinterBinding.DataSource = Session.curPrinter
            navbarPrinter.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the Printer grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectPrinterItem(ByVal item As Integer)
        GridViewPrinter.FocusedRowHandle = item
        If GridViewPrinter.FocusedRowHandle >= 0 Then
            Session.curPrinter = Session.Printers(GetSelectedHandleFromGrid(GridViewPrinter))
            PrinterBinding.DataSource = Session.curPrinter
            navbarPrinter.Enabled = True
        Else
            navbarPrinter.Enabled = False
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

    Public Sub AddPrinter()
        Dim prt As New Printer
        prt.Id = Guid.NewGuid
        prt.RoomID = Session.curRoom.Id
        Session.Printers.Add(prt)
        Session.Context.Printers.AddObject(prt)
        Session.Context.SaveChanges()
        prt = Nothing

        'Display the new item
        SelectPrinterItem(GridViewPrinter.RowCount - 1)
    End Sub

    Private Sub frmPrinters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        DocumentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.Docked
        DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.AllowedDockState = Not Telerik.WinControls.UI.Docking.AllowedDockState.Hidden
        ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
    End Sub
End Class