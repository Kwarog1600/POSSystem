<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStock
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxBrand = New Guna.UI2.WinForms.Guna2TextBox()
        txbxID = New Guna.UI2.WinForms.Guna2TextBox()
        lbBrand = New Label()
        lbID = New Label()
        lbCat = New Label()
        lbModel = New Label()
        txbxModel = New Guna.UI2.WinForms.Guna2TextBox()
        lbDescription = New Label()
        cbxCategory = New ComboBox()
        btAddStock = New Guna.UI2.WinForms.Guna2Button()
        dgvDescriptions = New Guna.UI2.WinForms.Guna2DataGridView()
        dgvAddedList = New Guna.UI2.WinForms.Guna2DataGridView()
        clmCategory = New DataGridViewTextBoxColumn()
        clmID = New DataGridViewTextBoxColumn()
        clmBrand = New DataGridViewTextBoxColumn()
        clmModel = New DataGridViewTextBoxColumn()
        clmQuantity = New DataGridViewTextBoxColumn()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        lblQuantity = New Label()
        txbxQty = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvDescriptions, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAddedList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxBrand
        ' 
        txbxBrand.CustomizableEdges = CustomizableEdges1
        txbxBrand.DefaultText = ""
        txbxBrand.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxBrand.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxBrand.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxBrand.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxBrand.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxBrand.Font = New Font("Segoe UI", 9F)
        txbxBrand.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxBrand.Location = New Point(73, 118)
        txbxBrand.Name = "txbxBrand"
        txbxBrand.PasswordChar = ChrW(0)
        txbxBrand.PlaceholderText = ""
        txbxBrand.SelectedText = ""
        txbxBrand.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxBrand.Size = New Size(200, 36)
        txbxBrand.TabIndex = 4
        ' 
        ' txbxID
        ' 
        txbxID.CustomizableEdges = CustomizableEdges3
        txbxID.DefaultText = ""
        txbxID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Font = New Font("Segoe UI", 9F)
        txbxID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Location = New Point(73, 57)
        txbxID.Name = "txbxID"
        txbxID.PasswordChar = ChrW(0)
        txbxID.PlaceholderText = ""
        txbxID.SelectedText = ""
        txbxID.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxID.Size = New Size(200, 36)
        txbxID.TabIndex = 6
        ' 
        ' lbBrand
        ' 
        lbBrand.AutoSize = True
        lbBrand.Location = New Point(12, 118)
        lbBrand.Name = "lbBrand"
        lbBrand.Size = New Size(38, 15)
        lbBrand.TabIndex = 7
        lbBrand.Text = "Brand"
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.Location = New Point(12, 57)
        lbID.Name = "lbID"
        lbID.Size = New Size(18, 15)
        lbID.TabIndex = 8
        lbID.Text = "ID"
        ' 
        ' lbCat
        ' 
        lbCat.AutoSize = True
        lbCat.Location = New Point(368, 57)
        lbCat.Name = "lbCat"
        lbCat.Size = New Size(55, 15)
        lbCat.TabIndex = 9
        lbCat.Text = "Category"
        ' 
        ' lbModel
        ' 
        lbModel.AutoSize = True
        lbModel.Location = New Point(368, 118)
        lbModel.Name = "lbModel"
        lbModel.Size = New Size(41, 15)
        lbModel.TabIndex = 11
        lbModel.Text = "Model"
        ' 
        ' txbxModel
        ' 
        txbxModel.CustomizableEdges = CustomizableEdges5
        txbxModel.DefaultText = ""
        txbxModel.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxModel.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxModel.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxModel.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxModel.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxModel.Font = New Font("Segoe UI", 9F)
        txbxModel.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxModel.Location = New Point(429, 118)
        txbxModel.Name = "txbxModel"
        txbxModel.PasswordChar = ChrW(0)
        txbxModel.PlaceholderText = ""
        txbxModel.SelectedText = ""
        txbxModel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txbxModel.Size = New Size(200, 36)
        txbxModel.TabIndex = 10
        ' 
        ' lbDescription
        ' 
        lbDescription.AutoSize = True
        lbDescription.Location = New Point(12, 177)
        lbDescription.Name = "lbDescription"
        lbDescription.Size = New Size(67, 15)
        lbDescription.TabIndex = 13
        lbDescription.Text = "Description"
        ' 
        ' cbxCategory
        ' 
        cbxCategory.AutoCompleteCustomSource.AddRange(New String() {"All"})
        cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbxCategory.FormattingEnabled = True
        cbxCategory.Location = New Point(429, 57)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(200, 23)
        cbxCategory.Sorted = True
        cbxCategory.TabIndex = 17
        cbxCategory.TabStop = False
        ' 
        ' btAddStock
        ' 
        btAddStock.BackColor = Color.Transparent
        btAddStock.BorderRadius = 25
        btAddStock.CustomizableEdges = CustomizableEdges7
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.FillColor = Color.DimGray
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(243, 266)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 18
        btAddStock.Text = "Add Stock"
        ' 
        ' dgvDescriptions
        ' 
        dgvDescriptions.AllowUserToAddRows = False
        dgvDescriptions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvDescriptions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvDescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvDescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvDescriptions.ColumnHeadersHeight = 20
        dgvDescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvDescriptions.DefaultCellStyle = DataGridViewCellStyle3
        dgvDescriptions.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvDescriptions.Location = New Point(96, 186)
        dgvDescriptions.Name = "dgvDescriptions"
        dgvDescriptions.RowHeadersVisible = False
        dgvDescriptions.Size = New Size(533, 60)
        dgvDescriptions.TabIndex = 19
        dgvDescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvDescriptions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvDescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvDescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvDescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvDescriptions.ThemeStyle.BackColor = Color.White
        dgvDescriptions.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvDescriptions.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvDescriptions.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvDescriptions.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvDescriptions.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvDescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvDescriptions.ThemeStyle.HeaderStyle.Height = 20
        dgvDescriptions.ThemeStyle.ReadOnly = False
        dgvDescriptions.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvDescriptions.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDescriptions.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvDescriptions.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvDescriptions.ThemeStyle.RowsStyle.Height = 25
        dgvDescriptions.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvDescriptions.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' dgvAddedList
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgvAddedList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvAddedList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvAddedList.ColumnHeadersHeight = 17
        dgvAddedList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddedList.Columns.AddRange(New DataGridViewColumn() {clmCategory, clmID, clmBrand, clmModel, clmQuantity})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvAddedList.DefaultCellStyle = DataGridViewCellStyle6
        dgvAddedList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddedList.Location = New Point(12, 343)
        dgvAddedList.Name = "dgvAddedList"
        dgvAddedList.RowHeadersVisible = False
        dgvAddedList.Size = New Size(617, 249)
        dgvAddedList.TabIndex = 20
        dgvAddedList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvAddedList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvAddedList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvAddedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvAddedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvAddedList.ThemeStyle.BackColor = Color.White
        dgvAddedList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddedList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvAddedList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvAddedList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvAddedList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvAddedList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddedList.ThemeStyle.HeaderStyle.Height = 17
        dgvAddedList.ThemeStyle.ReadOnly = False
        dgvAddedList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvAddedList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAddedList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvAddedList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvAddedList.ThemeStyle.RowsStyle.Height = 25
        dgvAddedList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddedList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' clmCategory
        ' 
        clmCategory.HeaderText = "Category"
        clmCategory.Name = "clmCategory"
        ' 
        ' clmID
        ' 
        clmID.HeaderText = "ID"
        clmID.Name = "clmID"
        ' 
        ' clmBrand
        ' 
        clmBrand.HeaderText = "Brand"
        clmBrand.Name = "clmBrand"
        ' 
        ' clmModel
        ' 
        clmModel.HeaderText = "Model"
        clmModel.Name = "clmModel"
        ' 
        ' clmQuantity
        ' 
        clmQuantity.HeaderText = "Quantity"
        clmQuantity.Name = "clmQuantity"
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.BorderRadius = 25
        btSave.CustomizableEdges = CustomizableEdges9
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(449, 266)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btSave.Size = New Size(180, 45)
        btSave.TabIndex = 21
        btSave.Text = "Save"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(12, 276)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 23
        lblQuantity.Text = "Quantity"
        ' 
        ' txbxQty
        ' 
        txbxQty.CustomizableEdges = CustomizableEdges11
        txbxQty.DefaultText = ""
        txbxQty.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxQty.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxQty.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxQty.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxQty.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxQty.Font = New Font("Segoe UI", 9F)
        txbxQty.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxQty.Location = New Point(73, 276)
        txbxQty.Name = "txbxQty"
        txbxQty.PasswordChar = ChrW(0)
        txbxQty.PlaceholderText = ""
        txbxQty.SelectedText = ""
        txbxQty.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txbxQty.Size = New Size(145, 36)
        txbxQty.TabIndex = 22
        ' 
        ' AddStock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 604)
        Controls.Add(lblQuantity)
        Controls.Add(txbxQty)
        Controls.Add(btSave)
        Controls.Add(dgvAddedList)
        Controls.Add(dgvDescriptions)
        Controls.Add(btAddStock)
        Controls.Add(cbxCategory)
        Controls.Add(lbDescription)
        Controls.Add(lbModel)
        Controls.Add(txbxModel)
        Controls.Add(lbCat)
        Controls.Add(lbID)
        Controls.Add(lbBrand)
        Controls.Add(txbxID)
        Controls.Add(txbxBrand)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddStock"
        Text = "AddStock"
        CType(dgvDescriptions, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAddedList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txbxBrand As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbBrand As Label
    Friend WithEvents lbID As Label
    Private WithEvents lbCat As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents txbxModel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbDescription As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btAddStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvDescriptions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvAddedList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txbxQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmBrand As DataGridViewTextBoxColumn
    Friend WithEvents clmModel As DataGridViewTextBoxColumn
    Friend WithEvents clmQuantity As DataGridViewTextBoxColumn
End Class
