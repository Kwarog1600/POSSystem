Public Class ExpenseAdd
    Private Sub btAddExpenses_Click(sender As Object, e As EventArgs) Handles btAddExpenses.Click
        AddExpense(txbxName.Text, txbxPurpose.Text, txbxAmount.Text, DateTime.Now)
        Me.Hide()
    End Sub
End Class