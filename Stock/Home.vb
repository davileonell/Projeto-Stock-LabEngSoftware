Imports System.ComponentModel

Public Class Home
    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class