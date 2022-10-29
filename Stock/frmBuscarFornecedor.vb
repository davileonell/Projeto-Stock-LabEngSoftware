Imports Npgsql

Public Class frmBuscarFornecedor
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        UpdateGrid()
    End Sub

    Private Sub frmBuscarFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
    End Sub

    Public Sub UpdateGrid()
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT fornecedor_id, nm_fornecedor, cnpj FROM tb_fornecedor WHERE nm_fornecedor ILIKE '" & Trim(txtNome.Text) & "%' ORDER BY nm_fornecedor LIMIT 10", con) ' ILIKE NÃO É CASE-SENSITIVE
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            dvgFornecedores.DataSource = dt
            dvgFornecedores.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        BlockNumbers(sender, e)
    End Sub

    Private Sub txtNome_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNome.KeyDown
        If e.KeyCode = Keys.Enter Then btnBuscar.PerformClick()
    End Sub

    Private Sub dvgFornecedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgFornecedores.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        If index < 0 Then index = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = dvgFornecedores.Rows(index)
        intIndex_ = dvgFornecedores.CurrentRow().Cells(0).Value

        Me.Close()
    End Sub
End Class