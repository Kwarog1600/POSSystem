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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2DataGridView2 = New Guna.UI2.WinForms.Guna2DataGridView()
        clmID = New DataGridViewTextBoxColumn()
        clmBrand = New DataGridViewTextBoxColumn()
        clmModel = New DataGridViewTextBoxColumn()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxBrand
        ' 
        txbxBrand.CustomizableEdges = CustomizableEdges9
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
        txbxBrand.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txbxBrand.Size = New Size(200, 36)
        txbxBrand.TabIndex = 4
        ' 
        ' txbxID
        ' 
        txbxID.CustomizableEdges = CustomizableEdges11
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
        txbxID.ShadowDecoration.CustomizableEdges = CustomizableEdges12
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
        txbxModel.CustomizableEdges = CustomizableEdges13
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
        txbxModel.ShadowDecoration.CustomizableEdges = CustomizableEdges14
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
        cbxCategory.Size = New Size(128, 23)
        cbxCategory.Sorted = True
        cbxCategory.TabIndex = 17
        cbxCategory.TabStop = False
        ' 
        ' btAddStock
        ' 
        btAddStock.BackColor = Color.Transparent
        btAddStock.BorderRadius = 25
        btAddStock.CustomizableEdges = CustomizableEdges15
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.FillColor = Color.DimGray
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(449, 532)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 18
        btAddStock.Text = "Add Stock"
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Guna2DataGridView1.ColumnHeadersHeight = 4
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(96, 186)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.Size = New Size(533, 48)
        Guna2DataGridView1.TabIndex = 19
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2DataGridView2
        ' 
        DataGridViewCellStyle10.BackColor = Color.White
        Guna2DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        Guna2DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView2.Columns.AddRange(New DataGridViewColumn() {clmID, clmBrand, clmModel})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        Guna2DataGridView2.DefaultCellStyle = DataGridViewCellStyle12
        Guna2DataGridView2.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.Location = New Point(12, 255)
        Guna2DataGridView2.Name = "Guna2DataGridView2"
        Guna2DataGridView2.RowHeadersVisible = False
        Guna2DataGridView2.Size = New Size(617, 249)
        Guna2DataGridView2.TabIndex = 20
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 17
        Guna2DataGridView2.ThemeStyle.ReadOnly = False
        Guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView2.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView2.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
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
        ' AddStock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(707, 604)
        Controls.Add(Guna2DataGridView2)
        Controls.Add(Guna2DataGridView1)
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
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridView2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmBrand As DataGridViewTextBoxColumn
    Friend WithEvents clmModel As DataGridViewTextBoxColumn
End Class
