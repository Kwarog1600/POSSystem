Imports System.IO

Module AppModule
    Public Function MatchSearch(indexToMatch As Integer, itemToMatch As String, filepath As String) As String
        Dim toSend As String = ""
        Dim lines() As String = File.ReadAllLines(filepath)
        For Each line As String In lines
            Dim Content() As String = line.Split(","c)
            If Content(indexToMatch) = itemToMatch Then
                toSend = line
            End If
        Next
        Return toSend
    End Function
End Module
