<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockCategoryAdd
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        txbxCategory = New Guna.UI2.WinForms.Guna2TextBox()
        lblCategoryName = New Label()
        btAddCat = New Guna.UI2.WinForms.Guna2Button()
        PrintDocument1 = New Printing.PrintDocument()
        dgvCatList = New Guna.UI2.WinForms.Guna2DataGridView()
        btRemove = New Guna.UI2.WinForms.Guna2Button()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgvCatList, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxCategory
        ' 
        txbxCategory.CustomizableEdges = CustomizableEdges1
        txbxCategory.DefaultText = ""
        txbxCategory.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxCategory.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxCategory.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxCategory.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxCategory.Font = New Font("Segoe UI", 9F)
        txbxCategory.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxCategory.Location = New Point(87, 21)
        txbxCategory.Name = "txbxCategory"
        txbxCategory.PasswordChar = ChrW(0)
        txbxCategory.PlaceholderText = ""
        txbxCategory.SelectedText = ""
        txbxCategory.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxCategory.Size = New Size(200, 36)
        txbxCategory.TabIndex = 0
        ' 
        ' lblCategoryName
        ' 
        lblCategoryName.AutoSize = True
        lblCategoryName.Location = New Point(40, 21)
        lblCategoryName.Name = "lblCategoryName"
        lblCategoryName.Size = New Size(42, 15)
        lblCategoryName.TabIndex = 1
        lblCategoryName.Text = "Name:"
        ' 
        ' btAddCat
        ' 
        btAddCat.CustomizableEdges = CustomizableEdges3
        btAddCat.DisabledState.BorderColor = Color.DarkGray
        btAddCat.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCat.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCat.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCat.FillColor = Color.DimGray
        btAddCat.Font = New Font("Segoe UI", 9F)
        btAddCat.ForeColor = Color.White
        btAddCat.Location = New Point(196, 261)
        btAddCat.Name = "btAddCat"
        btAddCat.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddCat.Size = New Size(121, 36)
        btAddCat.TabIndex = 3
        btAddCat.Text = "Add"
        ' 
        ' dgvCatList
        ' 
        dgvCatList.AllowUserToAddRows = False
        dgvCatList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvCatList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCatList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCatList.ColumnHeadersHeight = 4
        dgvCatList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCatList.DefaultCellStyle = DataGridViewCellStyle3
        dgvCatList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatList.Location = New Point(40, 86)
        dgvCatList.Name = "dgvCatList"
        dgvCatList.ReadOnly = True
        dgvCatList.RowHeadersVisible = False
        dgvCatList.Size = New Size(120, 150)
        dgvCatList.TabIndex = 4
        dgvCatList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvCatList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvCatList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvCatList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvCatList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvCatList.ThemeStyle.BackColor = Color.White
        dgvCatList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvCatList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCatList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvCatList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvCatList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvCatList.ThemeStyle.HeaderStyle.Height = 4
        dgvCatList.ThemeStyle.ReadOnly = True
        dgvCatList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvCatList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvCatList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvCatList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvCatList.ThemeStyle.RowsStyle.Height = 25
        dgvCatList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btRemove
        ' 
        btRemove.CustomizableEdges = CustomizableEdges5
        btRemove.DisabledState.BorderColor = Color.DarkGray
        btRemove.DisabledState.CustomBorderColor = Color.DarkGray
        btRemove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btRemove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btRemove.FillColor = Color.DimGray
        btRemove.Font = New Font("Segoe UI", 9F)
        btRemove.ForeColor = Color.White
        btRemove.Location = New Point(39, 261)
        btRemove.Name = "btRemove"
        btRemove.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btRemove.Size = New Size(121, 36)
        btRemove.TabIndex = 5
        btRemove.Text = "Remove"
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Location = New Point(293, 38)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(119, 19)
        Guna2CheckBox1.TabIndex = 6
        Guna2CheckBox1.Text = "Guna2CheckBox1"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(193, 86)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.ReadOnly = True
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.Size = New Size(219, 150)
        Guna2DataGridView1.TabIndex = 7
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' StockCategoryAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 323)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(btRemove)
        Controls.Add(dgvCatList)
        Controls.Add(btAddCat)
        Controls.Add(lblCategoryName)
        Controls.Add(txbxCategory)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "StockCategoryAdd"
        ShowIcon = False
        Text = "Category"
        TopMost = True
        CType(dgvCatList, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents txbxCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents btAddCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dgvCatList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
