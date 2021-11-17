Module Module1

    Sub Main()

        Dim str1 As String
        Dim thischar, char1 As Char
        Dim allalpha, count As Integer

        str1 = ""
        thischar = ""
        allalpha = 0
        count = 0
        char1 = "a-z, A-Z"

        Console.Write("Enter string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = char1 Then
                allalpha = allalpha + 1
            End If

            If str1 = InStr(str1, thischar) Then
                Console.WriteLine("this string has both capital and small alike")
            Else
                Console.WriteLine("this string is invalid")
            End If

        Next
        Console.ReadKey()


    End Sub

End Module
