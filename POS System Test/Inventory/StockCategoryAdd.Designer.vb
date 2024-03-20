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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        txbxCategory = New Guna.UI2.WinForms.Guna2TextBox()
        lblCategoryName = New Label()
        dgvCatDescr = New Guna.UI2.WinForms.Guna2DataGridView()
        clmDescriptions = New DataGridViewTextBoxColumn()
        btAddCat = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvCatDescr, ComponentModel.ISupportInitialize).BeginInit()
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
        ' dgvCatDescr
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvCatDescr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvCatDescr.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCatDescr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCatDescr.ColumnHeadersHeight = 17
        dgvCatDescr.Columns.AddRange(New DataGridViewColumn() {clmDescriptions})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCatDescr.DefaultCellStyle = DataGridViewCellStyle3
        dgvCatDescr.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatDescr.Location = New Point(40, 73)
        dgvCatDescr.Name = "dgvCatDescr"
        dgvCatDescr.RowHeadersVisible = False
        dgvCatDescr.Size = New Size(247, 221)
        dgvCatDescr.TabIndex = 2
        dgvCatDescr.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvCatDescr.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvCatDescr.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvCatDescr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvCatDescr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvCatDescr.ThemeStyle.BackColor = Color.White
        dgvCatDescr.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatDescr.ThemeStyle.HeaderStyle.BackColor = Color.Gray
        dgvCatDescr.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCatDescr.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvCatDescr.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvCatDescr.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvCatDescr.ThemeStyle.HeaderStyle.Height = 17
        dgvCatDescr.ThemeStyle.ReadOnly = False
        dgvCatDescr.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvCatDescr.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvCatDescr.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvCatDescr.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvCatDescr.ThemeStyle.RowsStyle.Height = 25
        dgvCatDescr.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvCatDescr.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' clmDescriptions
        ' 
        clmDescriptions.HeaderText = "Descriptions"
        clmDescriptions.Name = "clmDescriptions"
        ' 
        ' btAddCat
        ' 
        btAddCat.CustomizableEdges = CustomizableEdges3
        btAddCat.DisabledState.BorderColor = Color.DarkGray
        btAddCat.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCat.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCat.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCat.Font = New Font("Segoe UI", 9F)
        btAddCat.ForeColor = Color.White
        btAddCat.Location = New Point(320, 249)
        btAddCat.Name = "btAddCat"
        btAddCat.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddCat.Size = New Size(121, 45)
        btAddCat.TabIndex = 3
        btAddCat.Text = "Add Category"
        ' 
        ' StockCategoryAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(468, 335)
        Controls.Add(btAddCat)
        Controls.Add(dgvCatDescr)
        Controls.Add(lblCategoryName)
        Controls.Add(txbxCategory)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "StockCategoryAdd"
        Text = "StockCategoryAdd"
        CType(dgvCatDescr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents txbxCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents dgvCatDescr As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btAddCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clmDescriptions As DataGridViewTextBoxColumn
End Class
