Imports System.IO

Public Class StockHistory

    Private Sub dgvHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellDoubleClick
        Try
            Dim filepath As String = $"{srcFolder}/Stock History/{dgvHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
            ReceiptViewer.ShowReceipt(filepath)
            ReceiptViewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Acc > 2 Then
            btBatchEdit.Enabled = True
            btBatchEdit.Visible = True
        Else
            btBatchEdit.Enabled = False
            btBatchEdit.Visible = False
        End If
    End Sub

    Private Sub btBatchEdit_Click(sender As Object, e As EventArgs) Handles btBatchEdit.Click
        If Not dgvHistory.SelectedRows.Count <> 1 Then
            Dim filepath As String = $"{srcFolder}/Stock History/{dgvHistory.SelectedRows(0).Cells(1).Value}.csv"
            With BatchEditor
                .ShowBatch(filepath)
                .batchref = dgvHistory.SelectedRows(0).Cells(1).Value
                .txbxBatchCost.Text = dgvHistory.SelectedRows(0).Cells(4).Value
                .filepath = filepath
            End With

        End If
    End Sub
End Class