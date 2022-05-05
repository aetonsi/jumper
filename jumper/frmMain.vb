Module frmMain

    Sub Main()
        If My.Application.CommandLineArgs.Count = 0 Then
            Exit Sub
        End If
        Dim p As New Process
        Dim args As String = ""
        'first arg received is process path
        For i = 1 To My.Application.CommandLineArgs.Count - 1
            args &= " " & qin(My.Application.CommandLineArgs(i))
        Next
        p.StartInfo.Arguments = args
        p.StartInfo.FileName = My.Application.CommandLineArgs(0)

        'p.StartInfo.UseShellExecute = False
        'p.StartInfo.RedirectStandardError = p.StartInfo.RedirectStandardInput = p.StartInfo.RedirectStandardOutput = True

        p.Start()
    End Sub
    Function qin(ByVal str As String) As String
        If str.Contains(Chr(34)) Then
            str = str.Replace(Chr(34), "\""")
        End If
        If str.Contains(" ") Then
            str = """" & str & """"
        End If
        Return str
    End Function
End Module
