Imports System.IO

Module ExpenseModule

    Public Sub LoadList()
        Dim filepath As String = $"{srcFolder}/Resources/Expenses.csv"
        If File.Exists(filepath) Then
            Using read As New StreamReader(filepath)
                Dim header As String = read.ReadLine()
                Dim headers() As String = header.Split(","c)
                Expenses.dgvExpenseList.Columns.Clear()
                For Each col In headers
                    Expenses.dgvExpenseList.Columns.Add(col, col)
                Next
                While Not read.EndOfStream
                    Expenses.dgvExpenseList.Rows.Add(read.ReadLine().Split(","c))
                End While
            End Using
        Else
            MessageBox.Show("File not found")
        End If
    End Sub

    Public Sub AddExpense(name As String, Purpose As String, Amount As String, currentDate As DateOnly)
        Dim filepath As String = $"{srcFolder}/Resources/Expenses.csv"
        If File.Exists(filepath) Then
            Using write As New StreamWriter(filepath, True)
                write.WriteLine($"{currentDate},{name},{Purpose},{Amount}, {MainForm.lbUsername.Text}")
            End Using
        End If
        LoadList()
        Dashboard.TotalExpenses.Text = Convert.ToString(Convert.ToInt32(Dashboard.TotalExpenses.Text) + Convert.ToInt32(Amount))
    End Sub

End Module
