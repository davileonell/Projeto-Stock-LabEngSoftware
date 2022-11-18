Imports System.ComponentModel

Public Class frmChecaCpf
    Dim validado As Boolean = False
    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles mtxRestoCpf.TextChanged
        If mtxRestoCpf.Text.Length = 6 Then
            If mtxRestoCpf.Text = strcpf_.Substring(8) Then
                validado = True
                Me.Close()
            Else
                MessageBox.Show("CPF inválido para este login, tente logar novamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Login.Close()
            End If
        End If
    End Sub

    Private Sub frmChecaCpf_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If validado = False Then
            MessageBox.Show("CPF não informado, tente realizar o login novamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Login.Close()
        End If
    End Sub

    Private Sub frmChecaCpf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendKeys.Send("{HOME}")
    End Sub
End Class