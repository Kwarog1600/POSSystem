Imports System.IO

Public Class Sale_Confirmation
    Public logDate As DateOnly, info As String, inputuser As String, customerName As String, items As List(Of String), profit As Double
    Dim headers As New List(Of String)

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click
        With Sales
            For i = 1 To .dgvAddedList.Columns.Count - 1
                headers.Add(.dgvAddedList.Columns(i).HeaderText)
            Next
            For Each row As DataGridViewRow In .dgvAddedList.Rows
                Dim filename = $"{srcFolder}\Stock\{row.Cells(0).Value}.csv"
                Dim content As New List(Of String)
                For i = 1 To .dgvAddedList.Columns.Count - 1
                    If i <> 5 Then
                        content.Add(row.Cells(i).Value)
                    End If
                Next
                items.Add(String.Join(",", row.Cells.Cast(Of DataGridViewCell)().Skip(1).Select(Function(cell) cell.Value.ToString()).ToArray()))
                UpdateQty(filename, content, headers, True)
            Next
        End With

        If cbxMethod.SelectedItem = "" Then
            MessageBox.Show("Select Payment Method")
        ElseIf cbxMethod.SelectedItem = "Cash" Then
            If txbxAmtPd.Text = "" Then
                MessageBox.Show("Enter amount paid")
            ElseIf txbxAmtPd.Text < info Then
                MessageBox.Show("Insufficient Amount")
            Else
                SalesLogging()
                MessageBox.Show($"Change : Php{txbxAmtPd.Text - info}", "Transaction Successful")
                Current = Double.Parse(info)
            End If
        ElseIf cbxMethod.SelectedItem = "Accounts Recievable" Then
            SalesLogging()
            Current = Double.Parse(txbxAmtPd.Text)
            MessageBox.Show("Transaction Successful")
        End If
        With Sales
            .dgvAddedList.Rows.Clear()
            Dashboard.CurrentCash.Text = (Convert.ToDouble(Dashboard.CurrentCash.Text) + Convert.ToDouble(.showTotalPrice.Text)).ToString()
            If .dgvAddedList.Columns.Count > 6 Then
                For i = .dgvAddedList.Columns.Count - 1 To 7 Step -1
                    .dgvAddedList.Columns.RemoveAt(i)
                Next i
            End If
        End With
        Me.Hide()
    End Sub

    Sub SalesLogging()
        Try
            Dim logpath As String = $"{srcFolder}\Resources\Sales History.csv"
            Dim logrec As String = $"{srcFolder}\Receipts\SR-{ReadCsv(logpath).Count - 1}.csv"
            Dim stocklist As String = ""
            For Each item As String In items
                stocklist += item & Environment.NewLine
            Next
            Dim line As String = $"{logDate.ToString()},SR-{ReadCsv(logpath).Count - 1},{customerName},{info},{profit},{inputuser},{cbxMethod.SelectedItem},{txbxAmtPd.Text}" & Environment.NewLine
            File.AppendAllText(logpath, line)
            CreateNewCsv(logrec, stocklist)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class