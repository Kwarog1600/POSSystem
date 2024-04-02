Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class LoginForm
    Public Function HashPassword(password As String) As String
        ' Convert the password to bytes
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)

        ' Create a SHA256 hash
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(bytes)

            ' Convert hashed bytes to a string
            Dim builder As StringBuilder = New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgramLoad.LoadAll()
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim read As New StreamReader($"{Application.StartupPath}\Users.csv")
        read.ReadLine()
        While Not read.EndOfStream
            Dim line As String = read.ReadLine()
            Dim data As String() = line.Split(","c)
            Dim dataWithoutLastColumn As String() = data.Take(data.Length - 1).ToArray()
            Dim joinedData As String = String.Join(",", dataWithoutLastColumn)
            If joinedData = $"{txbxUsername.Text},{HashPassword(txbxPassword.Text)}" Then
                MainForm.Visible = True
                MainForm.switchPanel(Dashboard)
                Me.Visible = False
            Else
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End While
    End Sub

End Class
