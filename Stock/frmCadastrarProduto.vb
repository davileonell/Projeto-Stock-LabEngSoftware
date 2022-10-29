Public Class frmCadastrarProduto





















    Private Sub cmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFornecedor.KeyPress
        e.Handled = True
    End Sub
End Class