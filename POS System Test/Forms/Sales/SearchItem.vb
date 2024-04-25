Public Class SearchItem
    Private Sub SearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxCategory.Items.Add("All")
        RefreshCat(cbxCategory)
        cbxCategory.SelectedItem = "All"
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
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
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
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
        For Each row In dgvStockList.Rows
            If row.Cells(3).Value < 1 Then
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub dgvStockList_CellDoubleCClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockList.CellDoubleClick
        Sales.txbxID.Text = dgvStockList.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub
End Class