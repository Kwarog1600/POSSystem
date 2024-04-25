Imports System.IO

Public Class StockHistory

    Private Sub dgvHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellDoubleClick
        Dim filepath As String = $"{srcFolder}/Stock History/{dgvHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        ReceiptViewer.ShowReceipt(filepath)
        ReceiptViewer.Show()
    End Sub

    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class