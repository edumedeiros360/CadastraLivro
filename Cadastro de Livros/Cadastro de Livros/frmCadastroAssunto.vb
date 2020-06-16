Imports CadastroDeLivros.Blibliotecas.Classes
Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados

Public Class frmCadastroAssunto

    Dim m_Assunto As Assunto

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim mensagem As String

        m_Assunto = New Assunto(ntxtAssunto.Text)

        Try
            If Trim(ntxtAssunto.Text) = "" Then
                MessageBox.Show("Digite o assunto.")
            Else
                mensagem = m_Assunto.IncluirAssunto
                carregarGrid()
                MessageBox.Show(mensagem)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Assunto = Nothing
            LimparTela()
        End Try

    End Sub

    Private Sub btnExibirTodos_Click(sender As Object, e As EventArgs) Handles btnExibirTodos.Click

        Try
            carregarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid()

        dgvAssunto.Columns(0).HeaderText = "CÓDIGO"
        dgvAssunto.Columns(1).HeaderText = "ASSUNTO"

    End Sub

    Private Sub carregarGrid()

        Dim dataSet As DataSet

        m_Assunto = New Assunto(ntxtAssunto.Text)

        Try
            dataSet = m_Assunto.BuscarTodosDS

            dgvAssunto.DataSource = dataSet.Tables(0)

            FormatarGrid()

            m_Assunto = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Assunto = Nothing
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim mensagem As String
        Dim codAs As Integer
        Dim v_assunto As String


        Try
            If (dgvAssunto.SelectedRows.Count > 0) AndAlso (IsNumeric(codAs)) Then

                codAs = CInt(dgvAssunto.SelectedRows(0).Cells(0).Value.ToString())
                v_assunto = dgvAssunto.SelectedRows(0).Cells(1).Value.ToString()

                m_Assunto = New Assunto(v_assunto, codAs)

                mensagem = m_Assunto.ExcluirAssunto()
                MessageBox.Show(mensagem)

            Else
                MessageBox.Show("Selecione uma linha para poder excluir")
            End If

            carregarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Assunto = Nothing
            LimparTela()
        End Try


    End Sub

    Private Sub LimparTela()
        ntxtAssunto.Text = ""


    End Sub

End Class