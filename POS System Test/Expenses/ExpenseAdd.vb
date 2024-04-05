Public Class ExpenseAdd
    Private Sub btAddExpenses_Click(sender As Object, e As EventArgs) Handles btAddExpenses.Click
        AddExpense()
        Me.Hide()
    End Sub
End Class