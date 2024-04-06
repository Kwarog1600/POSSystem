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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        txbxCategory = New Guna.UI2.WinForms.Guna2TextBox()
        lblCategoryName = New Label()
        btAddCat = New Guna.UI2.WinForms.Guna2Button()
        PrintDocument1 = New Printing.PrintDocument()
        dgvCatList = New Guna.UI2.WinForms.Guna2DataGridView()
        btRemove = New Guna.UI2.WinForms.Guna2Button()
        cbxAddDescr = New Guna.UI2.WinForms.Guna2CheckBox()
        dgvAddDescr = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgvCatList, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxCategory
        ' 
        txbxCategory.CustomizableEdges = CustomizableEdges7
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
        txbxCategory.ShadowDecoration.CustomizableEdges = CustomizableEdges8
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
        btAddCat.CustomizableEdges = CustomizableEdges9
        btAddCat.DisabledState.BorderColor = Color.DarkGray
        btAddCat.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCat.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCat.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCat.FillColor = Color.DimGray
        btAddCat.Font = New Font("Segoe UI", 9F)
        btAddCat.ForeColor = Color.White
        btAddCat.Location = New Point(196, 261)
        btAddCat.Name = "btAddCat"
        btAddCat.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btAddCat.Size = New Size(121, 36)
        btAddCat.TabIndex = 3
        btAddCat.Text = "Add"
        ' 
        ' dgvCatList
        ' 
        dgvCatList.AllowUserToAddRows = False
        dgvCatList.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = Color.White
        dgvCatList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvCatList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvCatList.ColumnHeadersHeight = 4
        dgvCatList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvCatList.DefaultCellStyle = DataGridViewCellStyle9
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
        btRemove.CustomizableEdges = CustomizableEdges11
        btRemove.DisabledState.BorderColor = Color.DarkGray
        btRemove.DisabledState.CustomBorderColor = Color.DarkGray
        btRemove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btRemove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btRemove.FillColor = Color.DimGray
        btRemove.Font = New Font("Segoe UI", 9F)
        btRemove.ForeColor = Color.White
        btRemove.Location = New Point(39, 261)
        btRemove.Name = "btRemove"
        btRemove.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btRemove.Size = New Size(121, 36)
        btRemove.TabIndex = 5
        btRemove.Text = "Remove"
        ' 
        ' cbxAddDescr
        ' 
        cbxAddDescr.AutoSize = True
        cbxAddDescr.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxAddDescr.CheckedState.BorderRadius = 0
        cbxAddDescr.CheckedState.BorderThickness = 0
        cbxAddDescr.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxAddDescr.Location = New Point(193, 63)
        cbxAddDescr.Name = "cbxAddDescr"
        cbxAddDescr.Size = New Size(149, 19)
        cbxAddDescr.TabIndex = 6
        cbxAddDescr.Text = "Additional Descriptions"
        cbxAddDescr.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        cbxAddDescr.UncheckedState.BorderRadius = 0
        cbxAddDescr.UncheckedState.BorderThickness = 0
        cbxAddDescr.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' dgvAddDescr
        ' 
        dgvAddDescr.AllowUserToAddRows = False
        dgvAddDescr.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = Color.White
        dgvAddDescr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        dgvAddDescr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        dgvAddDescr.ColumnHeadersHeight = 4
        dgvAddDescr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        dgvAddDescr.DefaultCellStyle = DataGridViewCellStyle12
        dgvAddDescr.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.Location = New Point(193, 86)
        dgvAddDescr.Name = "dgvAddDescr"
        dgvAddDescr.ReadOnly = True
        dgvAddDescr.RowHeadersVisible = False
        dgvAddDescr.Size = New Size(219, 150)
        dgvAddDescr.TabIndex = 7
        dgvAddDescr.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvAddDescr.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvAddDescr.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvAddDescr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvAddDescr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvAddDescr.ThemeStyle.BackColor = Color.White
        dgvAddDescr.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvAddDescr.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvAddDescr.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvAddDescr.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvAddDescr.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddDescr.ThemeStyle.HeaderStyle.Height = 4
        dgvAddDescr.ThemeStyle.ReadOnly = True
        dgvAddDescr.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvAddDescr.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAddDescr.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvAddDescr.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvAddDescr.ThemeStyle.RowsStyle.Height = 25
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' StockCategoryAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 323)
        Controls.Add(dgvAddDescr)
        Controls.Add(cbxAddDescr)
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
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbxAddDescr As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents dgvAddDescr As Guna.UI2.WinForms.Guna2DataGridView
End Class
