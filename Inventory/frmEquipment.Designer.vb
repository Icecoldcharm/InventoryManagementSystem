<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipment
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
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.EquipmentBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentCollectionBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.gridEquipment = New DevExpress.XtraGrid.GridControl()
        Me.GridViewEquipment = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEquipmentQuantity = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colRoomID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colDatePurchased1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFundSource1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCondition1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEquipmentCondition = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiscard1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoried1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnEquipmentTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.navbarEquipment = New DevExpress.XtraNavBar.NavBarControl()
        Me.navEquipmentBasic = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer13 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cboEquipmentFund = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtEquipmentComments = New DevExpress.XtraEditors.MemoEdit()
        Me.lblEquipmentFund = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentComments = New DevExpress.XtraEditors.LabelControl()
        Me.txtEquipmentCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtEquipmentVendor = New DevExpress.XtraEditors.TextEdit()
        Me.lblEquipmentCost = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentVendor = New DevExpress.XtraEditors.LabelControl()
        Me.txtEquipmentDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.dataEquipmentPurchased = New DevExpress.XtraEditors.DateEdit()
        Me.cboEquipmentModel = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboEquipmentCondition = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboEquipmentBrand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblEquipmentDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentCondition = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentModel = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentBrand = New DevExpress.XtraEditors.LabelControl()
        Me.lblEquipmentDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtEquipmentQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.lblEquipmentQuantity = New DevExpress.XtraEditors.LabelControl()
        Me.txtEquipmentSerial = New DevExpress.XtraEditors.TextEdit()
        Me.lblEquipmentSerial = New DevExpress.XtraEditors.LabelControl()
        Me.chkEquipmentInventoried = New DevExpress.XtraEditors.CheckEdit()
        Me.NavBarGroupControlContainer15 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtEquipmentID = New DevExpress.XtraEditors.TextEdit()
        Me.lblEquipmentID = New DevExpress.XtraEditors.LabelControl()
        Me.navEquipmentAdvanced = New DevExpress.XtraNavBar.NavBarGroup()
        CType(Me.EquipmentBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentCollectionBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEquipmentQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEquipmentCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.navbarEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navbarEquipment.SuspendLayout()
        Me.NavBarGroupControlContainer13.SuspendLayout()
        CType(Me.cboEquipmentFund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataEquipmentPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataEquipmentPurchased.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEquipmentModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEquipmentCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEquipmentBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquipmentSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEquipmentInventoried.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer15.SuspendLayout()
        CType(Me.txtEquipmentID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EquipmentBinding
        '
        Me.EquipmentBinding.DataSource = GetType(InventoryData.BusinessObjects.Equipment)
        '
        'EquipmentCollectionBinding
        '
        Me.EquipmentCollectionBinding.DataSource = GetType(InventoryData.BusinessObjects.EquipmentCollection)
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow1
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDock1.Size = New System.Drawing.Size(880, 684)
        Me.RadDock1.SplitterWidth = 4
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "dockEquipment"
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.gridEquipment)
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(596, 639)
        Me.DocumentWindow1.Text = "Equipment"
        '
        'gridEquipment
        '
        Me.gridEquipment.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridEquipment.DataSource = Me.EquipmentCollectionBinding
        Me.gridEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEquipment.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridEquipment.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridEquipment.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridEquipment.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridEquipment.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridEquipment.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridEquipment.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridEquipment.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridEquipment.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridEquipment.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridEquipment.Location = New System.Drawing.Point(0, 0)
        Me.gridEquipment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridEquipment.MainView = Me.GridViewEquipment
        Me.gridEquipment.Name = "gridEquipment"
        Me.gridEquipment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.repEquipmentQuantity, Me.repEquipmentCondition})
        Me.gridEquipment.Size = New System.Drawing.Size(596, 639)
        Me.gridEquipment.TabIndex = 12
        Me.gridEquipment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewEquipment})
        '
        'GridViewEquipment
        '
        Me.GridViewEquipment.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewEquipment.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewEquipment.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewEquipment.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewEquipment.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewEquipment.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GridViewEquipment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colQuantity1, Me.colRoomID1, Me.colType2, Me.colSerialNo1, Me.colBrand1, Me.colModel1, Me.colDescription1, Me.colDatePurchased1, Me.colCost1, Me.colFundSource1, Me.colCondition1, Me.colDiscard1, Me.colVendor1, Me.colInventoried1, Me.GridColumnEquipmentTotal, Me.colComments2})
        Me.GridViewEquipment.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridViewEquipment.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridViewEquipment.GridControl = Me.gridEquipment
        Me.GridViewEquipment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridViewEquipment.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.GridViewEquipment.Name = "GridViewEquipment"
        Me.GridViewEquipment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewEquipment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewEquipment.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.GridViewEquipment.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.GridViewEquipment.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.GridViewEquipment.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewEquipment.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.GridViewEquipment.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.GridViewEquipment.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.GridViewEquipment.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.GridViewEquipment.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.GridViewEquipment.OptionsView.RowAutoHeight = True
        Me.GridViewEquipment.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.GridViewEquipment.OptionsView.ShowGroupPanel = False
        Me.GridViewEquipment.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridViewEquipment.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colId2
        '
        Me.colId2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId2.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId2.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colId2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colId2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colId2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colId2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colId2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colId2.FieldName = "Id"
        Me.colId2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colId2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colId2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colId2.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colId2.Name = "colId2"
        Me.colId2.OptionsColumn.AllowEdit = False
        Me.colId2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colId2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colId2.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId2.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colId2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colId2.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colId2.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colQuantity1
        '
        Me.colQuantity1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colQuantity1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colQuantity1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colQuantity1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colQuantity1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colQuantity1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colQuantity1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colQuantity1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colQuantity1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colQuantity1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colQuantity1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colQuantity1.ColumnEdit = Me.repEquipmentQuantity
        Me.colQuantity1.FieldName = "Quantity"
        Me.colQuantity1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colQuantity1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colQuantity1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colQuantity1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colQuantity1.Name = "colQuantity1"
        Me.colQuantity1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colQuantity1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colQuantity1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colQuantity1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colQuantity1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colQuantity1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colQuantity1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colQuantity1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colQuantity1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colQuantity1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colQuantity1.Visible = True
        Me.colQuantity1.VisibleIndex = 0
        '
        'repEquipmentQuantity
        '
        Me.repEquipmentQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.repEquipmentQuantity.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.repEquipmentQuantity.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentQuantity.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentQuantity.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentQuantity.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentQuantity.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentQuantity.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentQuantity.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentQuantity.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentQuantity.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentQuantity.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentQuantity.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentQuantity.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentQuantity.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentQuantity.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentQuantity.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentQuantity.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentQuantity.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentQuantity.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentQuantity.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentQuantity.AutoHeight = False
        Me.repEquipmentQuantity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.repEquipmentQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.repEquipmentQuantity.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.repEquipmentQuantity.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.repEquipmentQuantity.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.repEquipmentQuantity.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.repEquipmentQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repEquipmentQuantity.Name = "repEquipmentQuantity"
        '
        'colRoomID1
        '
        Me.colRoomID1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomID1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomID1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomID1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomID1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomID1.FieldName = "RoomID"
        Me.colRoomID1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colRoomID1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colRoomID1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colRoomID1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colRoomID1.Name = "colRoomID1"
        Me.colRoomID1.OptionsColumn.AllowEdit = False
        Me.colRoomID1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colRoomID1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colRoomID1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomID1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colRoomID1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colRoomID1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colType2
        '
        Me.colType2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType2.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType2.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colType2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colType2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colType2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colType2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colType2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colType2.FieldName = "Type"
        Me.colType2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colType2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colType2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colType2.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colType2.Name = "colType2"
        Me.colType2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colType2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colType2.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType2.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colType2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colType2.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colType2.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colSerialNo1
        '
        Me.colSerialNo1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colSerialNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colSerialNo1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colSerialNo1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colSerialNo1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colSerialNo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colSerialNo1.FieldName = "SerialNo"
        Me.colSerialNo1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colSerialNo1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colSerialNo1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colSerialNo1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colSerialNo1.Name = "colSerialNo1"
        Me.colSerialNo1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colSerialNo1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colSerialNo1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colSerialNo1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colSerialNo1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colSerialNo1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colBrand1
        '
        Me.colBrand1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBrand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBrand1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBrand1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBrand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBrand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBrand1.FieldName = "Brand"
        Me.colBrand1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colBrand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colBrand1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colBrand1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colBrand1.Name = "colBrand1"
        Me.colBrand1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colBrand1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colBrand1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBrand1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colBrand1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colBrand1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colBrand1.Visible = True
        Me.colBrand1.VisibleIndex = 3
        '
        'colModel1
        '
        Me.colModel1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colModel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colModel1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colModel1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colModel1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colModel1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colModel1.FieldName = "Model"
        Me.colModel1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colModel1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colModel1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colModel1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colModel1.Name = "colModel1"
        Me.colModel1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colModel1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colModel1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colModel1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colModel1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colModel1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colModel1.Visible = True
        Me.colModel1.VisibleIndex = 4
        '
        'colDescription1
        '
        Me.colDescription1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDescription1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDescription1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDescription1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDescription1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDescription1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDescription1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDescription1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDescription1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDescription1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDescription1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDescription1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDescription1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDescription1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDescription1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 5
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemMemoEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemMemoEdit1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit1.AppearanceFocused.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.RepositoryItemMemoEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemMemoEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemMemoEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemMemoEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        Me.RepositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'colDatePurchased1
        '
        Me.colDatePurchased1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDatePurchased1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDatePurchased1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDatePurchased1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDatePurchased1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDatePurchased1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDatePurchased1.FieldName = "DatePurchased"
        Me.colDatePurchased1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDatePurchased1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDatePurchased1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDatePurchased1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDatePurchased1.Name = "colDatePurchased1"
        Me.colDatePurchased1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDatePurchased1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDatePurchased1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDatePurchased1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDatePurchased1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDatePurchased1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCost1
        '
        Me.colCost1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCost1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCost1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCost1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCost1.DisplayFormat.FormatString = "$###,###.00"
        Me.colCost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCost1.FieldName = "Cost"
        Me.colCost1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCost1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCost1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCost1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCost1.Name = "colCost1"
        Me.colCost1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCost1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCost1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCost1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCost1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCost1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCost1.Visible = True
        Me.colCost1.VisibleIndex = 1
        '
        'colFundSource1
        '
        Me.colFundSource1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFundSource1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFundSource1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFundSource1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFundSource1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFundSource1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFundSource1.FieldName = "FundSource"
        Me.colFundSource1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colFundSource1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colFundSource1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colFundSource1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colFundSource1.Name = "colFundSource1"
        Me.colFundSource1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colFundSource1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colFundSource1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFundSource1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colFundSource1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colFundSource1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colCondition1
        '
        Me.colCondition1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colCondition1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colCondition1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colCondition1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colCondition1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colCondition1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colCondition1.ColumnEdit = Me.repEquipmentCondition
        Me.colCondition1.FieldName = "Condition"
        Me.colCondition1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colCondition1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colCondition1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colCondition1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colCondition1.Name = "colCondition1"
        Me.colCondition1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colCondition1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colCondition1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colCondition1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colCondition1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colCondition1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colCondition1.Visible = True
        Me.colCondition1.VisibleIndex = 6
        '
        'repEquipmentCondition
        '
        Me.repEquipmentCondition.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.repEquipmentCondition.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.repEquipmentCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentCondition.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentCondition.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentCondition.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentCondition.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentCondition.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentCondition.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentCondition.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentCondition.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentCondition.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentCondition.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentCondition.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentCondition.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentCondition.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentCondition.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentCondition.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.repEquipmentCondition.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.repEquipmentCondition.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.repEquipmentCondition.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.repEquipmentCondition.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.repEquipmentCondition.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.AutoHeight = False
        Me.repEquipmentCondition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject6.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject6.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject6.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.repEquipmentCondition.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.repEquipmentCondition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.repEquipmentCondition.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.repEquipmentCondition.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.repEquipmentCondition.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.repEquipmentCondition.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.repEquipmentCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.repEquipmentCondition.Name = "repEquipmentCondition"
        Me.repEquipmentCondition.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.repEquipmentCondition.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.repEquipmentCondition.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDiscard1
        '
        Me.colDiscard1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colDiscard1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colDiscard1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colDiscard1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colDiscard1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colDiscard1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colDiscard1.FieldName = "Discard"
        Me.colDiscard1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colDiscard1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colDiscard1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colDiscard1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colDiscard1.Name = "colDiscard1"
        Me.colDiscard1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colDiscard1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colDiscard1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colDiscard1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colDiscard1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colDiscard1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colVendor1
        '
        Me.colVendor1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVendor1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVendor1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVendor1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVendor1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVendor1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVendor1.FieldName = "Vendor"
        Me.colVendor1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colVendor1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colVendor1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colVendor1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colVendor1.Name = "colVendor1"
        Me.colVendor1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colVendor1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colVendor1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVendor1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colVendor1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colVendor1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'colInventoried1
        '
        Me.colInventoried1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colInventoried1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colInventoried1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colInventoried1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colInventoried1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colInventoried1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colInventoried1.FieldName = "Inventoried"
        Me.colInventoried1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colInventoried1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colInventoried1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colInventoried1.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colInventoried1.Name = "colInventoried1"
        Me.colInventoried1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colInventoried1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colInventoried1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colInventoried1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colInventoried1.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colInventoried1.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colInventoried1.Visible = True
        Me.colInventoried1.VisibleIndex = 7
        '
        'GridColumnEquipmentTotal
        '
        Me.GridColumnEquipmentTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridColumnEquipmentTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridColumnEquipmentTotal.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridColumnEquipmentTotal.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridColumnEquipmentTotal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridColumnEquipmentTotal.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridColumnEquipmentTotal.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridColumnEquipmentTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridColumnEquipmentTotal.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridColumnEquipmentTotal.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridColumnEquipmentTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridColumnEquipmentTotal.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridColumnEquipmentTotal.Caption = "Total"
        Me.GridColumnEquipmentTotal.DisplayFormat.FormatString = "$###,###.00"
        Me.GridColumnEquipmentTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnEquipmentTotal.FieldName = "colEquipmentTotal"
        Me.GridColumnEquipmentTotal.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.GridColumnEquipmentTotal.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.GridColumnEquipmentTotal.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.GridColumnEquipmentTotal.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.GridColumnEquipmentTotal.Name = "GridColumnEquipmentTotal"
        Me.GridColumnEquipmentTotal.OptionsColumn.AllowEdit = False
        Me.GridColumnEquipmentTotal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridColumnEquipmentTotal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridColumnEquipmentTotal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridColumnEquipmentTotal.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.GridColumnEquipmentTotal.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.GridColumnEquipmentTotal.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridColumnEquipmentTotal.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridColumnEquipmentTotal.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.GridColumnEquipmentTotal.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.GridColumnEquipmentTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumnEquipmentTotal.Visible = True
        Me.GridColumnEquipmentTotal.VisibleIndex = 2
        '
        'colComments2
        '
        Me.colComments2.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments2.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments2.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colComments2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colComments2.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colComments2.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colComments2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colComments2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colComments2.FieldName = "Comments"
        Me.colComments2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colComments2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colComments2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colComments2.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colComments2.Name = "colComments2"
        Me.colComments2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colComments2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colComments2.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments2.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colComments2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colComments2.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colComments2.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Location = New System.Drawing.Point(5, 5)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        Me.DocumentContainer1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.DocumentContainer1.Size = New System.Drawing.Size(608, 674)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(608, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-58, 0)
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
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(608, 674)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(617, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(258, 674)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(258, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(58, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.navbarEquipment)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(256, 648)
        Me.ToolWindow1.Text = "Details"
        '
        'navbarEquipment
        '
        Me.navbarEquipment.ActiveGroup = Me.navEquipmentBasic
        Me.navbarEquipment.Appearance.Background.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.Background.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.Background.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.Background.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.Background.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.Background.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.Button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.Button.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.Button.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.Button.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.Button.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.GroupBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.GroupBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.GroupBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.GroupBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.GroupHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.GroupHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.GroupHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.GroupHeaderPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.GroupHeaderPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.Hint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.Hint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.Hint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.Hint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.Hint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.Hint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.Item.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.Item.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.Item.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.Item.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.Item.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.Item.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ItemActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ItemActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ItemActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ItemActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ItemDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ItemDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ItemDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ItemHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ItemHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ItemHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.ItemPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.ItemPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.ItemPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.LinkDropTarget.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.LinkDropTarget.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.LinkDropTarget.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.LinkDropTarget.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.LinkDropTarget.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.LinkDropTarget.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.NavigationPaneHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.NavigationPaneHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.NavigationPaneHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.NavigationPaneHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.NavigationPaneHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.NavPaneContentButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarEquipment.Appearance.NavPaneContentButtonReleased.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarEquipment.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.navbarEquipment.Controls.Add(Me.NavBarGroupControlContainer13)
        Me.navbarEquipment.Controls.Add(Me.NavBarGroupControlContainer15)
        Me.navbarEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navbarEquipment.DragDropFlags = CType((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop), DevExpress.XtraNavBar.NavBarDragDrop)
        Me.navbarEquipment.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navEquipmentBasic, Me.navEquipmentAdvanced})
        Me.navbarEquipment.Location = New System.Drawing.Point(0, 0)
        Me.navbarEquipment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.navbarEquipment.Name = "navbarEquipment"
        Me.navbarEquipment.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Normal
        Me.navbarEquipment.OptionsNavPane.ExpandedWidth = 239
        Me.navbarEquipment.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        Me.navbarEquipment.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.[Default]
        Me.navbarEquipment.Size = New System.Drawing.Size(256, 648)
        Me.navbarEquipment.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.[Default]
        Me.navbarEquipment.TabIndex = 13
        Me.navbarEquipment.Text = "NavBarControl1"
        '
        'navEquipmentBasic
        '
        Me.navEquipmentBasic.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentBasic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentBasic.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentBasic.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentBasic.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentBasic.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentBasic.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentBasic.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentBasic.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentBasic.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentBasic.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentBasic.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentBasic.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentBasic.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentBasic.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentBasic.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentBasic.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentBasic.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentBasic.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentBasic.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentBasic.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentBasic.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentBasic.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentBasic.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentBasic.Caption = "Basic Properties"
        Me.navEquipmentBasic.ControlContainer = Me.NavBarGroupControlContainer13
        Me.navEquipmentBasic.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navEquipmentBasic.Expanded = True
        Me.navEquipmentBasic.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navEquipmentBasic.GroupClientHeight = 494
        Me.navEquipmentBasic.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navEquipmentBasic.LargeImage = Global.Inventory.My.Resources.Resources.Misc_Box_32
        Me.navEquipmentBasic.Name = "navEquipmentBasic"
        '
        'NavBarGroupControlContainer13
        '
        Me.NavBarGroupControlContainer13.Controls.Add(Me.cboEquipmentFund)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentComments)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentFund)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentComments)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentCost)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentVendor)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentCost)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentVendor)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentDescription)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.dataEquipmentPurchased)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.cboEquipmentModel)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.cboEquipmentCondition)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.cboEquipmentBrand)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentDate)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentCondition)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentModel)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentBrand)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentDescription)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentQuantity)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentQuantity)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.txtEquipmentSerial)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.lblEquipmentSerial)
        Me.NavBarGroupControlContainer13.Controls.Add(Me.chkEquipmentInventoried)
        Me.NavBarGroupControlContainer13.Name = "NavBarGroupControlContainer13"
        Me.NavBarGroupControlContainer13.Size = New System.Drawing.Size(252, 492)
        Me.NavBarGroupControlContainer13.TabIndex = 1
        '
        'cboEquipmentFund
        '
        Me.cboEquipmentFund.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentFund.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipmentFund.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "FundSource", True))
        Me.cboEquipmentFund.Location = New System.Drawing.Point(105, 142)
        Me.cboEquipmentFund.Name = "cboEquipmentFund"
        Me.cboEquipmentFund.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboEquipmentFund.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentFund.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentFund.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentFund.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentFund.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentFund.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentFund.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentFund.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentFund.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentFund.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentFund.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentFund.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentFund.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject8.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject8.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject8.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject8.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject8.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentFund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.cboEquipmentFund.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEquipmentFund.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboEquipmentFund.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboEquipmentFund.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboEquipmentFund.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboEquipmentFund.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboEquipmentFund.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboEquipmentFund.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboEquipmentFund.Size = New System.Drawing.Size(143, 20)
        Me.cboEquipmentFund.TabIndex = 6
        Me.cboEquipmentFund.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentComments
        '
        Me.txtEquipmentComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentComments.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Comments", True))
        Me.txtEquipmentComments.Location = New System.Drawing.Point(12, 381)
        Me.txtEquipmentComments.Name = "txtEquipmentComments"
        Me.txtEquipmentComments.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentComments.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentComments.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentComments.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentComments.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentComments.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentComments.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentComments.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentComments.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentComments.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentComments.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentComments.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentComments.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentComments.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentComments.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentComments.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentComments.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentComments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentComments.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentComments.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentComments.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentComments.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentComments.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEquipmentComments.Size = New System.Drawing.Size(236, 70)
        Me.txtEquipmentComments.TabIndex = 19
        Me.txtEquipmentComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentFund
        '
        Me.lblEquipmentFund.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentFund.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentFund.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentFund.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentFund.Appearance.Options.UseFont = True
        Me.lblEquipmentFund.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentFund.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentFund.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentFund.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentFund.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentFund.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentFund.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentFund.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentFund.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentFund.Location = New System.Drawing.Point(12, 145)
        Me.lblEquipmentFund.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentFund.Name = "lblEquipmentFund"
        Me.lblEquipmentFund.Size = New System.Drawing.Size(72, 13)
        Me.lblEquipmentFund.TabIndex = 5
        Me.lblEquipmentFund.Text = "Fund Source:"
        Me.lblEquipmentFund.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentComments
        '
        Me.lblEquipmentComments.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentComments.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentComments.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentComments.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentComments.Appearance.Options.UseFont = True
        Me.lblEquipmentComments.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentComments.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentComments.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentComments.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentComments.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentComments.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentComments.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentComments.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentComments.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentComments.Location = New System.Drawing.Point(12, 362)
        Me.lblEquipmentComments.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentComments.Name = "lblEquipmentComments"
        Me.lblEquipmentComments.Size = New System.Drawing.Size(64, 13)
        Me.lblEquipmentComments.TabIndex = 18
        Me.lblEquipmentComments.Text = "Comments:"
        Me.lblEquipmentComments.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentCost
        '
        Me.txtEquipmentCost.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Cost", True))
        Me.txtEquipmentCost.Location = New System.Drawing.Point(105, 116)
        Me.txtEquipmentCost.Name = "txtEquipmentCost"
        Me.txtEquipmentCost.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentCost.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentCost.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentCost.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentCost.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentCost.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentCost.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentCost.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentCost.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentCost.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentCost.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentCost.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentCost.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentCost.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentCost.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentCost.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentCost.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtEquipmentCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEquipmentCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEquipmentCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentCost.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentCost.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentCost.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtEquipmentCost.Properties.Mask.EditMask = "c"
        Me.txtEquipmentCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEquipmentCost.Size = New System.Drawing.Size(143, 20)
        Me.txtEquipmentCost.TabIndex = 4
        Me.txtEquipmentCost.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentVendor
        '
        Me.txtEquipmentVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentVendor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Vendor", True))
        Me.txtEquipmentVendor.Location = New System.Drawing.Point(105, 226)
        Me.txtEquipmentVendor.Name = "txtEquipmentVendor"
        Me.txtEquipmentVendor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentVendor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentVendor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentVendor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentVendor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentVendor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentVendor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentVendor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentVendor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentVendor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentVendor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentVendor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentVendor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentVendor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentVendor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentVendor.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtEquipmentVendor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtEquipmentVendor.Size = New System.Drawing.Size(143, 20)
        Me.txtEquipmentVendor.TabIndex = 16
        Me.txtEquipmentVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentCost
        '
        Me.lblEquipmentCost.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentCost.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentCost.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentCost.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentCost.Appearance.Options.UseFont = True
        Me.lblEquipmentCost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentCost.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentCost.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentCost.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentCost.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentCost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentCost.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentCost.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentCost.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentCost.Location = New System.Drawing.Point(12, 119)
        Me.lblEquipmentCost.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentCost.Name = "lblEquipmentCost"
        Me.lblEquipmentCost.Size = New System.Drawing.Size(28, 13)
        Me.lblEquipmentCost.TabIndex = 3
        Me.lblEquipmentCost.Text = "Cost:"
        Me.lblEquipmentCost.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentVendor
        '
        Me.lblEquipmentVendor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentVendor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentVendor.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentVendor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentVendor.Appearance.Options.UseFont = True
        Me.lblEquipmentVendor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentVendor.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentVendor.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentVendor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentVendor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentVendor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentVendor.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentVendor.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentVendor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentVendor.Location = New System.Drawing.Point(12, 229)
        Me.lblEquipmentVendor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentVendor.Name = "lblEquipmentVendor"
        Me.lblEquipmentVendor.Size = New System.Drawing.Size(43, 13)
        Me.lblEquipmentVendor.TabIndex = 17
        Me.lblEquipmentVendor.Text = "Vendor:"
        Me.lblEquipmentVendor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentDescription
        '
        Me.txtEquipmentDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Description", True))
        Me.txtEquipmentDescription.Location = New System.Drawing.Point(12, 286)
        Me.txtEquipmentDescription.Name = "txtEquipmentDescription"
        Me.txtEquipmentDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentDescription.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentDescription.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentDescription.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentDescription.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentDescription.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentDescription.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentDescription.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentDescription.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentDescription.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentDescription.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentDescription.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentDescription.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEquipmentDescription.Size = New System.Drawing.Size(236, 70)
        Me.txtEquipmentDescription.TabIndex = 6
        Me.txtEquipmentDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dataEquipmentPurchased
        '
        Me.dataEquipmentPurchased.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataEquipmentPurchased.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataEquipmentPurchased.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "DatePurchased", True))
        Me.dataEquipmentPurchased.EditValue = Nothing
        Me.dataEquipmentPurchased.Location = New System.Drawing.Point(105, 90)
        Me.dataEquipmentPurchased.Name = "dataEquipmentPurchased"
        Me.dataEquipmentPurchased.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataEquipmentPurchased.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataEquipmentPurchased.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.dataEquipmentPurchased.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataEquipmentPurchased.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None
        Me.dataEquipmentPurchased.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.None
        Me.dataEquipmentPurchased.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.dataEquipmentPurchased.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataEquipmentPurchased.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataEquipmentPurchased.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataEquipmentPurchased.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataEquipmentPurchased.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.dataEquipmentPurchased.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.dataEquipmentPurchased.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataEquipmentPurchased.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataEquipmentPurchased.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject9.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject9.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject9.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject9.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject9.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject9.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "", Nothing, Nothing, True)})
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.dataEquipmentPurchased.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataEquipmentPurchased.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.dataEquipmentPurchased.Size = New System.Drawing.Size(143, 20)
        Me.dataEquipmentPurchased.TabIndex = 4
        Me.dataEquipmentPurchased.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboEquipmentModel
        '
        Me.cboEquipmentModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentModel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipmentModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Model", True))
        Me.cboEquipmentModel.Location = New System.Drawing.Point(105, 64)
        Me.cboEquipmentModel.Name = "cboEquipmentModel"
        Me.cboEquipmentModel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboEquipmentModel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentModel.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentModel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentModel.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentModel.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentModel.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentModel.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentModel.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentModel.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentModel.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentModel.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentModel.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentModel.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.cboEquipmentModel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEquipmentModel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboEquipmentModel.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboEquipmentModel.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboEquipmentModel.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboEquipmentModel.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboEquipmentModel.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboEquipmentModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboEquipmentModel.Size = New System.Drawing.Size(143, 20)
        Me.cboEquipmentModel.TabIndex = 3
        Me.cboEquipmentModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboEquipmentCondition
        '
        Me.cboEquipmentCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipmentCondition.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Condition", True))
        Me.cboEquipmentCondition.Location = New System.Drawing.Point(105, 174)
        Me.cboEquipmentCondition.Name = "cboEquipmentCondition"
        Me.cboEquipmentCondition.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboEquipmentCondition.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentCondition.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentCondition.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentCondition.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentCondition.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentCondition.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentCondition.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentCondition.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentCondition.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject4.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.cboEquipmentCondition.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEquipmentCondition.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboEquipmentCondition.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboEquipmentCondition.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboEquipmentCondition.Properties.Items.AddRange(New Object() {"New", "Like New", "Very Good", "Good", "Poor", "Discarded"})
        Me.cboEquipmentCondition.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboEquipmentCondition.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboEquipmentCondition.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboEquipmentCondition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboEquipmentCondition.Size = New System.Drawing.Size(143, 20)
        Me.cboEquipmentCondition.TabIndex = 3
        Me.cboEquipmentCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboEquipmentBrand
        '
        Me.cboEquipmentBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentBrand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipmentBrand.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Brand", True))
        Me.cboEquipmentBrand.Location = New System.Drawing.Point(105, 38)
        Me.cboEquipmentBrand.Name = "cboEquipmentBrand"
        Me.cboEquipmentBrand.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboEquipmentBrand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboEquipmentBrand.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentBrand.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentBrand.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentBrand.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentBrand.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentBrand.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentBrand.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboEquipmentBrand.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject5.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject5.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboEquipmentBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.cboEquipmentBrand.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEquipmentBrand.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboEquipmentBrand.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboEquipmentBrand.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboEquipmentBrand.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboEquipmentBrand.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboEquipmentBrand.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboEquipmentBrand.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboEquipmentBrand.Size = New System.Drawing.Size(143, 20)
        Me.cboEquipmentBrand.TabIndex = 3
        Me.cboEquipmentBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentDate
        '
        Me.lblEquipmentDate.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentDate.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentDate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentDate.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentDate.Appearance.Options.UseFont = True
        Me.lblEquipmentDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentDate.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentDate.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentDate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentDate.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentDate.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentDate.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentDate.Location = New System.Drawing.Point(12, 93)
        Me.lblEquipmentDate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentDate.Name = "lblEquipmentDate"
        Me.lblEquipmentDate.Size = New System.Drawing.Size(92, 13)
        Me.lblEquipmentDate.TabIndex = 1
        Me.lblEquipmentDate.Text = "Date Purchased:"
        Me.lblEquipmentDate.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentCondition
        '
        Me.lblEquipmentCondition.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentCondition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentCondition.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentCondition.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentCondition.Appearance.Options.UseFont = True
        Me.lblEquipmentCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentCondition.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentCondition.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentCondition.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentCondition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentCondition.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentCondition.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentCondition.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentCondition.Location = New System.Drawing.Point(12, 177)
        Me.lblEquipmentCondition.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentCondition.Name = "lblEquipmentCondition"
        Me.lblEquipmentCondition.Size = New System.Drawing.Size(56, 13)
        Me.lblEquipmentCondition.TabIndex = 1
        Me.lblEquipmentCondition.Text = "Condition:"
        Me.lblEquipmentCondition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentModel
        '
        Me.lblEquipmentModel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentModel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentModel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentModel.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentModel.Appearance.Options.UseFont = True
        Me.lblEquipmentModel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentModel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentModel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentModel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentModel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentModel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentModel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentModel.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentModel.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentModel.Location = New System.Drawing.Point(12, 67)
        Me.lblEquipmentModel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentModel.Name = "lblEquipmentModel"
        Me.lblEquipmentModel.Size = New System.Drawing.Size(37, 13)
        Me.lblEquipmentModel.TabIndex = 1
        Me.lblEquipmentModel.Text = "Model:"
        Me.lblEquipmentModel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentBrand
        '
        Me.lblEquipmentBrand.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentBrand.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentBrand.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentBrand.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentBrand.Appearance.Options.UseFont = True
        Me.lblEquipmentBrand.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentBrand.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentBrand.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentBrand.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentBrand.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentBrand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentBrand.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentBrand.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentBrand.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentBrand.Location = New System.Drawing.Point(12, 41)
        Me.lblEquipmentBrand.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentBrand.Name = "lblEquipmentBrand"
        Me.lblEquipmentBrand.Size = New System.Drawing.Size(36, 13)
        Me.lblEquipmentBrand.TabIndex = 1
        Me.lblEquipmentBrand.Text = "Brand:"
        Me.lblEquipmentBrand.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentDescription
        '
        Me.lblEquipmentDescription.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentDescription.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentDescription.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentDescription.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentDescription.Appearance.Options.UseFont = True
        Me.lblEquipmentDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentDescription.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentDescription.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentDescription.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentDescription.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentDescription.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentDescription.Location = New System.Drawing.Point(12, 267)
        Me.lblEquipmentDescription.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentDescription.Name = "lblEquipmentDescription"
        Me.lblEquipmentDescription.Size = New System.Drawing.Size(64, 13)
        Me.lblEquipmentDescription.TabIndex = 1
        Me.lblEquipmentDescription.Text = "Description"
        Me.lblEquipmentDescription.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentQuantity
        '
        Me.txtEquipmentQuantity.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentQuantity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Quantity", True))
        Me.txtEquipmentQuantity.Location = New System.Drawing.Point(105, 200)
        Me.txtEquipmentQuantity.Name = "txtEquipmentQuantity"
        Me.txtEquipmentQuantity.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentQuantity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentQuantity.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentQuantity.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentQuantity.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentQuantity.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentQuantity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentQuantity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentQuantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentQuantity.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentQuantity.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentQuantity.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtEquipmentQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtEquipmentQuantity.Size = New System.Drawing.Size(143, 20)
        Me.txtEquipmentQuantity.TabIndex = 2
        Me.txtEquipmentQuantity.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentQuantity
        '
        Me.lblEquipmentQuantity.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentQuantity.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentQuantity.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentQuantity.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentQuantity.Appearance.Options.UseFont = True
        Me.lblEquipmentQuantity.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentQuantity.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentQuantity.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentQuantity.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentQuantity.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentQuantity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentQuantity.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentQuantity.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentQuantity.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentQuantity.Location = New System.Drawing.Point(12, 203)
        Me.lblEquipmentQuantity.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentQuantity.Name = "lblEquipmentQuantity"
        Me.lblEquipmentQuantity.Size = New System.Drawing.Size(52, 13)
        Me.lblEquipmentQuantity.TabIndex = 1
        Me.lblEquipmentQuantity.Text = "Quantity:"
        Me.lblEquipmentQuantity.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtEquipmentSerial
        '
        Me.txtEquipmentSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentSerial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentSerial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "SerialNo", True))
        Me.txtEquipmentSerial.Location = New System.Drawing.Point(105, 12)
        Me.txtEquipmentSerial.Name = "txtEquipmentSerial"
        Me.txtEquipmentSerial.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentSerial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentSerial.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentSerial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentSerial.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentSerial.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentSerial.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentSerial.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentSerial.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentSerial.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentSerial.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentSerial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentSerial.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentSerial.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentSerial.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentSerial.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtEquipmentSerial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtEquipmentSerial.Size = New System.Drawing.Size(143, 20)
        Me.txtEquipmentSerial.TabIndex = 2
        Me.txtEquipmentSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentSerial
        '
        Me.lblEquipmentSerial.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentSerial.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentSerial.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentSerial.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentSerial.Appearance.Options.UseFont = True
        Me.lblEquipmentSerial.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentSerial.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentSerial.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentSerial.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentSerial.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentSerial.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentSerial.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentSerial.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentSerial.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentSerial.Location = New System.Drawing.Point(12, 15)
        Me.lblEquipmentSerial.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentSerial.Name = "lblEquipmentSerial"
        Me.lblEquipmentSerial.Size = New System.Drawing.Size(82, 13)
        Me.lblEquipmentSerial.TabIndex = 1
        Me.lblEquipmentSerial.Text = "Serial Number:"
        Me.lblEquipmentSerial.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'chkEquipmentInventoried
        '
        Me.chkEquipmentInventoried.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.chkEquipmentInventoried.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Inventoried", True))
        Me.chkEquipmentInventoried.Location = New System.Drawing.Point(10, 461)
        Me.chkEquipmentInventoried.Name = "chkEquipmentInventoried"
        Me.chkEquipmentInventoried.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.chkEquipmentInventoried.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEquipmentInventoried.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkEquipmentInventoried.Properties.Appearance.Options.UseFont = True
        Me.chkEquipmentInventoried.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkEquipmentInventoried.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkEquipmentInventoried.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.chkEquipmentInventoried.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.chkEquipmentInventoried.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.chkEquipmentInventoried.Properties.Caption = "Inventoried"
        Me.chkEquipmentInventoried.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.chkEquipmentInventoried.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.chkEquipmentInventoried.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.chkEquipmentInventoried.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.chkEquipmentInventoried.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.chkEquipmentInventoried.Size = New System.Drawing.Size(96, 19)
        Me.chkEquipmentInventoried.TabIndex = 0
        Me.chkEquipmentInventoried.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer15
        '
        Me.NavBarGroupControlContainer15.Controls.Add(Me.txtEquipmentID)
        Me.NavBarGroupControlContainer15.Controls.Add(Me.lblEquipmentID)
        Me.NavBarGroupControlContainer15.Name = "NavBarGroupControlContainer15"
        Me.NavBarGroupControlContainer15.Size = New System.Drawing.Size(252, 45)
        Me.NavBarGroupControlContainer15.TabIndex = 3
        '
        'txtEquipmentID
        '
        Me.txtEquipmentID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipmentID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EquipmentBinding, "Id", True))
        Me.txtEquipmentID.Location = New System.Drawing.Point(47, 12)
        Me.txtEquipmentID.Name = "txtEquipmentID"
        Me.txtEquipmentID.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtEquipmentID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtEquipmentID.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentID.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentID.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentID.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentID.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentID.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentID.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentID.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentID.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentID.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentID.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtEquipmentID.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtEquipmentID.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtEquipmentID.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtEquipmentID.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtEquipmentID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtEquipmentID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEquipmentID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtEquipmentID.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtEquipmentID.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtEquipmentID.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtEquipmentID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtEquipmentID.Properties.ReadOnly = True
        Me.txtEquipmentID.Size = New System.Drawing.Size(201, 20)
        Me.txtEquipmentID.TabIndex = 4
        Me.txtEquipmentID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblEquipmentID
        '
        Me.lblEquipmentID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEquipmentID.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEquipmentID.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEquipmentID.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEquipmentID.Appearance.Options.UseFont = True
        Me.lblEquipmentID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEquipmentID.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEquipmentID.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEquipmentID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEquipmentID.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEquipmentID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEquipmentID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEquipmentID.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEquipmentID.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEquipmentID.Location = New System.Drawing.Point(12, 15)
        Me.lblEquipmentID.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEquipmentID.Name = "lblEquipmentID"
        Me.lblEquipmentID.Size = New System.Drawing.Size(16, 13)
        Me.lblEquipmentID.TabIndex = 3
        Me.lblEquipmentID.Text = "ID:"
        Me.lblEquipmentID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'navEquipmentAdvanced
        '
        Me.navEquipmentAdvanced.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentAdvanced.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentAdvanced.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentAdvanced.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentAdvanced.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentAdvanced.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentAdvanced.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentAdvanced.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentAdvanced.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentAdvanced.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentAdvanced.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentAdvanced.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentAdvanced.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentAdvanced.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentAdvanced.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentAdvanced.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentAdvanced.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentAdvanced.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentAdvanced.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navEquipmentAdvanced.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navEquipmentAdvanced.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navEquipmentAdvanced.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navEquipmentAdvanced.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navEquipmentAdvanced.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navEquipmentAdvanced.Caption = "Advanced Properties"
        Me.navEquipmentAdvanced.ControlContainer = Me.NavBarGroupControlContainer15
        Me.navEquipmentAdvanced.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navEquipmentAdvanced.Expanded = True
        Me.navEquipmentAdvanced.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navEquipmentAdvanced.GroupClientHeight = 47
        Me.navEquipmentAdvanced.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navEquipmentAdvanced.LargeImage = Global.Inventory.My.Resources.Resources.Config_32
        Me.navEquipmentAdvanced.Name = "navEquipmentAdvanced"
        '
        'frmEquipment
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 684)
        Me.Controls.Add(Me.RadDock1)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmEquipment"
        Me.Text = "Equipment"
        CType(Me.EquipmentBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentCollectionBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEquipmentQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEquipmentCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.navbarEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navbarEquipment.ResumeLayout(False)
        Me.NavBarGroupControlContainer13.ResumeLayout(False)
        Me.NavBarGroupControlContainer13.PerformLayout()
        CType(Me.cboEquipmentFund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataEquipmentPurchased.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataEquipmentPurchased.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEquipmentModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEquipmentCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEquipmentBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquipmentSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEquipmentInventoried.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer15.ResumeLayout(False)
        Me.NavBarGroupControlContainer15.PerformLayout()
        CType(Me.txtEquipmentID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EquipmentBinding As System.Windows.Forms.BindingSource
    Friend WithEvents EquipmentCollectionBinding As System.Windows.Forms.BindingSource
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents gridEquipment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewEquipment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repEquipmentQuantity As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colRoomID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerialNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colDatePurchased1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFundSource1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repEquipmentCondition As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDiscard1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoried1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnEquipmentTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents navbarEquipment As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroupControlContainer13 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtEquipmentComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblEquipmentComments As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquipmentVendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEquipmentVendor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquipmentDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dataEquipmentPurchased As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboEquipmentModel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboEquipmentCondition As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboEquipmentBrand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblEquipmentDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipmentCondition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipmentModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipmentBrand As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEquipmentDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquipmentQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEquipmentQuantity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquipmentSerial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEquipmentSerial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkEquipmentInventoried As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboEquipmentFund As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblEquipmentFund As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquipmentCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEquipmentCost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavBarGroupControlContainer15 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtEquipmentID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEquipmentID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents navEquipmentBasic As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navEquipmentAdvanced As DevExpress.XtraNavBar.NavBarGroup
End Class
