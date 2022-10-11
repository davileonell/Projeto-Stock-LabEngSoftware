Imports Npgsql
Public Class frmCadastroFuncionario

    Private Sub frmCadastroFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Botoes("SELECT * FROM tb_usuarios WHERE nome <'" & txtNome.Text & "' ORDER BY nome DESC LIMIT 1")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Botoes("SELECT * FROM tb_usuarios WHERE nome > '" & txtNome.Text & "' ORDER BY nome LIMIT 1")
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtID.Text = "" Then
            MessageBox.Show("Não há nenhum registro para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Connection()
                    cmd = New NpgsqlCommand("DELETE FROM tb_usuarios WHERE id =" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuário excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Você não excluiu este usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        If CamposVazios() = False Then
            If txtID.Text = "" Then ' INSERT
                Try
                    Connection()
                    cmd = New NpgsqlCommand("INSERT INTO tb_usuarios (nome,login,senha,grupo,cpf) VALUES ('" & Trim(txtNome.Text) &
                                                                                                       "','" & Trim(txtLogin.Text) &
                                                                                                       "','" & Trim(txtPassword.Text) &
                                                                                                       "','" & Trim(cmbGrupo.Text) &
                                                                                                       "','" & Trim(mtxCPF.Text) & "')", con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show("Preencha todas as informações!" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

            Else ' UPDATE

                Try
                    Connection()
                    cmd = New NpgsqlCommand("UPDATE tb_usuarios set nome='" & txtNome.Text &
                                                                 "',login='" & txtLogin.Text &
                                                                 "',senha='" & txtPassword.Text &
                                                                 "',grupo='" & cmbGrupo.Text &
                                                                 "',cpf='" & mtxCPF.Text & "' WHERE id=" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuário atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Public Sub Botoes(strSql As String)
        Connection()
        cmd = New NpgsqlCommand(strSql, con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            txtNome.Text = dr.Item("nome")
            txtLogin.Text = dr.Item("login")
            txtPassword.Text = dr.Item("senha")
            mtxCPF.Text = dr.Item("cpf")
            cmbGrupo.Text = dr.Item("grupo")
            txtID.Text = dr.Item("id")
        Else
            MessageBox.Show("Você chegou ao limite!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        con.Close()
        dr.Close()
    End Sub

    Public Sub CarregarDados()
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_usuarios ORDER BY nome LIMIT 1", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nome")
                txtLogin.Text = dr.Item("login")
                txtPassword.Text = dr.Item("senha")
                mtxCPF.Text = dr.Item("cpf")
                cmbGrupo.Text = dr.Item("grupo")
                txtID.Text = dr.Item("id")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub

    Public Function CamposVazios() As Boolean
        If txtNome.Text = "" Or mtxCPF.Text.Length < 14 Or txtLogin.Text = "" Or txtPassword.Text = "" Or cmbGrupo.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnViewPassword_Click(sender As Object, e As EventArgs) Handles btnViewPassword.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.PasswordChar = ""
            btnViewPassword.BackgroundImage = My.Resources.monkey_closed_mouth
        Else
            txtPassword.UseSystemPasswordChar = True
            txtPassword.PasswordChar = "•"
            btnViewPassword.BackgroundImage = My.Resources.monkey_closed_eyes
        End If
    End Sub
    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs)
        JustNumbers(sender, e)
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        BlockNumbers(sender, e)
    End Sub

    Private Sub cmbGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbGrupo.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnNext_MouseHover(sender As Object, e As EventArgs) Handles btnNext.MouseHover
        ToolTip1.SetToolTip(Me.btnNext, "Próximo")
    End Sub

    Private Sub btnBack_MouseHover(sender As Object, e As EventArgs) Handles btnBack.MouseHover
        ToolTip1.SetToolTip(Me.btnBack, "Voltar")
    End Sub

    Private Sub btnViewPassword_MouseHover(sender As Object, e As EventArgs) Handles btnViewPassword.MouseHover
        If txtPassword.UseSystemPasswordChar = True Then
            ToolTip1.SetToolTip(Me.btnViewPassword, "Ver senha")
        Else
            ToolTip1.SetToolTip(Me.btnViewPassword, "Ocultar senha")
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        txtNome.Clear()
        txtLogin.Clear()
        txtPassword.Clear()
        mtxCPF.Clear()
        cmbGrupo.Text = ""
        txtID.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ofrmBuscarUsuario As New frmBuscarUsuario
        ofrmBuscarUsuario.ShowDialog()

        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_usuarios WHERE id=" & intIndex_, con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nome")
                txtLogin.Text = dr.Item("login")
                txtPassword.Text = dr.Item("senha")
                mtxCPF.Text = dr.Item("cpf")
                cmbGrupo.Text = dr.Item("grupo")
                txtID.Text = dr.Item("id")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub
End Class