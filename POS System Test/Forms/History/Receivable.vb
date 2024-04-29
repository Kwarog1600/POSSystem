Imports System.IO

Public Class Receivable
    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click
        Dim loglist As List(Of String) = ReadCsv($"{srcFolder}/Resources/Sales History.csv")
        For Each log In loglist
            Dim loginf() As String = log.Split(",")
            If loginf(1) = txbxRef.Text Then
                Dim index = loglist.IndexOf(log)
                loginf(7) = (Double.Parse(loginf(7)) + Double.Parse(txbxAmtPd.Text)).ToString("0.00")
                loglist(index) = String.Join(",", loginf)
                Current += Double.Parse(txbxAmtPd.Text)
                File.WriteAllLines($"{srcFolder}/Resources/Sales History.csv", loglist)
                Exit Sub
            End If
        Next
        Me.Hide()
    End Sub
End Class