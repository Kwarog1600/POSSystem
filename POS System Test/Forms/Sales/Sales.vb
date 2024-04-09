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

    End Sub



    Private Sub LoadCategories()
        Dim filePath As String = "Resources/Stock Category.csv"

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the CSV file
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Clear the existing items in the ComboBox
            cbxCategory.Items.Clear()

            ' Start from the second line (index 1) to skip the header
            For i As Integer = 1 To lines.Length - 1
                ' Split the line by comma (assuming it's a CSV file)
                Dim category As String() = lines(i).Split(","c)

                ' Add the category to the ComboBox
                cbxCategory.Items.Add(category(0)) ' Assuming category name is in the first column
            Next

            ' Select the first item by default
            If cbxCategory.Items.Count > 0 Then
                cbxCategory.SelectedIndex = 0
            End If
        Else
            MessageBox.Show("Stock Category.csv file not found.")
        End If
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        If txbxID.Text.Trim Is Nothing Then
            MessageBox.Show("Please enter an ID")
            Exit Sub
        Else
            Dim count As Integer = CountIDMatches()
            Dim DescrCol As New List(Of String)
            Dim Descr As New List(Of String)

            If count = 1 Then
                For Each row In dgvDescr.Rows
                    Dim columnName As String = row.Cells(0).Value.ToString
                    If Not dgvAddedList.Columns.Contains(columnName) Then
                        DescrCol.Add(columnName)
                        dgvAddedList.Columns.Add(columnName, columnName)
                    End If
                Next
                For Each Item As String In cbxCategory.Items
                    Dim read As String() = File.ReadAllLines($"Stock\{Item}.csv")
                    For Each line As String In read
                        Dim contents As String() = line.Split(","c)
                        Dim Id As String = contents(0)
                        If Id.StartsWith(txbxID.Text.Trim) Then
                            Dim total As Decimal = 0
                            For Each row In dgvAddedList.Rows
                                If row.Cells(1).Value.ToString() = Id Then
                                    row.Cells(4).Value = Convert.ToInt32(row.Cells(4).Value) + Convert.ToInt32(txbxQty.Text)
                                    row.Cells(5).Value = (Decimal.Parse(row.cells(4).Value) * Decimal.Parse(row.Cells(3).Value))
                                    total = 0
                                    For Each amount As DataGridViewRow In dgvAddedList.Rows
                                        total += Decimal.Parse(amount.Cells(5).Value.ToString())
                                    Next
                                    showTotalPrice.Text = total.ToString("0.00")
                                    Exit Sub
                                End If
                            Next
                            Dim newRow As New DataGridViewRow()
                            dgvAddedList.Rows.Add(cbxCategory.SelectedItem.ToString, Id, txbxProduct.Text, txbxPrice.Text, txbxQty.Text, (Decimal.Parse(txbxPrice.Text) * Decimal.Parse(txbxQty.Text)).ToString("0.00"))
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each row In dgvDescr.Rows
                                DescrCol.Add(row.Cells(0).Value.ToString)
                                Descr.Add(row.Cells(1).Value.ToString)
                            Next
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each col In DescrCol
                                newRow.Cells(col).Value = Descr(DescrCol.IndexOf(col))
                            Next
                            total = 0
                            For Each amount As DataGridViewRow In dgvAddedList.Rows
                                total += Decimal.Parse(amount.Cells(5).Value.ToString())
                            Next
                            showTotalPrice.Text = total.ToString("0.00")
                        End If
                    Next
                Next
            ElseIf count > 1 Then
                MessageBox.Show("ID matches multiple items. You may choose one category and put description to find the matching item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btVoid_Click(sender As Object, e As EventArgs) Handles btVoid.Click
        dgvAddedList.Rows.Clear()
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim Category As String = cbxCategory.SelectedItem.ToString
        Dim filePath As String = $"Stock\{Category}.csv"
        dgvDescr.Rows.Clear()

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            If lines.Length > 0 Then
                Dim columnHeaders As String() = lines(0).Split(","c) ' Assuming columns are comma-separated
                ' Assuming columnHeaders is the array containing all the column headers
                If columnHeaders.Length > 4 Then
                    For i As Integer = 4 To columnHeaders.Length - 1
                        dgvDescr.Rows().Add(columnHeaders(i))
                        dgvDescr.Visible = True
                    Next
                Else
                    dgvDescr.Visible = False
                End If
            End If
        Else
            MessageBox.Show("Category file not found.")
        End If
    End Sub

End Class