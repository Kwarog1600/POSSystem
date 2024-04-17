Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.Notice.Warning.Types

Public Class LoginForm

    Public startCash As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btLogin
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        contents = ReadCsv("Resources/Users.csv")
        Dim match As Boolean = False
        For Each userinfo In contents
            Dim user = userinfo.Split(","c)
            If user(1) = txbxUsername.Text AndAlso user(2) = HashPassword(txbxPassword.Text) Then
                AccessLevel(user(3))
                match = True
            End If
        Next
        If match Then
            startCash = InputBox("Enter the start cash:", "Start Cash")
            MainForm.lbUsername.Text = txbxUsername.Text
            MainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect username or password")
        End If
    End Sub

End Class
