<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        pnlDashBoardContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        SuspendLayout()
        ' 
        ' pnlDashBoardContainer
        ' 
        pnlDashBoardContainer.BorderRadius = 25
        pnlDashBoardContainer.CustomizableEdges = CustomizableEdges3
        pnlDashBoardContainer.Location = New Point(50, 50)
        pnlDashBoardContainer.Name = "pnlDashBoardContainer"
        pnlDashBoardContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlDashBoardContainer.Size = New Size(920, 575)
        pnlDashBoardContainer.TabIndex = 2
        ' 
        ' Expenses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlDashBoardContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Expenses"
        Text = "Expenses"
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashBoardContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
