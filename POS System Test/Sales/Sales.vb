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
            Using log As New StreamWriter("Resources\Sales History.csv", True)
                log.WriteLine($"{referencenumber},{txbxName.Text}, {showTotalPrice.Text}, {DateAndTime.Now}, {MainForm.lbUsername.Text}")
            End Using
            PrintReceipt(referencenumber, dgvAddedList, txbxName.Text, showTotalPrice.Text, DateAndTime.Now)
            showTotalPrice.Text = "0.00"
            dgvAddedList.Rows.Clear()
        Else
            MessageBox.Show("Please add items to the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        InventoryModule1.RefreshTable()
    End Sub

    Private Sub txbxID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbxID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btAddStock_Click(sender, e)
        End If
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Dim count As Integer = CountIDMatches()
        For Each Item As String In cbxCategory.Items
            Dim read As String() = File.ReadAllLines($"Stock\{Item}.csv")
            For Each line As String In read
                Dim contents As String() = line.Split(","c)
                If contents(0).Trim.StartsWith(txbxID.Text.Trim) Then
                    cbxCategory.SelectedItem = $"{Item}"
                    txbxProduct.Text = contents(1)
                    txbxPrice.Text = contents(2)
                    txbxQty.Text = "1"
                    If contents.Length > 4 Then
                        If count > 1 Then
                            For Each row As DataGridViewRow In dgvDescr.Rows
                                row.Cells(1).Value = ""
                            Next
                        Else
                            For i As Integer = 4 To contents.Length - 1
                                dgvDescr.Rows(i - 4).Cells(1).Value = contents(i)
                            Next
                        End If
                    End If
                    Exit Sub
                Else
                        cbxCategory.SelectedItem = ""
                    txbxProduct.Text = ""
                    txbxPrice.Text = ""
                    txbxQty.Text = "1"
                End If
            Next
        Next
    End Sub

    Private Function CountIDMatches() As Integer
        Dim count As Integer = 0
        For Each Item As String In cbxCategory.Items
            If File.Exists($"Stock\{Item}.csv") Then
                Dim lines As String() = File.ReadAllLines($"Stock\{Item}.csv")
                For Each line As String In lines
                    Dim contents As String() = line.Split(","c)
                    If contents(0).Trim.StartsWith(txbxID.Text.Trim) Then
                        count += 1
                    End If
                Next
            End If
        Next
        Return count
    End Function

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
                                           ePrint.Graphics.DrawString($"Name: {name}", New Font("Arial", 9), Brushes.Black, 100, 120)
                                           ePrint.Graphics.DrawString($"Sale Date: {saleDate.ToString("MM/dd/yyyy")}", New Font("Arial", 9), Brushes.Black, 100, 140)
                                           ' Iterate through the rows in dgvAddedList and draw the content in a tabular format
                                           Dim yPos As Integer = 160  ' Start position for items
                                           Dim columnWidth As Integer = 100
                                           For Each row As DataGridViewRow In dgvAdded.Rows
                                               ' Draw the item details in a tabular format
                                               Dim xPosition As Integer = 100
                                               For Each cell As DataGridViewCell In row.Cells
                                                   If cell.ColumnIndex <> 1 And cell.ColumnIndex <> 0 Then ' Exclude the 2nd column (index 1)
                                                       ePrint.Graphics.DrawString($"{cell.Value}", New Font("Arial", 9), Brushes.Black, xPosition, yPos)
                                                       xPosition += columnWidth  ' Adjust the width based on column content
                                                   End If
                                               Next
                                               yPos += 20  ' Increase the Y position for the next item
                                           Next
                                           ePrint.Graphics.DrawString("Total Price:", New Font("Arial", 9), Brushes.Black, 100, yPos + 20)
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

    Private Sub LoadCategories()
        Dim filePath As String = "Resources/Stock Category.csv"

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Clear the existing items in the ComboBox
            cbxCategory.Items.Clear()

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
        If txbxID.Text.Trim Is Nothing Then
            MessageBox.Show("Please enter an ID")
            Exit Sub
        Else
            Dim count As Integer = CountIDMatches()
            Dim DescrCol As New List(Of String)
            Dim Descr As New List(Of String)

            If count = 1 Then
                For Each row In dgvDescr.Rows
                    Dim columnName As String = row.Cells(0).Value.ToString
                    If Not dgvAddedList.Columns.Contains(columnName) Then
                        DescrCol.Add(columnName)
                        dgvAddedList.Columns.Add(columnName, columnName)
                    End If
                Next
                For Each Item As String In cbxCategory.Items
                    Dim read As String() = File.ReadAllLines($"Stock\{Item}.csv")
                    For Each line As String In read
                        Dim contents As String() = line.Split(","c)
                        Dim Id As String = contents(0)
                        If Id.StartsWith(txbxID.Text.Trim) Then
                            Dim total As Decimal = 0
                            For Each row In dgvAddedList.Rows
                                If row.Cells(1).Value.ToString() = Id Then
                                    row.Cells(4).Value = Convert.ToInt32(row.Cells(4).Value) + Convert.ToInt32(txbxQty.Text)
                                    row.Cells(5).Value = (Decimal.Parse(row.cells(4).Value) * Decimal.Parse(row.Cells(3).Value))
                                    total = 0
                                    For Each amount As DataGridViewRow In dgvAddedList.Rows
                                        total += Decimal.Parse(amount.Cells(5).Value.ToString())
                                    Next
                                    showTotalPrice.Text = total.ToString("0.00")
                                    Exit Sub
                                End If
                            Next
                            Dim newRow As New DataGridViewRow()
                            dgvAddedList.Rows.Add(cbxCategory.SelectedItem.ToString, Id, txbxProduct.Text, txbxPrice.Text, txbxQty.Text, (Decimal.Parse(txbxPrice.Text) * Decimal.Parse(txbxQty.Text)).ToString("0.00"))
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each row In dgvDescr.Rows
                                DescrCol.Add(row.Cells(0).Value.ToString)
                                Descr.Add(row.Cells(1).Value.ToString)
                            Next
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each col In DescrCol
                                newRow.Cells(col).Value = Descr(DescrCol.IndexOf(col))
                            Next
                            total = 0
                            For Each amount As DataGridViewRow In dgvAddedList.Rows
                                total += Decimal.Parse(amount.Cells(5).Value.ToString())
                            Next
                            showTotalPrice.Text = total.ToString("0.00")
                        End If
                    Next
                Next
            ElseIf count > 1 Then
                MessageBox.Show("ID matches multiple items. You may choose one category and put description to find the matching item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btVoid_Click(sender As Object, e As EventArgs) Handles btVoid.Click
        dgvAddedList.Rows.Clear()
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim Category As String = cbxCategory.SelectedItem.ToString
        Dim filePath As String = $"Stock\{Category}.csv"
        dgvDescr.Rows.Clear()

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            If lines.Length > 0 Then
                Dim columnHeaders As String() = lines(0).Split(","c) ' Assuming columns are comma-separated
                ' Assuming columnHeaders is the array containing all the column headers
                If columnHeaders.Length > 4 Then
                    For i As Integer = 4 To columnHeaders.Length - 1
                        dgvDescr.Rows().Add(columnHeaders(i))
                        dgvDescr.Visible = True
                    Next
                Else
                    dgvDescr.Visible = False
                End If
            End If
        Else
            MessageBox.Show("Category file not found.")
        End If
    End Sub

End Class