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
        If txbxID IsNot Nothing Then
            For Each filename As String In cbxCategory.Items
                Dim filePath As String = filename & ".csv"
                ' Check if the file exists
                If File.Exists(filePath) Then

                    Try
                        ' Read all lines from the file
                        Dim lines As String() = File.ReadAllLines(filePath)

                        ' Check if there are items in the file
                        If lines.Length > 1 Then
                            ' Iterate through each line starting from index 1 (to skip header)
                            For i As Integer = 1 To lines.Length - 1
                                ' Split the line by comma to get individual values
                                Dim values As String() = lines(i).Split(","c)
                                If values(0).Equals(txbxID.Text) Then
                                    txbxBrand.Text = values(2)
                                    txbxModel.Text = values(3)
                                    txbxPrice.Text = values(1)
                                    cbxCategory.SelectedItem = filename
                                    Exit For
                                End If
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
            Next
        End If
    End Sub

    Private Sub UpdateRowHeaders()
        ' Get the selected content
        Dim selectedContent As String = cbxCategory.SelectedItem.ToString()
        dgvDescriptions.Rows.Clear()
        ' Create the file path using the selected content as the filename
        Dim filePath As String = Path.Combine(Application.StartupPath, $"{selectedContent}.csv")

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read the first line of the CSV file to get column headers
            Dim headers As String() = File.ReadLines(filePath).First().Split(","c)

            ' Add row headers to the DataGridView using the headers from the CSV file starting from the 6th column
            For i As Integer = 5 To headers.Length - 1
                dgvDescriptions.Rows.Add(headers(i), "")
            Next
        Else
            ' Add a new row to the DataGridView if the row does not exist
            dgvDescriptions.Rows.Add("No data available", "")
            MessageBox.Show($"Row for '{selectedContent}' does not exist. Added a default row to the DataGridView.", "Row Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dgvDescriptions.Columns("clmDesciptions").ReadOnly = True
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
        UpdateRowHeaders()
    End Sub

End Class
