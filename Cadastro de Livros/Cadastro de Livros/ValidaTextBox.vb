Module ValidaTextBox



    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer

        'Transformar letras minusculas em Maiúsculas

        KeyAscii = Asc(UCase(Chr(KeyAscii)))

        ' Intercepta um código ASCII recebido e admite somente letras

        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then

            SoLETRAS = 0

        Else

            SoLETRAS = KeyAscii

        End If



        ' teclas adicionais permitidas

        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace

        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter

        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace

    End Function


    Function SoNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then

            SoNumeros = 0

        Else

            SoNumeros = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumeros = Keyascii

            Case 13

                SoNumeros = Keyascii

            Case 32

                SoNumeros = Keyascii

        End Select

    End Function

    Function SoNumerosComVirgula(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then

            SoNumerosComVirgula = 0

        Else

            SoNumerosComVirgula = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumerosComVirgula = Keyascii

            Case 13

                SoNumerosComVirgula = Keyascii

            Case 32

                SoNumerosComVirgula = Keyascii

            Case 44

                SoNumerosComVirgula = Keyascii

        End Select

    End Function

End Module
