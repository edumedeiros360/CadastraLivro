<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroLivro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbCadstro = New System.Windows.Forms.GroupBox()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnExibirTodos = New System.Windows.Forms.Button()
        Me.btnConsultarTitulo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.dgvLivros = New System.Windows.Forms.DataGridView()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.cboAssunto = New System.Windows.Forms.ComboBox()
        Me.cboAutor = New System.Windows.Forms.ComboBox()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblAnoPublicacao = New System.Windows.Forms.Label()
        Me.lblEdicao = New System.Windows.Forms.Label()
        Me.lblEditora = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ntxtPreco = New Cadastro_De_Livros.NovoTextBox()
        Me.ntxtAnoPublicacao = New Cadastro_De_Livros.NovoTextBox()
        Me.ntxtEdicao = New Cadastro_De_Livros.NovoTextBox()
        Me.ntxtEditora = New Cadastro_De_Livros.NovoTextBox()
        Me.ntxtTitulo = New Cadastro_De_Livros.NovoTextBox()
        Me.grbCadstro.SuspendLayout()
        CType(Me.dgvLivros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCadstro
        '
        Me.grbCadstro.Controls.Add(Me.btnRelatorio)
        Me.grbCadstro.Controls.Add(Me.btnExibirTodos)
        Me.grbCadstro.Controls.Add(Me.btnConsultarTitulo)
        Me.grbCadstro.Controls.Add(Me.btnAlterar)
        Me.grbCadstro.Controls.Add(Me.dgvLivros)
        Me.grbCadstro.Controls.Add(Me.btnExcluir)
        Me.grbCadstro.Controls.Add(Me.btnIncluir)
        Me.grbCadstro.Controls.Add(Me.cboAssunto)
        Me.grbCadstro.Controls.Add(Me.cboAutor)
        Me.grbCadstro.Controls.Add(Me.ntxtPreco)
        Me.grbCadstro.Controls.Add(Me.ntxtAnoPublicacao)
        Me.grbCadstro.Controls.Add(Me.ntxtEdicao)
        Me.grbCadstro.Controls.Add(Me.ntxtEditora)
        Me.grbCadstro.Controls.Add(Me.ntxtTitulo)
        Me.grbCadstro.Controls.Add(Me.lblPreco)
        Me.grbCadstro.Controls.Add(Me.lblAssunto)
        Me.grbCadstro.Controls.Add(Me.lblAutor)
        Me.grbCadstro.Controls.Add(Me.lblAnoPublicacao)
        Me.grbCadstro.Controls.Add(Me.lblEdicao)
        Me.grbCadstro.Controls.Add(Me.lblEditora)
        Me.grbCadstro.Controls.Add(Me.lblTitulo)
        Me.grbCadstro.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grbCadstro.Location = New System.Drawing.Point(12, 12)
        Me.grbCadstro.Name = "grbCadstro"
        Me.grbCadstro.Size = New System.Drawing.Size(758, 470)
        Me.grbCadstro.TabIndex = 0
        Me.grbCadstro.TabStop = False
        Me.grbCadstro.Text = "Cadastro"
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Location = New System.Drawing.Point(640, 228)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(102, 26)
        Me.btnRelatorio.TabIndex = 28
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnExibirTodos
        '
        Me.btnExibirTodos.Location = New System.Drawing.Point(30, 228)
        Me.btnExibirTodos.Name = "btnExibirTodos"
        Me.btnExibirTodos.Size = New System.Drawing.Size(102, 26)
        Me.btnExibirTodos.TabIndex = 27
        Me.btnExibirTodos.Text = "Exibir Todos"
        Me.btnExibirTodos.UseVisualStyleBackColor = True
        '
        'btnConsultarTitulo
        '
        Me.btnConsultarTitulo.Location = New System.Drawing.Point(148, 228)
        Me.btnConsultarTitulo.Name = "btnConsultarTitulo"
        Me.btnConsultarTitulo.Size = New System.Drawing.Size(102, 26)
        Me.btnConsultarTitulo.TabIndex = 26
        Me.btnConsultarTitulo.Text = "Consultar Título"
        Me.btnConsultarTitulo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(392, 228)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(102, 26)
        Me.btnAlterar.TabIndex = 25
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'dgvLivros
        '
        Me.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLivros.Location = New System.Drawing.Point(30, 260)
        Me.dgvLivros.Name = "dgvLivros"
        Me.dgvLivros.ReadOnly = True
        Me.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLivros.Size = New System.Drawing.Size(712, 192)
        Me.dgvLivros.TabIndex = 24
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(512, 228)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(102, 26)
        Me.btnExcluir.TabIndex = 23
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(270, 228)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(102, 26)
        Me.btnIncluir.TabIndex = 22
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'cboAssunto
        '
        Me.cboAssunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssunto.FormattingEnabled = True
        Me.cboAssunto.Location = New System.Drawing.Point(131, 174)
        Me.cboAssunto.Name = "cboAssunto"
        Me.cboAssunto.Size = New System.Drawing.Size(277, 21)
        Me.cboAssunto.TabIndex = 21
        '
        'cboAutor
        '
        Me.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAutor.FormattingEnabled = True
        Me.cboAutor.Location = New System.Drawing.Point(131, 66)
        Me.cboAutor.Name = "cboAutor"
        Me.cboAutor.Size = New System.Drawing.Size(470, 21)
        Me.cboAutor.TabIndex = 20
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(27, 202)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(35, 13)
        Me.lblPreco.TabIndex = 12
        Me.lblPreco.Text = "Preço"
        '
        'lblAssunto
        '
        Me.lblAssunto.AutoSize = True
        Me.lblAssunto.Location = New System.Drawing.Point(27, 174)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(45, 13)
        Me.lblAssunto.TabIndex = 5
        Me.lblAssunto.Text = "Assunto"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(27, 66)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(32, 13)
        Me.lblAutor.TabIndex = 4
        Me.lblAutor.Text = "Autor"
        '
        'lblAnoPublicacao
        '
        Me.lblAnoPublicacao.AutoSize = True
        Me.lblAnoPublicacao.Location = New System.Drawing.Point(27, 150)
        Me.lblAnoPublicacao.Name = "lblAnoPublicacao"
        Me.lblAnoPublicacao.Size = New System.Drawing.Size(82, 13)
        Me.lblAnoPublicacao.TabIndex = 3
        Me.lblAnoPublicacao.Text = "Ano Publicação"
        '
        'lblEdicao
        '
        Me.lblEdicao.AutoSize = True
        Me.lblEdicao.Location = New System.Drawing.Point(27, 124)
        Me.lblEdicao.Name = "lblEdicao"
        Me.lblEdicao.Size = New System.Drawing.Size(40, 13)
        Me.lblEdicao.TabIndex = 2
        Me.lblEdicao.Text = "Edição"
        '
        'lblEditora
        '
        Me.lblEditora.AutoSize = True
        Me.lblEditora.Location = New System.Drawing.Point(27, 96)
        Me.lblEditora.Name = "lblEditora"
        Me.lblEditora.Size = New System.Drawing.Size(40, 13)
        Me.lblEditora.TabIndex = 1
        Me.lblEditora.Text = "Editora"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(27, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Título"
        '
        'ntxtPreco
        '
        Me.ntxtPreco.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtPreco.Location = New System.Drawing.Point(131, 202)
        Me.ntxtPreco.MaxLength = 15
        Me.ntxtPreco.Name = "ntxtPreco"
        Me.ntxtPreco.Size = New System.Drawing.Size(143, 20)
        Me.ntxtPreco.TabIndex = 19
        Me.ntxtPreco.Tipo = Nothing
        '
        'ntxtAnoPublicacao
        '
        Me.ntxtAnoPublicacao.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtAnoPublicacao.Location = New System.Drawing.Point(131, 148)
        Me.ntxtAnoPublicacao.MaxLength = 4
        Me.ntxtAnoPublicacao.Name = "ntxtAnoPublicacao"
        Me.ntxtAnoPublicacao.Size = New System.Drawing.Size(78, 20)
        Me.ntxtAnoPublicacao.TabIndex = 17
        Me.ntxtAnoPublicacao.Tipo = Nothing
        '
        'ntxtEdicao
        '
        Me.ntxtEdicao.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtEdicao.Location = New System.Drawing.Point(131, 122)
        Me.ntxtEdicao.MaxLength = 6
        Me.ntxtEdicao.Name = "ntxtEdicao"
        Me.ntxtEdicao.Size = New System.Drawing.Size(78, 20)
        Me.ntxtEdicao.TabIndex = 16
        Me.ntxtEdicao.Tipo = Nothing
        '
        'ntxtEditora
        '
        Me.ntxtEditora.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtEditora.Location = New System.Drawing.Point(131, 96)
        Me.ntxtEditora.MaxLength = 40
        Me.ntxtEditora.Name = "ntxtEditora"
        Me.ntxtEditora.Size = New System.Drawing.Size(470, 20)
        Me.ntxtEditora.TabIndex = 15
        Me.ntxtEditora.Tipo = Nothing
        '
        'ntxtTitulo
        '
        Me.ntxtTitulo.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtTitulo.Location = New System.Drawing.Point(131, 37)
        Me.ntxtTitulo.MaxLength = 40
        Me.ntxtTitulo.Name = "ntxtTitulo"
        Me.ntxtTitulo.Size = New System.Drawing.Size(470, 20)
        Me.ntxtTitulo.TabIndex = 13
        Me.ntxtTitulo.Tipo = Nothing
        '
        'frmCadastroLivro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 492)
        Me.Controls.Add(Me.grbCadstro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroLivro"
        Me.ShowInTaskbar = False
        Me.Text = "Cadastro Livro"
        Me.grbCadstro.ResumeLayout(False)
        Me.grbCadstro.PerformLayout()
        CType(Me.dgvLivros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbCadstro As GroupBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblAnoPublicacao As Label
    Friend WithEvents lblEdicao As Label
    Friend WithEvents lblEditora As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPreco As Label
    Friend WithEvents ntxtPreco As NovoTextBox
    Friend WithEvents ntxtAnoPublicacao As NovoTextBox
    Friend WithEvents ntxtEdicao As NovoTextBox
    Friend WithEvents ntxtTitulo As NovoTextBox
    Friend WithEvents ntxtEditora As NovoTextBox
    Friend WithEvents cboAssunto As ComboBox
    Friend WithEvents cboAutor As ComboBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnConsultarTitulo As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents dgvLivros As DataGridView
    Friend WithEvents btnExibirTodos As Button
    Friend WithEvents btnRelatorio As Button
End Class
