Imports MySqlConnector

Module Conexao
    Public mysql As New MySqlConnection("server=localhost;userid=root;password=;database=sistema_clinica")

    Sub abrir()
        If mysql.State = 0 Then
            mysql.Open()
            MsgBox("Conectado com sucesso!")

        End If
    End Sub

    Sub fechar()
        If mysql.State = 1 Then
            mysql.Close()
            MsgBox("Conexão fehada!")

        End If
    End Sub

End Module
