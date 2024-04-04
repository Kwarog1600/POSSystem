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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        txbxOldPass = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' txbxNewPassword
        ' 
        txbxNewPassword.CustomizableEdges = CustomizableEdges5
        txbxNewPassword.DefaultText = ""
        txbxNewPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxNewPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxNewPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxNewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxNewPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxNewPassword.Font = New Font("Segoe UI", 9.0F)
        txbxNewPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxNewPassword.Location = New Point(12, 12)
        txbxNewPassword.Name = "txbxNewPassword"
        txbxNewPassword.PasswordChar = ChrW(0)
        txbxNewPassword.PlaceholderText = ""
        txbxNewPassword.SelectedText = ""
        txbxNewPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txbxNewPassword.Size = New Size(200, 36)
        txbxNewPassword.TabIndex = 0
        ' 
        ' txbxOldPass
        ' 
        txbxOldPass.CustomizableEdges = CustomizableEdges7
        txbxOldPass.DefaultText = ""
        txbxOldPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxOldPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxOldPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxOldPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxOldPass.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxOldPass.Font = New Font("Segoe UI", 9.0F)
        txbxOldPass.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxOldPass.Location = New Point(12, 54)
        txbxOldPass.Name = "txbxOldPass"
        txbxOldPass.PasswordChar = ChrW(0)
        txbxOldPass.PlaceholderText = ""
        txbxOldPass.SelectedText = ""
        txbxOldPass.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txbxOldPass.Size = New Size(200, 36)
        txbxOldPass.TabIndex = 1
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 102)
        Controls.Add(txbxOldPass)
        Controls.Add(txbxNewPassword)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "ChangePassword"
        Text = "Change Password"
        ResumeLayout(False)
    End Sub

    Friend WithEvents txbxNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbxOldPass As Guna.UI2.WinForms.Guna2TextBox
End Class
