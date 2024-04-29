Public Class ExpenseAdd
    Private Sub btAddExpenses_Click(sender As Object, e As EventArgs) Handles btAddExpenses.Click
        Dim Expense As Double = Convert.ToDouble(txbxAmount.Text)
        Dim name As String = txbxName.Text
        Dim Purpose As String = txbxPurpose.Text
        AddExpense(name, Purpose, Expense, DateOnly.FromDateTime(DateTime.Now))
        Dashboard.lbMonthlyExpense.Text = Dashboard.MonthlyExpenses()
        Dashboard.TotalExpenses.Text = Dashboard.DailyExpenses()
        If cbxDeduct.Checked Then
            Current -= Expense
        End If
        Me.Hide()
    End Sub
End Class