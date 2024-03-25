﻿Imports System.IO
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
                        ' Read all lines from the file using StreamReader
                        Using reader As New StreamReader(filePath)
                            Dim line As String
                            ' Read each line until the end of the file
                            Do While reader.Peek() >= 0
                                line = reader.ReadLine()
                                Dim values As String() = line.Split(","c)
                                If values(0).Equals(txbxID.Text) Then
                                    txbxBrand.Text = values(2)
                                    txbxModel.Text = values(3)
                                    txbxPrice.Text = values(1)
                                    txbxQty.Text = 1
                                    cbxCategory.SelectedItem = filename
                                    Dim i As Integer = 5
                                    For Each row As DataGridViewRow In dgvDescriptions.Rows
                                        If values(i) IsNot Nothing Then
                                            row.Cells(1).Value = values(i)
                                            i += 1
                                        End If
                                    Next
                                    Exit For
                                Else
                                    txbxBrand.Clear()
                                    txbxModel.Clear()
                                    txbxPrice.Clear()
                                    txbxQty.Clear()
                                End If
                            Loop
                        End Using
                    Catch ex As Exception
                        ' Handle any exceptions that might occur during file reading
                        MessageBox.Show("Error reading file: " & ex.Message)
                    End Try
                Else
                    ' Handle case where file doesn't exist
                    MessageBox.Show("File does not exist: " & filePath)
                End If
            Next
        Else
            dgvDescriptions.Rows.Clear()
            cbxCategory.SelectedIndex = -1
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

        Using reader As New StreamReader(filePath)
            ' Use the reader here for further processing
        End Using

        dgvDescriptions.Columns("clmDesciptions").ReadOnly = True
    End Sub

    Private Sub btAddStock_Click(sender As Object, e As EventArgs) Handles btAddStock.Click
        If Not cbxCategory.SelectedIndex = -1 Then
            Dim Category As String = cbxCategory.SelectedItem.ToString()
            Dim ID As String = txbxID.Text
            Dim Model As String = txbxModel.Text
            Dim Brand As String = txbxBrand.Text
            Dim Quantity As String = txbxQty.Text
            Dim Price As String = txbxPrice.Text ' Assuming you have a textbox for the price

            If Quantity <= 0 Then
                MessageBox.Show("Quantity cannot be negative or zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If ID IsNot Nothing Then
                For Each row As DataGridViewRow In dgvDescriptions.Rows
                    Dim headerText As String = row.Cells(0).Value
                    If dgvAddedList.Columns.Contains(headerText) Then
                        Continue For ' Skip adding the column if it already exists
                    End If
                    dgvAddedList.Columns.Add(headerText, headerText)
                Next

                Dim existingRow As DataGridViewRow = dgvAddedList.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(r) r.Cells("clmID").Value IsNot Nothing AndAlso r.Cells("clmID").Value.ToString() = ID)

                If existingRow IsNot Nothing Then
                    Dim existingQuantity As Integer = Convert.ToInt32(existingRow.Cells("clmQuantity").Value)
                    existingRow.Cells("clmQuantity").Value = existingQuantity + Convert.ToInt32(Quantity)
                Else
                    Dim rowData As New List(Of Object)()
                    rowData.Add(Category)
                    rowData.Add(ID)
                    rowData.Add(Model)
                    rowData.Add(Brand)
                    rowData.Add(Quantity)
                    rowData.Add(Price) ' Add the price to the row data

                    For Each row As DataGridViewRow In dgvDescriptions.Rows
                        rowData.Add(row.Cells(1).Value)
                    Next

                    dgvAddedList.Rows.Add(rowData.ToArray())
                End If
            Else
                MessageBox.Show("Please enter an ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a category.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        UpdateRowHeaders()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        For Each row As DataGridViewRow In dgvAddedList.Rows
            Dim category As String = row.Cells("clmCategory").Value.ToString()
            Dim id As String = row.Cells("clmID").Value.ToString()
            Dim fileName As String = category & ".csv"
            Dim lines As New List(Of String)

            ' Read all lines from the CSV file
            Using reader As New StreamReader(fileName)
                Do While Not reader.EndOfStream
                    lines.Add(reader.ReadLine())
                Loop
            End Using

            ' Find and update the line with the matching ID
            Dim found As Boolean = False
            For i As Integer = 0 To lines.Count - 1
                Dim values As String() = lines(i).Split(","c)
                If values(0) = id Then
                    Dim quantity As Integer = Convert.ToInt32(values(4))
                    quantity += Convert.ToInt32(row.Cells("clmQuantity").Value)
                    values(4) = quantity.ToString()
                    lines(i) = String.Join(",", values)
                    found = True
                    Exit For
                End If
            Next

            ' Add the item if it does not match any
            ' Add the item if it does not match any
            If Not found Then
                Dim newLine As String = String.Join(",", row.Cells.Cast(Of DataGridViewCell).Skip(1).Select(Function(cell) cell.Value), row.Cells("clmPrice").Value)
                lines.Add(newLine)
            End If

            ' Write all lines back to the CSV file
            Using writer As New StreamWriter(fileName)
                For Each line As String In lines
                    writer.WriteLine(line)
                Next
            End Using

            AddToStockHistoryLog(id, row.Cells("clmModel").Value.ToString(), Convert.ToInt32(row.Cells("clmQuantity").Value))
            Inventory.PopulateDataGridViewForCategory(Inventory.cbxCategory.SelectedItem.ToString())
        Next
    End Sub

    Private Sub AddToStockHistoryLog(id As String, model As String, quantity As Integer)
        Dim fileName As String = "Stock History.csv"

        ' Create the log entry string
        Dim logEntry As String = $"{id},{model},{quantity},{DateTime.Now}"

        ' Append the log entry to the CSV file
        Using writer As New StreamWriter(fileName, True)
            writer.WriteLine(logEntry)
        End Using


    End Sub
End Class
