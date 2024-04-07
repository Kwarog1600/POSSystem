Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btSave.Click
        AddCat()
    End Sub

    Private Sub StockCategoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCat()
    End Sub



    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        RemoveItem()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddDescr.CheckedChanged
        If cbxAddDescr.Checked Then
            With dgvAddDescr
                .Enabled = True
                .ReadOnly = False
                .AllowUserToAddRows = True
                .Columns.Add("clmDescr", "Description")
            End With

        Else
            dgvAddDescr.Enabled = False
            dgvAddDescr.ReadOnly = True
            dgvAddDescr.Columns.Clear()
            dgvAddDescr.AllowUserToAddRows = False
        End If
    End Sub

    Private Sub dgvCatList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatList.CellClick
        Dim cellValue As String = dgvCatList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        Dim fileName As String = $"Stock\{cellValue}.csv"
        Dim headers() As String = File.ReadAllLines(fileName).First().Split(","c)

        If headers.Length > 5 Then
            cbxAddDescr.Checked = True
            dgvAddDescr.ReadOnly = False
            For i = 5 To headers.Length - 1
                dgvAddDescr.Rows.Add(headers(i), "")
            Next

        End If
    End Sub
End Class











