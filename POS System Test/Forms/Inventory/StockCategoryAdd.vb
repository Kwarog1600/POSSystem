Imports System.IO
Imports System.Text

Public Class StockCategoryAdd
    Private Sub btAddCat_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            AddCategory($"{srcFolder}/Resources/Stock Category.csv", txbxCategory.Text, dgvAddDescr)
            dgvCatList.Rows.Clear()
            dgvCatList.Columns.Clear()
            RefreshTable($"{srcFolder}/Resources/Stock Category.csv", dgvCatList)
            Inventory.cbxCategory.Items.Clear()
            Inventory.cbxCategory.Items.Add("All")
            Sales.cbxCategory.Items.Clear()
            AddStock.cbxCategory.Items.Clear()
            RefreshCat(Inventory.cbxCategory)
            RefreshCat(Sales.cbxCategory)
            RefreshCat(AddStock.cbxCategory)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub StockCategoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Stock Category.csv")
            dgvCatList.Columns.Add("", "")
            For i = 1 To contents.Count - 1
                dgvCatList.Rows.Add(contents(i))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Stock Category.csv")
            For Each cat In contents
                If cat = dgvCatList.SelectedRows(0).Cells(0).Value Then
                    contents.Remove(cat)
                    File.WriteAllLines($"{srcFolder}/Resources/Stock Category.csv", contents)
                    File.Delete($"{srcFolder}/Stock\{cat}.csv")
                    Exit Sub
                End If
            Next
            RefreshTable($"{srcFolder}/Resources/Stock Category.csv", dgvCatList)
            Inventory.cbxCategory.Items.Clear()
            Inventory.cbxCategory.Items.Add("All")
            Sales.cbxCategory.Items.Clear()
            AddStock.cbxCategory.Items.Clear()
            RefreshCat(Inventory.cbxCategory)
            RefreshCat(Sales.cbxCategory)
            RefreshCat(AddStock.cbxCategory)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddDescr.CheckedChanged
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

End Class











