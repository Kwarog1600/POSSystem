Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        AddCat()
    End Sub

    Private Sub StockCategoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCat()
    End Sub



    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        RemoveItem()
    End Sub

End Class











