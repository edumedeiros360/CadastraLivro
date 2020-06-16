Imports System.Data.SqlClient

Namespace Classes.BancoDeDados

    Public Class ManutencaoLivrosBD

        Shared _Comando As SqlCommand
        Shared _DataAdapter As SqlDataAdapter
        Shared _StrSql As String
        Shared _StringDeConexao As String = "Data Source=NOTE; Initial Catalog=CadastroLivros; Integrated Security=True"

        Shared Function BuscarTodosDT() As DataTable

            Dim Dt As New DataTable
            Try
                Dim DB As New SQLServerConn("NOTE", "CadastroDeLivros")
                Dim Retorno As String = DB.SQLQuery("SELECT Titulo, Editora, Edicao , AnoPublicacao FROM Livro", Dt)
                DB.Close()

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return Dt

        End Function

        Shared Function IncluirLivro(livro As Livro) As String

            Dim mensagem As String = ""
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)
            Dim _DataSet As New DataSet
            Dim codL As Integer

            Try

                'Verificar qual foi CodL criado
                _StrSql = $"SELECT CODL AS PROXIMO_CODL FROM LIVRO WHERE UPPER(TITULO) = UPPER('{livro.Titulo}')"
                _Comando = New SqlCommand(_StrSql, _Conexao)

                _DataAdapter = New SqlDataAdapter(_StrSql, _Conexao)
                _DataAdapter.Fill(_DataSet)

                If _DataSet.Tables(0).Rows.Count > 0 Then
                    _Conexao.Close()
                    Return "Livro já cadastrado."
                Else

                    'Salvar na tabela LIVRO
                    _StrSql = $"INSERT INTO LIVRO (Titulo, Editora, Edicao , AnoPublicacao, Preco) VALUES ('{livro.Titulo}', '{livro.editora}', {livro.edicao}, '{livro.AnoPublicacao}', {Replace(livro.PrecoLivro, ",", ".") }  )"
                    _Comando = New SqlCommand(_StrSql, _Conexao)
                    _Conexao.Open()
                    _Comando.ExecuteNonQuery()


                    'Verificar qual foi CodL criado
                    _StrSql = $"SELECT CODL FROM LIVRO WHERE UPPER(TITULO) = UPPER('{livro.Titulo}')"
                    _Comando = New SqlCommand(_StrSql, _Conexao)

                    _DataAdapter = New SqlDataAdapter(_StrSql, _Conexao)
                    _DataAdapter.Fill(_DataSet)

                    codL = CInt(_DataSet.Tables(0).Rows(0)("CODL"))

                    'Salvar na tabela de relacionamento LIVRO_AUTOR
                    _StrSql = $"INSERT INTO LIVRO_AUTOR (LIVRO_CODL,AUTOR_CODAU) VALUES ('{codL}', '{livro.Autor.CodAu}')"
                    _Comando = New SqlCommand(_StrSql, _Conexao)
                    '_Conexao.Open()
                    _Comando.ExecuteNonQuery()

                    'Salvar na tabela de relacionamento  LIVRO_ASSUNTO
                    _StrSql = $"INSERT INTO LIVRO_ASSUNTO (LIVRO_CODL,ASSUNTO_CODAS) VALUES ('{codL}', '{livro.Assunto.CodAs}')"
                    _Comando = New SqlCommand(_StrSql, _Conexao)
                    '_Conexao.Open()
                    _Comando.ExecuteNonQuery()

                    mensagem = "Livro incluido com sucesso."

                    _Conexao.Close()
                End If

                Return mensagem

            Catch ex As Exception
                Return mensagem
                Throw New Exception(ex.Message)
            Finally

                _Conexao.Close()
                _Comando.Clone()
                _Conexao = Nothing
                _Comando = Nothing

            End Try

        End Function


        Shared Function ExcluirLivro(livro As Livro) As String

            Dim mensagem As String
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)

            Try

                'Deletar na tabela de relacionamento LIVRO_AUTOR
                _StrSql = $"DELETE LIVRO_AUTOR WHERE LIVRO_CODL = {livro.Codl}"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _Conexao.Open()
                _Comando.ExecuteNonQuery()

                'Salvar na tabela de relacionamento  LIVRO_ASSUNTO
                _StrSql = $"DELETE LIVRO_ASSUNTO WHERE LIVRO_CODL = {livro.Codl}"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                '_Conexao.Open()
                _Comando.ExecuteNonQuery()

                _StrSql = $"DELETE LIVRO WHERE CODL = {livro.Codl}"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                '_Conexao.Open()
                _Comando.ExecuteNonQuery()

                mensagem = "Livro foi excluído com sucesso."

                _Conexao.Close()

                Return mensagem

            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                _Conexao.Close()
                _Comando.Clone()
                _Conexao = Nothing
                _Comando = Nothing
            End Try

        End Function

        Shared Function AlterarLivro(livro As Livro) As String

            Dim mensagem As String
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)


            Try

                _StrSql = $"UPDATE LIVRO SET TITULO = '{livro.Titulo}', EDITORA = '{livro.editora}', EDICAO = {livro.edicao}, ANOPUBLICACAO = '{livro.AnoPublicacao}', PRECO = { Replace(livro.PrecoLivro, ",", ".")} WHERE TITULO = '{livro.Titulo}'"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _Conexao.Open()
                _Comando.ExecuteNonQuery()

                mensagem = "O livro foi alterado com sucesso."

                _Conexao.Close()

                Return mensagem

            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                _Conexao.Close()
                _Comando.Clone()
                _Conexao = Nothing
                _Comando = Nothing
            End Try

        End Function


        Shared Function BuscarTodosDS() As DataSet

            Dim dataSet As New DataSet
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)

            Try

                _StrSql = "SELECT CODL, TITULO, EDITORA, EDICAO , ANOPUBLICACAO, PRECO FROM LIVRO"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _DataAdapter = New SqlDataAdapter(_StrSql, _Conexao)
                _DataAdapter.Fill(dataSet)

                Return dataSet

            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                _Conexao.Close()
                _Comando.Clone()
                _Conexao = Nothing
                _Comando = Nothing
            End Try

        End Function


        Shared Function BuscarLivro(titulo As String) As DataSet

            Dim _DataSet As New DataSet
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)
            Dim _DataReader As SqlDataReader

            Try

                _StrSql = $"SELECT li.CODL, li.TITULO, li.EDITORA, li.EDICAO , li.ANOPUBLICACAO, li.PRECO, ass.CODAS, ass.DESCRICAO ASSUNTO, au.CodAu, au.Nome as AUTOR
                        FROM Livro li, Livro_Autor liau, Autor au, Livro_Assunto lias, Assunto ass
                        WHERE li.CodL = liau.Livro_Codl
                        AND liau.Autor_CodAu = au.CodAu
                        AND li.CodL = lias.Livro_Codl
                        AND lias.Assunto_codAs = ass.CodAs
                        AND UPPER(li.TITULO) LIKE UPPER('{titulo}') 
                        ORDER BY 2,3;"

                _Comando = New SqlCommand(_StrSql, _Conexao)

                _DataAdapter = New SqlDataAdapter(_StrSql, _Conexao)
                _DataAdapter.Fill(_DataSet)

                'Por que não funciona?
                '_Conexao.Open()
                '_DataReader = Comando.ExecuteReader
                'dt.AsDataView = dataSet
                'Return _DataReader


                Return _DataSet

            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                _Conexao.Close()
                _Comando.Clone()
                _Conexao = Nothing
                _Comando = Nothing
                _DataReader = Nothing
            End Try

        End Function

    End Class

End Namespace
