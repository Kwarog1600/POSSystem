<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockHistory
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvHistory.ColumnHeadersHeight = 17
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
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
        dgvHistory.Size = New Size(890, 290)
        dgvHistory.TabIndex = 0
        dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvHistory.ThemeStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
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
        ' StockHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 317)
        Controls.Add(dgvHistory)
        Name = "StockHistory"
        Text = "StockHistory"
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvHistory As Guna.UI2.WinForms.Guna2DataGridView
End Class
