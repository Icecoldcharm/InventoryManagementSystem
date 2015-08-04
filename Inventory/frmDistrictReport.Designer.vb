<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistrictReport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLoadReport = New DevExpress.XtraEditors.SimpleButton()
        Me.lstUsers = New DevExpress.XtraEditors.ListBoxControl()
        Me.lblUsers = New DevExpress.XtraEditors.LabelControl()
        Me.lblRooms = New DevExpress.XtraEditors.LabelControl()
        Me.lstRooms = New DevExpress.XtraEditors.ListBoxControl()
        Me.lblFurniture = New DevExpress.XtraEditors.LabelControl()
        Me.lblMiscTech = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitor = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinter = New DevExpress.XtraEditors.LabelControl()
        Me.lblSoftware = New DevExpress.XtraEditors.LabelControl()
        Me.lblTextbook = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipment = New DevExpress.XtraEditors.LabelControl()
        Me.lblComputer = New DevExpress.XtraEditors.LabelControl()
        Me.lblAudioVideo = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentData = New DevExpress.XtraEditors.LabelControl()
        Me.lblComputerData = New DevExpress.XtraEditors.LabelControl()
        Me.lblAudioVideoData = New DevExpress.XtraEditors.LabelControl()
        Me.lblTextbookData = New DevExpress.XtraEditors.LabelControl()
        Me.lblSoftwareData = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinterData = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorData = New DevExpress.XtraEditors.LabelControl()
        Me.lblMiscTechData = New DevExpress.XtraEditors.LabelControl()
        Me.lblFurnitureData = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalData = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.btnPrintReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.lstUsers,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lstRooms,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnLoadReport
        '
        Me.btnLoadReport.Location = New System.Drawing.Point(12, 12)
        Me.btnLoadReport.Name = "btnLoadReport"
        Me.btnLoadReport.Size = New System.Drawing.Size(131, 46)
        Me.btnLoadReport.TabIndex = 0
        Me.btnLoadReport.Text = "Load Report"
        '
        'lstUsers
        '
        Me.lstUsers.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstUsers.Appearance.Options.UseFont = true
        Me.lstUsers.Location = New System.Drawing.Point(12, 135)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstUsers.Size = New System.Drawing.Size(196, 355)
        Me.lstUsers.TabIndex = 1
        '
        'lblUsers
        '
        Me.lblUsers.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblUsers.Location = New System.Drawing.Point(12, 113)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(41, 16)
        Me.lblUsers.TabIndex = 2
        Me.lblUsers.Text = "Users:"
        '
        'lblRooms
        '
        Me.lblRooms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRooms.Location = New System.Drawing.Point(224, 113)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(48, 16)
        Me.lblRooms.TabIndex = 4
        Me.lblRooms.Text = "Rooms:"
        '
        'lstRooms
        '
        Me.lstRooms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstRooms.Appearance.Options.UseFont = true
        Me.lstRooms.Location = New System.Drawing.Point(224, 135)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstRooms.Size = New System.Drawing.Size(196, 355)
        Me.lstRooms.TabIndex = 3
        '
        'lblFurniture
        '
        Me.lblFurniture.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFurniture.Location = New System.Drawing.Point(436, 243)
        Me.lblFurniture.Name = "lblFurniture"
        Me.lblFurniture.Size = New System.Drawing.Size(57, 16)
        Me.lblFurniture.TabIndex = 5
        Me.lblFurniture.Text = "Furniture:"
        '
        'lblMiscTech
        '
        Me.lblMiscTech.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMiscTech.Location = New System.Drawing.Point(436, 279)
        Me.lblMiscTech.Name = "lblMiscTech"
        Me.lblMiscTech.Size = New System.Drawing.Size(62, 16)
        Me.lblMiscTech.TabIndex = 6
        Me.lblMiscTech.Text = "Misc Tech:"
        '
        'lblMonitor
        '
        Me.lblMonitor.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMonitor.Location = New System.Drawing.Point(436, 315)
        Me.lblMonitor.Name = "lblMonitor"
        Me.lblMonitor.Size = New System.Drawing.Size(54, 16)
        Me.lblMonitor.TabIndex = 7
        Me.lblMonitor.Text = "Monitors:"
        '
        'lblPrinter
        '
        Me.lblPrinter.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPrinter.Location = New System.Drawing.Point(436, 351)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(49, 16)
        Me.lblPrinter.TabIndex = 8
        Me.lblPrinter.Text = "Printers:"
        '
        'lblSoftware
        '
        Me.lblSoftware.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSoftware.Location = New System.Drawing.Point(436, 387)
        Me.lblSoftware.Name = "lblSoftware"
        Me.lblSoftware.Size = New System.Drawing.Size(57, 16)
        Me.lblSoftware.TabIndex = 9
        Me.lblSoftware.Text = "Software:"
        '
        'lblTextbook
        '
        Me.lblTextbook.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTextbook.Location = New System.Drawing.Point(436, 423)
        Me.lblTextbook.Name = "lblTextbook"
        Me.lblTextbook.Size = New System.Drawing.Size(63, 16)
        Me.lblTextbook.TabIndex = 10
        Me.lblTextbook.Text = "Textbooks:"
        '
        'lblEquipment
        '
        Me.lblEquipment.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEquipment.Location = New System.Drawing.Point(436, 207)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(65, 16)
        Me.lblEquipment.TabIndex = 13
        Me.lblEquipment.Text = "Equipment:"
        '
        'lblComputer
        '
        Me.lblComputer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblComputer.Location = New System.Drawing.Point(436, 171)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(67, 16)
        Me.lblComputer.TabIndex = 12
        Me.lblComputer.Text = "Computers:"
        '
        'lblAudioVideo
        '
        Me.lblAudioVideo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAudioVideo.Location = New System.Drawing.Point(436, 135)
        Me.lblAudioVideo.Name = "lblAudioVideo"
        Me.lblAudioVideo.Size = New System.Drawing.Size(73, 16)
        Me.lblAudioVideo.TabIndex = 11
        Me.lblAudioVideo.Text = "Audio Video:"
        '
        'lblEquipmentData
        '
        Me.lblEquipmentData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEquipmentData.Location = New System.Drawing.Point(515, 207)
        Me.lblEquipmentData.Name = "lblEquipmentData"
        Me.lblEquipmentData.Size = New System.Drawing.Size(70, 16)
        Me.lblEquipmentData.TabIndex = 22
        Me.lblEquipmentData.Text = " < Value >"
        '
        'lblComputerData
        '
        Me.lblComputerData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblComputerData.Location = New System.Drawing.Point(515, 171)
        Me.lblComputerData.Name = "lblComputerData"
        Me.lblComputerData.Size = New System.Drawing.Size(70, 16)
        Me.lblComputerData.TabIndex = 21
        Me.lblComputerData.Text = " < Value >"
        '
        'lblAudioVideoData
        '
        Me.lblAudioVideoData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAudioVideoData.Location = New System.Drawing.Point(515, 135)
        Me.lblAudioVideoData.Name = "lblAudioVideoData"
        Me.lblAudioVideoData.Size = New System.Drawing.Size(70, 16)
        Me.lblAudioVideoData.TabIndex = 20
        Me.lblAudioVideoData.Text = " < Value >"
        '
        'lblTextbookData
        '
        Me.lblTextbookData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTextbookData.Location = New System.Drawing.Point(515, 423)
        Me.lblTextbookData.Name = "lblTextbookData"
        Me.lblTextbookData.Size = New System.Drawing.Size(70, 16)
        Me.lblTextbookData.TabIndex = 19
        Me.lblTextbookData.Text = " < Value >"
        '
        'lblSoftwareData
        '
        Me.lblSoftwareData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSoftwareData.Location = New System.Drawing.Point(515, 387)
        Me.lblSoftwareData.Name = "lblSoftwareData"
        Me.lblSoftwareData.Size = New System.Drawing.Size(70, 16)
        Me.lblSoftwareData.TabIndex = 18
        Me.lblSoftwareData.Text = " < Value >"
        '
        'lblPrinterData
        '
        Me.lblPrinterData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPrinterData.Location = New System.Drawing.Point(515, 351)
        Me.lblPrinterData.Name = "lblPrinterData"
        Me.lblPrinterData.Size = New System.Drawing.Size(70, 16)
        Me.lblPrinterData.TabIndex = 17
        Me.lblPrinterData.Text = " < Value >"
        '
        'lblMonitorData
        '
        Me.lblMonitorData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMonitorData.Location = New System.Drawing.Point(515, 315)
        Me.lblMonitorData.Name = "lblMonitorData"
        Me.lblMonitorData.Size = New System.Drawing.Size(70, 16)
        Me.lblMonitorData.TabIndex = 16
        Me.lblMonitorData.Text = " < Value >"
        '
        'lblMiscTechData
        '
        Me.lblMiscTechData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMiscTechData.Location = New System.Drawing.Point(515, 279)
        Me.lblMiscTechData.Name = "lblMiscTechData"
        Me.lblMiscTechData.Size = New System.Drawing.Size(70, 16)
        Me.lblMiscTechData.TabIndex = 15
        Me.lblMiscTechData.Text = " < Value >"
        '
        'lblFurnitureData
        '
        Me.lblFurnitureData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFurnitureData.Location = New System.Drawing.Point(515, 243)
        Me.lblFurnitureData.Name = "lblFurnitureData"
        Me.lblFurnitureData.Size = New System.Drawing.Size(70, 16)
        Me.lblFurnitureData.TabIndex = 14
        Me.lblFurnitureData.Text = " < Value >"
        '
        'lblTotalData
        '
        Me.lblTotalData.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotalData.Location = New System.Drawing.Point(515, 474)
        Me.lblTotalData.Name = "lblTotalData"
        Me.lblTotalData.Size = New System.Drawing.Size(70, 16)
        Me.lblTotalData.TabIndex = 24
        Me.lblTotalData.Text = " < Value >"
        '
        'lblTotal
        '
        Me.lblTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotal.Location = New System.Drawing.Point(436, 474)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 16)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Total:"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Location = New System.Drawing.Point(166, 12)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(131, 46)
        Me.btnPrintReport.TabIndex = 0
        Me.btnPrintReport.Text = "Print Report"
        '
        'frmDistrictReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 499)
        Me.Controls.Add(Me.lblTotalData)
        Me.Controls.Add(Me.lblRooms)
        Me.Controls.Add(Me.lblMiscTech)
        Me.Controls.Add(Me.lstRooms)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.lblFurniture)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.lblEquipmentData)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.btnLoadReport)
        Me.Controls.Add(Me.lblMonitor)
        Me.Controls.Add(Me.lblComputerData)
        Me.Controls.Add(Me.lblAudioVideo)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.lblFurnitureData)
        Me.Controls.Add(Me.lblAudioVideoData)
        Me.Controls.Add(Me.lblMiscTechData)
        Me.Controls.Add(Me.lblSoftware)
        Me.Controls.Add(Me.lblEquipment)
        Me.Controls.Add(Me.lblTextbookData)
        Me.Controls.Add(Me.lblMonitorData)
        Me.Controls.Add(Me.lblTextbook)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblSoftwareData)
        Me.Controls.Add(Me.lblPrinterData)
        Me.Name = "frmDistrictReport"
        Me.Text = "frmDistrictReport"
        CType(Me.lstUsers,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lstRooms,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnLoadReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstUsers As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lblUsers As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRooms As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstRooms As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lblFurniture As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMiscTech As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinter As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSoftware As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTextbook As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComputer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAudioVideo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipmentData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComputerData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAudioVideoData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTextbookData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSoftwareData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinterData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMiscTechData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFurnitureData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrintReport As DevExpress.XtraEditors.SimpleButton
End Class
