Imports System.IO

Module StockCategoryAddModule
    Public Sub AddCat()
        With StockCategoryAdd
            ' Get the file name from the text box
            Dim csvCatList As String = "Resources\Stock Category.csv"
            Dim csvFileName As String = $"Stock\{ .txbxCategory.Text}.csv"
            ' Content for the CSV file header
            Dim csvContent As String = "Product ID,Product Name,Price,Quantity" & Environment.NewLine

            ' Check if the file already exists and create it if not
            If Not File.Exists(csvFileName) Then
                ' Append the new category to the CSV file
                System.IO.File.WriteAllText(csvFileName, csvContent)

                Using sw As New System.IO.StreamWriter(csvCatList, True) ' Append mode
                    sw.WriteLine(.txbxCategory.Text)
                End Using
            End If

            LoadCategories()
            .dgvCatList.Rows.Add(.txbxCategory.Text)
        End With

    End Sub


    Public Sub LoadCat()
        With StockCategoryAdd
            Dim csvCatList As String = "Resources/Stock Category.csv"
            Using reader As New StreamReader(csvCatList)
                Dim line As String
                .dgvCatList.Columns.Add("clm1", "")
                reader.ReadLine()
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    .dgvCatList.Rows.Add(line)
                End While
            End Using
            LoadCategories()
        End With

    End Sub


    Public Sub RemoveItem()
        With StockCategoryAdd
            Dim csvCatList As String = "Stock Category.csv"
            Dim selectedValue As String = .dgvCatList.SelectedRows(0).Cells(0).Value

            ' Display a confirmation message box
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this item? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Read all lines from the file
                Dim lines As List(Of String) = File.ReadAllLines(csvCatList).ToList()

                ' Remove all lines that match the selectedValue
                lines.RemoveAll(Function(line) line = selectedValue)

                ' Write the modified lines back to the file
                File.WriteAllLines(csvCatList, lines.ToArray())

                ' Delete the corresponding .csv file
                File.Delete($"Stock\{selectedValue}.csv")

                ' Remove the selected row from the DataGridView
                .dgvCatList.Rows.Remove(.dgvCatList.SelectedRows(0))
            End If
        End With

    End Sub
End Module
