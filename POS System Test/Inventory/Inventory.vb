Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inventory
    Public filePath As String = "Stock.csv"
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        StockCategoryAdd.Visible = True

    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        AddStock.Visible = True
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        StockHistory.Visible = True
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "Stock.csv"

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Initialize a HashSet to store unique categories
            Dim uniqueCategories As New HashSet(Of String)()

            ' Start the loop from index 1 to skip the header row
            For i As Integer = 1 To lines.Length - 1
                Dim values As String() = lines(i).Split(","c)

                ' Check if the line has at least 6 columns and the category is not already added
                If values.Length >= 6 AndAlso Not uniqueCategories.Contains(values(5)) Then
                    ' Add the category to the HashSet
                    uniqueCategories.Add(values(5))

                    ' Add the category to the ComboBox
                    cbxCategory.Items.Add(values(5))
                End If
            Next

            ' Add "All" as the first item
            cbxCategory.Items.Insert(0, "All")

            ' Select "All" by default
            cbxCategory.SelectedItem = "All"
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim selectedCategory As String = cbxCategory.SelectedItem.ToString

        ' Clear existing rows in DataGridView
        dgvStockList.Rows.Clear()

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Use a flag to track if the first row has been encountered
            Dim isFirstRow As Boolean = True

            ' Loop through each line in the CSV file
            For Each line As String In lines
                ' Skip the first row if "All" is selected
                If selectedCategory = "All" AndAlso isFirstRow Then
                    isFirstRow = False ' Set the flag to False after skipping the first row
                    Continue For
                End If

                Dim values As String() = line.Split(","c)

                ' Check if "All" is selected or if the line matches the selected category
                If selectedCategory = "All" OrElse (values.Length > 5 AndAlso values(5) = selectedCategory) Then
                    ' Add a new row to the DataGridView
                    dgvStockList.Rows.Add(values)
                End If
            Next
        Else
            MessageBox.Show("Stock.csv not found.")
        End If
    End Sub

End Class