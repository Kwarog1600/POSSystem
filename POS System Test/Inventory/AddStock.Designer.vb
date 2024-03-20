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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        clmID = New DataGridViewTextBoxColumn()
        clmBrand = New DataGridViewTextBoxColumn()
        clmModel = New DataGridViewTextBoxColumn()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvDescriptions, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAddedList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txbxBrand
        ' 
        txbxBrand.CustomizableEdges = CustomizableEdges11
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
        txbxBrand.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txbxBrand.Size = New Size(200, 36)
        txbxBrand.TabIndex = 4
        ' 
        ' txbxID
        ' 
        txbxID.CustomizableEdges = CustomizableEdges13
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
        txbxID.ShadowDecoration.CustomizableEdges = CustomizableEdges14
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
        txbxModel.CustomizableEdges = CustomizableEdges15
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
        txbxModel.ShadowDecoration.CustomizableEdges = CustomizableEdges16
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
        btAddStock.CustomizableEdges = CustomizableEdges17
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.FillColor = Color.DimGray
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(243, 266)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 18
        btAddStock.Text = "Add Stock"
        ' 
        ' dgvDescriptions
        ' 
        dgvDescriptions.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = Color.White
        dgvDescriptions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvDescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvDescriptions.ColumnHeadersHeight = 4
        dgvDescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvDescriptions.DefaultCellStyle = DataGridViewCellStyle9
        dgvDescriptions.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvDescriptions.Location = New Point(96, 186)
        dgvDescriptions.Name = "dgvDescriptions"
        dgvDescriptions.RowHeadersVisible = False
        dgvDescriptions.Size = New Size(533, 48)
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
        dgvDescriptions.ThemeStyle.HeaderStyle.Height = 4
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
        DataGridViewCellStyle10.BackColor = Color.White
        dgvAddedList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        dgvAddedList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        dgvAddedList.ColumnHeadersHeight = 17
        dgvAddedList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvAddedList.Columns.AddRange(New DataGridViewColumn() {clmID, clmBrand, clmModel})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        dgvAddedList.DefaultCellStyle = DataGridViewCellStyle12
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
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.BorderRadius = 25
        btSave.CustomizableEdges = CustomizableEdges19
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(449, 266)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btSave.Size = New Size(180, 45)
        btSave.TabIndex = 21
        btSave.Text = "Save"
        ' 
        ' AddStock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 604)
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
    Friend WithEvents clmID As DataGridViewTextBoxColumn
    Friend WithEvents clmBrand As DataGridViewTextBoxColumn
    Friend WithEvents clmModel As DataGridViewTextBoxColumn
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
End Class
