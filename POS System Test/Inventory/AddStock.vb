Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar
Imports Mysqlx.XDevAPI.Common

Public Class AddStock
    Dim categoryFilePath As String = "Resources/Stock Category.csv"
    Dim categoryNames As New List(Of String)


    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        If File.Exists(categoryFilePath) Then
            Dim lines As String() = File.ReadAllLines(categoryFilePath)
            ' Skip header (first line)
            For Each line As String In lines.Skip(1)
                ' Extract category names and populate ComboBox
                Dim categoryName As String = line.Split(","c)(0)
                cbxCategory.Items.Add(categoryName)
                categoryNames.Add(categoryName)
            Next
        Else
            MessageBox.Show("Categories file not found.")
        End If
    End Sub

    Private Function CountIDMatches() As Integer
        Dim count As Integer = 0
        For Each Item As String In cbxCategory.Items
            If File.Exists($"Stock\{Item}.csv") Then
                Dim lines As String() = File.ReadAllLines($"Stock\{Item}.csv")
                For Each line As String In lines
                    Dim contents As String() = line.Split(","c)
                    If contents(0).Trim.StartsWith(txbxID.Text.Trim) Then
                        count += 1
                    End If
                Next
            End If
        Next
        Return count
    End Function

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Dim count As Integer = CountIDMatches()
        For Each Item As String In cbxCategory.Items
            Dim read As String() = File.ReadAllLines($"Stock\{Item}.csv")
            For Each line As String In read
                Dim contents As String() = line.Split(","c)
                If contents(0).Trim.StartsWith(txbxID.Text.Trim) Then
                    cbxCategory.SelectedItem = $"{Item}"
                    txbxProduct.Text = contents(1)
                    txbxPrice.Text = contents(2)
                    txbxQty.Text = "1"
                    If contents.Length > 4 Then
                        If count > 1 Then
                            For Each row As DataGridViewRow In dgvAddDescr.Rows
                                row.Cells(1).Value = ""
                            Next
                        Else
                            For i As Integer = 4 To contents.Length - 1
                                dgvAddDescr.Rows(i - 4).Cells(1).Value = contents(i)
                            Next
                        End If
                    End If
                    Exit Sub
                Else
                    cbxCategory.SelectedItem = ""
                    txbxProduct.Text = ""
                    txbxPrice.Text = ""
                    txbxQty.Text = "1"
                End If
            Next
        Next
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        If txbxID.Text.Trim Is Nothing Then
            MessageBox.Show("Please enter an ID")
            Exit Sub
        Else
            If dgvAddDescr.Rows.Count > 0 Then
                For Each row In dgvAddDescr.Rows
                    If row.Cells(1).Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells(1).Value.ToString()) Then
                        MessageBox.Show("Descriptions must not be blank.")
                    End If
                Next
            End If

            Dim count As Integer = CountIDMatches()
            Dim DescrCol As New List(Of String)
            Dim Descr As New List(Of String)

            If count = 1 Then
                For Each row In dgvAddDescr.Rows
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
                            For Each row In dgvAddedList.Rows
                                If row.Cells(1).Value.ToString() = Id Then
                                    row.Cells(4).Value = Convert.ToInt32(row.Cells(4).Value) + Convert.ToInt32(txbxQty.Text)
                                    Exit Sub
                                End If
                            Next
                            Dim newRow As New DataGridViewRow()
                            dgvAddedList.Rows.Add(cbxCategory.SelectedItem.ToString, Id, txbxProduct.Text, txbxPrice.Text, txbxQty.Text)
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each row In dgvAddDescr.Rows
                                DescrCol.Add(row.Cells(0).Value.ToString)
                                Descr.Add(row.Cells(1).Value.ToString)
                            Next
                            newRow = dgvAddedList.Rows(dgvAddedList.Rows.Count - 1)

                            For Each col In DescrCol
                                newRow.Cells(col).Value = Descr(DescrCol.IndexOf(col))
                            Next
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

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        ' Initialize a transaction reference number
        Dim transactionRefNumber As String = Guid.NewGuid().ToString()
        Dim totalQty As Integer = 0
        ' Iterate through each row in the DataGridView
        For Each row As DataGridViewRow In dgvAddedList.Rows
            ' Read the selected category from the ComboBox for each row
            Dim categoryName As String = row.Cells("clmCategory").Value.ToString()
            ' Construct the path to the category file for each row
            Dim categoryFilePath As String = $"Stock\{categoryName}.csv"

            ' Check if the category file exists
            If File.Exists(categoryFilePath) Then
                ' Read all lines from the category file
                Dim lines As String() = File.ReadAllLines(categoryFilePath)

                ' Flag to check if a match is found
                Dim matchFound As Boolean = False

                ' Iterate over each line (excluding the header)
                For i As Integer = 1 To lines.Length - 1
                    ' Split the line into individual values
                    Dim values As String() = lines(i).Split(","c)
                    ' Check if the Product ID matches the current ID in the DataGridView
                    If values(0) = row.Cells("clmID").Value.ToString() Then
                        ' Add the new quantity to the existing quantity
                        Dim newQuantity As Integer = Integer.Parse(values(3)) + Integer.Parse(row.Cells("clmQuantity").Value.ToString())
                        totalQty += Integer.Parse(row.Cells("clmQuantity").Value)
                        ' Update the quantity in the line
                        lines(i) = $"{values(0)},{values(1)},{values(2)},{newQuantity}"
                        If values.Length > 4 Then
                            For j = 4 To values.Length - 1
                                If Not String.IsNullOrEmpty(values(i)) Then
                                    lines(i) += $",{values(j)}"
                                End If
                            Next
                        End If
                        ' Write the updated lines back to the category file
                        File.WriteAllLines(categoryFilePath, lines)

                        ' Log the transaction into Stock History.csv
                        Dim logEntry As String = $"{transactionRefNumber},{values(0)},{values(1)},{row.Cells("clmQuantity").Value},{DateTime.Now}"
                        File.AppendAllText("Resources/Stock History.csv", logEntry & Environment.NewLine)

                        ' Set the flag to true since a match is found
                        matchFound = True

                        ' Exit the loop once the update is done for the current row
                        Exit For
                    End If
                Next

                ' If no match is found, append the data to the CSV file
                If Not matchFound Then
                    Dim newData As String = $"{row.Cells("clmID").Value},{row.Cells("clmProduct").Value},,{row.Cells("clmQuantity").Value}"
                    totalQty += Integer.Parse(row.Cells("clmQuantity").Value)
                    For Each descr In dgvAddDescr.Rows
                        newData += $",{descr.Cells(1).Value}"
                    Next
                    File.AppendAllText(categoryFilePath, newData & Environment.NewLine)
                    File.AppendAllText("Resources\Stock History.csv", $"{transactionRefNumber},{totalQty},{DateTime.Now}" & Environment.NewLine)
                End If
            Else
                MessageBox.Show($"Category file '{categoryFilePath}' not found.")
            End If
        Next
        AddStockModule.PrintReceipt(transactionRefNumber.ToString, dgvAddedList, DateTime.Now)
        ' Notify the user that the stock has been saved for all items
        RefreshTable()
        MessageBox.Show("Stock saved successfully.")
    End Sub



    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        Dim Category As String = cbxCategory.SelectedItem.ToString
        Dim filePath As String = $"Stock\{Category}.csv"
        dgvAddDescr.Rows.Clear()

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            If lines.Length > 0 Then
                Dim columnHeaders As String() = lines(0).Split(","c) ' Assuming columns are comma-separated
                ' Assuming columnHeaders is the array containing all the column headers
                If columnHeaders.Length > 4 Then
                    For i As Integer = 4 To columnHeaders.Length - 1
                        dgvAddDescr.Rows().Add(columnHeaders(i))
                    Next
                End If
            End If
        Else
            MessageBox.Show("Category file not found.")
        End If
    End Sub
    Private Sub DeletePress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            btRemove_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btRemove_Click(sender As Object, e As EventArgs) Handles btRemove.Click
        ' Check if a row is selected in dgvAddedList
        If dgvAddedList.SelectedRows.Count > 0 Then
            ' Remove the selected row
            dgvAddedList.Rows.RemoveAt(dgvAddedList.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please first select an item to remove.")
        End If
    End Sub
End Class
