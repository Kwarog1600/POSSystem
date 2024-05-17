Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.Notice.Warning.Types

Public Class LoginForm

    Public Acc As Int16

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btLogin
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Try
            contents = ReadCsv($"{srcFolder}/Resources/Users.csv")
            Dim match As Boolean = False
            For Each userinfo In contents
                Dim user = userinfo.Split(","c)
                If user(1) = txbxUsername.Text AndAlso user(2) = HashPassword(txbxPassword.Text) Then
                    Acc = Integer.Parse(user(3))
                    AccessLevel(Acc)
                    match = True
                End If
            Next
            If match Then
                Dim isValidInput As Boolean = False
                Do Until isValidInput
                    Dim input As String = InputBox("Enter the start cash:", "Start Cash")
                    If IsNumeric(input) Then
                        Current = CInt(input)
                        isValidInput = True
                    Else
                        MessageBox.Show("Please enter a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Loop
                MainForm.lbUsername.Text = txbxUsername.Text
                MainForm.Show()
                Me.Hide()
                LogReg("In", txbxUsername.Text, Current)
                AppModule.Cash = Current
            Else
                MessageBox.Show("Incorrect username or password")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

End Class
