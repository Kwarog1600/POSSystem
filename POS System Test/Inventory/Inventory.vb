Imports System.IO

Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadCategories()
            LoadItems()
        Catch ex As Exception
            MessageBox.Show($"Error loading categories and items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCategories()
        ' Clear existing items in cbxCategory
        cbxCategory.Items.Clear()

        ' Add default item "All"
        cbxCategory.Items.Add("All")

        ' Load categories from Stock Category.csv
        Dim categories As New List(Of String)
        Try
            Using reader As New StreamReader("Stock Category.csv")
                Dim isFirstLine As Boolean = True ' Flag to skip the first line (headers)
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine()
                    If isFirstLine Then
                        isFirstLine = False
                        Continue While ' Skip headers
                    End If
                    Dim category = line.Split(","c)(0) ' Assuming category is in the first column
                    categories.Add(category)
                End While
            End Using

            ' Add categories to cbxCategory
            For Each category In categories
                cbxCategory.Items.Add(category)
            Next
        Catch ex As Exception
            Throw New Exception("Error loading categories", ex)
        End Try

        ' Select "All" by default
        cbxCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadItems()
        ' Clear existing items in dgvItems
        dgvStockList.Rows.Clear()

        ' Load items based on selected category from Stock Category.csv
        Dim selectedCategory As String = cbxCategory.SelectedItem.ToString()
        Dim items As New List(Of String)
        Try
            Using reader As New StreamReader("Stock Category.csv")
                Dim isFirstLine As Boolean = True ' Flag to skip the first line (headers)
                While Not reader.EndOfStream
                    Dim line = reader.ReadLine()
                    If isFirstLine Then
                        isFirstLine = False
                        Continue While ' Skip headers
                    End If
                    Dim categoryAndItems = line.Split(","c)
                    If categoryAndItems(0) = selectedCategory OrElse selectedCategory = "All" Then
                        For i As Integer = 1 To categoryAndItems.Length - 1
                            items.Add(categoryAndItems(i))
                        Next
                    End If
                End While
            End Using

            ' Add items to dgvItems
            For Each item In items
                dgvStockList.Rows.Add(item)
            Next
        Catch ex As Exception
            Throw New Exception("Error loading items", ex)
        End Try
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged, cbxCategory.SelectedIndexChanged
        Try
            ' Clear existing columns and rows in dgvStockList
            dgvStockList.Columns.Clear()
            dgvStockList.Rows.Clear()

            ' Dictionary to store headers and corresponding column indices
            Dim headerColumnIndex As New Dictionary(Of String, Integer)

            ' Add a common "ID" column
            dgvStockList.Columns.Add("ID", "ID")

            ' Add columns for the selected category (if not "All")
            Dim selectedCategory = cbxCategory.SelectedItem.ToString
            If selectedCategory <> "All" Then
                Dim categoryFileName = selectedCategory & ".csv"
                If File.Exists(categoryFileName) Then
                    Using reader As New StreamReader(categoryFileName)
                        Dim isFirstLine = True ' Flag to skip the first line (headers)
                        If Not reader.EndOfStream Then
                            Dim headers = reader.ReadLine.Split(","c)
                            For Each header In headers
                                If isFirstLine Then
                                    isFirstLine = False
                                    Continue For ' Skip headers
                                End If
                                If Not headerColumnIndex.ContainsKey(header) Then
                                    Dim columnName = $"clm{header}" ' Prefix column name with 'clm'
                                    Dim columnIndex = dgvStockList.Columns.Add(columnName, header)
                                    headerColumnIndex.Add(header, columnIndex)
                                End If
                            Next
                        End If
                    End Using
                End If

                ' Populate dgvStockList with items from the selected category
                If dgvStockList.Columns.Count > 0 Then
                    Using reader As New StreamReader(categoryFileName)
                        Dim isFirstLine = True ' Flag to skip the first line (headers)
                        While Not reader.EndOfStream
                            Dim line = reader.ReadLine
                            If isFirstLine Then
                                isFirstLine = False
                                Continue While ' Skip headers
                            End If
                            Dim values = line.Split(","c)
                            If values.Length = dgvStockList.Columns.Count Then
                                dgvStockList.Rows.Add(values)
                            End If
                        End While
                    End Using
                End If
            Else
                ' If "All" selected, you can handle what you want to show in the DataGridView here.
                ' For example, you could load all categories or show a message indicating that "All" is selected.
                AddItemsFromAllCategories()
                'MessageBox.Show("All categories selected. You can handle the logic here.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading items for the selected category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddItemsFromAllCategories()
        Try
            ' Clear existing columns and rows in dgvStockList
            dgvStockList.Columns.Clear()
            dgvStockList.Rows.Clear()

            ' Dictionary to store headers and corresponding column indices
            Dim headerColumnIndex As New Dictionary(Of String, Integer)

            ' Read categories from Stock Category.csv
            Dim categoryFilePath As String = "Stock Category.csv"
            Using categoryReader As New StreamReader(categoryFilePath)
                ' Skip headers
                categoryReader.ReadLine()

                ' Iterate over categories
                While Not categoryReader.EndOfStream
                    Dim categoryLine As String = categoryReader.ReadLine()
                    Dim category As String = categoryLine.Split(","c)(0)

                    ' Read items from category file
                    Dim categoryFile As String = $"{category}.csv"
                    Using reader As New StreamReader(categoryFile)
                        ' Read headers
                        Dim headers As String() = reader.ReadLine().Split(","c)

                        ' Add headers if not already added
                        For Each header As String In headers
                            If Not headerColumnIndex.ContainsKey(header) Then
                                Dim columnIndex As Integer = dgvStockList.Columns.Add(header, header)
                                headerColumnIndex.Add(header, columnIndex)
                            End If
                        Next

                        ' Read data and add to DataGridView
                        While Not reader.EndOfStream
                            Dim values As String() = reader.ReadLine().Split(","c)
                            Dim rowIndex As Integer = dgvStockList.Rows.Add()

                            ' Add each value to corresponding column
                            For i As Integer = 0 To values.Length - 1
                                Dim columnName As String = headers(i)
                                Dim columnIndex As Integer = headerColumnIndex(columnName)
                                dgvStockList.Rows(rowIndex).Cells(columnIndex).Value = values(i)
                            Next
                        End While
                    End Using
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding items from all categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        ' Clear the existing rows and columns in dgvStocklist
        dgvStockList.Rows.Clear()

        ' Get the search text
        Dim searchText As String = txbxSearch.Text.Trim()

        ' Scan for CSV files in the program folder
        Dim programFolder As String = Application.StartupPath
        Dim csvFiles() As String = System.IO.Directory.GetFiles(programFolder, "*.csv")

        ' Loop through each CSV file
        For Each csvFile As String In csvFiles
            ' Read the CSV file
            Dim lines() As String = System.IO.File.ReadAllLines(csvFile)

            ' Assume the first line contains the column headers
            Dim headers() As String = lines(0).Split(","c)

            ' Add columns to dgvStocklist if not added already
            If dgvStockList.ColumnCount = 0 Then
                For Each header As String In headers
                    dgvStockList.Columns.Add(header, header)
                Next
            End If

            ' Loop through each line (excluding the header line)
            For i As Integer = 1 To lines.Length - 1
                Dim values() As String = lines(i).Split(","c)

                ' Check if any value in the line contains the search text, excluding Quantity column
                Dim foundMatchingItem As Boolean = False
                For j As Integer = 0 To values.Length - 1
                    If dgvStockList.Columns(j).HeaderText.Trim().ToLower() <> "quantity" Then
                        If values(j).Contains(searchText, StringComparison.OrdinalIgnoreCase) Then
                            foundMatchingItem = True
                            Exit For
                        End If
                    End If
                Next

                ' If any value matches the search text, add the row to dgvStocklist
                If foundMatchingItem Then
                    dgvStockList.Rows.Add(values)
                End If
            Next
        Next
    End Sub




End Class



