Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Module SystemLoad
    Public Sub LoadAll()
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

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
        With Expenses
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With
        With History
            .Size = New Size(screenWidth - 200, screenHeight - 50)
        End With

    End Sub
End Module
