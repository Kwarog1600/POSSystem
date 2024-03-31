<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        lblName = New Label()
        txbxTotal = New Guna.UI2.WinForms.Guna2TextBox()
        txbxName = New Guna.UI2.WinForms.Guna2TextBox()
        dgvStockList = New Guna.UI2.WinForms.Guna2DataGridView()
        clmID = New DataGridViewTextBoxColumn()
        clmPrice = New DataGridViewTextBoxColumn()
        clmCategory = New DataGridViewTextBoxColumn()
        clmBrand = New DataGridViewTextBoxColumn()
        clmModel = New DataGridViewTextBoxColumn()
        clmQty = New DataGridViewTextBoxColumn()
        clmsubtotal = New DataGridViewTextBoxColumn()
        btSale = New Guna.UI2.WinForms.Guna2Button()
        pnlContainer.SuspendLayout()
        CType(dgvStockList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(lblName)
        pnlContainer.Controls.Add(txbxTotal)
        pnlContainer.Controls.Add(txbxName)
        pnlContainer.Controls.Add(dgvStockList)
        pnlContainer.Controls.Add(btSale)
        pnlContainer.CustomizableEdges = CustomizableEdges7
        pnlContainer.Location = New Point(40, 107)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(650, 41)
        lblName.Name = "lblName"
        lblName.Size = New Size(48, 15)
        lblName.TabIndex = 9
        lblName.Text = "Sold To:"
        ' 
        ' txbxTotal
        ' 
        txbxTotal.CustomizableEdges = CustomizableEdges1
        txbxTotal.DefaultText = ""
        txbxTotal.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxTotal.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxTotal.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxTotal.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxTotal.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxTotal.Font = New Font("Segoe UI", 9F)
        txbxTotal.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxTotal.Location = New Point(650, 429)
        txbxTotal.Name = "txbxTotal"
        txbxTotal.PasswordChar = ChrW(0)
        txbxTotal.PlaceholderText = "Total"
        txbxTotal.SelectedText = ""
        txbxTotal.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxTotal.Size = New Size(200, 36)
        txbxTotal.TabIndex = 8
        ' 
        ' txbxName
        ' 
        txbxName.CustomizableEdges = CustomizableEdges3
        txbxName.DefaultText = ""
        txbxName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxName.Font = New Font("Segoe UI", 9F)
        txbxName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxName.Location = New Point(650, 59)
        txbxName.Name = "txbxName"
        txbxName.PasswordChar = ChrW(0)
        txbxName.PlaceholderText = "Name"
        txbxName.SelectedText = ""
        txbxName.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxName.Size = New Size(200, 36)
        txbxName.TabIndex = 7
        ' 
        ' dgvStockList
        ' 
        dgvStockList.AllowUserToAddRows = False
        dgvStockList.AllowUserToDeleteRows = False
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
        dgvStockList.ColumnHeadersHeight = 17
        dgvStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvStockList.Columns.AddRange(New DataGridViewColumn() {clmID, clmPrice, clmCategory, clmBrand, clmModel, clmQty, clmsubtotal})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvStockList.DefaultCellStyle = DataGridViewCellStyle3
        dgvStockList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.Location = New Point(456, 122)
        dgvStockList.Name = "dgvStockList"
        dgvStockList.ReadOnly = True
        dgvStockList.RowHeadersVisible = False
        dgvStockList.Size = New Size(394, 301)
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
        dgvStockList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
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
        ' clmPrice
        ' 
        clmPrice.HeaderText = "Price"
        clmPrice.Name = "clmPrice"
        clmPrice.ReadOnly = True
        ' 
        ' clmCategory
        ' 
        clmCategory.HeaderText = "Category"
        clmCategory.Name = "clmCategory"
        clmCategory.ReadOnly = True
        ' 
        ' clmBrand
        ' 
        clmBrand.HeaderText = "Brand"
        clmBrand.Name = "clmBrand"
        clmBrand.ReadOnly = True
        ' 
        ' clmModel
        ' 
        clmModel.HeaderText = "Model"
        clmModel.Name = "clmModel"
        clmModel.ReadOnly = True
        ' 
        ' clmQty
        ' 
        clmQty.HeaderText = "Quantity"
        clmQty.Name = "clmQty"
        clmQty.ReadOnly = True
        ' 
        ' clmsubtotal
        ' 
        clmsubtotal.HeaderText = "Subtotal"
        clmsubtotal.Name = "clmsubtotal"
        clmsubtotal.ReadOnly = True
        ' 
        ' btSale
        ' 
        btSale.BackColor = Color.Transparent
        btSale.BorderRadius = 25
        btSale.CustomizableEdges = CustomizableEdges5
        btSale.DisabledState.BorderColor = Color.DarkGray
        btSale.DisabledState.CustomBorderColor = Color.DarkGray
        btSale.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSale.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSale.FillColor = Color.DimGray
        btSale.Font = New Font("Segoe UI", 9F)
        btSale.ForeColor = Color.White
        btSale.Location = New Point(670, 492)
        btSale.Name = "btSale"
        btSale.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btSale.Size = New Size(180, 45)
        btSale.TabIndex = 2
        btSale.Text = "Stock History"
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Sales"
        Text = "Sales"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        CType(dgvStockList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txbxTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvStockList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btSale As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmPrice As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmBrand As DataGridViewTextBoxColumn
    Friend WithEvents clmModel As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
    Friend WithEvents clmsubtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblName As Label
End Class
