Imports InventoryData

Public Class RoomLogic
    Implements IDisposable

    Public Function GetRoomsForUser(ByVal usr As User, ByVal ctx As InventoryEntities) As List(Of Room)
        Dim tmpRooms As New List(Of Room)
        Dim UserRooms As New List(Of UserRoom)

        Try
            UserRooms = ctx.UserRooms.Where(Function(u) u.UserID = usr.ID).ToList()

            For Each usrRm As UserRoom In UserRooms
                tmpRooms.Add(usrRm.Room)
            Next

            Return tmpRooms.OrderBy(Function(s) s.FullName)
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return Nothing
        End Try
    End Function

    ' ''' <summary>
    ' ''' This function is used to get a list of rooms for the currently selected user in the user maanger
    ' ''' </summary>
    ' ''' <param name="usr"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Public Function GetRoomsForSelectedUser(ByVal usr As User) As List(Of Room)
    '    Dim Rooms As New List(Of Room)
    '    Dim tmpRooms As New RoomCollection
    '    Dim UserRoomQry As New UserRoomQuery
    '    Dim UserRooms As New UserRoomCollection
    '    Dim SortedRooms As IEnumerable(Of Room)

    '    UserRoomQry.Where(UserRoomQry.UserID = usr.Id)
    '    UserRooms.Load(UserRoomQry)


    '    For Each usrRm As UserRoom In UserRooms
    '        tmpRooms.Add(usrRm.UpToRoomByRoomID)
    '    Next

    '    SortedRooms = tmpRooms.OrderBy(Function(room) room.FullName)

    '    For Each rm As Room In SortedRooms
    '        Rooms.Add(rm)
    '    Next

    '    Return Rooms
    'End Function

    Public Function GetRoomsInBuilding(ByVal bldg As Building, ByVal ctx As InventoryEntities) As List(Of Room)
        Try
            Return ctx.Rooms.Where(Function(r) r.BldID = bldg.ID)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try

    End Function

    Public Function GetRoomGUID(ByVal bldName As String, ByVal rmNumber As String, ByVal ctx As InventoryEntities) As String
        Dim bldg As Building
        Dim rm As Room

        Try
            bldg = ctx.Buildings.Where(Function(b) b.BldName = bldName).First
            rm = ctx.Rooms.Where(Function(r) r.BldID = bldg.ID and r.RoomNo = rmNumber).First

            Return rm.ID.ToString()
        Catch ex As Exception
            MsgBox(ex.ToString())            
            Return Nothing
        Finally
            bldg = Nothing
            rm = Nothing
        End Try
    End Function

    Public Function GetAllRooms(ByVal ctx As InventoryEntities) As List(Of Room)
        Try
            return ctx.Rooms.OrderBy(Function(s) s.FullName)
        Catch ex As Exception
            MsgBox(ex.ToString())
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
