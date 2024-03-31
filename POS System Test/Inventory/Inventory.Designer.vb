<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        txbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        btAddCategory = New Guna.UI2.WinForms.Guna2Button()
        dgvStockList = New Guna.UI2.WinForms.Guna2DataGridView()
        clmID = New DataGridViewTextBoxColumn()
        clmProduct = New DataGridViewTextBoxColumn()
        clmPrice = New DataGridViewTextBoxColumn()
        clmQty = New DataGridViewTextBoxColumn()
        lblStockCategory = New Label()
        cbxCategory = New ComboBox()
        btStockHistory = New Guna.UI2.WinForms.Guna2Button()
        btAddStock = New Guna.UI2.WinForms.Guna2Button()
        pnlContainer.SuspendLayout()
        CType(dgvStockList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(txbxSearch)
        pnlContainer.Controls.Add(btAddCategory)
        pnlContainer.Controls.Add(dgvStockList)
        pnlContainer.Controls.Add(lblStockCategory)
        pnlContainer.Controls.Add(cbxCategory)
        pnlContainer.Controls.Add(btStockHistory)
        pnlContainer.Controls.Add(btAddStock)
        pnlContainer.CustomizableEdges = CustomizableEdges9
        pnlContainer.Location = New Point(24, 51)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 3
        ' 
        ' txbxSearch
        ' 
        txbxSearch.CustomizableEdges = CustomizableEdges1
        txbxSearch.DefaultText = ""
        txbxSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSearch.Font = New Font("Segoe UI", 9F)
        txbxSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSearch.Location = New Point(650, 21)
        txbxSearch.Name = "txbxSearch"
        txbxSearch.PasswordChar = ChrW(0)
        txbxSearch.PlaceholderText = "Search"
        txbxSearch.SelectedText = ""
        txbxSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxSearch.Size = New Size(200, 36)
        txbxSearch.TabIndex = 7
        ' 
        ' btAddCategory
        ' 
        btAddCategory.BackColor = Color.Transparent
        btAddCategory.BorderRadius = 25
        btAddCategory.CustomizableEdges = CustomizableEdges3
        btAddCategory.DisabledState.BorderColor = Color.DarkGray
        btAddCategory.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCategory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCategory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCategory.FillColor = Color.DimGray
        btAddCategory.Font = New Font("Segoe UI", 9F)
        btAddCategory.ForeColor = Color.White
        btAddCategory.Location = New Point(265, 492)
        btAddCategory.Name = "btAddCategory"
        btAddCategory.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddCategory.Size = New Size(180, 45)
        btAddCategory.TabIndex = 6
        btAddCategory.Text = "Add Category"
        ' 
        ' dgvStockList
        ' 
        dgvStockList.AllowUserToAddRows = False
        dgvStockList.AllowUserToDeleteRows = False
        dgvStockList.AllowUserToResizeColumns = False
        dgvStockList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvStockList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStockList.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStockList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStockList.Columns.AddRange(New DataGridViewColumn() {clmID, clmProduct, clmPrice, clmQty})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvStockList.DefaultCellStyle = DataGridViewCellStyle3
        dgvStockList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.Location = New Point(50, 77)
        dgvStockList.Name = "dgvStockList"
        dgvStockList.ReadOnly = True
        dgvStockList.RowHeadersVisible = False
        dgvStockList.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvStockList.Size = New Size(800, 389)
        dgvStockList.TabIndex = 5
        dgvStockList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvStockList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvStockList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvStockList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvStockList.ThemeStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvStockList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvStockList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvStockList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvStockList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStockList.ThemeStyle.HeaderStyle.Height = 17
        dgvStockList.ThemeStyle.ReadOnly = True
        dgvStockList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStockList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvStockList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvStockList.ThemeStyle.RowsStyle.Height = 25
        dgvStockList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
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
        ' clmQty
        ' 
        clmQty.HeaderText = "Available"
        clmQty.Name = "clmQty"
        clmQty.ReadOnly = True
        ' 
        ' lblStockCategory
        ' 
        lblStockCategory.AutoSize = True
        lblStockCategory.BackColor = Color.Transparent
        lblStockCategory.Location = New Point(50, 16)
        lblStockCategory.Name = "lblStockCategory"
        lblStockCategory.Size = New Size(55, 15)
        lblStockCategory.TabIndex = 4
        lblStockCategory.Text = "Category"
        ' 
        ' cbxCategory
        ' 
        cbxCategory.AutoCompleteCustomSource.AddRange(New String() {"All"})
        cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbxCategory.FormattingEnabled = True
        cbxCategory.Location = New Point(50, 34)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(128, 23)
        cbxCategory.Sorted = True
        cbxCategory.TabIndex = 3
        cbxCategory.TabStop = False
        ' 
        ' btStockHistory
        ' 
        btStockHistory.BackColor = Color.Transparent
        btStockHistory.BorderRadius = 25
        btStockHistory.CustomizableEdges = CustomizableEdges5
        btStockHistory.DisabledState.BorderColor = Color.DarkGray
        btStockHistory.DisabledState.CustomBorderColor = Color.DarkGray
        btStockHistory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btStockHistory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btStockHistory.FillColor = Color.DimGray
        btStockHistory.Font = New Font("Segoe UI", 9F)
        btStockHistory.ForeColor = Color.White
        btStockHistory.Location = New Point(670, 492)
        btStockHistory.Name = "btStockHistory"
        btStockHistory.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btStockHistory.Size = New Size(180, 45)
        btStockHistory.TabIndex = 2
        btStockHistory.Text = "Stock History"
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
        btAddStock.Location = New Point(466, 492)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 1
        btAddStock.Text = "Add Stock"
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        Text = "Inventory"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        CType(dgvStockList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btStockHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAddStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStockCategory As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents dgvStockList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btAddCategory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmProduct As DataGridViewTextBoxColumn
    Friend WithEvents clmPrice As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
End Class
