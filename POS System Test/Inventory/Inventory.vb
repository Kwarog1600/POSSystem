Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inventory
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

        cbxCategory.SelectedItem = "All"

        ' Specify the path to your CSV file
        Dim filePath As String = "Stock.csv"
        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Start the loop from index 1 to skip the first line (header)
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim values As String() = line.Split(","c)

                ' Add a new row to the DataGridView
                DataGridView1.Rows.Add(values)
            Next
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub
End Class