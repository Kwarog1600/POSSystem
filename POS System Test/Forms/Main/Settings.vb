Imports System.IO

Public Class Settings
    Dim PreviousPath As String = ReadIni("conf.ini", "SourceLocation", "csvsrc")
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbxProduct.Text = ReadIni("conf.ini", "SourceLocation", "csvsrc")
    End Sub

    Private Sub btSeach_Click(sender As Object, e As EventArgs) Handles btSeach.Click
        FolderDialog.ShowDialog()
        txbxProduct.Text = FolderDialog.SelectedPath

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim conf As String = "conf.ini"
        WriteIni(conf, "SourceLocation", "csvsrc", txbxProduct.Text)
        Directory.CreateDirectory(txbxProduct.Text)

    End Sub
End Class