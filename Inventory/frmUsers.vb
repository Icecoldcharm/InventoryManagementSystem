Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData
Imports InventoryLogic
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices

Public Class frmUsers

    Private userRooms As New List(Of Room)
    Private Rooms As New List(Of Room)

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm
        GetDistrictRooms()
    End Sub

    Private Sub GridViewUsers_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewUsers.MouseDown
        Try
            'Get a list of rooms the user has rights to
            GetUserRooms()

            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewUsers.CalcHitInfo(e.Location)

            Session.curEditUser = Session.Users(GridViewUsers.GetDataSourceRowIndex(hi.RowHandle))
            UserBinding.DataSource = Session.curEditUser   

            navbarUsers.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Gets a list of all district rooms
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetDistrictRooms()
        Rooms = New List(Of Room)

        Using rmLogic As New RoomLogic
            Rooms.AddRange(rmLogic.GetAllRooms(Session.Context))
        End Using

        gridRooms.DataSource = Rooms
        gridRooms.Refresh
    End Sub
    
    ''' <summary>
    ''' Get a list of rooms that the current user has rights to and check them off in the gridview
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetUserRooms()
        Using rmLogic As New RoomLogic
            userRooms.AddRange(rmLogic.GetRoomsForUser(Session.curEditUser, Session.Context))
        End Using

        'gridViewRooms.RefreshData()
    End Sub

    ''' <summary>
    ''' Select the first item in the User grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectUserItem(ByVal item As Integer)
        GridViewUsers.FocusedRowHandle = item
        If GridViewUsers.FocusedRowHandle >= 0 Then
            Session.curEditUser = Session.Users(GetSelectedHandleFromGrid(GridViewUsers))
            UserBinding.DataSource = Session.curEditUser
            navbarUsers.Enabled = True
        Else
            navbarUsers.Enabled = False
        End If
    End Sub

    Public Sub AddMonitor()
        Dim usr As New User
        usr.Id = Guid.NewGuid
        usr.FirstName = "New"
        usr.LastName = "User"
        usr.UserName = "NewUser"
        usr.Password = "NewUser"
        Session.Users.Add(usr)
        Session.Context.Users.AddObject(usr)
        Session.Context.SaveChanges()
        usr = Nothing

        'Display the new item
        SelectUserItem(GridViewUsers.RowCount - 1)
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

    ''' <summary>
    ''' Center the change password popup when the form is resized
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmUsers_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If IsInitializing = False Then
            Visuals.CenterItemOnScreen(grpPassword)
        End If
    End Sub

    'Private Sub GetADUsers()
    '    Dim ctx As New PrincipalContext(ContextType.Domain, "Hartville", "HartvilleAdmin", "H@rtv!lle-09")
    '    Dim grp As GroupPrincipal

    '    grp = GroupPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, "Teachers")

    '    If grp IsNot Nothing Then
    '        For Each p As Principal In grp.GetMembers(False)
    '            Dim usr As DirectoryEntry = p.GetUnderlyingObject

    '            MessageBox.Show(usr.Name)
    '            MessageBox.Show(usr.Properties("givenName").Value)
    '        Next
    '    End If
    'End Sub

    Private Sub gridViewRooms_CustomUnboundColumnData( sender As System.Object,  e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridViewRooms.CustomUnboundColumnData
        If e.IsGetData Then
            If e.Column.FieldName = "colVisible" then
                'Set the visible value initially to false
                e.Value = False

                'Check to see if the user has rights to the current room
                For Each rm As Room In Rooms
                    If userRooms.Count > 0 And userRooms.Count >= gridViewRoomSelector.GetDataSourceRowIndex(e.RowHandle)                     
                        If rm.Id = UserRooms(gridViewRoomSelector.GetDataSourceRowIndex(e.RowHandle)).Id then
                            e.Value = true
                        End If
                    End If
                Next
            End If
        Else If e.IsSetData then
            
        End If
End Sub
End Class