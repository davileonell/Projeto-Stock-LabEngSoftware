Imports Npgsql

Public Class frmCadastroFornecedor
    Private Sub frmCadastroFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        txtNome.Clear()
        txtID.Clear()
        mtxCNPJ.Clear()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Botoes("SELECT * FROM tb_fornecedor WHERE nm_fornecedor > '" & txtNome.Text & "' ORDER BY nm_fornecedor LIMIT 1")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Botoes("SELECT * FROM tb_fornecedor WHERE nm_fornecedor < '" & txtNome.Text & "' ORDER BY nm_fornecedor LIMIT 1")
    End Sub

    Public Sub Botoes(strSql As String)
        Connection()
        cmd = New NpgsqlCommand(strSql, con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            txtNome.Text = dr.Item("nm_fornecedor")
            mtxCNPJ.Text = dr.Item("cnpj")
            txtID.Text = dr.Item("fornecedor_id")
        Else
            MessageBox.Show("Você chegou ao limite!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtID.Text = "" Then
            MessageBox.Show("Não há nenhum registro para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Connection()
                    cmd = New NpgsqlCommand("DELETE FROM tb_fornecedor WHERE fornecedor_id =" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Fornecedor excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Você não excluiu este fornecedor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub CarregarDados()
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_fornecedor ORDER BY nm_fornecedor LIMIT 1", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nm_fornecedor")
                mtxCNPJ.Text = dr.Item("cnpj")
                txtID.Text = dr.Item("fornecedor_id")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click
        If txtNome.Text = "" Or mtxCNPJ.Text.Length < 18 Then
            MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If txtID.Text = "" Then 'INSERT
                Try
                    Connection()
                    cmd = New NpgsqlCommand("INSERT INTO tb_fornecedor (nm_fornecedor,cnpj) VALUES ('" & Trim(txtNome.Text) & "','" & Trim(mtxCNPJ.Text) & "')", con)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show("Preencha todas as informações!" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

            Else ' UPDATE
                Try
                    Connection()
                    cmd = New NpgsqlCommand("UPDATE tb_fornecedor set nm_fornecedor='" & txtNome.Text & "',cnpj='" & mtxCNPJ.Text & "' WHERE fornecedor_id=" & txtID.Text, con)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Fornecedor atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                Finally
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ofrmBuscarFornecedor As New frmBuscarFornecedor
        ofrmBuscarFornecedor.ShowDialog()

        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_fornecedor WHERE fornecedor_id=" & intIndex_, con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nm_fornecedor")
                mtxCNPJ.Text = dr.Item("cnpj")
                txtID.Text = dr.Item("fornecedor_id")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub
End Class