Imports System

Module Program

    Private nota1 As Double
    Private nota2 As Double
    Private nota3 As Double
    Private nota4 As Double

    Sub Main()
        Console.WriteLine("Informe a Nota 01: ")
        nota1 = Console.ReadLine

        Console.WriteLine("Informe a Nota 02: ")
        nota2 = Console.ReadLine

        Console.WriteLine("Informe a Nota 03: ")
        nota3 = Console.ReadLine

        Console.WriteLine("Informe a Nota 04: ")
        nota4 = Console.ReadLine

        Dim media As Double = (nota1 + nota2 + nota3 + nota4) / 4

        If media >= 7 Then
            Console.WriteLine("Aluno Aprovado com m�dia: " & media)

        ElseIf media >= 6 And media <= 6.9 Then
            Console.WriteLine("Aluno me Recupera��o com m�dia: " & media)

        Else
            Console.WriteLine("Aluno Reprovado com m�dia: " & media)
        End If


        Select Case media

            Case >= 7
                Console.WriteLine("Parab�ns, voc� pode curtir as suas merecidas f�rias!")

            Case >= 6 And media <= 6.9
                Console.WriteLine("Se prepare para o novo teste!")

            Case Else
                Console.WriteLine("Nos vemos novamente ano que vem!")
        End Select

        Console.ReadLine()
    End Sub
End Module
