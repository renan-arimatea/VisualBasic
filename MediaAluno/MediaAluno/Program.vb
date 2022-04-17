Imports System

Module Program

    Private sair As String = "n"
    Private nota As Double = 0
    Private media As Double = 0
    Sub Main()
        Do Until sair = "s"

            nota = 0

            For I As Integer = 1 To 4
                Console.WriteLine("Informe a nota: " & I)
                nota += Console.ReadLine

            Next

            media = nota / 4

            If media >= 7 Then
                Console.WriteLine("Aluno Aprovado! com média: " & media)

            ElseIf media >= 6 And media < 7 Then
                Console.WriteLine("Aluno em Recuperação! com média: " & media)

            Else
                Console.WriteLine("Aluno Reprovado! com média: " & media)
            End If

            Console.WriteLine("Deseja sair? (s/n)")
            sair = Console.ReadLine()
            Console.Clear()

        Loop

    End Sub
End Module
