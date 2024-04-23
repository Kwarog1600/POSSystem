Imports System.Globalization

Public Class Dashboard

    Public ttlcount As Integer = 0
    Public ttlExpenses As String = 0
    Public ttlSold As String = 0

    Function CountStock() As Integer
        Dim cat = ReadCsv("Resources/Stock Category.csv").Skip(1)
        For Each line In cat
            Dim file = ReadCsv($"Stock/{line}.csv").Skip(1)
            For Each item In file
                Dim splititem = item.Split(","c)
                ttlcount += Int32.Parse(splititem(3))
            Next
        Next
        Return ttlcount
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttlStockCount.Text = CountStock()
        CurrentCash.Text = $"{Double.Parse(LoginForm.startCash)}"
        TotalExpenses.Text = DailyExpenses()
        lbMonthlyExpense.Text = MonthlyExpenses()
        TotalSold.Text = ttlDailySale()
    End Sub

    Private Function ttlDailySale() As Double
        Dim ttlSale As Double = 0
        contents = ReadCsv("Resources/Sales History.csv")
        For i As Integer = 1 To contents.Count - 1
            Dim saleinfo = contents(i).Split(","c)
            If DateTime.Now = DateTime.ParseExact(saleinfo(0), "M/d/yyyy", CultureInfo.InvariantCulture) Then
                ttlSale += Double.Parse(saleinfo(3))
            End If
        Next
        Return ttlSale
    End Function

    Public Function MonthlyExpenses() As Integer
        contents = ReadCsv("Resources/Expenses.csv")
        Dim mExp As Integer = 0
        For i As Integer = 1 To contents.Count - 1
            Dim expenseinfo = contents(i).Split(","c)
            If DateTime.Now.Month = DateTime.ParseExact(expenseinfo(0), "M/d/yyyy", CultureInfo.InvariantCulture).Month Then
                mExp += Int32.Parse(expenseinfo(3))
            End If
        Next
        Return mExp
    End Function

    Public Function DailyExpenses() As Integer
        contents = ReadCsv("Resources/Expenses.csv")
        Dim dExp As Integer = 0
        Dim currentDate = DateTime.Now
        For i As Integer = 1 To contents.Count - 1
            Dim expenseinfo = contents(i).Split(","c)
            Dim expenseDate = DateTime.ParseExact(expenseinfo(0), "M/d/yyyy", CultureInfo.InvariantCulture)
            If currentDate.Date = expenseDate.Date Then
                dExp += Int32.Parse(expenseinfo(3))
            End If
        Next
        Return dExp
    End Function

End Class