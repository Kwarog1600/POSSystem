Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTable("Resources/Sales History.csv", dgvSaleHistory)
    End Sub

    Private Sub dgvSaleHistory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellContentDoubleClick
        Dim filepath As String = $"Receipts/{dgvSaleHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        System.Diagnostics.Process.Start(filepath)
    End Sub

End Class