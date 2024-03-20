Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Module ProgramLoad
    Public screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Public Sub LoadAll()

        Main()

        'LoginForm Load
        With LoginForm
            .ClientSize = New Size(screenWidth, screenHeight)
            .pnlMain.Size = New Size(screenWidth, screenHeight)
            .pnlContainer.Location = New Point((screenWidth - 500) / 2, (screenHeight - 300) / 2)
            .btClose.Location = New Point((screenWidth - 70), 10)
        End With

        'MainFormLoad
        With MainForm
            .ClientSize = New Size(screenWidth, screenHeight)
            .pnlSelection.Size = New Size(200, screenHeight)
            .pnlRibbon.Size = New Size(screenWidth - 200, 50)
            .pnlSwitch.Size = New Size(screenWidth - 200, screenHeight - 50)
            .pnlFormCtrl.Location = New Point(screenWidth - 280, 0)
            .PnlBtnSelection.Location = New Point(0, (screenHeight - 300) / 2)
            .pnlLgtSt.Location = New Point(5, screenHeight - 60)
        End With

        'Load For pnlSwitch Forms
        With Dashboard
            .Size = New Size(screenWidth - 200, screenHeight - 50)
            .pnlDashBoardContainer.Location = New Point(50, 50)
        End With
        With Inventory
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With
        With Sales
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With
        With Analytics
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With
        With History
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With

    End Sub

    Private Sub CreateCsvFileIfNotExists(fileName As String, header As String)
        Dim filePath As String = fileName

        ' Check if the CSV file exists, if not, create it and write the header
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(header)
            End Using
        End If
    End Sub

    Sub Main()

        ' Create CSV files for each list if they do not exist
        CreateCsvFileIfNotExists("Users.csv", "Username,Password,Access Level")
        CreateCsvFileIfNotExists("Expenses.csv", "Date and Time,Name,Amount,Source,Purpose")
        CreateCsvFileIfNotExists("Sales History.csv", "Transaction Reference Number,Customer Name,Product ID List,Model List,ID List,Qty,Date and Time")
        CreateCsvFileIfNotExists("Stock Category.csv", "CategoryName,DescriptionList")
        CreateCsvFileIfNotExists("Stock Category.csv", "Date & Time, Items")
    End Sub
End Module
