Imports System.Drawing.Printing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module AppModule
    'Variables
    Public filepath As String
    Public line As String
    Public headers() As String
    Public contents As List(Of String)
    Dim csvcontents As List(Of String)

    Public Function ReadCsv(filePath As String) As List(Of String)
        Using reader As New StreamReader(filePath)
            csvcontents = New List(Of String)
            While Not reader.EndOfStream
                csvcontents.Add(reader.ReadLine)
            End While
        End Using
        Return csvcontents
    End Function

    Public Function CountMatch(content As String, index As Integer, filepath As String) As Integer
        Dim match As Integer = 0
        For Each line As String In ReadCsv(filepath)
            Dim items = line.Split(",")
            If items(index) = content Then
                match += 1
            End If
        Next
        Return match
    End Function

    Public Sub RefreshTable(filePath As String, ByRef table As DataGridView)
        contents = ReadCsv(filePath)
        Dim headers As String() = contents(0).Split(",")
        For Each header As String In headers
            table.Columns.Add(header, header)
        Next
        For i As Integer = 1 To contents.Count - 1
            Dim line = contents(i)
            Dim items() = line.Split(",")
            Dim j As Integer = 0
            table.Rows.Add()
            For Each item As String In items
                table.Rows(table.Rows.Count - 1).Cells(headers(j)).Value = item
                j += 1
            Next
        Next
    End Sub

    Public Sub AddCategory(filepath As String, category As String, table As DataGridView)
        Dim Stockheader As String = "Product ID,Product Name,Price,Quantity"
        contents = ReadCsv(filepath)
        If contents.Contains(category) Then
            MessageBox.Show("Category already exists")
        Else
            contents.Add(category)
            Dim sortedContents = contents.Skip(1).OrderBy(Function(x) x).ToList()
            sortedContents.Insert(0, contents(0))
            contents = sortedContents
            File.WriteAllLines(filepath, contents)
            For Each item In table.Rows
                If item IsNot Nothing Then
                    Stockheader += $",{item.Cells(0).Value}"
                End If
            Next
            Stockheader += Environment.NewLine
            CreateNewCsv($"Stock\{category}.csv", Stockheader)
            contents.Clear()
        End If
    End Sub

    Public Sub CreateNewCsv(filepath As String, headers As String)
        Dim headerList As New List(Of String)
        headerList.Add(headers)
        File.WriteAllLines(filepath, headerList)
    End Sub

    Public Sub UpdateQty(filepath As String, content As List(Of String), refheader As List(Of String))
        contents = ReadCsv(filepath)
        Dim headers() As String = contents(0).Split(","c)
        For i As Integer = 0 To contents.Count - 1
            Dim line() As String = contents(i).Split(","c)
            If line(0) = content(0) Then
                line(3) = content(3)
                contents(i) = String.Join(",", line)
            End If
        Next
        File.WriteAllLines(filepath, contents)
    End Sub

    Public Sub AddtoTable(ByRef table As DataGridView, item As List(Of String), headers As List(Of String))
        For Each header As String In headers
            If Not table.Columns.Contains(header) Then
                table.Columns.Add(header, header)
            End If
        Next
        table.Rows.Add()
        For Each cellcontent As String In item
            table.Rows(table.Rows.Count - 1).Cells(headers(item.IndexOf(cellcontent))).Value = cellcontent
        Next
    End Sub

    Public Function HashPassword(password As String) As String
        ' Convert the password to bytes
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)

        ' Create a SHA256 hash
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(bytes)

            ' Convert hashed bytes to a string
            Dim builder As StringBuilder = New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function


    Public Sub switchPanel(ByVal panel As Form)
        With MainForm.pnlSwitch
            .Controls.Clear()
            panel.TopLevel = False
            .Controls.Add(panel)
            panel.Show()
        End With
    End Sub

    Public Sub LogReg(InOut As String, Username As String)
        Dim csvFilePath As String = $"Resources\TimeLog.csv"
        Using Write As New StreamWriter(csvFilePath, True)
            Write.WriteLine($"Logged {InOut},{DateTime.Now},{Username}")
        End Using
    End Sub

    Public Sub PrintReceipt(referencenumber As String, dgvAdded As DataGridView, name As String, totalPrice As String, saleDate As DateTime)
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

    Public Sub AccessLevel(level As Integer)
        If level = 1 Then
            Inventory.btAddCategory.Visible = False
            Inventory.btStockHistory.Visible = False
            MainForm.pnlAdminContainer.Visible = False
            MainForm.btExpenses.Visible = False
        ElseIf level = 2 Then
            MainForm.pnlAdminContainer.Visible = False
        ElseIf level = 3 Then
            MainForm.pnlAdminContainer.Visible = True
        End If
    End Sub

End Module
