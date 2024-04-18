Public Class Expenses
    Private Sub btAddExpenses_Click(sender As Object, e As EventArgs) Handles btAddExpenses.Click
        ExpenseAdd.Show()
    End Sub

    Private Sub Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub
End Class