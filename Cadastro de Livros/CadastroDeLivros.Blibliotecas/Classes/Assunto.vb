Imports System.Security.Cryptography
Imports CadastroDeLivros.Blibliotecas.Classes
Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados

Namespace Classes

    ''' <summary>
    ''' Esta classe Representa o Assunto de um Livro
    ''' </summary>
    Public Class Assunto

#Region "PROPRIEDADES"

        Protected m_CodAs As Integer
        Public Property CodAs As Integer
            Get
                Return m_CodAs
            End Get
            Set(value As Integer)
                m_CodAs = value
            End Set
        End Property

        Protected m_Descricao As String
        Public Property Descricao As String
            Get
                Return m_Descricao
            End Get
            Set(value As String)
                m_Descricao = value
            End Set
        End Property

#End Region

#Region "CONSTRUTORES"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="descricao">Assunto ao qual o livro se refere</param>
        ''' <param name="codAu">Parametro opcional, se nao for informado o codigo sera -1. Codigo do assunto na tabela</param>
        Public Sub New(descricao As String, Optional codAs As Integer = -1)
            m_Descricao = descricao
            m_CodAs = codAs
        End Sub

        Public Sub New()

        End Sub

#End Region

#Region "MÉTODOS"

        Public Function IncluirAssunto() As String
            Return ManutencaoAssuntoBD.IncluirAssunto(Me)
        End Function

        Public Function ExcluirAssunto() As String
            Return ManutencaoAssuntoBD.ExcluirAssunto(Me)
        End Function

        Public Function AlterarAssunto() As String

        End Function

        Public Function BuscarTodosDT() As DataTable
            Return ManutencaoAssuntoBD.BuscarTodosDT()
        End Function

        Public Function BuscarTodosDS() As DataSet
            Return ManutencaoAssuntoBD.BuscarTodosDS()
        End Function

#End Region

    End Class

End Namespace