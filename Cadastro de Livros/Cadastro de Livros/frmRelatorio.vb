Public Class frmRelatorio
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroLivrosDataSet.VW_LIVROS_POR_AUTOR'. Você pode movê-la ou removê-la conforme necessário.
        Me.VW_LIVROS_POR_AUTORTableAdapter.Fill(Me.CadastroLivrosDataSet.VW_LIVROS_POR_AUTOR)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class