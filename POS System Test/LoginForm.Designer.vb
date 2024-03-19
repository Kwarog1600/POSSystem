<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlMain = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        btClose = New Guna.UI2.WinForms.Guna2Button()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        lblWelcMsg = New Label()
        pnlLogIn = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        lblLogin = New Label()
        btLogin = New Guna.UI2.WinForms.Guna2Button()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        pnlMain.SuspendLayout()
        pnlContainer.SuspendLayout()
        pnlLogIn.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(btClose)
        pnlMain.Controls.Add(pnlContainer)
        pnlMain.CustomizableEdges = CustomizableEdges13
        pnlMain.FillColor2 = Color.DarkSlateGray
        pnlMain.FillColor4 = Color.DarkSlateGray
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        pnlMain.Size = New Size(800, 450)
        pnlMain.TabIndex = 0
        ' 
        ' btClose
        ' 
        btClose.BackColor = Color.Transparent
        btClose.BorderRadius = 25
        btClose.CustomizableEdges = CustomizableEdges1
        btClose.DisabledState.BorderColor = Color.DarkGray
        btClose.DisabledState.CustomBorderColor = Color.DarkGray
        btClose.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btClose.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btClose.FillColor = Color.Transparent
        btClose.Font = New Font("Segoe UI", 20.0F)
        btClose.ForeColor = Color.Silver
        btClose.Location = New Point(747, 3)
        btClose.Name = "btClose"
        btClose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btClose.Size = New Size(50, 50)
        btClose.TabIndex = 1
        btClose.Text = "✖"
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BackColor = Color.Transparent
        pnlContainer.BorderColor = Color.Transparent
        pnlContainer.BorderRadius = 20
        pnlContainer.Controls.Add(lblWelcMsg)
        pnlContainer.Controls.Add(pnlLogIn)
        pnlContainer.CustomizableEdges = CustomizableEdges11
        pnlContainer.FillColor = Color.LightGray
        pnlContainer.FillColor2 = Color.LightGray
        pnlContainer.Location = New Point(150, 75)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlContainer.Size = New Size(500, 300)
        pnlContainer.TabIndex = 0
        ' 
        ' lblWelcMsg
        ' 
        lblWelcMsg.AutoSize = True
        lblWelcMsg.Font = New Font("HP Simplified Hans", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcMsg.Location = New Point(26, 26)
        lblWelcMsg.Name = "lblWelcMsg"
        lblWelcMsg.Size = New Size(157, 37)
        lblWelcMsg.TabIndex = 1
        lblWelcMsg.Text = "Welcome!"
        ' 
        ' pnlLogIn
        ' 
        pnlLogIn.BackColor = Color.Transparent
        pnlLogIn.BorderColor = Color.Transparent
        pnlLogIn.BorderRadius = 20
        pnlLogIn.Controls.Add(lblLogin)
        pnlLogIn.Controls.Add(btLogin)
        pnlLogIn.Controls.Add(Guna2TextBox2)
        pnlLogIn.Controls.Add(Guna2TextBox1)
        pnlLogIn.CustomizableEdges = CustomizableEdges9
        pnlLogIn.FillColor2 = Color.DarkSlateGray
        pnlLogIn.FillColor3 = Color.LightGray
        pnlLogIn.FillColor4 = Color.Transparent
        pnlLogIn.Location = New Point(250, 0)
        pnlLogIn.Name = "pnlLogIn"
        pnlLogIn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlLogIn.Size = New Size(250, 300)
        pnlLogIn.TabIndex = 0
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("HP Simplified Hans", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(80, 26)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(95, 37)
        lblLogin.TabIndex = 2
        lblLogin.Text = "Login"
        ' 
        ' btLogin
        ' 
        btLogin.BorderRadius = 25
        btLogin.CustomizableEdges = CustomizableEdges3
        btLogin.DisabledState.BorderColor = Color.DarkGray
        btLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btLogin.Font = New Font("Segoe UI", 9.0F)
        btLogin.ForeColor = Color.White
        btLogin.Location = New Point(35, 215)
        btLogin.Name = "btLogin"
        btLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btLogin.Size = New Size(180, 50)
        btLogin.TabIndex = 1
        btLogin.Text = "Log In"
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BorderRadius = 20
        Guna2TextBox2.CustomizableEdges = CustomizableEdges5
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9.0F)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(25, 145)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = "•"c
        Guna2TextBox2.PlaceholderText = "Password"
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TextBox2.Size = New Size(200, 36)
        Guna2TextBox2.TabIndex = 1
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderRadius = 20
        Guna2TextBox1.CustomizableEdges = CustomizableEdges7
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9.0F)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(25, 88)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Login"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2TextBox1.Size = New Size(200, 36)
        Guna2TextBox1.TabIndex = 0
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        ClientSize = New Size(800, 450)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.Manual
        Text = "Form1"
        pnlMain.ResumeLayout(False)
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        pnlLogIn.ResumeLayout(False)
        pnlLogIn.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents pnlLogIn As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblWelcMsg As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents btLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btClose As Guna.UI2.WinForms.Guna2Button

End Class
