Module Module1


    Sub Main()
        'XDeclaration'
        Dim s1 As String
        Dim thischar, char1 As Char
        Dim charcount, count As Integer

        'INITIALISATION'
        s1 = ""
        thischar = ""
        charcount = 0
        count = 0
        char1 = ""

        'INPUT'
        Console.Write("Enter a sentence: ")
        s1 = Console.ReadLine()

        Console.Write("Enter the character to counted: ")
        char1 = Console.ReadLine()

        'PROGRAM'
        For count = 1 To Len(s1)
            thischar = Mid(s1, count, 1)
            If thischar = char1 Then
                charcount = charcount + 1
            Else
                charcount = charcount
            End If

        Next
        'OUTPUT'
        Console.Write("the character was used " & charcount & " times.")
        Console.ReadKey()

    End Sub

End Module
