Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        ' Get the file name from the text box
        Dim csvCatList As String = "Stock Category.csv"
        Dim csvFileName As String = txbxCategory.Text & ".csv"

        ' Check if the file already exists
        If File.Exists(csvFileName) Then
            MessageBox.Show("File already exists.")
            Return
        End If

        ' Content for the CSV file header
        Dim csvContent As String = "Product ID,Product Name,Price,Quantity" & Environment.NewLine

        ' Write the header to the CSV file
        Using sw As New System.IO.StreamWriter(csvFileName)
            sw.WriteLine(csvContent)
        End Using

        ' Append the new category to the CSV file
        Using sw As New System.IO.StreamWriter(csvCatList, True) ' Append mode
            sw.WriteLine(txbxCategory.Text)
        End Using
        Inventory.LoadCategories()
    End Sub

End Class











