<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DistrictOverviewReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAV = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.bindingDistrictReport = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.bindingDistrictReport,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.Detail.EvenStyleName = "XrControlStyle1"
        Me.Detail.HeightF = 163.0834!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.OddStyleName = "XrControlStyle2"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.StyleName = "XrControlStyle2"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SoftwareCount")})
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(500!, 92.49995!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel19.Text = "XrLabel19"
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Total", "{0} items")})
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(670.8751!, 0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(78.125!, 23!)
        Me.XrLabel21.Text = "XrLabel21"
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(628.1667!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(42.70831!, 23!)
        Me.XrLabel16.StylePriority.UseFont = false
        Me.XrLabel16.Text = "Total:"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MiscTechCount")})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 140.0001!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel10.Text = "XrLabel10"
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FurnitureCount")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 116.5001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EquipmentCount")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 92.99997!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AVCount")})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 46.50002!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ComputerCount")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(99.99997!, 69.5!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel8.Text = "XrLabel8"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 140.0001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.Text = "Misc Tech:"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 116.5001!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.Text = "Furniture:"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 92.99997!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.Text = "Equipment:"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.5!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.Text = "Computers:"
        '
        'lblAV
        '
        Me.lblAV.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAV.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46!)
        Me.lblAV.Name = "lblAV"
        Me.lblAV.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblAV.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.lblAV.StylePriority.UseFont = false
        Me.lblAV.Text = "Audio / Video:"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Room.FullName")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.99999!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(450!, 23!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "User.FullName")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(450!, 23!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'bindingDistrictReport
        '
        Me.bindingDistrictReport.DataSource = GetType(InventoryData.DistrictReport)
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        '
        'XrControlStyle2
        '
        Me.XrControlStyle2.BackColor = System.Drawing.Color.White
        Me.XrControlStyle2.Name = "XrControlStyle2"
        Me.XrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblAV, Me.XrLabel11, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel10, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel1, Me.XrLabel2, Me.XrLabel21, Me.XrLabel16, Me.XrLabel12, Me.XrLabel19, Me.XrLabel17, Me.XrLabel18, Me.XrLabel20, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(749!, 163.0834!)
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PrinterCount")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(499.9999!, 69.49997!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MonitorCount")})
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(499.9999!, 46.49998!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TextbookCount")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(499.9998!, 115.4999!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(400!, 69.5!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.Text = "Printers:"
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(400!, 93.50005!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.Text = "Software:"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(400!, 117!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.Text = "Textbooks:"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(400!, 46.49998!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.Text = "Monitors:"
        '
        'DistrictOverviewReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataSource = Me.bindingDistrictReport
        Me.Margins = New System.Drawing.Printing.Margins(48, 53, 100, 100)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1, Me.XrControlStyle2})
        Me.Version = "11.1"
        CType(Me.bindingDistrictReport,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents bindingDistrictReport As System.Windows.Forms.BindingSource
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAV As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
End Class
