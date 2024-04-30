Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
            txbxID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Try
            If txbxID.Text <> "" AndAlso txbxPrice.Text <> "" AndAlso txbxProduct.Text <> "" AndAlso txbxQty.Text <> "" AndAlso txbxCost.Text <> "" Then
                Dim headers As New List(Of String)
                For Each col As DataGridViewColumn In dgvAddedList.Columns
                    headers.Add(col.Name)
                Next
                Dim contents As New List(Of String)
                With contents
                    .Add(cbxCategory.SelectedItem)
                    .Add(txbxID.Text)
                    .Add(txbxProduct.Text)
                    .Add(txbxPrice.Text)
                    .Add(txbxQty.Text)
                    .Add(txbxCost.Text)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            Dim headers As New List(Of String)
            Dim stockCount As Integer = 0
            Dim StockAdded As New List(Of String)
            Dim BatchCost As String = InputBox("Enter the Total Amount of Additional Batch Cost(Shipping, Labor, etc.):", "Additional Costs")
            If IsNumeric(BatchCost) Then
                For i As Integer = 1 To dgvAddedList.Columns.Count - 1
                    headers.Add(dgvAddedList.Columns(i).HeaderText)
                Next
                StockAdded.Add(String.Join(",", dgvAddedList.Columns.Cast(Of DataGridViewColumn)().Skip(1).Select(Function(col) col.HeaderText).ToArray()))
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    Dim filename As String = $"{srcFolder}/Stock\{row.Cells(0).Value}.csv"
                    Dim content As New List(Of String)
                    For i As Integer = 1 To dgvAddedList.Columns.Count - 1
                        content.Add(row.Cells(i).Value)
                    Next
                    AddStockSub(filename, content, headers)
                    stockCount += row.Cells(4).Value
                    StockAdded.Add(String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Skip(1).Select(Function(cell) cell.Value.ToString()).ToArray()))
                Next
                StockLogging(DateOnly.FromDateTime(DateTime.Now), stockCount, MainForm.lbUsername.Text, StockAdded, BatchCost)
                Dashboard.ttlStockCount.Text = Dashboard.CountStock()
                dgvAddedList.Rows.Clear()
                For i As Integer = dgvAddedList.Columns.Count - 1 To 6 Step -1
                    dgvAddedList.Columns.RemoveAt(i)
                Next
                Inventory.cbxCategory.SelectedIndex = 0
            Else
                MessageBox.Show("Please enter a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Try
            Dim headers() As String = File.ReadAllLines($"{srcFolder}/Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
            If headers.Length > 5 Then
                dgvAddDescr.Rows.Clear()
                For i As Integer = 5 To headers.Length - 1
                    With dgvAddDescr
                        .Rows.Add(headers(i), "")
                    End With
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        Try
            For Each selectedRow As DataGridViewRow In dgvAddedList.SelectedRows
                dgvAddedList.Rows.Remove(selectedRow)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txbxProduct_TextChanged(sender As Object, e As EventArgs) Handles txbxProduct.TextChanged
        Try
            Dim id As String = cbxCategory.SelectedItem & txbxProduct.Text
            For Each row As DataGridViewRow In dgvAddDescr.Rows
                If Not String.IsNullOrEmpty(row.Cells(1).Value.ToString()) Then
                    id += "-" & row.Cells(0).Value.ToString() & row.Cells(1).Value.ToString()
                End If
            Next
            txbxID.Text = $"{idHash(id)}"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgvAddDescr_ValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddDescr.CellValueChanged
        Try
            Dim id As String = cbxCategory.SelectedItem & txbxProduct.Text
            For Each row As DataGridViewRow In dgvAddDescr.Rows
                If Not String.IsNullOrEmpty(row.Cells(1).Value.ToString()) Then
                    id += "-" & row.Cells(0).Value.ToString() & row.Cells(1).Value.ToString()
                End If
            Next
            txbxID.Text = $"{idHash(id)}"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Try
            If CountMatch(txbxID.Text, 0) >= 1 Then
                For Each cat In cbxCategory.Items
                    contents = ReadCsv($"{srcFolder}/Stock\{cat}.csv")
                    If contents.Count > 1 AndAlso Not String.IsNullOrWhiteSpace(contents(1)) Then
                        For Each line In contents
                            Dim data = line.Split(",")
                            If data(0) = txbxID.Text Then
                                cbxCategory.SelectedItem = cat
                                txbxProduct.Text = data(1)
                                txbxPrice.Text = data(2)
                                txbxQty.Text = 1
                                txbxCost.Text = data(4)
                                For i As Integer = 0 To dgvAddDescr.Rows.Count - 1
                                    dgvAddDescr.Rows(i).Cells(1).Value = data(i + 5)
                                Next
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Sub StockLogging(logDate As DateOnly, info As String, inputuser As String, items As List(Of String), BatchCost As String)
        Try
            Dim logpath As String = $"{srcFolder}/Resources\Stock History.csv"
            Dim logrec As String = $"{srcFolder}/Stock History\SAR-{ReadCsv(logpath).Count - 1}.csv"
            Dim stocklist As String = ""
            Dim isFirstItem As Boolean = True
            For Each item As String In items
                If isFirstItem Then
                    stocklist += item & ", Sold" & Environment.NewLine
                    isFirstItem = False
                Else
                    stocklist += item & ",0" & Environment.NewLine
                End If
            Next
            Dim line As String = $"{logDate.ToString()},SAR-{ReadCsv(logpath).Count - 1},{info},{inputuser},{BatchCost}" & Environment.NewLine
            File.AppendAllText(logpath, line)
            CreateNewCsv(logrec, stocklist)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btSeach_Click(sender As Object, e As EventArgs) Handles btSeach.Click
        Try
            SearchItem.Show()
            SearchItem.openedfrom = "AddStock"
            SearchItem.txbxSearch.Text = txbxProduct.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class