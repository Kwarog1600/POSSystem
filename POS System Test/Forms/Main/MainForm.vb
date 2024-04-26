
Public Class MainForm
    Public currentBtn As Object

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .ClientSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
            .pnlSelection.Size = New Size(200, Screen.PrimaryScreen.WorkingArea.Height)
            .pnlRibbon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, 50)
            .pnlSwitch.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
            .pnlFormCtrl.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 290, 5)
            .PnlBtnSelection.Location = New Point(0, ((Screen.PrimaryScreen.WorkingArea.Height - 275) / 2))
            .pnlAdminContainer.Location = New Point(0, ((Screen.PrimaryScreen.WorkingArea.Height - 275) / 2) + 300)
            .pnlLgtSt.Location = New Point(0, Screen.PrimaryScreen.WorkingArea.Height - 60)
        End With
        switchPanel(Dashboard)
    End Sub

    Private Sub btMin_Click(sender As Object, e As EventArgs) Handles btMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btCLose_Click(sender As Object, e As EventArgs) Handles btLgtClose.Click
        LogReg("Out", lbUsername.Text, Dashboard.CurrentCash.Text)
        Application.Exit()
    End Sub

    Private Sub btLogOut_Click(sender As Object, e As EventArgs) Handles btLogOut.Click
        LoginForm.Show()
        LogReg("Out", lbUsername.Text, Dashboard.CurrentCash.Text)
        Me.Hide()
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
        switchPanel(Expenses)
    End Sub

    Private Sub btEmplyMngt_Click(sender As Object, e As EventArgs) Handles btEmplyMngt.Click
        switchPanel(EmployeeManagement)
    End Sub

    Private Sub btTimeLog_Click(sender As Object, e As EventArgs) Handles btTimeLog.Click
        switchPanel(TimeLog)
    End Sub

    Private Sub btDashboard_Click(sender As Object, e As EventArgs) Handles btDashboard.Click
        switchPanel(Dashboard)
    End Sub

    Private Sub btSettings_Click(sender As Object, e As EventArgs) Handles btSettings.Click
        Settings.Show()
    End Sub

    Private Sub pnlSwitch_Paint(sender As Object, e As PaintEventArgs) Handles pnlSwitch.Paint

    End Sub

    Private Sub pnlSelection_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelection.Paint

    End Sub
End Class