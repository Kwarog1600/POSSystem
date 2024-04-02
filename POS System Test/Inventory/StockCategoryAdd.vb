Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        ' Get the file name from the text box
        Dim csvCatList As String = "Stock Category.csv"
        Dim csvFileName As String = $"Stock\{txbxCategory.Text}.csv"

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
        Dim csvCatList As String = "Resources/Stock Category.csv"
        Using reader As New StreamReader(csvCatList)
            Dim line As String
            dgvCatList.Columns.Add("clm1", "")
            reader.ReadLine()
            While Not reader.EndOfStream
                line = reader.ReadLine()
                dgvCatList.Rows.Add(line)
            End While
        End Using
        Inventory.LoadCategories()
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        Dim csvCatList As String = "Stock Category.csv"
        Dim selectedValue As String = dgvCatList.SelectedRows(0).Cells(0).Value

        ' Display a confirmation message box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Read all lines from the file
            Dim lines As List(Of String) = File.ReadAllLines(csvCatList).ToList()

            ' Remove the selected line from the list
            lines.Remove(selectedValue)

            ' Write the modified lines back to the file
            File.WriteAllLines(csvCatList, lines.ToArray())

            ' Delete the corresponding .csv file
            File.Delete($"Stock\{selectedValue}.csv")

            ' Remove the selected row from the DataGridView
            dgvCatList.Rows.Remove(dgvCatList.SelectedRows(0))
        End If
    End Sub
End Class











