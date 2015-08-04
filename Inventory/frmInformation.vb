Public Class FrmInformation

    Public Property Title() As String
        Get
            Return lblTitle.Text
        End Get
        Set(ByVal value As String)
            lblTitle.Text = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return txtMessage.RtfText
        End Get
        Set(ByVal value As String)
            txtMessage.RtfText = value
        End Set
    End Property

    Public Sub LoadMessage(ByVal filePath As String)
        Try
            txtMessage.LoadDocument(filePath)
        Catch ex As Exception
            txtMessage.Text = ex.Message
        End Try
    End Sub

End Class
