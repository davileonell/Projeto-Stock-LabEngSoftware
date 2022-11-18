Module Functions
    Public Function IsFormOpen(FormName As String) As Boolean
        IsFormOpen = False
        For Each oForm As Form In Application.OpenForms
            If oForm.Name = FormName Then IsFormOpen = True
        Next
    End Function

    Public Sub JustNumbers(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then e.Handled = True
    End Sub

    Public Sub BlockNumbers(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    Public Function CancApostofro(txt As TextBox)
        SendKeys.Send("{END}")
        Return txt.Text.Replace("'", "´")
    End Function

    Public Function JustMoney(ByVal Keyascii As Short) As Short
        If InStr("1234567890,.", Chr(Keyascii)) = 0 Then
            JustMoney = 0
        Else
            JustMoney = Keyascii
        End If
    End Function
End Module
