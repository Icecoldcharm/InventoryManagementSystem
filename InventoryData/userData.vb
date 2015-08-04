Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports InventoryData.BusinessObjects

Public Class userData

    Public Function GetAllUsers() As UserCollection
        Dim tmpUsers As New UserCollection

        Try
            If tmpUsers.LoadAll() Then
                Return tmpUsers
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.ToString)
        Finally
            tmpUsers.Dispose()
        End Try
    End Function

End Class
