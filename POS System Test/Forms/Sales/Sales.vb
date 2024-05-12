Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Sales

    Dim pCost As String

    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        Try
            If Not txbxName.Text = "" Then
                Dim headers As New List(Of String)
                Dim TotalAmount As Integer = 0
                Dim items As New List(Of String)
                Dim less As Integer
                If dgvAddedList.RowCount = 0 Then
                    MessageBox.Show("Please add items.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim isValidInput As Boolean = False
                Do Until isValidInput
                    Dim input As String = InputBox("Less?", "Discount Prompt")
                    If IsNumeric(input) Then
                        less = CInt(input)
                        isValidInput = True
                    Else
                        MessageBox.Show("Please enter a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Loop
                For i = 1 To dgvAddedList.Columns.Count - 1
                    headers.Add(dgvAddedList.Columns(i).HeaderText)
                Next
                items.Add(String.Join(",", dgvAddedList.Columns.Cast(Of DataGridViewColumn)().Skip(1).Select(Function(col) col.HeaderText).ToArray()))
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    Dim filename = $"{srcFolder}\Stock\{row.Cells(0).Value}.csv"
                    Dim content As New List(Of String)
                    For i = 1 To dgvAddedList.Columns.Count - 1
                        If i <> 5 Then
                            content.Add(row.Cells(i).Value)
                        End If
                    Next
                    TotalAmount = TotalAmount + Convert.ToInt32(row.Cells(5).Value)
                Next
                Dim prft As Double = 0
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    prft += ProfitCalc(row.Cells(1).Value.ToString(), row.Cells(4).Value.ToString(), row.Cells(3).Value.ToString())
                Next
                prft -= less
                TotalAmount -= less
                With Sale_Confirmation
                    .txbxRef.Text = $"SR-{ReadCsv($"{srcFolder}\Resources\Sales History.csv").Count - 1}"
                    .txbxAmount.Text = TotalAmount
                    .logDate = DateOnly.FromDateTime(DateTime.Now)
                    .info = TotalAmount
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

    Function ProfitCalc(id As String, itemcost As String, price As String) As Double
        Dim profit As Double = 0
        Try
            Dim stocklogs As List(Of String) = ReadCsv($"{srcFolder}\Resources\Stock History.csv")
            For Each log As String In stocklogs.Skip(1)
                Dim loginf() As String = log.Split(",")
                Dim logfile As String = $"{srcFolder}\Stock History\{loginf(1)}.csv"
                Dim stocklist As List(Of String) = ReadCsv(logfile)
                For Each stock As String In stocklist
                    Dim stockinf() As String = stock.Split(",")
                    If stockinf(0) = id Then
                        If stockinf(stockinf.Length - 1) < stockinf(3) Then
                            Dim totalCost As Double = Double.Parse(stockinf(4)) + (Double.Parse(loginf(4)) / Double.Parse(loginf(2)))
                            profit = Double.Parse(price) - totalCost
                            Dim index = stocklist.IndexOf(stock)
                            stockinf(stockinf.Length - 1) = Integer.Parse(stockinf(stockinf.Length - 1)) + 1
                            stock = String.Join(",", stockinf)
                            stocklist(index) = stock
                            File.WriteAllLines(logfile, stocklist)
                            Return profit.ToString("0.00")
                        End If
                    End If
                Next
            Next
            Return profit
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
            Return profit
        End Try
    End Function



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
                                    pCost = data(4)
                                    For i As Integer = 0 To dgvDescr.Rows.Count - 1
                                        dgvDescr.Rows(i).Cells(1).Value = data(i + 5)
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
                .Add(pCost)
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
                For i As Integer = 5 To headers.Length - 1
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