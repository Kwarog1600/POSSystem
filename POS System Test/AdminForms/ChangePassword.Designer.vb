<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        txbxConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        btChangePass = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' txbxNewPassword
        ' 
        txbxNewPassword.CustomizableEdges = CustomizableEdges7
        txbxNewPassword.DefaultText = ""
        txbxNewPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxNewPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxNewPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxNewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxNewPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxNewPassword.Font = New Font("Segoe UI", 9F)
        txbxNewPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxNewPassword.Location = New Point(12, 12)
        txbxNewPassword.Name = "txbxNewPassword"
        txbxNewPassword.PasswordChar = ChrW(0)
        txbxNewPassword.PlaceholderText = "Password"
        txbxNewPassword.SelectedText = ""
        txbxNewPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txbxNewPassword.Size = New Size(200, 36)
        txbxNewPassword.TabIndex = 0
        ' 
        ' txbxConfirmPass
        ' 
        txbxConfirmPass.CustomizableEdges = CustomizableEdges9
        txbxConfirmPass.DefaultText = ""
        txbxConfirmPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxConfirmPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxConfirmPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxConfirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxConfirmPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxConfirmPass.Font = New Font("Segoe UI", 9F)
        txbxConfirmPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxConfirmPass.Location = New Point(12, 54)
        txbxConfirmPass.Name = "txbxConfirmPass"
        txbxConfirmPass.PasswordChar = ChrW(0)
        txbxConfirmPass.PlaceholderText = "Confirm Password"
        txbxConfirmPass.SelectedText = ""
        txbxConfirmPass.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txbxConfirmPass.Size = New Size(200, 36)
        txbxConfirmPass.TabIndex = 1
        ' 
        ' btChangePass
        ' 
        btChangePass.CustomizableEdges = CustomizableEdges11
        btChangePass.DisabledState.BorderColor = Color.DarkGray
        btChangePass.DisabledState.CustomBorderColor = Color.DarkGray
        btChangePass.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btChangePass.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btChangePass.FillColor = Color.DimGray
        btChangePass.Font = New Font("Segoe UI", 9F)
        btChangePass.ForeColor = Color.White
        btChangePass.Location = New Point(67, 96)
        btChangePass.Name = "btChangePass"
        btChangePass.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btChangePass.Size = New Size(82, 45)
        btChangePass.TabIndex = 17
        btChangePass.Text = "Change Password"
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 148)
        Controls.Add(btChangePass)
        Controls.Add(txbxConfirmPass)
        Controls.Add(txbxNewPassword)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Change Password"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents txbxNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btChangePass As Guna.UI2.WinForms.Guna2Button
End Class
