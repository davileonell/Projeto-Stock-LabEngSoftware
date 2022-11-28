Imports Npgsql
Module Functions

    Public Sub NumerarSolicitacao()
        Try
            cmd = New NpgsqlCommand("SELECT numSolicitacao FROM tb_ItensSolicitados ORDER BY numSolicitacao DESC LIMIT 1", con)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                codSolicitacao_ = dr.Item("numSolicitacao") + 1
            Else
                codSolicitacao_ = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dr.Close()
        End Try
    End Sub
End Module
