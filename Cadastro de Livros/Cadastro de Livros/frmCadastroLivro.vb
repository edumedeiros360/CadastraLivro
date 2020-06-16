Imports CadastroDeLivros.Blibliotecas.Classes.BancoDeDados
Imports CadastroDeLivros.Blibliotecas.Classes

Public Class frmCadastroLivro

    Dim m_Livro As Livro
    Dim m_Assunto As Assunto
    Dim m_Autor As Autor

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Try

            m_Assunto = New Assunto
            m_Autor = New Autor
            carregarComboAutor()
            carregarComboAssunto()
            btnAlterar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            m_Assunto = Nothing
            m_Autor = Nothing
        End Try


    End Sub


    Private Sub carregarComboAutor()

        Dim dataTable As DataTable

        Try

            dataTable = m_Autor.BuscarTodosDT
            cboAutor.ValueMember = "CODAU"
            cboAutor.DisplayMember = "NOME"
            cboAutor.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub carregarComboAssunto()
        Dim dataTable As DataTable

        Try
            dataTable = m_Assunto.BuscarTodosDT

            cboAssunto.ValueMember = "CODAS"
            cboAssunto.DisplayMember = "DESCRICAO"
            cboAssunto.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim mensagem As String
        Dim codAs As Integer
        Dim codAu As Integer
        Dim descricao As String
        Dim nome As String

        Try
            If cboAutor.SelectedIndex < 0 Or cboAssunto.SelectedIndex < 0 Then
                MessageBox.Show("Favor escolher um Autor e um Assunto esse campos são obrigatórios.")
            Else

                codAs = cboAssunto.Items(cboAssunto.SelectedIndex)(0)
                descricao = cboAssunto.Text
                codAu = cboAutor.Items(cboAutor.SelectedIndex)(0)
                nome = cboAutor.Text

                m_Assunto = New Assunto(descricao, codAs)
                m_Autor = New Autor(nome, codAu)


                m_Livro = New Livro(ntxtTitulo.Text, m_Autor, m_Assunto) With {
                            .editora = ntxtEditora.Text,
                            .edicao = ntxtEdicao.Text,
                            .AnoPublicacao = ntxtAnoPublicacao.Text,
                            .PrecoLivro = ntxtPreco.Text
                }

                mensagem = m_Livro.Incluir()

                MessageBox.Show(mensagem)

                carregarGrid()
            End If
            LimparTela()
        Catch ex As Exception
            m_Livro = Nothing
            MessageBox.Show(ex.Message)
        Finally
            m_Livro = Nothing

        End Try


    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultarTitulo.Click

        Dim dataSet As DataSet

        Try
            'Refazer, retornar um obj Livro e a carregar todo os campos pelo obj
            'dataSet = ManutencaoLivrosBD.ConsultarLivro(ntxtTitulo.Text)
            m_Livro = New Livro()

            dataSet = m_Livro.BuscarLivro(ntxtTitulo.Text)


            If dataSet.Tables(0).Rows.Count > 0 Then
                ntxtTitulo.Text = dataSet.Tables(0).Rows(0)("Titulo")
                ntxtEditora.Text = dataSet.Tables(0).Rows(0)("EDITORA")
                ntxtEdicao.Text = dataSet.Tables(0).Rows(0)("EDICAO")
                ntxtAnoPublicacao.Text = dataSet.Tables(0).Rows(0)("ANOPUBLICACAO")
                ntxtPreco.Text = dataSet.Tables(0).Rows(0)("PRECO")
                cboAssunto.SelectedValue = dataSet.Tables(0).Rows(0)("CODAS")
                cboAutor.SelectedValue = dataSet.Tables(0).Rows(0)("CODAU")
                btnAlterar.Enabled = True
            Else
                MessageBox.Show("Livro não encontrado.")
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
            btnAlterar.Enabled = False
        Finally
            m_Livro = Nothing
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

        dgvLivros.Columns(0).HeaderText = "CÓDIGO"
        dgvLivros.Columns(1).HeaderText = "TÍTULO"
        dgvLivros.Columns(2).HeaderText = "EDITORA"
        dgvLivros.Columns(3).HeaderText = "EDIÇÃO"
        dgvLivros.Columns(4).HeaderText = "ANO PUBLICAÇÃO"
        dgvLivros.Columns(5).HeaderText = "PREÇO"

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim mensagem As String


        Try

            m_Livro = New Livro(ntxtTitulo.Text, m_Autor, m_Assunto) With {
                                .editora = ntxtEditora.Text,
                                .edicao = ntxtEdicao.Text,
                                .AnoPublicacao = ntxtAnoPublicacao.Text,
                                .PrecoLivro = ntxtPreco.Text
            }

            mensagem = m_Livro.AlterarLivro()
            MessageBox.Show(mensagem)

        Catch ex As InvalidCastException
            MessageBox.Show("Preço inválido")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            LimparTela()
        End Try

    End Sub

    Private Function Consulta() As Boolean

        Return true
    End Function
    Private Sub carregarGrid()

        Dim dataSet As DataSet

        Try

            m_Livro = New Livro()

            dataSet = m_Livro.BuscarTodosDS()

            dgvLivros.DataSource = dataSet.Tables(0)

            FormatarGrid()
        Catch er As NullReferenceException
            MessageBox.Show("Objeto Não instanciado." + er.Message)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim mensagem As String
        Dim codL As Integer
        Dim codAs As Integer
        Dim codAu As Integer
        Dim descricao As String
        Dim nome As String
        Dim editora As String
        Dim edicao As Integer
        Dim anoPublicacao As Integer
        Dim PrecoLivro As Double

        Try

            If (dgvLivros.SelectedRows.Count > 0) AndAlso (IsNumeric(codL)) Then

                codL = CInt(dgvLivros.SelectedRows(0).Cells(0).Value.ToString())
                editora = dgvLivros.SelectedRows(0).Cells(2).Value.ToString()
                edicao = dgvLivros.SelectedRows(0).Cells(3).Value.ToString()
                anoPublicacao = dgvLivros.SelectedRows(0).Cells(4).Value.ToString()
                PrecoLivro = dgvLivros.SelectedRows(0).Cells(5).Value.ToString()

                If cboAssunto.SelectedIndex < 0 Then
                    m_Assunto = New Assunto(descricao)
                Else
                    codAs = cboAssunto.Items(cboAssunto.SelectedIndex)(0)
                    descricao = cboAssunto.Text
                    m_Assunto = New Assunto(descricao, codAs)
                End If

                If cboAutor.SelectedIndex < 0 Then
                    m_Autor = New Autor(nome, codAu)
                Else

                    codAu = cboAutor.Items(cboAutor.SelectedIndex)(0)
                    nome = cboAutor.Text
                    m_Autor = New Autor(nome, codAu)
                End If



                m_Livro = New Livro(ntxtTitulo.Text, m_Autor, m_Assunto, codL) _
                With {
                        .editora = editora,
                        .edicao = edicao,
                        .AnoPublicacao = anoPublicacao,
                        .PrecoLivro = PrecoLivro
                     }

                mensagem = m_Livro.Excluir()


                MessageBox.Show(mensagem)

            Else
                MessageBox.Show("Selecione uma linha para poder excluir")
            End If

            carregarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            LimparTela()
        End Try

    End Sub

    Private Sub ntxtEdicao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ntxtEdicao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If

    End Sub

    Private Sub ntxtAnoPublicacao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ntxtEdicao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If

    End Sub

    Private Sub ntxtPreco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ntxtAnoPublicacao.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumerosComVirgula(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If

    End Sub

    Private Sub ntxtPreco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntxtPreco.TextChanged

        Utils.TextBoxMoeda(ntxtPreco)

    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click

        Try
            frmRelatorio.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LimparTela()
        ntxtTitulo.Text = ""
        cboAutor.SelectedIndex = -1
        ntxtEditora.Text = ""
        ntxtEdicao.Text = ""
        ntxtAnoPublicacao.Text = ""
        cboAssunto.SelectedIndex = -1
        ntxtPreco.Text = ""
        btnAlterar.Enabled = False

    End Sub


End Class