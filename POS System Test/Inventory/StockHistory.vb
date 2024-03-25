Imports System.IO

Public Class StockHistory
    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ' Define the file path for Stock History.csv
        Dim filePath As String = Path.Combine(Application.StartupPath, "Stock History.csv")

        ' Check if the file exists
        If File.Exists(filePath) Then
            Try
                ' Read all lines from the file
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Check if there are lines in the file
                If lines.Length > 0 Then
                    ' Split the first line to get column headers
                    Dim headers As String() = lines(0).Split(","c)

                    ' Add column headers to dgvHistory
                    For Each header In headers
                        dgvHistory.Columns.Add(header, header)
                    Next

                    ' Populate data rows in dgvHistory
                    For i As Integer = 1 To lines.Length - 1
                        Dim values As String() = lines(i).Split(","c)
                        dgvHistory.Rows.Add(values)
                    Next
                    ' Sort the DataGridView in descending order based on the 4th column
                    dgvHistory.Sort(dgvHistory.Columns(3), System.ComponentModel.ListSortDirection.Descending)
                End If
            Catch ex As Exception
                ' Handle any exceptions that might occur during file reading
                MessageBox.Show("Error reading file: " & ex.Message)
            End Try
        Else
            ' Handle case where file doesn't exist
            MessageBox.Show("File does not exist: " & filePath)
        End If
    End Sub

End Class