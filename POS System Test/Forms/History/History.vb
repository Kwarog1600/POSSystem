Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTable($"{srcFolder}/Resources/Sales History.csv", dgvSaleHistory)
    End Sub

    Private Sub dgvSaleHistory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellContentDoubleClick
        Dim filepath As String = $"{srcFolder}/Receipts/{dgvSaleHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        ReceiptViewer.ShowReceipt(filepath)
        ReceiptViewer.Show()
    End Sub

End Class