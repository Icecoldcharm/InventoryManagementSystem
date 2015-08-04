Public Class frmWelcome 

    Private Sub tmrFade_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFade.Tick
        If Me.Opacity <= 0.95 Then
            Me.Opacity += 0.05
        Else
            Me.Opacity = 1
            tmrFade.Enabled = False
            StartProgram()
        End If
    End Sub

    Private Sub StartProgram()
        Session.MainForm = New frmMain

        Session.MainForm.Show()
    End Sub
End Class