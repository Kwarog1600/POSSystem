Imports System.IO

Public Class Sale_Confirmation
    Public logDate As DateOnly, info As String, inputuser As String, customerName As String, items As List(Of String), profit As Double
    Dim headers As New List(Of String)

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click
        Try
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
                    SalesLogging("")
                    MessageBox.Show($"Change : Php{txbxAmtPd.Text - info}", "Transaction Successful")
                    Current += Double.Parse(info)
                End If
            ElseIf cbxMethod.SelectedItem = "Accounts Recievable(15 days)" Then
                If Not txbxContactNumber.Text = "" Then
                    Dim Due As DateTime = DateTime.Now.AddDays(15)
                    SalesLogging(Due.ToString("MM/dd/yyyy"))
                    Current += Double.Parse(txbxAmtPd.Text)
                    MessageBox.Show("Transaction Successful")
                Else
                    MessageBox.Show("Contact Number must be provided")
                End If
            ElseIf cbxMethod.SelectedItem = "Accounts Recievable(30 days)" Then
                If Not txbxContactNumber.Text = "" Then
                    Dim Due As DateTime = DateTime.Now.AddDays(30)
                    SalesLogging(Due.ToString("MM/dd/yyyy"))
                    Current += Double.Parse(txbxAmtPd.Text)
                    MessageBox.Show("Transaction Successful")
                Else
                    MessageBox.Show("Contact Number must be provided")
                End If
            End If
            With Sales
                .dgvAddedList.Rows.Clear()
                Current += Convert.ToDouble(.showTotalPrice.Text)
                If .dgvAddedList.Columns.Count > 6 Then
                    For i = .dgvAddedList.Columns.Count - 1 To 7 Step -1
                        .dgvAddedList.Columns.RemoveAt(i)
                    Next i
                End If
            End With
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Sub SalesLogging(Due As String)
        Try
            Dim logpath As String = $"{srcFolder}\Resources\Sales History.csv"
            Dim logrec As String = $"{srcFolder}\Receipts\SR-{ReadCsv(logpath).Count - 1}.csv"
            Dim stocklist As String = ""
            For Each item As String In items
                stocklist += item & Environment.NewLine
            Next
            Dim line As String = $"{logDate.ToString()},SR-{ReadCsv(logpath).Count - 1},{txbxContactNumber.Text}-{customerName},{info},{profit},{inputuser},{cbxMethod.SelectedItem},{txbxAmtPd.Text},{Due}" & Environment.NewLine
            File.AppendAllText(logpath, line)
            CreateNewCsv(logrec, stocklist)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMethod.SelectedIndexChanged
        If Not cbxMethod.SelectedItem = "Cash" Then
            txbxContactNumber.Visible = True
            txbxContactNumber.Enabled = True
        Else
            txbxContactNumber.Visible = False
            txbxContactNumber.Enabled = False
        End If
    End Sub
End Class