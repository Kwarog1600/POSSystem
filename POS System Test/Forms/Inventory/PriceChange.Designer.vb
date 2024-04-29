<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceChange
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txbxPrice = New Guna.UI2.WinForms.Guna2TextBox()
        txbxID = New Guna.UI2.WinForms.Guna2TextBox()
        txbxProduct = New Guna.UI2.WinForms.Guna2TextBox()
        txbxCategory = New Guna.UI2.WinForms.Guna2TextBox()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        clmValue = New DataGridViewTextBoxColumn()
        clmDescription = New DataGridViewTextBoxColumn()
        dgvAddDescr = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxPrice
        ' 
        txbxPrice.CustomizableEdges = CustomizableEdges1
        txbxPrice.DefaultText = "Price"
        txbxPrice.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxPrice.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxPrice.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPrice.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPrice.Font = New Font("Segoe UI", 9F)
        txbxPrice.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPrice.Location = New Point(21, 156)
        txbxPrice.Name = "txbxPrice"
        txbxPrice.PasswordChar = ChrW(0)
        txbxPrice.PlaceholderText = ""
        txbxPrice.SelectedText = ""
        txbxPrice.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxPrice.Size = New Size(159, 36)
        txbxPrice.TabIndex = 0
        ' 
        ' txbxID
        ' 
        txbxID.CustomizableEdges = CustomizableEdges3
        txbxID.DefaultText = "ID"
        txbxID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.Enabled = False
        txbxID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Font = New Font("Segoe UI", 9F)
        txbxID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Location = New Point(21, 72)
        txbxID.Name = "txbxID"
        txbxID.PasswordChar = ChrW(0)
        txbxID.PlaceholderText = ""
        txbxID.ReadOnly = True
        txbxID.SelectedText = ""
        txbxID.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxID.Size = New Size(159, 36)
        txbxID.TabIndex = 5
        ' 
        ' txbxProduct
        ' 
        txbxProduct.CustomizableEdges = CustomizableEdges5
        txbxProduct.DefaultText = "Product"
        txbxProduct.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxProduct.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxProduct.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.Enabled = False
        txbxProduct.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Font = New Font("Segoe UI", 9F)
        txbxProduct.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Location = New Point(21, 114)
        txbxProduct.Name = "txbxProduct"
        txbxProduct.PasswordChar = ChrW(0)
        txbxProduct.PlaceholderText = ""
        txbxProduct.ReadOnly = True
        txbxProduct.SelectedText = ""
        txbxProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txbxProduct.Size = New Size(159, 36)
        txbxProduct.TabIndex = 4
        ' 
        ' txbxCategory
        ' 
        txbxCategory.CustomizableEdges = CustomizableEdges7
        txbxCategory.DefaultText = "Category "
        txbxCategory.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxCategory.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxCategory.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxCategory.Enabled = False
        txbxCategory.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxCategory.Font = New Font("Segoe UI", 9F)
        txbxCategory.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxCategory.Location = New Point(21, 30)
        txbxCategory.Name = "txbxCategory"
        txbxCategory.PasswordChar = ChrW(0)
        txbxCategory.PlaceholderText = ""
        txbxCategory.ReadOnly = True
        txbxCategory.SelectedText = ""
        txbxCategory.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txbxCategory.Size = New Size(159, 36)
        txbxCategory.TabIndex = 28
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.CustomizableEdges = CustomizableEdges9
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(294, 198)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btSave.Size = New Size(77, 36)
        btSave.TabIndex = 44
        btSave.Text = "Save"
        ' 
        ' clmValue
        ' 
        clmValue.HeaderText = "Value"
        clmValue.Name = "clmValue"
        clmValue.ReadOnly = True
        ' 
        ' clmDescription
        ' 
        clmDescription.HeaderText = "Description"
        clmDescription.Name = "clmDescription"
        clmDescription.ReadOnly = True
        ' 
        ' dgvAddDescr
        ' 
        dgvAddDescr.AllowUserToAddRows = False
        dgvAddDescr.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvAddDescr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvAddDescr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvAddDescr.ColumnHeadersHeight = 17
        dgvAddDescr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddDescr.Columns.AddRange(New DataGridViewColumn() {clmDescription, clmValue})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvAddDescr.DefaultCellStyle = DataGridViewCellStyle3
        dgvAddDescr.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.Location = New Point(186, 30)
        dgvAddDescr.Name = "dgvAddDescr"
        dgvAddDescr.ReadOnly = True
        dgvAddDescr.RowHeadersVisible = False
        dgvAddDescr.Size = New Size(185, 162)
        dgvAddDescr.TabIndex = 27
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
        dgvAddDescr.ThemeStyle.HeaderStyle.Height = 17
        dgvAddDescr.ThemeStyle.ReadOnly = True
        dgvAddDescr.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvAddDescr.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAddDescr.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvAddDescr.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvAddDescr.ThemeStyle.RowsStyle.Height = 25
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' PriceChange
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 255)
        Controls.Add(btSave)
        Controls.Add(txbxCategory)
        Controls.Add(dgvAddDescr)
        Controls.Add(txbxPrice)
        Controls.Add(txbxID)
        Controls.Add(txbxProduct)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "PriceChange"
        Text = "Price Change"
        TopMost = True
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txbxPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clmValue As DataGridViewTextBoxColumn
    Friend WithEvents clmDescription As DataGridViewTextBoxColumn
    Friend WithEvents dgvAddDescr As Guna.UI2.WinForms.Guna2DataGridView
End Class
