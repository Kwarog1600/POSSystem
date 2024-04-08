Imports System.Drawing.Printing

Module AddStockModule
    Sub PrintReceipt(referencenumber As String, dgvAdded As DataGridView, saleDate As DateTime)
        ' Create an instance of PrintDocument
        Dim printDoc As New Printing.PrintDocument()

        ' Set the PrintPage event handler to generate the receipt content
        AddHandler printDoc.PrintPage, Sub(senderPrint, ePrint)
                                           ' Your logic to draw the receipt content on the print page
                                           ePrint.Graphics.DrawString($"Reference: {referencenumber}", New Font("Arial", 9), Brushes.Black, 100, 100)
                                           ePrint.Graphics.DrawString($"Sale Date: {saleDate.ToString("MM/dd/yyyy")}", New Font("Arial", 9), Brushes.Black, 100, 140)
                                           ' Iterate through the rows in dgvAddedList and draw the content in a tabular format
                                           Dim yPos As Integer = 160  ' Start position for items
                                           Dim columnWidth As Integer = 100
                                           For Each row As DataGridViewRow In dgvAdded.Rows
                                               ' Draw the item details in a tabular format
                                               Dim xPosition As Integer = 100
                                               For Each cell As DataGridViewCell In row.Cells
                                                   If cell.ColumnIndex <> 1 And cell.ColumnIndex <> 0 And cell.ColumnIndex <> 3 Then ' Exclude the 2nd column (index 1)
                                                       ePrint.Graphics.DrawString($"{cell.Value}", New Font("Arial", 9), Brushes.Black, xPosition, yPos)
                                                       xPosition += columnWidth  ' Adjust the width based on column content
                                                   End If
                                               Next
                                               yPos += 20  ' Increase the Y position for the next item
                                           Next
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
        printDoc.PrinterSettings.PrintFileName = $"Stock History/{referencenumber}.pdf"
        ' Start printing
        printDoc.Print()
    End Sub
End Module
