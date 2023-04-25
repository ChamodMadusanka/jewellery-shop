<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Passwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.BackgroundImage = Global.jewellery_shop.My.Resources.Resources.OFP6901ff
        Me.Guna2Panel1.Controls.Add(Me.CloseBtn)
        Me.Guna2Panel1.Controls.Add(Me.LoginBtn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.Passwd)
        Me.Guna2Panel1.Controls.Add(Me.UserName)
        Me.Guna2Panel1.Location = New System.Drawing.Point(543, -3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(406, 590)
        Me.Guna2Panel1.TabIndex = 0
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = Global.jewellery_shop.My.Resources.Resources.cancel1
        Me.CloseBtn.ImageRotate = 0!
        Me.CloseBtn.Location = New System.Drawing.Point(357, 3)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(52, 48)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.TabStop = False
        Me.CloseBtn.UseTransparentBackground = True
        '
        'LoginBtn
        '
        Me.LoginBtn.BorderRadius = 20
        Me.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(91, 427)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(163, 57)
        Me.LoginBtn.TabIndex = 5
        Me.LoginBtn.Text = "Login"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.jewellery_shop.My.Resources.Resources._11367__Converted_2
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(81, 44)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(173, 161)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 2
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Passwd
        '
        Me.Passwd.Animated = True
        Me.Passwd.BackColor = System.Drawing.Color.Transparent
        Me.Passwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Passwd.BorderRadius = 8
        Me.Passwd.BorderThickness = 2
        Me.Passwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Passwd.DefaultText = ""
        Me.Passwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Passwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Passwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Passwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Passwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passwd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Passwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passwd.IconRight = Global.jewellery_shop.My.Resources.Resources.pngfind_com_password_icon_png_2021854
        Me.Passwd.Location = New System.Drawing.Point(31, 335)
        Me.Passwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Passwd.Name = "Passwd"
        Me.Passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Passwd.PlaceholderText = "Password"
        Me.Passwd.SelectedText = ""
        Me.Passwd.Size = New System.Drawing.Size(267, 44)
        Me.Passwd.TabIndex = 4
        '
        'UserName
        '
        Me.UserName.Animated = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.UserName.BorderRadius = 8
        Me.UserName.BorderThickness = 2
        Me.UserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserName.DefaultText = ""
        Me.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.IconRight = Global.jewellery_shop.My.Resources.Resources.login_icon_3048
        Me.UserName.Location = New System.Drawing.Point(31, 241)
        Me.UserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserName.Name = "UserName"
        Me.UserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserName.PlaceholderText = "Username"
        Me.UserName.SelectedText = ""
        Me.UserName.Size = New System.Drawing.Size(267, 44)
        Me.UserName.TabIndex = 3
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.jewellery_shop.My.Resources.Resources._2002_i402_054__Jewelry_flat_4x4__Converted_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 81)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(509, 460)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.jewellery_shop.My.Resources.Resources.OFP6900
        Me.ClientSize = New System.Drawing.Size(951, 523)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Passwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2PictureBox
End Class
