<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAutor
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
        Me.btnExibirTodos = New System.Windows.Forms.Button()
        Me.dgvAutor = New System.Windows.Forms.DataGridView()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.ntxtAutor = New Cadastro_De_Livros.NovoTextBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.grbCadstro.SuspendLayout()
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCadstro
        '
        Me.grbCadstro.Controls.Add(Me.btnExcluir)
        Me.grbCadstro.Controls.Add(Me.btnExibirTodos)
        Me.grbCadstro.Controls.Add(Me.dgvAutor)
        Me.grbCadstro.Controls.Add(Me.btnCadastrar)
        Me.grbCadstro.Controls.Add(Me.ntxtAutor)
        Me.grbCadstro.Controls.Add(Me.lblAutor)
        Me.grbCadstro.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grbCadstro.Location = New System.Drawing.Point(12, 12)
        Me.grbCadstro.Name = "grbCadstro"
        Me.grbCadstro.Size = New System.Drawing.Size(620, 265)
        Me.grbCadstro.TabIndex = 1
        Me.grbCadstro.TabStop = False
        Me.grbCadstro.Text = "Cadastro"
        '
        'btnExibirTodos
        '
        Me.btnExibirTodos.Location = New System.Drawing.Point(61, 55)
        Me.btnExibirTodos.Name = "btnExibirTodos"
        Me.btnExibirTodos.Size = New System.Drawing.Size(122, 26)
        Me.btnExibirTodos.TabIndex = 22
        Me.btnExibirTodos.Text = "Exibir Todos"
        Me.btnExibirTodos.UseVisualStyleBackColor = True
        '
        'dgvAutor
        '
        Me.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutor.Location = New System.Drawing.Point(61, 87)
        Me.dgvAutor.Name = "dgvAutor"
        Me.dgvAutor.ReadOnly = True
        Me.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAutor.Size = New System.Drawing.Size(470, 150)
        Me.dgvAutor.TabIndex = 21
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(198, 55)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(122, 26)
        Me.btnCadastrar.TabIndex = 20
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'ntxtAutor
        '
        Me.ntxtAutor.ColorFoco = System.Drawing.Color.BlueViolet
        Me.ntxtAutor.Location = New System.Drawing.Point(61, 29)
        Me.ntxtAutor.MaxLength = 40
        Me.ntxtAutor.Name = "ntxtAutor"
        Me.ntxtAutor.Size = New System.Drawing.Size(470, 20)
        Me.ntxtAutor.TabIndex = 14
        Me.ntxtAutor.Tipo = Nothing
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(10, 29)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(32, 13)
        Me.lblAutor.TabIndex = 4
        Me.lblAutor.Text = "Autor"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(337, 55)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(122, 26)
        Me.btnExcluir.TabIndex = 23
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'frmCadastroAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 286)
        Me.Controls.Add(Me.grbCadstro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroAutor"
        Me.Text = "Cadastro Autor"
        Me.grbCadstro.ResumeLayout(False)
        Me.grbCadstro.PerformLayout()
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbCadstro As GroupBox
    Friend WithEvents lblAutor As Label
    Friend WithEvents dgvAutor As DataGridView
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents ntxtAutor As NovoTextBox
    Friend WithEvents btnExibirTodos As Button
    Friend WithEvents btnExcluir As Button
End Class
