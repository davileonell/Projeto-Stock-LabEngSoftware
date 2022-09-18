Imports System.ComponentModel

Public Class frmHome

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmChecaCpf.ShowDialog()

    End Sub




    'If IsFormOpen("frmChecaCpf") = False Then
    '    Call New frmChecaCpf() With {.MdiParent = Me}.Show()
    'End If





    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class