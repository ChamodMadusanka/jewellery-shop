<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProductDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CustomerDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Print = New Guna.UI2.WinForms.Guna2Button()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddBill = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BillDVG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.productsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.customerBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BillingBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BillDVG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Print)
        Me.Panel1.Controls.Add(Me.totalLbl)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BillDVG)
        Me.Panel1.Controls.Add(Me.productsBtn)
        Me.Panel1.Controls.Add(Me.customerBtn)
        Me.Panel1.Controls.Add(Me.BillingBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 762)
        Me.Panel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ProductDGV)
        Me.Panel4.Controls.Add(Me.CustomerDGV)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(370, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(940, 238)
        Me.Panel4.TabIndex = 73
        '
        'ProductDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ProductDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDGV.ColumnHeadersHeight = 4
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductDGV.Location = New System.Drawing.Point(505, 44)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.RowHeadersVisible = False
        Me.ProductDGV.RowHeadersWidth = 51
        Me.ProductDGV.RowTemplate.Height = 24
        Me.ProductDGV.Size = New System.Drawing.Size(382, 137)
        Me.ProductDGV.TabIndex = 74
        Me.ProductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ProductDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ProductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ProductDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ProductDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProductDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ProductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ProductDGV.ThemeStyle.HeaderStyle.Height = 4
        Me.ProductDGV.ThemeStyle.ReadOnly = False
        Me.ProductDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ProductDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ProductDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ProductDGV.ThemeStyle.RowsStyle.Height = 24
        Me.ProductDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'CustomerDGV
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.CustomerDGV.ColumnHeadersHeight = 4
        Me.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.CustomerDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDGV.Location = New System.Drawing.Point(95, 45)
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.RowHeadersVisible = False
        Me.CustomerDGV.RowHeadersWidth = 51
        Me.CustomerDGV.RowTemplate.Height = 24
        Me.CustomerDGV.Size = New System.Drawing.Size(365, 136)
        Me.CustomerDGV.TabIndex = 73
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CustomerDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomerDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CustomerDGV.ThemeStyle.HeaderStyle.Height = 4
        Me.CustomerDGV.ThemeStyle.ReadOnly = False
        Me.CustomerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.RowsStyle.Height = 24
        Me.CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(651, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 33)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Products List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(158, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 33)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Customer Name"
        '
        'Print
        '
        Me.Print.BorderRadius = 20
        Me.Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Print.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Print.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Print.ForeColor = System.Drawing.Color.White
        Me.Print.Location = New System.Drawing.Point(901, 449)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(163, 57)
        Me.Print.TabIndex = 68
        Me.Print.Text = "Print"
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.totalLbl.Location = New System.Drawing.Point(1131, 462)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(73, 33)
        Me.totalLbl.TabIndex = 68
        Me.totalLbl.Text = "Total"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Price)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CustName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Qty)
        Me.Panel3.Controls.Add(Me.AddBill)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ProductName)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(351, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(479, 285)
        Me.Panel3.TabIndex = 72
        '
        'Price
        '
        Me.Price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Price.DefaultText = ""
        Me.Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Price.Enabled = False
        Me.Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Price.Location = New System.Drawing.Point(311, 149)
        Me.Price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Price.Name = "Price"
        Me.Price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Price.PlaceholderText = ""
        Me.Price.SelectedText = ""
        Me.Price.Size = New System.Drawing.Size(153, 39)
        Me.Price.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(333, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 33)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Price"
        '
        'CustName
        '
        Me.CustName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustName.DefaultText = ""
        Me.CustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CustName.Enabled = False
        Me.CustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustName.Location = New System.Drawing.Point(19, 149)
        Me.CustName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustName.Name = "CustName"
        Me.CustName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CustName.PlaceholderText = ""
        Me.CustName.SelectedText = ""
        Me.CustName.Size = New System.Drawing.Size(229, 39)
        Me.CustName.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(44, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 33)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Customer Name"
        '
        'Qty
        '
        Me.Qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Qty.DefaultText = ""
        Me.Qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Qty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Qty.Location = New System.Drawing.Point(311, 38)
        Me.Qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Qty.Name = "Qty"
        Me.Qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Qty.PlaceholderText = ""
        Me.Qty.SelectedText = ""
        Me.Qty.Size = New System.Drawing.Size(153, 39)
        Me.Qty.TabIndex = 51
        '
        'AddBill
        '
        Me.AddBill.BorderRadius = 20
        Me.AddBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddBill.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.AddBill.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddBill.ForeColor = System.Drawing.Color.White
        Me.AddBill.Location = New System.Drawing.Point(157, 209)
        Me.AddBill.Name = "AddBill"
        Me.AddBill.Size = New System.Drawing.Size(163, 57)
        Me.AddBill.TabIndex = 67
        Me.AddBill.Text = "Add To Bill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(323, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 33)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Quantity"
        '
        'ProductName
        '
        Me.ProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProductName.DefaultText = ""
        Me.ProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProductName.Enabled = False
        Me.ProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProductName.Location = New System.Drawing.Point(15, 38)
        Me.ProductName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductName.Name = "ProductName"
        Me.ProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductName.PlaceholderText = ""
        Me.ProductName.SelectedText = ""
        Me.ProductName.Size = New System.Drawing.Size(229, 39)
        Me.ProductName.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(40, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 33)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1039, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 46)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Bills"
        '
        'BillDVG
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.BillDVG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDVG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BillDVG.ColumnHeadersHeight = 25
        Me.BillDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BillDVG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillDVG.DefaultCellStyle = DataGridViewCellStyle9
        Me.BillDVG.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BillDVG.Location = New System.Drawing.Point(901, 196)
        Me.BillDVG.Name = "BillDVG"
        Me.BillDVG.RowHeadersVisible = False
        Me.BillDVG.RowHeadersWidth = 51
        Me.BillDVG.RowTemplate.Height = 24
        Me.BillDVG.Size = New System.Drawing.Size(409, 236)
        Me.BillDVG.TabIndex = 61
        Me.BillDVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BillDVG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BillDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BillDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BillDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BillDVG.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BillDVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BillDVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BillDVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BillDVG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillDVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BillDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BillDVG.ThemeStyle.HeaderStyle.Height = 25
        Me.BillDVG.ThemeStyle.ReadOnly = False
        Me.BillDVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BillDVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BillDVG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillDVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BillDVG.ThemeStyle.RowsStyle.Height = 24
        Me.BillDVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BillDVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Products"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prices"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-6, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1404, 138)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(573, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Asiri Jewellery"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'productsBtn
        '
        Me.productsBtn.BorderRadius = 20
        Me.productsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.productsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.productsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.productsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.productsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.productsBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.productsBtn.ForeColor = System.Drawing.Color.White
        Me.productsBtn.Image = Global.jewellery_shop.My.Resources.Resources._19470__Converted_
        Me.productsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.productsBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.productsBtn.Location = New System.Drawing.Point(24, 176)
        Me.productsBtn.Name = "productsBtn"
        Me.productsBtn.Size = New System.Drawing.Size(300, 81)
        Me.productsBtn.TabIndex = 43
        Me.productsBtn.Text = "products"
        '
        'customerBtn
        '
        Me.customerBtn.BorderRadius = 20
        Me.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.customerBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.customerBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.customerBtn.ForeColor = System.Drawing.Color.White
        Me.customerBtn.Image = Global.jewellery_shop.My.Resources.Resources.watch_salon_04__Converted_
        Me.customerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.customerBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.customerBtn.Location = New System.Drawing.Point(24, 318)
        Me.customerBtn.Name = "customerBtn"
        Me.customerBtn.Size = New System.Drawing.Size(300, 81)
        Me.customerBtn.TabIndex = 44
        Me.customerBtn.Text = "Customers"
        '
        'BillingBtn
        '
        Me.BillingBtn.BorderRadius = 20
        Me.BillingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BillingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BillingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BillingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BillingBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BillingBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.BillingBtn.ForeColor = System.Drawing.Color.White
        Me.BillingBtn.Image = Global.jewellery_shop.My.Resources.Resources.budget
        Me.BillingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BillingBtn.ImageSize = New System.Drawing.Size(60, 60)
        Me.BillingBtn.Location = New System.Drawing.Point(24, 462)
        Me.BillingBtn.Name = "BillingBtn"
        Me.BillingBtn.Size = New System.Drawing.Size(300, 81)
        Me.BillingBtn.TabIndex = 45
        Me.BillingBtn.Text = "Billing"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.jewellery_shop.My.Resources.Resources.icons8_go_back_48
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(52, 48)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 76
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.jewellery_shop.My.Resources.Resources.cancel1
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(1320, 0)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(52, 48)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 75
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
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
        Me.Guna2Button1.Location = New System.Drawing.Point(24, 608)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(300, 81)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "LogOut"
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 762)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BillDVG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents AddBill As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BillDVG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents productsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents customerBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BillingBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents ProductName As Guna.UI2.WinForms.Guna2TextBox
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents Label3 As Label
    Friend WithEvents Qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CustName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalLbl As Label
    Friend WithEvents ProductDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CustomerDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
