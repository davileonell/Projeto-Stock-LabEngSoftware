Module Functions
    Public Function IsFormOpen(FormName As String) As Boolean
        IsFormOpen = False
        For Each oForm As Form In Application.OpenForms
            If oForm.Name = FormName Then IsFormOpen = True
        Next
    End Function


End Module
