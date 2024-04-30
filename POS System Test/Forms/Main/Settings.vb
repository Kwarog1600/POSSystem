Imports System.IO

Public Class Settings
    Dim PreviousPath As String
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreviousPath = ReadIni("SystemConf.ini", "SourceLocation", "csvsrc")
        txbxProduct.Text = ReadIni("SystemConf.ini", "SourceLocation", "csvsrc")
    End Sub

    Private Sub btSeach_Click(sender As Object, e As EventArgs) Handles btSeach.Click
        FolderDialog.ShowDialog()
        txbxProduct.Text = FolderDialog.SelectedPath
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            Dim conf As String = "SystemConf.ini"
            WriteIni(conf, "SourceLocation", "csvsrc", txbxProduct.Text)
            Dim Folders() As String = Directory.GetDirectories(PreviousPath)

            For Each folder In Folders
                Dim folderName As String = Path.GetFileName(folder)
                Dim destinationFolder As String = Path.Combine(txbxProduct.Text, folderName)
                Directory.CreateDirectory(destinationFolder)
                Dim files() As String = Directory.GetFiles(folder)
                For Each csv In files
                    Dim fileName As String = Path.GetFileName(csv)
                    Dim sourceFile As String = Path.Combine(folder, fileName)
                    Dim destinationFile As String = Path.Combine(destinationFolder, fileName)
                    File.Move(sourceFile, destinationFile)
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class