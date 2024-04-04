<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        lbBestSellers = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        pnlContainer.SuspendLayout()
        Guna2CustomGradientPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(Guna2CustomGradientPanel2)
        pnlContainer.CustomizableEdges = CustomizableEdges3
        pnlContainer.Location = New Point(12, 10)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 1
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.BackColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderRadius = 25
        Guna2CustomGradientPanel2.Controls.Add(Label1)
        Guna2CustomGradientPanel2.Controls.Add(Label2)
        Guna2CustomGradientPanel2.Controls.Add(Label5)
        Guna2CustomGradientPanel2.Controls.Add(Label6)
        Guna2CustomGradientPanel2.Controls.Add(Label8)
        Guna2CustomGradientPanel2.Controls.Add(lbBestSellers)
        Guna2CustomGradientPanel2.Controls.Add(Label10)
        Guna2CustomGradientPanel2.Controls.Add(Label12)
        Guna2CustomGradientPanel2.Controls.Add(Label13)
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges1
        Guna2CustomGradientPanel2.FillColor = Color.Silver
        Guna2CustomGradientPanel2.FillColor3 = Color.Silver
        Guna2CustomGradientPanel2.Location = New Point(562, 101)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomGradientPanel2.Size = New Size(200, 200)
        Guna2CustomGradientPanel2.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(140, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 10
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 15)
        Label2.TabIndex = 9
        Label2.Text = "4."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(140, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 6
        Label5.Text = "Label1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(140, 90)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 5
        Label6.Text = "Label1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(140, 60)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 4
        Label8.Text = "Label1"
        ' 
        ' lbBestSellers
        ' 
        lbBestSellers.AutoSize = True
        lbBestSellers.Location = New Point(66, 15)
        lbBestSellers.Name = "lbBestSellers"
        lbBestSellers.Size = New Size(65, 15)
        lbBestSellers.TabIndex = 3
        lbBestSellers.Text = "Best Sellers"
        lbBestSellers.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(25, 120)
        Label10.Name = "Label10"
        Label10.Size = New Size(16, 15)
        Label10.TabIndex = 2
        Label10.Text = "3."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(25, 90)
        Label12.Name = "Label12"
        Label12.Size = New Size(16, 15)
        Label12.TabIndex = 1
        Label12.Text = "2."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(25, 60)
        Label13.Name = "Label13"
        Label13.Size = New Size(16, 15)
        Label13.TabIndex = 0
        Label13.Text = "1."
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(968, 701)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Form1"
        pnlContainer.ResumeLayout(False)
        Guna2CustomGradientPanel2.ResumeLayout(False)
        Guna2CustomGradientPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbBestSellers As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
