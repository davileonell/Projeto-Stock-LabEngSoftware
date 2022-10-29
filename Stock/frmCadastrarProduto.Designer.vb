<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarProduto))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSaveInfo = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudQtd = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.cmbFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.nudQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(407, 553)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(69, 23)
        Me.txtID.TabIndex = 0
        '
        'btnSaveInfo
        '
        Me.btnSaveInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveInfo.BackgroundImage = Global.Stock.My.Resources.Resources.disket
        Me.btnSaveInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveInfo.Location = New System.Drawing.Point(71, 11)
        Me.btnSaveInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveInfo.Name = "btnSaveInfo"
        Me.btnSaveInfo.Size = New System.Drawing.Size(63, 45)
        Me.btnSaveInfo.TabIndex = 30
        Me.btnSaveInfo.TabStop = False
        Me.btnSaveInfo.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackgroundImage = Global.Stock.My.Resources.Resources.lupa2
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(437, 11)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 45)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.TabStop = False
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcluir.BackgroundImage = Global.Stock.My.Resources.Resources.excluir
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.Location = New System.Drawing.Point(357, 11)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 45)
        Me.btnExcluir.TabIndex = 28
        Me.btnExcluir.TabStop = False
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Control
        Me.btnNext.BackgroundImage = Global.Stock.My.Resources.Resources.right
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(288, 11)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 45)
        Me.btnNext.TabIndex = 27
        Me.btnNext.TabStop = False
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.BackgroundImage = Global.Stock.My.Resources.Resources.left
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(220, 11)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 45)
        Me.btnBack.TabIndex = 26
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddProduct.BackgroundImage = CType(resources.GetObject("btnAddProduct.BackgroundImage"), System.Drawing.Image)
        Me.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddProduct.Location = New System.Drawing.Point(151, 11)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(63, 45)
        Me.btnAddProduct.TabIndex = 31
        Me.btnAddProduct.TabStop = False
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(54, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(112, 110)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(316, 23)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Azure
        Me.Label2.Location = New System.Drawing.Point(247, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Qtd:"
        '
        'nudQtd
        '
        Me.nudQtd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudQtd.Location = New System.Drawing.Point(289, 149)
        Me.nudQtd.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtd.Name = "nudQtd"
        Me.nudQtd.Size = New System.Drawing.Size(63, 23)
        Me.nudQtd.TabIndex = 2
        Me.nudQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Azure
        Me.Label3.Location = New System.Drawing.Point(30, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Categoria:"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(112, 148)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 23)
        Me.cmbCategoria.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Azure
        Me.Label4.Location = New System.Drawing.Point(54, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Marca:"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(112, 263)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMarca.MaxLength = 30
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(316, 23)
        Me.txtMarca.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Azure
        Me.Label5.Location = New System.Drawing.Point(44, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(112, 185)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModelo.MaxLength = 30
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(316, 23)
        Me.txtModelo.TabIndex = 6
        '
        'cmbFornecedor
        '
        Me.cmbFornecedor.FormattingEnabled = True
        Me.cmbFornecedor.Location = New System.Drawing.Point(112, 224)
        Me.cmbFornecedor.Name = "cmbFornecedor"
        Me.cmbFornecedor.Size = New System.Drawing.Size(316, 23)
        Me.cmbFornecedor.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Azure
        Me.Label6.Location = New System.Drawing.Point(16, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Fornecedor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Azure
        Me.Label7.Location = New System.Drawing.Point(363, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Valor unid:"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(449, 149)
        Me.txtVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVal.MaxLength = 30
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(107, 23)
        Me.txtVal.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Azure
        Me.Label8.Location = New System.Drawing.Point(29, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Descrição:"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(112, 304)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.MaxLength = 30
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(228, 145)
        Me.txtDesc.TabIndex = 8
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(445, 358)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(111, 91)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 49
        Me.picLogo.TabStop = False
        '
        'frmCadastrarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(570, 463)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.cmbFornecedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudQtd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnSaveInfo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarProduto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar/Editar Produtos"
        CType(Me.nudQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSaveInfo As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudQtd As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents cmbFornecedor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents picLogo As PictureBox
End Class
