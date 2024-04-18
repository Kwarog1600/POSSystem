Imports System.IO
Public Class ChangePassword

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        Dim userID = EmployeeManagement.txbxUserID.Text
        If txbxNewPassword.Text = txbxConfirmPass.Text Then
            contents = ReadCsv("Resources/Users.csv")
            For i As Integer = 1 To contents.Count - 1
                Dim userinfo() As String = contents(i).Split(","c)
                If userinfo(0) = userID Then
                    userinfo(2) = HashPassword(txbxNewPassword.Text)
                    contents(i) = String.Join(",", userinfo)
                End If
            Next
        End If
        File.WriteAllLines("Resources/Users.csv", contents)
    End Sub

End Class