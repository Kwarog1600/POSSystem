﻿Imports System.IO

Module StockCategoryAddModule
    Public Sub AddCat()
        With StockCategoryAdd
            ' Get the file name from the text box
            Dim csvCatList As String = "Resources\Stock Category.csv"
            Dim csvFileName As String = $"Stock\{ .txbxCategory.Text}.csv"
            ' Content for the CSV file header
            Dim csvContent As String = "Product ID,Product Name,Price,Quantity"

            For Each row In .dgvAddDescr.Rows
                If Not String.IsNullOrEmpty(row.Cells(0).Value?.ToString()) Then
                    csvContent += $",{row.Cells(0).Value}"
                End If
            Next
            csvContent += Environment.NewLine

            ' Read the Stock Category.csv file to check if the category already exists
            If File.Exists(csvCatList) Then
                Dim categories As String() = File.ReadAllLines(csvCatList)
                If Not categories.Contains(.txbxCategory.Text) Then
                    ' Check if the file already exists and create it if not
                    If Not File.Exists(csvFileName) Then
                        ' Append the new category to the CSV file
                        System.IO.File.WriteAllText(csvFileName, csvContent)

                        Using sw As New System.IO.StreamWriter(csvCatList, True) ' Append mode
                            sw.WriteLine(.txbxCategory.Text)
                        End Using
                        LoadCategories()
                        .dgvCatList.Rows.Add(.txbxCategory.Text)
                    Else
                        MessageBox.Show("File already exists.")
                    End If
                Else
                    MessageBox.Show("Category already exists.")
                End If
            End If


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
            Dim csvCatList As String = "Resources\Stock Category.csv"
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
