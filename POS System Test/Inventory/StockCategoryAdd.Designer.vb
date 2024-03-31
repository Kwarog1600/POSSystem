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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        txbxCategory = New Guna.UI2.WinForms.Guna2TextBox()
        lblCategoryName = New Label()
        btAddCat = New Guna.UI2.WinForms.Guna2Button()
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
        ' btAddCat
        ' 
        btAddCat.CustomizableEdges = CustomizableEdges3
        btAddCat.DisabledState.BorderColor = Color.DarkGray
        btAddCat.DisabledState.CustomBorderColor = Color.DarkGray
        btAddCat.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddCat.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddCat.Font = New Font("Segoe UI", 9F)
        btAddCat.ForeColor = Color.White
        btAddCat.Location = New Point(322, 21)
        btAddCat.Name = "btAddCat"
        btAddCat.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddCat.Size = New Size(121, 36)
        btAddCat.TabIndex = 3
        btAddCat.Text = "Add Category"
        ' 
        ' StockCategoryAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(468, 80)
        Controls.Add(btAddCat)
        Controls.Add(lblCategoryName)
        Controls.Add(txbxCategory)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "StockCategoryAdd"
        Text = "StockCategoryAdd"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents txbxCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents btAddCat As Guna.UI2.WinForms.Guna2Button
End Class
