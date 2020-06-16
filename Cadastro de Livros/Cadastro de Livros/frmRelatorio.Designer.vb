<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelatorio
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CadastroLivrosDataSet = New Cadastro_De_Livros.CadastroLivrosDataSet()
        Me.VW_LIVROS_POR_AUTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VW_LIVROS_POR_AUTORTableAdapter = New Cadastro_De_Livros.CadastroLivrosDataSetTableAdapters.VW_LIVROS_POR_AUTORTableAdapter()
        CType(Me.CadastroLivrosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VW_LIVROS_POR_AUTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VW_LIVROS_POR_AUTORBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cadastro_De_Livros.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'CadastroLivrosDataSet
        '
        Me.CadastroLivrosDataSet.DataSetName = "CadastroLivrosDataSet"
        Me.CadastroLivrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VW_LIVROS_POR_AUTORBindingSource
        '
        Me.VW_LIVROS_POR_AUTORBindingSource.DataMember = "VW_LIVROS_POR_AUTOR"
        Me.VW_LIVROS_POR_AUTORBindingSource.DataSource = Me.CadastroLivrosDataSet
        '
        'VW_LIVROS_POR_AUTORTableAdapter
        '
        Me.VW_LIVROS_POR_AUTORTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CadastroLivrosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VW_LIVROS_POR_AUTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VW_LIVROS_POR_AUTORBindingSource As BindingSource
    Friend WithEvents CadastroLivrosDataSet As CadastroLivrosDataSet
    Friend WithEvents VW_LIVROS_POR_AUTORTableAdapter As CadastroLivrosDataSetTableAdapters.VW_LIVROS_POR_AUTORTableAdapter
End Class
