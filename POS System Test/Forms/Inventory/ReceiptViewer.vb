﻿Imports System.IO
Imports Mysqlx.XDevAPI.Relational

Public Class ReceiptViewer
    Sub ShowReceipt(filepath As String)
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
End Class