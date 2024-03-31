Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Inventory
    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        AddStock.Visible = True
    End Sub

    Private Sub btAddCategory_Click(sender As Object, e As EventArgs) Handles btAddCategory.Click
        StockCategoryAdd.Visible = True
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim filePath As String = "Stock Category.csv"
        dgvStockList.Rows.Clear()
        If cbxCategory.SelectedIndex = 0 Then
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
            LoadStock(cbxCategory.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Public Sub LoadCategories()
        Dim filePath As String = "Stock Category.csv"

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Clear the existing items in the ComboBox
            cbxCategory.Items.Clear()
            cbxCategory.Items.Add("All")

            ' Start from the second line (index 1) to skip the header
            For i As Integer = 1 To lines.Length - 1
                ' Split the line by comma (assuming it's a CSV file)
                Dim category As String() = lines(i).Split(","c)

                ' Add the category to the ComboBox
                cbxCategory.Items.Add(category(0)) ' Assuming category name is in the first column
            Next

            ' Select the first item by default
            If cbxCategory.Items.Count > 0 Then
                cbxCategory.SelectedIndex = 0
            End If
        Else
            MessageBox.Show("Stock Category.csv file not found.")
        End If
    End Sub

    Private Sub btStockHistory_Click(sender As Object, e As EventArgs) Handles btStockHistory.Click
        StockHistory.Visible = True
    End Sub

    Private Sub LoadStock(category As String)

        Dim filePath As String = category & ".csv"

        If System.IO.File.Exists(filePath) Then
            Using parser As New TextFieldParser(filePath)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(",")

                ' Skip header row
                parser.ReadLine()

                While Not parser.EndOfData
                    Dim fields As String() = parser.ReadFields()
                    dgvStockList.Rows.Add(fields)
                End While
            End Using
        Else
            MessageBox.Show("File not found: " & filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class



