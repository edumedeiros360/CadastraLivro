Imports System.Windows.Forms

Public Class mdiPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles subCadastrar.Click, sbtnCadastarLivro.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        frmCadastroLivro.MdiParent = Me

        m_ChildFormNumber += 1
        frmCadastroLivro.Text = "Cadastro Livro"
        frmCadastroLivro.Show()

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Adicione aqui código para abrir o arquivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Adicionar código aqui para salvar em arquivo o conteúdo atual do formulário.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData para obter informações da Área de Transferência.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Feche todos os formulários filhos do pai.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub sbntCadastarAutor_Click(sender As Object, e As EventArgs) Handles sbntCadastarAutor.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        frmCadastroAutor.MdiParent = Me

        m_ChildFormNumber += 1
        frmCadastroAutor.Text = "Cadastro Autor "
        frmCadastroAutor.Show()
    End Sub

    Private Sub sbtnAssunto_Click(sender As Object, e As EventArgs) Handles sbtnAssunto.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        frmCadastroAssunto.MdiParent = Me

        m_ChildFormNumber += 1
        frmCadastroAssunto.Text = "Cadastro Assunto "
        frmCadastroAssunto.Show()
    End Sub

    Private Sub sbtnRelatorio_Click(sender As Object, e As EventArgs) Handles sbtnRelatorio.Click
        Try
            frmRelatorio.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
