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
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomGradientPanel5 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        lbMonthlyExpense = New Label()
        Label3 = New Label()
        Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        TotalSold = New Label()
        Label6 = New Label()
        Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        TotalExpenses = New Label()
        Label4 = New Label()
        Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        CurrentCash = New Label()
        Label2 = New Label()
        lbCash = New Label()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        ttlStockCount = New Label()
        lbAvailable = New Label()
        pnlContainer.SuspendLayout()
        Guna2CustomGradientPanel5.SuspendLayout()
        Guna2CustomGradientPanel4.SuspendLayout()
        Guna2CustomGradientPanel3.SuspendLayout()
        Guna2CustomGradientPanel2.SuspendLayout()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(Guna2CustomGradientPanel5)
        pnlContainer.Controls.Add(Guna2CustomGradientPanel4)
        pnlContainer.Controls.Add(Guna2CustomGradientPanel3)
        pnlContainer.Controls.Add(Guna2CustomGradientPanel2)
        pnlContainer.Controls.Add(Guna2CustomGradientPanel1)
        pnlContainer.CustomizableEdges = CustomizableEdges23
        pnlContainer.Location = New Point(36, 45)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 4
        ' 
        ' Guna2CustomGradientPanel5
        ' 
        Guna2CustomGradientPanel5.BackColor = Color.Transparent
        Guna2CustomGradientPanel5.BorderRadius = 25
        Guna2CustomGradientPanel5.Controls.Add(lbMonthlyExpense)
        Guna2CustomGradientPanel5.Controls.Add(Label3)
        Guna2CustomGradientPanel5.CustomizableEdges = CustomizableEdges13
        Guna2CustomGradientPanel5.FillColor = Color.LightGray
        Guna2CustomGradientPanel5.FillColor3 = Color.LightGray
        Guna2CustomGradientPanel5.Location = New Point(491, 308)
        Guna2CustomGradientPanel5.Name = "Guna2CustomGradientPanel5"
        Guna2CustomGradientPanel5.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2CustomGradientPanel5.Size = New Size(250, 250)
        Guna2CustomGradientPanel5.TabIndex = 12
        ' 
        ' lbMonthlyExpense
        ' 
        lbMonthlyExpense.AutoSize = True
        lbMonthlyExpense.Font = New Font("Segoe UI", 25F)
        lbMonthlyExpense.Location = New Point(95, 100)
        lbMonthlyExpense.Name = "lbMonthlyExpense"
        lbMonthlyExpense.Size = New Size(74, 46)
        lbMonthlyExpense.TabIndex = 9
        lbMonthlyExpense.Text = "000"
        lbMonthlyExpense.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 15)
        Label3.TabIndex = 8
        Label3.Text = "Total Month Expenses"
        ' 
        ' Guna2CustomGradientPanel4
        ' 
        Guna2CustomGradientPanel4.BackColor = Color.Transparent
        Guna2CustomGradientPanel4.BorderRadius = 25
        Guna2CustomGradientPanel4.Controls.Add(TotalSold)
        Guna2CustomGradientPanel4.Controls.Add(Label6)
        Guna2CustomGradientPanel4.CustomizableEdges = CustomizableEdges15
        Guna2CustomGradientPanel4.FillColor = Color.LightGray
        Guna2CustomGradientPanel4.FillColor3 = Color.LightGray
        Guna2CustomGradientPanel4.Location = New Point(185, 308)
        Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Guna2CustomGradientPanel4.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2CustomGradientPanel4.Size = New Size(250, 250)
        Guna2CustomGradientPanel4.TabIndex = 12
        ' 
        ' TotalSold
        ' 
        TotalSold.AutoSize = True
        TotalSold.Font = New Font("Segoe UI", 25F)
        TotalSold.Location = New Point(95, 100)
        TotalSold.Name = "TotalSold"
        TotalSold.Size = New Size(74, 46)
        TotalSold.TabIndex = 9
        TotalSold.Text = "000"
        TotalSold.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(50, 50)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 15)
        Label6.TabIndex = 8
        Label6.Text = "Total Amount Sold"
        ' 
        ' Guna2CustomGradientPanel3
        ' 
        Guna2CustomGradientPanel3.BackColor = Color.Transparent
        Guna2CustomGradientPanel3.BorderRadius = 25
        Guna2CustomGradientPanel3.Controls.Add(TotalExpenses)
        Guna2CustomGradientPanel3.Controls.Add(Label4)
        Guna2CustomGradientPanel3.CustomizableEdges = CustomizableEdges17
        Guna2CustomGradientPanel3.FillColor = Color.LightGray
        Guna2CustomGradientPanel3.FillColor3 = Color.LightGray
        Guna2CustomGradientPanel3.Location = New Point(620, 52)
        Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2CustomGradientPanel3.Size = New Size(250, 250)
        Guna2CustomGradientPanel3.TabIndex = 11
        ' 
        ' TotalExpenses
        ' 
        TotalExpenses.AutoSize = True
        TotalExpenses.Font = New Font("Segoe UI", 25F)
        TotalExpenses.Location = New Point(95, 100)
        TotalExpenses.Name = "TotalExpenses"
        TotalExpenses.Size = New Size(74, 46)
        TotalExpenses.TabIndex = 9
        TotalExpenses.Text = "000"
        TotalExpenses.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 15)
        Label4.TabIndex = 8
        Label4.Text = "Expenses of the Day"
        ' 
        ' Guna2CustomGradientPanel2
        ' 
        Guna2CustomGradientPanel2.BackColor = Color.Transparent
        Guna2CustomGradientPanel2.BorderRadius = 25
        Guna2CustomGradientPanel2.Controls.Add(CurrentCash)
        Guna2CustomGradientPanel2.Controls.Add(Label2)
        Guna2CustomGradientPanel2.Controls.Add(lbCash)
        Guna2CustomGradientPanel2.CustomizableEdges = CustomizableEdges19
        Guna2CustomGradientPanel2.FillColor = Color.LightGray
        Guna2CustomGradientPanel2.FillColor3 = Color.LightGray
        Guna2CustomGradientPanel2.Location = New Point(339, 52)
        Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2CustomGradientPanel2.Size = New Size(250, 250)
        Guna2CustomGradientPanel2.TabIndex = 10
        ' 
        ' CurrentCash
        ' 
        CurrentCash.AutoSize = True
        CurrentCash.Font = New Font("Segoe UI", 25F)
        CurrentCash.Location = New Point(95, 100)
        CurrentCash.Name = "CurrentCash"
        CurrentCash.Size = New Size(74, 46)
        CurrentCash.TabIndex = 10
        CurrentCash.Text = "000"
        CurrentCash.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 25F)
        Label2.Location = New Point(91, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 46)
        Label2.TabIndex = 9
        Label2.Text = "000"
        ' 
        ' lbCash
        ' 
        lbCash.AutoSize = True
        lbCash.Location = New Point(50, 50)
        lbCash.Name = "lbCash"
        lbCash.Size = New Size(76, 15)
        lbCash.TabIndex = 8
        lbCash.Text = "Current Cash"
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BackColor = Color.Transparent
        Guna2CustomGradientPanel1.BorderRadius = 25
        Guna2CustomGradientPanel1.Controls.Add(ttlStockCount)
        Guna2CustomGradientPanel1.Controls.Add(lbAvailable)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges21
        Guna2CustomGradientPanel1.FillColor = Color.LightGray
        Guna2CustomGradientPanel1.FillColor3 = Color.LightGray
        Guna2CustomGradientPanel1.Location = New Point(55, 52)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2CustomGradientPanel1.Size = New Size(250, 250)
        Guna2CustomGradientPanel1.TabIndex = 5
        ' 
        ' ttlStockCount
        ' 
        ttlStockCount.AutoSize = True
        ttlStockCount.Font = New Font("Segoe UI", 25F)
        ttlStockCount.Location = New Point(95, 100)
        ttlStockCount.Name = "ttlStockCount"
        ttlStockCount.Size = New Size(74, 46)
        ttlStockCount.TabIndex = 9
        ttlStockCount.Text = "000"
        ttlStockCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbAvailable
        ' 
        lbAvailable.AutoSize = True
        lbAvailable.Location = New Point(50, 50)
        lbAvailable.Name = "lbAvailable"
        lbAvailable.Size = New Size(115, 15)
        lbAvailable.TabIndex = 8
        lbAvailable.Text = "Total Available Stock"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(993, 665)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        pnlContainer.ResumeLayout(False)
        Guna2CustomGradientPanel5.ResumeLayout(False)
        Guna2CustomGradientPanel5.PerformLayout()
        Guna2CustomGradientPanel4.ResumeLayout(False)
        Guna2CustomGradientPanel4.PerformLayout()
        Guna2CustomGradientPanel3.ResumeLayout(False)
        Guna2CustomGradientPanel3.PerformLayout()
        Guna2CustomGradientPanel2.ResumeLayout(False)
        Guna2CustomGradientPanel2.PerformLayout()
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents ttlStockCount As Label
    Friend WithEvents lbAvailable As Label
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TotalSold As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TotalExpenses As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCash As Label
    Friend WithEvents CurrentCash As Label
    Friend WithEvents Guna2CustomGradientPanel5 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbMonthlyExpense As Label
    Friend WithEvents Label3 As Label
End Class
