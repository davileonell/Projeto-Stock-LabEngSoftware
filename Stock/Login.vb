Imports Npgsql
Public Class Login
    Public cont As Integer = 5 ' Quantidade de tentativas para colocar a senha

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUser.Text IsNot "" And txtPassword.Text IsNot "" Then

            Try
                connection()
                cmd = New NpgsqlCommand("SELECT login,senha,cpf FROM tb_usuarios WHERE login= '" & Trim(txtUser.Text) & "' AND senha='" & Trim(txtPassword.Text) & "'", con)
                Dim dr As NpgsqlDataReader = cmd.ExecuteReader()

                If dr.HasRows Then ' Se tem linhas
                    dr.Read()
                    strUser_ = txtUser.Text
                    strcpf_ = dr.Item("cpf") ' Para verificação após o login

                    Clear()
                    Me.Hide()
                    frmHome.Show()
                Else
                    MessageBox.Show("Credenciais incorretas!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            con.Close()

        Else
            MessageBox.Show("Preencha as Credenciais!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnSubmit.PerformClick()
    End Sub

    Public Sub Clear()
        txtUser.Clear()
        txtPassword.Clear()
        txtUser.Focus()
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then txtPassword.Focus()
    End Sub
End Class
