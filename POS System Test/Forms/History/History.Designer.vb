<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        txbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgvSaleHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        pnlContainer.SuspendLayout()
        CType(dgvSaleHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(txbxSearch)
        pnlContainer.Controls.Add(dgvSaleHistory)
        pnlContainer.CustomizableEdges = CustomizableEdges3
        pnlContainer.Location = New Point(40, 107)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 4
        ' 
        ' txbxSearch
        ' 
        txbxSearch.CustomizableEdges = CustomizableEdges1
        txbxSearch.DefaultText = ""
        txbxSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSearch.Font = New Font("Segoe UI", 9F)
        txbxSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSearch.Location = New Point(690, 22)
        txbxSearch.Name = "txbxSearch"
        txbxSearch.PasswordChar = ChrW(0)
        txbxSearch.PlaceholderText = "Search"
        txbxSearch.SelectedText = ""
        txbxSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxSearch.Size = New Size(200, 36)
        txbxSearch.TabIndex = 7
        ' 
        ' dgvSaleHistory
        ' 
        dgvSaleHistory.AllowUserToAddRows = False
        dgvSaleHistory.AllowUserToDeleteRows = False
        dgvSaleHistory.AllowUserToResizeColumns = False
        dgvSaleHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvSaleHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvSaleHistory.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvSaleHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvSaleHistory.ColumnHeadersHeight = 17
        dgvSaleHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvSaleHistory.DefaultCellStyle = DataGridViewCellStyle3
        dgvSaleHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvSaleHistory.Location = New Point(30, 75)
        dgvSaleHistory.Name = "dgvSaleHistory"
        dgvSaleHistory.ReadOnly = True
        dgvSaleHistory.RowHeadersVisible = False
        dgvSaleHistory.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvSaleHistory.Size = New Size(860, 475)
        dgvSaleHistory.TabIndex = 5
        dgvSaleHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvSaleHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvSaleHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvSaleHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvSaleHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvSaleHistory.ThemeStyle.BackColor = Color.White
        dgvSaleHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvSaleHistory.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvSaleHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvSaleHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvSaleHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvSaleHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvSaleHistory.ThemeStyle.HeaderStyle.Height = 17
        dgvSaleHistory.ThemeStyle.ReadOnly = True
        dgvSaleHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvSaleHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSaleHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvSaleHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvSaleHistory.ThemeStyle.RowsStyle.Height = 25
        dgvSaleHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvSaleHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "History"
        Text = "History"
        pnlContainer.ResumeLayout(False)
        CType(dgvSaleHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvSaleHistory As Guna.UI2.WinForms.Guna2DataGridView
End Class
