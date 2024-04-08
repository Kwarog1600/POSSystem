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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        txbxSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgvExpenseList = New Guna.UI2.WinForms.Guna2DataGridView()
        btAddExpenses = New Guna.UI2.WinForms.Guna2Button()
        pnlContainer.SuspendLayout()
        CType(dgvExpenseList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(txbxSearch)
        pnlContainer.Controls.Add(dgvExpenseList)
        pnlContainer.Controls.Add(btAddExpenses)
        pnlContainer.CustomizableEdges = CustomizableEdges5
        pnlContainer.Location = New Point(47, 47)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges6
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
        txbxSearch.Location = New Point(59, 54)
        txbxSearch.Name = "txbxSearch"
        txbxSearch.PasswordChar = ChrW(0)
        txbxSearch.PlaceholderText = "Search"
        txbxSearch.SelectedText = ""
        txbxSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txbxSearch.Size = New Size(321, 36)
        txbxSearch.TabIndex = 7
        ' 
        ' dgvExpenseList
        ' 
        dgvExpenseList.AllowUserToAddRows = False
        dgvExpenseList.AllowUserToDeleteRows = False
        dgvExpenseList.AllowUserToResizeColumns = False
        dgvExpenseList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvExpenseList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvExpenseList.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvExpenseList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvExpenseList.ColumnHeadersHeight = 17
        dgvExpenseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvExpenseList.DefaultCellStyle = DataGridViewCellStyle3
        dgvExpenseList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvExpenseList.Location = New Point(59, 105)
        dgvExpenseList.Name = "dgvExpenseList"
        dgvExpenseList.ReadOnly = True
        dgvExpenseList.RowHeadersVisible = False
        dgvExpenseList.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvExpenseList.Size = New Size(800, 446)
        dgvExpenseList.TabIndex = 5
        dgvExpenseList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvExpenseList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvExpenseList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvExpenseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvExpenseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvExpenseList.ThemeStyle.BackColor = Color.White
        dgvExpenseList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvExpenseList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvExpenseList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvExpenseList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvExpenseList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvExpenseList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvExpenseList.ThemeStyle.HeaderStyle.Height = 17
        dgvExpenseList.ThemeStyle.ReadOnly = True
        dgvExpenseList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvExpenseList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvExpenseList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvExpenseList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvExpenseList.ThemeStyle.RowsStyle.Height = 25
        dgvExpenseList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvExpenseList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btAddExpenses
        ' 
        btAddExpenses.BackColor = Color.Transparent
        btAddExpenses.CustomizableEdges = CustomizableEdges3
        btAddExpenses.DisabledState.BorderColor = Color.DarkGray
        btAddExpenses.DisabledState.CustomBorderColor = Color.DarkGray
        btAddExpenses.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAddExpenses.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAddExpenses.FillColor = Color.DimGray
        btAddExpenses.Font = New Font("Segoe UI", 9F)
        btAddExpenses.ForeColor = Color.White
        btAddExpenses.Location = New Point(679, 45)
        btAddExpenses.Name = "btAddExpenses"
        btAddExpenses.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAddExpenses.Size = New Size(180, 45)
        btAddExpenses.TabIndex = 2
        btAddExpenses.Text = "Add Expense"
        ' 
        ' Expenses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1000, 788)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Expenses"
        Text = "Expenses"
        pnlContainer.ResumeLayout(False)
        CType(dgvExpenseList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txbxSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvExpenseList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btAddExpenses As Guna.UI2.WinForms.Guna2Button
End Class
