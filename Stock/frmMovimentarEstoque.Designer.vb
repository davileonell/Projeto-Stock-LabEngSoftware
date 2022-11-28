<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimentarEstoque
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dvgLista = New System.Windows.Forms.DataGridView()
        Me.btnCancSolicitacao = New System.Windows.Forms.Button()
        Me.btnDisponibilizar = New System.Windows.Forms.Button()
        Me.dvgSolicitacoes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.lbPedido = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnHistórico = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dvgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Azure
        Me.Label2.Location = New System.Drawing.Point(640, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 30)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Itens solicitados:"
        '
        'dvgLista
        '
        Me.dvgLista.AllowUserToAddRows = False
        Me.dvgLista.AllowUserToDeleteRows = False
        Me.dvgLista.AllowUserToResizeRows = False
        Me.dvgLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgLista.BackgroundColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLista.Location = New System.Drawing.Point(553, 48)
        Me.dvgLista.MultiSelect = False
        Me.dvgLista.Name = "dvgLista"
        Me.dvgLista.RowHeadersVisible = False
        Me.dvgLista.RowTemplate.Height = 25
        Me.dvgLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgLista.ShowCellErrors = False
        Me.dvgLista.ShowEditingIcon = False
        Me.dvgLista.ShowRowErrors = False
        Me.dvgLista.Size = New System.Drawing.Size(363, 201)
        Me.dvgLista.TabIndex = 75
        Me.dvgLista.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dvgLista, "Dê duplo clique em um item para remove-lo!")
        '
        'btnCancSolicitacao
        '
        Me.btnCancSolicitacao.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancSolicitacao.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnCancSolicitacao.FlatAppearance.BorderSize = 2
        Me.btnCancSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancSolicitacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancSolicitacao.Location = New System.Drawing.Point(649, 318)
        Me.btnCancSolicitacao.Name = "btnCancSolicitacao"
        Me.btnCancSolicitacao.Size = New System.Drawing.Size(168, 34)
        Me.btnCancSolicitacao.TabIndex = 82
        Me.btnCancSolicitacao.TabStop = False
        Me.btnCancSolicitacao.Text = "Cancelar solicitação"
        Me.btnCancSolicitacao.UseVisualStyleBackColor = False
        '
        'btnDisponibilizar
        '
        Me.btnDisponibilizar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnDisponibilizar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnDisponibilizar.FlatAppearance.BorderSize = 2
        Me.btnDisponibilizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisponibilizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDisponibilizar.Location = New System.Drawing.Point(553, 264)
        Me.btnDisponibilizar.Name = "btnDisponibilizar"
        Me.btnDisponibilizar.Size = New System.Drawing.Size(168, 34)
        Me.btnDisponibilizar.TabIndex = 81
        Me.btnDisponibilizar.TabStop = False
        Me.btnDisponibilizar.Text = "Disponibilizar Retirada"
        Me.btnDisponibilizar.UseVisualStyleBackColor = False
        '
        'dvgSolicitacoes
        '
        Me.dvgSolicitacoes.AllowUserToAddRows = False
        Me.dvgSolicitacoes.AllowUserToDeleteRows = False
        Me.dvgSolicitacoes.AllowUserToResizeRows = False
        Me.dvgSolicitacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgSolicitacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgSolicitacoes.BackgroundColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgSolicitacoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dvgSolicitacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSolicitacoes.Location = New System.Drawing.Point(12, 48)
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
        Me.dvgSolicitacoes.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.dvgSolicitacoes, "Dê duplo clique para selecionar a solicitação!")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(174, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 30)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Solicitações:"
        '
        'Timer1
        '
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExcluir.Location = New System.Drawing.Point(418, 411)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(122, 34)
        Me.btnExcluir.TabIndex = 85
        Me.btnExcluir.TabStop = False
        Me.btnExcluir.Text = "excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'lbPedido
        '
        Me.lbPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPedido.AutoSize = True
        Me.lbPedido.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPedido.ForeColor = System.Drawing.Color.Azure
        Me.lbPedido.Location = New System.Drawing.Point(12, 263)
        Me.lbPedido.Name = "lbPedido"
        Me.lbPedido.Size = New System.Drawing.Size(110, 30)
        Me.lbPedido.TabIndex = 86
        Me.lbPedido.Text = "Pedido nº"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.Khaki
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnFinalizar.FlatAppearance.BorderSize = 2
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFinalizar.Location = New System.Drawing.Point(748, 264)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(168, 34)
        Me.btnFinalizar.TabIndex = 87
        Me.btnFinalizar.TabStop = False
        Me.btnFinalizar.Text = "Finalizar solicitação"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnHistórico
        '
        Me.btnHistórico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHistórico.Location = New System.Drawing.Point(12, 309)
        Me.btnHistórico.Name = "btnHistórico"
        Me.btnHistórico.Size = New System.Drawing.Size(145, 43)
        Me.btnHistórico.TabIndex = 88
        Me.btnHistórico.TabStop = False
        Me.btnHistórico.Text = "Consultar histórico de Solicitações"
        Me.btnHistórico.UseVisualStyleBackColor = True
        '
        'frmMovimentarEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(928, 364)
        Me.Controls.Add(Me.btnHistórico)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.lbPedido)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvgSolicitacoes)
        Me.Controls.Add(Me.btnCancSolicitacao)
        Me.Controls.Add(Me.btnDisponibilizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dvgLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimentarEstoque"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentar estoque"
        CType(Me.dvgLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgSolicitacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dvgLista As DataGridView
    Friend WithEvents btnCancSolicitacao As Button
    Friend WithEvents btnDisponibilizar As Button
    Friend WithEvents dvgSolicitacoes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExcluir As Button
    Friend WithEvents lbPedido As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnHistórico As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
