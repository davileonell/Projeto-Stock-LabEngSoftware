<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSolicitar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitar))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimparFiltros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCategoria = New System.Windows.Forms.CheckBox()
        Me.chkNome = New System.Windows.Forms.CheckBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.dvgProdutos = New System.Windows.Forms.DataGridView()
        Me.dvgLista = New System.Windows.Forms.DataGridView()
        Me.CodProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExcluirItem = New System.Windows.Forms.Button()
        Me.btnFinalizarSolicitacao = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSetor = New System.Windows.Forms.ComboBox()
        Me.btnCancSolicitacao = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dvgSolicitacoes = New System.Windows.Forms.DataGridView()
        Me.dvgVisualizarItems = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbPedido = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgVisualizarItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(176, 196)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 34)
        Me.btnSearch.TabIndex = 72
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Pesquisar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimparFiltros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkCategoria)
        Me.GroupBox1.Controls.Add(Me.chkNome)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.cmbCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 175)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        '
        'btnLimparFiltros
        '
        Me.btnLimparFiltros.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparFiltros.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimparFiltros.Location = New System.Drawing.Point(165, 129)
        Me.btnLimparFiltros.Name = "btnLimparFiltros"
        Me.btnLimparFiltros.Size = New System.Drawing.Size(116, 34)
        Me.btnLimparFiltros.TabIndex = 68
        Me.btnLimparFiltros.TabStop = False
        Me.btnLimparFiltros.Text = "Limpar Filtros"
        Me.btnLimparFiltros.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(174, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 30)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Filtros:"
        '
        'chkCategoria
        '
        Me.chkCategoria.AutoSize = True
        Me.chkCategoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkCategoria.ForeColor = System.Drawing.Color.Azure
        Me.chkCategoria.Location = New System.Drawing.Point(19, 96)
        Me.chkCategoria.Name = "chkCategoria"
        Me.chkCategoria.Size = New System.Drawing.Size(82, 19)
        Me.chkCategoria.TabIndex = 64
        Me.chkCategoria.TabStop = False
        Me.chkCategoria.Text = "Categoria:"
        Me.chkCategoria.UseVisualStyleBackColor = True
        '
        'chkNome
        '
        Me.chkNome.AutoSize = True
        Me.chkNome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkNome.ForeColor = System.Drawing.Color.Azure
        Me.chkNome.Location = New System.Drawing.Point(19, 58)
        Me.chkNome.Name = "chkNome"
        Me.chkNome.Size = New System.Drawing.Size(63, 19)
        Me.chkNome.TabIndex = 63
        Me.chkNome.TabStop = False
        Me.chkNome.Text = "Nome:"
        Me.chkNome.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(116, 56)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(316, 25)
        Me.txtNome.TabIndex = 59
        Me.txtNome.TabStop = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategoria.Enabled = False
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(116, 94)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(239, 25)
        Me.cmbCategoria.TabIndex = 60
        Me.cmbCategoria.TabStop = False
        '
        'dvgProdutos
        '
        Me.dvgProdutos.AllowUserToAddRows = False
        Me.dvgProdutos.AllowUserToDeleteRows = False
        Me.dvgProdutos.AllowUserToResizeRows = False
        Me.dvgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgProdutos.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgProdutos.Location = New System.Drawing.Point(11, 236)
        Me.dvgProdutos.MultiSelect = False
        Me.dvgProdutos.Name = "dvgProdutos"
        Me.dvgProdutos.RowHeadersVisible = False
        Me.dvgProdutos.RowTemplate.Height = 25
        Me.dvgProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgProdutos.ShowCellErrors = False
        Me.dvgProdutos.ShowEditingIcon = False
        Me.dvgProdutos.ShowRowErrors = False
        Me.dvgProdutos.Size = New System.Drawing.Size(445, 259)
        Me.dvgProdutos.TabIndex = 70
        Me.dvgProdutos.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dvgProdutos, "Dê duplo clique para adicionar produtos à lista!")
        '
        'dvgLista
        '
        Me.dvgLista.AllowUserToAddRows = False
        Me.dvgLista.AllowUserToDeleteRows = False
        Me.dvgLista.AllowUserToResizeRows = False
        Me.dvgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgLista.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dvgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProduto, Me.Nome, Me.Qtde})
        Me.dvgLista.Location = New System.Drawing.Point(529, 73)
        Me.dvgLista.MultiSelect = False
        Me.dvgLista.Name = "dvgLista"
        Me.dvgLista.RowHeadersVisible = False
        Me.dvgLista.RowTemplate.Height = 25
        Me.dvgLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgLista.ShowCellErrors = False
        Me.dvgLista.ShowEditingIcon = False
        Me.dvgLista.ShowRowErrors = False
        Me.dvgLista.Size = New System.Drawing.Size(363, 299)
        Me.dvgLista.TabIndex = 73
        Me.dvgLista.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dvgLista, "Dê duplo clique para remover produtos da lista!")
        '
        'CodProduto
        '
        Me.CodProduto.FillWeight = 70.0!
        Me.CodProduto.HeaderText = "CodProduto"
        Me.CodProduto.Name = "CodProduto"
        '
        'Nome
        '
        Me.Nome.FillWeight = 150.0!
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        '
        'Qtde
        '
        Me.Qtde.FillWeight = 35.0!
        Me.Qtde.HeaderText = "Qtde"
        Me.Qtde.Name = "Qtde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Azure
        Me.Label2.Location = New System.Drawing.Point(611, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 30)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Itens para solicitar:"
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Location = New System.Drawing.Point(468, 543)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirItem.TabIndex = 75
        Me.btnExcluirItem.Text = "Button1"
        Me.btnExcluirItem.UseVisualStyleBackColor = True
        '
        'btnFinalizarSolicitacao
        '
        Me.btnFinalizarSolicitacao.BackColor = System.Drawing.Color.Khaki
        Me.btnFinalizarSolicitacao.Enabled = False
        Me.btnFinalizarSolicitacao.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnFinalizarSolicitacao.FlatAppearance.BorderSize = 2
        Me.btnFinalizarSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizarSolicitacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFinalizarSolicitacao.Location = New System.Drawing.Point(749, 461)
        Me.btnFinalizarSolicitacao.Name = "btnFinalizarSolicitacao"
        Me.btnFinalizarSolicitacao.Size = New System.Drawing.Size(143, 34)
        Me.btnFinalizarSolicitacao.TabIndex = 76
        Me.btnFinalizarSolicitacao.TabStop = False
        Me.btnFinalizarSolicitacao.Text = "Finalizar"
        Me.btnFinalizarSolicitacao.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Azure
        Me.Label3.Location = New System.Drawing.Point(537, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 30)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Setor:"
        '
        'cmbSetor
        '
        Me.cmbSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSetor.FormattingEnabled = True
        Me.cmbSetor.Items.AddRange(New Object() {"Financeiro", "TI", "Balcão", "Garagem"})
        Me.cmbSetor.Location = New System.Drawing.Point(611, 390)
        Me.cmbSetor.Name = "cmbSetor"
        Me.cmbSetor.Size = New System.Drawing.Size(163, 25)
        Me.cmbSetor.TabIndex = 69
        Me.cmbSetor.TabStop = False
        '
        'btnCancSolicitacao
        '
        Me.btnCancSolicitacao.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancSolicitacao.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnCancSolicitacao.FlatAppearance.BorderSize = 2
        Me.btnCancSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancSolicitacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancSolicitacao.Location = New System.Drawing.Point(529, 461)
        Me.btnCancSolicitacao.Name = "btnCancSolicitacao"
        Me.btnCancSolicitacao.Size = New System.Drawing.Size(143, 34)
        Me.btnCancSolicitacao.TabIndex = 78
        Me.btnCancSolicitacao.TabStop = False
        Me.btnCancSolicitacao.Text = "Cancelar solicitação"
        Me.btnCancSolicitacao.UseVisualStyleBackColor = False
        '
        'dvgSolicitacoes
        '
        Me.dvgSolicitacoes.AllowUserToAddRows = False
        Me.dvgSolicitacoes.AllowUserToDeleteRows = False
        Me.dvgSolicitacoes.AllowUserToResizeRows = False
        Me.dvgSolicitacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgSolicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgSolicitacoes.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgSolicitacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgSolicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSolicitacoes.Location = New System.Drawing.Point(19, 90)
        Me.dvgSolicitacoes.MultiSelect = False
        Me.dvgSolicitacoes.Name = "dvgSolicitacoes"
        Me.dvgSolicitacoes.ReadOnly = True
        Me.dvgSolicitacoes.RowHeadersVisible = False
        Me.dvgSolicitacoes.RowTemplate.Height = 25
        Me.dvgSolicitacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgSolicitacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgSolicitacoes.ShowCellErrors = False
        Me.dvgSolicitacoes.ShowEditingIcon = False
        Me.dvgSolicitacoes.ShowRowErrors = False
        Me.dvgSolicitacoes.Size = New System.Drawing.Size(493, 201)
        Me.dvgSolicitacoes.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.dvgSolicitacoes, "Dê duplo clique para selecionar a solicitação!")
        '
        'dvgVisualizarItems
        '
        Me.dvgVisualizarItems.AllowUserToAddRows = False
        Me.dvgVisualizarItems.AllowUserToDeleteRows = False
        Me.dvgVisualizarItems.AllowUserToResizeRows = False
        Me.dvgVisualizarItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgVisualizarItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgVisualizarItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgVisualizarItems.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgVisualizarItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dvgVisualizarItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgVisualizarItems.Location = New System.Drawing.Point(560, 90)
        Me.dvgVisualizarItems.MultiSelect = False
        Me.dvgVisualizarItems.Name = "dvgVisualizarItems"
        Me.dvgVisualizarItems.ReadOnly = True
        Me.dvgVisualizarItems.RowHeadersVisible = False
        Me.dvgVisualizarItems.RowTemplate.Height = 25
        Me.dvgVisualizarItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgVisualizarItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgVisualizarItems.ShowCellErrors = False
        Me.dvgVisualizarItems.ShowEditingIcon = False
        Me.dvgVisualizarItems.ShowRowErrors = False
        Me.dvgVisualizarItems.Size = New System.Drawing.Size(363, 201)
        Me.dvgVisualizarItems.TabIndex = 88
        Me.dvgVisualizarItems.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(952, 557)
        Me.TabControl1.TabIndex = 79
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.btnExcluirItem)
        Me.TabPage1.Controls.Add(Me.btnCancSolicitacao)
        Me.TabPage1.Controls.Add(Me.dvgProdutos)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cmbSetor)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnFinalizarSolicitacao)
        Me.TabPage1.Controls.Add(Me.dvgLista)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(944, 529)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Solicitar produtos"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage2.Controls.Add(Me.lbPedido)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dvgSolicitacoes)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.dvgVisualizarItems)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(944, 529)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pedidos disponíveis para retirada"
        '
        'lbPedido
        '
        Me.lbPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPedido.AutoSize = True
        Me.lbPedido.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPedido.ForeColor = System.Drawing.Color.Azure
        Me.lbPedido.Location = New System.Drawing.Point(19, 305)
        Me.lbPedido.Name = "lbPedido"
        Me.lbPedido.Size = New System.Drawing.Size(110, 30)
        Me.lbPedido.TabIndex = 91
        Me.lbPedido.Text = "Pedido nº"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Azure
        Me.Label4.Location = New System.Drawing.Point(181, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 30)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Solicitações:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Azure
        Me.Label5.Location = New System.Drawing.Point(647, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 30)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Itens solicitados:"
        '
        'frmSolicitar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(980, 583)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSolicitar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitação de produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgVisualizarItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimparFiltros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCategoria As CheckBox
    Friend WithEvents chkNome As CheckBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents dvgProdutos As DataGridView
    Friend WithEvents dvgLista As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents CodProduto As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Qtde As DataGridViewTextBoxColumn
    Friend WithEvents btnExcluirItem As Button
    Friend WithEvents btnFinalizarSolicitacao As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSetor As ComboBox
    Friend WithEvents btnCancSolicitacao As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbPedido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dvgSolicitacoes As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents dvgVisualizarItems As DataGridView
End Class
