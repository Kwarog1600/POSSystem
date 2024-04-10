Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Sales
    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click

    End Sub

    Private Sub txbxID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbxID.KeyDown

    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged

    End Sub


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contents = ReadCsv("Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
    End Sub
    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Dim headers As New List(Of String)
        For Each col In dgvAddedList.Columns
            headers.Add(col.Name)
        Next
        Dim contents As New List(Of String)
        With contents
            .Add(cbxCategory.SelectedItem)
            .Add(txbxID.Text)
            .Add(txbxProduct.Text)
            .Add(txbxPrice.Text)
            .Add(txbxQty.Text)
            .Add(Convert.ToString(Convert.ToDouble(txbxPrice.Text) * Convert.ToDouble(txbxQty.Text)))
            For Each add In dgvDescr.Rows
                .Add(add.Cells(1).Value)
                headers.Add(add.cells(0).Value)
            Next
        End With
        AddtoTable(dgvAddedList, contents, headers)
    End Sub

    Private Sub btVoid_Click(sender As Object, e As EventArgs) Handles btVoid.Click

    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub

End Class