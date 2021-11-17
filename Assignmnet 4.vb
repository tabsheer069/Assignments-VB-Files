Module Module1

    Sub Main()
        Dim thischar, char1, char2 As Char
        Dim highest, count, count2, count3 As Integer
        Dim s1 As String

        thischar = ""
        char1 = ""
        char2 = ""
        highest = 0
        count = 0
        count2 = 0
        count3 = 0
        s1 = ""

        Console.Write("Enter the string: ")
        s1 = Console.ReadLine

        For count2 = 1 To Len(s1)
            thischar = Mid(s1, count2, 1)
            count = 0
            For count3 = 1 To Len(s1)
                char2 = Mid(s1, count3, 1)
                If char2 = thischar Then count = count + 1
            Next
            If count > highest Then
                highest = count
                char1 = thischar
            End If
        Next
        Console.WriteLine(char1 & " was used " & highest & " number of times")
        Console.ReadKey()

    End Sub

End Module
