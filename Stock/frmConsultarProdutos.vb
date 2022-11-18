Imports Npgsql

Public Class frmConsultarProdutos

    Private Sub frmConsultarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnLimparFiltros_Click(sender As Object, e As EventArgs) Handles btnLimparFiltros.Click
        chkCategoria.Checked = False
        chkFornecedor.Checked = False
        chkMarca.Checked = False
        chkNome.Checked = False

        txtMarca.Clear()
        txtNome.Clear()
        cmbCategoria.Text = ""
        cmbFornecedor.Text = ""

        dvgProdutos.Columns.Clear()
    End Sub

    Private Sub chkNome_CheckedChanged(sender As Object, e As EventArgs) Handles chkNome.CheckedChanged
        If chkNome.Checked = True Then
            txtNome.Enabled = True
            txtNome.Focus()
        Else
            txtNome.Clear()
            txtNome.Enabled = False
        End If
    End Sub

    Private Sub chkCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles chkCategoria.CheckedChanged
        If chkCategoria.Checked = True Then
            cmbCategoria.Enabled = True
        Else
            cmbCategoria.Text = ""
            cmbCategoria.Enabled = False
        End If
    End Sub

    Private Sub chkFornecedor_CheckedChanged(sender As Object, e As EventArgs) Handles chkFornecedor.CheckedChanged
        If chkFornecedor.Checked = True Then
            cmbFornecedor.Enabled = True
        Else
            cmbFornecedor.Text = ""
            cmbFornecedor.Enabled = False
        End If
    End Sub

    Private Sub chkMarca_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarca.CheckedChanged
        If chkMarca.Checked = True Then
            txtMarca.Enabled = True
            txtMarca.Focus()
        Else
            txtMarca.Clear()
            txtMarca.Enabled = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SqlFiltro As String

        If chkCategoria.Checked = True And chkFornecedor.Checked = True And chkMarca.Checked = True And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                           "%' AND nm_categoria='" & cmbCategoria.Text &
                             "' AND marca ilike '" & txtMarca.Text &
                          "%' AND nm_fornecedor='" & cmbFornecedor.Text &
                     "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = True And chkMarca.Checked = True And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                            "%' AND marca ilike '" & txtMarca.Text &
                          "%' AND nm_fornecedor='" & cmbFornecedor.Text &
                      "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = False And chkMarca.Checked = True And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                           "%' AND nm_categoria='" & cmbCategoria.Text &
                             "' AND marca ilike '" & txtMarca.Text &
                    "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = True And chkMarca.Checked = False And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                           "%' AND nm_categoria='" & cmbCategoria.Text &
                          "' AND nm_fornecedor='" & cmbFornecedor.Text &
                     "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = True And chkMarca.Checked = True And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_categoria='" & cmbCategoria.Text &
                         "' AND marca ilike '" & txtMarca.Text &
                      "%' AND nm_fornecedor='" & cmbFornecedor.Text &
                     "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = False And chkMarca.Checked = True And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                            "%' AND marca ilike '" & txtMarca.Text &
                     "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = True And chkMarca.Checked = False And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_categoria='" & cmbCategoria.Text &
                       "' AND nm_fornecedor='" & cmbFornecedor.Text &
                     "' ORDER BY nm_produto"


        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = True And chkMarca.Checked = False And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                          "%' AND nm_fornecedor='" & cmbFornecedor.Text &
                      "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = False And chkMarca.Checked = True And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_categoria='" & cmbCategoria.Text &
                         "' AND marca ilike '" & txtMarca.Text &
                     "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkFornecedor.Checked = False And chkMarca.Checked = False And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_categoria='" & cmbCategoria.Text & "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = True And chkMarca.Checked = False And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_fornecedor='" & cmbFornecedor.Text & "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = False And chkMarca.Checked = True And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE marca ilike '" & txtMarca.Text & "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = False And chkMarca.Checked = False And chkNome.Checked = True Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text & "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkFornecedor.Checked = False And chkMarca.Checked = False And chkNome.Checked = False Then
            SqlFiltro = "SELECT nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria, marca, modelo, nm_fornecedor AS Fornecedor, vl_produto AS Valor
                         FROM tb_produtos 
                         ORDER BY nm_produto"
        End If



        Try
            Connection()
            cmd = New NpgsqlCommand(SqlFiltro, con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            dvgProdutos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try












    End Sub
End Class