Imports System.IO
Public Class AddUser
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If txbxPassword.Text = txbxConfirm.Text Then
            Dim user As String = txbxUsername.Text
            Dim pass As String = HashPassword(txbxPassword.Text)
            Dim access As String = cbxAccess.SelectedItem
            Dim fname As String = txbxFirstName.Text
            Dim surname As String = txbxSurname.Text

            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(1) = user Then
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK)
                    txbxUsername.Text = ""
                    Exit Sub
                End If
            Next
            Dim userID As String = $"U{contents.Count - 1:000}"
            contents.Add(userID & "," & user & "," & pass & "," & access & "," & fname & "," & surname)
            File.WriteAllLines($"{srcFolder}/Resources/Users.csv", contents)
            EmployeeManagement.dgvUserList.Rows.Clear()
            EmployeeManagement.EmployeeManagement_Load(sender, e)
        End If

    End Sub

End Class