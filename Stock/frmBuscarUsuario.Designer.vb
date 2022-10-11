<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarUsuario
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
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.dvgUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dvgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(69, 18)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(248, 23)
        Me.txtNome.TabIndex = 1
        '
        'dvgUsuarios
        '
        Me.dvgUsuarios.AllowUserToAddRows = False
        Me.dvgUsuarios.AllowUserToDeleteRows = False
        Me.dvgUsuarios.AllowUserToResizeRows = False
        Me.dvgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dvgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dvgUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgUsuarios.Location = New System.Drawing.Point(12, 53)
        Me.dvgUsuarios.MultiSelect = False
        Me.dvgUsuarios.Name = "dvgUsuarios"
        Me.dvgUsuarios.RowTemplate.Height = 25
        Me.dvgUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgUsuarios.ShowCellErrors = False
        Me.dvgUsuarios.ShowEditingIcon = False
        Me.dvgUsuarios.ShowRowErrors = False
        Me.dvgUsuarios.Size = New System.Drawing.Size(399, 267)
        Me.dvgUsuarios.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(208, 387)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(33, 23)
        Me.txtID.TabIndex = 9
        Me.txtID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nome:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(323, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(423, 333)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dvgUsuarios)
        Me.Controls.Add(Me.txtNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarUsuario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar usuário"
        CType(Me.dvgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dvgUsuarios As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
End Class
