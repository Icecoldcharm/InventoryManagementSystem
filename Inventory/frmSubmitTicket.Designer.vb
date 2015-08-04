<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmitTicket
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
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'browser
        '
        Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser.IsWebBrowserContextMenuEnabled = False
        Me.browser.Location = New System.Drawing.Point(0, 0)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(446, 399)
        Me.browser.TabIndex = 0
        Me.browser.Url = New System.Uri("http://techsupport/open.php", System.UriKind.Absolute)
        '
        'frmSubmitTicket
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 399)
        Me.Controls.Add(Me.browser)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmSubmitTicket"
        Me.Text = "Submit a Ticket"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
End Class
