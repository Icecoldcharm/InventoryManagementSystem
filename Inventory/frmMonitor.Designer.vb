<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitor
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
        Me.MonitorCollectionBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonitorBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.dockMonitor = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.gridMonitor = New DevExpress.XtraGrid.GridControl()
        Me.GridViewMonitor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonitorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatePurchased4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFundSource4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondition4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repMonitorsCondition = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiscard4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendor4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoried4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.navbarMonitor = New DevExpress.XtraNavBar.NavBarControl()
        Me.navMonitorBasic = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer21 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cboMonitorFund = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMonitorComments = New DevExpress.XtraEditors.MemoEdit()
        Me.lblMonitorFund = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorComments = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonitorCost = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonitorCost = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonitorVendor = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonitorVendor = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonitorDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.dataMonitorPurchased = New DevExpress.XtraEditors.DateEdit()
        Me.cboMonitorModel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMonitorCondition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboMonitorBrand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblMonitorDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorCondition = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorModel = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorBrand = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonitorName = New DevExpress.XtraEditors.TextEdit()
        Me.txtMonitorSerial = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonitorName = New DevExpress.XtraEditors.LabelControl()
        Me.lblMonitorSerial = New DevExpress.XtraEditors.LabelControl()
        Me.chkMonitorInventoried = New DevExpress.XtraEditors.CheckEdit()
        Me.NavBarGroupControlContainer23 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtMonitorID = New DevExpress.XtraEditors.TextEdit()
        Me.lblMonitorID = New DevExpress.XtraEditors.LabelControl()
        Me.navMonitorAdvanced = New DevExpress.XtraNavBar.NavBarGroup()
        CType(Me.MonitorCollectionBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockMonitor.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.gridMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repMonitorsCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.navbarMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navbarMonitor.SuspendLayout()
        Me.NavBarGroupControlContainer21.SuspendLayout()
        CType(Me.cboMonitorFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataMonitorPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataMonitorPurchased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonitorModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonitorCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMonitorBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonitorSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMonitorInventoried.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer23.SuspendLayout()
        CType(Me.txtMonitorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonitorCollectionBinding
        '
        Me.MonitorCollectionBinding.DataSource = GetType(InventoryData.BusinessObjects.MonitorCollection)
        '
        'MonitorBinding
        '
        Me.MonitorBinding.DataSource = GetType(InventoryData.BusinessObjects.Monitor)
        '
        'dockMonitor
        '
        Me.dockMonitor.ActiveWindow = Me.DocumentWindow1
        Me.dockMonitor.Controls.Add(Me.DocumentContainer1)
        Me.dockMonitor.Controls.Add(Me.ToolTabStrip1)
        Me.dockMonitor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockMonitor.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.dockMonitor.IsCleanUpTarget = True
        Me.dockMonitor.Location = New System.Drawing.Point(0, 0)
        Me.dockMonitor.MainDocumentContainer = Me.DocumentContainer1
        Me.dockMonitor.Name = "dockMonitor"
        Me.dockMonitor.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.dockMonitor.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.dockMonitor.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.dockMonitor.Size = New System.Drawing.Size(963, 658)
        Me.dockMonitor.SplitterWidth = 4
        Me.dockMonitor.TabIndex = 0
        Me.dockMonitor.TabStop = False
        Me.dockMonitor.Text = "RadDock1"
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.gridMonitor)
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 30)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.Size = New System.Drawing.Size(592, 612)
        Me.DocumentWindow1.Text = "Monitors"
        '
        'gridMonitor
        '
        Me.gridMonitor.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridMonitor.DataSource = Me.MonitorCollectionBinding
        Me.gridMonitor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMonitor.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridMonitor.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridMonitor.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridMonitor.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridMonitor.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridMonitor.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridMonitor.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridMonitor.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridMonitor.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridMonitor.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridMonitor.Location = New System.Drawing.Point(0, 0)
        Me.gridMonitor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridMonitor.MainView = Me.GridViewMonitor
        Me.gridMonitor.Name = "gridMonitor"
        Me.gridMonitor.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit3, Me.repMonitorsCondition})
        Me.gridMonitor.Size = New System.Drawing.Size(592, 612)
        Me.gridMonitor.TabIndex = 16
        Me.gridMonitor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMonitor})
        '
        'GridViewMonitor
        '
        Me.GridViewMonitor.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewMonitor.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewMonitor.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewMonitor.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewMonitor.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewMonitor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GridViewMonitor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId5, Me.colMonitorName, Me.colSize, Me.colType4, Me.colRoomID4, Me.colSerialNo3, Me.colBrand3, Me.colModel3, Me.colDescription4, Me.colDatePurchased4, Me.colCost4, Me.colFundSource4, Me.colCondition4, Me.colDiscard4, Me.colVendor4, Me.colInventoried4, Me.colComments4})
        Me.GridViewMonitor.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridViewMonitor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridViewMonitor.GridControl = Me.gridMonitor
        Me.GridViewMonitor.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridViewMonitor.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.GridViewMonitor.Name = "GridViewMonitor"
        Me.GridViewMonitor.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewMonitor.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewMonitor.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.GridViewMonitor.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.GridViewMonitor.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.GridViewMonitor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMonitor.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.GridViewMonitor.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.GridViewMonitor.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.GridViewMonitor.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.GridViewMonitor.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.GridViewMonitor.OptionsView.RowAutoHeight = True
        Me.GridViewMonitor.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.GridViewMonitor.OptionsView.ShowGroupPanel = False
        Me.GridViewMonitor.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridViewMonitor.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colId5
        '
        Me.colId5.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId5.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId5.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId5.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId5.FieldName = "Id"
        Me.colId5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colId5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colId5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colId5.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colId5.Name = "colId5"
        Me.colId5.OptionsColumn.AllowEdit = False
        Me.colId5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colId5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colId5.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId5.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colId5.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colId5.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colMonitorName
        '
        Me.colMonitorName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colMonitorName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colMonitorName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colMonitorName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colMonitorName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colMonitorName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colMonitorName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colMonitorName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colMonitorName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colMonitorName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colMonitorName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colMonitorName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colMonitorName.FieldName = "MonitorName"
        Me.colMonitorName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colMonitorName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colMonitorName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colMonitorName.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colMonitorName.Name = "colMonitorName"
        Me.colMonitorName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMonitorName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMonitorName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMonitorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colMonitorName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colMonitorName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMonitorName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colMonitorName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colMonitorName.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colMonitorName.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colMonitorName.Visible = True
        Me.colMonitorName.VisibleIndex = 0
        '
        'colSize
        '
        Me.colSize.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSize.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSize.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSize.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSize.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSize.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSize.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSize.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSize.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSize.FieldName = "Size"
        Me.colSize.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colSize.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colSize.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colSize.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colSize.Name = "colSize"
        Me.colSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSize.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSize.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSize.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colSize.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colSize.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSize.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSize.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colSize.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colSize.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colType4
        '
        Me.colType4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType4.FieldName = "Type"
        Me.colType4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colType4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colType4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colType4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colType4.Name = "colType4"
        Me.colType4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colType4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colType4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colType4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colType4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colRoomID4
        '
        Me.colRoomID4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID4.FieldName = "RoomID"
        Me.colRoomID4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colRoomID4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colRoomID4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colRoomID4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colRoomID4.Name = "colRoomID4"
        Me.colRoomID4.OptionsColumn.AllowEdit = False
        Me.colRoomID4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colRoomID4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colRoomID4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colRoomID4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colRoomID4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colSerialNo3
        '
        Me.colSerialNo3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo3.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo3.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo3.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo3.FieldName = "SerialNo"
        Me.colSerialNo3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colSerialNo3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colSerialNo3.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colSerialNo3.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colSerialNo3.Name = "colSerialNo3"
        Me.colSerialNo3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colSerialNo3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colSerialNo3.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo3.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colSerialNo3.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colSerialNo3.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colBrand3
        '
        Me.colBrand3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand3.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand3.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand3.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand3.FieldName = "Brand"
        Me.colBrand3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colBrand3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colBrand3.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colBrand3.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colBrand3.Name = "colBrand3"
        Me.colBrand3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colBrand3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colBrand3.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand3.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colBrand3.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colBrand3.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colBrand3.Visible = True
        Me.colBrand3.VisibleIndex = 2
        '
        'colModel3
        '
        Me.colModel3.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel3.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel3.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel3.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel3.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel3.FieldName = "Model"
        Me.colModel3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colModel3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colModel3.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colModel3.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colModel3.Name = "colModel3"
        Me.colModel3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colModel3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colModel3.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel3.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colModel3.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colModel3.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colModel3.Visible = True
        Me.colModel3.VisibleIndex = 3
        '
        'colDescription4
        '
        Me.colDescription4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription4.FieldName = "Description"
        Me.colDescription4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDescription4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDescription4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDescription4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDescription4.Name = "colDescription4"
        Me.colDescription4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDescription4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDescription4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDescription4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDescription4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colDatePurchased4
        '
        Me.colDatePurchased4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased4.FieldName = "DatePurchased"
        Me.colDatePurchased4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDatePurchased4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDatePurchased4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDatePurchased4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDatePurchased4.Name = "colDatePurchased4"
        Me.colDatePurchased4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDatePurchased4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDatePurchased4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDatePurchased4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDatePurchased4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCost4
        '
        Me.colCost4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost4.DisplayFormat.FormatString = "$###,###.00"
        Me.colCost4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCost4.FieldName = "Cost"
        Me.colCost4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCost4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCost4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCost4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCost4.Name = "colCost4"
        Me.colCost4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCost4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCost4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCost4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCost4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCost4.Visible = True
        Me.colCost4.VisibleIndex = 1
        '
        'colFundSource4
        '
        Me.colFundSource4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource4.FieldName = "FundSource"
        Me.colFundSource4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colFundSource4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colFundSource4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colFundSource4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colFundSource4.Name = "colFundSource4"
        Me.colFundSource4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colFundSource4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colFundSource4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colFundSource4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colFundSource4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCondition4
        '
        Me.colCondition4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition4.ColumnEdit = Me.repMonitorsCondition
        Me.colCondition4.FieldName = "Condition"
        Me.colCondition4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCondition4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCondition4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCondition4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCondition4.Name = "colCondition4"
        Me.colCondition4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCondition4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCondition4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCondition4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCondition4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCondition4.Visible = True
        Me.colCondition4.VisibleIndex = 4
        '
        'repMonitorsCondition
        '
        Me.repMonitorsCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.repMonitorsCondition.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.repMonitorsCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repMonitorsCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repMonitorsCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repMonitorsCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repMonitorsCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repMonitorsCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repMonitorsCondition.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repMonitorsCondition.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repMonitorsCondition.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repMonitorsCondition.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repMonitorsCondition.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repMonitorsCondition.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repMonitorsCondition.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repMonitorsCondition.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repMonitorsCondition.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repMonitorsCondition.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repMonitorsCondition.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repMonitorsCondition.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repMonitorsCondition.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repMonitorsCondition.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repMonitorsCondition.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repMonitorsCondition.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repMonitorsCondition.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repMonitorsCondition.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repMonitorsCondition.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repMonitorsCondition.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.AutoHeight = False
        Me.repMonitorsCondition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repMonitorsCondition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.repMonitorsCondition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.repMonitorsCondition.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.repMonitorsCondition.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.repMonitorsCondition.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.repMonitorsCondition.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.repMonitorsCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.repMonitorsCondition.Name = "repMonitorsCondition"
        Me.repMonitorsCondition.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.repMonitorsCondition.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.repMonitorsCondition.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDiscard4
        '
        Me.colDiscard4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard4.FieldName = "Discard"
        Me.colDiscard4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDiscard4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDiscard4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDiscard4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDiscard4.Name = "colDiscard4"
        Me.colDiscard4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDiscard4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDiscard4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDiscard4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDiscard4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colVendor4
        '
        Me.colVendor4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor4.FieldName = "Vendor"
        Me.colVendor4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colVendor4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colVendor4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colVendor4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colVendor4.Name = "colVendor4"
        Me.colVendor4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colVendor4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colVendor4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colVendor4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colVendor4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colInventoried4
        '
        Me.colInventoried4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried4.FieldName = "Inventoried"
        Me.colInventoried4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colInventoried4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colInventoried4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colInventoried4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colInventoried4.Name = "colInventoried4"
        Me.colInventoried4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colInventoried4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colInventoried4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colInventoried4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colInventoried4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colInventoried4.Visible = True
        Me.colInventoried4.VisibleIndex = 5
        '
        'colComments4
        '
        Me.colComments4.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments4.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments4.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments4.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments4.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments4.FieldName = "Comments"
        Me.colComments4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colComments4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colComments4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colComments4.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colComments4.Name = "colComments4"
        Me.colComments4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colComments4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colComments4.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments4.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colComments4.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colComments4.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemMemoEdit3.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemMemoEdit3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit3.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit3.AppearanceFocused.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit3.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RepositoryItemMemoEdit3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemMemoEdit3.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemMemoEdit3.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemMemoEdit3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        Me.RepositoryItemMemoEdit3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
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
        Me.DocumentContainer1.Size = New System.Drawing.Size(604, 648)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(604, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-145, 0)
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
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(604, 648)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(613, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(345, 648)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(345, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(145, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Controls.Add(Me.navbarMonitor)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.Size = New System.Drawing.Size(343, 622)
        Me.ToolWindow1.Text = "Details"
        '
        'navbarMonitor
        '
        Me.navbarMonitor.ActiveGroup = Me.navMonitorBasic
        Me.navbarMonitor.Appearance.Background.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.Background.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.Background.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.Background.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.Background.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.Background.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.Button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.Button.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.Button.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.Button.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.Button.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.GroupBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.GroupBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.GroupBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.GroupBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.GroupHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.GroupHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.GroupHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.GroupHeaderPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.GroupHeaderPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.Hint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.Hint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.Hint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.Hint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.Hint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.Hint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.Item.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.Item.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.Item.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.Item.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.Item.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.Item.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ItemActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ItemActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ItemActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ItemActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ItemDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ItemDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ItemDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ItemHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ItemHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ItemHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.ItemPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.ItemPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.ItemPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.LinkDropTarget.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.LinkDropTarget.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.LinkDropTarget.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.LinkDropTarget.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.LinkDropTarget.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.LinkDropTarget.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.NavigationPaneHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.NavigationPaneHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.NavigationPaneHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.NavigationPaneHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.NavigationPaneHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.NavPaneContentButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarMonitor.Appearance.NavPaneContentButtonReleased.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarMonitor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.navbarMonitor.Controls.Add(Me.NavBarGroupControlContainer21)
        Me.navbarMonitor.Controls.Add(Me.NavBarGroupControlContainer23)
        Me.navbarMonitor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navbarMonitor.DragDropFlags = CType((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop), DevExpress.XtraNavBar.NavBarDragDrop)
        Me.navbarMonitor.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navMonitorBasic, Me.navMonitorAdvanced})
        Me.navbarMonitor.Location = New System.Drawing.Point(0, 0)
        Me.navbarMonitor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.navbarMonitor.Name = "navbarMonitor"
        Me.navbarMonitor.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Normal
        Me.navbarMonitor.OptionsNavPane.ExpandedWidth = 239
        Me.navbarMonitor.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        Me.navbarMonitor.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.[Default]
        Me.navbarMonitor.Size = New System.Drawing.Size(343, 622)
        Me.navbarMonitor.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.[Default]
        Me.navbarMonitor.TabIndex = 17
        Me.navbarMonitor.Text = "NavBarControl3"
        '
        'navMonitorBasic
        '
        Me.navMonitorBasic.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorBasic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorBasic.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorBasic.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorBasic.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorBasic.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorBasic.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorBasic.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorBasic.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorBasic.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorBasic.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorBasic.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorBasic.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorBasic.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorBasic.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorBasic.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorBasic.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorBasic.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorBasic.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorBasic.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorBasic.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorBasic.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorBasic.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorBasic.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorBasic.Caption = "Basic Properties"
        Me.navMonitorBasic.ControlContainer = Me.NavBarGroupControlContainer21
        Me.navMonitorBasic.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navMonitorBasic.Expanded = True
        Me.navMonitorBasic.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navMonitorBasic.GroupClientHeight = 490
        Me.navMonitorBasic.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navMonitorBasic.LargeImage = Global.Inventory.My.Resources.Resources.My_Computer_Vista_32
        Me.navMonitorBasic.Name = "navMonitorBasic"
        '
        'NavBarGroupControlContainer21
        '
        Me.NavBarGroupControlContainer21.Controls.Add(Me.cboMonitorFund)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorComments)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorFund)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorComments)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorCost)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorCost)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorVendor)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorVendor)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorDescription)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.dataMonitorPurchased)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.cboMonitorModel)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.cboMonitorCondition)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.cboMonitorBrand)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorDate)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorCondition)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorModel)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorBrand)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorDescription)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorName)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.txtMonitorSerial)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorName)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.lblMonitorSerial)
        Me.NavBarGroupControlContainer21.Controls.Add(Me.chkMonitorInventoried)
        Me.NavBarGroupControlContainer21.Name = "NavBarGroupControlContainer21"
        Me.NavBarGroupControlContainer21.Size = New System.Drawing.Size(339, 488)
        Me.NavBarGroupControlContainer21.TabIndex = 1
        '
        'cboMonitorFund
        '
        Me.cboMonitorFund.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorFund.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMonitorFund.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "FundSource", True))
        Me.cboMonitorFund.Location = New System.Drawing.Point(105, 168)
        Me.cboMonitorFund.Name = "cboMonitorFund"
        Me.cboMonitorFund.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboMonitorFund.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorFund.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorFund.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorFund.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorFund.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorFund.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorFund.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorFund.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorFund.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorFund.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorFund.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorFund.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorFund.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorFund.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorFund.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorFund.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorFund.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorFund.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorFund.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorFund.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.cboMonitorFund.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMonitorFund.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboMonitorFund.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboMonitorFund.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboMonitorFund.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboMonitorFund.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboMonitorFund.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboMonitorFund.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboMonitorFund.Size = New System.Drawing.Size(230, 20)
        Me.cboMonitorFund.TabIndex = 6
        Me.cboMonitorFund.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorComments
        '
        Me.txtMonitorComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorComments.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Comments", True))
        Me.txtMonitorComments.Location = New System.Drawing.Point(13, 372)
        Me.txtMonitorComments.Name = "txtMonitorComments"
        Me.txtMonitorComments.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorComments.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorComments.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorComments.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorComments.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorComments.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorComments.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorComments.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorComments.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorComments.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorComments.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorComments.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorComments.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorComments.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorComments.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorComments.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorComments.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorComments.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorComments.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorComments.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorComments.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorComments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorComments.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorComments.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorComments.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorComments.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorComments.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMonitorComments.Size = New System.Drawing.Size(323, 70)
        Me.txtMonitorComments.TabIndex = 27
        Me.txtMonitorComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorFund
        '
        Me.lblMonitorFund.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorFund.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorFund.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorFund.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorFund.Appearance.Options.UseFont = True
        Me.lblMonitorFund.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorFund.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorFund.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorFund.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorFund.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorFund.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorFund.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorFund.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorFund.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorFund.Location = New System.Drawing.Point(12, 171)
        Me.lblMonitorFund.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorFund.Name = "lblMonitorFund"
        Me.lblMonitorFund.Size = New System.Drawing.Size(72, 13)
        Me.lblMonitorFund.TabIndex = 5
        Me.lblMonitorFund.Text = "Fund Source:"
        Me.lblMonitorFund.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorComments
        '
        Me.lblMonitorComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorComments.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorComments.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorComments.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorComments.Appearance.Options.UseFont = True
        Me.lblMonitorComments.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorComments.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorComments.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorComments.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorComments.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorComments.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorComments.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorComments.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorComments.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorComments.Location = New System.Drawing.Point(13, 353)
        Me.lblMonitorComments.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorComments.Name = "lblMonitorComments"
        Me.lblMonitorComments.Size = New System.Drawing.Size(64, 13)
        Me.lblMonitorComments.TabIndex = 26
        Me.lblMonitorComments.Text = "Comments:"
        Me.lblMonitorComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorCost
        '
        Me.txtMonitorCost.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Cost", True))
        Me.txtMonitorCost.Location = New System.Drawing.Point(105, 142)
        Me.txtMonitorCost.Name = "txtMonitorCost"
        Me.txtMonitorCost.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorCost.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorCost.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorCost.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorCost.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorCost.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorCost.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorCost.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorCost.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorCost.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorCost.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorCost.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorCost.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorCost.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorCost.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorCost.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorCost.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorCost.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorCost.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorCost.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorCost.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtMonitorCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonitorCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonitorCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorCost.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorCost.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorCost.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtMonitorCost.Properties.Mask.EditMask = "c"
        Me.txtMonitorCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonitorCost.Size = New System.Drawing.Size(230, 20)
        Me.txtMonitorCost.TabIndex = 4
        Me.txtMonitorCost.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorCost
        '
        Me.lblMonitorCost.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorCost.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorCost.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorCost.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorCost.Appearance.Options.UseFont = True
        Me.lblMonitorCost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorCost.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorCost.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorCost.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorCost.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorCost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorCost.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorCost.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorCost.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorCost.Location = New System.Drawing.Point(12, 145)
        Me.lblMonitorCost.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorCost.Name = "lblMonitorCost"
        Me.lblMonitorCost.Size = New System.Drawing.Size(28, 13)
        Me.lblMonitorCost.TabIndex = 3
        Me.lblMonitorCost.Text = "Cost:"
        Me.lblMonitorCost.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorVendor
        '
        Me.txtMonitorVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorVendor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Vendor", True))
        Me.txtMonitorVendor.Location = New System.Drawing.Point(106, 222)
        Me.txtMonitorVendor.Name = "txtMonitorVendor"
        Me.txtMonitorVendor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorVendor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorVendor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorVendor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorVendor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorVendor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorVendor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorVendor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorVendor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorVendor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorVendor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorVendor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorVendor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorVendor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorVendor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorVendor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorVendor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorVendor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorVendor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorVendor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorVendor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorVendor.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtMonitorVendor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtMonitorVendor.Size = New System.Drawing.Size(230, 20)
        Me.txtMonitorVendor.TabIndex = 24
        Me.txtMonitorVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorVendor
        '
        Me.lblMonitorVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorVendor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorVendor.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorVendor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorVendor.Appearance.Options.UseFont = True
        Me.lblMonitorVendor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorVendor.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorVendor.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorVendor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorVendor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorVendor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorVendor.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorVendor.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorVendor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorVendor.Location = New System.Drawing.Point(13, 225)
        Me.lblMonitorVendor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorVendor.Name = "lblMonitorVendor"
        Me.lblMonitorVendor.Size = New System.Drawing.Size(43, 13)
        Me.lblMonitorVendor.TabIndex = 25
        Me.lblMonitorVendor.Text = "Vendor:"
        Me.lblMonitorVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorDescription
        '
        Me.txtMonitorDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Description", True))
        Me.txtMonitorDescription.Location = New System.Drawing.Point(13, 277)
        Me.txtMonitorDescription.Name = "txtMonitorDescription"
        Me.txtMonitorDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorDescription.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorDescription.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorDescription.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorDescription.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorDescription.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorDescription.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorDescription.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorDescription.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorDescription.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorDescription.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorDescription.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorDescription.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorDescription.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorDescription.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorDescription.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorDescription.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorDescription.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorDescription.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorDescription.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMonitorDescription.Size = New System.Drawing.Size(323, 70)
        Me.txtMonitorDescription.TabIndex = 6
        Me.txtMonitorDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dataMonitorPurchased
        '
        Me.dataMonitorPurchased.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataMonitorPurchased.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataMonitorPurchased.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "DatePurchased", True))
        Me.dataMonitorPurchased.EditValue = Nothing
        Me.dataMonitorPurchased.Location = New System.Drawing.Point(105, 116)
        Me.dataMonitorPurchased.Name = "dataMonitorPurchased"
        Me.dataMonitorPurchased.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataMonitorPurchased.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataMonitorPurchased.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.dataMonitorPurchased.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataMonitorPurchased.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dataMonitorPurchased.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataMonitorPurchased.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataMonitorPurchased.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataMonitorPurchased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataMonitorPurchased.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.dataMonitorPurchased.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.dataMonitorPurchased.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataMonitorPurchased.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataMonitorPurchased.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject4.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.dataMonitorPurchased.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataMonitorPurchased.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.dataMonitorPurchased.Size = New System.Drawing.Size(230, 20)
        Me.dataMonitorPurchased.TabIndex = 4
        Me.dataMonitorPurchased.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboMonitorModel
        '
        Me.cboMonitorModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorModel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMonitorModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Model", True))
        Me.cboMonitorModel.Location = New System.Drawing.Point(105, 90)
        Me.cboMonitorModel.Name = "cboMonitorModel"
        Me.cboMonitorModel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboMonitorModel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorModel.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorModel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorModel.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorModel.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorModel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorModel.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorModel.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorModel.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorModel.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorModel.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorModel.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorModel.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorModel.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorModel.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorModel.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorModel.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorModel.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorModel.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorModel.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject5.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject5.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.cboMonitorModel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMonitorModel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboMonitorModel.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboMonitorModel.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboMonitorModel.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboMonitorModel.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboMonitorModel.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboMonitorModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboMonitorModel.Size = New System.Drawing.Size(230, 20)
        Me.cboMonitorModel.TabIndex = 3
        Me.cboMonitorModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboMonitorCondition
        '
        Me.cboMonitorCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMonitorCondition.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Condition", True))
        Me.cboMonitorCondition.Location = New System.Drawing.Point(106, 194)
        Me.cboMonitorCondition.Name = "cboMonitorCondition"
        Me.cboMonitorCondition.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboMonitorCondition.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorCondition.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorCondition.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorCondition.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorCondition.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorCondition.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorCondition.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorCondition.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorCondition.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorCondition.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorCondition.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorCondition.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorCondition.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject6.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject6.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject6.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.cboMonitorCondition.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMonitorCondition.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboMonitorCondition.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboMonitorCondition.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboMonitorCondition.Properties.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.cboMonitorCondition.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboMonitorCondition.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboMonitorCondition.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboMonitorCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMonitorCondition.Size = New System.Drawing.Size(230, 20)
        Me.cboMonitorCondition.TabIndex = 3
        Me.cboMonitorCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboMonitorBrand
        '
        Me.cboMonitorBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorBrand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMonitorBrand.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Brand", True))
        Me.cboMonitorBrand.Location = New System.Drawing.Point(105, 64)
        Me.cboMonitorBrand.Name = "cboMonitorBrand"
        Me.cboMonitorBrand.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboMonitorBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboMonitorBrand.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorBrand.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorBrand.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorBrand.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorBrand.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorBrand.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorBrand.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorBrand.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorBrand.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorBrand.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorBrand.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboMonitorBrand.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject7.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject7.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject7.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject7.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject7.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboMonitorBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject7, "", Nothing, Nothing, True)})
        Me.cboMonitorBrand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMonitorBrand.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboMonitorBrand.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboMonitorBrand.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboMonitorBrand.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboMonitorBrand.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboMonitorBrand.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboMonitorBrand.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboMonitorBrand.Size = New System.Drawing.Size(230, 20)
        Me.cboMonitorBrand.TabIndex = 3
        Me.cboMonitorBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorDate
        '
        Me.lblMonitorDate.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorDate.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorDate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorDate.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorDate.Appearance.Options.UseFont = True
        Me.lblMonitorDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorDate.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorDate.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorDate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorDate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorDate.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorDate.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorDate.Location = New System.Drawing.Point(12, 119)
        Me.lblMonitorDate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorDate.Name = "lblMonitorDate"
        Me.lblMonitorDate.Size = New System.Drawing.Size(92, 13)
        Me.lblMonitorDate.TabIndex = 1
        Me.lblMonitorDate.Text = "Date Purchased:"
        Me.lblMonitorDate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorCondition
        '
        Me.lblMonitorCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorCondition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorCondition.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorCondition.Appearance.Options.UseFont = True
        Me.lblMonitorCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorCondition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorCondition.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorCondition.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorCondition.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorCondition.Location = New System.Drawing.Point(13, 197)
        Me.lblMonitorCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorCondition.Name = "lblMonitorCondition"
        Me.lblMonitorCondition.Size = New System.Drawing.Size(56, 13)
        Me.lblMonitorCondition.TabIndex = 1
        Me.lblMonitorCondition.Text = "Condition:"
        Me.lblMonitorCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorModel
        '
        Me.lblMonitorModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorModel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorModel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorModel.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorModel.Appearance.Options.UseFont = True
        Me.lblMonitorModel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorModel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorModel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorModel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorModel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorModel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorModel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorModel.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorModel.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorModel.Location = New System.Drawing.Point(12, 93)
        Me.lblMonitorModel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorModel.Name = "lblMonitorModel"
        Me.lblMonitorModel.Size = New System.Drawing.Size(37, 13)
        Me.lblMonitorModel.TabIndex = 1
        Me.lblMonitorModel.Text = "Model:"
        Me.lblMonitorModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorBrand
        '
        Me.lblMonitorBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorBrand.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorBrand.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorBrand.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorBrand.Appearance.Options.UseFont = True
        Me.lblMonitorBrand.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorBrand.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorBrand.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorBrand.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorBrand.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorBrand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorBrand.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorBrand.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorBrand.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorBrand.Location = New System.Drawing.Point(12, 67)
        Me.lblMonitorBrand.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorBrand.Name = "lblMonitorBrand"
        Me.lblMonitorBrand.Size = New System.Drawing.Size(36, 13)
        Me.lblMonitorBrand.TabIndex = 1
        Me.lblMonitorBrand.Text = "Brand:"
        Me.lblMonitorBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorDescription
        '
        Me.lblMonitorDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorDescription.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorDescription.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorDescription.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorDescription.Appearance.Options.UseFont = True
        Me.lblMonitorDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorDescription.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorDescription.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorDescription.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorDescription.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorDescription.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorDescription.Location = New System.Drawing.Point(13, 258)
        Me.lblMonitorDescription.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorDescription.Name = "lblMonitorDescription"
        Me.lblMonitorDescription.Size = New System.Drawing.Size(64, 13)
        Me.lblMonitorDescription.TabIndex = 1
        Me.lblMonitorDescription.Text = "Description"
        Me.lblMonitorDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorName
        '
        Me.txtMonitorName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "MonitorName", True))
        Me.txtMonitorName.Location = New System.Drawing.Point(105, 12)
        Me.txtMonitorName.Name = "txtMonitorName"
        Me.txtMonitorName.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorName.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorName.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorName.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorName.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorName.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorName.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorName.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorName.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorName.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorName.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorName.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorName.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtMonitorName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtMonitorName.Size = New System.Drawing.Size(230, 20)
        Me.txtMonitorName.TabIndex = 2
        Me.txtMonitorName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMonitorSerial
        '
        Me.txtMonitorSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorSerial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorSerial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "SerialNo", True))
        Me.txtMonitorSerial.Location = New System.Drawing.Point(105, 38)
        Me.txtMonitorSerial.Name = "txtMonitorSerial"
        Me.txtMonitorSerial.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorSerial.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorSerial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorSerial.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorSerial.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorSerial.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorSerial.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorSerial.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorSerial.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorSerial.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorSerial.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorSerial.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorSerial.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorSerial.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorSerial.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorSerial.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorSerial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorSerial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorSerial.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorSerial.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorSerial.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorSerial.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtMonitorSerial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtMonitorSerial.Size = New System.Drawing.Size(230, 20)
        Me.txtMonitorSerial.TabIndex = 2
        Me.txtMonitorSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorName
        '
        Me.lblMonitorName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorName.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorName.Appearance.Options.UseFont = True
        Me.lblMonitorName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorName.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorName.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorName.Location = New System.Drawing.Point(12, 15)
        Me.lblMonitorName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorName.Name = "lblMonitorName"
        Me.lblMonitorName.Size = New System.Drawing.Size(35, 13)
        Me.lblMonitorName.TabIndex = 1
        Me.lblMonitorName.Text = "Name:"
        Me.lblMonitorName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorSerial
        '
        Me.lblMonitorSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorSerial.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorSerial.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorSerial.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorSerial.Appearance.Options.UseFont = True
        Me.lblMonitorSerial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorSerial.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorSerial.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorSerial.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorSerial.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorSerial.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorSerial.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorSerial.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorSerial.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorSerial.Location = New System.Drawing.Point(12, 41)
        Me.lblMonitorSerial.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorSerial.Name = "lblMonitorSerial"
        Me.lblMonitorSerial.Size = New System.Drawing.Size(82, 13)
        Me.lblMonitorSerial.TabIndex = 1
        Me.lblMonitorSerial.Text = "Serial Number:"
        Me.lblMonitorSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'chkMonitorInventoried
        '
        Me.chkMonitorInventoried.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.chkMonitorInventoried.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Inventoried", True))
        Me.chkMonitorInventoried.Location = New System.Drawing.Point(11, 457)
        Me.chkMonitorInventoried.Name = "chkMonitorInventoried"
        Me.chkMonitorInventoried.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.chkMonitorInventoried.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMonitorInventoried.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkMonitorInventoried.Properties.Appearance.Options.UseFont = True
        Me.chkMonitorInventoried.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkMonitorInventoried.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkMonitorInventoried.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkMonitorInventoried.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkMonitorInventoried.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkMonitorInventoried.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkMonitorInventoried.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkMonitorInventoried.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.chkMonitorInventoried.Properties.Caption = "Inventoried"
        Me.chkMonitorInventoried.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.chkMonitorInventoried.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.chkMonitorInventoried.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.chkMonitorInventoried.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.chkMonitorInventoried.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.chkMonitorInventoried.Size = New System.Drawing.Size(96, 19)
        Me.chkMonitorInventoried.TabIndex = 0
        Me.chkMonitorInventoried.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer23
        '
        Me.NavBarGroupControlContainer23.Controls.Add(Me.txtMonitorID)
        Me.NavBarGroupControlContainer23.Controls.Add(Me.lblMonitorID)
        Me.NavBarGroupControlContainer23.Name = "NavBarGroupControlContainer23"
        Me.NavBarGroupControlContainer23.Size = New System.Drawing.Size(480, 45)
        Me.NavBarGroupControlContainer23.TabIndex = 3
        '
        'txtMonitorID
        '
        Me.txtMonitorID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonitorID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MonitorBinding, "Id", True))
        Me.txtMonitorID.Location = New System.Drawing.Point(47, 12)
        Me.txtMonitorID.Name = "txtMonitorID"
        Me.txtMonitorID.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtMonitorID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtMonitorID.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorID.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorID.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorID.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorID.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorID.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorID.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorID.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorID.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorID.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorID.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMonitorID.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMonitorID.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMonitorID.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMonitorID.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMonitorID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMonitorID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMonitorID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtMonitorID.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtMonitorID.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMonitorID.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtMonitorID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtMonitorID.Properties.ReadOnly = True
        Me.txtMonitorID.Size = New System.Drawing.Size(429, 20)
        Me.txtMonitorID.TabIndex = 4
        Me.txtMonitorID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMonitorID
        '
        Me.lblMonitorID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblMonitorID.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMonitorID.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblMonitorID.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMonitorID.Appearance.Options.UseFont = True
        Me.lblMonitorID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblMonitorID.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblMonitorID.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblMonitorID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblMonitorID.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblMonitorID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblMonitorID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblMonitorID.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblMonitorID.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblMonitorID.Location = New System.Drawing.Point(12, 15)
        Me.lblMonitorID.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblMonitorID.Name = "lblMonitorID"
        Me.lblMonitorID.Size = New System.Drawing.Size(16, 13)
        Me.lblMonitorID.TabIndex = 3
        Me.lblMonitorID.Text = "ID:"
        Me.lblMonitorID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'navMonitorAdvanced
        '
        Me.navMonitorAdvanced.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorAdvanced.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorAdvanced.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorAdvanced.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorAdvanced.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorAdvanced.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorAdvanced.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorAdvanced.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorAdvanced.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorAdvanced.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorAdvanced.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorAdvanced.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorAdvanced.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorAdvanced.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorAdvanced.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorAdvanced.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorAdvanced.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorAdvanced.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorAdvanced.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navMonitorAdvanced.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navMonitorAdvanced.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navMonitorAdvanced.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navMonitorAdvanced.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navMonitorAdvanced.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navMonitorAdvanced.Caption = "Advanced Properties"
        Me.navMonitorAdvanced.ControlContainer = Me.NavBarGroupControlContainer23
        Me.navMonitorAdvanced.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navMonitorAdvanced.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navMonitorAdvanced.GroupClientHeight = 47
        Me.navMonitorAdvanced.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navMonitorAdvanced.LargeImage = Global.Inventory.My.Resources.Resources.Config_32
        Me.navMonitorAdvanced.Name = "navMonitorAdvanced"
        '
        'frmMonitor
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 658)
        Me.Controls.Add(Me.dockMonitor)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmMonitor"
        Me.Text = "Monitors"
        CType(Me.MonitorCollectionBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockMonitor.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.gridMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repMonitorsCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.navbarMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navbarMonitor.ResumeLayout(False)
        Me.NavBarGroupControlContainer21.ResumeLayout(False)
        Me.NavBarGroupControlContainer21.PerformLayout()
        CType(Me.cboMonitorFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataMonitorPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataMonitorPurchased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonitorModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonitorCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMonitorBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonitorSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMonitorInventoried.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer23.ResumeLayout(False)
        Me.NavBarGroupControlContainer23.PerformLayout()
        CType(Me.txtMonitorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonitorCollectionBinding As System.Windows.Forms.BindingSource
    Friend WithEvents MonitorBinding As System.Windows.Forms.BindingSource
    Friend WithEvents dockMonitor As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents navbarMonitor As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroupControlContainer21 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtMonitorComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblMonitorComments As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonitorVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonitorVendor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonitorDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dataMonitorPurchased As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboMonitorModel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMonitorCondition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMonitorBrand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblMonitorDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorCondition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorBrand As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonitorName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMonitorSerial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonitorName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMonitorSerial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMonitorInventoried As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboMonitorFund As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblMonitorFund As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonitorCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonitorCost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavBarGroupControlContainer23 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtMonitorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMonitorID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents navMonitorBasic As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navMonitorAdvanced As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents gridMonitor As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMonitor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonitorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoomID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatePurchased4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFundSource4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondition4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repMonitorsCondition As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDiscard4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendor4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoried4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
