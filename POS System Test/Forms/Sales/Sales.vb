Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Sales

    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        Try
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
                End If
            Loop
            For i = 1 To dgvAddedList.Columns.Count - 1
                    headers.Add(dgvAddedList.Columns(i).HeaderText)
                Next
                items.Add(String.Join(",", dgvAddedList.Columns.Cast(Of DataGridViewColumn)().Skip(2).Select(Function(col) col.HeaderText).ToArray()))
            For Each row As DataGridViewRow In dgvAddedList.Rows
                Dim filename = $"Stock\{row.Cells(0).Value}.csv"
                Dim content As New List(Of String)
                For i = 1 To dgvAddedList.Columns.Count - 1
                    If i <> 5 Then
                        content.Add(row.Cells(i).Value)
                    End If

                Next
                TotalAmount = TotalAmount + Convert.ToInt32(row.Cells(5).Value)
                items.Add(String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Skip(2).Select(Function(cell) cell.Value.ToString()).ToArray()) & "," & row.Cells(5).Value)
                UpdateQty(filename, content, headers, True)
            Next
            TotalAmount -= Less
            SalesLogging(DateOnly.FromDateTime(DateTime.Now), TotalAmount, MainForm.lbUsername.Text, txbxName.Text, items)
            dgvAddedList.Rows.Clear()
                Dashboard.CurrentCash.Text = (Convert.ToDouble(Dashboard.CurrentCash.Text) + Convert.ToDouble(showTotalPrice.Text)).ToString()
                Dashboard.TotalSold.Text = (Convert.ToDouble(Dashboard.TotalSold.Text) + Convert.ToDouble(showTotalPrice.Text)).ToString()
            If dgvAddedList.Columns.Count > 6 Then
                For i = dgvAddedList.Columns.Count - 1 To 6 Step -1
                    dgvAddedList.Columns.RemoveAt(i)
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Sub SalesLogging(logDate As DateOnly, info As String, inputuser As String, customerName As String, items As List(Of String))
        Try
            Dim logpath As String = $"{srcFolder}/Resources\Sales History.csv"
            Dim logrec As String = $"{srcFolder}/Receipts\SR-{ReadCsv(logpath).Count - 1}.csv"
            Dim stocklist As String = ""
            For Each item As String In items
                stocklist += item & Environment.NewLine
            Next
            Dim line As String = $"{logDate.ToString()},SR-{ReadCsv(logpath).Count - 1},{customerName},{info},{inputuser}" & Environment.NewLine
            File.AppendAllText(logpath, line)
            CreateNewCsv(logrec, $"Date,{logDate.ToString() & Environment.NewLine}Reference,SR-{ReadCsv(logpath).Count - 1 & Environment.NewLine}Name,{customerName & Environment.NewLine}Total,{info & Environment.NewLine}Sold By,{inputuser}" & Environment.NewLine & Environment.NewLine & stocklist)
        Catch ex As Exception
            ' Handle the exception here
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Try
            If CountMatch(txbxID.Text, 0) >= 1 Then
                For Each cat In cbxCategory.Items
                    Try
                        contents = ReadCsv($"{srcFolder}/Stock\{cat}.csv")
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
                row.Cells(5).Value = Convert.ToString(Convert.ToDouble(row.Cells(3).Value) * Convert.ToDouble(row.Cells(4).Value))
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
        Try
            Dim headers() As String = File.ReadAllLines($"{srcFolder}/Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
            If headers.Length > 4 Then
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
        SearchItem.txbxSearch.Text = txbxProduct.Text
    End Sub

    Private Sub showTotalPrice_Click(sender As Object, e As EventArgs) Handles showTotalPrice.Click

    End Sub
End Class