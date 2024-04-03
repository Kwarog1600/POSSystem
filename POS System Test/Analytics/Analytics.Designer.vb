<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analytics
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
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.CustomizableEdges = CustomizableEdges1
        pnlContainer.Location = New Point(40, 107)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 4
        ' 
        ' Analytics
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Analytics"
        Text = "Analytics"
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
