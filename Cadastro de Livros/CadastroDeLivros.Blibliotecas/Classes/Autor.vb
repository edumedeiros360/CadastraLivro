Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados
Imports System.Security.Cryptography
Imports CadastroDeLivros.Blibliotecas.Classes

Namespace Classes


    ''' <summary>
    ''' Esta classe Representa o Autor de um Livro
    ''' </summary>
    Public Class Autor

#Region "PROPRIEDADES"

        Protected m_CodAu As Integer
        Public Property CodAu As Integer
            Get
                Return m_CodAu
            End Get
            Set(value As Integer)
                m_CodAu = value
            End Set
        End Property

        Protected m_Nome As String
        Public Property Nome As String
            Get
                Return m_Nome
            End Get
            Set(value As String)
                m_Nome = value
            End Set
        End Property


#End Region

#Region "CONSTRUTORES"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nome">Nome do autor</param>
        ''' <param name="codAs">Parametro opcional, se nao for informado o codigo sera -1. Codigo do autor na tabela</param>
        Public Sub New(nome As String, Optional codAu As Integer = -1)
            m_Nome = nome
            m_CodAu = codAu
        End Sub

        Public Sub New()

        End Sub
#End Region

#Region "MÉTODOS"

        Public Function IncluirAutor() As String
            Return ManutencaoAutorBD.IncluirAutor(Me)
        End Function

        Public Function ExcluirAutor() As String
            Return ManutencaoAutorBD.ExcluirAutor(Me)
        End Function

        Public Function AlterarAutor() As String

        End Function

        Public Function BuscarAutorDT() As DataTable
            Return ManutencaoAutorBD.BuscarTodosDT()
        End Function

        Public Function BuscarTodosDT() As DataTable
            Return ManutencaoAutorBD.BuscarTodosDT
        End Function

        Public Function BuscarTodosDS() As DataSet
            Return ManutencaoAutorBD.BuscarTodosDS
        End Function

#End Region



    End Class

End Namespace


