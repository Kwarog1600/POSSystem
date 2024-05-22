Imports System.IO

Public Class BatchEditor

    Public filepath, batchref As String

    Sub ShowBatch(filepath As String)
        Try
            dgvHistory.Rows.Clear()
            contents = ReadCsv(filepath)
            For Each line As String In contents
                If Not contents.IndexOf(line) = 0 Then
                    Dim lineContents() As String = line.Split(","c)
                    dgvHistory.Rows.Add(lineContents)
                Else
                    Dim lineContents() As String = line.Split(","c)
                    For Each header In lineContents
                        dgvHistory.Columns.Add(header, header)
                    Next
                    For Each columns As DataGridViewColumn In dgvHistory.Columns
                        columns.ReadOnly = False
                    Next

                End If
            Next
            For Each Col As DataGridViewColumn In dgvHistory.Columns
                Col.ReadOnly = True
            Next
            dgvHistory.Columns(4).ReadOnly = False
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If IsNumeric(txbxBatchCost.Text) Then
            Dim logpath As String = $"{srcFolder}/Resources/Stock History.csv"
            Dim loglist As List(Of String) = ReadCsv(logpath)
            For Each log In loglist.Skip(1)
                Dim loginfo() As String = log.Split(","c)
                If loginfo(1).Equals(batchref) Then
                    loginfo(4) = txbxBatchCost.Text
                    loglist(loglist.IndexOf(log)) = String.Join(",", loginfo)
                End If
            Next
            Dim ProdList As New List(Of String)
            ProdList.Add(String.Join(", ", dgvHistory.Columns.Cast(Of DataGridViewColumn)().Select(Function(col) col.Name)))
            For Each row As DataGridViewRow In dgvHistory.Rows
                ProdList.Add(String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Select(Function(cell) If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty))))
            Next
            File.WriteAllLines(logpath, loglist)
            File.WriteAllLines(filepath, ProdList)
        Else
            MessageBox.Show("Cost Input Invalid", "Error")
        End If


    End Sub
End Class