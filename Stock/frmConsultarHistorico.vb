Imports Npgsql
Public Class frmConsultarHistorico

    Private Sub frmConsultarHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDataInicial.Value = DateTime.Now.ToShortDateString
        dtpDataFinal.Value = DateTime.Now.ToShortDateString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strsql As String

        If histSolicitacao_ = True Then
            strsql = "SELECT nm_setor AS Setor, nm_maquina AS Máquina, dt_solicitacao AS Data, hora, status
                      FROM tb_solicitacoes
                      WHERE TO_DATE(dt_solicitacao, 'DD/MM/YYYY')
                      BETWEEN TO_DATE('" & dtpDataInicial.Value.ToShortDateString & "', 'DD/MM/YYYY') AND TO_DATE('" & dtpDataFinal.Value.ToShortDateString & "', 'DD/MM/YYYY')
                      ORDER BY solicitacao_id DESC"

        Else
            strsql = "SELECT nm_produto AS Produto,
                                            qt_movimentacao AS Quantidade,
                                            dt_movimentacao AS Data,
                                            hora,
                                            qt_quantidadeanterior AS Quantidade_Anterior,
                                            tipomovimentacao AS Movimentação,
                                            qt_quantidadeatual AS Quantidade_Atual,
                                            nm_usuario AS Usuário
                     FROM tb_historico
                     WHERE TO_DATE(dt_movimentacao, 'DD/MM/YYYY')
                     BETWEEN TO_DATE('" & dtpDataInicial.Value.ToShortDateString & "', 'DD/MM/YYYY') AND TO_DATE('" & dtpDataFinal.Value.ToShortDateString & "', 'DD/MM/YYYY')
                     ORDER BY historico_id DESC"
        End If

        Try
            Connection()
            cmd = New NpgsqlCommand(strsql, con)

            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable

            da.Fill(dt)
            dvgHistorico.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dvgHistorico_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dvgHistorico.CellFormatting
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
End Class