<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchItem
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
        txbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgvStockList = New Guna.UI2.WinForms.Guna2DataGridView()
        lblStockCategory = New Label()
        cbxCategory = New ComboBox()
        CType(dgvStockList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        txbxSearch.Location = New Point(588, 5)
        txbxSearch.Name = "txbxSearch"
        txbxSearch.PasswordChar = ChrW(0)
        txbxSearch.PlaceholderText = "Search"
        txbxSearch.SelectedText = ""
        txbxSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxSearch.Size = New Size(200, 36)
        txbxSearch.TabIndex = 11
        ' 
        ' dgvStockList
        ' 
        dgvStockList.AllowUserToAddRows = False
        dgvStockList.AllowUserToDeleteRows = False
        dgvStockList.AllowUserToResizeColumns = False
        dgvStockList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvStockList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStockList.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStockList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvStockList.ColumnHeadersHeight = 17
        dgvStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvStockList.DefaultCellStyle = DataGridViewCellStyle3
        dgvStockList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.Location = New Point(0, 61)
        dgvStockList.Name = "dgvStockList"
        dgvStockList.ReadOnly = True
        dgvStockList.RowHeadersVisible = False
        dgvStockList.Size = New Size(800, 390)
        dgvStockList.TabIndex = 10
        dgvStockList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvStockList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvStockList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvStockList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvStockList.ThemeStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvStockList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvStockList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvStockList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvStockList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvStockList.ThemeStyle.HeaderStyle.Height = 17
        dgvStockList.ThemeStyle.ReadOnly = True
        dgvStockList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvStockList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvStockList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvStockList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvStockList.ThemeStyle.RowsStyle.Height = 25
        dgvStockList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvStockList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblStockCategory
        ' 
        lblStockCategory.AutoSize = True
        lblStockCategory.BackColor = Color.Transparent
        lblStockCategory.Location = New Point(12, 0)
        lblStockCategory.Name = "lblStockCategory"
        lblStockCategory.Size = New Size(55, 15)
        lblStockCategory.TabIndex = 9
        lblStockCategory.Text = "Category"
        ' 
        ' cbxCategory
        ' 
        cbxCategory.AutoCompleteCustomSource.AddRange(New String() {"All"})
        cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbxCategory.FormattingEnabled = True
        cbxCategory.Location = New Point(12, 18)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(128, 23)
        cbxCategory.TabIndex = 8
        cbxCategory.TabStop = False
        ' 
        ' SearchItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txbxSearch)
        Controls.Add(dgvStockList)
        Controls.Add(lblStockCategory)
        Controls.Add(cbxCategory)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "SearchItem"
        Text = "Search Item"
        TopMost = True
        CType(dgvStockList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvStockList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblStockCategory As Label
    Friend WithEvents cbxCategory As ComboBox
End Class
