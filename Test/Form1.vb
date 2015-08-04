Public Class Form1

    Dim ctx As New InventoryEntities()
    Dim curPC As New Computer

Private Sub Form1_Load( sender As Object,  e As EventArgs) Handles MyBase.Load

End Sub

Private Function LoadComputers(name As string) As List(Of Computer)
        Return ctx.Computers.Where(Function(pc) pc.ComputerName.Contains(name)).ToList()
End Function

Private Sub Button1_Click( sender As Object,  e As EventArgs) Handles Button1.Click
    ListBox1.DisplayMember = "ComputerName"    
    ListBox1.DataSource = LoadComputers(TextBox1.Text)
End Sub

Private Sub Button2_Click( sender As Object,  e As EventArgs) Handles Button2.Click
    curPC.ComputerName = TextBox2.Text
    ctx.SaveChanges()
End Sub

Private Sub ListBox1_SelectedIndexChanged( sender As Object,  e As EventArgs) Handles ListBox1.SelectedIndexChanged
        curPC = ListBox1.SelectedItem
        TextBox2.Text = curPC.ComputerName
End Sub
End Class
