Imports System.IO

Module CreateFiles
    Public Sub CreateCsvFileIfNotExists(fileName As String, header As String)
        Dim filePath As String = fileName

        ' Check if the CSV file exists, if not, create it and write the header
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(header)
            End Using
        End If
    End Sub

    Public Sub CreateStarting()
        Directory.CreateDirectory("Stock")
        Directory.CreateDirectory("Receipts")
        Directory.CreateDirectory("Resources")
        Directory.CreateDirectory("Stock History")

        CreateCsvFileIfNotExists($"Resources/Users.csv", "User ID,Username,Password,Access Level, First Name, Last Name" & vbLf & $"U000,admin,{HashPassword("admin")},3,admin,admin")
        CreateCsvFileIfNotExists("Resources/Expenses.csv", "Date and Time,name,Purpose,Amount, Added by")
        CreateCsvFileIfNotExists("Resources/Sales History.csv", "Date,Transaction Reference,Customer Name,Total Amount,Sold By")
        CreateCsvFileIfNotExists("Resources/Stock Category.csv", "CategoryName")
        CreateCsvFileIfNotExists("Resources/Stock History.csv", "Date,Transaction Reference,Quantity,by User")
        CreateCsvFileIfNotExists("Resources/TimeLog.csv", "Log,Date and Time,Username")
    End Sub
End Module
