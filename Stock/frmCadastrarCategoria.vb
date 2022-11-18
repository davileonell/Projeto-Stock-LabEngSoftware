Imports Npgsql

Public Class frmCadastrarCategoria
    Private Sub frmCadastrarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmbCategoria.Text = ""
        txtID.Clear()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtID.Text = "" Then
            MessageBox.Show("Não há nenhum registro para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Connection()
                    cmd = New NpgsqlCommand("DELETE FROM tb_categorias WHERE id_categoria=" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria excluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Você não excluiu esta categoria!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub CarregarDados()
        Try
            Connection() ' Preencher Combobox
            cmd = New NpgsqlCommand("SELECT nm_categoria FROM tb_categorias ORDER BY nm_categoria", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            cmbCategoria.ValueMember = "nm_categoria"
            cmbCategoria.DataSource = dt
            cmbCategoria.Text = ""

            ' Carregar Dados
            cmd = New NpgsqlCommand("SELECT * FROM tb_categorias ORDER BY nm_categoria LIMIT 1", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                cmbCategoria.Text = dr.Item("nm_categoria")
                txtID.Text = dr.Item("id_categoria")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        If cmbCategoria.Text = "" Then
            MessageBox.Show("Preencha o campo categoria!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If txtID.Text = "" Then 'INSERT
                Try
                    Connection()
                    cmd = New NpgsqlCommand("INSERT INTO tb_categorias (nm_categoria) VALUES ('" & Trim(cmbCategoria.Text) & "')", con)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

            Else ' UPDATE
                Try
                    Connection()
                    cmd = New NpgsqlCommand("UPDATE tb_categorias set nm_categoria='" & cmbCategoria.Text & "' WHERE id_categoria=" & txtID.Text, con)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Categoria atualizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT id_categoria FROM tb_categorias WHERE nm_categoria='" & cmbCategoria.Text & "'", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtID.Text = dr.Item("id_categoria")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'con.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub cmbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cmbCategoria.TextChanged
        cmbCategoria.Text = cmbCategoria.Text.Replace("'", "´")
        SendKeys.Send("{END}")
    End Sub
End Class