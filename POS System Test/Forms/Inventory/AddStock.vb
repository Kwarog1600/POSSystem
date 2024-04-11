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
        dgvAddedList.Columns.Clear()
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click

        If txbxID.Text Or txbxPrice.Text Or txbxProduct.Text Or txbxQty.Text IsNot Nothing Then
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In dgvAddedList.Columns
                headers.Add(col.Name)
            Next

            For Each row As DataGridViewRow In dgvAddDescr.Rows
                If row.Cells(1).Value Is Nothing Then
                    MessageBox.Show("Please fill all fields")
                    Exit Sub
                End If
            Next

            Dim id As String = ""
            For Each row As DataGridViewRow In dgvAddDescr.Rows
                id += "-" & row.Cells(0).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray() & row.Cells(1).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray()
            Next

            Dim contents As New List(Of String)
            With contents
                .Add(cbxCategory.SelectedItem)
                .Add(txbxID.Text & id)
                .Add(txbxProduct.Text)
                .Add(txbxPrice.Text)
                .Add(txbxQty.Text)
                For Each add As DataGridViewRow In dgvAddDescr.Rows
                    .Add(add.Cells(1).Value)
                    headers.Add(add.Cells(0).Value)
                Next
            End With
            If Not dgvAddedList.Rows.Count = 0 Then
                For Each row As DataGridViewRow In dgvAddedList.Rows
                    If Not row.Cells(1).Value = contents(1) Then
                        AddtoTable(dgvAddedList, contents, headers)
                    Else
                        row.Cells(4).Value = Int(row.Cells(4).Value) + Int(contents(4))
                    End If
                Next
            Else
                AddtoTable(dgvAddedList, contents, headers)
            End If
            dgvAddedList.Columns.Clear()
            dgvAddedList.Rows.Clear()
        Else
            MessageBox.Show("Please fill all the fields")
        End If

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
        Dim headers() As String = File.ReadAllLines($"Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
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

    Private Sub txbxProduct_TextChanged(sender As Object, e As EventArgs) Handles txbxProduct.TextChanged
        Dim id As String = New String(txbxProduct.Text.Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray())



        txbxID.Text = id
    End Sub
End Class
