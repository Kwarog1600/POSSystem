Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Module MngtModule


    Public Sub Mngt()

        With EmployeeManagement
            Dim filePath As String = "Resources/Users.csv"

            ' Check if the file exists
            If File.Exists(filePath) Then
                ' Read all lines from the CSV file
                Dim lines As String() = File.ReadAllLines(filePath)
                .dgvUserList.Columns.Add("", "")

                For i As Integer = 1 To lines.Length - 1
                    Dim line As String() = lines(i).Split(","c)
                    .dgvUserList.Rows.Add(line(1))
                Next
            Else
                MessageBox.Show("Users.csv file not found.")
            End If
        End With
    End Sub

    Public Sub SelectUser(user As String)

    End Sub

End Module
