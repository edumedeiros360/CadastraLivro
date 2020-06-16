<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.subCadastrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.subRelatorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.sbtnCadastarLivro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sbntCadastarAutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.sbtnAssunto = New System.Windows.Forms.ToolStripButton()
        Me.sbtnRelatorio = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Menu.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(866, 24)
        Me.Menu.TabIndex = 5
        Me.Menu.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subCadastrar, Me.ToolStripSeparator4, Me.subRelatorio, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(61, 20)
        Me.FileMenu.Text = "&Arquivo"
        '
        'subCadastrar
        '
        Me.subCadastrar.Image = CType(resources.GetObject("subCadastrar.Image"), System.Drawing.Image)
        Me.subCadastrar.ImageTransparentColor = System.Drawing.Color.Black
        Me.subCadastrar.Name = "subCadastrar"
        Me.subCadastrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.subCadastrar.Size = New System.Drawing.Size(167, 22)
        Me.subCadastrar.Text = "Cadastrar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(164, 6)
        '
        'subRelatorio
        '
        Me.subRelatorio.Image = CType(resources.GetObject("subRelatorio.Image"), System.Drawing.Image)
        Me.subRelatorio.ImageTransparentColor = System.Drawing.Color.Black
        Me.subRelatorio.Name = "subRelatorio"
        Me.subRelatorio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.subRelatorio.Size = New System.Drawing.Size(167, 22)
        Me.subRelatorio.Text = "Relatório"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitToolStripMenuItem.Text = "Sai&r"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbtnCadastarLivro, Me.ToolStripSeparator1, Me.sbntCadastarAutor, Me.ToolStripSeparator2, Me.sbtnAssunto, Me.sbtnRelatorio})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(866, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'sbtnCadastarLivro
        '
        Me.sbtnCadastarLivro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sbtnCadastarLivro.Image = CType(resources.GetObject("sbtnCadastarLivro.Image"), System.Drawing.Image)
        Me.sbtnCadastarLivro.ImageTransparentColor = System.Drawing.Color.Black
        Me.sbtnCadastarLivro.Name = "sbtnCadastarLivro"
        Me.sbtnCadastarLivro.Size = New System.Drawing.Size(23, 22)
        Me.sbtnCadastarLivro.Text = "Cadastrar Livro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'sbntCadastarAutor
        '
        Me.sbntCadastarAutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sbntCadastarAutor.Image = CType(resources.GetObject("sbntCadastarAutor.Image"), System.Drawing.Image)
        Me.sbntCadastarAutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbntCadastarAutor.Name = "sbntCadastarAutor"
        Me.sbntCadastarAutor.Size = New System.Drawing.Size(23, 22)
        Me.sbntCadastarAutor.Text = "Cadastrar Autor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'sbtnAssunto
        '
        Me.sbtnAssunto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sbtnAssunto.Image = CType(resources.GetObject("sbtnAssunto.Image"), System.Drawing.Image)
        Me.sbtnAssunto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbtnAssunto.Name = "sbtnAssunto"
        Me.sbtnAssunto.Size = New System.Drawing.Size(23, 22)
        Me.sbtnAssunto.Text = "Cadastrar Assunto"
        '
        'sbtnRelatorio
        '
        Me.sbtnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sbtnRelatorio.Image = CType(resources.GetObject("sbtnRelatorio.Image"), System.Drawing.Image)
        Me.sbtnRelatorio.ImageTransparentColor = System.Drawing.Color.Black
        Me.sbtnRelatorio.Name = "sbtnRelatorio"
        Me.sbtnRelatorio.Size = New System.Drawing.Size(23, 22)
        Me.sbtnRelatorio.Text = "Relatório"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(866, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 612)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu
        Me.Name = "mdiPrincipal"
        Me.Text = "Cadastrar Livros"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents sbtnRelatorio As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbtnCadastarLivro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents subRelatorio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subCadastrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents sbntCadastarAutor As ToolStripButton
    Friend WithEvents sbtnAssunto As ToolStripButton
End Class
