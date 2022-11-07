Imports Npgsql

Public Class frmBuscarProduto
    Public Sub UpdateGrid()
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT produto_id, nm_produto AS NOME, qt_produto AS QUANTIDADE, nm_categoria AS CATEGORIA FROM tb_produtos WHERE nm_produto ILIKE '" & Trim(txtNome.Text) & "%' ORDER BY nm_produto LIMIT 30", con) ' ILIKE NÃO É CASE-SENSITIVE
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            dvgProdutos.DataSource = dt
            dvgProdutos.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dvgProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgProdutos.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        If index < 0 Then index = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = dvgProdutos.Rows(index)
        intIndex_ = dvgProdutos.CurrentRow().Cells(0).Value

        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        UpdateGrid()
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        BlockNumbers(sender, e)
    End Sub

    Private Sub txtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNome.KeyDown
        If e.KeyCode = Keys.Enter Then btnBuscar.PerformClick()
    End Sub
End Class