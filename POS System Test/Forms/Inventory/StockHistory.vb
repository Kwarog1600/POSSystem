Imports System.IO

Public Class StockHistory

    Private Sub dgvHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellDoubleClick
        Dim filepath As String = $"Stock History/{dgvHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        System.Diagnostics.Process.Start(filepath)
    End Sub

End Class