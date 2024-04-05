Public Class EmployeeManagement

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MngtModule.Mngt()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        AddUser.Visible = True
    End Sub

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        ChangePassword.Visible = True
    End Sub
End Class