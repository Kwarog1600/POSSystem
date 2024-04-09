Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Module ProgramLoad
    Public ProgramWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
    Public ProgramHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

    Public Sub LoadAll()

        Main()



    End Sub


    Sub Main()
        CreateDir()
        ' Create CSV files for each list if they do not exist

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

