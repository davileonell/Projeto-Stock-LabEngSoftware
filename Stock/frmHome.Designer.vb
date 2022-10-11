<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.mnsHome = New System.Windows.Forms.MenuStrip()
        Me.ConsultarProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarProdutoF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsHome
        '
        Me.mnsHome.BackColor = System.Drawing.Color.Navy
        Me.mnsHome.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mnsHome.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnsHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarProdutosToolStripMenuItem, Me.SolicitarProdutoF3ToolStripMenuItem, Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem, Me.ConsultarHistóricoDeMovimentaçãoToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem})
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
        'SolicitarProdutoF3ToolStripMenuItem
        '
        Me.SolicitarProdutoF3ToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.SolicitarProdutoF3ToolStripMenuItem.Name = "SolicitarProdutoF3ToolStripMenuItem"
        Me.SolicitarProdutoF3ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.SolicitarProdutoF3ToolStripMenuItem.Text = "Solicitar Produto"
        '
        'EditarInformaçõesDoProdutoF3ToolStripMenuItem
        '
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.ForeColor = System.Drawing.Color.Azure
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Name = "EditarInformaçõesDoProdutoF3ToolStripMenuItem"
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Size = New System.Drawing.Size(236, 24)
        Me.EditarInformaçõesDoProdutoF3ToolStripMenuItem.Text = "Editar informações do produto"
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
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarFuncionárioToolStripMenuItem})
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
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 389)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsHome As MenuStrip
    Friend WithEvents ConsultarProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarProdutoF3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarInformaçõesDoProdutoF3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarHistóricoDeMovimentaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarFuncionárioToolStripMenuItem As ToolStripMenuItem
End Class
