
Imports Npgsql

Module PostgreSQL_Connection
    Public con As NpgsqlConnection
    Public cmd As NpgsqlCommand
    Public dr As NpgsqlDataReader
    Public strsql As String = ""

    Dim host As String = "Host=ec2-3-214-2-141.compute-1.amazonaws.com;"
    Dim port As String = "Port=5432;"
    Dim db As String = "Database=d6lr0arisnb5mj;"
    Dim user As String = "Username=cxryvoqhgyelig;"
    Dim pass As String = "Password=0fd705d4318b90cfc700e17e2e8051bf8f8e02fc5abbc5e12b4d6985218e525e"

    Public Function Connection()
        Try
            con = New NpgsqlConnection("" & host & port & db & user & pass)
            con.Open()

            'Return MessageBox.Show("PROCESS ID: " & con.ProcessID, "FUNCIONOU")
        Catch ex As Exception
            Return MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Module
