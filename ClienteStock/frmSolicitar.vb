Imports Npgsql
Public Class frmSolicitar

    Private Sub btnLimparFiltros_Click(sender As Object, e As EventArgs) Handles btnLimparFiltros.Click
        chkCategoria.Checked = False
        chkNome.Checked = False

        txtNome.Clear()
        cmbCategoria.Text = ""

        dvgProdutos.Columns.Clear()
    End Sub

    Private Sub frmSolicitar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connection()
            cmd = New NpgsqlCommand("SELECT nm_categoria FROM tb_categorias ORDER BY nm_categoria", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            cmbCategoria.ValueMember = "nm_categoria"
            cmbCategoria.DataSource = dt
            cmbCategoria.Text = ""
            codSolicitacao_ = 0 ' ZERAR Nº DO PEDIDO
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateSolicitacoes() ' Atualizar solcitações
        'dvgSolicitacoes.Columns(0).Visible = False
        BuscarItens()
    End Sub

    Public Sub UpdateSolicitacoes()
        Try
            cmd = New NpgsqlCommand("SELECT num_solicitacao AS Pedido, nm_setor AS Setor, dt_solicitacao AS Data, hora, status
                                         FROM tb_solicitacoes
                                         WHERE status='AGUARDANDO' or status='DISPONÍVEL' AND nm_maquina='" & My.Computer.Name & "' 
                                         ORDER BY dt_solicitacao DESC", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dvgSolicitacoes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BuscarItens()
        Try
            cmd = New NpgsqlCommand("SELECT nm_produto AS Nome, qt_produto AS Qtde
                                     FROM tb_itenssolicitados
                                     WHERE numsolicitacao=" & IdSolicitacao_ &
                                   " ORDER BY nm_produto", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dvgVisualizarItems.DataSource = dt
            lbPedido.Text = "Pedido Nº " & IdSolicitacao_ & " selecionado"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        UpdateSolicitacoes()
        dvgVisualizarItems.Columns.Clear()
    End Sub

    Private Sub dvgSolicitacoes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgSolicitacoes.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        If index < 0 Then index = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = dvgSolicitacoes.Rows(index)
        IdSolicitacao_ = dvgSolicitacoes.CurrentRow().Cells(0).Value
        BuscarItens()
    End Sub

    Private Sub dvgSolicitacoes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dvgSolicitacoes.CellFormatting
        If e.Value IsNot Nothing Then
            If e.Value.ToString() = "AGUARDANDO" Then
                e.CellStyle.ForeColor = Color.Blue
            ElseIf e.Value.ToString() = "FINALIZADO" Or e.Value.ToString() = "CANCELADO" Then
                e.CellStyle.ForeColor = Color.Red
            ElseIf e.Value.ToString() = "DISPONÍVEL" Then
                e.CellStyle.ForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SqlFiltro As String

        If chkCategoria.Checked = True And chkNome.Checked = True Then
            SqlFiltro = "SELECT produto_id, nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text &
                           "%' AND nm_categoria='" & cmbCategoria.Text & "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkNome.Checked = True Then
            SqlFiltro = "SELECT produto_id, nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria
                         FROM tb_produtos
                         WHERE nm_produto ilike '" & txtNome.Text & "%' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = True And chkNome.Checked = False Then
            SqlFiltro = "SELECT produto_id, nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria
                         FROM tb_produtos
                         WHERE nm_categoria='" & cmbCategoria.Text & "' ORDER BY nm_produto"

        ElseIf chkCategoria.Checked = False And chkNome.Checked = False Then
            SqlFiltro = "SELECT produto_id, nm_produto AS Nome, qt_produto AS Qtde, nm_categoria AS Categoria
                         FROM tb_produtos
                         ORDER BY nm_produto"
        End If

        Try
            cmd = New NpgsqlCommand(SqlFiltro, con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            dvgProdutos.DataSource = dt
            dvgProdutos.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub dvgProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgProdutos.CellDoubleClick
        If MessageBox.Show("Deseja adicionar o produto a lista?", "RESPONDA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Dim index As Integer
            index = e.RowIndex
            If index < 0 Then index = 0
            Dim selectedRow As DataGridViewRow
            selectedRow = dvgProdutos.Rows(index)
            IdProduto_ = dvgProdutos.CurrentRow().Cells(0).Value

            BuscarInfoProduto()

            frmInfoQtde.ShowDialog()

            If qtdInfoList_ = 0 Then
                MessageBox.Show("Quantidade inválida!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dvgLista.Rows.Add(IdProduto_, nmProduto_, qtdInfoList_)

                If codSolicitacao_ = 0 Then NumerarSolicitacao() ' CRIAR PEDIDO

                Try ' CADASTRAR ITEM NA TABELA DE ITENS SOLICITADOS
                    cmd = New NpgsqlCommand("INSERT INTO tb_Itenssolicitados(numsolicitacao,nm_produto,qt_produto,cod_produto)
                                             VALUES(" & codSolicitacao_ & ",'" & nmProduto_ & "'," & qtdInfoList_ & "," & IdProduto_ & ")", con)
                    cmd.ExecuteNonQuery()

                    ' ATUALIZAR ESTOQUE COM BASE NA SOLICITAÇÃO
                    cmd = New NpgsqlCommand("UPDATE tb_produtos SET qt_produto=" & (qtdProduto_ - qtdInfoList_) & " WHERE produto_id=" & IdProduto_, con)
                    cmd.ExecuteNonQuery()
                    qtdInfoList_ = 0 ' ZERAR QUANTIDADE INFORMADA
                    btnSearch.PerformClick()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If
    End Sub

    Public Sub BuscarInfoProduto()
        Try
            cmd = New NpgsqlCommand("SELECT nm_produto,qt_produto FROM tb_produtos WHERE produto_id=" & IdProduto_, con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                nmProduto_ = dr.Item("nm_produto")
                qtdProduto_ = dr.Item("qt_produto")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dr.Close()
        End Try
    End Sub

    Private Sub dvgLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgLista.CellDoubleClick
        If MessageBox.Show("Deseja remover o produto da lista?", "RESPONDA:", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            'If dvgLista.Rows.Count > 0 Then

            Dim index, index2, index3 As Integer ' ID, NOME e QTDE
                index = e.RowIndex
                index2 = e.RowIndex
                index3 = e.RowIndex
                If index = -1 Then
                    index = 0
                    index2 = 0
                    index3 = 0
                End If
                Dim selectedRow As DataGridViewRow
                Dim selectedRow2 As DataGridViewRow
                Dim selectedRow3 As DataGridViewRow
                selectedRow = dvgLista.Rows(index) ' ID
                selectedRow2 = dvgLista.Rows(index2) ' NOME
                selectedRow3 = dvgLista.Rows(index3) ' QTDE

                TirarProd_ = dvgLista.CurrentRow.Cells(0).Value
                Repor_ = dvgLista.CurrentRow.Cells(2).Value
                ApagarNome_ = dvgLista.CurrentRow.Cells(1).Value

                btnExcluirItem.PerformClick()
            Else
                MessageBox.Show("Não foi possível excluír o produto!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        'End If
    End Sub

    Private Sub btnExcluirItem_Click(sender As Object, e As EventArgs) Handles btnExcluirItem.Click
        Dim estoqueControl As Integer

        With dvgLista
            Try
                cmd = New NpgsqlCommand("DELETE FROM tb_Itenssolicitados WHERE numsolicitacao=" & codSolicitacao_ & " AND nm_produto='" & ApagarNome_ & "'", con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            dvgLista.Rows.Remove(dvgLista.CurrentRow)

            If CountProdutos_ = 0 Then codSolicitacao_ = 0

            Try ' REPOR PRODUTO NO ESTOQUE
                cmd = New NpgsqlCommand("SELECT qt_produto FROM tb_produtos WHERE produto_id=" & TirarProd_, con)
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
                    estoqueControl = dr.Item("qt_produto")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dr.Close()
            End Try

            Try ' CORRIGIR ESTOQUE
                cmd = New NpgsqlCommand("UPDATE tb_produtos SET qt_produto=" & (estoqueControl + Repor_) & " WHERE produto_id=" & TirarProd_, con)
                cmd.ExecuteNonQuery()
                btnSearch.PerformClick() ' RESETAR PESQUISA
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub btnFinalizarSolicitacao_Click(sender As Object, e As EventArgs) Handles btnFinalizarSolicitacao.Click
        If MessageBox.Show("Deseja finalizar a solicitação?", "RESPONDA:", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            If CountProdutos_ <= 0 Then
                MessageBox.Show("Não há produtos para solicitar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Try
                    cmd = New NpgsqlCommand("INSERT INTO tb_solicitacoes(num_solicitacao,nm_setor,dt_solicitacao,hora,nm_maquina, status)
                                             VALUES(" & codSolicitacao_ &
                                                 ",'" & cmbSetor.Text &
                                                "','" & DateTime.Now.ToShortDateString &
                                                "','" & DateTime.Now.ToShortTimeString &
                                                "','" & My.Computer.Name & "','AGUARDANDO')", con)
                    cmd.ExecuteNonQuery()

                    codSolicitacao_ = 0
                    dvgLista.Rows.Clear()
                    cmbSetor.Text = ""
                    CountProdutos_ = 0 ' zerar contador de produtos no grid
                    MessageBox.Show("Solicitação enviada ao almoxarifado!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub cmbSetor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSetor.SelectedIndexChanged
        If cmbSetor.Text IsNot "" Then
            btnFinalizarSolicitacao.Enabled = True
        Else
            btnFinalizarSolicitacao.Enabled = False
        End If
    End Sub
    Private Sub btnCancSolicitacao_Click(sender As Object, e As EventArgs) Handles btnCancSolicitacao.Click
        If CountProdutos_ > 0 Then
            Do While CountProdutos_ > 0
                For Each Row As DataGridViewRow In dvgLista.SelectedRows

                    TirarProd_ = dvgLista.CurrentRow.Cells(0).Value
                    Repor_ = dvgLista.CurrentRow.Cells(2).Value
                    ApagarNome_ = dvgLista.CurrentRow.Cells(1).Value
                    btnExcluirItem.PerformClick()

                Next
            Loop
            MessageBox.Show("Solicitação Cancelada!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Não há nada para cancelar!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dvgLista_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dvgLista.RowsAdded
        CountProdutos_ += 1
    End Sub
    Private Sub dvgLista_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dvgLista.RowsRemoved
        CountProdutos_ -= 1
    End Sub

    Private Sub cmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbSetor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSetor.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        txtNome.Text = txtNome.Text.Replace("'", "´")
        SendKeys.Send("{END}")
    End Sub
End Class
