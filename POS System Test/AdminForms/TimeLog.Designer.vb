<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeLog
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        dgvTimeLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        lbUser = New Label()
        cbxUsers = New ComboBox()
        pnlContainer.SuspendLayout()
        CType(dgvTimeLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(dgvTimeLogs)
        pnlContainer.Controls.Add(lbUser)
        pnlContainer.Controls.Add(cbxUsers)
        pnlContainer.CustomizableEdges = CustomizableEdges1
        pnlContainer.Location = New Point(48, 29)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 4
        ' 
        ' dgvTimeLogs
        ' 
        dgvTimeLogs.AllowUserToAddRows = False
        dgvTimeLogs.AllowUserToDeleteRows = False
        dgvTimeLogs.AllowUserToResizeColumns = False
        dgvTimeLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTimeLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTimeLogs.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTimeLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTimeLogs.ColumnHeadersHeight = 17
        dgvTimeLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTimeLogs.DefaultCellStyle = DataGridViewCellStyle3
        dgvTimeLogs.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTimeLogs.Location = New Point(50, 77)
        dgvTimeLogs.Name = "dgvTimeLogs"
        dgvTimeLogs.ReadOnly = True
        dgvTimeLogs.RowHeadersVisible = False
        dgvTimeLogs.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvTimeLogs.Size = New Size(800, 389)
        dgvTimeLogs.TabIndex = 5
        dgvTimeLogs.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTimeLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTimeLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTimeLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTimeLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTimeLogs.ThemeStyle.BackColor = Color.White
        dgvTimeLogs.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTimeLogs.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvTimeLogs.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTimeLogs.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvTimeLogs.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTimeLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvTimeLogs.ThemeStyle.HeaderStyle.Height = 17
        dgvTimeLogs.ThemeStyle.ReadOnly = True
        dgvTimeLogs.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvTimeLogs.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTimeLogs.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvTimeLogs.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvTimeLogs.ThemeStyle.RowsStyle.Height = 25
        dgvTimeLogs.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTimeLogs.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lbUser
        ' 
        lbUser.AutoSize = True
        lbUser.BackColor = Color.Transparent
        lbUser.Location = New Point(50, 16)
        lbUser.Name = "lbUser"
        lbUser.Size = New Size(30, 15)
        lbUser.TabIndex = 4
        lbUser.Text = "User"
        ' 
        ' cbxUsers
        ' 
        cbxUsers.AutoCompleteCustomSource.AddRange(New String() {"All"})
        cbxUsers.DropDownStyle = ComboBoxStyle.DropDownList
        cbxUsers.FormattingEnabled = True
        cbxUsers.Location = New Point(50, 34)
        cbxUsers.Name = "cbxUsers"
        cbxUsers.Size = New Size(128, 23)
        cbxUsers.TabIndex = 3
        cbxUsers.TabStop = False
        ' 
        ' TimeLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "TimeLog"
        Text = "TimeLog"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        CType(dgvTimeLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents dgvTimeLogs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbUser As Label
    Friend WithEvents cbxUsers As ComboBox
End Class
