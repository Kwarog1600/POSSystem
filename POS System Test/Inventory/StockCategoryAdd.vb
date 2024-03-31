Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        Dim csvFileName As String = txbxCategory.Text & ".csv"
        Dim csvContent As String = "Product ID,Product Name,Price,Quantity" & Environment.NewLine

        Using sw As New System.IO.StreamWriter(csvFileName)
            sw.WriteLine(csvContent)
        End Using
    End Sub
End Class











