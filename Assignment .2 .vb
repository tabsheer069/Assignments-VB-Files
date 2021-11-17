Module Module1

    Sub Main()

        'Declare 
        Dim str1, str2 As String
        Dim thischar As Char
        Dim count As Integer
        Dim char1 As Char
        Dim char2 As Char

        'Initialization 
        str1 = ""
        str2 = ""
        thischar = ""
        char1 = ""
        char2 = ""
        count = 0

        'Promt 
        Console.Write("Enter string to be processed: ")
        str1 = Console.ReadLine

        'Promt 
        Console.Write("Enter the character to replace: ")
        char1 = Console.ReadLine

        'Promt
        Console.Write("Enter the character to replace it with: ")
        char2 = Console.ReadLine

        'Count loop
        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = char1 Then
                str2 = Replace(str1, char1, char2)
            End If

        Next
        Console.WriteLine(str2)
        Console.ReadKey()
    End Sub

End Module
