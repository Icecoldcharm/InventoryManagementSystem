<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ComputerReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComputerReport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblFundSource2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCost2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFundSource1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblCost1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSerial1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblSerial2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblRAM1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblRAM2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblLicense1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblLicense2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOS1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblOS2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblType2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblName2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblComments1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblComments2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescription1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescription2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblModel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblModel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblBrand1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblBrand2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.lblPage1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPage2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblHeader1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblHeader2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblHeaderUser = New DevExpress.XtraReports.UI.XRLabel()
        Me.User = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblHeaderRoom = New DevExpress.XtraReports.UI.XRLabel()
        Me.Room = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblFundSource2, Me.lblCost2, Me.lblFundSource1, Me.lblCost1, Me.lblSerial1, Me.lblSerial2, Me.lblRAM1, Me.lblRAM2, Me.lblOS1, Me.lblOS2, Me.XrPanel1, Me.lblComments1, Me.lblComments2, Me.lblDescription1, Me.lblDescription2, Me.lblModel1, Me.lblModel2, Me.lblBrand1, Me.lblBrand2, Me.lblLicense2, Me.lblLicense1})
        Me.Detail.HeightF = 101!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblFundSource2
        '
        Me.lblFundSource2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FundSource")})
        Me.lblFundSource2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFundSource2.LocationFloat = New DevExpress.Utils.PointFloat(500.0001!, 39.75!)
        Me.lblFundSource2.Name = "lblFundSource2"
        Me.lblFundSource2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblFundSource2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblFundSource2.SizeF = New System.Drawing.SizeF(240.9999!, 12.58333!)
        Me.lblFundSource2.StylePriority.UseFont = false
        Me.lblFundSource2.Text = "lblFundSource2"
        '
        'lblCost2
        '
        Me.lblCost2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cost", "{0:c}")})
        Me.lblCost2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCost2.LocationFloat = New DevExpress.Utils.PointFloat(113.5418!, 52.33332!)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblCost2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblCost2.SizeF = New System.Drawing.SizeF(258.3334!, 12.58333!)
        Me.lblCost2.StylePriority.UseFont = false
        Me.lblCost2.Text = "lblCost2"
        '
        'lblFundSource1
        '
        Me.lblFundSource1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFundSource1.LocationFloat = New DevExpress.Utils.PointFloat(385.4169!, 39.75!)
        Me.lblFundSource1.Name = "lblFundSource1"
        Me.lblFundSource1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblFundSource1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblFundSource1.SizeF = New System.Drawing.SizeF(114.5833!, 12.58334!)
        Me.lblFundSource1.StylePriority.UseFont = false
        Me.lblFundSource1.Text = "Fund Source:"
        '
        'lblCost1
        '
        Me.lblCost1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCost1.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 54.50001!)
        Me.lblCost1.Name = "lblCost1"
        Me.lblCost1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblCost1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblCost1.SizeF = New System.Drawing.SizeF(113.5417!, 10.41666!)
        Me.lblCost1.StylePriority.UseFont = false
        Me.lblCost1.Text = "Cost:"
        '
        'lblSerial1
        '
        Me.lblSerial1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSerial1.LocationFloat = New DevExpress.Utils.PointFloat(385.4167!, 27.16669!)
        Me.lblSerial1.Name = "lblSerial1"
        Me.lblSerial1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblSerial1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblSerial1.SizeF = New System.Drawing.SizeF(114.5833!, 12.58334!)
        Me.lblSerial1.StylePriority.UseFont = false
        Me.lblSerial1.Text = "Serial #:"
        '
        'lblSerial2
        '
        Me.lblSerial2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SerialNo")})
        Me.lblSerial2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSerial2.LocationFloat = New DevExpress.Utils.PointFloat(499.9999!, 27.16669!)
        Me.lblSerial2.Name = "lblSerial2"
        Me.lblSerial2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblSerial2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblSerial2.SizeF = New System.Drawing.SizeF(240.9999!, 12.58333!)
        Me.lblSerial2.StylePriority.UseFont = false
        Me.lblSerial2.Text = "lblSerial2"
        '
        'lblRAM1
        '
        Me.lblRAM1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRAM1.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05!, 41.91669!)
        Me.lblRAM1.Name = "lblRAM1"
        Me.lblRAM1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblRAM1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblRAM1.SizeF = New System.Drawing.SizeF(113.5417!, 10.41666!)
        Me.lblRAM1.StylePriority.UseFont = false
        Me.lblRAM1.Text = "RAM:"
        '
        'lblRAM2
        '
        Me.lblRAM2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ram")})
        Me.lblRAM2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRAM2.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 39.75!)
        Me.lblRAM2.Name = "lblRAM2"
        Me.lblRAM2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblRAM2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblRAM2.SizeF = New System.Drawing.SizeF(258.3334!, 12.58333!)
        Me.lblRAM2.StylePriority.UseFont = false
        Me.lblRAM2.Text = "lblRAM2"
        '
        'lblLicense1
        '
        Me.lblLicense1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLicense1.LocationFloat = New DevExpress.Utils.PointFloat(385.4168!, 54.50001!)
        Me.lblLicense1.Name = "lblLicense1"
        Me.lblLicense1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblLicense1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblLicense1.SizeF = New System.Drawing.SizeF(114.5833!, 12.58334!)
        Me.lblLicense1.StylePriority.UseFont = false
        Me.lblLicense1.Text = "License:"
        '
        'lblLicense2
        '
        Me.lblLicense2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WinLicense")})
        Me.lblLicense2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLicense2.LocationFloat = New DevExpress.Utils.PointFloat(499.9999!, 54.50001!)
        Me.lblLicense2.Name = "lblLicense2"
        Me.lblLicense2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblLicense2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblLicense2.SizeF = New System.Drawing.SizeF(240.9999!, 12.58334!)
        Me.lblLicense2.StylePriority.UseFont = false
        Me.lblLicense2.Text = "lblLicense2"
        '
        'lblOS1
        '
        Me.lblOS1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOS1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 27.16665!)
        Me.lblOS1.Name = "lblOS1"
        Me.lblOS1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblOS1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblOS1.SizeF = New System.Drawing.SizeF(113.5417!, 12.58334!)
        Me.lblOS1.StylePriority.UseFont = false
        Me.lblOS1.Text = "Operating System:"
        '
        'lblOS2
        '
        Me.lblOS2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Os")})
        Me.lblOS2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOS2.LocationFloat = New DevExpress.Utils.PointFloat(113.5416!, 27.16669!)
        Me.lblOS2.Name = "lblOS2"
        Me.lblOS2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblOS2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblOS2.SizeF = New System.Drawing.SizeF(258.3334!, 12.58331!)
        Me.lblOS2.StylePriority.UseFont = false
        Me.lblOS2.Text = "lblOS2"
        '
        'XrPanel1
        '
        Me.XrPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblType2, Me.lblName2})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(751!, 13!)
        Me.XrPanel1.StylePriority.UseBackColor = false
        '
        'lblType2
        '
        Me.lblType2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Type", "{0}")})
        Me.lblType2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblType2.LocationFloat = New DevExpress.Utils.PointFloat(385.4169!, 0!)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblType2.SizeF = New System.Drawing.SizeF(197.9167!, 12.99999!)
        Me.lblType2.StylePriority.UseFont = false
        Me.lblType2.Text = "lblType2"
        '
        'lblName2
        '
        Me.lblName2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ComputerName")})
        Me.lblName2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblName2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblName2.SizeF = New System.Drawing.SizeF(197.9167!, 12.99999!)
        Me.lblName2.StylePriority.UseFont = false
        Me.lblName2.Text = "lblName2"
        '
        'lblComments1
        '
        Me.lblComments1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblComments1.LocationFloat = New DevExpress.Utils.PointFloat(385.4165!, 69.75005!)
        Me.lblComments1.Name = "lblComments1"
        Me.lblComments1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblComments1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblComments1.SizeF = New System.Drawing.SizeF(114.5833!, 12.58334!)
        Me.lblComments1.StylePriority.UseFont = false
        Me.lblComments1.Text = "Comments:"
        '
        'lblComments2
        '
        Me.lblComments2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comments")})
        Me.lblComments2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblComments2.LocationFloat = New DevExpress.Utils.PointFloat(385.4168!, 83.45833!)
        Me.lblComments2.Name = "lblComments2"
        Me.lblComments2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblComments2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblComments2.SizeF = New System.Drawing.SizeF(355.5832!, 17.54169!)
        Me.lblComments2.StylePriority.UseFont = false
        Me.lblComments2.Text = "lblComments2"
        '
        'lblDescription1
        '
        Me.lblDescription1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDescription1.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 69.75005!)
        Me.lblDescription1.Name = "lblDescription1"
        Me.lblDescription1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblDescription1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblDescription1.SizeF = New System.Drawing.SizeF(113.5417!, 12.58333!)
        Me.lblDescription1.StylePriority.UseFont = false
        Me.lblDescription1.Text = "Description:"
        '
        'lblDescription2
        '
        Me.lblDescription2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
        Me.lblDescription2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDescription2.LocationFloat = New DevExpress.Utils.PointFloat(0.0002543131!, 82.33337!)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblDescription2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblDescription2.SizeF = New System.Drawing.SizeF(371.875!, 18.66663!)
        Me.lblDescription2.StylePriority.UseFont = false
        Me.lblDescription2.Text = "lblDescription2"
        '
        'lblModel1
        '
        Me.lblModel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblModel1.LocationFloat = New DevExpress.Utils.PointFloat(385.4167!, 14.58333!)
        Me.lblModel1.Name = "lblModel1"
        Me.lblModel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblModel1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblModel1.SizeF = New System.Drawing.SizeF(114.5833!, 12.58333!)
        Me.lblModel1.StylePriority.UseFont = false
        Me.lblModel1.Text = "Model:"
        '
        'lblModel2
        '
        Me.lblModel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Model")})
        Me.lblModel2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblModel2.LocationFloat = New DevExpress.Utils.PointFloat(500.0001!, 14.58333!)
        Me.lblModel2.Name = "lblModel2"
        Me.lblModel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblModel2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblModel2.SizeF = New System.Drawing.SizeF(240.9999!, 12.58334!)
        Me.lblModel2.StylePriority.UseFont = false
        Me.lblModel2.Text = "lblModel2"
        '
        'lblBrand1
        '
        Me.lblBrand1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBrand1.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05!, 14.58333!)
        Me.lblBrand1.Name = "lblBrand1"
        Me.lblBrand1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblBrand1.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblBrand1.SizeF = New System.Drawing.SizeF(113.5417!, 12.58334!)
        Me.lblBrand1.StylePriority.UseFont = false
        Me.lblBrand1.Text = "Brand:"
        '
        'lblBrand2
        '
        Me.lblBrand2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Brand")})
        Me.lblBrand2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblBrand2.LocationFloat = New DevExpress.Utils.PointFloat(113.5417!, 14.58333!)
        Me.lblBrand2.Name = "lblBrand2"
        Me.lblBrand2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblBrand2.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink
        Me.lblBrand2.SizeF = New System.Drawing.SizeF(258.3334!, 12.58334!)
        Me.lblBrand2.StylePriority.UseFont = false
        Me.lblBrand2.Text = "lblBrand2"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 49!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPage1, Me.lblPage2})
        Me.BottomMargin.HeightF = 49!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPage1
        '
        Me.lblPage1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.lblPage1.Name = "lblPage1"
        Me.lblPage1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblPage1.SizeF = New System.Drawing.SizeF(41.66667!, 23!)
        Me.lblPage1.Text = "Page:"
        '
        'lblPage2
        '
        Me.lblPage2.LocationFloat = New DevExpress.Utils.PointFloat(41.66667!, 10.00001!)
        Me.lblPage2.Name = "lblPage2"
        Me.lblPage2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblPage2.SizeF = New System.Drawing.SizeF(100!, 23!)
        '
        'lblHeader1
        '
        Me.lblHeader1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHeader1.LocationFloat = New DevExpress.Utils.PointFloat(200!, 10.00001!)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblHeader1.SizeF = New System.Drawing.SizeF(351.0417!, 23!)
        Me.lblHeader1.StylePriority.UseFont = false
        Me.lblHeader1.StylePriority.UseTextAlignment = false
        Me.lblHeader1.Text = "Hartville R-II School District"
        Me.lblHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblHeader2
        '
        Me.lblHeader2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblHeader2.LocationFloat = New DevExpress.Utils.PointFloat(200!, 33.00002!)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblHeader2.SizeF = New System.Drawing.SizeF(351.0417!, 21!)
        Me.lblHeader2.StylePriority.UseFont = false
        Me.lblHeader2.StylePriority.UseTextAlignment = false
        Me.lblHeader2.Text = "Inventory Management System"
        Me.lblHeader2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblHeaderUser
        '
        Me.lblHeaderUser.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.User, "Text", "")})
        Me.lblHeaderUser.LocationFloat = New DevExpress.Utils.PointFloat(543.0833!, 57.12503!)
        Me.lblHeaderUser.Name = "lblHeaderUser"
        Me.lblHeaderUser.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblHeaderUser.SizeF = New System.Drawing.SizeF(197.9167!, 23!)
        Me.lblHeaderUser.StylePriority.UseTextAlignment = false
        Me.lblHeaderUser.Text = "lblHeaderUser"
        Me.lblHeaderUser.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'User
        '
        Me.User.Name = "User"
        Me.User.Value = ""
        '
        'lblHeaderRoom
        '
        Me.lblHeaderRoom.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Room, "Text", "")})
        Me.lblHeaderRoom.LocationFloat = New DevExpress.Utils.PointFloat(543.0833!, 80.12502!)
        Me.lblHeaderRoom.Name = "lblHeaderRoom"
        Me.lblHeaderRoom.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblHeaderRoom.SizeF = New System.Drawing.SizeF(197.9167!, 23!)
        Me.lblHeaderRoom.StylePriority.UseTextAlignment = false
        Me.lblHeaderRoom.Text = "lblHeaderRoom"
        Me.lblHeaderRoom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Room
        '
        Me.Room.Name = "Room"
        Me.Room.Value = ""
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"),System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3.178914E-05!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(100!, 100!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblHeader2, Me.XrPictureBox1, Me.lblHeader1, Me.lblHeaderUser, Me.lblHeaderRoom})
        Me.ReportHeader.HeightF = 103.125!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(InventoryData.BusinessObjects.ComputerCollection)
        '
        'ComputerReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.DataSource = Me.BindingSource1
        Me.Detail.PrintOnEmptyDataSource = False
        Me.Margins = New System.Drawing.Printing.Margins(50, 49, 49, 49)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.User, Me.Room})
        Me.Version = "11.1"
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblName2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblType2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblModel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblModel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBrand1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBrand2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDescription1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDescription2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComments1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblComments2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblLicense1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLicense2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOS1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblOS2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSerial1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblSerial2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRAM1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRAM2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPage2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents lblPage1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHeader1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHeader2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHeaderUser As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblHeaderRoom As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents User As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Room As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblFundSource2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCost2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFundSource1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCost1 As DevExpress.XtraReports.UI.XRLabel
End Class
