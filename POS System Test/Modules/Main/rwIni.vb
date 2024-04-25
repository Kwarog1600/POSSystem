Imports System.IO

Module rwIni
    Public Sub WriteIni(filePath As String, section As String, key As String, value As String)
        Try
            Dim lines As New List(Of String)

            If File.Exists(filePath) Then
                lines.AddRange(File.ReadAllLines(filePath))
            End If

            Dim sectionExists As Boolean = False
            Dim sectionIndex As Integer = -1
            Dim keyExistsInSection As Boolean = False

            For i As Integer = 0 To lines.Count - 1
                Dim line As String = lines(i).Trim()

                If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                    If line.Substring(1, line.Length - 2) = section Then
                        sectionExists = True
                        sectionIndex = i
                        Exit For
                    End If
                End If
            Next

            If Not sectionExists Then
                lines.Add($"[{section}]")
                lines.Add($"{key}={value}")
            Else
                For i As Integer = sectionIndex + 1 To lines.Count - 1
                    Dim line As String = lines(i).Trim()

                    If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                        lines.Insert(i, $"{key}={value}")
                        keyExistsInSection = True
                        Exit For
                    ElseIf line.StartsWith(key) Then
                        lines(i) = $"{key}={value}"
                        keyExistsInSection = True
                        Exit For
                    End If
                Next

                If Not keyExistsInSection Then
                    lines.Insert(sectionIndex + 1, $"{key}={value}")
                End If
            End If

            File.WriteAllLines(filePath, lines)
        Catch ex As Exception
            MessageBox.Show($"Failed to write to {filePath}")
        End Try
    End Sub

    Public Function ReadIni(filePath As String, section As String, key As String) As String
        Dim value As String = String.Empty
        Try
            Using reader As New StreamReader(filePath)
                Dim line As String
                Dim currentSection As String = ""
                While Not reader.EndOfStream
                    line = reader.ReadLine().Trim()
                    ' Check if the line is a section header
                    If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                        currentSection = line.Substring(1, line.Length - 2)
                    ElseIf currentSection = section Then
                        ' Check if the line contains the key
                        Dim parts() As String = line.Split("="c)
                        If parts.Length = 2 AndAlso parts(0).Trim() = key Then
                            value = parts(1).Trim()
                            Exit While
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to read from {filePath}")
        End Try
        Return value
    End Function

End Module
