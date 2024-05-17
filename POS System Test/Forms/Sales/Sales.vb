Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Sales


    Public stocklogs As List(Of String)
    Public logfile As String
    Public stocklist As List(Of String)
    Public TotalAmount As Double = 0
    Private itemCost As New List(Of Double)()

    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        Try
            If Not txbxName.Text = "" Then
                Dim headers As New List(Of String)
                TotalAmount = 0
                Dim items As New List(Of String)
                If dgvAddedList.RowCount = 0 Then
                    MessageBox.Show("Please add items.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                For i = 1 To dgvAddedList.Columns.Count - 1
                    headers.Add(dgvAddedList.Columns(i).HeaderText)
                Next
                items.Add(String.Join(",", dgvAddedList.Columns.Cast(Of DataGridViewColumn)().Skip(1).Select(Function(col) col.HeaderText).ToArray()))
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    Dim filename = $"{srcFolder}\Stock\{row.Cells(0).Value}.csv"
                    Dim content As New List(Of String)
                    For i = 1 To dgvAddedList.Columns.Count - 1
                        content.Add(row.Cells(i).Value)
                    Next
                    TotalAmount = TotalAmount + Convert.ToDouble(row.Cells(5).Value)
                Next
                Dim prft As Double = 0
                With Sale_Confirmation
                    For Each row As DataGridViewRow In dgvAddedList.Rows
                        prft += ProfitCalc(row.Cells(1).Value.ToString(), row.Cells(3).Value.ToString())
                    Next
                    .itemCosts = itemCost
                    .info = TotalAmount.ToString("0.00")
                    .txbxRef.Text = $"SR-{ReadCsv($"{srcFolder}\Resources\Sales History.csv").Count - 1}"
                    .txbxAmount.Text = TotalAmount
                    .logDate = DateOnly.FromDateTime(DateTime.Now)
                    .inputuser = MainForm.lbUsername.Text
                    .customerName = txbxName.Text
                    .items = items
                    .profit = prft
                    .Show()
                End With
            Else
                MessageBox.Show("Must Enter Customer Name")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Function to calculate profit based on given ID, item cost, and price
    Function ProfitCalc(id As String, price As String) As Double
        Dim profit As Double = 0
        Try
            ' Read the main stock history CSV file into a list of strings
            stocklogs = ReadCsv($"{srcFolder}\Resources\Stock History.csv")

            ' Skip the first line (header) and iterate through each log entry
            For Each log As String In stocklogs.Skip(1)
                Dim loginf() As String = log.Split(",")

                ' Construct the path to the specific stock history CSV file
                logfile = $"{srcFolder}\Stock History\{loginf(1)}.csv"

                ' Read the specific stock history CSV file into a list of strings
                stocklist = ReadCsv(logfile)

                ' Iterate through each stock entry in the specific stock file
                For Each stock As String In stocklist
                    Dim stockinf() As String = stock.Split(",")

                    ' Check if the stock ID matches the provided ID
                    If stockinf(0) = id Then
                        ' Check if the current stock quantity is less than the threshold
                        If Integer.Parse(stockinf(stockinf.Length - 1)) < Integer.Parse(stockinf(3)) Then
                            ' Calculate the total cost by adding the base cost and the additional cost
                            Dim totalCost As Double = Double.Parse(stockinf(4)) + (Double.Parse(loginf(4)) / Double.Parse(loginf(2)))

                            itemCost.Add(totalCost)
                            ' Calculate profit by subtracting total cost from the price
                            profit = Double.Parse(price) - totalCost

                            ' Update the stock quantity
                            Dim index = stocklist.IndexOf(stock)
                            stockinf(stockinf.Length - 1) = Integer.Parse(stockinf(stockinf.Length - 1)) + 1
                            stock = String.Join(",", stockinf)
                            stocklist(index) = stock
                            ' Return the calculated profit formatted to two decimal places
                            Return profit.ToString("0.00")
                        End If
                    End If
                Next
            Next

            ' Return profit (0 if no matching ID found or no update needed)
            Return profit
        Catch ex As Exception
            ' Show an error message if an exception occurs
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
            Return profit
        End Try
    End Function

    ' Subroutine to write a list of strings to a CSV file
    Sub WriteCsv(filePath As String, data As List(Of String))
        Try
            ' Write the list of strings to the specified file path
            File.WriteAllLines(filePath, data)
        Catch ex As Exception
            ' Show an error message if an exception occurs
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Try
            If CountMatch(txbxID.Text, 0) >= 1 Then
                For Each cat In cbxCategory.Items
                    Try
                        contents = ReadCsv($"{srcFolder}\Stock\{cat}.csv")
                        If contents.Count > 1 AndAlso Not String.IsNullOrWhiteSpace(contents(1)) Then
                            For Each line In contents
                                Dim data = line.Split(",")
                                If data(0) = txbxID.Text Then
                                    cbxCategory.SelectedItem = cat
                                    txbxProduct.Text = data(1)
                                    txbxPrice.Text = data(2)
                                    txbxQty.Text = 1
                                    For i As Integer = 0 To dgvDescr.Rows.Count - 1
                                        dgvDescr.Rows(i).Cells(1).Value = data(i + 4)
                                    Next
                                End If
                            Next
                        End If
                    Catch ex As Exception
                        Console.WriteLine($"An error occurred while reading the file: {ex.Message}")
                    End Try
                Next
            End If
        Catch ex As Exception
            Console.WriteLine($"An error occurred: {ex.Message}")
        End Try
    End Sub


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        cbxCategory.Items.Clear()
        RefreshCat(cbxCategory)
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Try
            Dim headers As New List(Of String)
            For Each col In dgvAddedList.Columns
                headers.Add(col.Name)
            Next
            Dim contents As New List(Of String)
            With contents
                .Add(cbxCategory.SelectedItem)
                .Add(txbxID.Text)
                .Add(txbxProduct.Text)
                .Add(txbxPrice.Text)
                .Add(txbxQty.Text)
                .Add(Convert.ToString(Convert.ToDouble(txbxPrice.Text) * Convert.ToDouble(txbxQty.Text)))
                For Each add In dgvDescr.Rows
                    .Add(add.Cells(1).Value)
                    headers.Add(add.cells(0).Value)
                Next
            End With
            Dim total As Integer = 0
            AddtoTable(dgvAddedList, contents, headers)
            For Each row As DataGridViewRow In dgvAddedList.Rows
                row.Cells(5).Value = Convert.ToString(Double.Parse(row.Cells(3).Value) * Double.Parse(row.Cells(4).Value))
            Next
            For Each row As DataGridViewRow In dgvAddedList.Rows
                total += row.Cells(5).Value
            Next
            showTotalPrice.Text = total
        Catch ex As Exception
            ' Handle the exception here
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btVoid_Click(sender As Object, e As EventArgs) Handles btVoid.Click
        Try
            If dgvAddedList.SelectedRows.Count = 0 Then
                MessageBox.Show("Selected row exists.")
            Else
                dgvAddedList.Rows.Remove(dgvAddedList.SelectedRows(0))
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        dgvDescr.Rows.Clear()
        Try
            Dim headers() As String = File.ReadAllLines($"{srcFolder}/Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
            If headers.Length > 5 Then
                dgvDescr.Rows.Clear()
                For i As Integer = 4 To headers.Length - 1
                    With dgvDescr
                        .Rows.Add(headers(i), "")
                    End With
                Next
            End If
        Catch ex As Exception
            ' Handle the exception here
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txbxProduct_TextChanged(sender As Object, e As EventArgs) Handles txbxProduct.TextChanged
        Try
            Dim id As String = cbxCategory.SelectedItem & txbxProduct.Text
            For Each row As DataGridViewRow In dgvDescr.Rows
                If Not String.IsNullOrEmpty(row.Cells(1).Value.ToString()) Then
                    id += "-" & row.Cells(0).Value.ToString() & row.Cells(1).Value.ToString()
                End If
            Next
            txbxID.Text = $"{idHash(id)}"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvDescr_ValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescr.CellValueChanged
        Try
            Dim id As String = cbxCategory.SelectedItem & txbxProduct.Text
            For Each row As DataGridViewRow In dgvDescr.Rows
                If Not String.IsNullOrEmpty(row.Cells(1).Value.ToString()) Then
                    id += "-" & row.Cells(0).Value.ToString() & row.Cells(1).Value.ToString()
                End If
            Next
            txbxID.Text = $"{idHash(id)}"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btSeach_Click(sender As Object, e As EventArgs) Handles btSeach.Click
        SearchItem.Show()
        SearchItem.openedfrom = "Sales"
        SearchItem.txbxSearch.Text = txbxProduct.Text
    End Sub

End Class