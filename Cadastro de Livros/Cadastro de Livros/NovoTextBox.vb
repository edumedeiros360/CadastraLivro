Public Class NovoTextBox

    Inherits TextBox

    Private MyColor As Color = Color.BlueViolet
    Private strTipo As String = ""

    Public Property ColorFoco() As Color
        Get
            ColorFoco = MyColor

        End Get

        Set(value As Color)
            MyColor = value

        End Set

    End Property


    Public Property Tipo() As String
        Get
            ColorFoco = MyColor

        End Get

        Set(value As String)
            strTipo = value

        End Set

    End Property


    'Quanto o foco estiver na textbox, ela fique azul.
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.BackColor = Color.PowderBlue
    End Sub

    'Quanto o foco sair da textbox, ela fique branca.'
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.BackColor = Color.White
    End Sub

End Class


