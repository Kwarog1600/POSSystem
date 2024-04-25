Imports System.IO
Public Class PriceChange

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        contents = ReadCsv($"{srcFolder}/Stock\{txbxCategory.Text}.csv")
        Dim pId As String = txbxID.Text
        For i As Integer = 1 To contents.Count - 1
            Dim line() As String = contents(i).Split(","c)
            If line(0) = pId Then
                line(2) = txbxPrice.Text
                contents(i) = String.Join(",", line)
            End If
        Next
        File.WriteAllLines($"Stock\{txbxCategory.Text}.csv", contents)
        Inventory.cbxCategory_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub PriceChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Inventory.dgvStockList.Columns.Count > 5 Then
            For i As Integer = 5 To Inventory.dgvStockList.Columns.Count - 1

            Next
        End If
    End Sub
End Class