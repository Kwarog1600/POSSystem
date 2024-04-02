Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        ' Get the file name from the text box
        Dim csvCatList As String = "Stock Category.csv"
        Dim csvFileName As String = $"Stock\{csvCatList}.csv"

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

    Private Sub StockCategoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim csvCatList As String = "Stock Category.csv"
        Using reader As New StreamReader(csvCatList)
            Dim line As String
            dgvCatList.Columns.Add("clm1", "")
            reader.ReadLine()
            While Not reader.EndOfStream
                line = reader.ReadLine()
                dgvCatList.Rows.Add(line)
            End While
        End Using
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        Dim csvCatList As String = "Stock Category.csv"
        Using read As New StreamReader(csvCatList)
            Dim line As String
            While Not read.EndOfStream
                If read.ReadLine() = dgvCatList.SelectedRows(0).Cells(0).Value Then

                End If
            End While
        End Using
        dgvCatList.Rows.Remove(dgvCatList.SelectedRows(0))
    End Sub
End Class











