Imports System

Module Modulo1
    Sub Main()

        Dim num1 As Integer = 3

        If num1 = 5 Then
            Console.WriteLine("num1 � igual a 5")

        ElseIf num1 < 5 Then

            Console.WriteLine("num1 � menor que 5. num1 � igual a " & num1)


        Else

            Console.WriteLine("num1 � maior que 5. num1 � igual a " & num1)
        End If

        Console.ReadLine()



        Dim num2 As Integer = 7

        If num2 = 4 Or num2 = 5 Then

            Console.WriteLine("num2 � igual a 4 ou 5")

        Else

            Console.WriteLine("num2 � diferente de 4 ou 5, num2 � " & num2)
        End If

        Console.ReadLine()



        If num1 = num2 And 5 Then

            Console.WriteLine("Os n�meros s�o equivalentes")

        Else

            Console.WriteLine("Os n�meros n�o n�o equivalentes")
        End If

        Console.ReadLine()
    End Sub
End Module
