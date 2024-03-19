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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxBrand = New Guna.UI2.WinForms.Guna2TextBox()
        txbxID = New Guna.UI2.WinForms.Guna2TextBox()
        lbBrand = New Label()
        lbID = New Label()
        lbCat = New Label()
        lbModel = New Label()
        txbxModel = New Guna.UI2.WinForms.Guna2TextBox()
        lbDescription = New Label()
        txbxDescription = New Guna.UI2.WinForms.Guna2TextBox()
        cbxCategory = New ComboBox()
        btAddStock = New Guna.UI2.WinForms.Guna2Button()
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
        ' txbxDescription
        ' 
        txbxDescription.CustomizableEdges = CustomizableEdges7
        txbxDescription.DefaultText = ""
        txbxDescription.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxDescription.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxDescription.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxDescription.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxDescription.Font = New Font("Segoe UI", 9F)
        txbxDescription.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxDescription.Location = New Point(89, 189)
        txbxDescription.Name = "txbxDescription"
        txbxDescription.PasswordChar = ChrW(0)
        txbxDescription.PlaceholderText = ""
        txbxDescription.SelectedText = ""
        txbxDescription.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txbxDescription.Size = New Size(542, 95)
        txbxDescription.TabIndex = 12
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
        btAddStock.CustomizableEdges = CustomizableEdges9
        btAddStock.DisabledState.BorderColor = Color.DarkGray
        btAddStock.DisabledState.CustomBorderColor = Color.DarkGray
        btAddStock.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddStock.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddStock.FillColor = Color.DimGray
        btAddStock.Font = New Font("Segoe UI", 9F)
        btAddStock.ForeColor = Color.White
        btAddStock.Location = New Point(451, 315)
        btAddStock.Name = "btAddStock"
        btAddStock.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btAddStock.Size = New Size(180, 45)
        btAddStock.TabIndex = 18
        btAddStock.Text = "Add Stock"
        ' 
        ' AddStock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(643, 372)
        Controls.Add(btAddStock)
        Controls.Add(cbxCategory)
        Controls.Add(lbDescription)
        Controls.Add(txbxDescription)
        Controls.Add(lbModel)
        Controls.Add(txbxModel)
        Controls.Add(lbCat)
        Controls.Add(lbID)
        Controls.Add(lbBrand)
        Controls.Add(txbxID)
        Controls.Add(txbxBrand)
        Name = "AddStock"
        Text = "AddStock"
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
    Friend WithEvents txbxDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btAddStock As Guna.UI2.WinForms.Guna2Button
End Class
