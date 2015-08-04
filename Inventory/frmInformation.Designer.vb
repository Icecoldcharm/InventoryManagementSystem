<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformation
    Inherits Telerik.WinControls.UI.ShapedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RoundRectShapeForm = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RadTitleBar = New Telerik.WinControls.UI.RadTitleBar()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.txtMessage = New DevExpress.XtraRichEdit.RichEditControl()
        CType(Me.RadTitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundRectShapeTitle
        '
        Me.RoundRectShapeTitle.BottomLeftRounded = False
        Me.RoundRectShapeTitle.BottomRightRounded = False
        '
        'RadTitleBar
        '
        Me.RadTitleBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTitleBar.Text = "Information"
        Me.RadTitleBar.Location = New System.Drawing.Point(1, 1)
        Me.RadTitleBar.Name = "RadTitleBar"
        '
        '
        '
        Me.RadTitleBar.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar.RootElement.Shape = Me.RoundRectShapeTitle
        Me.RadTitleBar.Size = New System.Drawing.Size(337, 23)
        Me.RadTitleBar.TabIndex = 0
        Me.RadTitleBar.TabStop = False
        Me.RadTitleBar.Text = "FrmInformation"
        '
        'lblTitle
        '
        Me.lblTitle.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblTitle.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseTextOptions = True
        Me.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTitle.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblTitle.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblTitle.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblTitle.Location = New System.Drawing.Point(12, 30)
        Me.lblTitle.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 28)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "< Title >"
        Me.lblTitle.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtMessage
        '
        Me.txtMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
        Me.txtMessage.Appearance.Text.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtMessage.Appearance.Text.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtMessage.Appearance.Text.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtMessage.Appearance.Text.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtMessage.Appearance.Text.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtMessage.Appearance.Text.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtMessage.DragDropMode = DevExpress.XtraRichEdit.DragDropMode.Standard
        Me.txtMessage.Location = New System.Drawing.Point(12, 64)
        Me.txtMessage.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Options.Behavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Behavior.Cut = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Behavior.Drag = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Behavior.Drop = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Behavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.[Auto]
        Me.txtMessage.Options.Behavior.ForeColorSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.[Auto]
        Me.txtMessage.Options.Behavior.Paste = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Bookmarks.Visibility = DevExpress.XtraRichEdit.RichEditBookmarkVisibility.[Auto]
        Me.txtMessage.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.CharacterFormatting = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.CharacterStyle = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Hyperlinks = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.InlinePictures = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Numbering.Bulleted = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Numbering.MultiLevel = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Numbering.Simple = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.ParagraphFormatting = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Paragraphs = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.ParagraphStyle = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.ParagraphTabs = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Tables = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.TabSymbol = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.DocumentCapabilities.Undo = DevExpress.XtraRichEdit.DocumentCapability.[Default]
        Me.txtMessage.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.[Auto]
        Me.txtMessage.Options.FormattingMarkVisibility.HiddenText = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.[Auto]
        Me.txtMessage.Options.FormattingMarkVisibility.ParagraphMark = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.[Auto]
        Me.txtMessage.Options.FormattingMarkVisibility.Space = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.[Auto]
        Me.txtMessage.Options.FormattingMarkVisibility.TabCharacter = DevExpress.XtraRichEdit.RichEditFormattingMarkVisibility.[Auto]
        Me.txtMessage.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.[Auto]
        Me.txtMessage.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.[Auto]
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(315, 93)
        Me.txtMessage.TabIndex = 2
        Me.txtMessage.Text = "No Message"
        Me.txtMessage.Unit = DevExpress.XtraRichEdit.DocumentUnit.Document
        '
        'FrmInformation
        '
        Me.AllowResize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(339, 169)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.RadTitleBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInformation"
        Me.Shape = Me.RoundRectShapeForm
        Me.Text = "FrmInformation"
        CType(Me.RadTitleBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RoundRectShapeForm As Telerik.WinControls.RoundRectShape
    Friend WithEvents RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents RadTitleBar As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMessage As DevExpress.XtraRichEdit.RichEditControl
End Class

