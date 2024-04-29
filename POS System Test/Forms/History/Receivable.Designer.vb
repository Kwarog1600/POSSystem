<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receivable
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txbxAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        txbxRef = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        txbxAmtPd = New Guna.UI2.WinForms.Guna2TextBox()
        Label5 = New Label()
        btConfirm = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' txbxAmount
        ' 
        txbxAmount.CustomizableEdges = CustomizableEdges1
        txbxAmount.DefaultText = ""
        txbxAmount.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxAmount.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxAmount.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmount.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmount.Font = New Font("Segoe UI", 9F)
        txbxAmount.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmount.Location = New Point(221, 36)
        txbxAmount.Name = "txbxAmount"
        txbxAmount.PasswordChar = ChrW(0)
        txbxAmount.PlaceholderText = ""
        txbxAmount.ReadOnly = True
        txbxAmount.SelectedText = ""
        txbxAmount.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxAmount.Size = New Size(200, 36)
        txbxAmount.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(221, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 2
        Label2.Text = "Balance"
        ' 
        ' txbxRef
        ' 
        txbxRef.CustomizableEdges = CustomizableEdges3
        txbxRef.DefaultText = ""
        txbxRef.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxRef.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxRef.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxRef.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxRef.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxRef.Font = New Font("Segoe UI", 9F)
        txbxRef.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxRef.Location = New Point(15, 36)
        txbxRef.Name = "txbxRef"
        txbxRef.PasswordChar = ChrW(0)
        txbxRef.PlaceholderText = ""
        txbxRef.ReadOnly = True
        txbxRef.SelectedText = ""
        txbxRef.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxRef.Size = New Size(200, 36)
        txbxRef.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 4
        Label3.Text = "Reference"
        ' 
        ' txbxAmtPd
        ' 
        txbxAmtPd.CustomizableEdges = CustomizableEdges5
        txbxAmtPd.DefaultText = ""
        txbxAmtPd.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxAmtPd.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxAmtPd.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmtPd.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxAmtPd.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmtPd.Font = New Font("Segoe UI", 9F)
        txbxAmtPd.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxAmtPd.Location = New Point(15, 111)
        txbxAmtPd.Name = "txbxAmtPd"
        txbxAmtPd.PasswordChar = ChrW(0)
        txbxAmtPd.PlaceholderText = ""
        txbxAmtPd.SelectedText = ""
        txbxAmtPd.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txbxAmtPd.Size = New Size(200, 36)
        txbxAmtPd.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 8
        Label5.Text = "Amount Paid"
        ' 
        ' btConfirm
        ' 
        btConfirm.BackColor = Color.Transparent
        btConfirm.CustomizableEdges = CustomizableEdges7
        btConfirm.DisabledState.BorderColor = Color.DarkGray
        btConfirm.DisabledState.CustomBorderColor = Color.DarkGray
        btConfirm.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btConfirm.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btConfirm.FillColor = Color.DimGray
        btConfirm.Font = New Font("Segoe UI", 9F)
        btConfirm.ForeColor = Color.White
        btConfirm.Location = New Point(221, 111)
        btConfirm.Name = "btConfirm"
        btConfirm.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btConfirm.Size = New Size(77, 36)
        btConfirm.TabIndex = 44
        btConfirm.Text = "Confirm"
        ' 
        ' Receivable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 159)
        Controls.Add(btConfirm)
        Controls.Add(txbxAmtPd)
        Controls.Add(Label5)
        Controls.Add(txbxRef)
        Controls.Add(Label3)
        Controls.Add(txbxAmount)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Receivable"
        Text = "Sale"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txbxAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbxRef As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbxAmtPd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btConfirm As Guna.UI2.WinForms.Guna2Button
End Class
