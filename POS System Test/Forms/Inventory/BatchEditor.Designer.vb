<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchEditor
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        dgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        lblPrice = New Label()
        txbxBatchCost = New Guna.UI2.WinForms.Guna2TextBox()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Transparent
        btSave.BorderRadius = 25
        btSave.CustomizableEdges = CustomizableEdges1
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(608, 333)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btSave.Size = New Size(180, 45)
        btSave.TabIndex = 4
        btSave.Text = "Save"
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvHistory.ColumnHeadersHeight = 17
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvHistory.DefaultCellStyle = DataGridViewCellStyle3
        dgvHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.Location = New Point(12, 12)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.RowHeadersVisible = False
        dgvHistory.Size = New Size(776, 308)
        dgvHistory.TabIndex = 3
        dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvHistory.ThemeStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvHistory.ThemeStyle.HeaderStyle.Height = 17
        dgvHistory.ThemeStyle.ReadOnly = False
        dgvHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvHistory.ThemeStyle.RowsStyle.Height = 25
        dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(14, 333)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(64, 15)
        lblPrice.TabIndex = 27
        lblPrice.Text = "Batch Cost"
        ' 
        ' txbxBatchCost
        ' 
        txbxBatchCost.CustomizableEdges = CustomizableEdges3
        txbxBatchCost.DefaultText = ""
        txbxBatchCost.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxBatchCost.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxBatchCost.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxBatchCost.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxBatchCost.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxBatchCost.Font = New Font("Segoe UI", 9F)
        txbxBatchCost.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxBatchCost.Location = New Point(84, 333)
        txbxBatchCost.Name = "txbxBatchCost"
        txbxBatchCost.PasswordChar = ChrW(0)
        txbxBatchCost.PlaceholderText = ""
        txbxBatchCost.SelectedText = ""
        txbxBatchCost.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txbxBatchCost.Size = New Size(90, 36)
        txbxBatchCost.TabIndex = 26
        ' 
        ' BatchEditor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 390)
        Controls.Add(lblPrice)
        Controls.Add(txbxBatchCost)
        Controls.Add(btSave)
        Controls.Add(dgvHistory)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "BatchEditor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Batch Editor"
        TopMost = True
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblPrice As Label
    Friend WithEvents txbxBatchCost As Guna.UI2.WinForms.Guna2TextBox
End Class
