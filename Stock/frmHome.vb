Imports System.ComponentModel
Imports Npgsql

Public Class frmHome
    Dim cont As Integer ' Timer

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If strGrupo_ = "FUNC" Then
            ConfiguraçõesToolStripMenuItem.Visible = False
            EditarInformaçõesDoProdutoF3ToolStripMenuItem.Visible = False
        End If
        frmChecaCpf.ShowDialog()
        Timer1.Start()
        Connection() ' Abre a conexão com o banco
        UpdateSolicitacoes()
        dvgSolicitacoes.Columns(0).Visible = False
    End Sub

    Private Sub CadastrarFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarFuncionárioToolStripMenuItem.Click
        If IsFormOpen("frmCadastroFuncionario") = False Then
            Call New frmCadastroFuncionario() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub CadastrarEditarFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarEditarFornecedorToolStripMenuItem.Click
        If IsFormOpen("frmCadastroFornecedor") = False Then
            Call New frmCadastroFornecedor() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub EditarInformaçõesDoProdutoF3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarInformaçõesDoProdutoF3ToolStripMenuItem.Click
        If IsFormOpen("frmCadastrarProduto") = False Then
            Call New frmCadastrarProduto() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub CadastrarEditarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarEditarCategoriaToolStripMenuItem.Click
        If IsFormOpen("frmCadastrarCategoria") = False Then
            Call New frmCadastrarCategoria() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub ConsultarProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarProdutosToolStripMenuItem.Click
        If IsFormOpen("frmConsultarProdutos") = False Then
            Call New frmConsultarProdutos() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub ConsultarHistóricoDeMovimentaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.Click
        If IsFormOpen("frmConsultarHistorico") = False Then
            Call New frmConsultarHistorico() With {.MdiParent = Me}.Show()
        End If
    End Sub

    Private Sub MovimentarEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentarEstoqueToolStripMenuItem.Click
        If IsFormOpen("frmMovimentarEstoque") = False Then
            Call New frmMovimentarEstoque() With {.MdiParent = Me}.Show()
        End If
    End Sub


    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
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
            cmd = New NpgsqlCommand("SELECT solicitacao_id, nm_setor AS Setor, dt_solicitacao AS Data, hora, nm_maquina AS Máquina, status
                                         FROM tb_solicitacoes
                                         WHERE status ='AGUARDANDO'
                                         ORDER BY dt_solicitacao", con)
            da = New NpgsqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            dvgSolicitacoes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dvgSolicitacoes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgSolicitacoes.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        If index < 0 Then index = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = dvgSolicitacoes.Rows(index)
        IdSolicitacao_ = dvgSolicitacoes.CurrentRow().Cells(0).Value
        MovimentarEstoqueToolStripMenuItem.PerformClick()
    End Sub

    Private Sub dvgSolicitacoes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dvgSolicitacoes.CellFormatting
        If e.Value IsNot Nothing Then
            If e.Value.ToString() = "AGUARDANDO" Then
                e.CellStyle.ForeColor = Color.Blue
            End If
        End If
    End Sub



















    ' ESTILIZAÇÃO DOS BOTÕES
    Private Sub ConsultarProdutosToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ConsultarProdutosToolStripMenuItem.MouseEnter
        ConsultarProdutosToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub ConsultarProdutosToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ConsultarProdutosToolStripMenuItem.MouseLeave
        ConsultarProdutosToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub EditarInformaçõesDoProdutoF3ToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles EditarInformaçõesDoProdutoF3ToolStripMenuItem.MouseEnter
        EditarInformaçõesDoProdutoF3ToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub EditarInformaçõesDoProdutoF3ToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles EditarInformaçõesDoProdutoF3ToolStripMenuItem.MouseLeave
        EditarInformaçõesDoProdutoF3ToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub CadastrarFuncionárioToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles CadastrarFuncionárioToolStripMenuItem.MouseEnter
        CadastrarFuncionárioToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub CadastrarFuncionárioToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles CadastrarFuncionárioToolStripMenuItem.MouseLeave
        CadastrarFuncionárioToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.MouseEnter
        ConfiguraçõesToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub ConfiguraçõesToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.MouseLeave
        If ConfiguraçõesToolStripMenuItem.DropDown.Visible = False Then ConfiguraçõesToolStripMenuItem.ForeColor = Color.Azure
    End Sub
    Private Sub ConfiguraçõesToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.DropDownOpening
        ConfiguraçõesToolStripMenuItem.ForeColor = Color.Black
        ConfiguraçõesToolStripMenuItem.BackColor = Color.White
    End Sub
    Private Sub ConfiguraçõesToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.DropDownClosed
        ConfiguraçõesToolStripMenuItem.ForeColor = Color.Azure
        ConfiguraçõesToolStripMenuItem.BackColor = Color.Navy
    End Sub

    Private Sub ConsultarHistóricoDeMovimentaçãoToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.MouseEnter
        ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub ConsultarHistóricoDeMovimentaçãoToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.MouseLeave
        ConsultarHistóricoDeMovimentaçãoToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub CadastrarEditarFornecedorToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles CadastrarEditarFornecedorToolStripMenuItem.MouseEnter
        CadastrarEditarFornecedorToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub CadastrarEditarFornecedorToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles CadastrarEditarFornecedorToolStripMenuItem.MouseLeave
        CadastrarEditarFornecedorToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub MovimentarEstoqueToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles MovimentarEstoqueToolStripMenuItem.MouseEnter
        MovimentarEstoqueToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub MovimentarEstoqueToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles MovimentarEstoqueToolStripMenuItem.MouseLeave
        MovimentarEstoqueToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub CadastrarEditarCategoriaToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles CadastrarEditarCategoriaToolStripMenuItem.MouseEnter
        CadastrarEditarCategoriaToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub CadastrarEditarCategoriaToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles CadastrarEditarCategoriaToolStripMenuItem.MouseLeave
        CadastrarEditarCategoriaToolStripMenuItem.ForeColor = Color.Azure
    End Sub
End Class