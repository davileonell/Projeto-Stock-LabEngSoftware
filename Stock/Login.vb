Imports Npgsql
Public Class Login
    Public cont As Integer = 5 ' Quantidade de tentativas para colocar a senha

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUser.Text IsNot "" And txtPassword.Text IsNot "" Then

            Try
                connection()
                cmd = New NpgsqlCommand("SELECT login,senha FROM tb_usuarios WHERE login= '" & Trim(txtUser.Text) & "' AND senha='" & Trim(txtPassword.Text) & "'", con)
                Dim dr As NpgsqlDataReader = cmd.ExecuteReader()

                If dr.HasRows Then ' Se tem linhas
                    'MessageBox.Show("TEM DADOS!")
                    strUser_ = txtUser.Text
                    Clear()
                    Me.Hide()
                    Home.Show()
                Else

                    If cont > 1 Then
                        MessageBox.Show("Credenciais incorretas!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Clear()
                        cont -= 1
                        lbTentativas.Visible = True
                        lbTentativas.Text = "Tentativas restantes: " & cont
                    Else
                        MessageBox.Show("Tentativas excedidas! Digite os últimos 3 dígitos do seu CPF!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ' EM DÚVIDA... TIRAR DE VEZ OU COLOCAR APÓS O LOGIN?


                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        Else
            MessageBox.Show("Preencha as Credenciais!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnSubmit.PerformClick()
    End Sub

    Public Sub ChecaCpf()

    End Sub

    Public Sub Clear()
        txtUser.Clear()
        txtPassword.Clear()
        txtUser.Focus()
    End Sub
End Class
