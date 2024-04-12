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
        If CountMatch(txbxID.Text, 0) = 1 Then
            For Each cat In cbxCategory.Items
                contents = ReadCsv($"Stock\{cat}.csv")
                For i As Integer = 1 To contents.Count - 1
                    Dim ref() As String = contents(i).Split(","c)
                    If ref(0).StartsWith(txbxID.Text) Then
                        txbxProduct.Text = ref(1)
                        txbxPrice.Text = ref(2)
                        txbxQty.Text = "1"
                        cbxCategory.SelectedItem = cat
                        If ref.Length > 5 Then
                            For j As Integer = 0 To dgvDescr.Rows.Count - 1
                                dgvDescr.Rows(j).Cells(1).Value = ref(j + 4)
                            Next
                        End If
                    End If
                Next
            Next
        End If
    End Sub


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCat(cbxCategory)
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
        Dim headers() As String = File.ReadAllLines($"Stock/{cbxCategory.SelectedItem}.csv").First().Split(",")
        If headers.Length > 4 Then
            dgvDescr.Rows.Clear()
            For i As Integer = 4 To headers.Length - 1
                With dgvDescr
                    .Rows.Add(headers(i), "")
                End With
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txbxProduct_TextChanged(sender As Object, e As EventArgs) Handles txbxProduct.TextChanged
        Dim id As String = New String(txbxProduct.Text.Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray())
        For Each row As DataGridViewRow In dgvDescr.Rows
            id += "-" & row.Cells(0).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray() & row.Cells(1).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray()
        Next
        txbxID.Text = id
    End Sub

    Private Sub dgvDescr_ValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescr.CellValueChanged
        Try
            Dim id As String = New String(txbxProduct.Text.Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray())
            For Each row As DataGridViewRow In dgvDescr.Rows
                id += "-" & row.Cells(0).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray() & row.Cells(1).Value.ToString().Where(Function(c) Char.IsUpper(c) Or Char.IsDigit(c)).ToArray()
            Next
            txbxID.Text = id
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub
End Class