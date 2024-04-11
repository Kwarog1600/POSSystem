Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.Notice.Warning.Types

Public Class LoginForm



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
            Me.Hide()
            MainForm.Show()
        Else
            MessageBox.Show("Incorrect username or password")
        End If
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
