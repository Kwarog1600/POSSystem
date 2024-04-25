Imports System.IO

Public Class TimeLog
    Private Sub TimeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTable($"{srcFolder}/Resources/TimeLog.csv", dgvTimeLogs)
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUsers.SelectedIndexChanged

    End Sub
End Class