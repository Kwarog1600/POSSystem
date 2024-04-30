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

    End Sub
End Class