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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlDashBoardContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        btAddCat = New Guna.UI2.WinForms.Guna2Button()
        lblStockCategory = New Label()
        ComboBox1 = New ComboBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        btAddStock = New Guna.UI2.WinForms.Guna2Button()
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Brand = New DataGridViewTextBoxColumn()
        Model = New DataGridViewTextBoxColumn()
        Description = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        pnlDashBoardContainer.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDashBoardContainer
        ' 
        pnlDashBoardContainer.BorderRadius = 25
        pnlDashBoardContainer.Controls.Add(btAddCat)
        pnlDashBoardContainer.Controls.Add(lblStockCategory)
        pnlDashBoardContainer.Controls.Add(ComboBox1)
        pnlDashBoardContainer.Controls.Add(Guna2Button2)
        pnlDashBoardContainer.Controls.Add(btAddStock)
        pnlDashBoardContainer.Controls.Add(DataGridView1)
        pnlDashBoardContainer.CustomizableEdges = CustomizableEdges7
        pnlDashBoardContainer.Location = New Point(24, 51)
        pnlDashBoardContainer.Name = "pnlDashBoardContainer"
        pnlDashBoardContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlDashBoardContainer.Size = New Size(920, 575)
        pnlDashBoardContainer.TabIndex = 3
        ' 
        ' btAddCat
        ' 
        btAddCat.CustomizableEdges = CustomizableEdges1
        btAddCat.DisabledState.BorderColor = Color.DarkGray
        btAddCat.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCat.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCat.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCat.Font = New Font("Segoe UI", 9F)
        btAddCat.ForeColor = Color.White
        btAddCat.Location = New Point(260, 492)
        btAddCat.Name = "btAddCat"
        btAddCat.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btAddCat.Size = New Size(180, 45)
        btAddCat.TabIndex = 5
        btAddCat.Text = "Edit Stock Category"
        ' 
        ' lblStockCategory
        ' 
        lblStockCategory.AutoSize = True
        lblStockCategory.Location = New Point(50, 16)
        lblStockCategory.Name = "lblStockCategory"
        lblStockCategory.Size = New Size(55, 15)
        lblStockCategory.TabIndex = 4
        lblStockCategory.Text = "Category"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All"})
        ComboBox1.Location = New Point(50, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(670, 492)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(180, 45)
        Guna2Button2.TabIndex = 2
        Guna2Button2.Text = "Stock History"
        ' 
        ' btAddStock
        ' 
        btAddStock.CustomizableEdges = CustomizableEdges5
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(466, 492)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 1
        btAddStock.Text = "Add Stock"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Brand, Model, Description, Quantity})
        DataGridView1.ImeMode = ImeMode.NoControl
        DataGridView1.Location = New Point(50, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(800, 400)
        DataGridView1.TabIndex = 0
        ' 
        ' ID
        ' 
        ID.FillWeight = 20F
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' Brand
        ' 
        Brand.FillWeight = 30F
        Brand.HeaderText = "Brand"
        Brand.Name = "Brand"
        Brand.ReadOnly = True
        ' 
        ' Model
        ' 
        Model.FillWeight = 40F
        Model.HeaderText = "Model"
        Model.Name = "Model"
        Model.ReadOnly = True
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.Name = "Description"
        Description.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.FillWeight = 20F
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 1000)
        Controls.Add(pnlDashBoardContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        Text = "Inventory"
        pnlDashBoardContainer.ResumeLayout(False)
        pnlDashBoardContainer.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashBoardContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAddStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents lblStockCategory As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btAddCat As Guna.UI2.WinForms.Guna2Button
End Class
