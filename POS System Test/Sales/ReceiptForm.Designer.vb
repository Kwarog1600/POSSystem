<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptForm
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
        dgvReceipt = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgvReceipt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReceipt
        ' 
        dgvReceipt.AllowUserToAddRows = False
        dgvReceipt.AllowUserToDeleteRows = False
        dgvReceipt.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvReceipt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Transparent
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 1F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvReceipt.ColumnHeadersHeight = 4
        dgvReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvReceipt.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvReceipt.DefaultCellStyle = DataGridViewCellStyle3
        dgvReceipt.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvReceipt.Location = New Point(12, 12)
        dgvReceipt.Name = "dgvReceipt"
        dgvReceipt.RowHeadersVisible = False
        dgvReceipt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvReceipt.RowTemplate.ReadOnly = True
        dgvReceipt.RowTemplate.Resizable = DataGridViewTriState.False
        dgvReceipt.Size = New Size(402, 426)
        dgvReceipt.TabIndex = 0
        dgvReceipt.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvReceipt.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvReceipt.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvReceipt.ThemeStyle.BackColor = Color.White
        dgvReceipt.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvReceipt.ThemeStyle.HeaderStyle.BackColor = Color.Transparent
        dgvReceipt.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvReceipt.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 1F)
        dgvReceipt.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvReceipt.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvReceipt.ThemeStyle.HeaderStyle.Height = 4
        dgvReceipt.ThemeStyle.ReadOnly = False
        dgvReceipt.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvReceipt.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvReceipt.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvReceipt.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvReceipt.ThemeStyle.RowsStyle.Height = 25
        dgvReceipt.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvReceipt.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 450)
        Controls.Add(dgvReceipt)
        Name = "ReceiptForm"
        Text = "ReceiptForm"
        CType(dgvReceipt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvReceipt As Guna.UI2.WinForms.Guna2DataGridView
End Class
