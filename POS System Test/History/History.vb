Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableRefresh()
    End Sub
    Private Sub TableRefresh()
        Dim filepath As String = "Resources\Sales History.csv"
        dgvSaleHistory.Rows.Clear()

        ' Read the CSV file line by line and add rows to the DataGridView
        Using read As New StreamReader(filepath)

            Dim header() As String = read.ReadLine().Split(","c) ' Assuming CSV file uses comma as delimiter
            For Each column In header
                dgvSaleHistory.Columns.Add(column, column)
            Next
            While Not read.EndOfStream
                Dim line As String = read.ReadLine()
                Dim values() As String = line.Split(","c) ' Assuming CSV file uses comma as delimiter
                ' Add a new row to the DataGridView and populate it with values from the CSV file
                dgvSaleHistory.Rows.Add(values)
            End While
        End Using
    End Sub


    Private Sub dgvSaleHistory_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSaleHistory.CellContentDoubleClick
        ' Check if a valid row and column index is selected
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Assuming the first column index is 0
            ' Retrieve the value of the first column of the selected row
            Dim reference As String = dgvSaleHistory.Rows(e.RowIndex).Cells(0).Value.ToString()

            ' Call the Receipt method with the reference as an argument

        End If
    End Sub

End Class