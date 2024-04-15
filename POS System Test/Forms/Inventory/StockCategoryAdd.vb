Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btSave.Click
        AddCategory("Resources/Stock Category.csv", txbxCategory.Text, dgvAddDescr)
        dgvCatList.Rows.Clear()
        dgvCatList.Columns.Clear()
        RefreshTable("Resources/Stock Category.csv", dgvCatList)
        Inventory.cbxCategory.Items.Clear()
        Inventory.cbxCategory.Items.Add("All")
        RefreshCat(Inventory.cbxCategory)
        RefreshCat(Sales.cbxCategory)
        RefreshCat(AddStock.cbxCategory)
    End Sub

    Private Sub StockCategoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contents = ReadCsv("Resources/Stock Category.csv")
        dgvCatList.Columns.Add("", "")
        For i = 1 To contents.Count - 1
            dgvCatList.Rows.Add(contents(i))
        Next
    End Sub



    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click

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

    End Sub

    Private Sub dgvAddDescr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddDescr.CellContentClick

    End Sub
End Class











