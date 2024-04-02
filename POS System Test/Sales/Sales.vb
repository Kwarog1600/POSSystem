Imports System.ComponentModel
Imports System.Drawing.Printing
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

        If dgvAddedList.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvAddedList.Rows

                Dim category As String = $"Stock\{row.Cells(0).Value.ToString()}.csv"

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



                    Catch ex As Exception
                        MessageBox.Show($"Error processing file '{category}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    ' Handle the case where the file doesn't exist
                    MessageBox.Show($"File '{category}' not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Next
            Using log As New StreamWriter("Sales History.csv", True)
                log.WriteLine($"{referencenumber},{txbxName.Text}, {showTotalPrice.Text}, {DateAndTime.Now}")
            End Using
            PrintReceipt(referencenumber, dgvAddedList, txbxName.Text, showTotalPrice.Text, DateAndTime.Now)
            showTotalPrice.Text = "0.00"
            dgvAddedList.Rows.Clear()
        Else
            MessageBox.Show("Please add items to the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txbxID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbxID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If Enter key is pressed, handle the event
            btAddStock_Click(sender, EventArgs.Empty)
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

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub PrintReceipt(referencenumber As String, dgvAdded As DataGridView, name As String, totalPrice As String, saleDate As DateTime)
        ' Create an instance of PrintDocument
        Dim printDoc As New Printing.PrintDocument()

        ' Set the PrintPage event handler to generate the receipt content
        AddHandler printDoc.PrintPage, Sub(senderPrint, ePrint)
                                           ' Your logic to draw the receipt content on the print page
                                           ePrint.Graphics.DrawString($"Reference: {referencenumber}", New Font("Arial", 9), Brushes.Black, 100, 100)
                                           ePrint.Graphics.DrawString($"Name: {name}", New Font("Arial", 9), Brushes.Black, 100, 150)
                                           ePrint.Graphics.DrawString($"Sale Date: {saleDate.ToString("MM/dd/yyyy")}", New Font("Arial", 9), Brushes.Black, 100, 200)

                                           ' Draw column headers
                                           Dim columnHeaders As String = "Product" & vbTab & vbTab & "Price" & vbTab & "Quantity" & vbTab & "Amount"  ' Adjust headers as needed
                                           ePrint.Graphics.DrawString(columnHeaders, New Font("Arial", 9, FontStyle.Bold), Brushes.Black, 100, 225)

                                           ' Iterate through the rows in dgvAddedList and draw the content
                                           Dim yPos As Integer = 250  ' Start position for items)
                                           For Each row As DataGridViewRow In dgvAdded.Rows
                                               ' Draw the item details
                                               Dim itemDetails As String = $"{row.Cells("clmProduct").Value}" & vbTab & $"{row.Cells("clmPrice").Value}" & vbTab & $"{row.Cells("clmQuantity").Value}" & vbTab & vbTab & $"{row.Cells("clmAmount").Value}"
                                               ePrint.Graphics.DrawString(itemDetails, New Font("Arial", 9), Brushes.Black, 100, yPos)
                                               ' Draw more item details as needed
                                               yPos += 20  ' Increase the Y position for the next item
                                           Next
                                           ePrint.Graphics.DrawString("Total Price:", New Font("Arial", 9), Brushes.Black, 100, yPos + 50)
                                           ePrint.Graphics.DrawString($"{totalPrice}", New Font("Arial", 9, FontStyle.Bold), Brushes.Black, 200, yPos + 50)
                                       End Sub

        ' Calculate the required paper width and height based on the content
        Dim standardWidth As Integer = 500  ' Standard width for receipts
        Dim lineHeight As Integer = 50  ' Height of each line of text
        Dim totalLines As Integer = 5 + dgvAdded.Rows.Count  ' Total lines of text content
        Dim totalHeight As Integer = 150 + (totalLines * lineHeight)  ' Total height based on the number of lines
        Dim requiredPaperSize As New PaperSize("Custom", standardWidth, totalHeight)

        ' Set the paper size to the calculated size
        printDoc.DefaultPageSettings.PaperSize = requiredPaperSize
        printDoc.DefaultPageSettings.Margins = New Margins(5, 5, 5, 5)

        printDoc.PrinterSettings.PrintToFile = True
        printDoc.PrinterSettings.PrintFileName = $"receipts/{referencenumber}.pdf"
        ' Start printing
        printDoc.Print()

    End Sub

    Public Sub LoadCategories()
        Dim filePath As String = "Resources/Stock Category.csv"

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