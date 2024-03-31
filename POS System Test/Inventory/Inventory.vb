Imports System.ComponentModel
Imports System.IO

Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadCategories()

    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        PopulateDataGridViewForCategory(cbxCategory.SelectedItem.ToString)
    End Sub

    Public Sub AddItemsFromAllCategories()

    End Sub

    Private Sub btAddCategory_Click(sender As Object, e As EventArgs) Handles btAddCategory.Click
        StockCategoryAdd.Visible = True
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        AddStock.Visible = True
    End Sub

    Private Sub btStockHistory_Click(sender As Object, e As EventArgs) Handles btStockHistory.Click
        StockHistory.Visible = True
    End Sub

    Private Sub cbxCategory_Click(sender As Object, e As EventArgs) Handles cbxCategory.Click
        LoadCategories()
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged

    End Sub

    Public Sub PopulateDataGridViewForCategory(selectedCategory As String)

    End Sub

End Class



