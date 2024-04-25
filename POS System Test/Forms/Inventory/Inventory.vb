Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Inventory
    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        AddStock.Visible = True
    End Sub

    Private Sub btAddCategory_Click(sender As Object, e As EventArgs) Handles btAddCategory.Click
        StockCategoryAdd.Visible = True
    End Sub


    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxCategory.Items.Add("All")
        RefreshCat(cbxCategory)
        cbxCategory.SelectedItem = "All"
    End Sub

    Private Sub btStockHistory_Click(sender As Object, e As EventArgs) Handles btStockHistory.Click
        RefreshTable($"{srcFolder}/Resources/Stock History.csv", StockHistory.dgvHistory)
        StockHistory.Show()
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
        Dim searchText As String = txbxSearch.Text.ToLower()

        For Each row As DataGridViewRow In dgvStockList.Rows
            Dim found As Boolean = False

            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                    found = True
                    Exit For
                End If
            Next

            row.Visible = found
        Next
    End Sub


    Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        dgvStockList.Rows.Clear()
        dgvStockList.Columns.Clear()
        dgvStockList.Columns.Add($"clmcategory", "category")
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
                        dgvStockList.Rows(newRowIdx).Cells("clmcategory").Value = cat
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
    End Sub

    Private Sub dgvStockList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStockList.CellDoubleClick
        With PriceChange
            .txbxCategory.Text = dgvStockList.Rows(e.RowIndex).Cells("clmCategory").Value
            .txbxID.Text = dgvStockList.Rows(e.RowIndex).Cells("clmID").Value
            .txbxProduct.Text = dgvStockList.Rows(e.RowIndex).Cells("clmProduct").Value
            .txbxPrice.Text = dgvStockList.Rows(e.RowIndex).Cells("clmPrice").Value
            If dgvStockList.Rows(e.RowIndex).Cells.Count > 5 Then
                For i As Integer = 5 To dgvStockList.Rows(e.RowIndex).Cells.Count - 1
                    .dgvAddDescr.Rows.Add(dgvStockList.Columns(i).HeaderText, dgvStockList.Rows(e.RowIndex).Cells(i).Value)
                Next
            End If
            .Show()
        End With
    End Sub
End Class


