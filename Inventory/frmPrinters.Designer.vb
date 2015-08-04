<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinters
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
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PrinterCollectionBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinterBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.dockPrinters = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.gridPrinter = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPrinter = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinterName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIPAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMACAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatePurchased5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFundSource5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondition5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repPrintersCondition = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiscard5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendor5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoried5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.navbarPrinter = New DevExpress.XtraNavBar.NavBarControl()
        Me.navPrinterBasic = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer25 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrinterComments = New DevExpress.XtraEditors.MemoEdit()
        Me.lblPrinterComments = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrinterVendor = New DevExpress.XtraEditors.TextEdit()
        Me.lblPrintersVendor = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrinterDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.dataPrinterPurchased = New DevExpress.XtraEditors.DateEdit()
        Me.cboPrinterModel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboPrinterCondition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboPrinterBrand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblPrinterDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinterCondition = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinterModel = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinterBrand = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrinterDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrinterName = New DevExpress.XtraEditors.TextEdit()
        Me.lblPrinterName = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrinterSerial = New DevExpress.XtraEditors.TextEdit()
        Me.lblPrinterSerial = New DevExpress.XtraEditors.LabelControl()
        Me.chkPrinterColor = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPrinterInventoried = New DevExpress.XtraEditors.CheckEdit()
        Me.NavBarGroupControlContainer27 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtPrinterID = New DevExpress.XtraEditors.TextEdit()
        Me.lblPrinterID = New DevExpress.XtraEditors.LabelControl()
        Me.navPrinterAdvanced = New DevExpress.XtraNavBar.NavBarGroup()
        CType(Me.PrinterCollectionBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinterBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockPrinters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPrinters.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.gridPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPrintersCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.navbarPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navbarPrinter.SuspendLayout()
        Me.NavBarGroupControlContainer25.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrinterComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrinterVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrinterDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPrinterPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPrinterPurchased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrinterModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrinterCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrinterBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrinterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrinterSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrinterColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrinterInventoried.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer27.SuspendLayout()
        CType(Me.txtPrinterID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrinterCollectionBinding
        '
        Me.PrinterCollectionBinding.DataSource = GetType(InventoryData.BusinessObjects.PrinterCollection)
        '
        'PrinterBinding
        '
        Me.PrinterBinding.DataSource = GetType(InventoryData.BusinessObjects.Printer)
        '
        'dockPrinters
        '
        Me.dockPrinters.ActiveWindow = Me.DocumentWindow1
        Me.dockPrinters.Controls.Add(Me.DocumentContainer1)
        Me.dockPrinters.Controls.Add(Me.ToolTabStrip1)
        Me.dockPrinters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockPrinters.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.dockPrinters.IsCleanUpTarget = True
        Me.dockPrinters.Location = New System.Drawing.Point(0, 0)
        Me.dockPrinters.MainDocumentContainer = Me.DocumentContainer1
        Me.dockPrinters.Name = "dockPrinters"
        Me.dockPrinters.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.dockPrinters.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.dockPrinters.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.dockPrinters.Size = New System.Drawing.Size(960, 693)
        Me.dockPrinters.SplitterWidth = 4
        Me.dockPrinters.TabIndex = 0
        Me.dockPrinters.TabStop = False
        Me.dockPrinters.Text = "RadDock1"
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.gridPrinter)
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 30)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(602, 647)
        Me.DocumentWindow1.Text = "Printers"
        '
        'gridPrinter
        '
        Me.gridPrinter.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridPrinter.DataSource = Me.PrinterCollectionBinding
        Me.gridPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPrinter.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridPrinter.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridPrinter.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridPrinter.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridPrinter.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridPrinter.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridPrinter.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridPrinter.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridPrinter.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridPrinter.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridPrinter.Location = New System.Drawing.Point(0, 0)
        Me.gridPrinter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridPrinter.MainView = Me.GridViewPrinter
        Me.gridPrinter.Name = "gridPrinter"
        Me.gridPrinter.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit4, Me.repPrintersCondition})
        Me.gridPrinter.Size = New System.Drawing.Size(602, 647)
        Me.gridPrinter.TabIndex = 16
        Me.gridPrinter.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPrinter})
        '
        'GridViewPrinter
        '
        Me.GridViewPrinter.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewPrinter.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewPrinter.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewPrinter.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewPrinter.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewPrinter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GridViewPrinter.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId6, Me.colPrinterName, Me.colIPAddress1, Me.colMACAddress, Me.colColor, Me.colRoomID5, Me.colType5, Me.colSerialNo4, Me.colBrand4, Me.colModel4, Me.colDescription5, Me.colDatePurchased5, Me.colCost5, Me.colFundSource5, Me.colCondition5, Me.colDiscard5, Me.colVendor5, Me.colInventoried5, Me.colComments5})
        Me.GridViewPrinter.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridViewPrinter.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridViewPrinter.GridControl = Me.gridPrinter
        Me.GridViewPrinter.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridViewPrinter.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.GridViewPrinter.Name = "GridViewPrinter"
        Me.GridViewPrinter.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewPrinter.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewPrinter.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.GridViewPrinter.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.GridViewPrinter.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.GridViewPrinter.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewPrinter.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.GridViewPrinter.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.GridViewPrinter.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.GridViewPrinter.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.GridViewPrinter.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.GridViewPrinter.OptionsView.RowAutoHeight = True
        Me.GridViewPrinter.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.GridViewPrinter.OptionsView.ShowGroupPanel = False
        Me.GridViewPrinter.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridViewPrinter.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colId6
        '
        Me.colId6.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId6.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId6.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId6.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId6.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId6.FieldName = "Id"
        Me.colId6.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colId6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colId6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colId6.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colId6.Name = "colId6"
        Me.colId6.OptionsColumn.AllowEdit = False
        Me.colId6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colId6.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colId6.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId6.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId6.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colId6.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colId6.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colPrinterName
        '
        Me.colPrinterName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colPrinterName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colPrinterName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colPrinterName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colPrinterName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colPrinterName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colPrinterName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colPrinterName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colPrinterName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colPrinterName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colPrinterName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colPrinterName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colPrinterName.FieldName = "PrinterName"
        Me.colPrinterName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colPrinterName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colPrinterName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colPrinterName.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colPrinterName.Name = "colPrinterName"
        Me.colPrinterName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colPrinterName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colPrinterName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colPrinterName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colPrinterName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colPrinterName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colPrinterName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colPrinterName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colPrinterName.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colPrinterName.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colPrinterName.Visible = True
        Me.colPrinterName.VisibleIndex = 0
        '
        'colIPAddress1
        '
        Me.colIPAddress1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIPAddress1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIPAddress1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIPAddress1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIPAddress1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIPAddress1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIPAddress1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colIPAddress1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colIPAddress1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colIPAddress1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colIPAddress1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colIPAddress1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colIPAddress1.FieldName = "IPAddress"
        Me.colIPAddress1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colIPAddress1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colIPAddress1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colIPAddress1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colIPAddress1.Name = "colIPAddress1"
        Me.colIPAddress1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIPAddress1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIPAddress1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIPAddress1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colIPAddress1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colIPAddress1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIPAddress1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colIPAddress1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colIPAddress1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colIPAddress1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colMACAddress
        '
        Me.colMACAddress.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colMACAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colMACAddress.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colMACAddress.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colMACAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colMACAddress.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colMACAddress.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colMACAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colMACAddress.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colMACAddress.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colMACAddress.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colMACAddress.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colMACAddress.FieldName = "MACAddress"
        Me.colMACAddress.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colMACAddress.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colMACAddress.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colMACAddress.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colMACAddress.Name = "colMACAddress"
        Me.colMACAddress.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMACAddress.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMACAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMACAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colMACAddress.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colMACAddress.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMACAddress.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMACAddress.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colMACAddress.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colMACAddress.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colColor
        '
        Me.colColor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colColor.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colColor.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colColor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colColor.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colColor.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colColor.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colColor.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colColor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colColor.FieldName = "Color"
        Me.colColor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colColor.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colColor.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colColor.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colColor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colColor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colColor.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colColor.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colColor.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colColor.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colColor.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colColor.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 2
        '
        'colRoomID5
        '
        Me.colRoomID5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID5.FieldName = "RoomID"
        Me.colRoomID5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colRoomID5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colRoomID5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colRoomID5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colRoomID5.Name = "colRoomID5"
        Me.colRoomID5.OptionsColumn.AllowEdit = False
        Me.colRoomID5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colRoomID5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colRoomID5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colRoomID5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colRoomID5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colType5
        '
        Me.colType5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType5.FieldName = "Type"
        Me.colType5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colType5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colType5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colType5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colType5.Name = "colType5"
        Me.colType5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colType5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colType5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colType5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colType5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colSerialNo4
        '
        Me.colSerialNo4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo4.FieldName = "SerialNo"
        Me.colSerialNo4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colSerialNo4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colSerialNo4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colSerialNo4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colSerialNo4.Name = "colSerialNo4"
        Me.colSerialNo4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colSerialNo4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colSerialNo4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colSerialNo4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colSerialNo4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colBrand4
        '
        Me.colBrand4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand4.FieldName = "Brand"
        Me.colBrand4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colBrand4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colBrand4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colBrand4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colBrand4.Name = "colBrand4"
        Me.colBrand4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colBrand4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colBrand4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colBrand4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colBrand4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colBrand4.Visible = True
        Me.colBrand4.VisibleIndex = 3
        '
        'colModel4
        '
        Me.colModel4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel4.FieldName = "Model"
        Me.colModel4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colModel4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colModel4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colModel4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colModel4.Name = "colModel4"
        Me.colModel4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colModel4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colModel4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colModel4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colModel4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colModel4.Visible = True
        Me.colModel4.VisibleIndex = 4
        '
        'colDescription5
        '
        Me.colDescription5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription5.FieldName = "Description"
        Me.colDescription5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDescription5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDescription5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDescription5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDescription5.Name = "colDescription5"
        Me.colDescription5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDescription5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDescription5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDescription5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDescription5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colDatePurchased5
        '
        Me.colDatePurchased5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased5.FieldName = "DatePurchased"
        Me.colDatePurchased5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDatePurchased5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDatePurchased5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDatePurchased5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDatePurchased5.Name = "colDatePurchased5"
        Me.colDatePurchased5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDatePurchased5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDatePurchased5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDatePurchased5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDatePurchased5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCost5
        '
        Me.colCost5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost5.DisplayFormat.FormatString = "$###,###.00"
        Me.colCost5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCost5.FieldName = "Cost"
        Me.colCost5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCost5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCost5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCost5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCost5.Name = "colCost5"
        Me.colCost5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCost5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCost5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCost5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCost5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCost5.Visible = True
        Me.colCost5.VisibleIndex = 1
        '
        'colFundSource5
        '
        Me.colFundSource5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource5.FieldName = "FundSource"
        Me.colFundSource5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colFundSource5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colFundSource5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colFundSource5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colFundSource5.Name = "colFundSource5"
        Me.colFundSource5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colFundSource5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colFundSource5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colFundSource5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colFundSource5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCondition5
        '
        Me.colCondition5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition5.ColumnEdit = Me.repPrintersCondition
        Me.colCondition5.FieldName = "Condition"
        Me.colCondition5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCondition5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCondition5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCondition5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCondition5.Name = "colCondition5"
        Me.colCondition5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCondition5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCondition5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCondition5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCondition5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCondition5.Visible = True
        Me.colCondition5.VisibleIndex = 5
        '
        'repPrintersCondition
        '
        Me.repPrintersCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.repPrintersCondition.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.repPrintersCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repPrintersCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repPrintersCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repPrintersCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repPrintersCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repPrintersCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repPrintersCondition.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repPrintersCondition.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repPrintersCondition.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repPrintersCondition.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repPrintersCondition.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repPrintersCondition.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repPrintersCondition.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repPrintersCondition.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repPrintersCondition.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repPrintersCondition.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repPrintersCondition.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repPrintersCondition.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repPrintersCondition.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repPrintersCondition.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repPrintersCondition.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repPrintersCondition.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repPrintersCondition.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repPrintersCondition.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repPrintersCondition.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repPrintersCondition.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.AutoHeight = False
        Me.repPrintersCondition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repPrintersCondition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.repPrintersCondition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.repPrintersCondition.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.repPrintersCondition.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.repPrintersCondition.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.repPrintersCondition.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.repPrintersCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.repPrintersCondition.Name = "repPrintersCondition"
        Me.repPrintersCondition.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.repPrintersCondition.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.repPrintersCondition.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDiscard5
        '
        Me.colDiscard5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard5.FieldName = "Discard"
        Me.colDiscard5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDiscard5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDiscard5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDiscard5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDiscard5.Name = "colDiscard5"
        Me.colDiscard5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDiscard5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDiscard5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDiscard5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDiscard5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colVendor5
        '
        Me.colVendor5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor5.FieldName = "Vendor"
        Me.colVendor5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colVendor5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colVendor5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colVendor5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colVendor5.Name = "colVendor5"
        Me.colVendor5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colVendor5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colVendor5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colVendor5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colVendor5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colInventoried5
        '
        Me.colInventoried5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried5.FieldName = "Inventoried"
        Me.colInventoried5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colInventoried5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colInventoried5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colInventoried5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colInventoried5.Name = "colInventoried5"
        Me.colInventoried5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colInventoried5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colInventoried5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colInventoried5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colInventoried5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colInventoried5.Visible = True
        Me.colInventoried5.VisibleIndex = 6
        '
        'colComments5
        '
        Me.colComments5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments5.FieldName = "Comments"
        Me.colComments5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colComments5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colComments5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colComments5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colComments5.Name = "colComments5"
        Me.colComments5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colComments5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colComments5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colComments5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colComments5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemMemoEdit4.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemMemoEdit4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit4.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit4.AppearanceFocused.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit4.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RepositoryItemMemoEdit4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemMemoEdit4.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemMemoEdit4.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemMemoEdit4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        Me.RepositoryItemMemoEdit4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(5, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.Size = New System.Drawing.Size(614, 683)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(614, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-132, 0)
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = False
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(614, 683)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(623, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(332, 683)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(332, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(132, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Controls.Add(Me.navbarPrinter)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(330, 657)
        Me.ToolWindow1.Text = "Details"
        '
        'navbarPrinter
        '
        Me.navbarPrinter.ActiveGroup = Me.navPrinterBasic
        Me.navbarPrinter.Appearance.Background.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.Background.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.Background.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.Background.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.Background.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.Background.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.Button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.Button.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.Button.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.Button.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.Button.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.GroupBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.GroupBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.GroupBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.GroupBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.GroupHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.GroupHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.GroupHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.GroupHeaderPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.GroupHeaderPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.Hint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.Hint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.Hint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.Hint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.Hint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.Hint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.Item.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.Item.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.Item.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.Item.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.Item.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.Item.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ItemActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ItemActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ItemActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ItemActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ItemDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ItemDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ItemDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ItemHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ItemHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ItemHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.ItemPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.ItemPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.ItemPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.LinkDropTarget.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.LinkDropTarget.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.LinkDropTarget.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.LinkDropTarget.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.LinkDropTarget.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.LinkDropTarget.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.NavigationPaneHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.NavigationPaneHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.NavigationPaneHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.NavigationPaneHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.NavigationPaneHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.NavPaneContentButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarPrinter.Appearance.NavPaneContentButtonReleased.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarPrinter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.navbarPrinter.Controls.Add(Me.NavBarGroupControlContainer25)
        Me.navbarPrinter.Controls.Add(Me.NavBarGroupControlContainer27)
        Me.navbarPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navbarPrinter.DragDropFlags = CType((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop), DevExpress.XtraNavBar.NavBarDragDrop)
        Me.navbarPrinter.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navPrinterBasic, Me.navPrinterAdvanced})
        Me.navbarPrinter.Location = New System.Drawing.Point(0, 0)
        Me.navbarPrinter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.navbarPrinter.Name = "navbarPrinter"
        Me.navbarPrinter.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Normal
        Me.navbarPrinter.OptionsNavPane.ExpandedWidth = 239
        Me.navbarPrinter.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        Me.navbarPrinter.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.[Default]
        Me.navbarPrinter.Size = New System.Drawing.Size(330, 657)
        Me.navbarPrinter.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.[Default]
        Me.navbarPrinter.TabIndex = 17
        Me.navbarPrinter.Text = "NavBarControl4"
        '
        'navPrinterBasic
        '
        Me.navPrinterBasic.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterBasic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterBasic.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterBasic.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterBasic.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterBasic.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterBasic.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterBasic.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterBasic.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterBasic.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterBasic.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterBasic.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterBasic.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterBasic.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterBasic.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterBasic.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterBasic.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterBasic.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterBasic.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterBasic.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterBasic.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterBasic.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterBasic.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterBasic.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterBasic.Caption = "Basic Properties"
        Me.navPrinterBasic.ControlContainer = Me.NavBarGroupControlContainer25
        Me.navPrinterBasic.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navPrinterBasic.Expanded = True
        Me.navPrinterBasic.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navPrinterBasic.GroupClientHeight = 505
        Me.navPrinterBasic.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navPrinterBasic.LargeImage = Global.Inventory.My.Resources.Resources.HP_Printer_32
        Me.navPrinterBasic.Name = "navPrinterBasic"
        '
        'NavBarGroupControlContainer25
        '
        Me.NavBarGroupControlContainer25.Controls.Add(Me.ComboBoxEdit1)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.LabelControl1)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.TextEdit1)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.LabelControl2)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.txtPrinterComments)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterComments)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.txtPrinterVendor)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrintersVendor)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.txtPrinterDescription)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.dataPrinterPurchased)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.cboPrinterModel)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.cboPrinterCondition)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.cboPrinterBrand)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterDate)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterCondition)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterModel)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterBrand)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterDescription)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.txtPrinterName)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterName)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.txtPrinterSerial)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.lblPrinterSerial)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.chkPrinterColor)
        Me.NavBarGroupControlContainer25.Controls.Add(Me.chkPrinterInventoried)
        Me.NavBarGroupControlContainer25.Name = "NavBarGroupControlContainer25"
        Me.NavBarGroupControlContainer25.Size = New System.Drawing.Size(326, 503)
        Me.NavBarGroupControlContainer25.TabIndex = 1
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ComboBoxEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "FundSource", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(105, 168)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ComboBoxEdit1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ComboBoxEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ComboBoxEdit1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ComboBoxEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ComboBoxEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ComboBoxEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ComboBoxEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.ComboBoxEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ComboBoxEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ComboBoxEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ComboBoxEdit1.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.ComboBoxEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ComboBoxEdit1.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.ComboBoxEdit1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(217, 20)
        Me.ComboBoxEdit1.TabIndex = 35
        Me.ComboBoxEdit1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LabelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LabelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.LabelControl1.Location = New System.Drawing.Point(12, 171)
        Me.LabelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Fund Source:"
        Me.LabelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TextEdit1
        '
        Me.TextEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Cost", True))
        Me.TextEdit1.Location = New System.Drawing.Point(105, 142)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TextEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TextEdit1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEdit1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEdit1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEdit1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEdit1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TextEdit1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TextEdit1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TextEdit1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TextEdit1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.TextEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "c"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TextEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TextEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TextEdit1.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.TextEdit1.Properties.Mask.EditMask = "c"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Size = New System.Drawing.Size(217, 20)
        Me.TextEdit1.TabIndex = 33
        Me.TextEdit1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'LabelControl2
        '
        Me.LabelControl2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LabelControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LabelControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.LabelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.LabelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.LabelControl2.Location = New System.Drawing.Point(12, 145)
        Me.LabelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Cost:"
        Me.LabelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrinterComments
        '
        Me.txtPrinterComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterComments.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Comments", True))
        Me.txtPrinterComments.Location = New System.Drawing.Point(12, 375)
        Me.txtPrinterComments.Name = "txtPrinterComments"
        Me.txtPrinterComments.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterComments.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterComments.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterComments.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterComments.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterComments.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterComments.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterComments.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterComments.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterComments.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterComments.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterComments.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterComments.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterComments.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterComments.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterComments.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterComments.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterComments.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterComments.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterComments.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterComments.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterComments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterComments.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterComments.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterComments.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterComments.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterComments.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrinterComments.Size = New System.Drawing.Size(310, 70)
        Me.txtPrinterComments.TabIndex = 31
        Me.txtPrinterComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterComments
        '
        Me.lblPrinterComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterComments.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterComments.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterComments.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterComments.Appearance.Options.UseFont = True
        Me.lblPrinterComments.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterComments.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterComments.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterComments.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterComments.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterComments.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterComments.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterComments.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterComments.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterComments.Location = New System.Drawing.Point(12, 356)
        Me.lblPrinterComments.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterComments.Name = "lblPrinterComments"
        Me.lblPrinterComments.Size = New System.Drawing.Size(64, 13)
        Me.lblPrinterComments.TabIndex = 30
        Me.lblPrinterComments.Text = "Comments:"
        Me.lblPrinterComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrinterVendor
        '
        Me.txtPrinterVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterVendor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Vendor", True))
        Me.txtPrinterVendor.Location = New System.Drawing.Point(105, 220)
        Me.txtPrinterVendor.Name = "txtPrinterVendor"
        Me.txtPrinterVendor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterVendor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterVendor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterVendor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterVendor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterVendor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterVendor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterVendor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterVendor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterVendor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterVendor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterVendor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterVendor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterVendor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterVendor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterVendor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterVendor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterVendor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterVendor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterVendor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterVendor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterVendor.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPrinterVendor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPrinterVendor.Size = New System.Drawing.Size(217, 20)
        Me.txtPrinterVendor.TabIndex = 28
        Me.txtPrinterVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrintersVendor
        '
        Me.lblPrintersVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrintersVendor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrintersVendor.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrintersVendor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrintersVendor.Appearance.Options.UseFont = True
        Me.lblPrintersVendor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrintersVendor.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrintersVendor.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrintersVendor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrintersVendor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrintersVendor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrintersVendor.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrintersVendor.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrintersVendor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrintersVendor.Location = New System.Drawing.Point(12, 223)
        Me.lblPrintersVendor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrintersVendor.Name = "lblPrintersVendor"
        Me.lblPrintersVendor.Size = New System.Drawing.Size(43, 13)
        Me.lblPrintersVendor.TabIndex = 29
        Me.lblPrintersVendor.Text = "Vendor:"
        Me.lblPrintersVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrinterDescription
        '
        Me.txtPrinterDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Description", True))
        Me.txtPrinterDescription.Location = New System.Drawing.Point(12, 280)
        Me.txtPrinterDescription.Name = "txtPrinterDescription"
        Me.txtPrinterDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterDescription.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterDescription.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterDescription.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterDescription.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterDescription.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterDescription.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterDescription.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterDescription.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterDescription.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterDescription.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterDescription.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterDescription.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterDescription.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterDescription.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterDescription.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterDescription.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterDescription.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterDescription.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterDescription.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrinterDescription.Size = New System.Drawing.Size(310, 70)
        Me.txtPrinterDescription.TabIndex = 6
        Me.txtPrinterDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dataPrinterPurchased
        '
        Me.dataPrinterPurchased.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataPrinterPurchased.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataPrinterPurchased.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "DatePurchased", True))
        Me.dataPrinterPurchased.EditValue = Nothing
        Me.dataPrinterPurchased.Location = New System.Drawing.Point(105, 116)
        Me.dataPrinterPurchased.Name = "dataPrinterPurchased"
        Me.dataPrinterPurchased.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataPrinterPurchased.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataPrinterPurchased.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.dataPrinterPurchased.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataPrinterPurchased.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dataPrinterPurchased.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataPrinterPurchased.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataPrinterPurchased.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataPrinterPurchased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataPrinterPurchased.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.dataPrinterPurchased.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.dataPrinterPurchased.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataPrinterPurchased.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataPrinterPurchased.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject4.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.dataPrinterPurchased.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataPrinterPurchased.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.dataPrinterPurchased.Size = New System.Drawing.Size(217, 20)
        Me.dataPrinterPurchased.TabIndex = 4
        Me.dataPrinterPurchased.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboPrinterModel
        '
        Me.cboPrinterModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterModel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPrinterModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Model", True))
        Me.cboPrinterModel.Location = New System.Drawing.Point(105, 90)
        Me.cboPrinterModel.Name = "cboPrinterModel"
        Me.cboPrinterModel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboPrinterModel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterModel.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterModel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterModel.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterModel.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterModel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterModel.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterModel.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterModel.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterModel.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterModel.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterModel.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterModel.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterModel.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterModel.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterModel.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterModel.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterModel.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterModel.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterModel.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject5.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject5.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.cboPrinterModel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPrinterModel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboPrinterModel.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboPrinterModel.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboPrinterModel.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboPrinterModel.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboPrinterModel.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboPrinterModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboPrinterModel.Size = New System.Drawing.Size(217, 20)
        Me.cboPrinterModel.TabIndex = 3
        Me.cboPrinterModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboPrinterCondition
        '
        Me.cboPrinterCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPrinterCondition.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Condition", True))
        Me.cboPrinterCondition.Location = New System.Drawing.Point(105, 194)
        Me.cboPrinterCondition.Name = "cboPrinterCondition"
        Me.cboPrinterCondition.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboPrinterCondition.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterCondition.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterCondition.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterCondition.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterCondition.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterCondition.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterCondition.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterCondition.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterCondition.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterCondition.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterCondition.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterCondition.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterCondition.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject6.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject6.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject6.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.cboPrinterCondition.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPrinterCondition.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboPrinterCondition.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboPrinterCondition.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboPrinterCondition.Properties.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.cboPrinterCondition.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboPrinterCondition.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboPrinterCondition.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboPrinterCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPrinterCondition.Size = New System.Drawing.Size(217, 20)
        Me.cboPrinterCondition.TabIndex = 3
        Me.cboPrinterCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboPrinterBrand
        '
        Me.cboPrinterBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterBrand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPrinterBrand.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Brand", True))
        Me.cboPrinterBrand.Location = New System.Drawing.Point(105, 64)
        Me.cboPrinterBrand.Name = "cboPrinterBrand"
        Me.cboPrinterBrand.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboPrinterBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboPrinterBrand.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterBrand.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterBrand.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterBrand.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterBrand.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterBrand.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterBrand.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterBrand.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterBrand.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterBrand.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterBrand.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboPrinterBrand.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject7.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject7.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject7.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject7.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject7.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboPrinterBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.cboPrinterBrand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPrinterBrand.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboPrinterBrand.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboPrinterBrand.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboPrinterBrand.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboPrinterBrand.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboPrinterBrand.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboPrinterBrand.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboPrinterBrand.Size = New System.Drawing.Size(217, 20)
        Me.cboPrinterBrand.TabIndex = 3
        Me.cboPrinterBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterDate
        '
        Me.lblPrinterDate.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterDate.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterDate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterDate.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterDate.Appearance.Options.UseFont = True
        Me.lblPrinterDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterDate.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterDate.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterDate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterDate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterDate.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterDate.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterDate.Location = New System.Drawing.Point(12, 119)
        Me.lblPrinterDate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterDate.Name = "lblPrinterDate"
        Me.lblPrinterDate.Size = New System.Drawing.Size(92, 13)
        Me.lblPrinterDate.TabIndex = 1
        Me.lblPrinterDate.Text = "Date Purchased:"
        Me.lblPrinterDate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterCondition
        '
        Me.lblPrinterCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterCondition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterCondition.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterCondition.Appearance.Options.UseFont = True
        Me.lblPrinterCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterCondition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterCondition.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterCondition.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterCondition.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterCondition.Location = New System.Drawing.Point(12, 197)
        Me.lblPrinterCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterCondition.Name = "lblPrinterCondition"
        Me.lblPrinterCondition.Size = New System.Drawing.Size(56, 13)
        Me.lblPrinterCondition.TabIndex = 1
        Me.lblPrinterCondition.Text = "Condition:"
        Me.lblPrinterCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterModel
        '
        Me.lblPrinterModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterModel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterModel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterModel.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterModel.Appearance.Options.UseFont = True
        Me.lblPrinterModel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterModel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterModel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterModel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterModel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterModel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterModel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterModel.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterModel.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterModel.Location = New System.Drawing.Point(12, 93)
        Me.lblPrinterModel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterModel.Name = "lblPrinterModel"
        Me.lblPrinterModel.Size = New System.Drawing.Size(37, 13)
        Me.lblPrinterModel.TabIndex = 1
        Me.lblPrinterModel.Text = "Model:"
        Me.lblPrinterModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterBrand
        '
        Me.lblPrinterBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterBrand.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterBrand.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterBrand.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterBrand.Appearance.Options.UseFont = True
        Me.lblPrinterBrand.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterBrand.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterBrand.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterBrand.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterBrand.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterBrand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterBrand.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterBrand.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterBrand.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterBrand.Location = New System.Drawing.Point(12, 67)
        Me.lblPrinterBrand.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterBrand.Name = "lblPrinterBrand"
        Me.lblPrinterBrand.Size = New System.Drawing.Size(36, 13)
        Me.lblPrinterBrand.TabIndex = 1
        Me.lblPrinterBrand.Text = "Brand:"
        Me.lblPrinterBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterDescription
        '
        Me.lblPrinterDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterDescription.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterDescription.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterDescription.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterDescription.Appearance.Options.UseFont = True
        Me.lblPrinterDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterDescription.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterDescription.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterDescription.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterDescription.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterDescription.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterDescription.Location = New System.Drawing.Point(12, 261)
        Me.lblPrinterDescription.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterDescription.Name = "lblPrinterDescription"
        Me.lblPrinterDescription.Size = New System.Drawing.Size(64, 13)
        Me.lblPrinterDescription.TabIndex = 1
        Me.lblPrinterDescription.Text = "Description"
        Me.lblPrinterDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrinterName
        '
        Me.txtPrinterName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "PrinterName", True))
        Me.txtPrinterName.Location = New System.Drawing.Point(105, 12)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterName.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterName.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterName.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterName.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterName.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterName.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterName.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterName.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterName.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterName.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterName.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterName.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPrinterName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPrinterName.Size = New System.Drawing.Size(217, 20)
        Me.txtPrinterName.TabIndex = 2
        Me.txtPrinterName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterName
        '
        Me.lblPrinterName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterName.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterName.Appearance.Options.UseFont = True
        Me.lblPrinterName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterName.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterName.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterName.Location = New System.Drawing.Point(12, 15)
        Me.lblPrinterName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterName.Name = "lblPrinterName"
        Me.lblPrinterName.Size = New System.Drawing.Size(35, 13)
        Me.lblPrinterName.TabIndex = 1
        Me.lblPrinterName.Text = "Name:"
        Me.lblPrinterName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrinterSerial
        '
        Me.txtPrinterSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterSerial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterSerial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "SerialNo", True))
        Me.txtPrinterSerial.Location = New System.Drawing.Point(105, 38)
        Me.txtPrinterSerial.Name = "txtPrinterSerial"
        Me.txtPrinterSerial.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterSerial.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterSerial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterSerial.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterSerial.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterSerial.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterSerial.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterSerial.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterSerial.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterSerial.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterSerial.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterSerial.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterSerial.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterSerial.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterSerial.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterSerial.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterSerial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterSerial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterSerial.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterSerial.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterSerial.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterSerial.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPrinterSerial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPrinterSerial.Size = New System.Drawing.Size(217, 20)
        Me.txtPrinterSerial.TabIndex = 2
        Me.txtPrinterSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterSerial
        '
        Me.lblPrinterSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterSerial.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterSerial.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterSerial.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterSerial.Appearance.Options.UseFont = True
        Me.lblPrinterSerial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterSerial.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterSerial.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterSerial.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterSerial.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterSerial.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterSerial.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterSerial.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterSerial.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterSerial.Location = New System.Drawing.Point(12, 41)
        Me.lblPrinterSerial.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterSerial.Name = "lblPrinterSerial"
        Me.lblPrinterSerial.Size = New System.Drawing.Size(82, 13)
        Me.lblPrinterSerial.TabIndex = 1
        Me.lblPrinterSerial.Text = "Serial Number:"
        Me.lblPrinterSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'chkPrinterColor
        '
        Me.chkPrinterColor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.chkPrinterColor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Color", True))
        Me.chkPrinterColor.Location = New System.Drawing.Point(10, 451)
        Me.chkPrinterColor.Name = "chkPrinterColor"
        Me.chkPrinterColor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.chkPrinterColor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrinterColor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterColor.Properties.Appearance.Options.UseFont = True
        Me.chkPrinterColor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterColor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterColor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterColor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterColor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterColor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterColor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterColor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterColor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterColor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterColor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterColor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterColor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterColor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterColor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterColor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterColor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterColor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.chkPrinterColor.Properties.Caption = "Color Printer"
        Me.chkPrinterColor.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.chkPrinterColor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.chkPrinterColor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.chkPrinterColor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.chkPrinterColor.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.chkPrinterColor.Size = New System.Drawing.Size(96, 19)
        Me.chkPrinterColor.TabIndex = 0
        Me.chkPrinterColor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'chkPrinterInventoried
        '
        Me.chkPrinterInventoried.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.chkPrinterInventoried.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Inventoried", True))
        Me.chkPrinterInventoried.Location = New System.Drawing.Point(10, 476)
        Me.chkPrinterInventoried.Name = "chkPrinterInventoried"
        Me.chkPrinterInventoried.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.chkPrinterInventoried.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrinterInventoried.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterInventoried.Properties.Appearance.Options.UseFont = True
        Me.chkPrinterInventoried.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterInventoried.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterInventoried.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterInventoried.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterInventoried.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterInventoried.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkPrinterInventoried.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkPrinterInventoried.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.chkPrinterInventoried.Properties.Caption = "Inventoried"
        Me.chkPrinterInventoried.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.chkPrinterInventoried.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.chkPrinterInventoried.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.chkPrinterInventoried.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.chkPrinterInventoried.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.chkPrinterInventoried.Size = New System.Drawing.Size(96, 19)
        Me.chkPrinterInventoried.TabIndex = 0
        Me.chkPrinterInventoried.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer27
        '
        Me.NavBarGroupControlContainer27.Controls.Add(Me.txtPrinterID)
        Me.NavBarGroupControlContainer27.Controls.Add(Me.lblPrinterID)
        Me.NavBarGroupControlContainer27.Name = "NavBarGroupControlContainer27"
        Me.NavBarGroupControlContainer27.Size = New System.Drawing.Size(409, 45)
        Me.NavBarGroupControlContainer27.TabIndex = 3
        '
        'txtPrinterID
        '
        Me.txtPrinterID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrinterBinding, "Id", True))
        Me.txtPrinterID.Location = New System.Drawing.Point(47, 12)
        Me.txtPrinterID.Name = "txtPrinterID"
        Me.txtPrinterID.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrinterID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrinterID.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterID.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterID.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterID.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterID.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterID.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterID.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterID.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterID.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterID.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterID.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrinterID.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrinterID.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrinterID.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrinterID.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrinterID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrinterID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrinterID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrinterID.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrinterID.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrinterID.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPrinterID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPrinterID.Properties.ReadOnly = True
        Me.txtPrinterID.Size = New System.Drawing.Size(358, 20)
        Me.txtPrinterID.TabIndex = 4
        Me.txtPrinterID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblPrinterID
        '
        Me.lblPrinterID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPrinterID.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrinterID.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPrinterID.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrinterID.Appearance.Options.UseFont = True
        Me.lblPrinterID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPrinterID.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPrinterID.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPrinterID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPrinterID.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPrinterID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPrinterID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPrinterID.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPrinterID.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPrinterID.Location = New System.Drawing.Point(12, 15)
        Me.lblPrinterID.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPrinterID.Name = "lblPrinterID"
        Me.lblPrinterID.Size = New System.Drawing.Size(16, 13)
        Me.lblPrinterID.TabIndex = 3
        Me.lblPrinterID.Text = "ID:"
        Me.lblPrinterID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'navPrinterAdvanced
        '
        Me.navPrinterAdvanced.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterAdvanced.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterAdvanced.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterAdvanced.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterAdvanced.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterAdvanced.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterAdvanced.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterAdvanced.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterAdvanced.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterAdvanced.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterAdvanced.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterAdvanced.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterAdvanced.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterAdvanced.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterAdvanced.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterAdvanced.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterAdvanced.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterAdvanced.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterAdvanced.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navPrinterAdvanced.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navPrinterAdvanced.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navPrinterAdvanced.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navPrinterAdvanced.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navPrinterAdvanced.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navPrinterAdvanced.Caption = "Advanced Properties"
        Me.navPrinterAdvanced.ControlContainer = Me.NavBarGroupControlContainer27
        Me.navPrinterAdvanced.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navPrinterAdvanced.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navPrinterAdvanced.GroupClientHeight = 47
        Me.navPrinterAdvanced.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navPrinterAdvanced.LargeImage = Global.Inventory.My.Resources.Resources.Config_32
        Me.navPrinterAdvanced.Name = "navPrinterAdvanced"
        '
        'frmPrinters
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 693)
        Me.Controls.Add(Me.dockPrinters)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmPrinters"
        Me.Text = "Printers"
        CType(Me.PrinterCollectionBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinterBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockPrinters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPrinters.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.gridPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPrintersCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.navbarPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navbarPrinter.ResumeLayout(False)
        Me.NavBarGroupControlContainer25.ResumeLayout(False)
        Me.NavBarGroupControlContainer25.PerformLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrinterComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrinterVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrinterDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPrinterPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPrinterPurchased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrinterModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrinterCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrinterBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrinterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrinterSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrinterColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrinterInventoried.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer27.ResumeLayout(False)
        Me.NavBarGroupControlContainer27.PerformLayout()
        CType(Me.txtPrinterID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrinterCollectionBinding As System.Windows.Forms.BindingSource
    Friend WithEvents PrinterBinding As System.Windows.Forms.BindingSource
    Friend WithEvents dockPrinters As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents navbarPrinter As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroupControlContainer25 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtPrinterComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblPrinterComments As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrinterVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrintersVendor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrinterDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dataPrinterPurchased As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboPrinterModel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboPrinterCondition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboPrinterBrand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblPrinterDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinterCondition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinterModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinterBrand As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrinterDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrinterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrinterName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrinterSerial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrinterSerial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkPrinterColor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPrinterInventoried As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents NavBarGroupControlContainer27 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtPrinterID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPrinterID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents navPrinterBasic As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navPrinterAdvanced As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridPrinter As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPrinter As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinterName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMACAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoomID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatePurchased5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFundSource5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondition5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repPrintersCondition As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDiscard5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendor5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoried5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
