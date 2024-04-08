Imports System.IO

Public Class StockHistory
    Public Sub StockHistory_Load()
        ' Define the file path for Stock History.csv
        Dim filePath = Path.Combine(Application.StartupPath, "Resources\Stock History.csv")

        ' Check if the file exists
        If File.Exists(filePath) Then
            Try
                ' Read all lines from the file
                Dim lines = File.ReadAllLines(filePath)

                ' Check if there are lines in the file
                If lines.Length > 0 Then
                    ' Split the first line to get column headers
                    Dim headers = lines(0).Split(","c)

                    ' Add column headers to dgvHistory if they haven't been added already
                    If dgvHistory.Columns.Count = 0 Then
                        For Each header In headers
                            dgvHistory.Columns.Add(header, header)
                        Next
                    End If

                    ' Populate data rows in dgvHistory
                    For i = 1 To lines.Length - 1
                        Dim values = lines(i).Split(","c)
                        dgvHistory.Rows.Add(values)
                    Next
                End If
            Catch ex As Exception
                ' Handle any exceptions that might occur during file reading
                MessageBox.Show("Error reading file: " & ex.Message)
            End Try
        Else
            ' Handle case where file doesn't exist
            MessageBox.Show("File does not exist: " & filePath)
        End If
        Visible = True
    End Sub

    Private Sub dgvHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellClick
        Dim filepath As String = $"Stock History/{dgvHistory.SelectedCells(0)}.pdf"
        If File.Exists(filepath) Then
            Process.Start(filepath)
        Else
            MessageBox.Show("File not found")
        End If
    End Sub
End Class