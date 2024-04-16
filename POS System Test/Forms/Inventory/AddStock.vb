Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contents = ReadCsv("Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        If txbxID.Text <> "" AndAlso txbxPrice.Text <> "" AndAlso txbxProduct.Text <> "" AndAlso txbxQty.Text <> "" Then
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In dgvAddedList.Columns
                headers.Add(col.Name)
            Next

            For Each row As DataGridViewRow In dgvAddDescr.Rows
                If row.Cells(1).Value = "" Then
                    MessageBox.Show("Please fill all fields")
                    Exit Sub
                End If
            Next

            Dim contents As New List(Of String)
            With contents
                .Add(cbxCategory.SelectedItem)
                .Add(txbxID.Text)
                .Add(txbxProduct.Text)
                .Add(txbxPrice.Text)
                .Add(txbxQty.Text)
                For Each add As DataGridViewRow In dgvAddDescr.Rows
                    .Add(add.Cells(1).Value)
                    headers.Add(add.Cells(0).Value)
                Next
            End With
            If Not dgvAddedList.Rows.Count = 0 Then
                Dim itemExists As Boolean = False
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    If row.Cells(1).Value = contents(1).ToString Then
                        row.Cells(4).Value = Convert.ToInt32(row.Cells(4).Value) + Convert.ToInt32(contents(4))
                        itemExists = True
                        Exit For ' Exit the loop since the item is found
                    End If
                Next

                If Not itemExists Then
                    AddtoTable(dgvAddedList, contents, headers)
                End If
            Else
                AddtoTable(dgvAddedList, contents, headers)
            End If
        Else
            MessageBox.Show("Please fill all the fields")
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim headers As New List(Of String)
        Dim stockCount As Integer = 0
        Dim StockAdded As New List(Of String)
        For i As Integer = 1 To dgvAddedList.Columns.Count - 1
            headers.Add(dgvAddedList.Columns(i).HeaderText)
        Next
        For Each row As DataGridViewRow In dgvAddedList.Rows
            Dim filename As String = $"Stock\{row.Cells(0).Value}.csv"
            Dim content As New List(Of String)
            For i As Integer = 1 To dgvAddedList.Columns.Count - 1
                If Not row.Cells(i).Value.ToString() = "" Then
                    content.Add(row.Cells(i).Value)
                End If
            Next
            AddStockSub(filename, content, headers)
            stockCount += row.Cells(4).Value
            StockAdded.Add(String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Skip(2).Select(Function(cell) cell.Value.ToString()).ToArray()))
        Next
        StockLogging(DateOnly.FromDateTime(DateTime.Now), stockCount, MainForm.lbUsername.Text, StockAdded)
        dgvAddedList.Rows.Clear()
        For i As Integer = dgvAddedList.Columns.Count - 1 To 5 Step -1
            dgvAddedList.Columns.RemoveAt(i)
        Next
        Inventory.cbxCategory.SelectedIndex = 0
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim headers() As String = File.ReadAllLines($"Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
        If headers.Length > 4 Then
            dgvAddDescr.Rows.Clear()
            For i As Integer = 4 To headers.Length - 1
                With dgvAddDescr
                    .Rows.Add(headers(i), "")
                End With
            Next
        End If
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        For Each selectedRow As DataGridViewRow In dgvAddedList.SelectedRows
            dgvAddedList.Rows.Remove(selectedRow)
        Next
    End Sub

    Private Sub txbxProduct_TextChanged(sender As Object, e As EventArgs) Handles txbxProduct.TextChanged
        Dim id As String = New String(txbxProduct.Text.Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray())
        For Each row As DataGridViewRow In dgvAddDescr.Rows
            If Not String.IsNullOrEmpty(row.Cells(1).Value.ToString()) Then
                id += "-" & row.Cells(0).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray() & row.Cells(1).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray()
            End If
        Next
        txbxID.Text = id
    End Sub

    Private Sub dgvAddDescr_ValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddDescr.CellValueChanged
        Try
            Dim id As String = New String(txbxProduct.Text.Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray())
            For Each row As DataGridViewRow In dgvAddDescr.Rows
                id += "-" & row.Cells(0).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray() & row.Cells(1).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray()
            Next
            txbxID.Text = id
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        If CountMatch(txbxID.Text, 0) >= 1 Then
            For Each cat In cbxCategory.Items
                contents = ReadCsv($"Stock\{cat}.csv")
                If contents.Count > 2 AndAlso Not String.IsNullOrWhiteSpace(contents(1)) Then
                    For Each line In contents
                        Dim data = line.Split(",")
                        If data(0) = txbxID.Text Then
                            cbxCategory.SelectedItem = cat
                            txbxProduct.Text = data(1)
                            txbxPrice.Text = data(2)
                            txbxQty.Text = data(3)

                            For i As Integer = 0 To dgvAddDescr.Rows.Count - 1
                                dgvAddDescr.Rows(i).Cells(1).Value = data(i + 4)
                            Next

                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Sub StockLogging(logDate As DateOnly, info As String, inputuser As String, items As List(Of String))
        Dim logpath As String = "Resources\Stock History.csv"
        Dim logrec As String = $"Stock History\SAR-{ReadCsv(logpath).Count - 1}.csv"
        Dim stocklist As String = ""
        For Each item As String In items
            stocklist += item & Environment.NewLine
        Next
        Dim line As String = $"{logDate.ToString()},SAR-{ReadCsv(logpath).Count - 1},{info},{inputuser}" & Environment.NewLine
        File.AppendAllText(logpath, line & Environment.NewLine)
        CreateNewCsv(logrec, $"Date,{logDate.ToString() & Environment.NewLine}Reference,SAR-{ReadCsv(logpath).Count - 1 & Environment.NewLine}Total,{info & " Items" & Environment.NewLine} By User,{inputuser}" & Environment.NewLine & Environment.NewLine & stocklist)
    End Sub


    Private Sub dgvAddDescr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddDescr.CellContentClick

    End Sub
End Class