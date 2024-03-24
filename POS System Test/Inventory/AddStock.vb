Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar

Public Class AddStock
    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define the path to your CSV file
        Dim filePath As String = "Stock Category.csv"

        ' Check if the file exists
        If File.Exists(filePath) Then
            Try
                ' Read all lines from the file
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Check if there are lines in the file
                If lines.Length > 0 Then
                    ' Iterate through each line starting from index 1 (to skip header)
                    For i As Integer = 1 To lines.Length - 1
                        ' Split the line by comma to get individual values
                        Dim values As String() = lines(i).Split(","c)

                        ' Add the category to the ComboBox
                        cbxCategory.Items.Add(values(0)) ' Assuming the category is in the first column
                    Next
                End If
            Catch ex As Exception
                ' Handle any exceptions that might occur during file reading
                MessageBox.Show("Error reading file: " & ex.Message)
            End Try
        Else
            ' Handle case where file doesn't exist
            MessageBox.Show("File does not exist: " & filePath)
        End If
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        Dim idToSearch As String = txbxID.Text.Trim()

        ' Check if the ID to search is not empty
        If Not String.IsNullOrEmpty(idToSearch) Then
            ' Define the path to your CSV file containing category filenames
            Dim categoryFilePath As String = "Stock Category.csv"

            ' Check if the category file exists
            If File.Exists(categoryFilePath) Then
                Try
                    ' Read all lines from the category file
                    Dim categoryLines As String() = File.ReadAllLines(categoryFilePath)

                    ' Check if there are lines in the category file
                    If categoryLines.Length > 0 Then
                        ' Iterate through each line starting from index 1 (to skip header)
                        For i As Integer = 1 To categoryLines.Length - 1
                            ' Split the line by comma to get individual values
                            Dim categoryValues As String() = categoryLines(i).Split(","c)

                            ' Check if the category values are present and in the expected format
                            If categoryValues.Length > 1 Then
                                ' Assuming the category filename is in the second column
                                Dim csvFileName As String = categoryValues(0) & ".csv"

                                ' Check if the CSV file exists
                                If File.Exists(csvFileName) Then
                                    Try
                                        ' Read all lines from the CSV file
                                        Dim lines As String() = File.ReadAllLines(csvFileName)

                                        ' Check if there are lines in the file
                                        If lines.Length > 0 Then
                                            ' Iterate through each line starting from index 1 (to skip header)
                                            For j As Integer = 1 To lines.Length - 1
                                                ' Split the line by comma to get individual values
                                                Dim values As String() = lines(j).Split(","c)

                                                ' Check if the first value (ID) matches the ID to search
                                                If values.Length > 0 AndAlso values(0) = idToSearch Then
                                                    ' If a match is found, update the UI elements
                                                    txbxPrice.Text = values(2) ' Assuming Price is in the fourth column

                                                    txbxBrand.Text = values(1) ' Assuming Brand is in the second column
                                                    txbxModel.Text = values(3) ' Assuming Model is in the third column
                                                    cbxCategory.Text = categoryValues(0) ' Category name is in the first column of category file

                                                    ' Clear existing rows and columns in dgvDescriptions
                                                    dgvDescriptions.Rows.Clear()
                                                    dgvDescriptions.Columns.Clear()

                                                    ' Update column headers
                                                    UpdateRowHeaders(lines(0))

                                                    ' Add corresponding details to dgvDescriptions
                                                    dgvDescriptions.Rows.Add()
                                                    For k As Integer = 4 To values.Length - 1 ' Assuming details start from the 5th column
                                                        dgvDescriptions.Rows(0).Cells(k - 4).Value = values(k)
                                                    Next

                                                    ' If a match is found, update the UI elements and make them non-editable
                                                    txbxBrand.Text = values(1) ' Assuming Brand is in the second column
                                                    txbxModel.Text = values(2) ' Assuming Model is in the third column
                                                    cbxCategory.Text = categoryValues(0) ' Category name is in the first column of category file

                                                    ' Make textboxes and combobox non-editable
                                                    txbxBrand.ReadOnly = True
                                                    txbxModel.ReadOnly = True
                                                    txbxPrice.ReadOnly = True
                                                    cbxCategory.Enabled = False

                                                    ' Clear existing rows and columns in dgvDescriptions
                                                    dgvDescriptions.Rows.Clear()
                                                    dgvDescriptions.Columns.Clear()

                                                    ' Make DataGridView non-editable
                                                    dgvDescriptions.ReadOnly = True

                                                    ' Update column headers
                                                    UpdateRowHeaders(lines(0))

                                                    ' Add corresponding details to dgvDescriptions
                                                    dgvDescriptions.Rows.Add()
                                                    For k As Integer = 4 To values.Length - 1 ' Assuming details start from the 5th column
                                                        dgvDescriptions.Rows(0).Cells(k - 4).Value = values(k)
                                                    Next

                                                    ' Make DataGridView non-editable
                                                    For Each column As DataGridViewColumn In dgvDescriptions.Columns
                                                        column.ReadOnly = True
                                                    Next

                                                    ' Exit the event handler since the ID is found
                                                    Return
                                                End If
                                            Next
                                        End If
                                    Catch ex As Exception
                                        ' Handle any exceptions that might occur during file reading
                                        MessageBox.Show($"Error reading file {csvFileName}: {ex.Message}")
                                    End Try
                                Else
                                    ' Handle case where CSV file doesn't exist
                                    MessageBox.Show($"File does not exist: {csvFileName}")
                                End If
                            End If
                        Next
                    End If
                Catch ex As Exception
                    ' Handle any exceptions that might occur during category file reading
                    MessageBox.Show($"Error reading file {categoryFilePath}: {ex.Message}")
                End Try
            Else
                ' Handle case where category file doesn't exist
                MessageBox.Show($"File does not exist: {categoryFilePath}")
            End If
        End If
    End Sub

    Private Sub UpdateRowHeaders(headerLine As String)
        ' Add row headers to dgvDescriptions
        Dim headers As String() = headerLine.Split(","c)
        For k As Integer = 1 To headers.Length - 1 ' Assuming details start from the 2nd column
            dgvDescriptions.Rows(k - 1).HeaderCell.Value = headers(k)
        Next
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        Dim Category As String = cbxCategory.SelectedItem.ToString()
        Dim ID As String = txbxID.Text
        Dim Model As String = txbxModel.Text
        Dim Brand As String = txbxBrand.Text
        Dim Quantity As String = txbxQty.Text


        For Each row As DataGridViewRow In dgvDescriptions.Rows
            Dim headerText As String = row.Cells(0).Value
            If dgvAddedList.Columns.Contains(headerText) Then
                Continue For ' Skip adding the column if it already exists
            End If
            dgvAddedList.Columns.Add(headerText, headerText)
        Next

    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        ' Get the selected content
        Dim selectedContent As String = cbxCategory.SelectedItem.ToString()

        ' Create the file path using the selected content as the filename
        Dim filePath As String = Path.Combine(Application.StartupPath, $"{selectedContent}.csv")

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read the first line of the CSV file to get column headers
            Dim headers As String() = File.ReadLines(filePath).First().Split(","c)

            ' Clear existing columns from the DataGridView
            dgvDescriptions.Columns.Clear()

            ' Add a column for headers
            dgvDescriptions.Columns.Add("HeaderColumn", "Description")

            ' Add a column for editing
            dgvDescriptions.Columns.Add("EditingColumn", "Value")

            ' Add row headers to the DataGridView using the headers from the CSV file starting from the 6th column
            For i As Integer = 5 To headers.Length - 1
                dgvDescriptions.Rows.Add(headers(i), "")
            Next
        Else
            ' Add a new row to the DataGridView if the row does not exist
            dgvDescriptions.Rows.Add("No data available", "")
            MessageBox.Show($"Row for '{selectedContent}' does not exist. Added a default row to the DataGridView.", "Row Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dgvDescriptions.Columns("HeaderColumn").ReadOnly = True
    End Sub

End Class
