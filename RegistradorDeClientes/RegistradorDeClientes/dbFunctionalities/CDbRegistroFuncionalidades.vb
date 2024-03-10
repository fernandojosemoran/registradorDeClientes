Imports System.Data.SqlClient

Public Class CDbRegistroFuncionalidades
    'Creamos las variables globales que contengan el nombre de la base de datos y la tabla'
    Private _nombreDeBaseDeDatos As String = Environment.GetEnvironmentVariable("DB_REGISTRADOR")
    Private _nomnbreDeTablaDeBaseDeDatos As String = Environment.GetEnvironmentVariable("DB_NOMBBRE_DE_TABLA")

    'Creamos un metodo con el cual hacemos una conexion a la base de datos
    Public Function ManejarBaseDeDatos() As SqlConnection
        'Asignamos un try catch que me permita manejar futuros errores'
        Try
            Dim conexionConSQL As New SqlConnection(Me._nombreDeBaseDeDatos)
            'Abrimos la conexion a la base de datos'
            conexionConSQL.Open()
            'Devolvemos la base de datos'
            Return conexionConSQL
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error con la conexion a la base de datos")
            'Si ocurre algun error lo guardamos en el archivo .log'
            CInteraccionGlobal.AddText(ex.Message)
            'Instanciamos la conexion a la base de datos
            Dim conexionConSQL As New SqlConnection(Me._nombreDeBaseDeDatos)
            'Abrimos la conexion'
            conexionConSQL.Open()
            'Devolvemos la conexion'
            Return conexionConSQL
        End Try
    End Function

    'Creamos un metodo para crear un registro'
    Public Sub CrearUnRegistro(
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
        'Hacemos el llamado al metodo ManejarBaseDeDatos el cual hace una conexion a la base de datos'
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()

        'Creamos la consulta a la base de datos
        Dim consulta As String = $"INSERT INTO {Me._nomnbreDeTablaDeBaseDeDatos}(
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
            'Hacemos una consulta a la base de datos
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
            'Indicamos que ejecute la consulta pero que no esperamos valores devueltos
            comando.ExecuteNonQuery()

        Catch ex As Exception
            'Mostramos un mensaje de error si el registro no fue creado
            MessageBox.Show("Ocurrio un error a la hora de crear el registro")
            CInteraccionGlobal.AddText(ex.Message)
        Finally
            conexionConSQL.Close()
        End Try
    End Sub

    'Creamos un metodo para eliminar todos los registros
    Public Sub EliminarUnRegistro(email As String)
        'Llamamos al metodo ManejarBaseDeDatos para hacer una conexion con la base de datos
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        'Creamos una consulta a la base de datos
        Dim consulta As String = $"DELETE FROM {Me._nomnbreDeTablaDeBaseDeDatos} WHERE Email=@email"

        'Usamos un try catch para manejar futuros errores
        Try
            'Hacemos la consulta a la base de datos
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            'Agregamos el valor dado por el usuario a la cadena de texto de la consulta
            comando.Parameters.AddWithValue("@email", email)
            'Indicamos que no devuelva nada
            comando.ExecuteNonQuery()
        Catch ex As Exception
            'Mostramos un mensaje de error indicando que el registro no fue eliminado
            MessageBox.Show("Ocurrio un error a la hora de eliminar el registro")
            CInteraccionGlobal.AddText(ex.Message)

        Finally
            'Cerramos la conexion de la base de datos'
            conexionConSQL.Close()
        End Try
    End Sub

    'Creamos un metodo que me haga una solicitud a la base de datos pidiendo todos los registros existentes
    Public Function ObtenerTodosLosRegistros() As DataTable

        'Llamamos al metodo ManejarBaseDeDatos para realizar una conexion a la base de datos
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        'Hacemos una consulta pidiendo todos los registros de la base de datos
        Dim consulta As String = $"SELECT * FROM {Me._nomnbreDeTablaDeBaseDeDatos}"

        Dim dataTable As New DataTable()
        'Usamos un manejador de errores try catch
        Try
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            'Instanciamos la clase SqlDataReader que nos permitira leer los datos devueltos por la base de datos
            Dim dataReader As SqlDataReader = comando.ExecuteReader()
            'Cargamos el lector en la tabla
            dataTable.Load(dataReader)
            'Cerramos la lectura de la tabla
            dataReader.Close()
        Catch ex As Exception
            'Mostramos el error si los no encontro ningun registro 
            MessageBox.Show("Ocurrio un error a la hora de obtener todos los registros")
            'Guardamos el error en un archivo .log
            CInteraccionGlobal.AddText(ex.Message)
        Finally
            'Cerramos la conexion a la base de datos'
            conexionConSQL.Close()
        End Try

        Return dataTable
    End Function

    'Creamos el metodo para buscar un registro en espesifico'
    Public Function EncontrarUnRegistro(texto As String, filtro As String) As DataTable
        'Convertimos la primera letra en mayuscula '
        Dim filtroCapitalizado As String = Char.ToUpper(filtro(0)) & filtro.Substring(1)

        'Instanciamos la clase DataTable que nos permitira guardar datos dentro de ella'
        Dim dataTable As New DataTable()
        'Llamamos la el metodo que hace la conexion a la base de datos'
        Dim conexionConSQL As SqlConnection = ManejarBaseDeDatos()
        'Creamos la consulta a la base de datos'
        Dim consulta As String = $"SELECT * FROM {Me._nomnbreDeTablaDeBaseDeDatos} WHERE {filtroCapitalizado} LIKE @{filtro} + '%' ORDER BY {filtroCapitalizado}"


        Try
            'Instanciamos la clase SqlCommand que ejecutara la consulta a la base de datos'
            Dim comando As New SqlCommand(consulta, conexionConSQL)
            'Agregamos al texto de la consulta el filtro'
            comando.Parameters.AddWithValue($"@{filtro}", texto)
            'Instanciamos la clase SqlDataReader la cual inicializara un ejecutador de lectura'
            Dim dataReader As SqlDataReader = comando.ExecuteReader()
            'Cargamos los datos devueltos por la base de datos a la tabla de datos'
            dataTable.Load(dataReader)
            'Cerramos la lectura de la tabla de datos'
            dataReader.Close()
        Catch ex As Exception
            'Mostramos el error al usuario'
            MessageBox.Show(ex.Message)
            'Agregamos el error a un archivo .log '
            CInteraccionGlobal.AddText(ex.Message)
        Finally
            'Cerramos la conexion a la base de datos'
            conexionConSQL.Close()
        End Try
        'Retornamos una tabla con datos'
        Return dataTable
    End Function

    'Creamos un metodo para actualizar un registro'
    Public Sub ActualizarUnRegistro(
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
            'Creamos una consulta para actualizar un registro'
            Dim consulta As String = $"UPDATE {Me._nomnbreDeTablaDeBaseDeDatos} SET 
            Nombre = @Nombre,
            Apellido = @Apellido,
            Email = @Email,
            Telefono = @Telefono,
            Direccion = @Direccion,
            FechaNacimiento = @FechaNacimiento,
            Genero = @Genero,
            EstadoCivil = @EstadoCivil
            WHERE Code = @Code"

            'Usamos un manejador de errores try catch
            Try
                'Cunado usas using automaticamente cierrar la base de datos'
                Using comando As New SqlCommand(consulta, conexionConSQL)
                    'Agregamos los valores dados por el usuario a la cadena de texto para poder hacer la consulta'
                    comando.Parameters.AddWithValue("@Nombre", nombre)
                    comando.Parameters.AddWithValue("@Apellido", apellido)
                    comando.Parameters.AddWithValue("@Email", email)
                    comando.Parameters.AddWithValue("@Telefono", telefono)
                    comando.Parameters.AddWithValue("@Direccion", direccion)
                    comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
                    comando.Parameters.AddWithValue("@Genero", genero)
                    comando.Parameters.AddWithValue("@EstadoCivil", estadoCivil)
                    comando.Parameters.AddWithValue("@Code", code)
                    'Indicamos que no queremos ejecutar una consulta'
                    comando.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                'Mostramos un mensaje de error si ocurrio un error
                MessageBox.Show("Ocurrio un error a la hora de editar el registro")
                'Guardamos el error en un archivo .log
                CInteraccionGlobal.AddText(ex.Message)
            End Try
        End Using
    End Sub
End Class
