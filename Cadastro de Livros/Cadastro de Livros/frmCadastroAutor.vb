Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados
Imports CadastroDeLivros.Blibliotecas.Classes

Public Class frmCadastroAutor

    Dim m_Autor As Autor


    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim mensagem As String
        m_Autor = New Autor(ntxtAutor.Text)

        Try
            If Trim(ntxtAutor.Text) = "" Then
                MessageBox.Show("Digite o autor.")
            Else
                mensagem = m_Autor.IncluirAutor
                carregarGrid()
                MessageBox.Show(mensagem)

            End If

            m_Autor = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Autor = Nothing
            LimparTela()
        End Try


    End Sub

    Private Sub FormatarGrid()

        dgvAutor.Columns(0).HeaderText = "CÓDIGO"
        dgvAutor.Columns(1).HeaderText = "AUTOR"

    End Sub

    Private Sub btnExibirTodos_Click(sender As Object, e As EventArgs) Handles btnExibirTodos.Click

        Try
            carregarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            LimparTela()
        End Try

    End Sub

    Private Sub carregarGrid()

        Dim dataSet As DataSet

        m_Autor = New Autor(ntxtAutor.Text)

        Try

            dataSet = m_Autor.BuscarTodosDS

            dgvAutor.DataSource = dataSet.Tables(0)

            FormatarGrid()

            m_Autor = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Autor = Nothing
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim mensagem As String
        Dim codAu As Integer
        Dim NomeAutor As String

        Try

            If (dgvAutor.SelectedRows.Count > 0) AndAlso (IsNumeric(codAu)) Then

                codAu = CInt(dgvAutor.SelectedRows(0).Cells(0).Value.ToString())
                NomeAutor = dgvAutor.SelectedRows(0).Cells(1).Value.ToString()

                m_Autor = New Autor(NomeAutor, codAu)

                mensagem = m_Autor.ExcluirAutor()

                MessageBox.Show(mensagem)

            Else
                MessageBox.Show("Selecione uma linha para poder excluir")
            End If

            carregarGrid()

            m_Autor = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Autor = Nothing
            LimparTela()
        End Try

    End Sub

    Private Sub LimparTela()
        ntxtAutor.Text = ""


    End Sub
End Class