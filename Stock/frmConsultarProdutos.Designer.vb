<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultarProdutos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dvgProdutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimparFiltros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFornecedor = New System.Windows.Forms.CheckBox()
        Me.chkMarca = New System.Windows.Forms.CheckBox()
        Me.chkCategoria = New System.Windows.Forms.CheckBox()
        Me.chkNome = New System.Windows.Forms.CheckBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.cmbFornecedor = New System.Windows.Forms.ComboBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dvgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgProdutos
        '
        Me.dvgProdutos.AllowUserToAddRows = False
        Me.dvgProdutos.AllowUserToDeleteRows = False
        Me.dvgProdutos.AllowUserToResizeRows = False
        Me.dvgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgProdutos.BackgroundColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgProdutos.Location = New System.Drawing.Point(468, 12)
        Me.dvgProdutos.MultiSelect = False
        Me.dvgProdutos.Name = "dvgProdutos"
        Me.dvgProdutos.ReadOnly = True
        Me.dvgProdutos.RowHeadersVisible = False
        Me.dvgProdutos.RowTemplate.Height = 25
        Me.dvgProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgProdutos.ShowCellErrors = False
        Me.dvgProdutos.ShowEditingIcon = False
        Me.dvgProdutos.ShowRowErrors = False
        Me.dvgProdutos.Size = New System.Drawing.Size(981, 470)
        Me.dvgProdutos.TabIndex = 9
        Me.dvgProdutos.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimparFiltros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkFornecedor)
        Me.GroupBox1.Controls.Add(Me.chkMarca)
        Me.GroupBox1.Controls.Add(Me.chkCategoria)
        Me.GroupBox1.Controls.Add(Me.chkNome)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.cmbCategoria)
        Me.GroupBox1.Controls.Add(Me.cmbFornecedor)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 267)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnLimparFiltros
        '
        Me.btnLimparFiltros.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimparFiltros.Location = New System.Drawing.Point(165, 221)
        Me.btnLimparFiltros.Name = "btnLimparFiltros"
        Me.btnLimparFiltros.Size = New System.Drawing.Size(116, 34)
        Me.btnLimparFiltros.TabIndex = 68
        Me.btnLimparFiltros.TabStop = False
        Me.btnLimparFiltros.Text = "Limpar Filtros"
        Me.btnLimparFiltros.UseVisualStyleBackColor = True
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
        'chkFornecedor
        '
        Me.chkFornecedor.AutoSize = True
        Me.chkFornecedor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkFornecedor.ForeColor = System.Drawing.Color.Azure
        Me.chkFornecedor.Location = New System.Drawing.Point(19, 149)
        Me.chkFornecedor.Name = "chkFornecedor"
        Me.chkFornecedor.Size = New System.Drawing.Size(93, 19)
        Me.chkFornecedor.TabIndex = 66
        Me.chkFornecedor.TabStop = False
        Me.chkFornecedor.Text = "Fornecedor:"
        Me.chkFornecedor.UseVisualStyleBackColor = True
        '
        'chkMarca
        '
        Me.chkMarca.AutoSize = True
        Me.chkMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkMarca.ForeColor = System.Drawing.Color.Azure
        Me.chkMarca.Location = New System.Drawing.Point(19, 184)
        Me.chkMarca.Name = "chkMarca"
        Me.chkMarca.Size = New System.Drawing.Size(63, 19)
        Me.chkMarca.TabIndex = 65
        Me.chkMarca.TabStop = False
        Me.chkMarca.Text = "Marca:"
        Me.chkMarca.UseVisualStyleBackColor = True
        '
        'chkCategoria
        '
        Me.chkCategoria.AutoSize = True
        Me.chkCategoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkCategoria.ForeColor = System.Drawing.Color.Azure
        Me.chkCategoria.Location = New System.Drawing.Point(19, 114)
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
        Me.chkNome.Location = New System.Drawing.Point(19, 76)
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
        Me.txtNome.Location = New System.Drawing.Point(116, 74)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(316, 23)
        Me.txtNome.TabIndex = 59
        Me.txtNome.TabStop = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Enabled = False
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(116, 112)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(239, 23)
        Me.cmbCategoria.TabIndex = 60
        Me.cmbCategoria.TabStop = False
        '
        'cmbFornecedor
        '
        Me.cmbFornecedor.Enabled = False
        Me.cmbFornecedor.FormattingEnabled = True
        Me.cmbFornecedor.Location = New System.Drawing.Point(116, 147)
        Me.cmbFornecedor.Name = "cmbFornecedor"
        Me.cmbFornecedor.Size = New System.Drawing.Size(316, 23)
        Me.cmbFornecedor.TabIndex = 61
        Me.cmbFornecedor.TabStop = False
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Location = New System.Drawing.Point(116, 182)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMarca.MaxLength = 30
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(239, 23)
        Me.txtMarca.TabIndex = 62
        Me.txtMarca.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(177, 376)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 34)
        Me.btnSearch.TabIndex = 69
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Pesquisar"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmConsultarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1461, 494)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dvgProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultarProdutos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Produtos"
        CType(Me.dvgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgProdutos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimparFiltros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkFornecedor As CheckBox
    Friend WithEvents chkMarca As CheckBox
    Friend WithEvents chkCategoria As CheckBox
    Friend WithEvents chkNome As CheckBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbFornecedor As ComboBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnSearch As Button
End Class
