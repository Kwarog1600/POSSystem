Imports System.Drawing.Printing
Imports System.IO
Imports Mysqlx.XDevAPI.Relational

Public Class ReceiptViewer
    Sub ShowReceipt(filepath As String)
        dgvHistory.Rows.Clear()
        contents = ReadCsv(filepath)
        For Each line As String In contents
            Dim lineContents() As String = line.Split(","c)
            For Each content As String In lineContents
                If Not dgvHistory.Columns.Contains($"{Array.IndexOf(lineContents, content)}") Then
                    dgvHistory.Columns.Add($"{Array.IndexOf(lineContents, content)}", "")
                End If
            Next
            dgvHistory.Rows.Add(lineContents)
        Next
    End Sub

    Private Sub ReceiptViewer_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        dgvHistory.Size = New Size(Me.Width, Me.Height)
    End Sub

    Private Sub ReceiptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class