'Llamamos las librerias correspondientes'
Imports System.Data.SqlClient

Public Class DbAutenticaciontFuncionalidades
    'El metodo ObtenerUsuarioDeAutenticacion tiene como objectivo devolvernos datos para verificar la autenticidad del usuario intentando ingresar al panel de registro'
    Public Function ObtenerUsuarioDeAutenticacion() As DataTable
        'Creamos un objecto DataTable el cual nos permitira almacenar datos con una estructura similar a una tabla, es decir que tenga filas y columnas como las bases de datos'
        Dim tablaDeDatos As New DataTable()
        'Realizamos la conexion a la base de datos protegida por una variable de ambiente o entorno'
        'Esto veneficia a la seguridad de los datos de los clientes, en caso de que alguien con malas intenciones quiera robar cierta informacion'
        Dim conexionConSQL As New SqlConnection(Environment.GetEnvironmentVariable("DB_STORE_EXPRESS"))
        'Declaramos una variable que contiene un texto que sera una consulta a la base de datos piendo informacion en esta caso sera los valores del email, nombre, contrasena del usuario'
        'El cual despues usaremos para verificar la autenticacion del usuario que intente ingresar al panel de registro'
        'Usamos variables de entorno para proteger el nombre autentico de la tabla'
        Dim consulta As String = $"SELECT Nombre, Email, Contrasena FROM {Environment.GetEnvironmentVariable("DB_AUTENTICACION")}"

        'Usamos un try catch para controlar el flujo del programa y que los errores ocurrentes no corrompan el funcionamiento del programa'
        Try
            'Abrimos o empezamos la conexion a la base de datos para que este pendiente a consultas posteriores'
            conexionConSQL.Open()
            'Realizamos la consulta por la informacion del usuario a la base de datos'
            Dim cmd As New SqlCommand(consulta, conexionConSQL)
            'Hacemos una lectura de los datos devulto por la base de datos ya que estos no se pueden leer facilmente'
            Dim lectorDeDatos As SqlDataReader = cmd.ExecuteReader()
            'Cargamos los datos dentro del objecto datatable ya que esta en favorable para la estructura de la base de datos y facil de manipular'
            tablaDeDatos.Load(lectorDeDatos)
            'Cerramos el lector de los datos para que no ocupe memoria del sistema'
            lectorDeDatos.Close()
        Catch ex As Exception
            'Si existe un error que me los registre en un fichero .log'
            MessageBox.Show(ex.Message)
        Finally
            'cerramos la conexion a la base de datos'
            'esto es importantes para que la base de datos no mantenga procesos en escucha ya que por defecto suelen tener un limite de llamadas y estan se van acumulando si no se cierran'
            'si por algun caso colapsara la base de datos dejaria de responder'
            conexionConSQL.Close()
        End Try
        'Devolvemos los datos entregados por la base de datos para despues hacer uso de estos mismos'
        Return tablaDeDatos
    End Function

End Class
