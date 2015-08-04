Imports InventoryData
Imports InventoryLogic
Imports Inventory.TabManager
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMain

    ''' <summary>
    ''' Gets/Sets the caption for the user label on the main status bar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StatusBarUserText() As String
        Get
            Return lblStatusUser.Caption
        End Get
        Set(ByVal value As String)
            lblStatusUser.Caption = value
        End Set
    End Property

    ''' <summary>
    ''' Gets/Sets the image for the user label on the main status bar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property StatusBarUserImage() As Image
        Get
            Return lblStatusUser.Glyph
        End Get
        Set(ByVal value As Image)
            lblStatusUser.Glyph = value
        End Set
    End Property

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Hide the welcome form
        frmWelcome.Close()

        'Register the DevExpress skins
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.OfficeSkins.Register()

        'Prepare entity spaces for use
        Startup.Connect()

        'Set the Application version in the Application Menu
        Dim appVer As String = My.Application.Info.Version.ToString().Substring(0, My.Application.Info.Version.ToString().Length - 2)

        lblApplicationVersion.Caption = "Version: " + appVer

        tmrLoginFocus.Enabled = True

        TabManager.ShowTab(TabDefinition.Login)
    End Sub

    ''' <summary>
    ''' Display the login tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnMainLogin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMainLogin.ItemClick
        TabManager.ShowTab(TabDefinition.Login)
    End Sub

    ''' <summary>
    ''' Get data for the newly selected room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub barInvRoom_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barInvRoom.EditValueChanged
        'Save our current data before proceeding
        SaveChanges()

        Session.curRoom = CType(barInvRoom.EditValue, Room)

        'Update our room binding
        RoomBinding.DataSource = Session.curRoom

        'Update our local data to reflect the room change
        UpdateData()
    End Sub

    ''' <summary>
    ''' Update the local data to match the seleted room
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateData()
        Session.AV = Nothing
        Session.Computers = Nothing
        Session.Equipment = Nothing
        Session.Furniture = Nothing
        Session.MiscTech = Nothing
        Session.Monitors = Nothing
        Session.Printers = Nothing
        Session.Software = Nothing
        Session.Textbooks = Nothing

        'Update the current tab's data
        Select Case Session.curTab
            Case TabDefinition.AV
                DisplayAVTab(0)
            Case TabDefinition.Computers
                DisplayComputerTab(0)
            Case TabDefinition.Equipment
                DisplayEquipmentTab(0)
            Case TabDefinition.Furniture
                DisplayFurnitureTab(0)
            Case TabDefinition.MiscTech
                DisplayMiscTechTab(0)
            Case TabDefinition.Monitors
                DisplayMonitorsTab(0)
            Case TabDefinition.Printers
                DisplayPrintersTab(0)
            Case TabDefinition.Software
                DisplaySoftwareTab(0)
            Case TabDefinition.Textbooks
                DisplayTextbooksTab(0)
        End Select
    End Sub

    ''' <summary>
    ''' Display the Computer tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechComputers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechComputers.ItemClick
        TabManager.DisplayComputerTab(0)
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
    ''' Add a technology item to the room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvTechAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvTechAdd.ItemClick
        Try
            Select Case Session.curTab
                Case TabDefinition.Computers
                    'Display the new item
                    TabManager.DisplayComputerTab(0)
                    Session.ComputerForm.AddComputer()
                Case TabDefinition.AV
                    'Display the new item
                    TabManager.DisplayAVTab(0)
                    Session.AVForm.AddAV()
                Case TabDefinition.Monitors
                    'Display the new item
                    TabManager.DisplayMonitorsTab(0)
                    Session.MonitorForm.AddMonitor()
                Case TabDefinition.Printers
                    'Display the new item
                    TabManager.DisplayPrintersTab(0)
                    Session.PrinterForm.AddPrinter()
                Case TabDefinition.Software
                    'Display the new item
                    TabManager.DisplaySoftwareTab(0)
                    Session.SoftwareForm.AddSoftware()
                Case TabDefinition.MiscTech
                    'Display the new item
                    TabManager.DisplayMiscTechTab(0)
                    Session.MiscTechForm.AddMiscTech()
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Try to delete the currently selected technology item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvTechRemove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvTechRemove.ItemClick
        If MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Select Case Session.curTab
                Case TabDefinition.Computers
                    Try
                        Session.Computers.Remove(Session.curComputer)
                        Session.Context.Computers.DeleteObject(Session.curComputer)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
                Case TabDefinition.AV
                    Try
                        Session.AV.Remove(Session.curAV)
                        Session.Context.AudioVideos.DeleteObject(Session.curAV)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
                Case TabDefinition.Monitors
                    Try
                        Session.Monitors.Remove(Session.curMonitor)
                        Session.Context.Monitors.DeleteObject(Session.curMonitor)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
                Case TabDefinition.Printers
                    Try
                        Session.Printers.Remove(Session.curPrinter)
                        Session.Context.Printers.DeleteObject(Session.curPrinter)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
                Case TabDefinition.Software
                    Try
                        Session.Software.Remove(Session.curSoftware)
                        Session.Context.Softwares.DeleteObject(Session.curSoftware)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
                Case TabDefinition.MiscTech
                    Try
                        Session.MiscTech.Remove(Session.curMiscTech)
                        Session.Context.MiscTechnologies.DeleteObject(Session.curMiscTech)
                        Session.Context.SaveChanges()
                    Catch ex As Exception
                        MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
                    End Try
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Display the furniture for the selected room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvFurniture_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvFurniture.ItemClick
        DisplayFurnitureTab(0)
    End Sub

    ''' <summary>
    ''' Add a Furniture item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvFurnitureAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvFurnitureAdd.ItemClick
        'Display the furniture tab
        TabManager.DisplayFurnitureTab(0)
        Session.FurnitureForm.AddFurniture()
    End Sub

    ''' <summary>
    ''' Remove a Furniture item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvFurnitureRemove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvFurnitureRemove.ItemClick
        If MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Try
                Session.Furniture.Remove(Session.curFurniture)
                Session.Context.Furnitures.DeleteObject(Session.curFurniture)
                Session.Context.SaveChanges()
            Catch ex As Exception
                MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Display the Equipment tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvEquipment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvEquipment.ItemClick
        DisplayEquipmentTab(0)
    End Sub

    ''' <summary>
    ''' Display the Textbook tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvTextbooks_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvTextbooks.ItemClick
        DisplayTextbooksTab(0)
    End Sub

    ''' <summary>
    ''' Display the Audio/Video tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechAV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechAV.ItemClick
        DisplayAVTab(0)
    End Sub

    ''' <summary>
    ''' Display the Monitor tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechMonitors_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechMonitors.ItemClick
        DisplayMonitorsTab(0)
    End Sub

    ''' <summary>
    ''' Display the Printer tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechPrinters_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechPrinters.ItemClick
        DisplayPrintersTab(0)
    End Sub

    ''' <summary>
    ''' Display the Software tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechSoftware_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechSoftware.ItemClick
        DisplaySoftwareTab(0)
    End Sub

    ''' <summary>
    ''' Display the Miscellaneous Technology tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTechMisc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTechMisc.ItemClick
        DisplayMiscTechTab(0)
    End Sub

    ''' <summary>
    ''' Add a new Equipment item and display it's properties
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvEquipmentAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvEquipmentAdd.ItemClick
        TabManager.DisplayEquipmentTab(0)
        Session.EquipmentForm.AddEquipment()
    End Sub

    ''' <summary>
    ''' Add a new Textbook item and display it's properties
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvTextbooksAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvTextbooksAdd.ItemClick
        'Display the new item
        TabManager.DisplayTextbooksTab(0)
        Session.TextbookForm.AddTextbook()
    End Sub

    ''' <summary>
    ''' Remove a Equipment item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvEquipmentRemove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvEquipmentRemove.ItemClick
        If MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Try
                Session.Equipment.Remove(Session.curEquipment)
                Session.Context.Equipments.DeleteObject(Session.curEquipment)
                Session.Context.SaveChanges()
            Catch ex As Exception
                MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Remove a Textbook item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInvTextbooksRemove_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvTextbooksRemove.ItemClick
        If MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Try
                Session.Textbooks.Remove(Session.curTextbook)
                Session.Context.Textbooks.DeleteObject(Session.curTextbook)
                Session.Context.SaveChanges()
            Catch ex As Exception
                MsgBox("An error occured while deleting the item.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Display the About tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHelpAbout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHelpAbout.ItemClick
        TabManager.ShowTab(TabDefinition.About)
    End Sub

    ''' <summary>
    ''' Focus the login username field after the program has loaded
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrLoginFocus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoginFocus.Tick
        tmrLoginFocus.Enabled = False
        Session.LoginForm.txtLoginUser.Focus()
    End Sub

    ''' <summary>
    ''' End the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        If UnsavedChanges() = True Then
            If MsgBox("There are unsaved changes. Do you want to save before closing?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel, "Unsaved Changes") = vbYes Then
                SaveChanges()
            End If
        End If

        End
    End Sub

    ''' <summary>
    ''' Display the Help Ticket tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHelpTicket_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHelpTicket.ItemClick
        TabManager.ShowTab(TabDefinition.SupportTicket)
    End Sub

    ''' <summary>
    ''' Check for unsaved changes before closing the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            SaveGridLayout()
            Application.Exit()
        Catch ex As Exception
            'Ignore this error. The application is closing
        End Try

        If UnsavedChanges() = True Then
            Dim result As New MsgBoxResult

            result = MsgBox("There are unsaved changes, would you like to save now?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)

            If result = MsgBoxResult.Yes Then
                If SaveChanges() = False Then
                    MsgBox("Changes failed to save.", MsgBoxStyle.Critical)
                    e.Cancel = True
                End If
            ElseIf result = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Check for unsaved changes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function UnsavedChanges() As Boolean
        'Check for changes in all categories
        If Session.Context IsNot Nothing
            Return Session.Context.ObjectStateManager.GetObjectStateEntries(EntityState.Added or EntityState.Deleted or EntityState.Modified).Any()
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Save all changes
    ''' </summary>
    ''' <remarks></remarks>
    Private Function SaveChanges() As Boolean
        Try
            Session.Context.SaveChanges()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Save all changed inventory objects
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInventorySave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventorySave.ItemClick
        If SaveChanges() = True Then
            lblChangesSaved.Glyph = My.Resources.Save_64
            lblChangesSaved.Caption = "All Changes Saved"
        End If

        'Save our grid layouts
        SaveGridLayout()
    End Sub

    ''' <summary>
    ''' Updates the status bar save status
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tmrSaveCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSaveCheck.Tick
        If UnsavedChanges() = True Then
            lblChangesSaved.Glyph = My.Resources.Alert
            lblChangesSaved.Caption = "Unsaved Changes"
        Else
            lblChangesSaved.Glyph = My.Resources.Save_64
            lblChangesSaved.Caption = "All Changes Saved"
        End If
    End Sub

    ''' <summary>
    ''' Load all grid view layouts from xml files
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadGridLayout()
        Using gridMan As New GridSettingsLogic
            gridMan.LoadGridSettings(Session.curUser, Session.ComputerForm.GridViewPC)
            gridMan.LoadGridSettings(Session.curUser, Session.FurnitureForm.GridViewFurniture)
            gridMan.LoadGridSettings(Session.curUser, Session.EquipmentForm.GridViewEquipment)
            gridMan.LoadGridSettings(Session.curUser, Session.TextbookForm.GridViewTextbook)
            gridMan.LoadGridSettings(Session.curUser, Session.AVForm.GridViewAV)
            gridMan.LoadGridSettings(Session.curUser, Session.MonitorForm.GridViewMonitor)
            gridMan.LoadGridSettings(Session.curUser, Session.PrinterForm.GridViewPrinter)
            gridMan.LoadGridSettings(Session.curUser, Session.SoftwareForm.GridViewSoftware)
            gridMan.LoadGridSettings(Session.curUser, Session.MiscTechForm.GridViewMisc)
        End Using
    End Sub

    ''' <summary>
    ''' Save all grid view layouts to xml files
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveGridLayout()
        Using gridMan As New GridSettingsLogic
            gridMan.SaveGridSettings(Session.curUser, Session.ComputerForm.GridViewPC)
            gridMan.SaveGridSettings(Session.curUser, Session.FurnitureForm.GridViewFurniture)
            gridMan.SaveGridSettings(Session.curUser, Session.EquipmentForm.GridViewEquipment)
            gridMan.SaveGridSettings(Session.curUser, Session.TextbookForm.GridViewTextbook)
            gridMan.SaveGridSettings(Session.curUser, Session.AVForm.GridViewAV)
            gridMan.SaveGridSettings(Session.curUser, Session.MonitorForm.GridViewMonitor)
            gridMan.SaveGridSettings(Session.curUser, Session.PrinterForm.GridViewPrinter)
            gridMan.SaveGridSettings(Session.curUser, Session.SoftwareForm.GridViewSoftware)
            gridMan.SaveGridSettings(Session.curUser, Session.MiscTechForm.GridViewMisc)
        End Using
    End Sub

    ''' <summary>
    ''' Update the ribbon for the currently logged in user
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateRibbonForUser()
        Select Case Session.curUser.AccountType
            Case "Administrator"
                RibbonControl.SelectedPage = pageInventory
                groupOverview.Visible = True
                pageInventory.Visible = True
                pageManagement.Visible = True
            Case Else
                RibbonControl.SelectedPage = pageInventory
                groupOverview.Visible = True
                pageInventory.Visible = True
        End Select
    End Sub

    ''' <summary>
    ''' Print the Computer Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechComputers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechComputers.ItemClick
        Session.PrintManager.PrintComputerReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Audio/Video Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechAV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechAV.ItemClick
        Session.PrintManager.PrintAudioVideoReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Monitor Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechMonitors_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechMonitors.ItemClick
        Session.PrintManager.PrintMonitorReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Printer Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechPrinters_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechPrinters.ItemClick
        Session.PrintManager.PrintPrinterReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Software Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechSoftware_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechSoftware.ItemClick
        Session.PrintManager.PrintSoftwareReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Miscellaneous Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTechMisc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTechMisc.ItemClick
        Session.PrintManager.PrintMiscTechReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Furniture Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintFurniture_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintFurniture.ItemClick
        Session.PrintManager.PrintFurnitureReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Equipment Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintEquipment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintEquipment.ItemClick
        Session.PrintManager.PrintEquipmemtReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Print the Textbook Report for the current room
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintTextbooks_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintTextbooks.ItemClick
        Session.PrintManager.PrintTextbookReportForRoom(Session.curRoom)
    End Sub

    ''' <summary>
    ''' Display the User Editor Tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnMgmtUsers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMgmtUsers.ItemClick
        DisplayUserManagerTab(0)
    End Sub

    ''' <summary>
    ''' Print the entire room's inventory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintRoom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintRoom.ItemClick
        Session.PrintManager.PrintRoomReportForRoom(Session.curRoom)
    End Sub
End Class