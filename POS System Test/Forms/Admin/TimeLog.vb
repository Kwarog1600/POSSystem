Imports System.IO

Public Class TimeLog
    Private Sub TimeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Me
                .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
                .pnlContainer.Location = New Point(50, 50)
            End With
            RefreshTable($"{srcFolder}/Resources/TimeLog.csv", dgvTimeLogs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUsers.SelectedIndexChanged

    End Sub
End Class