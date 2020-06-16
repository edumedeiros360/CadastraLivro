Imports System.Data.SqlClient

Namespace Classes.BancoDeDados

    Public Class SQLServerConn

#Region "PROPRIEDADES"

        Public Property StringConn As String
        Public Property connDB As SqlConnection

#End Region

#Region "CONSTRUTOR"

        Public Sub New(Servidor As String, Banco As String)
            StringConn = "Data Source=" + Servidor + ";Initial Catalog=" +
                Banco + ";Integrated Security=True"
            connDB = New SqlConnection(StringConn)
            connDB.Open()
        End Sub

#End Region

#Region "MÉTODOS"

        Public Function SQLQuery(SQL As String, ByRef DT As DataTable) As String
            Try
                Dim myCommand As IDbCommand = New SqlCommand(SQL, connDB)
                'Faz que o TimeOut não aconteca, fica esperando o resultado
                myCommand.CommandTimeout = 0
                Dim myReader As IDataReader = myCommand.ExecuteReader
                DT.Load(myReader)
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function SQLCommand(SQL As String) As String
            Try
                Dim myCommand As IDbCommand = New SqlCommand(SQL, connDB)
                myCommand.CommandTimeout = 0
                myCommand.ExecuteReader()
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function





        Public Sub Close()
            connDB.Close()
        End Sub

#End Region

    End Class

End Namespace