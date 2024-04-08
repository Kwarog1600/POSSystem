Imports System.IO
Public Class ChangePassword

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        If txbxNewPassword.Text = "" OrElse txbxConfirmPass.Text = "" Then
            MessageBox.Show("Please fill in all fields!")
        ElseIf txbxNewPassword.Text <> txbxConfirmPass.Text Then
            MessageBox.Show("Passwords do not match!")
        Else
            Dim filepath As String = "Resources/Users.csv"
            Dim userList() As String = File.ReadAllLines(filepath)
            For Each user In userList
                Dim Info() = user.Split(","c)
                If Info(0) = EmployeeManagement.txbxUserID.Text Then
                    Info(2) = LoginForm.HashPassword(txbxNewPassword.Text)
                    user = String.Join(",", Info)
                End If
            Next
            File.WriteAllLines(filepath, userList)
        End If
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btChangePass
    End Sub
End Class