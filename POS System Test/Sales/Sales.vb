Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Sales
    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click
        Dim newGuid As Guid = Guid.NewGuid()
        Dim referencenumber As String = newGuid.ToString()
        Dim filePath As String = "receipts/" & referencenumber & ".csv"
        Dim directoryPath As String = "receipts/"
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        ' Check if the CSV file exists, if not, create it and write the header
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine($"Reference Number,{referencenumber}")
                writer.WriteLine($"Date and Time,{DateAndTime.Now}")
                writer.WriteLine($"Customer,{txbxName.Text}")
                writer.WriteLine("Category, ID, Product, Price, Quantity, Subtotal")
                For Each row As DataGridViewRow In dgvAddedList.Rows

                    Dim category As String = $"{row.Cells(0).Value.ToString()}.csv"

                    ' Check if the file exists
                    If File.Exists(category) Then
                        Try
                            ' Read all lines from the CSV file
                            Dim lines As String() = File.ReadAllLines(category)

                            ' Find the line with matching ID
                            For Each line As String In lines
                                Dim columns As String() = line.Split(","c) ' Assuming comma-separated values

                                ' Check if the ID in the first column matches
                                If columns.Length > 0 AndAlso columns(0) = row.Cells(1).Value.ToString() Then
                                    ' Subtract the quantity from the line
                                    Dim currentQuantity As Integer = Integer.Parse(columns(3)) ' Assuming the quantity is in the fourth column
                                    Dim saleQuantity As Integer = Integer.Parse(row.Cells(4).Value.ToString()) ' Assuming the quantity to subtract is in the fifth column

                                    ' Update the quantity
                                    Dim newQuantity As Integer = currentQuantity - saleQuantity

                                    ' Ensure the quantity doesn't go below zero
                                    If newQuantity < 0 Then
                                        newQuantity = 0
                                    End If

                                    ' Update the line with new quantity
                                    columns(3) = newQuantity.ToString()

                                    ' Join the columns back into a line
                                    Dim updatedLine As String = String.Join(",", columns)

                                    ' Replace the line in the array of lines
                                    lines(Array.IndexOf(lines, line)) = updatedLine
                                End If
                            Next

                            ' Write the updated lines back to the CSV file
                            File.WriteAllLines(category, lines)
                            With row
                                writer.WriteLine($"{ .Cells(0).Value.ToString}, { .Cells(1).Value.ToString}, { .Cells(2).Value.ToString}, { .Cells(3).Value.ToString}, { .Cells(4).Value.ToString}, { .Cells(5).Value.ToString}")
                            End With

                        Catch ex As Exception
                            MessageBox.Show($"Error processing file '{category}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        ' Handle the case where the file doesn't exist
                        MessageBox.Show($"File '{category}' not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
                writer.WriteLine($",,,,Total, {showTotalPrice.Text}")
                Using log As New StreamWriter("Sales History.csv", True)
                    log.WriteLine($"{referencenumber},{txbxName.Text}, {showTotalPrice.Text}, {DateAndTime.Now}")
                End Using
            End Using
        End If
        dgvAddedList.Rows.Clear()
    End Sub

    Private Sub txbxID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbxID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If Enter key is pressed, handle the event
            btAddStock_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        For Each Item As String In cbxCategory.Items
            If File.Exists($"{Item}.csv") Then
                Dim lines As String() = File.ReadAllLines($"{Item}.csv")
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

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Dim itemExists As Boolean = False
        Dim rowIndex As Integer = -1

        ' Search for existing item in DataGridView
        For Each row As DataGridViewRow In dgvAddedList.Rows
            If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = txbxID.Text Then
                itemExists = True
                rowIndex = row.Index
                Exit For
            End If
        Next
        If String.IsNullOrEmpty(txbxID.Text) OrElse String.IsNullOrEmpty(txbxProduct.Text) OrElse String.IsNullOrEmpty(txbxPrice.Text) OrElse String.IsNullOrEmpty(txbxQty.Text) OrElse String.IsNullOrEmpty(cbxCategory.SelectedItem.ToString) Then
            MessageBox.Show("Please fill in all the required fields.")
        Else
            If itemExists Then
                ' If item exists, update quantity and total
                Dim newQty As Single = Single.Parse(txbxQty.Text)
                Dim currentQty As Single = Single.Parse(dgvAddedList.Rows(rowIndex).Cells(4).Value.ToString())
                Dim updatedQty As Single = currentQty + newQty
                dgvAddedList.Rows(rowIndex).Cells(4).Value = updatedQty.ToString()

                Dim newTotal As Single = Single.Parse(txbxPrice.Text) * updatedQty
                dgvAddedList.Rows(rowIndex).Cells(5).Value = newTotal.ToString()
            Else
                ' If item does not exist, add a new row
                dgvAddedList.Rows.Add(
                    cbxCategory.SelectedItem.ToString(),
                    txbxID.Text,
                    txbxProduct.Text,
                    txbxPrice.Text,
                    txbxQty.Text,
                    (Single.Parse(txbxPrice.Text) * Single.Parse(txbxQty.Text)).ToString()
                    )
            End If
        End If

        ' Sum up all values in the last column and display the total
        Dim totalPrice As Single = 0
        For Each row As DataGridViewRow In dgvAddedList.Rows
            If row.Cells(5).Value IsNot Nothing Then
                totalPrice += Single.Parse(row.Cells(5).Value.ToString())
            End If
        Next
        showTotalPrice.Text = "Php" & totalPrice.ToString("0.00")
    End Sub
End Class