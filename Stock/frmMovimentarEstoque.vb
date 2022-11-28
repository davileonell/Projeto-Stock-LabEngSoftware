Imports System.ComponentModel
Imports Npgsql

Public Class frmMovimentarEstoque
    Dim cont As Integer ' atualizar solicitações
    Dim countProdutos As Integer
    ' EXCLUSÃO DE ITENS
    Dim TirarProd_ As Integer
    Dim Repor_ As Integer
    Dim ApagarNome_ As String

    Private Sub frmMovimentarEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmHome.dvgSolicitacoes.Visible = False
        frmHome.Label2.Visible = False

        Timer1.Start()
        Connection()
        BuscarItens()
        UpdateSolicitacoes() ' Atualizar solcitações
        dvgSolicitacoes.Columns(0).Visible = False
    End Sub

    Private Sub frmMovimentarEstoque_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmHome.dvgSolicitacoes.Visible = True
        frmHome.Label2.Visible = True
    End Sub

    Private Sub txtSetor_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont > 10 Then
            cont = 0
            UpdateSolicitacoes()
        Else
            cont += 1
        End If
    End Sub

    Public Sub UpdateSolicitacoes()
        Try
            cmd = New NpgsqlCommand("SELECT num_solicitacao, nm_setor AS Setor, dt_solicitacao AS Data, hora, nm_maquina AS Máquina, status
                                         FROM tb_solicitacoes
                                         WHERE status='AGUARDANDO' or status='DISPONÍVEL' 
                                         ORDER BY dt_solicitacao DESC", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dvgSolicitacoes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim estoqueControl As Integer

        With dvgLista
            Try
                cmd = New NpgsqlCommand("DELETE FROM tb_Itenssolicitados WHERE numsolicitacao=" & IdSolicitacao_ & " AND nm_produto='" & ApagarNome_ & "'", con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            dvgLista.Rows.Remove(dvgLista.CurrentRow)

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
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
    End Sub

    Private Sub btnCancSolicitacao_Click(sender As Object, e As EventArgs) Handles btnCancSolicitacao.Click
        Do While countProdutos > 0
            For Each Row As DataGridViewRow In dvgLista.SelectedRows

                TirarProd_ = dvgLista.CurrentRow.Cells(0).Value
                Repor_ = dvgLista.CurrentRow.Cells(2).Value
                ApagarNome_ = dvgLista.CurrentRow.Cells(1).Value
                btnExcluir.PerformClick()
            Next
        Loop

        Try ' ATUALIZAR STATUS DO PEDIDO
            cmd = New NpgsqlCommand("UPDATE tb_solicitacoes SET status='CANCELADO' WHERE num_solicitacao=" & IdSolicitacao_, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Solicitação Cancelada!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDisponibilizar_Click(sender As Object, e As EventArgs) Handles btnDisponibilizar.Click
        Try
            cmd = New NpgsqlCommand("UPDATE tb_solicitacoes SET status='DISPONÍVEL' WHERE num_solicitacao=" & IdSolicitacao_, con)
            cmd.ExecuteNonQuery()
            dvgLista.Columns.Clear()
            UpdateSolicitacoes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Produtos disponíveis para retirada!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Try
            cmd = New NpgsqlCommand("UPDATE tb_solicitacoes SET status='FINALIZADO' WHERE num_solicitacao=" & IdSolicitacao_, con)
            cmd.ExecuteNonQuery()
            UpdateSolicitacoes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' MOVIMENTAÇÃO DE ESTOQUE
        Dim qtdRetirada As Integer
        Dim qtdAnterior As Integer
        Dim qtdAtual As Integer
        Dim idProduto As Integer
        Dim nomeProd As String

        Do While countProdutos > 0
            For Each Row As DataGridViewRow In dvgLista.SelectedRows

                idProduto = dvgLista.CurrentRow.Cells(0).Value
                nomeProd = dvgLista.CurrentRow.Cells(1).Value
                qtdRetirada = dvgLista.CurrentRow.Cells(2).Value


                Try ' PEGAR QUANTIDADE DO PRODUTO NA HORA DA FINALIZAÇÃO
                    cmd = New NpgsqlCommand("SELECT qt_produto FROM tb_produtos WHERE produto_id=" & idProduto, con)
                    dr = cmd.ExecuteReader

                    If dr.HasRows Then
                        dr.Read()
                        qtdAtual = dr.Item("qt_produto")
                        qtdAnterior = qtdRetirada + qtdAtual
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    dr.Close()
                End Try

                Try
                    cmd = New NpgsqlCommand("INSERT INTO tb_historico(nm_produto,
                                                                      qt_movimentacao,
                                                                      qt_quantidadeanterior,
                                                                      qt_quantidadeatual,
                                                                      dt_movimentacao,
                                                                      hora,
                                                                      tipomovimentacao,
                                                                      nm_usuario)
                                            VALUES('" & nomeProd &
                                                 "'," & qtdRetirada &
                                                  "," & qtdAnterior &
                                                  "," & qtdAtual &
                                                 ",'" & DateTime.Now.ToShortDateString &
                                                "','" & DateTime.Now.ToShortTimeString &
                                                "','RETIRADA','" & strUser_ & "')", con)
                    cmd.ExecuteNonQuery()
                    dvgLista.Rows.Remove(dvgLista.CurrentRow) ' Remover linha
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
        Loop

        MessageBox.Show("Pedido de Solicitação finalizada!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub BuscarItens()
        Try
            cmd = New NpgsqlCommand("SELECT cod_produto AS ID, nm_produto AS Nome, qt_produto AS Qtde
                                     FROM tb_itenssolicitados
                                     WHERE numsolicitacao=" & IdSolicitacao_ &
                                   " ORDER BY nm_produto", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dvgLista.DataSource = dt
            countProdutos = dvgLista.Rows.Count
            lbPedido.Text = "Pedido Nº " & IdSolicitacao_ & " selecionado"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dvgLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgLista.CellDoubleClick
        If MessageBox.Show("Deseja remover o produto da lista?", "RESPONDA:", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

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

            btnExcluir.PerformClick()
        Else
            MessageBox.Show("Não foi possível excluír o produto!", "AVISO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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

    Private Sub dvgLista_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dvgLista.RowsAdded
        countProdutos += 1
    End Sub
    Private Sub dvgLista_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dvgLista.RowsRemoved
        countProdutos -= 1
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

    Private Sub btnHistórico_Click(sender As Object, e As EventArgs) Handles btnHistórico.Click
        histSolicitacao_ = True
        frmConsultarHistorico.ShowDialog()
        histSolicitacao_ = False
    End Sub
End Class