Imports System.IO
Public Class ChangePassword

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        Try
            Dim userID = EmployeeManagement.txbxUserID.Text
            If txbxNewPassword.Text = txbxConfirmPass.Text Then
                contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
                For i As Integer = 1 To contents.Count - 1
                    Dim userinfo() As String = contents(i).Split(","c)
                    If userinfo(0) = userID Then
                        userinfo(2) = HashPassword(txbxNewPassword.Text)
                        contents(i) = String.Join(",", userinfo)
                    End If
                Next
            End If
            File.WriteAllLines($"{srcFolder}/Resources/Users.csv", contents)
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

End Class