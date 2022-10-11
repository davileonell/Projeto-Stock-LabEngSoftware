Imports Npgsql
Public Class frmBuscarUsuario
    Public Sub UpdateGrid()
        'If txtNome.Text IsNot "" Then
        Try
                Connection()
                cmd = New NpgsqlCommand("SELECT id, nome, login FROM tb_usuarios WHERE nome ILIKE '" & Trim(txtNome.Text) & "%' ORDER BY nome LIMIT 10", con) ' ILIKE NÃO É CASE-SENSITIVE
                da = New NpgsqlDataAdapter(cmd)
                dt = New DataTable

                da.Fill(dt)
                dvgUsuarios.DataSource = dt
                dvgUsuarios.Columns(0).Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        '    'Else
        '    '    dvgUsuarios.Columns.Clear()
        'End If
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

    Private Sub dvgUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgUsuarios.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        If index < 0 Then index = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = dvgUsuarios.Rows(index)
        intIndex_ = dvgUsuarios.CurrentRow().Cells(0).Value

        Me.Close()
    End Sub
End Class