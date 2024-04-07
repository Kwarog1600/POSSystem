Imports System.Drawing.Printing

Module AddStockModule
    Sub PrintReceipt(referencenumber As String, dgvAdded As DataGridView, saleDate As DateTime)
        ' Create a new PrintDocument
        Dim printDoc As New Printing.PrintDocument()

        ' Set the PrintPage event handler
        AddHandler printDoc.PrintPage, Sub(senderPrint, ePrint)
                                           ' Your logic to draw the receipt content
                                           ePrint.Graphics.DrawString($"Reference: {referencenumber}", New Font("Arial", 9), Brushes.Black, 100, 100)
                                           ePrint.Graphics.DrawString($"Sale Date: {saleDate.ToString("MM/dd/yyyy HH:mm:ss")}", New Font("Arial", 9), Brushes.Black, 100, 120)

                                           ' Iterate through the rows in the DataGridView and draw the content
                                           Dim yPos As Integer = 140
                                           For Each row As DataGridViewRow In dgvAdded.Rows
                                               Dim xPosition As Integer = 100
                                               For Each cell As DataGridViewCell In row.Cells
                                                   ePrint.Graphics.DrawString($"{cell.Value}", New Font("Arial", 9), Brushes.Black, xPosition, yPos)
                                                   xPosition += 100  ' Adjust the width based on content
                                               Next
                                               yPos += 20  ' Increase the Y position for the next row
                                           Next
                                       End Sub
        ' Calculate the required paper width and height based on the content
        Dim standardWidth As Integer = 500  ' Standard width for receipts
        Dim lineHeight As Integer = 50  ' Height of each line of text
        Dim totalHeight As Integer = 150 + (5 * lineHeight)  ' Total height based on the number of lines (1 reference)
        Dim requiredPaperSize As New PaperSize("Custom", standardWidth, totalHeight)

        ' Set the paper size to the calculated size
        printDoc.DefaultPageSettings.PaperSize = requiredPaperSize
        printDoc.DefaultPageSettings.Margins = New Margins(5, 5, 5, 5)

        printDoc.PrinterSettings.PrintToFile = True
        printDoc.PrinterSettings.PrintFileName = $"Stock History/{referencenumber}.pdf"

        ' Print the document
        printDoc.Print()
    End Sub
End Module
