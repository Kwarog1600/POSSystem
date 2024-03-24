Imports System.ComponentModel
Imports System.IO

Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadCategories()
            AddItemsFromAllCategories()
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

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        PopulateDataGridViewForCategory(cbxCategory.SelectedItem.ToString)
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

                                ' Check if the value already exists in the DataGridView
                                Dim existingValue As String = dgvStockList.Rows(rowIndex).Cells(columnIndex).Value?.ToString()
                                If existingValue <> values(i) Then
                                    dgvStockList.Rows(rowIndex).Cells(columnIndex).Value = values(i)
                                End If
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
        Dim searchText As String = txbxSearch.Text.Trim().ToLower()

        ' Clear dgvStockList before anything else
        dgvStockList.Rows.Clear()

        ' Iterate through each category in cxbxCategory
        For Each category As String In cbxCategory.Items
            If category <> "All" Then
                Dim csvFileName As String = category & ".csv" ' Assuming CSV file names are based on the category names
                If File.Exists(csvFileName) Then
                    Using reader As New StreamReader(csvFileName)
                        ' Skip the first line (column headers)
                        reader.ReadLine()

                        ' Read each line in the CSV file
                        While Not reader.EndOfStream
                            Dim line As String = reader.ReadLine()
                            Dim values As String() = line.Split(","c) ' Assuming CSV files are comma-separated

                            ' Check if any value in the current line contains the search text
                            For Each value As String In values
                                If value.ToLower().Contains(searchText) Then
                                    ' If a match is found, add the values to dgvStockList
                                    dgvStockList.Rows.Add(values)
                                    Exit While ' Exit the inner loop since we found a match in this file
                                End If
                            Next
                        End While
                    End Using
                Else
                    MessageBox.Show("CSV file not found for category: " & category, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub PopulateDataGridViewForCategory(selectedCategory As String)
        Try
            ' Clear existing columns and rows in dgvStockList
            dgvStockList.Columns.Clear()
            dgvStockList.Rows.Clear()

            ' Dictionary to store headers and corresponding column indices
            Dim headerColumnIndex As New Dictionary(Of String, Integer)

            ' Add a common "ID" column
            dgvStockList.Columns.Add("ID", "ID")

            ' Add columns for the selected category (if not "All")
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
                End If
            Else
                ' If "All" selected, you can handle what you want to show in the DataGridView here.
                AddItemsFromAllCategories()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading items for the selected category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class



