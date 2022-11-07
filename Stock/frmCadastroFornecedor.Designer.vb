<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFornecedor))
        Me.mtxCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSaveInfo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'mtxCNPJ
        '
        Me.mtxCNPJ.Location = New System.Drawing.Point(507, 81)
        Me.mtxCNPJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxCNPJ.Mask = "00,000,000/0000-00"
        Me.mtxCNPJ.Name = "mtxCNPJ"
        Me.mtxCNPJ.Size = New System.Drawing.Size(118, 23)
        Me.mtxCNPJ.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 81)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 60
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(379, 23)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(458, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CNPJ:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(136, 196)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.MaxLength = 3432
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 23)
        Me.txtID.TabIndex = 7
        Me.txtID.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackgroundImage = Global.Stock.My.Resources.Resources.lupa2
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(536, 11)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 45)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Buscar fornecedor")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddUser.BackgroundImage = Global.Stock.My.Resources.Resources.adduser
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddUser.Location = New System.Drawing.Point(150, 11)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(63, 45)
        Me.btnAddUser.TabIndex = 23
        Me.btnAddUser.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAddUser, "Novo fornecedor")
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcluir.BackgroundImage = Global.Stock.My.Resources.Resources.excluir
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.Location = New System.Drawing.Point(355, 11)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 45)
        Me.btnExcluir.TabIndex = 22
        Me.btnExcluir.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluír")
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Control
        Me.btnNext.BackgroundImage = Global.Stock.My.Resources.Resources.right
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(286, 11)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 45)
        Me.btnNext.TabIndex = 21
        Me.btnNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnNext, "Próximo")
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.BackgroundImage = Global.Stock.My.Resources.Resources.left
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(218, 11)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 45)
        Me.btnBack.TabIndex = 20
        Me.btnBack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnBack, "Voltar")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSaveInfo
        '
        Me.btnSaveInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveInfo.BackgroundImage = Global.Stock.My.Resources.Resources.disket
        Me.btnSaveInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveInfo.Location = New System.Drawing.Point(467, 11)
        Me.btnSaveInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveInfo.Name = "btnSaveInfo"
        Me.btnSaveInfo.Size = New System.Drawing.Size(63, 45)
        Me.btnSaveInfo.TabIndex = 25
        Me.btnSaveInfo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSaveInfo, "Salvar")
        Me.btnSaveInfo.UseVisualStyleBackColor = False
        '
        'frmCadastroFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 118)
        Me.Controls.Add(Me.btnSaveInfo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.mtxCNPJ)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroFornecedor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar/Editar informações do(s) fornecedor(es)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxCNPJ As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSaveInfo As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
