Public Class frmSubmitTicket

    Private Sub frmSubmitTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm
    End Sub

    Public Sub GotoSupportSite()
        browser.Navigate("http://hr2s-store1:9675/portal")
    End Sub
End Class