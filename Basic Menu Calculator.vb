Module Module1

    Sub Main()
        Dim x, choice, valA, valB As Integer
        choice = 0
        valA = 0
        valB = 0
        x = 0

        Do
            Console.Clear()

            Console.WriteLine("1 Add")
            Console.WriteLine("2 Subtract")
            Console.WriteLine("3 Multiply")
            Console.WriteLine("4 Divide")
            Console.WriteLine("5 Exit")

            Do
                Console.Write("Enter your choice (1....5): ")
                choice = Console.ReadLine

            Loop Until choice >= 1 And choice <= 5

            If choice <> 5 Then
                Console.Write("Input first number: ")
                valA = Console.ReadLine

                Console.Write("Enter second value: ")
                valB = Console.ReadLine
            End If

            If choice = 1 Then
                Call Addition(valA, valB)

            End If

            If choice = 2 Then
                Call Subtraction(valA, valB)
            End If

            If choice = 3 Then
                x = Multiply(valA, valB)
                Console.WriteLine("Multiply" & valA & " * " & valB & " = " & x)
                Console.ReadKey()
            End If

            If choice = 4 Then
                x = Division(valA, valB)
                Console.WriteLine(" Divide " & valA & " / " & valB & " = " & x)
                Console.ReadKey()
            End If

        Loop Until choice = 5
    End Sub

    Sub Subtraction(ByVal a As Integer, ByVal b As Integer)
        Dim x As Integer
        x = b - a
        Console.WriteLine("Subtract " & b & " - " & a & " = " & x)
        Console.ReadKey()
    End Sub

    Sub Addition(ByVal a As Integer, ByVal b As Integer)
        Dim x As Integer
        x = a + b
        Console.WriteLine("Addition " & a & " + " & b & " = " & x)
        Console.ReadKey()
    End Sub

    Function Multiply(ByVal m1 As Integer, ByVal m2 As Integer) As Integer
        Dim x As Integer
        x = m1 * m2
        Return x
    End Function

    Function Division(ByVal d1 As Integer, ByVal d2 As Integer) As Single
        Dim x As Single
        x = d1 / d2
        Return x
    End Function

End Module
