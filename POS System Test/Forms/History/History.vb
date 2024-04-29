Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        RefreshTable($"{srcFolder}/Resources/Sales History.csv", dgvSaleHistory)
    End Sub

    Private Sub dgvSaleHistory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellContentDoubleClick
        Dim filepath As String = $"{srcFolder}/Receipts/{dgvSaleHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        ReceiptViewer.ShowReceipt(filepath)
        ReceiptViewer.Show()
    End Sub

    Private Sub dgvSaleHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellContentClick

    End Sub
End Class