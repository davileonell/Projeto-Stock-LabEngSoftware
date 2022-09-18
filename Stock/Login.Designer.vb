<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.Location = New System.Drawing.Point(330, 39)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(103, 38)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(95, 27)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(218, 27)
        Me.txtUser.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 60)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(218, 27)
        Me.txtPassword.TabIndex = 2
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbUser.Location = New System.Drawing.Point(47, 30)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(46, 20)
        Me.lbUser.TabIndex = 3
        Me.lbUser.Text = "User:"
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPass.Location = New System.Drawing.Point(13, 64)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(80, 20)
        Me.lbPass.TabIndex = 4
        Me.lbPass.Text = "Password:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(467, 111)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnSubmit)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lbUser As Label
    Friend WithEvents lbPass As Label
End Class
