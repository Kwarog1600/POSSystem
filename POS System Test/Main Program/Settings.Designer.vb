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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btIPSet = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        GUIColor1 = New ColorDialog()
        GUIColor2 = New ColorDialog()
        swDarkMode = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btIPSet
        ' 
        btIPSet.BorderRadius = 20
        btIPSet.CustomizableEdges = CustomizableEdges1
        btIPSet.DefaultText = ""
        btIPSet.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        btIPSet.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        btIPSet.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        btIPSet.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        btIPSet.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btIPSet.Font = New Font("Segoe UI", 9F)
        btIPSet.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        btIPSet.Location = New Point(43, 55)
        btIPSet.Name = "btIPSet"
        btIPSet.PasswordChar = ChrW(0)
        btIPSet.PlaceholderText = ""
        btIPSet.SelectedText = ""
        btIPSet.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btIPSet.Size = New Size(200, 36)
        btIPSet.TabIndex = 0
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BorderRadius = 20
        Guna2TextBox2.CustomizableEdges = CustomizableEdges3
        Guna2TextBox2.DefaultText = ""
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Location = New Point(43, 136)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox2.Size = New Size(200, 36)
        Guna2TextBox2.TabIndex = 1
        ' 
        ' GUIColor1
        ' 
        GUIColor1.Color = SystemColors.ControlDark
        ' 
        ' swDarkMode
        ' 
        swDarkMode.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        swDarkMode.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        swDarkMode.CheckedState.InnerBorderColor = Color.White
        swDarkMode.CheckedState.InnerColor = Color.White
        swDarkMode.CustomizableEdges = CustomizableEdges5
        swDarkMode.Location = New Point(371, 71)
        swDarkMode.Name = "swDarkMode"
        swDarkMode.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        swDarkMode.Size = New Size(35, 20)
        swDarkMode.TabIndex = 2
        swDarkMode.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        swDarkMode.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        swDarkMode.UncheckedState.InnerBorderColor = Color.White
        swDarkMode.UncheckedState.InnerColor = Color.White
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 25
        Guna2Button1.CustomizableEdges = CustomizableEdges7
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(43, 232)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button1.Size = New Size(180, 45)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "Guna2Button1"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderRadius = 25
        Guna2Button2.CustomizableEdges = CustomizableEdges9
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(270, 314)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button2.Size = New Size(180, 45)
        Guna2Button2.TabIndex = 4
        Guna2Button2.Text = "Guna2Button2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 380)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(swDarkMode)
        Controls.Add(Guna2TextBox2)
        Controls.Add(btIPSet)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Settings"
        Text = "Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btIPSet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GUIColor1 As ColorDialog
    Friend WithEvents GUIColor2 As ColorDialog
    Friend WithEvents swDarkMode As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
