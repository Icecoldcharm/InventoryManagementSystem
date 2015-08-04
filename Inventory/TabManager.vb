Imports InventoryLogic

Public Class TabManager

    Public Enum TabDefinition As Integer
        Login = 0
        Dashboard = 1
        Computers = 2
        Furniture = 3
        About = 4
        Users = 5
        Equipment = 6
        Textbooks = 7
        AV = 8
        Monitors = 9
        Printers = 10
        Software = 11
        MiscTech = 12
        Welcome = 13
        Password = 14
        SupportTicket = 15
        UserManager = 16
        DistrictReport = 17
    End Enum

    ''' <summary>
    ''' Display the specified tab and hide all others
    ''' </summary>
    ''' <param name="tabName"></param>
    ''' <remarks></remarks>
    Public Shared Sub ShowTab(ByVal tabName As TabDefinition)
        'Hide all tab pages
        HideAllTabs()

        Session.curTab = tabName

        Select Case tabName
            Case TabDefinition.About
                Session.AboutForm.Show()
            Case TabDefinition.AV
                Session.AVForm.Show()
            Case TabDefinition.Computers
                Session.ComputerForm.Show()
            Case TabDefinition.Equipment
                Session.EquipmentForm.Show()
            Case TabDefinition.Furniture
                Session.FurnitureForm.Show()
            Case TabDefinition.Login
                Session.LoginForm.Show()
            Case TabDefinition.MiscTech
                Session.MiscTechForm.Show()
            Case TabDefinition.Monitors
                Session.MonitorForm.Show()
            Case TabDefinition.Printers
                Session.PrinterForm.Show()
            Case TabDefinition.Software
                Session.SoftwareForm.Show()
            Case TabDefinition.Textbooks
                Session.TextbookForm.Show()
            Case TabDefinition.SupportTicket
                Session.SupportTicketForm.Show()
                Session.SupportTicketForm.GotoSupportSite()
            Case TabDefinition.Users
                Session.UserManagerForm.Show()
            Case TabDefinition.DistrictReport
                Session.DistrictReportForm.Show()
        End Select
    End Sub

    ''' <summary>
    ''' Hides all the tab pages for the given tab control
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared Sub HideAllTabs()
        Session.AboutForm.Hide()
        Session.AVForm.Hide()
        Session.ComputerForm.Hide()
        Session.EquipmentForm.Hide()
        Session.FurnitureForm.Hide()
        Session.LoginForm.Hide()
        Session.MiscTechForm.Hide()
        Session.MonitorForm.Hide()
        Session.PrinterForm.Hide()
        Session.SoftwareForm.Hide()
        Session.TextbookForm.Hide()
        Session.SupportTicketForm.Hide()
        Session.UserManagerForm.Hide()
    End Sub

    ''' <summary>
    ''' Display the computer tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayComputerTab(ByVal selectedItem As Integer)
        If Session.Computers Is Nothing Then
            Using pc As New ComputerLogic
                Session.Computers = pc.GetComputersForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        Session.ComputerForm.ComputerCollectionBinding.DataSource = Session.Computers
        Session.ComputerForm.gridPC.DataSource = Nothing
        Session.ComputerForm.gridPC.DataSource = Session.ComputerForm.ComputerCollectionBinding
        Session.ComputerForm.GridViewPC.BestFitColumns()

        TabManager.ShowTab(TabDefinition.Computers)

        'Select the first item in the grid
        Session.ComputerForm.SelectComputerItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the Misc Tech tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayMiscTechTab(ByVal selectedItem As Integer)
        If Session.MiscTech Is Nothing Then
            Using misc As New MiscTechLogic
                Session.MiscTech = misc.GetMiscTechForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.MiscTech)

        Session.MiscTechForm.MiscCollectionBinding.DataSource = Session.MiscTech
        Session.MiscTechForm.gridMisc.DataSource = Nothing
        Session.MiscTechForm.gridMisc.DataSource = Session.MiscTechForm.MiscCollectionBinding
        Session.MiscTechForm.GridViewMisc.BestFitColumns()

        'Select the first item in the grid
        Session.MiscTechForm.SelectMiscTechItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the Software tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplaySoftwareTab(ByVal selectedItem As Integer)
        If Session.Software Is Nothing Then
            Using sft As New SoftwareLogic
                Session.Software = sft.GetSoftwareForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Software)

        Session.SoftwareForm.SoftwareCollectionBinding.DataSource = Session.Software
        Session.SoftwareForm.gridSoftware.DataSource = Nothing
        Session.SoftwareForm.gridSoftware.DataSource = Session.SoftwareForm.SoftwareCollectionBinding
        Session.SoftwareForm.GridViewSoftware.BestFitColumns()

        'Select the first item in the grid
        Session.SoftwareForm.SelectSoftwareItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the Printers tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayPrintersTab(ByVal selectedItem As Integer)
        If Session.Printers Is Nothing Then
            Using prt As New PrinterLogic
                Session.Printers = prt.GetPrintersForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Printers)

        Session.PrinterForm.PrinterCollectionBinding.DataSource = Session.Printers
        Session.PrinterForm.gridPrinter.DataSource = Nothing
        Session.PrinterForm.gridPrinter.DataSource = Session.PrinterForm.PrinterCollectionBinding
        Session.PrinterForm.GridViewPrinter.BestFitColumns()

        'Select the first item in the grid
        Session.PrinterForm.SelectPrinterItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the Monitors tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayMonitorsTab(ByVal selectedItem As Integer)
        If Session.Monitors Is Nothing Then
            Using mon As New MonitorLogic
                Session.Monitors = mon.GetMonitorsForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Monitors)

        Session.MonitorForm.MonitorCollectionBinding.DataSource = Session.Monitors
        Session.MonitorForm.gridMonitor.DataSource = Nothing
        Session.MonitorForm.gridMonitor.DataSource = Session.MonitorForm.MonitorCollectionBinding
        Session.MonitorForm.GridViewMonitor.BestFitColumns()

        'Select the first item in the grid
        Session.MonitorForm.SelectMonitorItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the AV tab and select the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayAVTab(ByVal selectedItem As Integer)
        If Session.AV Is Nothing Then
            Using av As New AVLogic
                Session.AV = av.GetAudioVideoForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.AV)

        Session.AVForm.AVCollectionBinding.DataSource = Session.AV
        Session.AVForm.gridAV.DataSource = Nothing
        Session.AVForm.gridAV.DataSource = Session.AVForm.AVCollectionBinding
        Session.AVForm.GridViewAV.BestFitColumns()

        'Select the first item in the grid
        Session.AVForm.SelectAVItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the textbooks tab and selected the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayTextbooksTab(ByVal selectedItem As Integer)
        If Session.Textbooks Is Nothing Then
            Using textbk As New TextbookLogic
                Session.Textbooks = textbk.GetTextbooksForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Textbooks)

        Session.TextbookForm.TextbookCollectionBinding.DataSource = Session.Textbooks
        Session.TextbookForm.gridTextbook.DataSource = Nothing
        Session.TextbookForm.gridTextbook.DataSource = Session.TextbookForm.TextbookCollectionBinding
        Session.TextbookForm.GridViewTextbook.BestFitColumns()

        'Select the first item in the grid
        Session.TextbookForm.SelectTextbookItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the equipment tab and highlight the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayEquipmentTab(ByVal selectedItem As Integer)
        If Session.Equipment Is Nothing Then
            Using equip As New EquipmentLogic
                Session.Equipment = equip.GetEquipmentForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Equipment)

        Session.EquipmentForm.EquipmentCollectionBinding.DataSource = Session.Equipment
        Session.EquipmentForm.gridEquipment.DataSource = Nothing
        Session.EquipmentForm.gridEquipment.DataSource = Session.EquipmentForm.EquipmentCollectionBinding
        Session.EquipmentForm.GridViewEquipment.BestFitColumns()

        'Select the first item in the grid
        Session.EquipmentForm.SelectEquipmentItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the Furniture tab and highlight the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayFurnitureTab(ByVal selectedItem As Integer)
        If Session.Furniture Is Nothing Then
            Using furn As New FurnitureLogic
                Session.Furniture = furn.GetFurnitureForRoom(Session.curRoom, Session.Context)
            End Using
        End If

        TabManager.ShowTab(TabDefinition.Furniture)

        Session.FurnitureForm.FurnitureCollectionBinding.DataSource = Session.Furniture
        Session.FurnitureForm.gridFurniture.DataSource = Nothing
        Session.FurnitureForm.gridFurniture.DataSource = Session.FurnitureForm.FurnitureCollectionBinding
        Session.FurnitureForm.GridViewFurniture.BestFitColumns()

        'Select the first item in the grid
        Session.FurnitureForm.SelectFurnitureItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the User Manager tab and highlight the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayUserManagerTab(ByVal selectedItem As Integer)
        Using usr As New UserLogic
            Session.Users = usr.GetAllUsers(Session.Context)
        End Using

        TabManager.ShowTab(TabDefinition.Users)

        Session.UserManagerForm.UsersCollectionBinding.DataSource = Session.Users
        Session.UserManagerForm.gridUsers.DataSource = Nothing
        Session.UserManagerForm.gridUsers.DataSource = Session.UserManagerForm.UsersCollectionBinding
        Session.UserManagerForm.GridViewUsers.BestFitColumns()

        'Select the first item in the grid
        Session.UserManagerForm.SelectUserItem(selectedItem)
    End Sub

    ''' <summary>
    ''' Display the District Report tab and highlight the specified item
    ''' </summary>
    ''' <param name="selectedItem"></param>
    ''' <remarks></remarks>
    Public Shared Sub DisplayDistrictReportTab(ByVal selectedItem As Integer)
        Using usr As New UserLogic
            Session.Users = usr.GetAllUsers(Session.Context)
        End Using

        TabManager.ShowTab(TabDefinition.DistrictReport)

        'Select the first item in the grid
        Session.UserManagerForm.SelectUserItem(selectedItem)
    End Sub
End Class
