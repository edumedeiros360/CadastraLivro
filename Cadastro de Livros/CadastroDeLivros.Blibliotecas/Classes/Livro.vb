Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados
Imports System.Security.Cryptography
Imports CadastroDeLivros.Blibliotecas.Classes

Namespace Classes

    ''' <summary>
    ''' Esta classe Representa um Livro
    ''' </summary>
    Public Class Livro


#Region "CONSTRUTORES"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="titulo">Titulo do Livro</param>
        ''' <param name="autor">Autor do Livro</param>
        ''' <param name="assunto">Assunto referente ao Livro</param>
        ''' <param name="codL">Parametro opcional, se nao for informado o codigo sera -1.  Codigo do livro na tabela</param>
        Public Sub New(titulo As String, autor As Autor, assunto As Assunto, Optional codL As Integer = -1)

            m_Titulo = titulo
            m_CodL = codL
            m_Assunto = assunto
            m_Autor = autor

        End Sub

        Public Sub New()


        End Sub

#End Region

#Region "PROPRIEDADES"

        Private m_Titulo As String
        ReadOnly Property Titulo As String
            Get
                Return m_Titulo
            End Get
        End Property

        Private m_CodL As Integer
        ReadOnly Property Codl As String
            Get
                Return m_CodL
            End Get
        End Property

        Private m_Autor As Autor
        Public Property Autor As Autor
            Get
                Return m_Autor
            End Get
            Set(value As Autor)
                m_Autor = value
            End Set
        End Property

        Private m_Assunto As Assunto
        Public Property Assunto As Assunto
            Get
                Return m_Assunto
            End Get
            Set(value As Assunto)
                m_Assunto = value
            End Set
        End Property

        Private m_Editora As String
        Public Property editora As String
            Get
                Return m_Editora
            End Get
            Set(value As String)
                m_Editora = value
            End Set
        End Property

        Private m_Edicao As Integer
        Public Property edicao As Integer
            Get
                Return m_Edicao
            End Get
            Set(value As Integer)
                m_Edicao = value
            End Set
        End Property

        Private m_AnoPublicacao As String
        Public Property AnoPublicacao As String
            Get
                Return m_AnoPublicacao
            End Get
            Set(value As String)
                m_AnoPublicacao = value
            End Set
        End Property

        Private m_PrecoLivro As String
        Public Property PrecoLivro As Double
            Get
                Return m_PrecoLivro
            End Get
            Set(value As Double)
                m_PrecoLivro = value
            End Set
        End Property


#End Region


#Region "MÉTODOS"

        Public Function Incluir() As String
            Return ManutencaoLivrosBD.IncluirLivro(Me)
        End Function

        Public Function Excluir() As String
            Return ManutencaoLivrosBD.ExcluirLivro(Me)
        End Function

        Public Function AlterarLivro() As String
            Return ManutencaoLivrosBD.AlterarLivro(Me)
        End Function

        Public Function BuscarLivro(titulo As String) As DataSet
            Return ManutencaoLivrosBD.BuscarLivro(titulo)
        End Function

        Public Function BuscarTodosDT() As DataTable
            Return ManutencaoLivrosBD.BuscarTodosDT()
        End Function

        Public Function BuscarTodosDS() As DataSet
            Return ManutencaoLivrosBD.BuscarTodosDS()
        End Function
#End Region



    End Class

End Namespace














