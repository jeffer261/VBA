        'Exemplo While para formatação Condicional

        Dim cont As Integer = 2

        While cont <= Rows

            If Not (xlWorkSheet.Range("COLUNA A SER PERCORIDA" & cont).Value Is Nothing) Then

                If xlWorkSheet.Range("COLUNA A SER PERCORIDA" & cont).Value.ToString() = "VALOR QUANDO ENCONTRADO ENTRA NA FORMATAÇÃO" Then

                    'Formatação

                End If
            End If

            cont = cont + 1

        End While
