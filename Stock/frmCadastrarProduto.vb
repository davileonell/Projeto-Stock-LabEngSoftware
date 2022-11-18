Imports Npgsql

Public Class frmCadastrarProduto

    Private Sub frmCadastrarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connection() 'Preencher Categorias
            cmd = New NpgsqlCommand("SELECT nm_categoria FROM tb_categorias ORDER BY nm_categoria", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            cmbCategoria.ValueMember = "nm_categoria"
            cmbCategoria.DataSource = dt
            cmbCategoria.Text = ""

            'Preencher Fornecedores
            cmd = New NpgsqlCommand("SELECT nm_fornecedor FROM tb_fornecedor ORDER BY nm_fornecedor", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            cmbFornecedor.ValueMember = "nm_fornecedor"
            cmbFornecedor.DataSource = dt
            cmbFornecedor.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        CarregarDados()
    End Sub

    Private Sub btnSaveInfo_Click(sender As Object, e As EventArgs) Handles btnSaveInfo.Click ' Contar como alteração e salvar no histórico?
        If txtNome.Text IsNot "" And cmbCategoria.Text IsNot "" Then

            Dim val As String = Trim(txtVal.Text.Replace(",", "."))

            If txtID.Text = "" Then 'INSERT

                Try
                    Connection()
                    cmd = New NpgsqlCommand("INSERT INTO tb_produtos(nm_produto,
                                                                 qt_produto,
                                                                 nm_categoria,
                                                                 marca,
                                                                 modelo,
                                                                 ds_produto,
                                                                 nm_fornecedor,
                                                                 vl_produto) VALUES('" & Trim(txtNome.Text) &
                                                                                  "'," & nudQtd.Value &
                                                                                  ",'" & cmbCategoria.Text &
                                                                                 "','" & Trim(txtMarca.Text) &
                                                                                 "','" & Trim(txtModelo.Text) &
                                                                                 "','" & Trim(txtDesc.Text) &
                                                                                 "','" & cmbFornecedor.Text &
                                                                                  "'," & val & ")", con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Produto cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

            Else 'UPDATE, bloquear para o funcionário?
                Try
                    Connection()
                    cmd = New NpgsqlCommand("UPDATE tb_produtos SET nm_produto= '" & Trim(txtNome.Text) & "',
                                                                    qt_produto= " & nudQtd.Value & ",
                                                                  nm_categoria= '" & cmbCategoria.Text & "', 
                                                                         marca= '" & Trim(txtMarca.Text) & "',
                                                                        modelo= '" & Trim(txtModelo.Text) & "',
                                                                    ds_produto= '" & Trim(txtDesc.Text) & "',
                                                                 nm_fornecedor= '" & cmbFornecedor.Text & "',
                                                                    vl_produto= " & val & " WHERE produto_id=" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Produto atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            End If

        Else
            MessageBox.Show("Preencha as informações obrigatórias!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Botoes("SELECT * FROM tb_produtos WHERE nm_produto < '" & txtNome.Text & "' ORDER BY nm_produto LIMIT 1")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Botoes("SELECT * FROM tb_produtos WHERE nm_produto > '" & txtNome.Text & "' ORDER BY nm_produto LIMIT 1")
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        txtNome.Clear()
        txtDesc.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtVal.Clear()
        cmbCategoria.Text = ""
        cmbFornecedor.Text = ""
        nudQtd.Value = 0
        txtID.Clear()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtID.Text = "" Then
            MessageBox.Show("Não há nenhum produto para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If MessageBox.Show("Tem certeza que deseja excluir este produto?", "Responda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Connection()
                    cmd = New NpgsqlCommand("DELETE FROM tb_produtos WHERE produto_id =" & txtID.Text, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("produto excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarDados()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Você não excluiu este produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ofrmBuscarProduto As New frmBuscarProduto
        ofrmBuscarProduto.ShowDialog()

        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_produtos WHERE produto_id=" & intIndex_, con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nm_produto")
                txtDesc.Text = dr.Item("ds_produto")
                txtMarca.Text = dr.Item("marca")
                txtModelo.Text = dr.Item("modelo")
                txtVal.Text = dr.Item("vl_produto")
                cmbCategoria.Text = dr.Item("nm_categoria")
                cmbFornecedor.Text = dr.Item("nm_fornecedor")
                nudQtd.Value = dr.Item("qt_produto")
                txtID.Text = dr.Item("produto_id")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub Botoes(strSql As String)
        Connection()
        cmd = New NpgsqlCommand(strSql, con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            txtNome.Text = dr.Item("nm_produto")
            txtDesc.Text = dr.Item("ds_produto")
            txtMarca.Text = dr.Item("marca")
            txtModelo.Text = dr.Item("modelo")
            txtVal.Text = dr.Item("vl_produto")
            cmbCategoria.Text = dr.Item("nm_categoria")
            cmbFornecedor.Text = dr.Item("nm_fornecedor")
            nudQtd.Value = dr.Item("qt_produto")
            txtID.Text = dr.Item("produto_id")
        Else
            MessageBox.Show("Você chegou ao limite!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        con.Close()
        dr.Close()
    End Sub

    Public Sub CarregarDados()
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT * FROM tb_produtos ORDER BY nm_produto LIMIT 1", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtNome.Text = dr.Item("nm_produto")
                txtDesc.Text = dr.Item("ds_produto")
                txtMarca.Text = dr.Item("marca")
                txtModelo.Text = dr.Item("modelo")
                txtVal.Text = dr.Item("vl_produto")
                cmbCategoria.Text = dr.Item("nm_categoria")
                cmbFornecedor.Text = dr.Item("nm_fornecedor")
                nudQtd.Value = dr.Item("qt_produto")
                txtID.Text = dr.Item("produto_id")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub cmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs)
        txtDesc.Text = CancApostofro(txtDesc)
    End Sub

    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs)
        txtMarca.Text = CancApostofro(txtMarca)
    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs)
        txtModelo.Text = CancApostofro(txtModelo)
    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        txtNome.Text = CancApostofro(txtNome)
    End Sub

    Private Sub txtVal_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))

        keyAscii = CShort(JustMoney(keyAscii))

        If keyAscii = 0 Then e.Handled = True
    End Sub

    Private Sub txtVal_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            If txtVal.TextLength > 0 Then
                Dim tamanho = txtVal.TextLength
                txtVal.Text = txtVal.Text.Substring(0, tamanho - 1)
                SendKeys.Send("{END}")
            End If
        End If
    End Sub
End Class