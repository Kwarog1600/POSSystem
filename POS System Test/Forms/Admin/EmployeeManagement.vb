Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Public Class EmployeeManagement
    Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
            .pnlContainer.Location = New Point(50, 50)
        End With
        contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
        If Not dgvUserList.Columns.Contains("") Then
            dgvUserList.Columns.Add("1", "1")
        End If
        For i As Integer = 1 To contents.Count - 1
            Dim userinfo() As String = contents(i).Split(","c)
            Dim check As Boolean = False
            For Each row In dgvUserList.Rows
                If row.Cells(0).Value.Contains(userinfo(1)) Then
                    check = True
                End If
            Next
            If Not check Then
                dgvUserList.Rows.Add(userinfo(1))
            End If
        Next
        dgvUserList.Sort(dgvUserList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        AddUser.Visible = True
    End Sub

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        ChangePassword.Visible = True
    End Sub

    Private Sub dgvUserList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUserList.SelectionChanged
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(1) = dgvUserList.SelectedRows(0).Cells(0).Value Then
                    txbxUserID.Text = userinfo(0)
                    txbxUsername.Text = userinfo(1)
                    cbxAccess.SelectedItem = userinfo(3)
                    txbxFirstName.Text = userinfo(4)
                    txbxSurname.Text = userinfo(5)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Try
            MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo)
            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            Dim selectedUser As String = dgvUserList.SelectedRows(0).Cells(0).Value.ToString()
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(1) = selectedUser Then
                    contents.Remove(contents(i))
                    Exit For
                End If
            Next
            File.WriteAllLines($"{srcFolder}/Resources/Users.csv", contents)
            For Each row In dgvUserList.Rows
                If row.Cells(0).Value = selectedUser Then
                    dgvUserList.Rows.Remove(row)
                End If
            Next
            EmployeeManagement_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged
        Try
            For Each row As DataGridViewRow In dgvUserList.Rows
                If row.Cells(0).Value.ToString().Contains(txbxSearch.Text) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(0) = txbxUserID.Text Then
                    userinfo(1) = txbxUsername.Text
                    userinfo(3) = cbxAccess.SelectedItem
                    userinfo(4) = txbxFirstName.Text
                    userinfo(5) = txbxSurname.Text
                End If
                contents(i) = String.Join(",", userinfo)
            Next
            File.WriteAllLines($"{srcFolder}/Resources/Users.csv", contents)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgvUserList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellContentClick

    End Sub
End Class