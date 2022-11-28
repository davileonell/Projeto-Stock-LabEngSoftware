Imports System.ComponentModel

Public Class frmInfoQtde
    Private Sub frmInfoQtde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudQtde.Maximum = qtdProduto_
        nudQtde.Value = 0
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If nudQtde.Value > 0 Then qtdInfoList_ = nudQtde.Value
        Me.Close()
    End Sub
End Class