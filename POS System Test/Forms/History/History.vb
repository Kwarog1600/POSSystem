﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
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

    Private Sub dgvSaleHistory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellDoubleClick
        Dim filepath As String = $"{srcFolder}/Receipts/{dgvSaleHistory.Rows(e.RowIndex).Cells(1).Value}.csv"
        ReceiptViewer.ShowReceipt(filepath)
        If dgvSaleHistory.Rows(e.RowIndex).Cells(6).Value = "Accounts Recievable" Then
            With Receivable
                .txbxRef.Text = dgvSaleHistory.Rows(e.RowIndex).Cells(1).Value
                .txbxAmount.Text = Double.Parse(dgvSaleHistory.Rows(e.RowIndex).Cells(3).Value) - Double.Parse(dgvSaleHistory.Rows(e.RowIndex).Cells(7).Value)
                .Show()
            End With
        End If
    End Sub

End Class