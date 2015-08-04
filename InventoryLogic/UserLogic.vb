Imports InventoryData

Public Class UserLogic
    Implements IDisposable

    Public Function Login(ByVal usrName As String, ByVal pword As String, ByVal ctx As InventoryEntities) As User
        Try
            Dim users As New List(Of User)

            users = ctx.Users.Where(Function(u) u.UserName = usrName and u.Password = pword).ToList()

            If users.Count > 0 Then
                Return users.First
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ADLogin(ByVal adUser As String, ByVal ctx As InventoryEntities) As User
        Try
            Dim users As New List(Of User)
            
            ctx.Users.Where(Function(u) u.UserName = adUser)

            If users.Count > 0 Then
                Return users.First
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Returns a list of all user accounts in the database
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAllUsers(ByVal ctx As InventoryEntities) As List(Of User)
        Try
            Return ctx.Users.ToList()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
