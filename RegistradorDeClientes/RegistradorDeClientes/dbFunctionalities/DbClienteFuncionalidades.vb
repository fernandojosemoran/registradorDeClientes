Imports System.Data.SqlClient

Public Class DbClienteFuncionalidades

    Public Function ManejarBaseDeDatos() As SqlConnection
        Try
            Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
            conexionConSQL.Open()

            Return conexionConSQL
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
            conexionConSQL.Open()
            Return conexionConSQL
        End Try
    End Function

    Public Sub CrearCliente(
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

        MessageBox.Show(estadoCivil)
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()

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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Sub

    Public Sub EliminarCliente(email As String)

        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        Dim consulta As String = $"DELETE FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")} WHERE Email=@email"

        Try
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            comando.Parameters.AddWithValue("@email", email)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Sub

    Public Function ObtenerTodosLosClientes() As DataTable
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        Dim consulta As String = $"SELECT * FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")}"

        Dim dataTable As New DataTable()

        Try
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


    Public Function EncontrarUnCliente(texto As String, filtro As String) As DataTable
        Dim filtroCapitalizado As String = Char.ToUpper(filtro(0)) & filtro.Substring(1)

        Dim dataTable As New DataTable()

        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        Dim consulta As String = $"SELECT * FROM {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")} WHERE {filtroCapitalizado} LIKE @{filtro} + '%' ORDER BY {filtroCapitalizado}"


        Try
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            comando.Parameters.AddWithValue($"@{filtro}", texto)
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


    Public Sub ActualizarUnCliente(
        nombre As String,
        apellido As String,
        email As String,
        telefono As String,
        direccion As String,
        fechaNacimiento As Date,
        genero As String,
        estadoCivil As String,
        code As String
)
        Using conexionConSQL As SqlConnection = ManejarBaseDeDatos()
            Dim consulta As String = $"UPDATE {Environment.GetEnvironmentVariable("DB_TABLE_STORE_EXPRESS")} SET 
            Nombre = @Nombre,
            Apellido = @Apellido,
            Email = @Email,
            Telefono = @Telefono,
            Direccion = @Direccion,
            FechaNacimiento = @FechaNacimiento,
            Genero = @Genero,
            EstadoCivil = @EstadoCivil
            WHERE Code = @Code"

            Try
                Using comando As New SqlCommand(consulta, conexionConSQL)
                    comando.Parameters.AddWithValue("@Nombre", nombre)
                    comando.Parameters.AddWithValue("@Apellido", apellido)
                    comando.Parameters.AddWithValue("@Email", email)
                    comando.Parameters.AddWithValue("@Telefono", telefono)
                    comando.Parameters.AddWithValue("@Direccion", direccion)
                    comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
                    comando.Parameters.AddWithValue("@Genero", genero)
                    comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil)
                    comando.Parameters.AddWithValue("@Code", code)
                    comando.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception($"Error al actualizar el cliente en la base de datos: {ex.Message}")
            End Try
        End Using
    End Sub



End Class
