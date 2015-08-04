Imports InventoryData

Public Class RoomReport

    Private Sub DetailComputers_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailComputers.BeforePrint
        Dim curItem As New Computer

        curItem = CType(DetailReportComputers.GetCurrentRow(), Computer)

        If curItem Is Nothing Then 
            ClearComputerFields()
            Exit Sub
        End If        

        If curItem.Brand = String.Empty Then
            lblBrandPC1.Text = Nothing
            lblBrandPC2.Text = Nothing
        Else
            lblBrandPC1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelPC1.Text = Nothing
            lblModelPC2.Text = Nothing
        Else
            lblModelPC1.Text = "Model:"
        End If

        If curItem.Os = String.Empty Then
            lblOSPC1.Text = Nothing
            lblOSPC2.Text = Nothing
        Else
            lblOSPC1.Text = "Operating System:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialPC1.Text = Nothing
            lblSerialPC2.Text = Nothing
        Else
            lblSerialPC1.Text = "Serial #:"
        End If

        If curItem.Ram = String.Empty Then
            lblRAMPC1.Text = Nothing
            lblRAMPC2.Text = Nothing
        Else
            lblRAMPC1.Text = "RAM:"
        End If

        If curItem.WinLicense = String.Empty Then
            lblLicensePC1.Text = Nothing
            lblLicensePC2.Text = Nothing
        Else
            lblLicensePC1.Text = "License:"
        End If

        If curItem.Cost is Nothing Then
            lblCostPC1.Text = Nothing
            lblCostPC2.Text = Nothing
        Else
            lblCostPC1.Text = "Cost:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundPC1.Text = Nothing
            lblFundPC2.Text = Nothing
        Else
            lblFundPC1.Text = "Fund Source:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionPC1.Text = Nothing
            lblDescriptionPC2.Text = Nothing
        Else
            lblDescriptionPC1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentPC1.Text = Nothing
            lblCommentPC2.Text = Nothing
        Else
            lblCommentPC1.Text = "Comment:"
        End If
    End Sub

    Private Sub DetailAudioVideo_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailAudioVideo.BeforePrint
        Dim curItem As New AudioVideo

        curItem = CType(DetailReportAudioVideo.GetCurrentRow(), AudioVideo)

        If curItem Is Nothing Then 
            ClearAudioVideoFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrand1.Text = Nothing
            lblBrand2.Text = Nothing
        Else
            lblBrand1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModel1.Text = Nothing
            lblModel2.Text = Nothing
        Else
            lblModel1.Text = "Model:"
        End If

        If curItem.Type = String.Empty Then
            lblType1.Text = Nothing
            lblType2.Text = Nothing
        Else
            lblType1.Text = "Type:"
        End If

        If curItem.DatePurchased Is Nothing Then
            lblDatePurchased1.Text = Nothing
            lblDatePurchased2.Text = Nothing
        Else
            lblDatePurchased1.Text = "Date Purchased:"
        End If

        If curItem.Condition = String.Empty Then
            lblCondition1.Text = Nothing
            lblCondition2.Text = Nothing
        Else
            lblCondition1.Text = "Condition:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerial1.Text = Nothing
            lblSerial2.Text = Nothing
        Else
            lblSerial1.Text = "Serial:"
        End If

        If curItem.Cost Is Nothing Then
            lblCost1.Text = Nothing
            lblCost2.Text = Nothing
        Else
            lblCost1.Text = "Cost:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundSource1.Text = Nothing
            lblFundSource2.Text = Nothing
        Else
            lblFundSource1.Text = "Fund Source:"
        End If

        If curItem.Description = String.Empty Then
            lblDescription1.Text = Nothing
            lblDescription2.Text = Nothing
        Else
            lblDescription1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblComments1.Text = Nothing
            lblComments2.Text = Nothing
        Else
            lblComments1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailEquipment_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailEquipment.BeforePrint
        Dim curItem As New Equipment

        curItem = CType(DetailReportEquipment.GetCurrentRow(), Equipment)

        If curItem Is Nothing Then
            ClearEquipmentFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandEquipment1.Text = Nothing
            lblBrandEquipment2.Text = Nothing
        Else
            lblBrandEquipment1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelEquipment1.Text = Nothing
            lblModelEquipment1.Text = Nothing
        Else
            lblModelEquipment1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionEquipment1.Text = Nothing
            lblConditionEquipment1.Text = Nothing
        Else
            lblConditionEquipment1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDateEquipment1.Text = Nothing
            lblDateEquipment2.Text = Nothing
        Else
            lblDateEquipment1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialEquipment1.Text = Nothing
            lblSerialEquipment2.Text = Nothing
        Else
            lblSerialEquipment1.Text = "Serial #:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundEquipment1.Text = Nothing
            lblFundEquipment2.Text = Nothing
        Else
            lblFundEquipment1.Text = "Fund Source:"
        End If

        If curItem.Cost is nothing Then
            lblCostEquipment1.Text = Nothing
            lblCostEquipment2.Text = Nothing
        Else
            lblCostEquipment1.Text = "Cost:"
        End If

        If curItem.Quantity is nothing Then
            lblQuantityEquipment1.Text = Nothing
            lblQuantityEquipment2.Text = Nothing
        Else
            lblQuantityEquipment1.Text = "Quantity:"
        End If

        If curItem.Total = 0 Then
            lblTotalEquipment1.Text = Nothing
            lblTotalEquipment2.Text = Nothing
        Else
            lblTotalEquipment1.Text = "Total Cost:"
        End If

        If curItem.Type = String.Empty Then
            lblTypeEquipment1.Text = Nothing
            lblTypeEquipment2.Text = Nothing
        Else
            lblTypeEquipment1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionEquipment1.Text = Nothing
            lblDescriptionEquipment2.Text = Nothing
        Else
            lblDescriptionEquipment1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsEquipment1.Text = Nothing
            lblCommentsEquipment1.Text = Nothing
        Else
            lblCommentsEquipment1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailFurniture_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailFurniture.BeforePrint
        Dim curItem As New Furniture

        curItem = CType(DetailReportFurniture.GetCurrentRow(), Furniture)

        If curItem Is Nothing Then
            ClearFurnitureFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandFurniture1.Text = Nothing
            lblBrandFurniture2.Text = Nothing
        Else
            lblBrandFurniture1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelFurniture1.Text = Nothing
            lblModelFurniture1.Text = Nothing
        Else
            lblModelFurniture1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionFurniture1.Text = Nothing
            lblConditionFurniture1.Text = Nothing
        Else
            lblConditionFurniture1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDateFurniture1.Text = Nothing
            lblDateFurniture2.Text = Nothing
        Else
            lblDateFurniture1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialFurniture1.Text = Nothing
            lblSerialFurniture2.Text = Nothing
        Else
            lblSerialFurniture1.Text = "Serial #:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundFurniture1.Text = Nothing
            lblFundFurniture2.Text = Nothing
        Else
            lblFundFurniture1.Text = "Fund Source:"
        End If

        If curItem.Cost is nothing Then
            lblCostFurniture1.Text = Nothing
            lblCostFurniture2.Text = Nothing
        Else
            lblCostFurniture1.Text = "Cost:"
        End If

        If curItem.Quantity is nothing Then
            lblQuantityFurniture1.Text = Nothing
            lblQuantityFurniture2.Text = Nothing
        Else
            lblQuantityFurniture1.Text = "Quantity:"
        End If

        If curItem.Total = 0 Then
            lblTotalFurniture1.Text = Nothing
            lblTotalFurniture2.Text = Nothing
        Else
            lblTotalFurniture1.Text = "Total Cost:"
        End If

        If curItem.Type = String.Empty Then
            lblTypeFurniture1.Text = Nothing
            lblTypeFurniture2.Text = Nothing
        Else
            lblTypeFurniture1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionFurniture1.Text = Nothing
            lblDescriptionFurniture2.Text = Nothing
        Else
            lblDescriptionFurniture1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsFurniture1.Text = Nothing
            lblCommentsFurniture1.Text = Nothing
        Else
            lblCommentsFurniture1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailMiscTech_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailMiscTech.BeforePrint
        Dim curItem As New MiscTechnology

        curItem = CType(DetailReportMiscTech.GetCurrentRow(), MiscTechnology)

        If curItem Is Nothing Then
            ClearMiscTechFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandTechnology1.Text = Nothing
            lblBrandTechnology2.Text = Nothing
        Else
            lblBrandTechnology1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelTechnology1.Text = Nothing
            lblModelTechnology1.Text = Nothing
        Else
            lblModelTechnology1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionTechnology1.Text = Nothing
            lblConditionTechnology1.Text = Nothing
        Else
            lblConditionTechnology1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDateTechnology1.Text = Nothing
            lblDateTechnology2.Text = Nothing
        Else
            lblDateTechnology1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialTechnology1.Text = Nothing
            lblSerialTechnology2.Text = Nothing
        Else
            lblSerialTechnology1.Text = "Serial #:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundTechnology1.Text = Nothing
            lblFundTechnology2.Text = Nothing
        Else
            lblFundTechnology1.Text = "Fund Source:"
        End If

        If curItem.Cost is nothing Then
            lblCostTechnology1.Text = Nothing
            lblCostTechnology2.Text = Nothing
        Else
            lblCostTechnology1.Text = "Cost:"
        End If

        If curItem.Quantity is nothing Then
            lblQuantityTechnology1.Text = Nothing
            lblQuantityTechnology2.Text = Nothing
        Else
            lblQuantityTechnology1.Text = "Quantity:"
        End If

        If curItem.Total = 0 Then
            lblTotalTechnology1.Text = Nothing
            lblTotalTechnology2.Text = Nothing
        Else
            lblTotalTechnology1.Text = "Total Cost:"
        End If

        If curItem.Type = String.Empty Then
            lblTypeTechnology1.Text = Nothing
            lblTypeTechnology2.Text = Nothing
        Else
            lblTypeTechnology1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionTechnology1.Text = Nothing
            lblDescriptionTechnology2.Text = Nothing
        Else
            lblDescriptionTechnology1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsTechnology1.Text = Nothing
            lblCommentsTechnology1.Text = Nothing
        Else
            lblCommentsTechnology1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailMonitors_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailMonitors.BeforePrint
        Dim curItem As New Monitor

        curItem = CType(DetailReportMonitors.GetCurrentRow(), Monitor)

        If curItem Is Nothing Then
            ClearMonitorFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandMonitor1.Text = Nothing
            lblBrandMonitor2.Text = Nothing
        Else
            lblBrandMonitor1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelMonitor1.Text = Nothing
            lblModelMonitor1.Text = Nothing
        Else
            lblModelMonitor1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionMonitor1.Text = Nothing
            lblConditionMonitor1.Text = Nothing
        Else
            lblConditionMonitor1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDateMonitor1.Text = Nothing
            lblDateMonitor2.Text = Nothing
        Else
            lblDateMonitor1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialMonitor1.Text = Nothing
            lblSerialMonitor2.Text = Nothing
        Else
            lblSerialMonitor1.Text = "Serial #:"
        End If

        If curItem.Cost is nothing Then
            lblCostMonitor1.Text = Nothing
            lblCostMonitor2.Text = Nothing
        Else
            lblCostMonitor1.Text = "Cost:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundMonitor1.Text = Nothing
            lblFundMonitor2.Text = Nothing
        Else
            lblFundMonitor1.Text = "Fund Source:"
        End If
        
        If curItem.Size = 0 Then
            lblSizeMonitor1.Text = Nothing
            lblSizeMonitor2.Text = Nothing
        Else
            lblSizeMonitor1.Text = "Monitor Size:"
        End If

        If curItem.Type = String.Empty Then
            lblTypeMonitor1.Text = Nothing
            lblTypeMonitor2.Text = Nothing
        Else
            lblTypeMonitor1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionMonitor1.Text = Nothing
            lblDescriptionMonitor2.Text = Nothing
        Else
            lblDescriptionMonitor1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsMonitor1.Text = Nothing
            lblCommentsMonitor1.Text = Nothing
        Else
            lblCommentsMonitor1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailPrinters_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailPrinters.BeforePrint
        Dim curItem As New Printer

        curItem = CType(DetailReportPrinters.GetCurrentRow(), Printer)

        If curItem Is Nothing Then
            ClearPrinterFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandPrinter1.Text = Nothing
            lblBrandPrinter2.Text = Nothing
        Else
            lblBrandPrinter1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelPrinter1.Text = Nothing
            lblModelPrinter1.Text = Nothing
        Else
            lblModelPrinter1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionPrinter1.Text = Nothing
            lblConditionPrinter1.Text = Nothing
        Else
            lblConditionPrinter1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDatePrinter1.Text = Nothing
            lblDatePrinter2.Text = Nothing
        Else
            lblDatePrinter1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialPrinter1.Text = Nothing
            lblSerialPrinter2.Text = Nothing
        Else
            lblSerialPrinter1.Text = "Serial #:"
        End If

        If curItem.Cost is nothing Then
            lblCostPrinter1.Text = Nothing
            lblCostPrinter2.Text = Nothing
        Else
            lblCostPrinter1.Text = "Cost:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundPrinter1.Text = Nothing
            lblFundPrinter2.Text = Nothing
        Else
            lblFundPrinter1.Text = "Fund Source:"
        End If
        
        If curItem.Color is Nothing
            lblColorPrinter1.Text = Nothing
            lblColorPrinter2.Text = Nothing
        Else
            If curItem.Color.Value = Nothing Then
                lblColorPrinter1.Text = Nothing
                lblColorPrinter2.Text = Nothing
            Else
                lblColorPrinter1.Text = "Color:"
            End If
        End If

        If curItem.Type = String.Empty Then
            lblTypePrinter1.Text = Nothing
            lblTypePrinter2.Text = Nothing
        Else
            lblTypePrinter1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionPrinter1.Text = Nothing
            lblDescriptionPrinter2.Text = Nothing
        Else
            lblDescriptionPrinter1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsPrinter1.Text = Nothing
            lblCommentsPrinter1.Text = Nothing
        Else
            lblCommentsPrinter1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailSoftware_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailSoftware.BeforePrint
        Dim curItem As New Software

        curItem = CType(DetailReportSoftware.GetCurrentRow(), Software)

        If curItem Is Nothing Then
            ClearSoftwareFields()
            Exit Sub
        End If

        If curItem.Brand = String.Empty Then
            lblBrandSoftware1.Text = Nothing
            lblBrandSoftware2.Text = Nothing
        Else
            lblBrandSoftware1.Text = "Brand:"
        End If

        If curItem.Model = String.Empty Then
            lblModelSoftware1.Text = Nothing
            lblModelSoftware1.Text = Nothing
        Else
            lblModelSoftware1.Text = "Model:"
        End If

        If curItem.Condition = String.Empty Then
            lblConditionSoftware1.Text = Nothing
            lblConditionSoftware1.Text = Nothing
        Else
            lblConditionSoftware1.Text = "Condition:"
        End If

        If curItem.DatePurchased is nothing Then
            lblDateSoftware1.Text = Nothing
            lblDateSoftware2.Text = Nothing
        Else
            lblDateSoftware1.Text = "Date Purchased:"
        End If

        If curItem.SerialNo = String.Empty Then
            lblSerialSoftware1.Text = Nothing
            lblSerialSoftware2.Text = Nothing
        Else
            lblSerialSoftware1.Text = "Serial #:"
        End If

        If curItem.Cost is Nothing Then
            lblCostSoftware1.Text = Nothing
            lblCostSoftware2.Text = Nothing
        Else
            lblCostSoftware1.Text = "Cost:"
        End If

        If curItem.Total = 0 Then
            lblTotalSoftware1.Text = Nothing
            lblTotalSoftware2.Text = Nothing
        Else
            lblTotalSoftware1.Text = "Total:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundSoftware1.Text = Nothing
            lblFundSoftware2.Text = Nothing
        Else
            lblFundSoftware1.Text = "Fund Source:"
        End If
        
        If curItem.NumberOfLicenses = 0 Then
            lblLicenseSoftware1.Text = Nothing
            lblLicenseSoftware2.Text = Nothing
        Else
            lblLicenseSoftware1.Text = "License Count:"
        End If

        If curItem.Type = String.Empty Then
            lblTypeSoftware1.Text = Nothing
            lblTypeSoftware2.Text = Nothing
        Else
            lblTypeSoftware1.Text = "Type:"
        End If

        If curItem.Description = String.Empty Then
            lblDescriptionSoftware1.Text = Nothing
            lblDescriptionSoftware2.Text = Nothing
        Else
            lblDescriptionSoftware1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblCommentsSoftware1.Text = Nothing
            lblCommentsSoftware1.Text = Nothing
        Else
            lblCommentsSoftware1.Text = "Comments:"
        End If
    End Sub

    Private Sub DetailTextbooks_BeforePrint( sender As System.Object,  e As System.Drawing.Printing.PrintEventArgs) Handles DetailTextbooks.BeforePrint
        Dim curItem As New Textbook

        curItem = CType(DetailReportTextbooks.GetCurrentRow(), Textbook)

        If curItem Is Nothing Then
            ClearTextbookFields()
            Exit Sub
        End If

        If curItem.Publisher = String.Empty Then
            lblPublisherTextbook1.Text = Nothing
            lblPublisherTextbook2.Text = Nothing
        Else
            lblPublisherTextbook1.Text = "Publisher:"
        End If

        If curItem.CopyrightDate is Nothing Then
            lblCopyrightTextbook1.Text = Nothing
            lblCopyrightTextbook2.Text = Nothing
        Else
            lblCopyrightTextbook1.Text = "Copyright Date:"
        End If

        If curItem.Condition is nothing Then
            lblConditionTextbook1.Text = Nothing
            lblConditionTextbook2.Text = Nothing
        Else
            lblConditionTextbook1.Text = "Condition:"
        End If

        If curItem.DatePurchased is Nothing Then
            lblDateTextbook1.Text = Nothing
            lblDateTextbook2.Text = Nothing
        Else
            lblDateTextbook1.Text = "Date Purchased:"
        End If

        If curItem.Cost is nothing Then
            lblCostTextbook1.Text = Nothing
            lblCostTextbook2.Text = Nothing
        Else
            lblCostTextbook1.Text = "Cost:"
        End If

        If curItem.Quantity is nothing Then
            lblQuantityTextbook1.Text = Nothing
            lblQuantityTextbook2.Text = Nothing
        Else
            lblQuantityTextbook1.Text = "Quantity:"
        End If

        If curItem.cost = 0 Then
            lblTotalTextbook1.Text = Nothing
            lblTotalTextbook2.Text = Nothing
        Else
            lblTotalTextbook1.Text = "Total Cost:"
        End If

        If curItem.FundSource is Nothing Then
            lblFundTextbook1.Text = Nothing
            lblFundTextbook2.Text = Nothing
        Else
            lblFundTextbook1.Text = "Fund Source:"
        End If

        If curItem.Isbn is Nothing Then
            lblISBNTextbook1.Text = Nothing
            lblISBNTextbook2.Text = Nothing
        Else
            lblISBNTextbook1.Text = "ISBN:"
        End If

        If curItem.Description is Nothing Then
            lblDescriptionTextbook1.Text = Nothing
            lblDescriptionTextbook2.Text = Nothing
        Else
            lblDescriptionTextbook1.Text = "Description:"
        End If

        If curItem.Comments is Nothing Then
            lblCommentsTextbook1.Text = Nothing
            lblCommentsTextbook2.Text = Nothing
        Else
            lblCommentsTextbook1.Text = "Comments:"
        End If
    End Sub

    Private Sub ClearComputerFields()
        lblBrandPC1.Text = Nothing
        lblBrandPC2.Text = Nothing
        lblModelPC1.Text = Nothing
        lblModelPC2.Text = Nothing
        lblOSPC1.Text = Nothing
        lblOSPC2.Text = Nothing
        lblSerialPC1.Text = Nothing
        lblSerialPC2.Text = Nothing
        lblRAMPC1.Text = Nothing
        lblRAMPC2.Text = Nothing
        lblLicensePC1.Text = Nothing
        lblLicensePC2.Text = Nothing
        lblCostPC1.Text = Nothing
        lblCostPC2.Text = Nothing
        lblFundPC1.Text = Nothing
        lblFundPC2.Text = Nothing
        lblDescriptionPC1.Text = Nothing
        lblDescriptionPC2.Text = Nothing
        lblCommentPC1.Text = Nothing
        lblCommentPC2.Text = Nothing
    End Sub

    Private Sub ClearAudioVideoFields()
        lblBrand1.Text = Nothing
        lblBrand2.Text = Nothing
        lblModel1.Text = Nothing
        lblModel2.Text = Nothing
        lblType1.Text = Nothing
        lblType2.Text = Nothing
        lblDatePurchased1.Text = Nothing
        lblDatePurchased2.Text = Nothing
        lblCondition1.Text = Nothing
        lblCondition2.Text = Nothing
        lblSerial1.Text = Nothing
        lblSerial2.Text = Nothing
        lblCost1.Text = Nothing
        lblCost2.Text = Nothing
        lblFundSource1.Text = Nothing
        lblFundSource2.Text = Nothing
        lblDescription1.Text = Nothing
        lblDescription2.Text = Nothing
        lblComments1.Text = Nothing
        lblComments2.Text = Nothing
    End Sub

    Private sub ClearEquipmentFields()
        lblBrandEquipment1.Text = Nothing
        lblBrandEquipment2.Text = Nothing
        lblModelEquipment1.Text = Nothing
        lblModelEquipment1.Text = Nothing
        lblConditionEquipment1.Text = Nothing
        lblConditionEquipment1.Text = Nothing
        lblDateEquipment1.Text = Nothing
        lblDateEquipment2.Text = Nothing
        lblSerialEquipment1.Text = Nothing
        lblSerialEquipment2.Text = Nothing
        lblFundEquipment1.Text = Nothing
        lblFundEquipment2.Text = Nothing
        lblCostEquipment1.Text = Nothing
        lblCostEquipment2.Text = Nothing
        lblQuantityEquipment1.Text = Nothing
        lblQuantityEquipment2.Text = Nothing
        lblTotalEquipment1.Text = Nothing
        lblTotalEquipment2.Text = Nothing
        lblTypeEquipment1.Text = Nothing
        lblTypeEquipment2.Text = Nothing
        lblDescriptionEquipment1.Text = Nothing
        lblDescriptionEquipment2.Text = Nothing
        lblCommentsEquipment1.Text = Nothing
        lblCommentsEquipment1.Text = Nothing
    End Sub

    Private Sub ClearFurnitureFields()
        lblBrandFurniture1.Text = Nothing
        lblBrandFurniture2.Text = Nothing
        lblModelFurniture1.Text = Nothing
        lblModelFurniture1.Text = Nothing
        lblConditionFurniture1.Text = Nothing
        lblConditionFurniture1.Text = Nothing
        lblDateFurniture1.Text = Nothing
        lblDateFurniture2.Text = Nothing
        lblSerialFurniture1.Text = Nothing
        lblSerialFurniture2.Text = Nothing
        lblFundFurniture1.Text = Nothing
        lblFundFurniture2.Text = Nothing
        lblCostFurniture1.Text = Nothing
        lblCostFurniture2.Text = Nothing
        lblQuantityFurniture1.Text = Nothing
        lblQuantityFurniture2.Text = Nothing
        lblTotalFurniture1.Text = Nothing
        lblTotalFurniture2.Text = Nothing
        lblTypeFurniture1.Text = Nothing
        lblTypeFurniture2.Text = Nothing
        lblDescriptionFurniture1.Text = Nothing
        lblDescriptionFurniture2.Text = Nothing
        lblCommentsFurniture1.Text = Nothing
        lblCommentsFurniture1.Text = Nothing
    End Sub

    Private Sub ClearMiscTechFields()
        lblBrandTechnology1.Text = Nothing
        lblBrandTechnology2.Text = Nothing
        lblModelTechnology1.Text = Nothing
        lblModelTechnology2.Text = Nothing
        lblConditionTechnology1.Text = Nothing
        lblConditionTechnology2.Text = Nothing
        lblDateTechnology1.Text = Nothing
        lblDateTechnology1.Text = Nothing
        lblSerialTechnology1.Text = Nothing
        lblSerialTechnology2.Text = Nothing
        lblFundTechnology1.Text = Nothing
        lblFundTechnology2.Text = Nothing
        lblCostTechnology1.Text = Nothing
        lblCostTechnology2.Text = Nothing
        lblQuantityTechnology1.Text = Nothing
        lblQuantityTechnology2.Text = Nothing
        lblTotalTechnology1.Text = Nothing
        lblTotalTechnology2.Text = Nothing
        lblTypeTechnology1.Text = Nothing
        lblTypeTechnology2.Text = Nothing
        lblDescriptionTechnology1.Text = Nothing
        lblDescriptionTechnology1.Text = Nothing
        lblCommentsTechnology1.Text = Nothing
        lblCommentsTechnology2.Text = Nothing
    End Sub

    Private Sub ClearMonitorFields()
        lblBrandMonitor1.Text = Nothing
        lblBrandMonitor2.Text = Nothing
        lblModelMonitor1.Text = Nothing
        lblModelMonitor2.Text = Nothing
        lblConditionMonitor1.Text = Nothing
	    lblConditionMonitor2.Text = Nothing
        lblDateMonitor1.Text = Nothing
        lblDateMonitor2.Text = Nothing
        lblSerialMonitor1.Text = Nothing
        lblSerialMonitor2.Text = Nothing
        lblCostMonitor1.Text = Nothing
        lblCostMonitor2.Text = Nothing
        lblFundMonitor1.Text = Nothing
        lblFundMonitor2.Text = Nothing
        lblSizeMonitor1.Text = Nothing
        lblSizeMonitor2.Text = Nothing
        lblTypeMonitor1.Text = Nothing
        lblTypeMonitor2.Text = Nothing
        lblDescriptionMonitor1.Text = Nothing
        lblDescriptionMonitor2.Text = Nothing
        lblCommentsMonitor1.Text = Nothing
        lblCommentsMonitor2.Text = Nothing
    End Sub

    Private Sub ClearPrinterFields()
        lblBrandPrinter1.Text = Nothing
        lblBrandPrinter2.Text = Nothing
        lblModelPrinter1.Text = Nothing
        lblModelPrinter2.Text = Nothing
        lblConditionPrinter1.Text = Nothing
	    lblConditionPrinter2.Text = Nothing
        lblDatePrinter1.Text = Nothing
        lblDatePrinter2.Text = Nothing
        lblSerialPrinter1.Text = Nothing
        lblSerialPrinter2.Text = Nothing
        lblCostPrinter1.Text = Nothing
        lblCostPrinter2.Text = Nothing
        lblFundPrinter1.Text = Nothing
        lblFundPrinter2.Text = Nothing
        lblColorPrinter1.Text = Nothing
        lblColorPrinter2.Text = Nothing
        lblTypePrinter1.Text = Nothing
        lblTypePrinter2.Text = Nothing
        lblDescriptionPrinter1.Text = Nothing
        lblDescriptionPrinter2.Text = Nothing
        lblCommentsPrinter1.Text = Nothing
        lblCommentsPrinter2.Text = Nothing
    End Sub

    Private Sub ClearSoftwareFields()
        lblBrandSoftware1.Text = Nothing
        lblBrandSoftware2.Text = Nothing
        lblModelSoftware1.Text = Nothing
        lblModelSoftware2.Text = Nothing
        lblConditionSoftware1.Text = Nothing
	    lblConditionSoftware2.Text = Nothing
        lblDateSoftware1.Text = Nothing
        lblDateSoftware2.Text = Nothing
        lblSerialSoftware1.Text = Nothing
        lblSerialSoftware2.Text = Nothing
        lblCostSoftware1.Text = Nothing
        lblCostSoftware2.Text = Nothing
        lblTotalSoftware1.Text = Nothing
        lblTotalSoftware2.Text = Nothing
        lblFundSoftware1.Text = Nothing
        lblFundSoftware2.Text = Nothing
        lblLicenseSoftware1.Text = Nothing
        lblLicenseSoftware2.Text = Nothing
        lblTypeSoftware1.Text = Nothing
        lblTypeSoftware2.Text = Nothing
        lblDescriptionSoftware1.Text = Nothing
        lblDescriptionSoftware2.Text = Nothing
        lblCommentsSoftware1.Text = Nothing
        lblCommentsSoftware2.Text = Nothing
    End Sub

    Private Sub ClearTextbookFields()
        lblPublisherTextbook1.Text = Nothing
        lblPublisherTextbook2.Text = Nothing
        lblCopyrightTextbook1.Text = Nothing
        lblCopyrightTextbook2.Text = Nothing
        lblConditionTextbook1.Text = Nothing
        lblConditionTextbook2.Text = Nothing
        lblDateTextbook1.Text = Nothing
        lblDateTextbook2.Text = Nothing
        lblCostTextbook1.Text = Nothing
        lblCostTextbook2.Text = Nothing
        lblQuantityTextbook1.Text = Nothing
        lblQuantityTextbook2.Text = Nothing
        lblTotalTextbook1.Text = Nothing
        lblTotalTextbook2.Text = Nothing
        lblFundTextbook1.Text = Nothing
        lblFundTextbook2.Text = Nothing
        lblISBNTextbook1.Text = Nothing
        lblISBNTextbook2.Text = Nothing
        lblDescriptionTextbook1.Text = Nothing
        lblDescriptionTextbook2.Text = Nothing
        lblCommentsTextbook1.Text = Nothing
        lblCommentsTextbook2.Text = Nothing
    End Sub
End Class