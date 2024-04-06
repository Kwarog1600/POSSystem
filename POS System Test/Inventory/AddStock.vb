Imports System.Drawing.Printing
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
                        File.AppendAllText("Resources/Stock History.csv", logEntry & Environment.NewLine)

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
                    File.AppendAllText("Resources\Stock History.csv", $"{transactionRefNumber},{row.Cells("clmID").Value},{row.Cells("clmProduct").Value},{row.Cells("clmQuantity").Value},{DateTime.Now}" & Environment.NewLine)
                End If
            Else
                MessageBox.Show($"Category file '{categoryFilePath}' not found.")
            End If
        Next
        ' Notify the user that the stock has been saved for all items
        RefreshTable()
        MessageBox.Show("Stock saved successfully.")
    End Sub

    Private Sub PrintReceipt(referencenumber As String, dgvAdded As DataGridView, name As String, totalPrice As String, saleDate As DateTime)
        ' Create an instance of PrintDocument
        Dim printDoc As New Printing.PrintDocument()

        ' Set the PrintPage event handler to generate the receipt content
        AddHandler printDoc.PrintPage, Sub(senderPrint, ePrint)
                                           ' Your logic to draw the receipt content on the print page
                                           ePrint.Graphics.DrawString($"Reference: {referencenumber}", New Font("Arial", 9), Brushes.Black, 100, 100)
                                           ePrint.Graphics.DrawString($"Name: {name}", New Font("Arial", 9), Brushes.Black, 100, 120)
                                           ePrint.Graphics.DrawString($"Sale Date: {saleDate.ToString("MM/dd/yyyy")}", New Font("Arial", 9), Brushes.Black, 100, 140)
                                           ' Iterate through the rows in dgvAddedList and draw the content in a tabular format
                                           Dim yPos As Integer = 160  ' Start position for items
                                           Dim columnWidth As Integer = 100
                                           For Each row As DataGridViewRow In dgvAdded.Rows
                                               ' Draw the item details in a tabular format
                                               Dim xPosition As Integer = 100
                                               For Each cell As DataGridViewCell In row.Cells
                                                   If Not cell.ColumnIndex = 0 Then
                                                       If cell.ColumnIndex = 2 Then
                                                           ePrint.Graphics.DrawString($"{cell.Value}", New Font("Arial", 9), Brushes.Black, xPosition, yPos)
                                                           xPosition += columnWidth + 75  ' Adjust the width based on column content
                                                       Else
                                                           ePrint.Graphics.DrawString($"{cell.Value}", New Font("Arial", 9), Brushes.Black, xPosition, yPos)
                                                           xPosition += columnWidth  ' Adjust the width based on column content
                                                       End If

                                                   End If
                                               Next
                                               yPos += 20  ' Increase the Y position for the next item
                                           Next
                                           ePrint.Graphics.DrawString("Total Price:", New Font("Arial", 9), Brushes.Black, 475, yPos + 20)
                                           ePrint.Graphics.DrawString($"{totalPrice}", New Font("Arial", 9, FontStyle.Bold), Brushes.Black, 575, yPos + 20)
                                           ePrint.Graphics.DrawString($"Sold by: {MainForm.lbUsername.Text}", New Font("Arial", 9), Brushes.Black, 100, yPos + 40)
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
End Class
