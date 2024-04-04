Public Class MainForm
    Public currentBtn As Object

    Public Sub switchPanel(ByVal panel As Form)
        With pnlSwitch
            .Controls.Clear()
            panel.TopLevel = False
            .Controls.Add(panel)
            panel.Show()
        End With
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.ClientSize = New Size(screenWidth, screenHeight)
        pnlSelection.Size = New Size(200, screenHeight)
        pnlRibbon.Size = New Size(screenWidth - 200, 50)
        pnlSwitch.Size = New Size(screenWidth - 200, screenHeight - 50)
    End Sub

    Public Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Gray
        End If
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btLgtCLose_Click(sender As Object, e As EventArgs) Handles btLgtClose.Click
        LoginForm.TimeLog("Out", lbUsername.Text)
        Application.Exit()
    End Sub

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        LoginForm.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btSettings_Click(sender As Object, e As EventArgs) Handles btSettings.Click

    End Sub


    Private Sub btdashboard_Click(sender As Object, e As EventArgs) Handles btdashboard.Click
        switchPanel(Dashboard)
    End Sub

    Private Sub btInventory_Click(sender As Object, e As EventArgs) Handles btInventory.Click
        switchPanel(Inventory)
    End Sub

    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        switchPanel(Sales)
    End Sub

    Private Sub btHistory_Click(sender As Object, e As EventArgs) Handles btHistory.Click
        switchPanel(History)
    End Sub

    Private Sub btExpenses_Click(sender As Object, e As EventArgs) Handles btExpenses.Click

    End Sub

    Private Sub btEmplyMngt_Click(sender As Object, e As EventArgs) Handles btEmplyMngt.Click
        switchPanel(EmployeeManagement)
    End Sub
End Class