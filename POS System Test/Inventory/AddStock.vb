Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar

Public Class AddStock
    Dim categoryFilePath As String = "Resources/Stock Category.csv"
    Dim categoryNames As New List(Of String)


    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        If File.Exists(categoryFilePath) Then
            Dim lines As String() = File.ReadAllLines(categoryFilePath)
            ' Skip header (first line)
            For Each line As String In lines.Skip(1)
                ' Extract category names and populate ComboBox
                Dim categoryName As String = line.Split(","c)(0)
                cbxCategory.Items.Add(categoryName)
                categoryNames.Add(categoryName)
            Next
        Else
            MessageBox.Show("Categories file not found.")
        End If
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        For Each Item As String In cbxCategory.Items
            If File.Exists($"Stock\{Item}.csv") Then
                Dim lines As String() = File.ReadAllLines($"Stock\{Item}.csv")
                For Each line As String In lines
                    Dim contents As String() = line.Split(","c)
                    If contents(0).Trim = txbxID.Text.Trim Then
                        txbxProduct.Text = contents(1)
                        txbxPrice.Text = contents(2)
                        txbxQty.Text = "1"
                        cbxCategory.Text = Item
                        Exit Sub
                    Else
                        txbxProduct.Text = ""
                        txbxPrice.Text = ""
                        txbxQty.Text = "1"
                        cbxCategory.Text = ""
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        ' Add information to DataGridView
        If String.IsNullOrEmpty(txbxID.Text) OrElse String.IsNullOrEmpty(txbxProduct.Text) OrElse String.IsNullOrEmpty(txbxPrice.Text) OrElse String.IsNullOrEmpty(txbxQty.Text) OrElse String.IsNullOrEmpty(cbxCategory.SelectedItem.ToString) Then
            MessageBox.Show("Please fill in all the required fields.")
        Else
            dgvAddedList.Rows.Add(cbxCategory.SelectedItem.ToString(), txbxID.Text, txbxProduct.Text, txbxPrice.Text, txbxQty.Text)
        End If

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        ' Initialize a transaction reference number
        Dim transactionRefNumber As String = Guid.NewGuid().ToString()

        ' Iterate through each row in the DataGridView
        For Each row As DataGridViewRow In dgvAddedList.Rows
            ' Read the selected category from the ComboBox for each row
            Dim categoryName As String = row.Cells("clmCategory").Value.ToString()
            ' Construct the path to the category file for each row
            Dim categoryFilePath As String = $"Stock\{categoryName}.csv"

            ' Check if the category file exists
            If File.Exists(categoryFilePath) Then
                ' Read all lines from the category file
                Dim lines As String() = File.ReadAllLines(categoryFilePath)

                ' Flag to check if a match is found
                Dim matchFound As Boolean = False

                ' Iterate over each line (excluding the header)
                For i As Integer = 1 To lines.Length - 1
                    ' Split the line into individual values
                    Dim values As String() = lines(i).Split(","c)
                    ' Check if the Product ID matches the current ID in the DataGridView
                    If values(0) = row.Cells("clmID").Value.ToString() Then
                        ' Add the new quantity to the existing quantity
                        Dim newQuantity As Integer = Integer.Parse(values(3)) + Integer.Parse(row.Cells("clmQuantity").Value.ToString())
                        ' Update the quantity in the line
                        lines(i) = $"{values(0)},{values(1)},{values(2)},{newQuantity},{categoryName}"
                        ' Write the updated lines back to the category file
                        File.WriteAllLines(categoryFilePath, lines)

                        ' Log the transaction into Stock History.csv
                        Dim logEntry As String = $"{transactionRefNumber},{values(0)},{values(1)},{row.Cells("clmQuantity").Value},{DateTime.Now}"
                        File.AppendAllText("Stock History.csv", logEntry & Environment.NewLine)

                        ' Set the flag to true since a match is found
                        matchFound = True

                        ' Exit the loop once the update is done for the current row
                        Exit For
                    End If
                Next

                ' If no match is found, append the data to the CSV file
                If Not matchFound Then
                    Dim newData As String = $"{row.Cells("clmID").Value},{row.Cells("clmProduct").Value},{row.Cells("clmPrice").Value},{row.Cells("clmQuantity").Value}"
                    File.AppendAllText(categoryFilePath, newData & Environment.NewLine)
                    File.AppendAllText("Stock History.csv", $"{transactionRefNumber},{row.Cells("clmID").Value},{row.Cells("clmProduct").Value},{row.Cells("clmQuantity").Value},{DateTime.Now}" & Environment.NewLine)
                End If
            Else
                MessageBox.Show($"Category file '{categoryFilePath}' not found.")
            End If
        Next
        ' Notify the user that the stock has been saved for all items
        Inventory.RefreshTable()
        MessageBox.Show("Stock saved successfully.")
    End Sub


End Class
