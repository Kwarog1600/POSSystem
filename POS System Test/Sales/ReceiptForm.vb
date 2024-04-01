Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class ReceiptForm

    Public Sub Receipt(reference As String)
        Dim filepath As String = $"receipts/{reference}.csv"

        dgvReceipt.Columns.Add("clm1", "")
        dgvReceipt.Columns.Add("clm2", "")
        dgvReceipt.Columns.Add("clm3", "")
        dgvReceipt.Columns.Add("clm4", "")
        dgvReceipt.Columns.Add("clm5", "")
        dgvReceipt.Columns.Add("clm6", "")
        dgvReceipt.Rows.Clear()

        ' Read the CSV file line by line and add rows to the DataGridView
        Using read As New StreamReader(filepath)
            While Not read.EndOfStream
                Dim line As String = read.ReadLine()
                Dim values() As String = line.Split(","c) ' Assuming CSV file uses comma as delimiter
                ' Add a new row to the DataGridView and populate it with values from the CSV file
                dgvReceipt.Rows.Add(values)
            End While
        End Using
        Me.Visible = True
    End Sub

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class