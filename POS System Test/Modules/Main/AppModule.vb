Imports System.Drawing.Printing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module AppModule
    'Variables
    Public filepath As String
    Public line As String
    Public headers() As String
    Public contents As List(Of String)
    Dim csvcontents As List(Of String)

    Public Sub ItemHash()

    End Sub

    Public Function ReadCsv(filePath As String) As List(Of String)
        Using reader As New StreamReader(filePath)
            csvcontents = New List(Of String)
            While Not reader.EndOfStream
                csvcontents.Add(reader.ReadLine)
            End While
        End Using
        Return csvcontents
    End Function

    Public Sub RefreshCat(ByRef cbx As ComboBox)
        contents = ReadCsv("Resources/Stock Category.csv")
        If contents.Count > 1 Then
            For i = 1 To contents.Count - 1
                cbx.Items.Add(contents(i))
            Next
        End If

    End Sub

    Public Function CountMatch(content As String, index As Integer) As Integer
        Dim match As Integer = 0
        Dim lines = ReadCsv("Resources/Stock Category.csv")

        ' Skip the header by starting the loop from the second line
        For i As Integer = 1 To lines.Count - 1
            Dim item = lines(i)
            Dim filepath As String = "Stock/" & item & ".csv"
            For Each line As String In ReadCsv(filepath)
                Dim items = line.Split(",")
                If items(index).StartsWith(content) Then
                    match += 1
                End If
            Next
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
        Dim Stockheader As String = "ID,Product,Price,Quantity"
        contents = ReadCsv(filepath)
        If contents.Contains(category) Then
            MessageBox.Show("Category already exists")
        Else
            contents.Add(category)
            Dim sortedContents = contents.Skip(1).OrderBy(Function(x) x).ToList()
            sortedContents.Insert(0, contents(0))
            contents = sortedContents
            File.WriteAllLines(filepath, contents)
            For Each item As DataGridViewRow In table.Rows
                If item.Cells(0).Value IsNot Nothing Then
                    Stockheader += $",{item.Cells(0).Value}"
                End If
            Next
            CreateNewCsv($"Stock\{category}.csv", Stockheader)
            contents.Clear()
        End If
    End Sub

    Public Sub CreateNewCsv(filepath As String, headers As String)
        Dim headerList As New List(Of String)
        headerList.Add(headers)
        File.WriteAllLines(filepath, headerList)
    End Sub

    Public Sub UpdateQty(filepath As String, content As List(Of String), refheader As List(Of String), Optional subtract As Boolean = False)
        contents = ReadCsv(filepath)
        Dim headers() As String = contents(0).Split(","c)
        For i As Integer = 0 To contents.Count - 1
            Dim line() As String = contents(i).Split(","c)
            If line(0) = content(0) Then
                If subtract Then
                    line(3) = (Integer.Parse(line(3)) - Integer.Parse(content(3))).ToString() ' Subtract quantity
                Else
                    line(3) = (Integer.Parse(line(3)) + Integer.Parse(content(3))).ToString() ' Add quantity
                End If
                contents(i) = String.Join(",", line)
                Exit For
            End If
        Next
        File.WriteAllLines(filepath, contents)
    End Sub

    Public Sub AddStockSub(filepath As String, addcontent As List(Of String), refheader As List(Of String))
        contents = ReadCsv(filepath)
        Dim headers() As String = contents(0).Split(","c)
        Dim match As Boolean = False
        For i As Integer = 0 To contents.Count - 1
            Dim item() As String = contents(i).Split(","c)
            If addcontent(0) = item(0) Then
                match = True
                Exit For ' Exit loop if match is found
            End If
        Next

        If Not match Then
            Dim NewLine(headers.Length - 1) As String ' Correct array size
            For i As Integer = 0 To refheader.Count - 1
                If addcontent(i) IsNot Nothing Then
                    Dim index As Integer = Array.IndexOf(headers, refheader(i))
                    If index <> -1 Then
                        NewLine(index) = addcontent(i)
                    End If
                End If
            Next
            Dim newStock As String = String.Join(",", NewLine)
            File.AppendAllText(filepath, newStock & Environment.NewLine)
        Else
            UpdateQty(filepath, addcontent, refheader)
        End If
    End Sub

    Public Sub AddtoTable(ByRef table As DataGridView, item As List(Of String), headers As List(Of String))
        For Each header As String In headers
            If Not table.Columns.Contains(header) Then
                table.Columns.Add(header, header)
            End If
        Next
        Dim found As Boolean = False
        For Each row As DataGridViewRow In table.Rows
            If row.Cells(1).Value.ToString() = item(1) Then
                found = True
                row.Cells(4).Value = Convert.ToInt32(row.Cells(4).Value) + Convert.ToInt32(item(4))
                Exit For
            End If
        Next
        If Not found Then
            table.Rows.Add()
            For Each cellcontent As String In item
                table.Rows(table.Rows.Count - 1).Cells(headers(item.IndexOf(cellcontent))).Value = cellcontent
            Next
        End If
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

    Public Sub LogReg(InOut As String, Username As String, Cash As String)
        Dim csvFilePath As String = $"Resources\TimeLog.csv"
        Using Write As New StreamWriter(csvFilePath, True)
            Write.WriteLine($"Logged {InOut},{DateTime.Now},{Username},{Cash}")
        End Using
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

    Public Function idHash(inputString As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputString))
        Dim hexString As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        Dim numericHash As Long = Convert.ToInt64(hexString.Substring(0, 12), 16)
        Return numericHash.ToString("D12")
    End Function

End Module
