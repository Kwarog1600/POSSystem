Public Class Dashboard

    Public ttlExpenses As String = 0
    Public ttlSold As String = 0
    Public ttlcount As Integer = 0

    Function CountStock() As Integer
        Dim cat = ReadCsv("Resources/Stock Category.csv").Skip(1)
        For Each line In cat
            Dim file = ReadCsv($"Stock/{line}.csv").Skip(1)
            For Each item In file
                Dim splititem = item.Split(","c)
                ttlcount = +Int32.Parse(splititem(3))
            Next
        Next
        Return ttlcount
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttlStockCount.Text = CountStock()
        CurrentCash.Text = $"{Double.Parse(LoginForm.startCash) + Double.Parse(ttlSold) - Double.Parse(ttlExpenses)}"
    End Sub
End Class