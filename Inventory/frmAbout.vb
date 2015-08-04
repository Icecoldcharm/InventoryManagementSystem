Public Class frmAbout 

    Private Sub frmAbout_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If IsInitializing = False Then
            Visuals.CenterItemOnScreen(groupAbout)
        End If
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm

        'Set the Application version
        Dim appVer As String = My.Application.Info.Version.ToString().Substring(0, My.Application.Info.Version.ToString().Length - 2)
        lblAboutVersion.Text = appVer

        'Add content to release notes
        rtbAboutReleaseNotes.LoadDocument("Release Notes.rtf")
    End Sub
End Class