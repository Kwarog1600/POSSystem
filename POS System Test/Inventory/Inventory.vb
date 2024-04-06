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

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        RefreshTable()
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub btStockHistory_Click(sender As Object, e As EventArgs) Handles btStockHistory.Click
        StockHistory.StockHistory_Load()
    End Sub



    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
        Search()
    End Sub

    Public Sub Search()
        Dim searchText As String = txbxSearch.Text.ToLower() ' Convert search text to lowercase for case-insensitive search
        For Each row As DataGridViewRow In dgvStockList.Rows
            ' Check if the text in the second column matches the search text
            Dim cellValue As String = row.Cells(1).Value.ToString().ToLower() ' Assuming the second column index is 1
            If cellValue.Contains(searchText) Then
                row.Visible = True ' If there's a match, make the row visible
            Else
                row.Visible = False ' If there's no match, hide the row
            End If
        Next
    End Sub

End Class



