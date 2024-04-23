
Public Class MainForm
    Public currentBtn As Object

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class