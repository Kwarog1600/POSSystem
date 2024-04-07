Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Public Class EmployeeManagement

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTable()
    End Sub

    Sub RefreshTable()
        Dim filePath As String = "Resources/Users.csv"
        Dim UserID As String = txbxUserID.Text

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                dgvUserList.Columns.Clear()
                dgvUserList.Columns.Add("", "")
                dgvUserList.Rows.Clear()
                reader.ReadLine()
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()

                    Dim columns As String() = line.Split(","c)

                    If columns.Length > 1 Then
                        dgvUserList.Rows.Add(columns(1))
                    End If
                End While
            End Using
        End If
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        AddUser.Visible = True
    End Sub

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        ChangePassword.Visible = True
    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellClick
        Dim filePath As String = "Resources/Users.csv"
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)
            For Each line As String In lines
                Dim contents As String() = line.Split(","c)
                If contents(1) = dgvUserList.SelectedCells(0).Value Then
                    txbxUserID.Text = contents(0)
                    txbxFirstName.Text = contents(4)
                    txbxSurname.Text = contents(5)
                    txbxUsername.Text = contents(1)
                    cbxAccess.SelectedItem = contents(3)
                End If
            Next
        End If
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.OKCancel)

        Dim filePath As String = "Resources/Users.csv"
        Dim UserID As String = txbxUserID.Text
        Dim lines() As String = File.ReadAllLines(filePath)
        Dim linesToKeep As New List(Of String)

        For Each line In lines
            Dim Info As String() = line.Split(","c)
            If Info(0) <> UserID Then
                linesToKeep.Add(line)
            End If
        Next

        File.WriteAllLines(filePath, linesToKeep)
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
        Dim searchText As String = txbxSearch.Text.ToLower()

        For Each row As DataGridViewRow In dgvUserList.Rows
            Dim isVisible As Boolean = False

            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                    isVisible = True
                    Exit For
                End If
            Next

            row.Visible = isVisible
        Next
    End Sub
End Class