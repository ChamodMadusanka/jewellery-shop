<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashbord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BillBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CustomerBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ProductsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 130)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(460, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Asiri Jewellery"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.jewellery_shop.My.Resources.Resources.icons8_go_back_481
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 516)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(300, 81)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "LogOut"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jewellery_shop.My.Resources.Resources._11367__Converted_
        Me.PictureBox1.Location = New System.Drawing.Point(507, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(646, 472)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BillBtn
        '
        Me.BillBtn.BorderRadius = 20
        Me.BillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BillBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BillBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.BillBtn.ForeColor = System.Drawing.Color.White
        Me.BillBtn.Image = Global.jewellery_shop.My.Resources.Resources.budget
        Me.BillBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BillBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.BillBtn.Location = New System.Drawing.Point(12, 403)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(300, 81)
        Me.BillBtn.TabIndex = 2
        Me.BillBtn.Text = "Billing"
        '
        'CustomerBtn
        '
        Me.CustomerBtn.BorderRadius = 20
        Me.CustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CustomerBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.CustomerBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.CustomerBtn.ForeColor = System.Drawing.Color.White
        Me.CustomerBtn.Image = Global.jewellery_shop.My.Resources.Resources.watch_salon_04__Converted_
        Me.CustomerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CustomerBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.CustomerBtn.Location = New System.Drawing.Point(12, 296)
        Me.CustomerBtn.Name = "CustomerBtn"
        Me.CustomerBtn.Size = New System.Drawing.Size(300, 81)
        Me.CustomerBtn.TabIndex = 1
        Me.CustomerBtn.Text = "Customers"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = Global.jewellery_shop.My.Resources.Resources.cancel1
        Me.CloseBtn.ImageRotate = 0!
        Me.CloseBtn.Location = New System.Drawing.Point(1158, 3)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(52, 48)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBtn.TabIndex = 7
        Me.CloseBtn.TabStop = False
        Me.CloseBtn.UseTransparentBackground = True
        '
        'ProductsBtn
        '
        Me.ProductsBtn.BorderRadius = 20
        Me.ProductsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ProductsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ProductsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ProductsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ProductsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ProductsBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.ProductsBtn.ForeColor = System.Drawing.Color.White
        Me.ProductsBtn.Image = Global.jewellery_shop.My.Resources.Resources._19470__Converted_
        Me.ProductsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ProductsBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.ProductsBtn.Location = New System.Drawing.Point(12, 180)
        Me.ProductsBtn.Name = "ProductsBtn"
        Me.ProductsBtn.Size = New System.Drawing.Size(300, 81)
        Me.ProductsBtn.TabIndex = 0
        Me.ProductsBtn.Text = "products"
        '
        'Dashbord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 650)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BillBtn)
        Me.Controls.Add(Me.CustomerBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProductsBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashbord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashbord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BillBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
