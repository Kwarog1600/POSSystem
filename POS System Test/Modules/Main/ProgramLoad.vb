Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Module ProgramLoad
    Public ProgramWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
    Public ProgramHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

    Public Sub LoadAll()

        Main()

        'LoginForm Load
        With LoginForm
            .MaximumSize = New Size(ProgramWidth, ProgramHeight)
            .ClientSize = New Size(ProgramWidth, ProgramHeight)
            .pnlMain.Size = New Size(ProgramWidth, ProgramHeight)
            .pnlContainer.Location = New Point((ProgramWidth - 500) / 2, (ProgramHeight - 300) / 2)
            .btClose.Location = New Point((ProgramWidth - 70), 10)
        End With

        'MainFormLoad
        With MainForm
            .MaximumSize = New Size(ProgramWidth, ProgramHeight)
            .ClientSize = New Size(ProgramWidth, ProgramHeight)
            .pnlSelection.Size = New Size(200, ProgramHeight)
            .pnlRibbon.Size = New Size(ProgramWidth - 200, 50)
            .pnlSwitch.Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlFormCtrl.Location = New Point(ProgramWidth - 280, 0)
            .PnlBtnSelection.Location = New Point(0, (ProgramHeight - 300) / 2)
            .pnlLgtSt.Location = New Point(5, ProgramHeight - 60)
            .pnlAdminContainer.Location = New Point(0, (ProgramHeight - 300) / 2 + 300)
        End With

        'Load For pnlSwitch Forms
        With Inventory
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
            LoadCategories()
        End With
        With Sales
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With History
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With EmployeeManagement
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With Expenses
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With TimeLog
            .Size = New Size(ProgramWidth - 200, ProgramHeight - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With

    End Sub

    Public Sub CreateCsvFileIfNotExists(fileName As String, header As String)
        Dim filePath As String = fileName

        ' Check if the CSV file exists, if not, create it and write the header
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(header)
            End Using
        End If
    End Sub

    Public Sub CreateDir()
        Directory.CreateDirectory("Stock")
        Directory.CreateDirectory("Receipts")
        Directory.CreateDirectory("Resources")
        Directory.CreateDirectory("Stock History")
    End Sub
    Sub Main()
        CreateDir()
        ' Create CSV files for each list if they do not exist
        CreateCsvFileIfNotExists($"Resources/Users.csv", "User ID,Username,Password,Access Level, First Name, Last Name" & vbLf & $"U000,admin,{LoginForm.HashPassword("admin")},3,admin,admin")
        CreateCsvFileIfNotExists("Resources/Expenses.csv", "Date and Time,name,Purpose,Amount, Added by")
        CreateCsvFileIfNotExists("Resources/Sales History.csv", "Transaction Reference Number,Customer Name,Amount,Sold By,Date and Time")
        CreateCsvFileIfNotExists("Resources/Stock Category.csv", "CategoryName")
        CreateCsvFileIfNotExists("Resources/Stock History.csv", "Transaction Reference Number,Quantity,Date and Time")
        CreateCsvFileIfNotExists("Resources/TimeLog.csv", "Log,Date and Time,Username")

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

