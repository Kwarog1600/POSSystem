﻿Imports System.Globalization

Public Class Dashboard

    Public ttlcount As Integer = 0
    Public ttlExpenses As String = 0
    Public ttlSold As String = 0

    Function CountStock() As Integer
        Dim cat = ReadCsv($"{srcFolder}/Resources/Stock Category.csv").Skip(1)
        For Each line In cat
            Dim file = ReadCsv($"{srcFolder}/Stock/{line}.csv").Skip(1)
            For Each item In file
                Dim splititem = item.Split(","c)
                ttlcount += Int32.Parse(splititem(3))
            Next
        Next
        Return ttlcount
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With

        ttlStockCount.Text = CountStock()
        CurrentCash.Text = $"{Double.Parse(LoginForm.startCash)}"
        TotalExpenses.Text = DailyExpenses()
        lbMonthlyExpense.Text = MonthlyExpenses()
        TotalSold.Text = ttlDailySale()
        Dim p7 As Double = 0.0, p15 As Double = 0.0, p30 As Double = 0.0, Ar As Double = 0.0

        For Each log In ReadCsv($"{srcFolder}/Resources/Sales History.csv").Skip(1)
            Dim loginf() As String = log.Split(","c)
            Dim saleDate As DateTime
            If loginf(6) = "Cash" Then
                If DateTime.TryParseExact(loginf(0), "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, saleDate) Then
                    If DateTime.Now.AddDays(-30) <= saleDate AndAlso saleDate <= DateTime.Now Then
                        p30 += Double.Parse(loginf(4))
                    End If

                    If DateTime.Now.AddDays(-15) <= saleDate AndAlso saleDate <= DateTime.Now Then
                        p15 += Double.Parse(loginf(4))
                    End If

                    If DateTime.Now.AddDays(-7) <= saleDate AndAlso saleDate <= DateTime.Now Then
                        p7 += Double.Parse(loginf(4))
                    End If
                Else
                    MessageBox.Show("Invalid date format in CSV: " & loginf(0), "Date Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf loginf(6) = "Accounts Recievable" Then
                If Double.Parse(loginf(3)) - Double.Parse(loginf(7)) > 0 Then
                    Ar += Double.Parse(loginf(3)) - Double.Parse(loginf(7))
                Else
                    If DateTime.TryParseExact(loginf(0), "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, saleDate) Then
                        If DateTime.Now.AddDays(-30) <= saleDate AndAlso saleDate <= DateTime.Now Then
                            p30 += Double.Parse(loginf(4))
                        End If

                        If DateTime.Now.AddDays(-15) <= saleDate AndAlso saleDate <= DateTime.Now Then
                            p15 += Double.Parse(loginf(4))
                        End If

                        If DateTime.Now.AddDays(-7) <= saleDate AndAlso saleDate <= DateTime.Now Then
                            p7 += Double.Parse(loginf(4))
                        End If
                    Else
                        MessageBox.Show("Invalid date format in CSV: " & loginf(0), "Date Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End If
        Next
        lb7.Text = p7.ToString("0.00")
        lb15.Text = p15.ToString("0.00")
        lb30.Text = p30.ToString("0.00")
        lbAR.Text = Ar.ToString("0.00")


    End Sub

    Private Function ttlDailySale() As Double
        Dim ttlSale As Double = 0
        contents = ReadCsv($"{srcFolder}/Resources/Sales History.csv")
        For i As Integer = 1 To contents.Count - 1
            Dim saleinfo = contents(i).Split(","c)
            If DateTime.Now = DateTime.ParseExact(saleinfo(0), "M/d/yyyy", CultureInfo.InvariantCulture) Then
                ttlSale += Double.Parse(saleinfo(3))
            End If
        Next
        Return ttlSale
    End Function

    Public Function MonthlyExpenses() As Integer
        contents = ReadCsv($"{srcFolder}/Resources/Expenses.csv")
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
        contents = ReadCsv($"{srcFolder}/Resources/Expenses.csv")
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