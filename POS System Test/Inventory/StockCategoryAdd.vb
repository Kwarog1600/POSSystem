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
        Dim headers As New List(Of String) From {"ID", "Brand", "Model", "Quantity"}
        headers.AddRange(descriptions)

        ' Get the filename for the new category CSV file
        Dim filename As String = category & ".csv"

        ' Construct full file path for the new category CSV file in the program folder
        Dim filePath As String = Path.Combine(Application.StartupPath, filename)

        ' Write headers and dummy data to the new category CSV file
        Using sw As New StreamWriter(filePath, False, Encoding.UTF8)
            sw.WriteLine(String.Join(",", headers))
            ' You can add some dummy data here if needed
            sw.WriteLine(String.Join(",", Enumerable.Repeat("", headers.Count)))
        End Using

        ' Write category name and descriptions to "Stock Categories.csv"
        Dim categoryInfo As String = $"{category},{String.Join("|", descriptions)}"
        File.AppendAllText(stockCategoriesFilePath, categoryInfo & Environment.NewLine)

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
End Class











