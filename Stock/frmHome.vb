Imports System.ComponentModel

Public Class frmHome

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If strGrupo_ = "FUNC" Then
            ConfiguraçõesToolStripMenuItem.Visible = False
        End If
        frmChecaCpf.ShowDialog()



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
























    ' ESTILIZAÇÃO DOS BOTÕES
    Private Sub ConsultarProdutosToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles ConsultarProdutosToolStripMenuItem.MouseEnter
        ConsultarProdutosToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub ConsultarProdutosToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles ConsultarProdutosToolStripMenuItem.MouseLeave
        ConsultarProdutosToolStripMenuItem.ForeColor = Color.Azure
    End Sub

    Private Sub SolicitarProdutoF3ToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles SolicitarProdutoF3ToolStripMenuItem.MouseEnter
        SolicitarProdutoF3ToolStripMenuItem.ForeColor = Color.Black
    End Sub
    Private Sub SolicitarProdutoF3ToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles SolicitarProdutoF3ToolStripMenuItem.MouseLeave
        SolicitarProdutoF3ToolStripMenuItem.ForeColor = Color.Azure
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
        If ConfiguraçõesToolStripMenuItem.DropDown.Visible = False Then
            ConfiguraçõesToolStripMenuItem.ForeColor = Color.Azure
        End If
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
    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class