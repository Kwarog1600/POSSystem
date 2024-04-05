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
        Me.AcceptButton = btLogin
    End Sub


    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Application.Exit()
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim csvFilePath As String = $"Resources\Users.csv"
        Dim read As New StreamReader(csvFilePath)
        read.ReadLine()
        While Not read.EndOfStream
            Dim line As String = read.ReadLine()
            Dim data As String() = line.Split(","c)
            If data(1) = $"{txbxUsername.Text}" And data(2) = $"{HashPassword(txbxPassword.Text)}" Then
                TimeLog("In", txbxUsername.Text)
                ProgramLoad.AccessLevel(Int32.Parse(data(3)))
                MainForm.Show()
                MainForm.lbUsername.Text = data(1)
                MainForm.switchPanel(Dashboard)
                Me.Hide()
            Else
                MessageBox.Show("Incorrect username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End While
    End Sub

    Public Sub TimeLog(InOut As String, Username As String)
        Dim csvFilePath As String = $"Resources\TimeLog.csv"
        Using Write As New StreamWriter(csvFilePath, True)
            Write.WriteLine($"Logged {InOut},{DateTime.Now},{Username}")
        End Using
    End Sub

End Class
