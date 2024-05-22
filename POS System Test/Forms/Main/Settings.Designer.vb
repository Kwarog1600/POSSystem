<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        btSeach = New Guna.UI2.WinForms.Guna2Button()
        lbsrcLoc = New Label()
        txbxProduct = New Guna.UI2.WinForms.Guna2TextBox()
        FolderDialog = New FolderBrowserDialog()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' btSeach
        ' 
        btSeach.BackColor = Color.Transparent
        btSeach.CustomizableEdges = CustomizableEdges1
        btSeach.DisabledState.BorderColor = Color.DarkGray
        btSeach.DisabledState.CustomBorderColor = Color.DarkGray
        btSeach.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSeach.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSeach.FillColor = Color.DimGray
        btSeach.Font = New Font("Segoe UI", 9F)
        btSeach.ForeColor = Color.White
        btSeach.Location = New Point(352, 27)
        btSeach.Name = "btSeach"
        btSeach.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btSeach.Size = New Size(77, 36)
        btSeach.TabIndex = 46
        btSeach.Text = "Search"
        ' 
        ' lbsrcLoc
        ' 
        lbsrcLoc.AutoSize = True
        lbsrcLoc.BackColor = Color.Transparent
        lbsrcLoc.Location = New Point(12, 9)
        lbsrcLoc.Name = "lbsrcLoc"
        lbsrcLoc.Size = New Size(104, 15)
        lbsrcLoc.TabIndex = 45
        lbsrcLoc.Text = "Resource Location"
        ' 
        ' txbxProduct
        ' 
        txbxProduct.BackColor = Color.Transparent
        txbxProduct.CustomizableEdges = CustomizableEdges3
        txbxProduct.DefaultText = ""
        txbxProduct.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxProduct.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxProduct.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxProduct.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Font = New Font("Segoe UI", 9F)
        txbxProduct.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxProduct.Location = New Point(12, 27)
        txbxProduct.Name = "txbxProduct"
        txbxProduct.PasswordChar = ChrW(0)
        txbxProduct.PlaceholderText = ""
        txbxProduct.SelectedText = ""
        txbxProduct.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxProduct.Size = New Size(325, 36)
        txbxProduct.TabIndex = 44
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.CustomizableEdges = CustomizableEdges5
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(352, 95)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btSave.Size = New Size(77, 36)
        btSave.TabIndex = 47
        btSave.Text = "Save"
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 143)
        Controls.Add(btSave)
        Controls.Add(btSeach)
        Controls.Add(lbsrcLoc)
        Controls.Add(txbxProduct)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btSeach As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbsrcLoc As Label
    Friend WithEvents txbxProduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FolderDialog As FolderBrowserDialog
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
End Class
