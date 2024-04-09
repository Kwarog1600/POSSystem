Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Public Class EmployeeManagement

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        AddUser.Visible = True
    End Sub

    Private Sub btChangePass_Click(sender As Object, e As EventArgs) Handles btChangePass.Click
        ChangePassword.Visible = True
    End Sub

    Private Sub dgvUserList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUserList.SelectionChanged

    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click

    End Sub

    Private Sub txbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txbxSearch.TextChanged

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

    End Sub
End Class