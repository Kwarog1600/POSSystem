Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Module InventoryModule1
    Public Sub LoadCategories()
        With Inventory
            Dim filePath As String = "Resources/Stock Category.csv"

            ' Check if the file exists
            If File.Exists(filePath) Then
                ' Read all lines from the CSV file
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Clear the existing items in the ComboBox
                .cbxCategory.Items.Clear()
                .cbxCategory.Items.Add("All")

                ' Start from the second line (index 1) to skip the header
                For i As Integer = 1 To lines.Length - 1
                    ' Split the line by comma (assuming it's a CSV file)
                    Dim category As String() = lines(i).Split(","c)

                    ' Add the category to the ComboBox
                    .cbxCategory.Items.Add(category(0)) ' Assuming category name is in the first column
                Next

                ' Select the first item by default
                If .cbxCategory.Items.Count > 0 Then
                    .cbxCategory.SelectedIndex = 0
                End If
            Else
                MessageBox.Show("Stock Category.csv file not found.")
            End If
        End With
    End Sub



    Public Sub LoadStock(category As String)
        With Inventory
            Dim filePath As String = $"Stock\{category}.csv"

            If System.IO.File.Exists(filePath) Then
                Dim headers As String() = File.ReadLines(filePath).First().Split(","c)

                ' Add column headers to the DataGridView if they are not already added
                For Each header As String In headers

                    If Not .dgvStockList.Columns.Cast(Of DataGridViewColumn)().Any(Function(x) x.HeaderText = header) Then
                        .dgvStockList.Columns.Add(header, header)
                    End If
                Next

                ' Add remaining data to respective column headers
                Using reader As New StreamReader(filePath)
                    ' Skip the first line (headers)
                    reader.ReadLine()
                    While Not reader.EndOfStream
                        Dim dataLine As String = reader.ReadLine()
                        Dim data As String() = dataLine.Split(","c)
                        ' Add data to DataGridView
                        .dgvStockList.Rows.Add(data)
                    End While
                End Using
            Else
                MessageBox.Show("File not found: " & filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub

    Public Sub RefreshTable()
        With Inventory
            Dim filePath As String = "Resources/Stock Category.csv"
            .dgvStockList.Rows.Clear()
            .dgvStockList.Columns.Clear()
            If .cbxCategory.SelectedIndex = 0 Then
                Using reader As New StreamReader(filePath)
                    ' Skip header line
                    reader.ReadLine()
                    ' Read and process each line
                    Dim line As String
                    Do
                        line = reader.ReadLine()
                        If line IsNot Nothing Then
                            ' Call LoadStock method for each line
                            LoadStock(line)
                        End If
                    Loop Until line Is Nothing
                End Using
            Else
                LoadStock(.cbxCategory.SelectedItem.ToString)
            End If
        End With
    End Sub
End Module
