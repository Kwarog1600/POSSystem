<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseAdd
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
        txbxPurpose = New Guna.UI2.WinForms.Guna2TextBox()
        btAddExpenses = New Guna.UI2.WinForms.Guna2Button()
        txbxAmount = New Guna.UI2.WinForms.Guna2TextBox()
        lbPurpose = New Label()
        lbAmount = New Label()
        lbname = New Label()
        txbxName = New Guna.UI2.WinForms.Guna2TextBox()
        cbxDeduct = New CheckBox()
        SuspendLayout()
        ' 
        ' txbxPurpose
        ' 
        txbxPurpose.CustomizableEdges = CustomizableEdges1
        txbxPurpose.DefaultText = ""
        txbxPurpose.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxPurpose.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxPurpose.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPurpose.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxPurpose.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPurpose.Font = New Font("Segoe UI", 9F)
        txbxPurpose.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxPurpose.Location = New Point(12, 89)
        txbxPurpose.Name = "txbxPurpose"
        txbxPurpose.PasswordChar = ChrW(0)
        txbxPurpose.PlaceholderText = "Purpose"
        txbxPurpose.SelectedText = ""
        txbxPurpose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxPurpose.Size = New Size(354, 36)
        txbxPurpose.TabIndex = 8
        ' 
        ' btAddExpenses
        ' 
        btAddExpenses.BackColor = Color.Transparent
        btAddExpenses.CustomizableEdges = CustomizableEdges3
        btAddExpenses.DisabledState.BorderColor = Color.DarkGray
        btAddExpenses.DisabledState.CustomBorderColor = Color.DarkGray
        btAddExpenses.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddExpenses.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddExpenses.FillColor = Color.DimGray
        btAddExpenses.Font = New Font("Segoe UI", 9F)
        btAddExpenses.ForeColor = Color.White
        btAddExpenses.Location = New Point(186, 201)
        btAddExpenses.Name = "btAddExpenses"
        btAddExpenses.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddExpenses.Size = New Size(180, 45)
        btAddExpenses.TabIndex = 9
        btAddExpenses.Text = "Add Expense"
        ' 
        ' txbxAmount
        ' 
        txbxAmount.CustomizableEdges = CustomizableEdges5
        txbxAmount.DefaultText = ""
        txbxAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmount.Font = New Font("Segoe UI", 9F)
        txbxAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmount.Location = New Point(12, 155)
        txbxAmount.Name = "txbxAmount"
        txbxAmount.PasswordChar = ChrW(0)
        txbxAmount.PlaceholderText = "Amount"
        txbxAmount.SelectedText = ""
        txbxAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txbxAmount.Size = New Size(354, 36)
        txbxAmount.TabIndex = 10
        ' 
        ' lbPurpose
        ' 
        lbPurpose.AutoSize = True
        lbPurpose.Location = New Point(12, 71)
        lbPurpose.Name = "lbPurpose"
        lbPurpose.Size = New Size(50, 15)
        lbPurpose.TabIndex = 11
        lbPurpose.Text = "Purpose"
        ' 
        ' lbAmount
        ' 
        lbAmount.AutoSize = True
        lbAmount.Location = New Point(12, 137)
        lbAmount.Name = "lbAmount"
        lbAmount.Size = New Size(51, 15)
        lbAmount.TabIndex = 12
        lbAmount.Text = "Amount"
        ' 
        ' lbname
        ' 
        lbname.AutoSize = True
        lbname.Location = New Point(12, 14)
        lbname.Name = "lbname"
        lbname.Size = New Size(39, 15)
        lbname.TabIndex = 14
        lbname.Text = "Name"
        ' 
        ' txbxName
        ' 
        txbxName.CustomizableEdges = CustomizableEdges7
        txbxName.DefaultText = ""
        txbxName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxName.Font = New Font("Segoe UI", 9F)
        txbxName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxName.Location = New Point(12, 32)
        txbxName.Name = "txbxName"
        txbxName.PasswordChar = ChrW(0)
        txbxName.PlaceholderText = "Name"
        txbxName.SelectedText = ""
        txbxName.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txbxName.Size = New Size(354, 36)
        txbxName.TabIndex = 13
        ' 
        ' cbxDeduct
        ' 
        cbxDeduct.AutoSize = True
        cbxDeduct.Checked = True
        cbxDeduct.CheckState = CheckState.Checked
        cbxDeduct.Location = New Point(12, 201)
        cbxDeduct.Name = "cbxDeduct"
        cbxDeduct.Size = New Size(124, 19)
        cbxDeduct.TabIndex = 15
        cbxDeduct.Text = "Deduct From Cash"
        cbxDeduct.UseVisualStyleBackColor = True
        ' 
        ' ExpenseAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(378, 258)
        Controls.Add(cbxDeduct)
        Controls.Add(lbname)
        Controls.Add(txbxName)
        Controls.Add(lbAmount)
        Controls.Add(lbPurpose)
        Controls.Add(txbxAmount)
        Controls.Add(btAddExpenses)
        Controls.Add(txbxPurpose)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ExpenseAdd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ExpenseAdd"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbxPurpose As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btAddExpenses As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txbxAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbPurpose As Label
    Friend WithEvents lbAmount As Label
    Friend WithEvents lbname As Label
    Friend WithEvents txbxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxDeduct As CheckBox
End Class
