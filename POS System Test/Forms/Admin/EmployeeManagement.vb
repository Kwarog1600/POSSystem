Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Public Class EmployeeManagement

    Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With Me
                .Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 50)
                .pnlContainer.Location = New Point(50, 50)
            End With

            dgvUserList.Columns.Clear()
            dgvUserList.Columns.Add("", "")
            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                dgvUserList.Rows.Add(userinfo(1))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
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
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(1) = dgvUserList.SelectedRows(0).Cells(0).Value Then
                    contents.Remove(contents(i))
                End If
            Next
            File.WriteAllLines($"{srcFolder}/Resources/Users.csv", contents)
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
End Class