Public Class LoginForm
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SystemLoad.LoadAll()
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        MainForm.Visible = True
        MainForm.switchPanel(Dashboard)
        Me.Visible = False
    End Sub

    Private Sub lblWelcMsg_Click(sender As Object, e As EventArgs) Handles lblWelcMsg.Click

    End Sub
End Class
