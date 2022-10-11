<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroFuncionario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnViewPassword = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSaveInfo = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.mtxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(358, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(340, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grupo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(10, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Senha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Login:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(67, 80)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(260, 23)
        Me.txtNome.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(67, 115)
        Me.txtLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLogin.MaxLength = 30
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(260, 23)
        Me.txtLogin.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(67, 148)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(260, 23)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cmbGrupo
        '
        Me.cmbGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Items.AddRange(New Object() {"ADM", "FUNC"})
        Me.cmbGrupo.Location = New System.Drawing.Point(399, 111)
        Me.cmbGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(95, 23)
        Me.cmbGrupo.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(244, 227)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.MaxLength = 30
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(57, 23)
        Me.txtID.TabIndex = 10
        Me.txtID.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.BackgroundImage = Global.Stock.My.Resources.Resources.left
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(195, 9)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 45)
        Me.btnBack.TabIndex = 14
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Control
        Me.btnNext.BackgroundImage = Global.Stock.My.Resources.Resources.right
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(263, 9)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 45)
        Me.btnNext.TabIndex = 15
        Me.btnNext.TabStop = False
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnViewPassword
        '
        Me.btnViewPassword.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewPassword.BackgroundImage = Global.Stock.My.Resources.Resources.monkey_closed_eyes
        Me.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPassword.Location = New System.Drawing.Point(332, 142)
        Me.btnViewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewPassword.Name = "btnViewPassword"
        Me.btnViewPassword.Size = New System.Drawing.Size(52, 34)
        Me.btnViewPassword.TabIndex = 16
        Me.btnViewPassword.TabStop = False
        Me.btnViewPassword.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddUser.BackgroundImage = Global.Stock.My.Resources.Resources.adduser
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddUser.Location = New System.Drawing.Point(127, 9)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(63, 45)
        Me.btnAddUser.TabIndex = 18
        Me.btnAddUser.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAddUser, "Adicionar usuário")
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcluir.BackgroundImage = Global.Stock.My.Resources.Resources.excluir
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.Location = New System.Drawing.Point(332, 9)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 45)
        Me.btnExcluir.TabIndex = 17
        Me.btnExcluir.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir usuário")
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSaveInfo
        '
        Me.btnSaveInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveInfo.BackgroundImage = Global.Stock.My.Resources.Resources.disket
        Me.btnSaveInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveInfo.Location = New System.Drawing.Point(430, 136)
        Me.btnSaveInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveInfo.Name = "btnSaveInfo"
        Me.btnSaveInfo.Size = New System.Drawing.Size(63, 45)
        Me.btnSaveInfo.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnSaveInfo, "Cadastrar/Atualizar usuário")
        Me.btnSaveInfo.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackgroundImage = Global.Stock.My.Resources.Resources.lupa2
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(486, 9)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 45)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Adicionar usuário")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'mtxCPF
        '
        Me.mtxCPF.Location = New System.Drawing.Point(399, 81)
        Me.mtxCPF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxCPF.Mask = "000,000,000-00"
        Me.mtxCPF.Name = "mtxCPF"
        Me.mtxCPF.Size = New System.Drawing.Size(118, 23)
        Me.mtxCPF.TabIndex = 2
        '
        'frmCadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(560, 184)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.mtxCPF)
        Me.Controls.Add(Me.btnSaveInfo)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnViewPassword)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroFuncionario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar/Editar Informações do Funcionário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnViewPassword As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnSaveInfo As Button
    Friend WithEvents mtxCPF As MaskedTextBox
    Friend WithEvents btnSearch As Button
End Class
