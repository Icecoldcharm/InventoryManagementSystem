<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.groupLoginFailed = New DevExpress.XtraEditors.GroupControl()
        Me.lblLoginFail = New DevExpress.XtraEditors.LabelControl()
        Me.lblLoginFailed = New DevExpress.XtraEditors.LabelControl()
        Me.groupLogin = New DevExpress.XtraEditors.GroupControl()
        Me.btnLoginOK = New DevExpress.XtraEditors.SimpleButton()
        Me.picLogin1 = New System.Windows.Forms.PictureBox()
        Me.lblLoginUser = New DevExpress.XtraEditors.LabelControl()
        Me.lblLoginPassword = New DevExpress.XtraEditors.LabelControl()
        Me.txtLoginPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtLoginUser = New DevExpress.XtraEditors.TextEdit()
        Me.groupLogout = New DevExpress.XtraEditors.GroupControl()
        Me.lblLogoutUser = New DevExpress.XtraEditors.LabelControl()
        Me.lblLogout1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnLogout = New DevExpress.XtraEditors.SimpleButton()
        Me.picLogin2 = New System.Windows.Forms.PictureBox()
        Me.pnlLoginHelp = New DevExpress.XtraEditors.PanelControl()
        Me.lblLoginHelp = New DevExpress.XtraEditors.LabelControl()
        CType(Me.groupLoginFailed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupLoginFailed.SuspendLayout()
        CType(Me.groupLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupLogin.SuspendLayout()
        CType(Me.picLogin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoginPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoginUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupLogout.SuspendLayout()
        CType(Me.picLogin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLoginHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupLoginFailed
        '
        Me.groupLoginFailed.Appearance.BackColor = System.Drawing.Color.White
        Me.groupLoginFailed.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.groupLoginFailed.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.groupLoginFailed.Appearance.Options.UseBackColor = True
        Me.groupLoginFailed.Controls.Add(Me.lblLoginFail)
        Me.groupLoginFailed.Controls.Add(Me.lblLoginFailed)
        Me.groupLoginFailed.Location = New System.Drawing.Point(287, 239)
        Me.groupLoginFailed.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.groupLoginFailed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.groupLoginFailed.Name = "groupLoginFailed"
        Me.groupLoginFailed.ShowCaption = False
        Me.groupLoginFailed.Size = New System.Drawing.Size(269, 100)
        Me.groupLoginFailed.TabIndex = 11
        Me.groupLoginFailed.Text = "Failed Login"
        Me.groupLoginFailed.Visible = False
        '
        'lblLoginFail
        '
        Me.lblLoginFail.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginFail.Location = New System.Drawing.Point(5, 6)
        Me.lblLoginFail.Name = "lblLoginFail"
        Me.lblLoginFail.Size = New System.Drawing.Size(121, 18)
        Me.lblLoginFail.TabIndex = 0
        Me.lblLoginFail.Text = "Unable to Login:"
        '
        'lblLoginFailed
        '
        Me.lblLoginFailed.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginFailed.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblLoginFailed.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblLoginFailed.Location = New System.Drawing.Point(5, 30)
        Me.lblLoginFailed.Name = "lblLoginFailed"
        Me.lblLoginFailed.Size = New System.Drawing.Size(258, 64)
        Me.lblLoginFailed.TabIndex = 0
        Me.lblLoginFailed.Text = "Invalid user name or password. Please re-enter your login information."
        '
        'groupLogin
        '
        Me.groupLogin.Controls.Add(Me.pnlLoginHelp)
        Me.groupLogin.Controls.Add(Me.btnLoginOK)
        Me.groupLogin.Controls.Add(Me.picLogin1)
        Me.groupLogin.Controls.Add(Me.lblLoginUser)
        Me.groupLogin.Controls.Add(Me.lblLoginPassword)
        Me.groupLogin.Controls.Add(Me.txtLoginPassword)
        Me.groupLogin.Controls.Add(Me.txtLoginUser)
        Me.groupLogin.Location = New System.Drawing.Point(287, 12)
        Me.groupLogin.Name = "groupLogin"
        Me.groupLogin.Size = New System.Drawing.Size(269, 221)
        Me.groupLogin.TabIndex = 9
        Me.groupLogin.Text = "Login"
        '
        'btnLoginOK
        '
        Me.btnLoginOK.Location = New System.Drawing.Point(5, 183)
        Me.btnLoginOK.Name = "btnLoginOK"
        Me.btnLoginOK.Size = New System.Drawing.Size(259, 32)
        Me.btnLoginOK.TabIndex = 2
        Me.btnLoginOK.Text = "Login"
        '
        'picLogin1
        '
        Me.picLogin1.BackColor = System.Drawing.Color.Transparent
        Me.picLogin1.Image = Global.Inventory.My.Resources.Resources.people
        Me.picLogin1.Location = New System.Drawing.Point(5, 83)
        Me.picLogin1.Name = "picLogin1"
        Me.picLogin1.Size = New System.Drawing.Size(96, 96)
        Me.picLogin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin1.TabIndex = 0
        Me.picLogin1.TabStop = False
        '
        'lblLoginUser
        '
        Me.lblLoginUser.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginUser.Location = New System.Drawing.Point(112, 83)
        Me.lblLoginUser.Name = "lblLoginUser"
        Me.lblLoginUser.Size = New System.Drawing.Size(31, 16)
        Me.lblLoginUser.TabIndex = 1
        Me.lblLoginUser.Text = "User:"
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(112, 138)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(60, 16)
        Me.lblLoginPassword.TabIndex = 2
        Me.lblLoginPassword.Text = "Password:"
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(112, 157)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtLoginPassword.TabIndex = 1
        '
        'txtLoginUser
        '
        Me.txtLoginUser.Location = New System.Drawing.Point(112, 105)
        Me.txtLoginUser.Name = "txtLoginUser"
        Me.txtLoginUser.Size = New System.Drawing.Size(152, 20)
        Me.txtLoginUser.TabIndex = 0
        '
        'groupLogout
        '
        Me.groupLogout.Controls.Add(Me.lblLogoutUser)
        Me.groupLogout.Controls.Add(Me.lblLogout1)
        Me.groupLogout.Controls.Add(Me.btnLogout)
        Me.groupLogout.Controls.Add(Me.picLogin2)
        Me.groupLogout.Location = New System.Drawing.Point(12, 12)
        Me.groupLogout.Name = "groupLogout"
        Me.groupLogout.Size = New System.Drawing.Size(269, 166)
        Me.groupLogout.TabIndex = 10
        Me.groupLogout.Text = "Current User"
        '
        'lblLogoutUser
        '
        Me.lblLogoutUser.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoutUser.Location = New System.Drawing.Point(107, 54)
        Me.lblLogoutUser.Name = "lblLogoutUser"
        Me.lblLogoutUser.Size = New System.Drawing.Size(50, 13)
        Me.lblLogoutUser.TabIndex = 4
        Me.lblLogoutUser.Text = "< User >"
        '
        'lblLogout1
        '
        Me.lblLogout1.Location = New System.Drawing.Point(107, 28)
        Me.lblLogout1.Name = "lblLogout1"
        Me.lblLogout1.Size = New System.Drawing.Size(66, 13)
        Me.lblLogout1.TabIndex = 3
        Me.lblLogout1.Text = "Current User:"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(5, 125)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(259, 32)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Log Out"
        '
        'picLogin2
        '
        Me.picLogin2.BackColor = System.Drawing.Color.Transparent
        Me.picLogin2.Image = Global.Inventory.My.Resources.Resources.people
        Me.picLogin2.Location = New System.Drawing.Point(5, 25)
        Me.picLogin2.Name = "picLogin2"
        Me.picLogin2.Size = New System.Drawing.Size(96, 96)
        Me.picLogin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogin2.TabIndex = 0
        Me.picLogin2.TabStop = False
        '
        'pnlLoginHelp
        '
        Me.pnlLoginHelp.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.pnlLoginHelp.Appearance.Options.UseBackColor = True
        Me.pnlLoginHelp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlLoginHelp.Controls.Add(Me.lblLoginHelp)
        Me.pnlLoginHelp.Location = New System.Drawing.Point(5, 25)
        Me.pnlLoginHelp.Name = "pnlLoginHelp"
        Me.pnlLoginHelp.Size = New System.Drawing.Size(259, 52)
        Me.pnlLoginHelp.TabIndex = 12
        '
        'lblLoginHelp
        '
        Me.lblLoginHelp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginHelp.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblLoginHelp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblLoginHelp.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblLoginHelp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblLoginHelp.Location = New System.Drawing.Point(3, 3)
        Me.lblLoginHelp.Name = "lblLoginHelp"
        Me.lblLoginHelp.Size = New System.Drawing.Size(253, 46)
        Me.lblLoginHelp.TabIndex = 12
        Me.lblLoginHelp.Text = "Use the same username and password that you use to login to your computer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 538)
        Me.Controls.Add(Me.groupLoginFailed)
        Me.Controls.Add(Me.groupLogin)
        Me.Controls.Add(Me.groupLogout)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.groupLoginFailed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupLoginFailed.ResumeLayout(False)
        Me.groupLoginFailed.PerformLayout()
        CType(Me.groupLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupLogin.ResumeLayout(False)
        Me.groupLogin.PerformLayout()
        CType(Me.picLogin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoginPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoginUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupLogout.ResumeLayout(False)
        Me.groupLogout.PerformLayout()
        CType(Me.picLogin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLoginHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginHelp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupLoginFailed As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblLoginFail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoginFailed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents groupLogin As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLoginOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picLogin1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoginUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoginPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLoginPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLoginUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents groupLogout As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblLogoutUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLogout1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLogout As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picLogin2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlLoginHelp As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblLoginHelp As DevExpress.XtraEditors.LabelControl
End Class
