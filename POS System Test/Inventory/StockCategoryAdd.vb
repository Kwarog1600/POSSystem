Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btAddCat.Click
        Dim category As String = txbxCategory.Text.Trim()
        Dim descriptions As New List(Of String)

        ' Extract descriptions from the Guna2DataGridView
        For Each row As DataGridViewRow In dgvCatDescr.Rows
            If Not row.IsNewRow Then
                descriptions.Add(row.Cells(0).Value.ToString())
            End If
        Next

        ' Check if the category already exists in the "Stock Categories.csv" file
        Dim stockCategoriesFilePath As String = Path.Combine(Application.StartupPath, "Stock Category.csv")
        If CategoryExists(stockCategoriesFilePath, category) Then
            MessageBox.Show("Category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method without proceeding
        End If

        ' Construct headers for the new category CSV file
        Dim headers As New List(Of String) From {"ID", "Price", "Brand", "Model", "Quantity"}
        headers.AddRange(descriptions)

        ' Get the filename for the new category CSV file
        Dim filename As String = category & ".csv"

        ' Construct full file path for the new category CSV file in the program folder
        Dim filePath As String = Path.Combine(Application.StartupPath, filename)

        ' Write category name and descriptions to "Stock Categories.csv"
        Dim categoryInfo As String = $"{category},{String.Join("|", descriptions)}"
        File.AppendAllText(stockCategoriesFilePath, categoryInfo & Environment.NewLine)
        PopulateCategoryComboBox()
        MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function CategoryExists(filePath As String, category As String) As Boolean
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim parts As String() = line.Split(","c)
                If parts.Length > 0 AndAlso parts(0) = category Then
                    Return True ' Category already exists
                End If
            Next
        End If
        Return False ' Category does not exist
    End Function

    Private Sub PopulateCategoryComboBox()
        ' Define the path to "Stock Category.csv" file
        Dim stockCategoriesFilePath As String = Path.Combine(Application.StartupPath, "Stock Category.csv")

        ' Check if the file exists
        If File.Exists(stockCategoriesFilePath) Then
            Try
                ' Read all lines from the file
                Dim lines As String() = File.ReadAllLines(stockCategoriesFilePath)

                ' Clear existing items in the ComboBox
                Inventory.cbxCategory.Items.Clear()

                ' Iterate through each line starting from index 1 (to skip header)
                For i As Integer = 1 To lines.Length - 1
                    ' Split the line by comma to get individual values
                    Dim values As String() = lines(i).Split(","c)

                    ' Add the category name to the ComboBox
                    Inventory.cbxCategory.Items.Add(values(0)) ' Assuming the category name is in the first column
                Next

                ' If you want to select the first category by default
                If Inventory.cbxCategory.Items.Count > 0 Then
                    Inventory.cbxCategory.SelectedIndex = 0
                End If

            Catch ex As Exception
                ' Handle any exceptions that might occur during file reading
                MessageBox.Show($"Error reading file {stockCategoriesFilePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Handle case where file doesn't exist
            MessageBox.Show($"File does not exist: {stockCategoriesFilePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class











