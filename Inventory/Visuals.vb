Public Class Visuals

    Public Shared Function CenterItemOnScreen(ByVal obj As Control) As Point
        Try
            obj.Left = (obj.Parent.Width * 0.5) - (obj.Width * 0.5)
            obj.Top = (obj.Parent.Height * 0.5) - (obj.Height * 0.5)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
