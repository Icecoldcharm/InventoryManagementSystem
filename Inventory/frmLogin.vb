Imports InventoryLogic
Imports Inventory.TabManager
Imports InventoryData
Imports System.DirectoryServices.AccountManagement

Public Class frmLogin

    Private Sub btnLoginOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginOK.Click
        Login()
    End Sub

    ''' <summary>
    ''' Authenticate against the user table in the inventory database
    ''' </summary>
    ''' <remarks></remarks>
    Private Function DBLogin() As User
        Dim usrLogic As New UserLogic

        Return usrLogic.Login(txtLoginUser.Text, txtLoginPassword.Text, Session.Context)
    End Function

    ''' <summary>
    ''' Active Directory Login
    ''' </summary>
    ''' <remarks></remarks>
    Private Function ADLogin() As User
        Dim pc As New PrincipalContext(ContextType.Domain, "Hartville")
        Dim validLogin As Boolean = False
        Dim usrLogic As New UserLogic

        validLogin = pc.ValidateCredentials(txtLoginUser.Text, txtLoginPassword.Text)

        If validLogin Then
            Return usrLogic.ADLogin(txtLoginUser.Text, Session.Context)
        Else
            Return Nothing
        End If
    End Function


    Private Sub Login()
        groupLoginFailed.Visible = False

        Using usrLogic As New UserLogic
            Session.curUser = ADLogin()

            If Session.curUser Is Nothing Then
                Session.MainForm.StatusBarUserImage = My.Resources.status_offline
                Session.MainForm.StatusBarUserText = "No User Logged In"
                groupLoginFailed.Visible = True
                txtLoginUser.Text = String.Empty
                txtLoginPassword.Text = String.Empty
                txtLoginUser.Focus()
                Exit Sub
            Else
                Session.MainForm.StatusBarUserImage = My.Resources.user
                Session.MainForm.StatusBarUserText = Session.curUser.ToString
                lblLogoutUser.Text = Session.curUser.ToString
                groupLogin.Visible = False
                groupLogout.Visible = True

                'Load the user's grid settings
                Session.MainForm.LoadGridLayout()

                'Update the information pane
                Session.MainForm.StatusBarUserImage = My.Resources.status_online
                Session.MainForm.StatusBarUserText = String.Format("{0} {1}", Session.curUser.FirstName, Session.curUser.LastName)

                'Show items for logged in users
                Session.MainForm.UpdateRibbonForUser()

                'Display the change password tab if the user is still using the default password
                If Session.curUser.Password = "inventory" Then
                    TabManager.ShowTab(TabDefinition.Password)
                Else
                    TabManager.ShowTab(TabDefinition.About)
                End If
            End If

            'Load the list of buildings
            Using bldLogic As New BuildingLogic
                Session.buildings = bldLogic.GetAllBuildings(Session.Context)
            End Using

            Using rmLogic As New RoomLogic
                Session.rooms = rmLogic.GetRoomsForUser(Session.curUser, Session.Context)
                Session.MainForm.cboInvCurrentRoom.Items.AddRange(Session.rooms)

                'Select the user's first room if they have any rooms assigned to them
                If Session.MainForm.cboInvCurrentRoom.Items.Count > 0 Then
                    Session.MainForm.barInvRoom.EditValue = Session.MainForm.cboInvCurrentRoom.Items(0)
                End If
            End Using
        End Using
    End Sub

    Private Sub frmLogin_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If IsInitializing = False Then
            Visuals.CenterItemOnScreen(groupLogin)
            Visuals.CenterItemOnScreen(groupLogout)
        End If

        'Resize the failed login box
        groupLoginFailed.Left = groupLogin.Left
        groupLoginFailed.Top = groupLogin.Top + groupLogin.Height + 20
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Session.curUser = Nothing
        groupLogout.Visible = False
        groupLogin.Visible = True

        Session.MainForm.lblStatusUser.Glyph = My.Resources.status_offline
        Session.MainForm.lblStatusUser.Caption = "No User Logged In"

        'Hide items for logged in users
        Session.MainForm.groupOverview.Visible = False
        Session.MainForm.pageInventory.Visible = False
    End Sub

    ''' <summary>
    ''' Allow the user to login by pressing the enter key after the password has been entered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtLoginPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLoginPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm
    End Sub
End Class