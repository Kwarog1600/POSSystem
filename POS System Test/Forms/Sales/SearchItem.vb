Public Class SearchItem
    Public openedfrom As String = ""

    Private Sub SearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbxCategory.Items.Add("All")
        RefreshCat(cbxCategory)
            cbxCategory.SelectedItem = "All"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
        Try
            Dim searchText As String = txbxSearch.Text.ToLower()
            For Each row As DataGridViewRow In dgvStockList.Rows
                Dim found As Boolean = False
                Dim cellValue As String = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
                If Not String.IsNullOrEmpty(cellValue) AndAlso Convert.ToDouble(cellValue) >= 1 Then
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                            found = True
                            Exit For
                        End If
                    Next
                End If
                row.Visible = found
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Try
            dgvStockList.Rows.Clear()
            If cbxCategory.SelectedItem = "All" Then
                For Each cat In cbxCategory.Items
                    If Not cat = "All" Then
                        Dim contents = ReadCsv($"{srcFolder}/Stock\{cat}.csv")
                        Dim tbheader() As String = contents(0).Split(","c)

                        For Each head As String In tbheader
                            If Not dgvStockList.Columns.Contains($"clm{head}") Then
                                dgvStockList.Columns.Add($"clm{head}", head)
                            End If
                        Next
                        For i As Integer = 1 To contents.Count - 1
                            Dim item() As String = contents(i).Split(","c)
                            Dim newRowIdx = dgvStockList.Rows.Add()
                            For j As Integer = 0 To item.Length - 1
                                If j < tbheader.Length Then
                                    Dim columnName As String = $"clm{tbheader(j)}"
                                    dgvStockList.Rows(newRowIdx).Cells(columnName).Value = item(j)
                                End If
                            Next
                        Next
                    End If
                Next
            Else
                Dim cat As String = cbxCategory.SelectedItem
                Dim contents = ReadCsv($"{srcFolder}/Stock\{cat}.csv")
                Dim tbheader() As String = contents(0).Split(","c)
                For Each head As String In tbheader
                    If Not dgvStockList.Columns.Contains($"clm{head}") Then
                        dgvStockList.Columns.Add($"clm{head}", head)
                    End If
                Next
                For i As Integer = 1 To contents.Count - 1
                    Dim item() As String = contents(i).Split(","c)
                    Dim newRowIdx = dgvStockList.Rows.Add()
                    For j As Integer = 0 To item.Length - 1
                        If j < tbheader.Length Then
                            Dim columnName As String = $"clm{tbheader(j)}"
                            dgvStockList.Rows(newRowIdx).Cells(columnName).Value = item(j)
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgvStockList_CellDoubleCClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockList.CellDoubleClick
        Try
            If openedfrom = "Sales" Then
                If dgvStockList.Rows(e.RowIndex).Cells(3).Value < 1 Then
                    MessageBox.Show("No Stock Available")
                Else
                    InputPID(Sales.txbxID, e)
                End If
            ElseIf openedfrom = "AddStock" Then
                InputPID(AddStock.txbxID, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub InputPID(ByRef tx As Guna.UI2.WinForms.Guna2TextBox, e As DataGridViewCellEventArgs)
        tx.Text = dgvStockList.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub
End Class