<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAssunto
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
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnExibirTodos = New System.Windows.Forms.Button()
        Me.dgvAssunto = New System.Windows.Forms.DataGridView()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.ntxtAssunto = New Cadastro_De_Livros.NovoTextBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.grbCadstro.SuspendLayout()
        CType(Me.dgvAssunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCadstro
        '
        Me.grbCadstro.Controls.Add(Me.btnExcluir)
        Me.grbCadstro.Controls.Add(Me.btnExibirTodos)
        Me.grbCadstro.Controls.Add(Me.dgvAssunto)
        Me.grbCadstro.Controls.Add(Me.btnCadastrar)
        Me.grbCadstro.Controls.Add(Me.ntxtAssunto)
        Me.grbCadstro.Controls.Add(Me.lblAssunto)
        Me.grbCadstro.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grbCadstro.Location = New System.Drawing.Point(12, 12)
        Me.grbCadstro.Name = "grbCadstro"
        Me.grbCadstro.Size = New System.Drawing.Size(620, 265)
        Me.grbCadstro.TabIndex = 2
        Me.grbCadstro.TabStop = False
        Me.grbCadstro.Text = "Cadastro"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(357, 67)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(122, 26)
        Me.btnExcluir.TabIndex = 19
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnExibirTodos
        '
        Me.btnExibirTodos.Location = New System.Drawing.Point(83, 67)
        Me.btnExibirTodos.Name = "btnExibirTodos"
        Me.btnExibirTodos.Size = New System.Drawing.Size(122, 26)
        Me.btnExibirTodos.TabIndex = 18
        Me.btnExibirTodos.Text = "Exibir Todos"
        Me.btnExibirTodos.UseVisualStyleBackColor = True
        '
        'dgvAssunto
        '
        Me.dgvAssunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssunto.Location = New System.Drawing.Point(83, 99)
        Me.dgvAssunto.MultiSelect = False
        Me.dgvAssunto.Name = "dgvAssunto"
        Me.dgvAssunto.ReadOnly = True
        Me.dgvAssunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssunto.Size = New System.Drawing.Size(396, 150)
        Me.dgvAssunto.TabIndex = 17
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(220, 67)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(122, 26)
        Me.btnCadastrar.TabIndex = 16
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'ntxtAssunto
        '
        Me.ntxtAssunto.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtAssunto.Location = New System.Drawing.Point(83, 41)
        Me.ntxtAssunto.MaxLength = 40
        Me.ntxtAssunto.Name = "ntxtAssunto"
        Me.ntxtAssunto.Size = New System.Drawing.Size(396, 20)
        Me.ntxtAssunto.TabIndex = 15
        Me.ntxtAssunto.Tipo = Nothing
        '
        'lblAssunto
        '
        Me.lblAssunto.AutoSize = True
        Me.lblAssunto.Location = New System.Drawing.Point(27, 44)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(45, 13)
        Me.lblAssunto.TabIndex = 1
        Me.lblAssunto.Text = "Assunto"
        '
        'frmCadastroAssunto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 284)
        Me.Controls.Add(Me.grbCadstro)
        Me.Name = "frmCadastroAssunto"
        Me.Text = "Cadastro Assunto"
        Me.grbCadstro.ResumeLayout(False)
        Me.grbCadstro.PerformLayout()
        CType(Me.dgvAssunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbCadstro As GroupBox
    Friend WithEvents ntxtAssunto As NovoTextBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents dgvAssunto As DataGridView
    Friend WithEvents btnExibirTodos As Button
    Friend WithEvents btnExcluir As Button
End Class
