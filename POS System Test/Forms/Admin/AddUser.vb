Imports System.IO
Public Class AddUser

    Private Function UsernameExists(username As String) As Boolean
        Dim csvFile As String = "Resources/Users.csv"
        Dim lines() As String = File.ReadAllLines(csvFile)
        For Each line As String In lines
            Dim columns() As String = line.Split(","c)
            If columns.Length > 1 AndAlso columns(1) = username Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim FirstName As String = txbxFirstName.Text
        Dim LastName As String = txbxSurname.Text
        Dim Username As String = txbxUsername.Text
        Dim Password As String = LoginForm.HashPassword(txbxPassword.Text)
        Dim Access As String = cbxAccess.SelectedItem
        Dim UserID As String

        Dim csvFile As String = "Resources/Users.csv"
        Dim lines() As String = File.ReadAllLines(csvFile)
        UserID = $"U{(lines.Length - 1).ToString("D3")}"

        If FirstName = "" OrElse LastName = "" OrElse Username = "" OrElse Password = "" OrElse Access = "" Then
            MessageBox.Show("Please fill in all fields!")
        Else
            If UsernameExists(Username) Then
                ' Username already exists, handle accordingly
                MessageBox.Show("Username already exists!")
            Else
                ' Username does not exist, proceed with saving
                Dim newLine As String = $"{UserID},{Username},{Password},{Access},{FirstName},{LastName}"
                Dim Path As String = "Resources/Users.csv"
                File.AppendAllText(Path, newLine & Environment.NewLine)


                Dim toSort = File.ReadAllLines(csvFile)
                Dim sortedList = toSort.
                Skip(1).
                Select(Function(line) line.Split(","c)).
                OrderBy(Function(parts) parts(1)).
                Select(Function(parts) String.Join(",", parts)).
                ToList()
                sortedList.Insert(0, toSort(0))
                File.WriteAllLines(csvFile, sortedList)
                EmployeeManagement.RefreshTable()
            End If
        End If

    End Sub
End Class