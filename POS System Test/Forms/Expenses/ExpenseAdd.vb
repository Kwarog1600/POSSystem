Public Class ExpenseAdd
    Private Sub btAddExpenses_Click(sender As Object, e As EventArgs) Handles btAddExpenses.Click
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class