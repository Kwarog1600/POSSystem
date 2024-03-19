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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label3 = New Label()
        Label4 = New Label()
        lbCount = New Label()
        lbWCount = New Label()
        lbDCount = New Label()
        lbTitle = New Label()
        lbMonthlyAvg = New Label()
        lbWeeklyAvg = New Label()
        lbToday = New Label()
        pnlDashBoardContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Label7 = New Label()
        lblInvtry = New Label()
        Label11 = New Label()
        Guna2CustomGradientPanel1.SuspendLayout()
        pnlDashBoardContainer.SuspendLayout()
        Guna2CustomGradientPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderRadius = 25
        Guna2CustomGradientPanel1.Controls.Add(Label3)
        Guna2CustomGradientPanel1.Controls.Add(Label4)
        Guna2CustomGradientPanel1.Controls.Add(lbCount)
        Guna2CustomGradientPanel1.Controls.Add(lbWCount)
        Guna2CustomGradientPanel1.Controls.Add(lbDCount)
        Guna2CustomGradientPanel1.Controls.Add(lbTitle)
        Guna2CustomGradientPanel1.Controls.Add(lbMonthlyAvg)
        Guna2CustomGradientPanel1.Controls.Add(lbWeeklyAvg)
        Guna2CustomGradientPanel1.Controls.Add(lbToday)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2CustomGradientPanel1.FillColor = Color.Silver
        Guna2CustomGradientPanel1.FillColor3 = Color.Silver
        Guna2CustomGradientPanel1.Location = New Point(71, 64)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2CustomGradientPanel1.Size = New Size(200, 200)
        Guna2CustomGradientPanel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(140, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 10
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 9
        Label4.Text = "Total"
        ' 
        ' lbCount
        ' 
        lbCount.AutoSize = True
        lbCount.Location = New Point(140, 120)
        lbCount.Name = "lbCount"
        lbCount.Size = New Size(41, 15)
        lbCount.TabIndex = 6
        lbCount.Text = "Label1"
        ' 
        ' lbWCount
        ' 
        lbWCount.AutoSize = True
        lbWCount.Location = New Point(140, 90)
        lbWCount.Name = "lbWCount"
        lbWCount.Size = New Size(41, 15)
        lbWCount.TabIndex = 5
        lbWCount.Text = "Label1"
        ' 
        ' lbDCount
        ' 
        lbDCount.AutoSize = True
        lbDCount.Location = New Point(140, 60)
        lbDCount.Name = "lbDCount"
        lbDCount.Size = New Size(41, 15)
        lbDCount.TabIndex = 4
        lbDCount.Text = "Label1"
        ' 
        ' lbTitle
        ' 
        lbTitle.AutoSize = True
        lbTitle.Location = New Point(87, 15)
        lbTitle.Name = "lbTitle"
        lbTitle.Size = New Size(33, 15)
        lbTitle.TabIndex = 3
        lbTitle.Text = "Sales"
        lbTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbMonthlyAvg
        ' 
        lbMonthlyAvg.AutoSize = True
        lbMonthlyAvg.Location = New Point(25, 120)
        lbMonthlyAvg.Name = "lbMonthlyAvg"
        lbMonthlyAvg.Size = New Size(71, 15)
        lbMonthlyAvg.TabIndex = 2
        lbMonthlyAvg.Text = "Last 30 Days"
        ' 
        ' lbWeeklyAvg
        ' 
        lbWeeklyAvg.AutoSize = True
        lbWeeklyAvg.Location = New Point(25, 90)
        lbWeeklyAvg.Name = "lbWeeklyAvg"
        lbWeeklyAvg.Size = New Size(65, 15)
        lbWeeklyAvg.TabIndex = 1
        lbWeeklyAvg.Text = "Last 7 Days"
        ' 
        ' lbToday
        ' 
        lbToday.AutoSize = True
        lbToday.Location = New Point(25, 60)
        lbToday.Name = "lbToday"
        lbToday.Size = New Size(38, 15)
        lbToday.TabIndex = 0
        lbToday.Text = "Today"
        ' 
        ' pnlDashBoardContainer
        ' 
        pnlDashBoardContainer.BorderRadius = 25
        pnlDashBoardContainer.Controls.Add(Guna2CustomGradientPanel3)
        pnlDashBoardContainer.Controls.Add(Guna2CustomGradientPanel1)
        pnlDashBoardContainer.CustomizableEdges = CustomizableEdges11
        pnlDashBoardContainer.Location = New Point(12, 10)
        pnlDashBoardContainer.Name = "pnlDashBoardContainer"
        pnlDashBoardContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlDashBoardContainer.Size = New Size(920, 575)
        pnlDashBoardContainer.TabIndex = 1
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderRadius = 25
        Guna2CustomGradientPanel3.Controls.Add(Label7)
        Guna2CustomGradientPanel3.Controls.Add(lblInvtry)
        Guna2CustomGradientPanel3.Controls.Add(Label11)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges9
        Guna2CustomGradientPanel3.FillColor = Color.Silver
        Guna2CustomGradientPanel3.FillColor3 = Color.Silver
        Guna2CustomGradientPanel3.Location = New Point(627, 31)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2CustomGradientPanel3.Size = New Size(261, 471)
        Guna2CustomGradientPanel3.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(180, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 4
        Label7.Text = "Label1"
        ' 
        ' lblInvtry
        ' 
        lblInvtry.AutoSize = True
        lblInvtry.Location = New Point(72, 15)
        lblInvtry.Name = "lblInvtry"
        lblInvtry.Size = New Size(57, 15)
        lblInvtry.TabIndex = 3
        lblInvtry.Text = "Inventory"
        lblInvtry.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(25, 60)
        Label11.Name = "Label11"
        Label11.Size = New Size(38, 15)
        Label11.TabIndex = 0
        Label11.Text = "Today"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(968, 701)
        Controls.Add(pnlDashBoardContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Form1"
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        pnlDashBoardContainer.ResumeLayout(False)
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbCount As Label
    Friend WithEvents lbWCount As Label
    Friend WithEvents lbDCount As Label
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbMonthlyAvg As Label
    Friend WithEvents lbWeeklyAvg As Label
    Friend WithEvents lbToday As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlDashBoardContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblInvtry As Label
    Friend WithEvents Label11 As Label
End Class
