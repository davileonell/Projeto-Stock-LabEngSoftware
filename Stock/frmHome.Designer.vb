<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.mnsHome = New System.Windows.Forms.MenuStrip()
        Me.ConsultarProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentarEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarEditarFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarEditarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dvgSolicitacoes = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnsHome.SuspendLayout()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsHome
        '
        Me.mnsHome.BackColor = System.Drawing.Color.Navy
        Me.mnsHome.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mnsHome.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarProdutosToolStripMenuItem, Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem, Me.MovimentarEstoqueToolStripMenuItem, Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem})
        Me.mnsHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnsHome.Location = New System.Drawing.Point(0, 0)
        Me.mnsHome.Name = "mnsHome"
        Me.mnsHome.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnsHome.Size = New System.Drawing.Size(1183, 28)
        Me.mnsHome.TabIndex = 1
        Me.mnsHome.Text = "MenuStrip1"
        '
        'ConsultarProdutosToolStripMenuItem
        '
        Me.ConsultarProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.ConsultarProdutosToolStripMenuItem.Name = "ConsultarProdutosToolStripMenuItem"
        Me.ConsultarProdutosToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.ConsultarProdutosToolStripMenuItem.Text = "Consultar produtos"
        '
        'EditarInformaçõesDoProdutoF3ToolStripMenuItem
        '
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Name = "EditarInformaçõesDoProdutoF3ToolStripMenuItem"
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Text = "Editar/Cadastrar do produto"
        '
        'MovimentarEstoqueToolStripMenuItem
        '
        Me.MovimentarEstoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.MovimentarEstoqueToolStripMenuItem.Name = "MovimentarEstoqueToolStripMenuItem"
        Me.MovimentarEstoqueToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.MovimentarEstoqueToolStripMenuItem.Text = "Movimentar Estoque"
        '
        'ConsultarHistóricoDeMovimentaçãoToolStripMenuItem
        '
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.Name = "ConsultarHistóricoDeMovimentaçãoToolStripMenuItem"
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.Size = New System.Drawing.Size(282, 24)
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.Text = "Consultar histórico de movimentação"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarFuncionárioToolStripMenuItem, Me.CadastrarEditarFornecedorToolStripMenuItem, Me.CadastrarEditarCategoriaToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'CadastrarFuncionárioToolStripMenuItem
        '
        Me.CadastrarFuncionárioToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.CadastrarFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.CadastrarFuncionárioToolStripMenuItem.Name = "CadastrarFuncionárioToolStripMenuItem"
        Me.CadastrarFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.CadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar/Editar Funcionário"
        '
        'CadastrarEditarFornecedorToolStripMenuItem
        '
        Me.CadastrarEditarFornecedorToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.CadastrarEditarFornecedorToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.CadastrarEditarFornecedorToolStripMenuItem.Name = "CadastrarEditarFornecedorToolStripMenuItem"
        Me.CadastrarEditarFornecedorToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.CadastrarEditarFornecedorToolStripMenuItem.Text = "Cadastrar/Editar Fornecedor"
        '
        'CadastrarEditarCategoriaToolStripMenuItem
        '
        Me.CadastrarEditarCategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.CadastrarEditarCategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.CadastrarEditarCategoriaToolStripMenuItem.Name = "CadastrarEditarCategoriaToolStripMenuItem"
        Me.CadastrarEditarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(279, 24)
        Me.CadastrarEditarCategoriaToolStripMenuItem.Text = "Cadastrar/Editar Categoria"
        '
        'dvgSolicitacoes
        '
        Me.dvgSolicitacoes.AllowUserToAddRows = False
        Me.dvgSolicitacoes.AllowUserToDeleteRows = False
        Me.dvgSolicitacoes.AllowUserToResizeRows = False
        Me.dvgSolicitacoes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgSolicitacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgSolicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgSolicitacoes.BackgroundColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgSolicitacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgSolicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSolicitacoes.Location = New System.Drawing.Point(678, 360)
        Me.dvgSolicitacoes.MultiSelect = False
        Me.dvgSolicitacoes.Name = "dvgSolicitacoes"
        Me.dvgSolicitacoes.RowHeadersVisible = False
        Me.dvgSolicitacoes.RowTemplate.Height = 25
        Me.dvgSolicitacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgSolicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgSolicitacoes.ShowCellErrors = False
        Me.dvgSolicitacoes.ShowEditingIcon = False
        Me.dvgSolicitacoes.ShowRowErrors = False
        Me.dvgSolicitacoes.Size = New System.Drawing.Size(493, 201)
        Me.dvgSolicitacoes.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(858, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 30)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Solicitações:"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 573)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dvgSolicitacoes)
        Me.Controls.Add(Me.mnsHome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsHome
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnsHome.ResumeLayout(False)
        Me.mnsHome.PerformLayout()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsHome As MenuStrip
    Friend WithEvents ConsultarProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarInformaçõesDoProdutoF3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarHistóricoDeMovimentaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarFuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarEditarFornecedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarEditarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentarEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dvgSolicitacoes As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
