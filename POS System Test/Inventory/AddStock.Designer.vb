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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxProduct = New Guna.UI2.WinForms.Guna2TextBox()
        txbxID = New Guna.UI2.WinForms.Guna2TextBox()
        lbProduct = New Label()
        lbID = New Label()
        lbCat = New Label()
        cbxCategory = New ComboBox()
        btAddStock = New Guna.UI2.WinForms.Guna2Button()
        dgvAddedList = New Guna.UI2.WinForms.Guna2DataGridView()
        clmCategory = New DataGridViewTextBoxColumn()
        clmID = New DataGridViewTextBoxColumn()
        clmProduct = New DataGridViewTextBoxColumn()
        clmPrice = New DataGridViewTextBoxColumn()
        clmQuantity = New DataGridViewTextBoxColumn()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        lblQuantity = New Label()
        txbxQty = New Guna.UI2.WinForms.Guna2TextBox()
        lblPrice = New Label()
        txbxPrice = New Guna.UI2.WinForms.Guna2TextBox()
        dgvAddDescr = New Guna.UI2.WinForms.Guna2DataGridView()
        clmDescription = New DataGridViewTextBoxColumn()
        clmValue = New DataGridViewTextBoxColumn()
        btRemove = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvAddedList, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxProduct
        ' 
        txbxProduct.BorderRadius = 18
        txbxProduct.CustomizableEdges = CustomizableEdges1
        txbxProduct.DefaultText = ""
        txbxProduct.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxProduct.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxProduct.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Font = New Font("Segoe UI", 9F)
        txbxProduct.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Location = New Point(73, 75)
        txbxProduct.Name = "txbxProduct"
        txbxProduct.PasswordChar = ChrW(0)
        txbxProduct.PlaceholderText = ""
        txbxProduct.SelectedText = ""
        txbxProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxProduct.Size = New Size(242, 36)
        txbxProduct.TabIndex = 1
        ' 
        ' txbxID
        ' 
        txbxID.BorderRadius = 18
        txbxID.CustomizableEdges = CustomizableEdges3
        txbxID.DefaultText = ""
        txbxID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Font = New Font("Segoe UI", 9F)
        txbxID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxID.Location = New Point(73, 21)
        txbxID.Name = "txbxID"
        txbxID.PasswordChar = ChrW(0)
        txbxID.PlaceholderText = ""
        txbxID.SelectedText = ""
        txbxID.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxID.Size = New Size(242, 36)
        txbxID.TabIndex = 0
        ' 
        ' lbProduct
        ' 
        lbProduct.AutoSize = True
        lbProduct.Location = New Point(12, 75)
        lbProduct.Name = "lbProduct"
        lbProduct.Size = New Size(49, 15)
        lbProduct.TabIndex = 7
        lbProduct.Text = "Product"
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.Location = New Point(12, 21)
        lbID.Name = "lbID"
        lbID.Size = New Size(18, 15)
        lbID.TabIndex = 8
        lbID.Text = "ID"
        ' 
        ' lbCat
        ' 
        lbCat.AutoSize = True
        lbCat.Location = New Point(321, 21)
        lbCat.Name = "lbCat"
        lbCat.Size = New Size(55, 15)
        lbCat.TabIndex = 9
        lbCat.Text = "Category"
        ' 
        ' cbxCategory
        ' 
        cbxCategory.AutoCompleteCustomSource.AddRange(New String() {"All"})
        cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbxCategory.FormattingEnabled = True
        cbxCategory.ItemHeight = 15
        cbxCategory.Location = New Point(382, 21)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(156, 23)
        cbxCategory.Sorted = True
        cbxCategory.TabIndex = 4
        cbxCategory.TabStop = False
        ' 
        ' btAddStock
        ' 
        btAddStock.BackColor = Color.Transparent
        btAddStock.BorderRadius = 25
        btAddStock.CustomizableEdges = CustomizableEdges5
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.FillColor = Color.DimGray
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(509, 61)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btAddStock.Size = New Size(120, 50)
        btAddStock.TabIndex = 18
        btAddStock.Text = "Add Stock"
        ' 
        ' dgvAddedList
        ' 
        dgvAddedList.AllowUserToAddRows = False
        dgvAddedList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvAddedList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvAddedList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvAddedList.ColumnHeadersHeight = 17
        dgvAddedList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddedList.Columns.AddRange(New DataGridViewColumn() {clmCategory, clmID, clmProduct, clmPrice, clmQuantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvAddedList.DefaultCellStyle = DataGridViewCellStyle3
        dgvAddedList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddedList.Location = New Point(12, 254)
        dgvAddedList.Name = "dgvAddedList"
        dgvAddedList.ReadOnly = True
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
        dgvAddedList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvAddedList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvAddedList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvAddedList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvAddedList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddedList.ThemeStyle.HeaderStyle.Height = 17
        dgvAddedList.ThemeStyle.ReadOnly = True
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
        clmCategory.ReadOnly = True
        ' 
        ' clmID
        ' 
        clmID.HeaderText = "ID"
        clmID.Name = "clmID"
        clmID.ReadOnly = True
        ' 
        ' clmProduct
        ' 
        clmProduct.HeaderText = "Product"
        clmProduct.Name = "clmProduct"
        clmProduct.ReadOnly = True
        ' 
        ' clmPrice
        ' 
        clmPrice.HeaderText = "Price"
        clmPrice.Name = "clmPrice"
        clmPrice.ReadOnly = True
        ' 
        ' clmQuantity
        ' 
        clmQuantity.HeaderText = "Quantity"
        clmQuantity.Name = "clmQuantity"
        clmQuantity.ReadOnly = True
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.BorderRadius = 25
        btSave.CustomizableEdges = CustomizableEdges7
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(509, 117)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btSave.Size = New Size(120, 50)
        btSave.TabIndex = 21
        btSave.Text = "Save"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(12, 136)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 23
        lblQuantity.Text = "Quantity"
        ' 
        ' txbxQty
        ' 
        txbxQty.BorderRadius = 18
        txbxQty.CustomizableEdges = CustomizableEdges9
        txbxQty.DefaultText = ""
        txbxQty.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxQty.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxQty.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxQty.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxQty.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxQty.Font = New Font("Segoe UI", 9F)
        txbxQty.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxQty.Location = New Point(73, 136)
        txbxQty.Name = "txbxQty"
        txbxQty.PasswordChar = ChrW(0)
        txbxQty.PlaceholderText = ""
        txbxQty.SelectedText = ""
        txbxQty.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txbxQty.Size = New Size(242, 36)
        txbxQty.TabIndex = 2
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(12, 195)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 25
        lblPrice.Text = "Price"
        ' 
        ' txbxPrice
        ' 
        txbxPrice.BorderRadius = 18
        txbxPrice.CustomizableEdges = CustomizableEdges11
        txbxPrice.DefaultText = ""
        txbxPrice.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxPrice.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxPrice.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPrice.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPrice.Font = New Font("Segoe UI", 9F)
        txbxPrice.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPrice.Location = New Point(73, 195)
        txbxPrice.Name = "txbxPrice"
        txbxPrice.PasswordChar = ChrW(0)
        txbxPrice.PlaceholderText = ""
        txbxPrice.SelectedText = ""
        txbxPrice.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txbxPrice.Size = New Size(247, 36)
        txbxPrice.TabIndex = 3
        ' 
        ' dgvAddDescr
        ' 
        dgvAddDescr.AllowUserToAddRows = False
        dgvAddDescr.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        dgvAddDescr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvAddDescr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvAddDescr.ColumnHeadersHeight = 17
        dgvAddDescr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddDescr.Columns.AddRange(New DataGridViewColumn() {clmDescription, clmValue})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvAddDescr.DefaultCellStyle = DataGridViewCellStyle6
        dgvAddDescr.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.Location = New Point(326, 60)
        dgvAddDescr.Name = "dgvAddDescr"
        dgvAddDescr.RowHeadersVisible = False
        dgvAddDescr.Size = New Size(177, 171)
        dgvAddDescr.TabIndex = 26
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
        dgvAddDescr.ThemeStyle.ReadOnly = False
        dgvAddDescr.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvAddDescr.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAddDescr.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvAddDescr.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvAddDescr.ThemeStyle.RowsStyle.Height = 25
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvAddDescr.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' clmDescription
        ' 
        clmDescription.HeaderText = "Description"
        clmDescription.Name = "clmDescription"
        clmDescription.ReadOnly = True
        ' 
        ' clmValue
        ' 
        clmValue.HeaderText = "Value"
        clmValue.Name = "clmValue"
        ' 
        ' btRemove
        ' 
        btRemove.BackColor = Color.Transparent
        btRemove.BorderRadius = 25
        btRemove.CustomizableEdges = CustomizableEdges13
        btRemove.DisabledState.BorderColor = Color.DarkGray
        btRemove.DisabledState.CustomBorderColor = Color.DarkGray
        btRemove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btRemove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btRemove.FillColor = Color.DimGray
        btRemove.Font = New Font("Segoe UI", 9F)
        btRemove.ForeColor = Color.White
        btRemove.Location = New Point(510, 181)
        btRemove.Name = "btRemove"
        btRemove.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btRemove.Size = New Size(120, 50)
        btRemove.TabIndex = 27
        btRemove.Text = "Remove"
        ' 
        ' AddStock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(642, 516)
        Controls.Add(btRemove)
        Controls.Add(dgvAddDescr)
        Controls.Add(lblPrice)
        Controls.Add(txbxPrice)
        Controls.Add(lblQuantity)
        Controls.Add(txbxQty)
        Controls.Add(btSave)
        Controls.Add(dgvAddedList)
        Controls.Add(btAddStock)
        Controls.Add(cbxCategory)
        Controls.Add(lbCat)
        Controls.Add(lbID)
        Controls.Add(lbProduct)
        Controls.Add(txbxID)
        Controls.Add(txbxProduct)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddStock"
        Text = "Add Stock"
        TopMost = True
        CType(dgvAddedList, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAddDescr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txbxProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbProduct As Label
    Friend WithEvents lbID As Label
    Private WithEvents lbCat As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btAddStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvAddedList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txbxQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txbxPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmProduct As DataGridViewTextBoxColumn
    Friend WithEvents clmPrice As DataGridViewTextBoxColumn
    Friend WithEvents clmQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dgvAddDescr As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents clmDescription As DataGridViewTextBoxColumn
    Friend WithEvents clmValue As DataGridViewTextBoxColumn
    Friend WithEvents btRemove As Guna.UI2.WinForms.Guna2Button
End Class
