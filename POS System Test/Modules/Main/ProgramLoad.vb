Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Module ProgramLoad

    Public Sub SetAllSizes(width As Integer, height As Integer)
        With MainForm
            .ClientSize = New Size(width, height)
            .pnlSelection.Size = New Size(200, height)
            .pnlRibbon.Size = New Size(width - 200, 50)
            .pnlSwitch.Size = New Size(width - 200, height - 50)
            .pnlFormCtrl.Location = New Point(width - 290, 5)
            .PnlBtnSelection.Location = New Point(0, ((height - 275) / 2))
            .pnlAdminContainer.Location = New Point(0, ((height - 275) / 2) + 300)
            .pnlLgtSt.Location = New Point(0, height - 60)
        End With
        With EmployeeManagement
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With Expenses
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With Inventory
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With Sales
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With History
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        With TimeLog
            .Size = New Size(width - 200, height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
    End Sub



End Module

