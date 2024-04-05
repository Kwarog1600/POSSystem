<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagement
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
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlContainer = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        dgvUserList = New Guna.UI2.WinForms.Guna2DataGridView()
        btDelete = New Guna.UI2.WinForms.Guna2Button()
        btAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        btSave = New Guna.UI2.WinForms.Guna2Button()
        Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        lbUsername = New Label()
        txbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        lbFirstName = New Label()
        txbxFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        lbAccess = New Label()
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        lbLastName = New Label()
        txbxSurname = New Guna.UI2.WinForms.Guna2TextBox()
        lbUsers = New Label()
        btChangePass = New Guna.UI2.WinForms.Guna2Button()
        pnlContainer.SuspendLayout()
        CType(dgvUserList, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BorderRadius = 25
        pnlContainer.Controls.Add(dgvUserList)
        pnlContainer.Controls.Add(btDelete)
        pnlContainer.Controls.Add(btAdd)
        pnlContainer.Controls.Add(Guna2Panel1)
        pnlContainer.Controls.Add(lbUsers)
        pnlContainer.CustomizableEdges = CustomizableEdges21
        pnlContainer.Location = New Point(65, 12)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        pnlContainer.Size = New Size(920, 575)
        pnlContainer.TabIndex = 2
        ' 
        ' dgvUserList
        ' 
        dgvUserList.AllowUserToAddRows = False
        dgvUserList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvUserList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvUserList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvUserList.ColumnHeadersHeight = 4
        dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvUserList.DefaultCellStyle = DataGridViewCellStyle3
        dgvUserList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserList.Location = New Point(45, 92)
        dgvUserList.Name = "dgvUserList"
        dgvUserList.ReadOnly = True
        dgvUserList.RowHeadersVisible = False
        dgvUserList.Size = New Size(240, 324)
        dgvUserList.TabIndex = 7
        dgvUserList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvUserList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvUserList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvUserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvUserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvUserList.ThemeStyle.BackColor = Color.White
        dgvUserList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserList.ThemeStyle.HeaderStyle.BackColor = SystemColors.ButtonShadow
        dgvUserList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvUserList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvUserList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvUserList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvUserList.ThemeStyle.HeaderStyle.Height = 4
        dgvUserList.ThemeStyle.ReadOnly = True
        dgvUserList.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvUserList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUserList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvUserList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvUserList.ThemeStyle.RowsStyle.Height = 25
        dgvUserList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvUserList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btDelete
        ' 
        btDelete.CustomizableEdges = CustomizableEdges1
        btDelete.DisabledState.BorderColor = Color.DarkGray
        btDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btDelete.FillColor = Color.DimGray
        btDelete.Font = New Font("Segoe UI", 9F)
        btDelete.ForeColor = Color.White
        btDelete.Location = New Point(42, 441)
        btDelete.Name = "btDelete"
        btDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btDelete.Size = New Size(113, 45)
        btDelete.TabIndex = 4
        btDelete.Text = "Remove"
        ' 
        ' btAdd
        ' 
        btAdd.CustomizableEdges = CustomizableEdges3
        btAdd.DisabledState.BorderColor = Color.DarkGray
        btAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btAdd.FillColor = Color.DimGray
        btAdd.Font = New Font("Segoe UI", 9F)
        btAdd.ForeColor = Color.White
        btAdd.Location = New Point(172, 441)
        btAdd.Name = "btAdd"
        btAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btAdd.Size = New Size(113, 45)
        btAdd.TabIndex = 3
        btAdd.Text = "Add"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(btChangePass)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(btSave)
        Guna2Panel1.Controls.Add(Guna2TextBox4)
        Guna2Panel1.Controls.Add(lbUsername)
        Guna2Panel1.Controls.Add(txbxUsername)
        Guna2Panel1.Controls.Add(lbFirstName)
        Guna2Panel1.Controls.Add(txbxFirstName)
        Guna2Panel1.Controls.Add(lbAccess)
        Guna2Panel1.Controls.Add(Guna2ComboBox1)
        Guna2Panel1.Controls.Add(lbLastName)
        Guna2Panel1.Controls.Add(txbxSurname)
        Guna2Panel1.CustomizableEdges = CustomizableEdges19
        Guna2Panel1.Location = New Point(386, 92)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2Panel1.Size = New Size(477, 394)
        Guna2Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(286, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 15
        Label1.Text = "User ID"
        ' 
        ' btSave
        ' 
        btSave.CustomizableEdges = CustomizableEdges7
        btSave.DisabledState.BorderColor = Color.DarkGray
        btSave.DisabledState.CustomBorderColor = Color.DarkGray
        btSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btSave.FillColor = Color.DimGray
        btSave.Font = New Font("Segoe UI", 9F)
        btSave.ForeColor = Color.White
        btSave.Location = New Point(304, 303)
        btSave.Name = "btSave"
        btSave.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btSave.Size = New Size(113, 45)
        btSave.TabIndex = 6
        btSave.Text = "Save"
        ' 
        ' Guna2TextBox4
        ' 
        Guna2TextBox4.CustomizableEdges = CustomizableEdges9
        Guna2TextBox4.DefaultText = ""
        Guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Font = New Font("Segoe UI", 9F)
        Guna2TextBox4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox4.Location = New Point(286, 139)
        Guna2TextBox4.Name = "Guna2TextBox4"
        Guna2TextBox4.PasswordChar = ChrW(0)
        Guna2TextBox4.PlaceholderText = ""
        Guna2TextBox4.ReadOnly = True
        Guna2TextBox4.SelectedText = ""
        Guna2TextBox4.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2TextBox4.Size = New Size(140, 36)
        Guna2TextBox4.TabIndex = 14
        ' 
        ' lbUsername
        ' 
        lbUsername.AutoSize = True
        lbUsername.Location = New Point(27, 192)
        lbUsername.Name = "lbUsername"
        lbUsername.Size = New Size(60, 15)
        lbUsername.TabIndex = 12
        lbUsername.Text = "Username"
        ' 
        ' txbxUsername
        ' 
        txbxUsername.CustomizableEdges = CustomizableEdges11
        txbxUsername.DefaultText = ""
        txbxUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxUsername.Font = New Font("Segoe UI", 9F)
        txbxUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxUsername.Location = New Point(27, 210)
        txbxUsername.Name = "txbxUsername"
        txbxUsername.PasswordChar = ChrW(0)
        txbxUsername.PlaceholderText = ""
        txbxUsername.SelectedText = ""
        txbxUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txbxUsername.Size = New Size(200, 36)
        txbxUsername.TabIndex = 11
        ' 
        ' lbFirstName
        ' 
        lbFirstName.AutoSize = True
        lbFirstName.Location = New Point(27, 121)
        lbFirstName.Name = "lbFirstName"
        lbFirstName.Size = New Size(64, 15)
        lbFirstName.TabIndex = 10
        lbFirstName.Text = "First Name"
        ' 
        ' txbxFirstName
        ' 
        txbxFirstName.CustomizableEdges = CustomizableEdges13
        txbxFirstName.DefaultText = ""
        txbxFirstName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxFirstName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxFirstName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxFirstName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxFirstName.Font = New Font("Segoe UI", 9F)
        txbxFirstName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxFirstName.Location = New Point(27, 139)
        txbxFirstName.Name = "txbxFirstName"
        txbxFirstName.PasswordChar = ChrW(0)
        txbxFirstName.PlaceholderText = ""
        txbxFirstName.SelectedText = ""
        txbxFirstName.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txbxFirstName.Size = New Size(200, 36)
        txbxFirstName.TabIndex = 9
        ' 
        ' lbAccess
        ' 
        lbAccess.AutoSize = True
        lbAccess.Location = New Point(286, 52)
        lbAccess.Name = "lbAccess"
        lbAccess.Size = New Size(73, 15)
        lbAccess.TabIndex = 8
        lbAccess.Text = "Access Level"
        ' 
        ' Guna2ComboBox1
        ' 
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2ComboBox1.CustomizableEdges = CustomizableEdges15
        Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Guna2ComboBox1.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.Font = New Font("Segoe UI", 10F)
        Guna2ComboBox1.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        Guna2ComboBox1.ItemHeight = 30
        Guna2ComboBox1.Items.AddRange(New Object() {"1", "2", "3"})
        Guna2ComboBox1.Location = New Point(286, 70)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2ComboBox1.Size = New Size(140, 36)
        Guna2ComboBox1.TabIndex = 3
        ' 
        ' lbLastName
        ' 
        lbLastName.AutoSize = True
        lbLastName.Location = New Point(27, 52)
        lbLastName.Name = "lbLastName"
        lbLastName.Size = New Size(63, 15)
        lbLastName.TabIndex = 2
        lbLastName.Text = "Last Name"
        ' 
        ' txbxSurname
        ' 
        txbxSurname.CustomizableEdges = CustomizableEdges17
        txbxSurname.DefaultText = ""
        txbxSurname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txbxSurname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txbxSurname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSurname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txbxSurname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSurname.Font = New Font("Segoe UI", 9F)
        txbxSurname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txbxSurname.Location = New Point(27, 70)
        txbxSurname.Name = "txbxSurname"
        txbxSurname.PasswordChar = ChrW(0)
        txbxSurname.PlaceholderText = ""
        txbxSurname.SelectedText = ""
        txbxSurname.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        txbxSurname.Size = New Size(200, 36)
        txbxSurname.TabIndex = 0
        ' 
        ' lbUsers
        ' 
        lbUsers.AutoSize = True
        lbUsers.BackColor = Color.Transparent
        lbUsers.Location = New Point(42, 74)
        lbUsers.Name = "lbUsers"
        lbUsers.Size = New Size(41, 15)
        lbUsers.TabIndex = 1
        lbUsers.Text = "Users :"
        ' 
        ' btChangePass
        ' 
        btChangePass.CustomizableEdges = CustomizableEdges5
        btChangePass.DisabledState.BorderColor = Color.DarkGray
        btChangePass.DisabledState.CustomBorderColor = Color.DarkGray
        btChangePass.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btChangePass.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btChangePass.FillColor = Color.DimGray
        btChangePass.Font = New Font("Segoe UI", 9F)
        btChangePass.ForeColor = Color.White
        btChangePass.Location = New Point(335, 210)
        btChangePass.Name = "btChangePass"
        btChangePass.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btChangePass.Size = New Size(82, 45)
        btChangePass.TabIndex = 16
        btChangePass.Text = "Change Password"
        ' 
        ' EmployeeManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1160, 644)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.None
        Name = "EmployeeManagement"
        Text = " "
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        CType(dgvUserList, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbUsers As Label
    Friend WithEvents lbAccess As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbLastName As Label
    Friend WithEvents txbxSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbUsername As Label
    Friend WithEvents txbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbFirstName As Label
    Friend WithEvents txbxFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvUserList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btChangePass As Guna.UI2.WinForms.Guna2Button
End Class
