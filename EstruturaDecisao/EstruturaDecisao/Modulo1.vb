Imports System

Module Modulo1
    Sub Main()

        Dim num1 As Integer = 3

        If num1 = 5 Then
            Console.WriteLine("num1 é igual a 5")

        ElseIf num1 < 5 Then

            Console.WriteLine("num1 é menor que 5. num1 é igual a " & num1)


        Else

            Console.WriteLine("num1 é maior que 5. num1 é igual a " & num1)
        End If

        Console.ReadLine()



        Dim num2 As Integer = 7

        If num2 = 4 Or num2 = 5 Then

            Console.WriteLine("num2 é igual a 4 ou 5")

        Else

            Console.WriteLine("num2 é diferente de 4 ou 5, num2 é " & num2)
        End If

        Console.ReadLine()



        If num1 = num2 And 5 Then

            Console.WriteLine("Os números são equivalentes")

        Else

            Console.WriteLine("Os números não não equivalentes")
        End If

        Console.ReadLine()
    End Sub
End Module
