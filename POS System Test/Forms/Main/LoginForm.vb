Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btLogin
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Me.Hide()
        MainForm.Show()
    End Sub



    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
