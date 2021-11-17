Module Module1

    Sub Main()


        'Declaration
        Dim donut, donutcount As Integer


        'Initialization
        donut = 0
        donutcount = 0


        'Promt
        Console.Write("How many Donuts are there; For Example '4: ")
        'Input
        donut = Console.ReadLine

        'Count loop with condition'IF'

        For count = 1 To donut
            If donut > 10 Then
                Console.Write("Number of Donuts: MANY")
                Console.ReadLine()
            Else
                If Len(donut) < 10 Then
                    Console.WriteLine("NUMBER OF DONUTS: " & donut)
                    Console.ReadLine()
                End If
            End If
        Next
        Console.ReadKey()
    End Sub

End Module