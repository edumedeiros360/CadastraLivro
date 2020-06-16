Imports System.Data.SqlClient

Namespace Classes.BancoDeDados

    Public Class ManutencaoAssuntoBD

        Shared _Comando As SqlCommand

        Shared _DataAdapter As SqlDataAdapter
        Shared _StrSql As String
        Shared _StringDeConexao As String = "Data Source=NOTE; Initial Catalog=CadastroLivros; Integrated Security=True"

        Shared Function BuscarTodosDT() As DataTable

            Dim Dt As New DataTable
            Try
                Dim DB As New SQLServerConn("NOTE", "CadastroLivros")
                Dim Retorno As String = DB.SQLQuery("SELECT CODAS, DESCRICAO FROM ASSUNTO", Dt)

                DB.Close()

                Return Dt

            Catch ex As Exception
                Throw New Exception(ex.Message)

            End Try


        End Function

        Shared Function IncluirAssunto(assunto As Assunto) As String

            Dim mensagem As String = ""
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)

            Try


                'Salvar na tabela LIVRO
                _StrSql = $"INSERT INTO ASSUNTO (DESCRICAO) VALUES ('{assunto.Descricao}')"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _Conexao.Open()
                _Comando.ExecuteNonQuery()

                mensagem = $"Assunto foi incluido com sucesso."

                _Conexao.Close()

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


        Shared Function ExcluirAssunto(assundo As Assunto) As String

            Dim mensagem As String
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)

            Try

                _StrSql = $"DELETE ASSUNTO WHERE CODAS = {assundo.CodAs}"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _Conexao.Open()
                _Comando.ExecuteNonQuery()

                mensagem = "Assunto foi excluído com sucesso."


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

        Shared Function AlterarAssunto(assunto As String) As String

            Dim mensagem As String
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)

            Try

                _StrSql = $"UPDATE ASSUNTO SET DESCRICAO = '{assunto}' WHERE DESCRICAO = '{assunto}'"
                _Comando = New SqlCommand(_StrSql, _Conexao)
                _Conexao.Open()
                _Comando.ExecuteNonQuery()

                mensagem = $"Assunto {assunto} foi alterado com sucesso."

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

                _StrSql = "SELECT CODAS, DESCRICAO FROM ASSUNTO"
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


        Shared Function ConsultarAssunto(nome As String) As DataSet

            Dim _DataSet As New DataSet
            Dim _Conexao As SqlConnection = New SqlConnection(_StringDeConexao)
            Dim _DataReader As SqlDataReader

            Try

                _StrSql = $"SELECT CODAS, DESCRICAO FROM ASSUNTO WHERE DESCRICAO LIKE '{nome}';"
                _Comando = New SqlCommand(_StrSql, _Conexao)

                _DataAdapter = New SqlDataAdapter(_StrSql, _Conexao)
                _DataAdapter.Fill(_DataSet)

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
