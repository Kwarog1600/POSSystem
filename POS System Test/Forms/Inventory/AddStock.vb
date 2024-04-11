Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contents = ReadCsv("Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
    End Sub

    Private Sub LoadCategories()

    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged

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
            For Each add In dgvAddDescr.Rows
                .Add(add.Cells(1).Value)
                headers.Add(add.cells(0).Value)
            Next
        End With
        AddtoTable(dgvAddedList, contents, headers)
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim headers As New List(Of String)
        For Each col In dgvAddedList.Columns
            headers.Add(col.Name)
        Next
        For Each row In dgvAddedList.Rows
            Dim filename As String = $"Stock\{row.Cells(0).Value}.csv"
            Dim content As New List(Of String)
            For i As Integer = 1 To dgvAddedList.Columns.Count - 1
                content.Add(row.cells(i))
            Next
            AddStockSub(filename, content, headers)
        Next
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged

    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click

    End Sub
End Class
