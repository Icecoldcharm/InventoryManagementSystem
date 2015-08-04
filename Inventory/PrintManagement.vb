Imports InventoryLogic
Imports InventoryData

Public Class PrintManagement

    ''' <summary>
    ''' Build and display a Computer report for the specified room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintComputerReportForRoom(ByVal rm As Room)
        Dim pcReport As New ComputerReport

        If Session.Computers Is Nothing Then
            Using pc As New ComputerLogic
                Session.Computers = pc.GetComputersForRoom(rm, Session.Context)
            End Using
        End If

        Session.ComputerForm.ComputerCollectionBinding.DataSource = Session.Computers

        pcReport.DataSource = Session.ComputerForm.ComputerCollectionBinding
        pcReport.Room.Value = Session.curRoom.FullName
        pcReport.User.Value = Session.curUser.ToString

        pcReport.RequestParameters = False
        pcReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Audio/Video report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintAudioVideoReportForRoom(ByVal rm As Room)
        Dim avReport As New AudioVideoReport

        If Session.AV Is Nothing Then
            Using av As New AVLogic
                Session.AV = av.GetAudioVideoForRoom(rm, Session.Context)
            End Using
        End If

        Session.AVForm.AVCollectionBinding.DataSource = Session.AV

        avReport.DataSource = Session.AVForm.AVCollectionBinding
        avReport.Room.Value = Session.curRoom.FullName
        avReport.User.Value = Session.curUser.ToString

        avReport.RequestParameters = False
        avReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Monitor report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintMonitorReportForRoom(ByVal rm As Room)
        Dim monReport As New MonitorReport

        If Session.Monitors Is Nothing Then
            Using mon As New MonitorLogic
                Session.Monitors = mon.GetMonitorsForRoom(rm, Session.Context)
            End Using
        End If

        Session.MonitorForm.MonitorCollectionBinding.DataSource = Session.Monitors

        monReport.DataSource = Session.MonitorForm.MonitorCollectionBinding
        monReport.Room.Value = Session.curRoom.FullName
        monReport.User.Value = Session.curUser.ToString

        monReport.RequestParameters = False
        monReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Printer report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintPrinterReportForRoom(ByVal rm As Room)
        Dim prtReport As New PrinterReport

        If Session.Printers Is Nothing Then
            Using prt As New PrinterLogic
                Session.Printers = prt.GetPrintersForRoom(rm, Session.Context)
            End Using
        End If

        Session.PrinterForm.PrinterCollectionBinding.DataSource = Session.Printers

        prtReport.DataSource = Session.PrinterForm.PrinterCollectionBinding
        prtReport.Room.Value = Session.curRoom.FullName
        prtReport.User.Value = Session.curUser.ToString

        prtReport.RequestParameters = False
        prtReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Software report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintSoftwareReportForRoom(ByVal rm As Room)
        Dim SoftReport As New SoftwareReport

        If Session.Software Is Nothing Then
            Using sft As New SoftwareLogic
                Session.Software = sft.GetSoftwareForRoom(rm, Session.Context)
            End Using
        End If

        Session.SoftwareForm.SoftwareCollectionBinding.DataSource = Session.Software

        SoftReport.DataSource = Session.SoftwareForm.SoftwareCollectionBinding
        SoftReport.Room.Value = Session.curRoom.FullName
        SoftReport.User.Value = Session.curUser.ToString

        SoftReport.RequestParameters = False
        SoftReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Miscellaneous Technology report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintMiscTechReportForRoom(ByVal rm As Room)
        Dim MiscReport As New MiscTechReport

        If Session.MiscTech Is Nothing Then
            Using msc As New MiscTechLogic
                Session.MiscTech = msc.GetMiscTechForRoom(rm, Session.Context)
            End Using
        End If

        Session.MiscTechForm.MiscCollectionBinding.DataSource = Session.MiscTech

        MiscReport.DataSource = Session.MiscTechForm.MiscCollectionBinding
        MiscReport.Room.Value = Session.curRoom.FullName
        MiscReport.User.Value = Session.curUser.ToString

        MiscReport.RequestParameters = False
        MiscReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Furniture report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintFurnitureReportForRoom(ByVal rm As Room)
        Dim FurnReport As New FurnitureReport

        If Session.Furniture Is Nothing Then
            Using frn As New FurnitureLogic
                Session.Furniture = frn.GetFurnitureForRoom(rm, Session.Context)
            End Using
        End If

        Session.FurnitureForm.FurnitureCollectionBinding.DataSource = Session.Furniture

        FurnReport.DataSource = Session.FurnitureForm.FurnitureCollectionBinding
        FurnReport.Room.Value = Session.curRoom.FullName
        FurnReport.User.Value = Session.curUser.ToString

        FurnReport.RequestParameters = False
        FurnReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Equipment report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintEquipmemtReportForRoom(ByVal rm As Room)
        Dim EquipReport As New EquipmentReport

        If Session.Equipment Is Nothing Then
            Using eqp As New EquipmentLogic
                Session.Equipment = eqp.GetEquipmentForRoom(rm, Session.Context)
            End Using
        End If

        Session.EquipmentForm.EquipmentCollectionBinding.DataSource = Session.Equipment

        EquipReport.DataSource = Session.EquipmentForm.EquipmentCollectionBinding
        EquipReport.Room.Value = Session.curRoom.FullName
        EquipReport.User.Value = Session.curUser.ToString

        EquipReport.RequestParameters = False
        EquipReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Textbook report for the given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintTextbookReportForRoom(ByVal rm As Room)
        Dim txtReport As New TextbookReport

        If Session.Textbooks Is Nothing Then
            Using txt As New TextbookLogic
                Session.Textbooks = txt.GetTextbooksForRoom(rm, Session.Context)
            End Using
        End If

        Session.TextbookForm.TextbookCollectionBinding.DataSource = Session.Textbooks

        txtReport.DataSource = Session.TextbookForm.TextbookCollectionBinding
        txtReport.Room.Value = Session.curRoom.FullName
        txtReport.User.Value = Session.curUser.ToString

        txtReport.RequestParameters = False
        txtReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Build and display a Room Report for a given room
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Public Sub PrintRoomReportForRoom(ByVal rm As Room)
        Dim rmReport As New RoomReport

        CheckForNullValues(rm)

        rmReport.Room.Value = Session.curRoom.FullName
        rmReport.User.Value = Session.curUser.ToString

        rmReport.bindingAudioVideo.DataSource = Session.AV
        rmReport.bindingComputer.DataSource = Session.Computers
        rmReport.bindingEquipment.DataSource = Session.Equipment
        rmReport.bindingFurniture.DataSource = Session.Furniture
        rmReport.bindingMiscTech.DataSource = Session.MiscTech
        rmReport.bindingMonitor.DataSource = Session.Monitors
        rmReport.bindingPrinter.DataSource = Session.Printers
        rmReport.bindingSoftware.DataSource = Session.Software
        rmReport.bindingTextbooks.DataSource = Session.Textbooks

        rmReport.RequestParameters = False
        rmReport.ShowPreview()
    End Sub

    ''' <summary>
    ''' Check for any null values
    ''' </summary>
    ''' <param name="rm"></param>
    ''' <remarks></remarks>
    Private Sub CheckForNullValues(ByVal rm As Room)

        If Session.Computers Is Nothing Then
            Using pc As New ComputerLogic
                Session.Computers = pc.GetComputersForRoom(rm, Session.Context)
            End Using
        End If

        If Session.AV Is Nothing Then
            Using av As New AVLogic
                Session.AV = av.GetAudioVideoForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Monitors Is Nothing Then
            Using mon As New MonitorLogic
                Session.Monitors = mon.GetMonitorsForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Printers Is Nothing Then
            Using prt As New PrinterLogic
                Session.Printers = prt.GetPrintersForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Software Is Nothing Then
            Using sft As New SoftwareLogic
                Session.Software = sft.GetSoftwareForRoom(rm, Session.Context)
            End Using
        End If

        If Session.MiscTech Is Nothing Then
            Using msc As New MiscTechLogic
                Session.MiscTech = msc.GetMiscTechForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Furniture Is Nothing Then
            Using frn As New FurnitureLogic
                Session.Furniture = frn.GetFurnitureForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Equipment Is Nothing Then
            Using eqp As New EquipmentLogic
                Session.Equipment = eqp.GetEquipmentForRoom(rm, Session.Context)
            End Using
        End If

        If Session.Textbooks Is Nothing Then
            Using txt As New TextbookLogic
                Session.Textbooks = txt.GetTextbooksForRoom(rm, Session.Context)
            End Using
        End If

    End Sub
End Class
