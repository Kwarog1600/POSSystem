Imports System.IO

Public Class TimeLog
    Private Sub TimeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadTimeLog()
    End Sub

    Sub LoadUsers()
        cbxUsers.Items.Clear()
        Dim usersList As New List(Of String)()

        Dim filePath As String = "Resources/Users.csv"
        Using reader As New StreamReader(filePath)
            reader.ReadLine()
            While Not reader.EndOfStream
                Dim line() As String = reader.ReadLine().Split(","c)
                usersList.Add(line(1))
            End While
        End Using

        usersList.Sort()
        usersList.Insert(0, "All") ' Add "All" on the first index
        For Each user As String In usersList
            cbxUsers.Items.Add(user)
        Next
        cbxUsers.SelectedItem = "All"
    End Sub

    Sub LoadTimeLog()
        Dim filePath As String = "Resources/TimeLog.csv"
        Using reader As New StreamReader(filePath)
            Dim headers() As String = reader.ReadLine().Split(","c)
            Dim lines() As String = reader.ReadToEnd().Split(Environment.NewLine)
            For Each col In headers
                dgvTimeLogs.Columns.Add(col, col)
            Next
            For Each line In lines
                Dim content() As String = line.Split(","c)
                dgvTimeLogs.Rows.Add(content)
            Next
        End Using
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUsers.SelectedIndexChanged
        Dim selectedUser As String = cbxUsers.SelectedItem.ToString()

        For Each row As DataGridViewRow In dgvTimeLogs.Rows
            If selectedUser = "All" OrElse (row.Cells.Count > 2 AndAlso row.Cells(2).Value IsNot Nothing AndAlso row.Cells(2).Value.ToString() = selectedUser) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub
End Class