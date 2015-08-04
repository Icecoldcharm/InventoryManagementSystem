<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.navbarUsers = New DevExpress.XtraNavBar.NavBarControl()
        Me.navUserBasics = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer10 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtUserLastName = New DevExpress.XtraEditors.TextEdit()
        Me.UserBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUserLastName = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.lblUserFirstName = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarGroupControlContainer11 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cboUserAccount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboUserType = New DevExpress.XtraEditors.LabelControl()
        Me.lblUserPassword = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserUserName = New DevExpress.XtraEditors.TextEdit()
        Me.lblUserUserName = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarGroupControlContainer12 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txtUserID = New DevExpress.XtraEditors.TextEdit()
        Me.lblUserID = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gridRooms = New DevExpress.XtraGrid.GridControl()
        Me.gridViewRooms = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVisible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuilding = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnRoomAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRoomDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.StandaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barRoomSelector = New DevExpress.XtraBars.Bar()
        Me.btnAddSelectedRooms = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelRoomSelector = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockRoomSelector = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnRoomsDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.navUserLogin = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navUserRooms = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navUserAdvanced = New DevExpress.XtraNavBar.NavBarGroup()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridUsers = New DevExpress.XtraGrid.GridControl()
        Me.GridViewUsers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UsersCollectionBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.dockUsers = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.docUsers = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.grpRooms = New DevExpress.XtraEditors.GroupControl()
        Me.gridRoomSelector = New DevExpress.XtraGrid.GridControl()
        Me.gridViewRoomSelector = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpPassword = New DevExpress.XtraEditors.GroupControl()
        Me.picPasswordConfirmValidate = New System.Windows.Forms.PictureBox()
        Me.picPasswordValidate = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.lblConfirmPassword = New DevExpress.XtraEditors.LabelControl()
        Me.lblNewPassword = New DevExpress.XtraEditors.LabelControl()
        Me.btnPasswordChange = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelPassword = New DevExpress.XtraEditors.SimpleButton()
        Me.picChangePassword = New System.Windows.Forms.PictureBox()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.RoomsCollectionBinding = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.navbarUsers,System.ComponentModel.ISupportInitialize).BeginInit
        Me.navbarUsers.SuspendLayout
        Me.NavBarGroupControlContainer10.SuspendLayout
        CType(Me.txtUserLastName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UserBinding,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtUserFirstName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NavBarGroupControlContainer11.SuspendLayout
        CType(Me.cboUserAccount.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtUserUserName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NavBarGroupControlContainer12.SuspendLayout
        CType(Me.txtUserID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.NavBarGroupControlContainer1.SuspendLayout
        CType(Me.gridRooms,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridViewRooms,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RoomBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridUsers,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridViewUsers,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UsersCollectionBinding,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dockUsers,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolWindow1.SuspendLayout
        CType(Me.DocumentContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DocumentTabStrip1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.docUsers.SuspendLayout
        CType(Me.grpRooms,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpRooms.SuspendLayout
        CType(Me.gridRoomSelector,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridViewRoomSelector,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpPassword,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpPassword.SuspendLayout
        CType(Me.picPasswordConfirmValidate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picPasswordValidate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtConfirmPassword.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNewPassword.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picChangePassword,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ToolTabStrip1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RoomsCollectionBinding,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'navbarUsers
        '
        Me.navbarUsers.ActiveGroup = Me.navUserBasics
        Me.navbarUsers.Appearance.Background.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.Background.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.Background.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.Background.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.Background.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.Background.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.Button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.Button.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.Button.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.Button.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.Button.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.GroupBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.GroupBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.GroupBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.GroupBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.GroupBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.GroupBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.GroupHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.GroupHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.GroupHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.GroupHeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.GroupHeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.GroupHeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.GroupHeaderPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.GroupHeaderPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.GroupHeaderPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.GroupHeaderPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.GroupHeaderPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.Hint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.Hint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.Hint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.Hint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.Hint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.Hint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.Item.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.Item.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.Item.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.Item.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.Item.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.Item.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ItemActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ItemActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ItemActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ItemActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ItemActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ItemActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ItemDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ItemDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ItemDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ItemDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ItemHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ItemHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ItemHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ItemHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.ItemPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.ItemPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.ItemPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.ItemPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.LinkDropTarget.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.LinkDropTarget.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.LinkDropTarget.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.LinkDropTarget.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.LinkDropTarget.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.LinkDropTarget.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.NavigationPaneHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.NavigationPaneHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.NavigationPaneHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.NavigationPaneHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.NavigationPaneHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.NavPaneContentButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navbarUsers.Appearance.NavPaneContentButtonReleased.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navbarUsers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.navbarUsers.Controls.Add(Me.NavBarGroupControlContainer10)
        Me.navbarUsers.Controls.Add(Me.NavBarGroupControlContainer11)
        Me.navbarUsers.Controls.Add(Me.NavBarGroupControlContainer12)
        Me.navbarUsers.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.navbarUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navbarUsers.DragDropFlags = CType((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop),DevExpress.XtraNavBar.NavBarDragDrop)
        Me.navbarUsers.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navUserBasics, Me.navUserLogin, Me.navUserRooms, Me.navUserAdvanced})
        Me.navbarUsers.Location = New System.Drawing.Point(0, 0)
        Me.navbarUsers.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.navbarUsers.Name = "navbarUsers"
        Me.navbarUsers.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Normal
        Me.navbarUsers.OptionsNavPane.ExpandedWidth = 239
        Me.navbarUsers.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        Me.navbarUsers.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.[Default]
        Me.navbarUsers.Size = New System.Drawing.Size(290, 596)
        Me.navbarUsers.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.[Default]
        Me.navbarUsers.TabIndex = 13
        Me.navbarUsers.Text = "NavBarControl1"
        '
        'navUserBasics
        '
        Me.navUserBasics.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserBasics.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserBasics.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserBasics.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserBasics.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserBasics.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserBasics.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserBasics.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserBasics.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserBasics.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserBasics.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserBasics.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserBasics.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserBasics.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserBasics.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserBasics.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserBasics.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserBasics.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserBasics.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserBasics.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserBasics.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserBasics.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserBasics.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserBasics.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserBasics.Caption = "Basic Properties"
        Me.navUserBasics.ControlContainer = Me.NavBarGroupControlContainer10
        Me.navUserBasics.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navUserBasics.Expanded = true
        Me.navUserBasics.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navUserBasics.GroupClientHeight = 69
        Me.navUserBasics.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navUserBasics.LargeImage = Global.Inventory.My.Resources.Resources.people_med
        Me.navUserBasics.Name = "navUserBasics"
        '
        'NavBarGroupControlContainer10
        '
        Me.NavBarGroupControlContainer10.Controls.Add(Me.txtUserLastName)
        Me.NavBarGroupControlContainer10.Controls.Add(Me.lblUserLastName)
        Me.NavBarGroupControlContainer10.Controls.Add(Me.txtUserFirstName)
        Me.NavBarGroupControlContainer10.Controls.Add(Me.lblUserFirstName)
        Me.NavBarGroupControlContainer10.Name = "NavBarGroupControlContainer10"
        Me.NavBarGroupControlContainer10.Size = New System.Drawing.Size(286, 67)
        Me.NavBarGroupControlContainer10.TabIndex = 1
        '
        'txtUserLastName
        '
        Me.txtUserLastName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUserLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBinding, "LastName", true))
        Me.txtUserLastName.Location = New System.Drawing.Point(105, 36)
        Me.txtUserLastName.Name = "txtUserLastName"
        Me.txtUserLastName.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtUserLastName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserLastName.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserLastName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserLastName.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserLastName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserLastName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserLastName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserLastName.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserLastName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserLastName.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserLastName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserLastName.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserLastName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserLastName.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserLastName.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserLastName.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserLastName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserLastName.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserLastName.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserLastName.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserLastName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtUserLastName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserLastName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtUserLastName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtUserLastName.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtUserLastName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtUserLastName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtUserLastName.Size = New System.Drawing.Size(177, 20)
        Me.txtUserLastName.TabIndex = 1
        Me.txtUserLastName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'UserBinding
        '
        Me.UserBinding.DataSource = GetType(InventoryData.BusinessObjects.User)
        '
        'lblUserLastName
        '
        Me.lblUserLastName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblUserLastName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserLastName.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblUserLastName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUserLastName.Appearance.Options.UseFont = true
        Me.lblUserLastName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUserLastName.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblUserLastName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblUserLastName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblUserLastName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblUserLastName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblUserLastName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblUserLastName.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblUserLastName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblUserLastName.Location = New System.Drawing.Point(12, 39)
        Me.lblUserLastName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblUserLastName.Name = "lblUserLastName"
        Me.lblUserLastName.Size = New System.Drawing.Size(62, 13)
        Me.lblUserLastName.TabIndex = 1
        Me.lblUserLastName.Text = "Last Name:"
        Me.lblUserLastName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtUserFirstName
        '
        Me.txtUserFirstName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUserFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBinding, "FirstName", true))
        Me.txtUserFirstName.Location = New System.Drawing.Point(105, 10)
        Me.txtUserFirstName.Name = "txtUserFirstName"
        Me.txtUserFirstName.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtUserFirstName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserFirstName.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserFirstName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserFirstName.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserFirstName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserFirstName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserFirstName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserFirstName.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserFirstName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserFirstName.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserFirstName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserFirstName.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserFirstName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserFirstName.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserFirstName.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserFirstName.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserFirstName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserFirstName.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserFirstName.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserFirstName.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserFirstName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtUserFirstName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserFirstName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtUserFirstName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtUserFirstName.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtUserFirstName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtUserFirstName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtUserFirstName.Size = New System.Drawing.Size(177, 20)
        Me.txtUserFirstName.TabIndex = 0
        Me.txtUserFirstName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblUserFirstName
        '
        Me.lblUserFirstName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblUserFirstName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserFirstName.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblUserFirstName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUserFirstName.Appearance.Options.UseFont = true
        Me.lblUserFirstName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUserFirstName.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblUserFirstName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblUserFirstName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblUserFirstName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblUserFirstName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblUserFirstName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblUserFirstName.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblUserFirstName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblUserFirstName.Location = New System.Drawing.Point(12, 13)
        Me.lblUserFirstName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblUserFirstName.Name = "lblUserFirstName"
        Me.lblUserFirstName.Size = New System.Drawing.Size(63, 13)
        Me.lblUserFirstName.TabIndex = 1
        Me.lblUserFirstName.Text = "First Name:"
        Me.lblUserFirstName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer11
        '
        Me.NavBarGroupControlContainer11.Controls.Add(Me.cboUserAccount)
        Me.NavBarGroupControlContainer11.Controls.Add(Me.cboUserType)
        Me.NavBarGroupControlContainer11.Controls.Add(Me.lblUserPassword)
        Me.NavBarGroupControlContainer11.Controls.Add(Me.txtUserUserName)
        Me.NavBarGroupControlContainer11.Controls.Add(Me.lblUserUserName)
        Me.NavBarGroupControlContainer11.Name = "NavBarGroupControlContainer11"
        Me.NavBarGroupControlContainer11.Size = New System.Drawing.Size(286, 97)
        Me.NavBarGroupControlContainer11.TabIndex = 2
        '
        'cboUserAccount
        '
        Me.cboUserAccount.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboUserAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboUserAccount.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBinding, "AccountType", true))
        Me.cboUserAccount.Location = New System.Drawing.Point(105, 60)
        Me.cboUserAccount.Name = "cboUserAccount"
        Me.cboUserAccount.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cboUserAccount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboUserAccount.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserAccount.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserAccount.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserAccount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserAccount.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserAccount.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserAccount.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserAccount.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserAccount.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserAccount.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserAccount.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserAccount.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserAccount.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserAccount.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserAccount.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserAccount.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserAccount.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserAccount.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserAccount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, true)})
        Me.cboUserAccount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboUserAccount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cboUserAccount.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cboUserAccount.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cboUserAccount.Properties.Items.AddRange(New Object() {"Administrator", "Teacher"})
        Me.cboUserAccount.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboUserAccount.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cboUserAccount.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cboUserAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboUserAccount.Size = New System.Drawing.Size(177, 20)
        Me.cboUserAccount.TabIndex = 3
        Me.cboUserAccount.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cboUserType
        '
        Me.cboUserType.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cboUserType.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboUserType.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cboUserType.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cboUserType.Appearance.Options.UseFont = true
        Me.cboUserType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cboUserType.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cboUserType.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cboUserType.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cboUserType.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cboUserType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.cboUserType.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.cboUserType.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.cboUserType.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.cboUserType.Location = New System.Drawing.Point(12, 63)
        Me.cboUserType.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(80, 13)
        Me.cboUserType.TabIndex = 5
        Me.cboUserType.Text = "Account Type:"
        Me.cboUserType.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblUserPassword.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserPassword.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblUserPassword.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUserPassword.Appearance.Options.UseFont = true
        Me.lblUserPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUserPassword.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblUserPassword.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblUserPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblUserPassword.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblUserPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblUserPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblUserPassword.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblUserPassword.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblUserPassword.Location = New System.Drawing.Point(12, 41)
        Me.lblUserPassword.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(220, 13)
        Me.lblUserPassword.TabIndex = 3
        Me.lblUserPassword.Text = "Password:            Set in Active Directory"
        Me.lblUserPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtUserUserName
        '
        Me.txtUserUserName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUserUserName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBinding, "UserName", true))
        Me.txtUserUserName.Location = New System.Drawing.Point(105, 12)
        Me.txtUserUserName.Name = "txtUserUserName"
        Me.txtUserUserName.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtUserUserName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserUserName.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserUserName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserUserName.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserUserName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserUserName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserUserName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserUserName.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserUserName.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserUserName.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserUserName.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserUserName.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserUserName.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserUserName.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserUserName.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserUserName.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserUserName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserUserName.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserUserName.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserUserName.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtUserUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserUserName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtUserUserName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtUserUserName.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtUserUserName.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtUserUserName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtUserUserName.Properties.Mask.EditMask = "c"
        Me.txtUserUserName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtUserUserName.Size = New System.Drawing.Size(177, 20)
        Me.txtUserUserName.TabIndex = 2
        Me.txtUserUserName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblUserUserName
        '
        Me.lblUserUserName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblUserUserName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserUserName.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblUserUserName.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUserUserName.Appearance.Options.UseFont = true
        Me.lblUserUserName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUserUserName.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblUserUserName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblUserUserName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblUserUserName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblUserUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblUserUserName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblUserUserName.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblUserUserName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblUserUserName.Location = New System.Drawing.Point(12, 15)
        Me.lblUserUserName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblUserUserName.Name = "lblUserUserName"
        Me.lblUserUserName.Size = New System.Drawing.Size(64, 13)
        Me.lblUserUserName.TabIndex = 3
        Me.lblUserUserName.Text = "User Name:"
        Me.lblUserUserName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer12
        '
        Me.NavBarGroupControlContainer12.Controls.Add(Me.txtUserID)
        Me.NavBarGroupControlContainer12.Controls.Add(Me.lblUserID)
        Me.NavBarGroupControlContainer12.Name = "NavBarGroupControlContainer12"
        Me.NavBarGroupControlContainer12.Size = New System.Drawing.Size(286, 46)
        Me.NavBarGroupControlContainer12.TabIndex = 3
        '
        'txtUserID
        '
        Me.txtUserID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUserID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBinding, "Id", true))
        Me.txtUserID.Location = New System.Drawing.Point(105, 12)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtUserID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtUserID.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserID.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserID.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserID.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserID.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserID.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserID.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserID.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserID.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserID.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserID.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserID.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserID.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserID.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserID.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserID.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserID.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtUserID.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtUserID.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtUserID.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtUserID.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtUserID.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtUserID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtUserID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtUserID.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtUserID.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtUserID.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtUserID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtUserID.Properties.ReadOnly = true
        Me.txtUserID.Size = New System.Drawing.Size(177, 20)
        Me.txtUserID.TabIndex = 4
        Me.txtUserID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblUserID
        '
        Me.lblUserID.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblUserID.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserID.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblUserID.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUserID.Appearance.Options.UseFont = true
        Me.lblUserID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUserID.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblUserID.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblUserID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblUserID.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblUserID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblUserID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblUserID.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblUserID.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblUserID.Location = New System.Drawing.Point(12, 15)
        Me.lblUserID.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(16, 13)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "ID:"
        Me.lblUserID.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.gridRooms)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.StandaloneBarDockControl1)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(286, 212)
        Me.NavBarGroupControlContainer1.TabIndex = 4
        '
        'gridRooms
        '
        Me.gridRooms.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRooms.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridRooms.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridRooms.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridRooms.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridRooms.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridRooms.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridRooms.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridRooms.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridRooms.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridRooms.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridRooms.Location = New System.Drawing.Point(0, 24)
        Me.gridRooms.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridRooms.MainView = Me.gridViewRooms
        Me.gridRooms.MenuManager = Me.BarManager
        Me.gridRooms.Name = "gridRooms"
        Me.gridRooms.Size = New System.Drawing.Size(286, 188)
        Me.gridRooms.TabIndex = 3
        Me.gridRooms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewRooms})
        '
        'gridViewRooms
        '
        Me.gridViewRooms.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRooms.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRooms.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRooms.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRooms.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRooms.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridViewRooms.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVisible, Me.colBuilding, Me.colRoomNumber, Me.colRoomFullName})
        Me.gridViewRooms.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.gridViewRooms.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.gridViewRooms.GridControl = Me.gridRooms
        Me.gridViewRooms.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.gridViewRooms.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.gridViewRooms.Name = "gridViewRooms"
        Me.gridViewRooms.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridViewRooms.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridViewRooms.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.gridViewRooms.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.gridViewRooms.OptionsBehavior.KeepGroupExpandedOnSorting = false
        Me.gridViewRooms.OptionsCustomization.AllowFilter = false
        Me.gridViewRooms.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.gridViewRooms.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.gridViewRooms.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.gridViewRooms.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.gridViewRooms.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.gridViewRooms.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.gridViewRooms.OptionsView.ShowAutoFilterRow = true
        Me.gridViewRooms.OptionsView.ShowDetailButtons = false
        Me.gridViewRooms.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridViewRooms.OptionsView.ShowGroupPanel = false
        Me.gridViewRooms.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.gridViewRooms.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colVisible
        '
        Me.colVisible.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVisible.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVisible.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVisible.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVisible.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVisible.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVisible.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colVisible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colVisible.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colVisible.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colVisible.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colVisible.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colVisible.Caption = "Visible"
        Me.colVisible.FieldName = "colVisible"
        Me.colVisible.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colVisible.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colVisible.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colVisible.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colVisible.Name = "colVisible"
        Me.colVisible.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVisible.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVisible.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVisible.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colVisible.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colVisible.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVisible.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colVisible.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colVisible.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colVisible.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colVisible.Visible = true
        Me.colVisible.VisibleIndex = 0
        '
        'colBuilding
        '
        Me.colBuilding.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBuilding.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBuilding.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBuilding.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBuilding.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBuilding.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBuilding.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colBuilding.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colBuilding.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colBuilding.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colBuilding.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colBuilding.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colBuilding.Caption = "Building"
        Me.colBuilding.FieldName = "BuildingName"
        Me.colBuilding.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colBuilding.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colBuilding.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colBuilding.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colBuilding.Name = "colBuilding"
        Me.colBuilding.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBuilding.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBuilding.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBuilding.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colBuilding.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colBuilding.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBuilding.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colBuilding.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colBuilding.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colBuilding.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colBuilding.Visible = true
        Me.colBuilding.VisibleIndex = 1
        '
        'colRoomNumber
        '
        Me.colRoomNumber.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomNumber.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomNumber.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomNumber.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomNumber.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomNumber.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomNumber.Caption = "Room Number"
        Me.colRoomNumber.FieldName = "RoomNo"
        Me.colRoomNumber.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colRoomNumber.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colRoomNumber.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colRoomNumber.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colRoomNumber.Name = "colRoomNumber"
        Me.colRoomNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomNumber.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomNumber.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colRoomNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colRoomNumber.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomNumber.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomNumber.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colRoomNumber.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colRoomNumber.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colRoomNumber.Visible = true
        Me.colRoomNumber.VisibleIndex = 2
        '
        'colRoomFullName
        '
        Me.colRoomFullName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomFullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomFullName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomFullName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomFullName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomFullName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomFullName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colRoomFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colRoomFullName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colRoomFullName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colRoomFullName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colRoomFullName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colRoomFullName.Caption = "Full Name"
        Me.colRoomFullName.FieldName = "FullName"
        Me.colRoomFullName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colRoomFullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colRoomFullName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colRoomFullName.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colRoomFullName.Name = "colRoomFullName"
        Me.colRoomFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomFullName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomFullName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colRoomFullName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colRoomFullName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomFullName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colRoomFullName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colRoomFullName.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colRoomFullName.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colRoomFullName.Visible = true
        Me.colRoomFullName.VisibleIndex = 3
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3, Me.barRoomSelector})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockControls.Add(Me.StandaloneBarDockControl1)
        Me.BarManager.DockControls.Add(Me.barDockRoomSelector)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRoomAdd, Me.btnRoomsDelete, Me.btnRoomDelete, Me.btnAddSelectedRooms, Me.btnCancelRoomSelector})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 7
        Me.BarManager.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Always
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Bar2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Bar2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Bar2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Bar2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Bar2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.CanDockStyle = CType((((((DevExpress.XtraBars.BarCanDockStyle.Floating Or DevExpress.XtraBars.BarCanDockStyle.Left)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Top)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Right)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Bottom)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Standalone),DevExpress.XtraBars.BarCanDockStyle)
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.Bar2.FloatLocation = New System.Drawing.Point(1215, 514)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRoomAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRoomDelete)})
        Me.Bar2.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded
        Me.Bar2.OptionsBar.MultiLine = true
        Me.Bar2.OptionsBar.UseWholeRow = true
        Me.Bar2.StandaloneBarDockControl = Me.StandaloneBarDockControl1
        Me.Bar2.Text = "Main menu"
        '
        'btnRoomAdd
        '
        Me.btnRoomAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.btnRoomAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomAdd.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomAdd.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.btnRoomAdd.Caption = "Add Room"
        Me.btnRoomAdd.Glyph = Global.Inventory.My.Resources.Resources.add
        Me.btnRoomAdd.Id = 0
        Me.btnRoomAdd.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.btnRoomAdd.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.btnRoomAdd.Name = "btnRoomAdd"
        Me.btnRoomAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'btnRoomDelete
        '
        Me.btnRoomDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.btnRoomDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomDelete.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.btnRoomDelete.Caption = "Delete"
        Me.btnRoomDelete.Glyph = Global.Inventory.My.Resources.Resources.cancel
        Me.btnRoomDelete.Id = 2
        Me.btnRoomDelete.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.btnRoomDelete.LargeGlyph = Global.Inventory.My.Resources.Resources.cancel
        Me.btnRoomDelete.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.btnRoomDelete.Name = "btnRoomDelete"
        Me.btnRoomDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'StandaloneBarDockControl1
        '
        Me.StandaloneBarDockControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.StandaloneBarDockControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.StandaloneBarDockControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.StandaloneBarDockControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.StandaloneBarDockControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.StandaloneBarDockControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.StandaloneBarDockControl1.CausesValidation = false
        Me.StandaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl1.Name = "StandaloneBarDockControl1"
        Me.StandaloneBarDockControl1.Size = New System.Drawing.Size(286, 24)
        Me.StandaloneBarDockControl1.Text = "StandaloneBarDockControl1"
        '
        'Bar3
        '
        Me.Bar3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Bar3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Bar3.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Bar3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Bar3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Bar3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = false
        Me.Bar3.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded
        Me.Bar3.OptionsBar.DrawDragBorder = false
        Me.Bar3.OptionsBar.UseWholeRow = true
        Me.Bar3.Text = "Status bar"
        '
        'barRoomSelector
        '
        Me.barRoomSelector.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barRoomSelector.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barRoomSelector.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barRoomSelector.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barRoomSelector.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barRoomSelector.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barRoomSelector.BarName = "Room Selector"
        Me.barRoomSelector.CanDockStyle = CType((((((DevExpress.XtraBars.BarCanDockStyle.Floating Or DevExpress.XtraBars.BarCanDockStyle.Left)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Top)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Right)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Bottom)  _
            Or DevExpress.XtraBars.BarCanDockStyle.Standalone),DevExpress.XtraBars.BarCanDockStyle)
        Me.barRoomSelector.DockCol = 0
        Me.barRoomSelector.DockRow = 0
        Me.barRoomSelector.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
        Me.barRoomSelector.FloatLocation = New System.Drawing.Point(474, 464)
        Me.barRoomSelector.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddSelectedRooms), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCancelRoomSelector)})
        Me.barRoomSelector.OptionsBar.AllowRename = true
        Me.barRoomSelector.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded
        Me.barRoomSelector.OptionsBar.UseWholeRow = true
        Me.barRoomSelector.StandaloneBarDockControl = Me.barDockRoomSelector
        Me.barRoomSelector.Text = "Room Selector"
        '
        'btnAddSelectedRooms
        '
        Me.btnAddSelectedRooms.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.btnAddSelectedRooms.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAddSelectedRooms.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAddSelectedRooms.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.btnAddSelectedRooms.Caption = "Add Selected Rooms"
        Me.btnAddSelectedRooms.Glyph = Global.Inventory.My.Resources.Resources.add
        Me.btnAddSelectedRooms.Id = 3
        Me.btnAddSelectedRooms.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.btnAddSelectedRooms.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.btnAddSelectedRooms.Name = "btnAddSelectedRooms"
        Me.btnAddSelectedRooms.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'btnCancelRoomSelector
        '
        Me.btnCancelRoomSelector.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.btnCancelRoomSelector.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCancelRoomSelector.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCancelRoomSelector.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.btnCancelRoomSelector.Caption = "Cancel"
        Me.btnCancelRoomSelector.Glyph = Global.Inventory.My.Resources.Resources.cancel
        Me.btnCancelRoomSelector.Id = 4
        Me.btnCancelRoomSelector.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.btnCancelRoomSelector.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.btnCancelRoomSelector.Name = "btnCancelRoomSelector"
        Me.btnCancelRoomSelector.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'barDockRoomSelector
        '
        Me.barDockRoomSelector.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockRoomSelector.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockRoomSelector.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockRoomSelector.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockRoomSelector.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockRoomSelector.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockRoomSelector.CausesValidation = false
        Me.barDockRoomSelector.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockRoomSelector.Location = New System.Drawing.Point(2, 22)
        Me.barDockRoomSelector.Name = "barDockRoomSelector"
        Me.barDockRoomSelector.Size = New System.Drawing.Size(489, 23)
        Me.barDockRoomSelector.Text = "StandaloneBarDockControl2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlTop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlTop.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlTop.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlTop.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlTop.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1187, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlBottom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 632)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1187, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlLeft.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 632)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlRight.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlRight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1187, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 632)
        '
        'btnRoomsDelete
        '
        Me.btnRoomsDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.btnRoomsDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomsDelete.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnRoomsDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.btnRoomsDelete.Caption = "Remove"
        Me.btnRoomsDelete.Glyph = Global.Inventory.My.Resources.Resources.cancel
        Me.btnRoomsDelete.Id = 1
        Me.btnRoomsDelete.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.btnRoomsDelete.LargeGlyph = Global.Inventory.My.Resources.Resources.cancel
        Me.btnRoomsDelete.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.btnRoomsDelete.Name = "btnRoomsDelete"
        Me.btnRoomsDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'navUserLogin
        '
        Me.navUserLogin.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserLogin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserLogin.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserLogin.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserLogin.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserLogin.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserLogin.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserLogin.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserLogin.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserLogin.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserLogin.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserLogin.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserLogin.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserLogin.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserLogin.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserLogin.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserLogin.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserLogin.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserLogin.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserLogin.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserLogin.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserLogin.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserLogin.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserLogin.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserLogin.Caption = "Login"
        Me.navUserLogin.ControlContainer = Me.NavBarGroupControlContainer11
        Me.navUserLogin.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navUserLogin.Expanded = true
        Me.navUserLogin.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navUserLogin.GroupClientHeight = 99
        Me.navUserLogin.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navUserLogin.LargeImage = Global.Inventory.My.Resources.Resources.Login_32
        Me.navUserLogin.Name = "navUserLogin"
        '
        'navUserRooms
        '
        Me.navUserRooms.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserRooms.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserRooms.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserRooms.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserRooms.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserRooms.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserRooms.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserRooms.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserRooms.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserRooms.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserRooms.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserRooms.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserRooms.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserRooms.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserRooms.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserRooms.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserRooms.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserRooms.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserRooms.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserRooms.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserRooms.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserRooms.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserRooms.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserRooms.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserRooms.Caption = "Rooms"
        Me.navUserRooms.ControlContainer = Me.NavBarGroupControlContainer1
        Me.navUserRooms.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navUserRooms.Expanded = true
        Me.navUserRooms.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navUserRooms.GroupClientHeight = 214
        Me.navUserRooms.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navUserRooms.LargeImage = Global.Inventory.My.Resources.Resources.building_32
        Me.navUserRooms.Name = "navUserRooms"
        '
        'navUserAdvanced
        '
        Me.navUserAdvanced.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserAdvanced.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserAdvanced.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserAdvanced.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserAdvanced.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserAdvanced.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserAdvanced.AppearanceBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserAdvanced.AppearanceBackground.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserAdvanced.AppearanceBackground.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserAdvanced.AppearanceBackground.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserAdvanced.AppearanceBackground.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserAdvanced.AppearanceBackground.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserAdvanced.AppearanceHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserAdvanced.AppearanceHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserAdvanced.AppearanceHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserAdvanced.AppearanceHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserAdvanced.AppearanceHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserAdvanced.AppearanceHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserAdvanced.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.navUserAdvanced.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.navUserAdvanced.AppearancePressed.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.navUserAdvanced.AppearancePressed.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.navUserAdvanced.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.navUserAdvanced.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.navUserAdvanced.Caption = "Advanced Properties"
        Me.navUserAdvanced.ControlContainer = Me.NavBarGroupControlContainer12
        Me.navUserAdvanced.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.[Default]
        Me.navUserAdvanced.Expanded = true
        Me.navUserAdvanced.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.[Default]
        Me.navUserAdvanced.GroupClientHeight = 48
        Me.navUserAdvanced.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navUserAdvanced.LargeImage = Global.Inventory.My.Resources.Resources.Config_32
        Me.navUserAdvanced.Name = "navUserAdvanced"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataSource = GetType(InventoryData.BusinessObjects.Room)
        '
        'gridUsers
        '
        Me.gridUsers.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUsers.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridUsers.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridUsers.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridUsers.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridUsers.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridUsers.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridUsers.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridUsers.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridUsers.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridUsers.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridUsers.Location = New System.Drawing.Point(0, 0)
        Me.gridUsers.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridUsers.MainView = Me.GridViewUsers
        Me.gridUsers.Name = "gridUsers"
        Me.gridUsers.Size = New System.Drawing.Size(869, 587)
        Me.gridUsers.TabIndex = 12
        Me.gridUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUsers})
        '
        'GridViewUsers
        '
        Me.GridViewUsers.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GridViewUsers.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GridViewUsers.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GridViewUsers.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GridViewUsers.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GridViewUsers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.GridViewUsers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUsername, Me.colFirstName, Me.colLastName, Me.colAccountType})
        Me.GridViewUsers.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.GridViewUsers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.GridViewUsers.GridControl = Me.gridUsers
        Me.GridViewUsers.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.GridViewUsers.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.GridViewUsers.Name = "GridViewUsers"
        Me.GridViewUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewUsers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.GridViewUsers.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.GridViewUsers.OptionsBehavior.Editable = false
        Me.GridViewUsers.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.GridViewUsers.OptionsDetail.EnableMasterViewMode = false
        Me.GridViewUsers.OptionsDetail.ShowDetailTabs = false
        Me.GridViewUsers.OptionsDetail.SmartDetailExpand = false
        Me.GridViewUsers.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.GridViewUsers.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridViewUsers.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.GridViewUsers.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.GridViewUsers.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.GridViewUsers.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.GridViewUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.GridViewUsers.OptionsView.ShowAutoFilterRow = true
        Me.GridViewUsers.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.GridViewUsers.OptionsView.ShowGroupPanel = false
        Me.GridViewUsers.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.GridViewUsers.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colUsername
        '
        Me.colUsername.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colUsername.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colUsername.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colUsername.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colUsername.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colUsername.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colUsername.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colUsername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colUsername.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colUsername.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colUsername.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colUsername.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colUsername.FieldName = "UserName"
        Me.colUsername.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colUsername.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colUsername.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colUsername.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colUsername.Name = "colUsername"
        Me.colUsername.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colUsername.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colUsername.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colUsername.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colUsername.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colUsername.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colUsername.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colUsername.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colUsername.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colUsername.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colUsername.Visible = true
        Me.colUsername.VisibleIndex = 0
        '
        'colFirstName
        '
        Me.colFirstName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFirstName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFirstName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFirstName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFirstName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFirstName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFirstName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colFirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colFirstName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colFirstName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colFirstName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colFirstName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colFirstName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colFirstName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colFirstName.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFirstName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFirstName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFirstName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colFirstName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colFirstName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFirstName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colFirstName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colFirstName.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colFirstName.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colFirstName.Visible = true
        Me.colFirstName.VisibleIndex = 1
        '
        'colLastName
        '
        Me.colLastName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colLastName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colLastName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colLastName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colLastName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colLastName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colLastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colLastName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colLastName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colLastName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colLastName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colLastName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colLastName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colLastName.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colLastName.Name = "colLastName"
        Me.colLastName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colLastName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colLastName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colLastName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colLastName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colLastName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colLastName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colLastName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colLastName.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colLastName.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colLastName.Visible = true
        Me.colLastName.VisibleIndex = 2
        '
        'colAccountType
        '
        Me.colAccountType.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colAccountType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colAccountType.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colAccountType.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colAccountType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colAccountType.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colAccountType.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.colAccountType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.colAccountType.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.colAccountType.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.colAccountType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.colAccountType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.colAccountType.FieldName = "AccountType"
        Me.colAccountType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
        Me.colAccountType.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
        Me.colAccountType.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
        Me.colAccountType.ImageAlignment = System.Drawing.StringAlignment.Near
        Me.colAccountType.Name = "colAccountType"
        Me.colAccountType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colAccountType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colAccountType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colAccountType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.colAccountType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.colAccountType.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colAccountType.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
        Me.colAccountType.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        Me.colAccountType.SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
        Me.colAccountType.UnboundType = DevExpress.Data.UnboundColumnType.Bound
        Me.colAccountType.Visible = true
        Me.colAccountType.VisibleIndex = 3
        '
        'UsersCollectionBinding
        '
        Me.UsersCollectionBinding.DataSource = GetType(InventoryData.BusinessObjects.UserCollection)
        '
        'dockUsers
        '
        Me.dockUsers.ActiveWindow = Me.docUsers
        Me.dockUsers.CausesValidation = false
        Me.dockUsers.Controls.Add(Me.DocumentContainer1)
        Me.dockUsers.Controls.Add(Me.ToolTabStrip1)
        Me.dockUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockUsers.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.dockUsers.IsCleanUpTarget = true
        Me.dockUsers.Location = New System.Drawing.Point(0, 0)
        Me.dockUsers.MainDocumentContainer = Me.DocumentContainer1
        Me.dockUsers.Name = "dockUsers"
        Me.dockUsers.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.dockUsers.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.dockUsers.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.dockUsers.Size = New System.Drawing.Size(1187, 632)
        Me.dockUsers.SplitterWidth = 4
        Me.dockUsers.TabIndex = 16
        Me.dockUsers.TabStop = false
        Me.dockUsers.Text = "RadDock1"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.navbarUsers)
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(290, 596)
        Me.ToolWindow1.Text = "Details"
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
        Me.DocumentContainer1.Size = New System.Drawing.Size(881, 622)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(701, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-92, 0)
        Me.DocumentContainer1.SplitterWidth = 4
        Me.DocumentContainer1.TabIndex = 0
        Me.DocumentContainer1.TabStop = false
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.Controls.Add(Me.docUsers)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(881, 622)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = false
        '
        'docUsers
        '
        Me.docUsers.Controls.Add(Me.grpRooms)
        Me.docUsers.Controls.Add(Me.grpPassword)
        Me.docUsers.Controls.Add(Me.gridUsers)
        Me.docUsers.Location = New System.Drawing.Point(6, 29)
        Me.docUsers.Name = "docUsers"
        Me.docUsers.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.docUsers.Size = New System.Drawing.Size(869, 587)
        Me.docUsers.Text = "Users"
        '
        'grpRooms
        '
        Me.grpRooms.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.grpRooms.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grpRooms.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.grpRooms.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.grpRooms.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.grpRooms.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.grpRooms.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.grpRooms.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grpRooms.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.grpRooms.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.grpRooms.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.grpRooms.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.grpRooms.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.grpRooms.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.grpRooms.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.grpRooms.Controls.Add(Me.gridRoomSelector)
        Me.grpRooms.Controls.Add(Me.barDockRoomSelector)
        Me.grpRooms.Location = New System.Drawing.Point(142, 112)
        Me.grpRooms.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.grpRooms.Name = "grpRooms"
        Me.grpRooms.Size = New System.Drawing.Size(493, 305)
        Me.grpRooms.TabIndex = 21
        Me.grpRooms.Text = "Room Selector"
        Me.grpRooms.Visible = false
        '
        'gridRoomSelector
        '
        Me.gridRoomSelector.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridRoomSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRoomSelector.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridRoomSelector.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.gridRoomSelector.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.gridRoomSelector.Location = New System.Drawing.Point(2, 45)
        Me.gridRoomSelector.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.gridRoomSelector.MainView = Me.gridViewRoomSelector
        Me.gridRoomSelector.MenuManager = Me.BarManager
        Me.gridRoomSelector.Name = "gridRoomSelector"
        Me.gridRoomSelector.Size = New System.Drawing.Size(489, 258)
        Me.gridRoomSelector.TabIndex = 1
        Me.gridRoomSelector.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewRoomSelector})
        '
        'gridViewRoomSelector
        '
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.gridViewRoomSelector.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.gridViewRoomSelector.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.gridViewRoomSelector.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.gridViewRoomSelector.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.gridViewRoomSelector.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Me.gridViewRoomSelector.GridControl = Me.gridRoomSelector
        Me.gridViewRoomSelector.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        Me.gridViewRoomSelector.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        Me.gridViewRoomSelector.Name = "gridViewRoomSelector"
        Me.gridViewRoomSelector.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridViewRoomSelector.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[Default]
        Me.gridViewRoomSelector.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll
        Me.gridViewRoomSelector.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.[Default]
        Me.gridViewRoomSelector.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.[Default]
        Me.gridViewRoomSelector.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        Me.gridViewRoomSelector.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.[Default]
        Me.gridViewRoomSelector.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.[Default]
        Me.gridViewRoomSelector.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.[Default]
        Me.gridViewRoomSelector.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Me.gridViewRoomSelector.OptionsView.ShowAutoFilterRow = true
        Me.gridViewRoomSelector.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.[Default]
        Me.gridViewRoomSelector.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell
        Me.gridViewRoomSelector.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'grpPassword
        '
        Me.grpPassword.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.grpPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grpPassword.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.grpPassword.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.grpPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.grpPassword.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.grpPassword.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.grpPassword.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grpPassword.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.grpPassword.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.grpPassword.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.grpPassword.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.grpPassword.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.grpPassword.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.grpPassword.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.grpPassword.Controls.Add(Me.picPasswordConfirmValidate)
        Me.grpPassword.Controls.Add(Me.picPasswordValidate)
        Me.grpPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.lblConfirmPassword)
        Me.grpPassword.Controls.Add(Me.lblNewPassword)
        Me.grpPassword.Controls.Add(Me.btnPasswordChange)
        Me.grpPassword.Controls.Add(Me.btnCancelPassword)
        Me.grpPassword.Controls.Add(Me.picChangePassword)
        Me.grpPassword.Location = New System.Drawing.Point(226, 197)
        Me.grpPassword.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(287, 147)
        Me.grpPassword.TabIndex = 17
        Me.grpPassword.Text = "Change Password (Minimum length: 6 characters)"
        Me.grpPassword.Visible = false
        '
        'picPasswordConfirmValidate
        '
        Me.picPasswordConfirmValidate.Image = CType(resources.GetObject("picPasswordConfirmValidate.Image"),System.Drawing.Image)
        Me.picPasswordConfirmValidate.Location = New System.Drawing.Point(266, 92)
        Me.picPasswordConfirmValidate.Name = "picPasswordConfirmValidate"
        Me.picPasswordConfirmValidate.Size = New System.Drawing.Size(16, 16)
        Me.picPasswordConfirmValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPasswordConfirmValidate.TabIndex = 5
        Me.picPasswordConfirmValidate.TabStop = false
        '
        'picPasswordValidate
        '
        Me.picPasswordValidate.Image = CType(resources.GetObject("picPasswordValidate.Image"),System.Drawing.Image)
        Me.picPasswordValidate.Location = New System.Drawing.Point(266, 47)
        Me.picPasswordValidate.Name = "picPasswordValidate"
        Me.picPasswordValidate.Size = New System.Drawing.Size(16, 16)
        Me.picPasswordValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPasswordValidate.TabIndex = 5
        Me.picPasswordValidate.TabStop = false
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtConfirmPassword.Location = New System.Drawing.Point(75, 89)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtConfirmPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtConfirmPassword.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtConfirmPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtConfirmPassword.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtConfirmPassword.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtConfirmPassword.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtConfirmPassword.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtConfirmPassword.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtConfirmPassword.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtConfirmPassword.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtConfirmPassword.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtConfirmPassword.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtConfirmPassword.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtConfirmPassword.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtConfirmPassword.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtConfirmPassword.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtConfirmPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtConfirmPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConfirmPassword.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtConfirmPassword.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtConfirmPassword.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtConfirmPassword.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtConfirmPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtConfirmPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(186, 20)
        Me.txtConfirmPassword.TabIndex = 2
        Me.txtConfirmPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtNewPassword
        '
        Me.txtNewPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNewPassword.Location = New System.Drawing.Point(75, 44)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtNewPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNewPassword.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNewPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNewPassword.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNewPassword.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNewPassword.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNewPassword.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNewPassword.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNewPassword.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNewPassword.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNewPassword.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNewPassword.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNewPassword.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNewPassword.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNewPassword.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNewPassword.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNewPassword.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNewPassword.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNewPassword.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNewPassword.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtNewPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNewPassword.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNewPassword.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtNewPassword.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtNewPassword.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtNewPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNewPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(186, 20)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblConfirmPassword.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblConfirmPassword.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblConfirmPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblConfirmPassword.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblConfirmPassword.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblConfirmPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblConfirmPassword.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblConfirmPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblConfirmPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblConfirmPassword.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblConfirmPassword.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblConfirmPassword.Location = New System.Drawing.Point(75, 70)
        Me.lblConfirmPassword.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(90, 13)
        Me.lblConfirmPassword.TabIndex = 2
        Me.lblConfirmPassword.Text = "Confirm Password:"
        Me.lblConfirmPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblNewPassword.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblNewPassword.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNewPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblNewPassword.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblNewPassword.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblNewPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblNewPassword.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblNewPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblNewPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblNewPassword.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblNewPassword.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblNewPassword.Location = New System.Drawing.Point(75, 25)
        Me.lblNewPassword.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(74, 13)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "New Password:"
        Me.lblNewPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnPasswordChange
        '
        Me.btnPasswordChange.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnPasswordChange.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnPasswordChange.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnPasswordChange.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnPasswordChange.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnPasswordChange.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnPasswordChange.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnPasswordChange.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnPasswordChange.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPasswordChange.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnPasswordChange.Location = New System.Drawing.Point(75, 115)
        Me.btnPasswordChange.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnPasswordChange.Name = "btnPasswordChange"
        Me.btnPasswordChange.Size = New System.Drawing.Size(186, 23)
        Me.btnPasswordChange.TabIndex = 3
        Me.btnPasswordChange.Text = "Change Password"
        Me.btnPasswordChange.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnCancelPassword
        '
        Me.btnCancelPassword.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnCancelPassword.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnCancelPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnCancelPassword.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnCancelPassword.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnCancelPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnCancelPassword.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCancelPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnCancelPassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelPassword.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnCancelPassword.Location = New System.Drawing.Point(5, 115)
        Me.btnCancelPassword.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnCancelPassword.Name = "btnCancelPassword"
        Me.btnCancelPassword.Size = New System.Drawing.Size(64, 23)
        Me.btnCancelPassword.TabIndex = 4
        Me.btnCancelPassword.Text = "Cancel"
        Me.btnCancelPassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'picChangePassword
        '
        Me.picChangePassword.Image = Global.Inventory.My.Resources.Resources.Login_64
        Me.picChangePassword.Location = New System.Drawing.Point(5, 35)
        Me.picChangePassword.Name = "picChangePassword"
        Me.picChangePassword.Size = New System.Drawing.Size(64, 64)
        Me.picChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChangePassword.TabIndex = 0
        Me.picChangePassword.TabStop = false
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CausesValidation = false
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(890, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(292, 622)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(292, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(92, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = false
        '
        'RoomsCollectionBinding
        '
        Me.RoomsCollectionBinding.DataSource = GetType(InventoryData.BusinessObjects.RoomCollection)
        '
        'frmUsers
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 654)
        Me.Controls.Add(Me.dockUsers)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmUsers"
        Me.Text = "User Manager"
        CType(Me.navbarUsers,System.ComponentModel.ISupportInitialize).EndInit
        Me.navbarUsers.ResumeLayout(false)
        Me.NavBarGroupControlContainer10.ResumeLayout(false)
        Me.NavBarGroupControlContainer10.PerformLayout
        CType(Me.txtUserLastName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UserBinding,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtUserFirstName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.NavBarGroupControlContainer11.ResumeLayout(false)
        Me.NavBarGroupControlContainer11.PerformLayout
        CType(Me.cboUserAccount.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtUserUserName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.NavBarGroupControlContainer12.ResumeLayout(false)
        Me.NavBarGroupControlContainer12.PerformLayout
        CType(Me.txtUserID.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.NavBarGroupControlContainer1.ResumeLayout(false)
        CType(Me.gridRooms,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridViewRooms,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RoomBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridUsers,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridViewUsers,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UsersCollectionBinding,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dockUsers,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolWindow1.ResumeLayout(false)
        CType(Me.DocumentContainer1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DocumentTabStrip1,System.ComponentModel.ISupportInitialize).EndInit
        Me.docUsers.ResumeLayout(false)
        CType(Me.grpRooms,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpRooms.ResumeLayout(false)
        CType(Me.gridRoomSelector,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridViewRoomSelector,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpPassword,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpPassword.ResumeLayout(false)
        Me.grpPassword.PerformLayout
        CType(Me.picPasswordConfirmValidate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picPasswordValidate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtConfirmPassword.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNewPassword.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picChangePassword,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ToolTabStrip1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RoomsCollectionBinding,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents navbarUsers As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navUserBasics As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer10 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtUserLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUserLastName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUserFirstName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavBarGroupControlContainer11 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents cboUserAccount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboUserType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUserPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUserUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavBarGroupControlContainer12 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txtUserID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUserID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents navUserLogin As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navUserAdvanced As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents gridUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewUsers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UsersCollectionBinding As System.Windows.Forms.BindingSource
    Friend WithEvents UserBinding As System.Windows.Forms.BindingSource
    Friend WithEvents grpPassword As DevExpress.XtraEditors.GroupControl
    Friend WithEvents picPasswordConfirmValidate As System.Windows.Forms.PictureBox
    Friend WithEvents picPasswordValidate As System.Windows.Forms.PictureBox
    Friend WithEvents txtConfirmPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNewPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblConfirmPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNewPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPasswordChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelPassword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picChangePassword As System.Windows.Forms.PictureBox
    Friend WithEvents RoomsCollectionBinding As System.Windows.Forms.BindingSource
    Private WithEvents dockUsers As Telerik.WinControls.UI.Docking.RadDock
    Private WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Private WithEvents docUsers As Telerik.WinControls.UI.Docking.DocumentWindow
    Private WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents navUserRooms As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents StandaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnRoomAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRoomsDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRoomDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpRooms As DevExpress.XtraEditors.GroupControl
    Friend WithEvents barDockRoomSelector As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents btnAddSelectedRooms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelRoomSelector As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barRoomSelector As DevExpress.XtraBars.Bar
    Friend WithEvents gridRoomSelector As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewRoomSelector As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridRooms As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewRooms As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRoomNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuilding As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoomFullName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Private WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents colVisible As DevExpress.XtraGrid.Columns.GridColumn
End Class
