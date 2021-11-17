Module Module1

    Sub Main()
        Dim s1, s2 As String
        Dim thischar As Char
        Dim Acount, Ecount, Icount, Ocount, Ucount, count As Integer

        s1 = ""
        s2 = ""
        thischar = ""
        Acount = 0
        Ecount = 0
        Icount = 0
        Ocount = 0
        Ucount = 0

        Console.Write("Enter the string to be processed: ")
        s1 = Console.ReadLine

        For count = 1 To Len(s1)
            s2 = UCase(s1)
            thischar = Mid(s2, count, 1)
            If thischar = "A" Then
                Acount = Acount + 1
            End If
            If thischar = "E" Then
                Ecount = Ecount + 1
            End If
            If thischar = "I" Then
                Icount = Icount + 1
            End If
            If thischar = "O" Then
                Ocount = Ocount + 1
            End If
            If thischar = "U" Then
                Ucount = Ucount + 1
            End If
        Next
        Console.WriteLine("Acount: " & Acount & ", Ecount: " & Ecount & ", Icount: " & Icount & ", Ocount: " & Ocount & ", Ucount: " & Ucount & ".")
        Console.ReadKey()
    End Sub

End Module
