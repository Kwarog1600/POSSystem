﻿Imports System.ComponentModel
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
        contents = ReadCsv("Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
        cbxCategory.SelectedIndex = 0
    End Sub

    Private Sub btStockHistory_Click(sender As Object, e As EventArgs) Handles btStockHistory.Click

    End Sub



    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged

    End Sub

End Class


