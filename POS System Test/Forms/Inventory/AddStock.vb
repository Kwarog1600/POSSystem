Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contents = ReadCsv("Resources/Stock Category.csv")
        For i = 1 To contents.Count - 1
            cbxCategory.Items.Add(contents(i))
        Next
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Dim itemFound() As String = SearchID(txbxID.Text, 0).ToArray
        If itemFound IsNot Nothing Then
            cbxCategory.SelectedItem = itemFound(0)
            txbxProduct.Text = itemFound(2)
            txbxPrice.Text = itemFound(3)
            txbxQty.Text = itemFound(4)
            If itemFound.Length > 5 Then
                With dgvAddDescr
                    For i As Integer = 5 To itemFound.Length - 1
                        .Rows(i).Cells(2).Value = itemFound(i)
                    Next
                End With
            End If
        End If
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Dim headers As New List(Of String)
        For Each col In dgvAddedList.Columns
            headers.Add(col.Name)
        Next
        Dim Id As String = txbxID.Text
        For Each row In dgvAddDescr.Rows
            Id += "-" & row.Cells(0).Value.ToString().Substring(0, 1) & row.Cells(1).Value.ToString()
        Next
        Dim contents As New List(Of String)
        With contents
            .Add(cbxCategory.SelectedItem)
            .Add(Id)
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
        For i As Integer = 1 To dgvAddedList.Columns.Count - 1
            headers.Add(dgvAddedList.Columns(i).HeaderText)
        Next
        For Each row In dgvAddedList.Rows
            Dim filename As String = $"Stock\{row.Cells(0).Value}.csv"
            Dim content As New List(Of String)
            For i As Integer = 1 To dgvAddedList.Columns.Count - 1
                content.Add(row.Cells(i).Value)
            Next
            AddStockSub(filename, content, headers)
        Next
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim headers() as String = File.ReadAllLines($"Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
        If headers.Length > 4 Then
            dgvAddDescr.Rows.Clear()
            For i As Integer = 4 To headers.Length - 1
                With dgvAddDescr
                    .Rows.Add(headers(i), "")
                End With
            Next
        End If
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click

    End Sub
End Class
