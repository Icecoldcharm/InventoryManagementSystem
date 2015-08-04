Imports InventoryLogic
Imports InventoryData


Public Class frmDistrictReport 

        Dim DistrictReportPrintout = New List(Of DistrictReport)
        Dim DistrictReportData as New List(Of DistrictReport)
        Dim newReportItem As New DistrictReport

        Dim avTotal As New Integer
        Dim computerTotal As New Integer
        Dim equipmentTotal As New Integer
        Dim furnitureTotal As New Integer
        Dim miscTechTotal As New Integer
        Dim monitorTotal As New Integer
        Dim printerTotal As New Integer
        Dim softwareTotal As New Integer
        Dim textbookTotal As New Integer

Private Sub btnLoadReport_Click( sender As System.Object,  e As System.EventArgs) Handles btnLoadReport.Click
         Using usrLogic As New UserLogic
            For Each usr As User in usrLogic.GetAllUsers(Session.Context)
                newReportItem = New DistrictReport()
                newReportItem.User = usr
                DistrictReportData.Add(newReportItem)
            Next

            lstUsers.DataSource = DistrictReportData
            lstUsers.DisplayMember = "UsersFullName"
            lstUsers.Refresh()

         End Using

End Sub

Private Sub frmDistrictReport_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm
End Sub

Private Sub lstUsers_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles lstUsers.SelectedIndexChanged
        dim curItem = new DistrictReport

        curItem = CType(lstUsers.SelectedItem, DistrictReport)

        'Clear out the total fields
        ClearTotalFields

        Using rmLogic As New RoomLogic
            lstRooms.DataSource = rmLogic.GetRoomsForUser(curItem.User, session.Context)
        End Using
End Sub

    Private Sub ClearTotalFields()
        lblAudioVideoData.Text = ""
        lblComputerData.Text = ""
        lblEquipmentData.Text = ""
        lblFurnitureData.Text = ""
        lblMiscTechData.Text = ""
        lblMonitorData.Text = ""
        lblPrinterData.Text = ""
        lblSoftwareData.Text = ""
        lblTextbookData.Text = ""
        lblTotalData.Text = ""
    End Sub

Private Sub lstRooms_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles lstRooms.SelectedIndexChanged
        For Each item As Room In lstRooms.SelectedItems

            Using AudioVideo As New AVLogic
                avTotal +=  AudioVideo.GetAudioVideoForRoom(item, Session.Context).Count
            End Using

            Using pc As New ComputerLogic
                computerTotal += pc.GetComputersForRoom(item, Session.Context).Count
            End Using

            Using equipLogic As New EquipmentLogic
                equipmentTotal += equipLogic.GetEquipmentForRoom(item, Session.Context).Count
            End Using

            Using furnLogic As New FurnitureLogic
                furnitureTotal += furnLogic.GetFurnitureForRoom(item, Session.Context).Count
            End Using

            Using miscLogic As New MiscTechLogic
                miscTechTotal += miscLogic.GetMiscTechForRoom(item, Session.Context).Count
            End Using

            Using monLogic As New MonitorLogic
                monitorTotal += monLogic.GetMonitorsForRoom(item, Session.Context).Count
            End Using

            Using printLogic As New PrinterLogic
                printerTotal += printLogic.GetPrintersForRoom(item, Session.Context).Count
            End Using

            Using softLogic As New SoftwareLogic
                softwareTotal += softLogic.GetSoftwareForRoom(item, Session.Context).Count
            End Using

            Using textLogic As New TextbookLogic
                textbookTotal += textLogic.GetTextbooksForRoom(item, Session.Context).Count
            End Using


            lblAudioVideoData.Text = avTotal
            lblComputerData.Text = computerTotal
            lblEquipmentData.Text = equipmentTotal
            lblFurnitureData.Text = furnitureTotal
            lblMiscTechData.Text = miscTechTotal
            lblMonitorData.Text = monitorTotal
            lblPrinterData.Text = printerTotal
            lblSoftwareData.Text = softwareTotal
            lblTextbookData.Text = textbookTotal

            lblTotalData.Text = avTotal + computerTotal + equipmentTotal + furnitureTotal + 
                                miscTechTotal + monitorTotal + printerTotal + softwareTotal + textbookTotal
        Next


End Sub

