Imports System.Data.SqlClient

Public Class DbClientContextSchema

    Public Function CrearCliente(
        Code As String,
        nombre As String,
        apellido As String,
        email As String,
        telefono As String,
        direccion As String,
        fechaNacimiento As String,
        genero As String,
        estadoCivil As String,
        fechaRegistro As String
    )
        Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))

        Dim consulta As String = $"INSERT INTO {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")}(
            Code,
            Nombre,
            Apellido,
            Email,
            Telefono,
            Direccion,
            FechaNacimiento,
            Genero,
            EstadoCivil,
            FechaRegistro
        ) VALUES (
            @Code,
            @Nombre,
            @Apellido,
            @Email,
            @Telefono,
            @Direccion,
            @FechaNacimiento,
            @Genero,
            @EstadoCivil,
            @FechaRegistro
        )"

        Try
            conexionConSQL.Open()
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            comando.Parameters.AddWithValue("@Code", Code)
            comando.Parameters.AddWithValue("@Nombre", nombre)
            comando.Parameters.AddWithValue("@Apellido", apellido)
            comando.Parameters.AddWithValue("@Email", email)
            comando.Parameters.AddWithValue("@Telefono", telefono)
            comando.Parameters.AddWithValue("@Direccion", direccion)
            comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
            comando.Parameters.AddWithValue("@Genero", genero)
            comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil)
            comando.Parameters.AddWithValue("@FechaRegistro", fechaRegistro)

            comando.ExecuteNonQuery()
            Return comando

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Function

    Public Function EliminarCliente(email As String)

        Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
        Dim consulta As String = $"DELETE FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")} WHERE Email=@email"

        Try
            conexionConSQL.Open()
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            comando.Parameters.AddWithValue("@email", email)
            comando.ExecuteNonQuery()
            Return comando
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Function

    Public Function ObtenerTodosLosClientes() As DataTable
        Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
        Dim consulta As String = $"SELECT * FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")}"

        Dim dataTable As New DataTable()

        Try
            conexionConSQL.Open()
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            Dim dataReader As SqlDataReader = comando.ExecuteReader()
            dataTable.Load(dataReader)
            dataReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try

        Return dataTable
    End Function


    Public Function EncontrarUnCliente(email As String)
        Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
        Dim consulta As String = $"SELECT Email FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")} WHERE Email=@email"
        Try
            conexionConSQL.Open()
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            comando.Parameters.AddWithValue("@email", email)
            comando.ExecuteScalar()

            Return comando
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Function

    'Public Function ActualizarUnCliente(fileds As String, connectionSQL As SqlConnection)
    '    Dim cmd As New SqlCommand($"UPDATE Cliente SET  {fileds} WHERE Email='{email}'", connectionSQL)
    '    cmd.ExecuteNonQuery()
    '    Return cmd
    'End Function


End Class
