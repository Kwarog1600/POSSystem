Imports System.IO

Module CreateFiles
    Public srcFolder As String
    Public Sub CreateFileIfNotExists(fileName As String, header As String)
        Dim filePath As String = fileName

        'Check if the CSV file exists, if not, create it and write the header
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(header)
            End Using
        End If
    End Sub

    Public Sub CreateStarting()
        CreateFileIfNotExists("conf.ini", "[SourceLocation]" & vbLf & $"csvsrc={srcFolder}")
        srcFolder = ReadIni("conf.ini", "SourceLocation", "csvsrc")
        Directory.CreateDirectory(srcFolder)
        Directory.CreateDirectory($"{srcFolder}\Stock")
        Directory.CreateDirectory($"{srcFolder}\Receipts")
        Directory.CreateDirectory($"{srcFolder}\Resources")
        Directory.CreateDirectory($"{srcFolder}\Stock History")
        CreateFileIfNotExists($"{srcFolder}\Resources/Users.csv", "User ID,Username,Password,Access Level, First Name, Last Name" & vbLf & $"U000,admin,{HashPassword("admin")},3,admin,admin")
        CreateFileIfNotExists($"{srcFolder}\Resources\Expenses.csv", "Date and Time,name,Purpose,Amount, Added by")
        CreateFileIfNotExists($"{srcFolder}\Resources\Sales History.csv", "Date,Transaction Reference,Customer Name,Total Amount,Profit,Sold By,Method, Paid")
        CreateFileIfNotExists($"{srcFolder}\Resources\Stock Category.csv", "CategoryName")
        CreateFileIfNotExists($"{srcFolder}\Resources\Stock History.csv", "Date,Transaction Reference,Quantity,by User,Amount Paid")
        CreateFileIfNotExists($"{srcFolder}\Resources\TimeLog.csv", "Log,Date and Time,Username, Start/End Cash")
    End Sub
End Module