Private Sub btnPrintReport_Click( sender As System.Object,  e As System.EventArgs) Handles btnPrintReport.Click
          Using usrLogic As New UserLogic
            Using rmLogic As New RoomLogic

                avTotal = 0
                computerTotal = 0
                equipmentTotal = 0
                furnitureTotal = 0
                miscTechTotal = 0
                monitorTotal = 0
                printerTotal = 0
                softwareTotal = 0
                textbookTotal = 0

                Dim selectedUsers As New List(Of User)
                For Each rpt As DistrictReport In lstUsers.SelectedItems
                    selectedUsers.Add(rpt.User)
                Next

                For Each usr As User in selectedusers  
                    For Each rm In rmLogic.GetRoomsForUser(usr, Session.Context)
                        newReportItem = New DistrictReport()
                        newReportItem.User = usr
                        newReportItem.Room = rm

                        Using AudioVideo As New AVLogic
                            newReportItem.AVCount =  AudioVideo.GetAudioVideoForRoom(rm, Session.Context).Count
                            avTotal += newReportItem.AVCount
                        End Using

                        Using pc As New ComputerLogic
                            newReportItem.ComputerCount = pc.GetComputersForRoom(rm, Session.Context).Count
                            computerTotal += newReportItem.ComputerCount
                        End Using

                        Using equipLogic As New EquipmentLogic
                            newReportItem.EquipmentCount = equipLogic.GetEquipmentForRoom(rm, Session.Context).Count
                            equipmentTotal += newReportItem.EquipmentCount
                        End Using

                        Using furnLogic As New FurnitureLogic
                            newReportItem.FurnitureCount = furnLogic.GetFurnitureForRoom(rm, Session.Context).Count
                            furnitureTotal += newReportItem.FurnitureCount
                        End Using

                        Using miscLogic As New MiscTechLogic
                            newReportItem.MiscTechCount = miscLogic.GetMiscTechForRoom(rm, Session.Context).Count
                            miscTechTotal += newReportItem.MiscTechCount
                        End Using

                        Using monLogic As New MonitorLogic
                            newReportItem.MonitorCount = monLogic.GetMonitorsForRoom(rm, Session.Context).Count
                            monitorTotal += newReportItem.MonitorCount
                        End Using

                        Using printLogic As New PrinterLogic
                            newReportItem.PrinterCount = printLogic.GetPrintersForRoom(rm, Session.Context).Count
                            printerTotal += newReportItem.PrinterCount
                        End Using

                        Using softLogic As New SoftwareLogic
                            newReportItem.SoftwareCount = softLogic.GetSoftwareForRoom(rm, Session.Context).Count
                            softwareTotal += newReportItem.SoftwareCount
                        End Using

                        Using textLogic As New TextbookLogic
                            newReportItem.TextbookCount = textLogic.GetTextbooksForRoom(rm, Session.Context).Count
                            textbookTotal += newReportItem.TextbookCount
                        End Using

                        DistrictReportPrintout.Add(newReportItem)
                    Next
                Next

                'Add an item for the district Total
                Dim totalUser As New User
                Dim totalBuilding As New Building
                Dim totalRoom As New Room
                totalBuilding.Id = Guid.NewGuid()
                totalBuilding.BldName = "Hartville R-"
                totalRoom.Id = Guid.NewGuid()
                totalRoom.BldID = totalBuilding.Id
                totalUser.FirstName = "District"
                totalUser.LastName = "Total"
                Dim districtTotal As New DistrictReport
                districtTotal.AVCount = avTotal
                districtTotal.ComputerCount = computerTotal
                districtTotal.EquipmentCount = equipmentTotal
                districtTotal.FurnitureCount = furnitureTotal
                districtTotal.MiscTechCount = miscTechTotal
                districtTotal.MonitorCount = monitorTotal
                districtTotal.PrinterCount = printerTotal
                districtTotal.Room = New Room()
                districtTotal.SoftwareCount = softwareTotal
                districtTotal.TextbookCount = textbookTotal
                districtTotal.User = totalUser
                districtTotal.Room = totalRoom

                DistrictReportPrintout.Insert(0, districtTotal)

            End Using
         End Using

        Dim _DistrictOverview as New DistrictOverviewReport()

        _DistrictOverview.DataSource = DistrictReportPrintout
        _DistrictOverview.ShowPreview()

End Sub
End Class