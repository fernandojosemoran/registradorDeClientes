

Imports System.Data.SqlClient
Imports FluentValidation.Results

Public Class Form1
    'Declaramos globalmente dos variables que almacenaran dos valores los cuales seran la posicion de la ventana'
    'Son declarados globalmente con la finalidad de poder acceder a ellos con facilidad sin importar de donde se llamen siempre y cuando sea adentro de la clase'
    Private xOffset As Integer
    Private yOffset As Integer

    ''
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centramos el programa al centro de la pantalla'
        Me.CenterToScreen()
        'Declaramos e inicializamos una variable llamda NombreDeProceso que servira para despues buscar un proceso en el sistema con ese nombre'
        Dim NombreDeProceso As String = "RegistradorDeClientes"

        'Obtenemos un proceso con el nombre  RegistradorDeClientes si es que existe
        Dim procesos() As Process = Process.GetProcessesByName(NombreDeProceso)
        'Verificamos si hay procesos'
        If procesos.Length > 1 Then
            'Si el proceso está en ejecución, cerrarlo
            For Each proceso As Process In procesos
                'Matamos o cerramos el proceso ya existente para que el programa pueda abrirse'
                proceso.Kill()
            Next
        End If

        'Declaramos e inicializamos una variable con una instancia del controlador o elemento ToolTip que sirve para mostrar informacion de los elementos cuando el puntero posa encima de ellos'
        Dim consejo As New ToolTip()
        'Asignamos los mensajes que queremos que le muestre al usuario cuando el puntero del mouse pose encima de ellos'
        consejo.SetToolTip(btnCerrar, "Cerrar Ventana Emergente")
        consejo.SetToolTip(btnExpandir, "Expandir Ventana Emergente")
        consejo.SetToolTip(btnMinimizar, "Minimizar Ventana Emergente")
        consejo.SetToolTip(btnAceptar, "Verificar Autenticacion")
        consejo.SetToolTip(txtEmail, "Ingresa un correo Electronico")
        consejo.SetToolTip(txtPassword, "Ingresa una contrasena")
        consejo.SetToolTip(txtUsuario, "Ingresa un nombre de usuario")
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        'La ventana es capas de saber en que parte de la pantalla esta ubicada si a la derecha, izquierda, abajo o arriba incluso enmedio'
        'Entonces lo que quermeos es guardar esos datos y como anteriormente los declaramos globalmente en el cuerpo de clase es decir son propiedades globales podremos usarlos donde sea'

        'Ademas esta metodo hace referencia al formulario completo y este usando el evento MouseDown que lo que hace es detectar si el mouse presiona la ventana es decir el formulario completo'
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            'Con esto indicamos que cuando demos clip en el formulario podamos arrastrarlo y llevarlo en cualquier parte de la pantalla del escritorio
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            'Intanciamos el formulario que mostrara los clientes registrados existentes'
            Dim formListarClientes As New ListadorDeRegistros()
            'Instanciamos el objecto que contiene las funcionalidades que interactuan con las base de datos'
            Dim dbAutenticacion As New CDbAutenticaciontFuncionalidades()
            'Llamamos el metodo ObtenerUsuarioDeAutenticacion que nos devolvera un datatable con los datos del usuario'
            Dim datos As DataTable = dbAutenticacion.ObtenerUsuarioDeAutenticacion()
            'Creamos un diccionario donde almacenaremos los datos del usuario para manipularlos mas facilmente luego'
            Dim datosDeUsuario As New Dictionary(Of String, String)()
            ' Itera el objecto datatable que contiene los datos del usuario
            For Each columna As DataColumn In datos.Columns
                'Obtenemos el nombre de la columna
                Dim nombreColumna As String = columna.ColumnName
                ' Conseguimos el valor de la primera columna de la datatable y la convertimos en texto'
                Dim valor As String = datos.Rows(0)(nombreColumna).ToString()
                'Almacenamos los valores en un diccionario'
                datosDeUsuario.Add(nombreColumna, valor)
            Next

            'Inicializamos y declaramos la variable emailDeUsuario que almacenara un texto del email, el cual sera llamado de un diccionario para luego usar esta informacion para validar la autenticacion'
            Dim emailDeUsuario As String = datosDeUsuario.Item("Email")
            'Inicializamos y declaramos la variable nombreDeUsuario que almacenara un texto del email, el cual sera llamado de un diccionario para luego usar esta informacion para validar la autenticacion'
            Dim nombreDeUsuario As String = datosDeUsuario.Item("Nombre")
            'Inicializamos y declaramos la variable contrasenaDeUsuario que almacenara un texto del email, el cual sera llamado de un diccionario para luego usar esta informacion para validar la autenticacion'
            Dim contrasenaDeUsuario As String = datosDeUsuario.Item("Contrasena")
            'Intanciamos la clase AutenticacionModel la cual tiene las propiedades que recibiran los datos que el usaurio ingrese'
            Dim modeloDeAutenticacion As New CAutenticacionModelo()
            'Creamos una funcion que nos permita ver si el textbox tiene texto de relleno por ejemplo Email,Usuario,Contrasena que solo le ayuda al usuario saber que valores ingresar a cada textbox'
            Dim VerificarRelleno = Function(textActual As String, indicador As String) As String
                                       If textActual = indicador Then
                                           Return ""
                                       End If

                                       Return textActual
                                   End Function
            'Ingresamos los valores ingresados por el usuario a la intancia de la clase que AutenticacionModel para despues usarlos para verificar los valores que el usuario ingreso'
            modeloDeAutenticacion.SetEmail = VerificarRelleno(txtEmail.Text, "Email")
            modeloDeAutenticacion.SetUsuario = VerificarRelleno(txtUsuario.Text, "Usuario")
            modeloDeAutenticacion.SetContrasena = VerificarRelleno(txtPassword.Text, "Contrasena")

            'Intanciamos la clase que tiene las validaciones echas para que el usuario ingrese los valores correspondientes'
            Dim validador As New CAutenticacionValidacionSchema()
            'Creamos una variable result que contiene un resultado arrojado por la libreria FluentValidation'
            Dim result = validador.Validate(modeloDeAutenticacion)

            'Si los valores ingresados son correctos que permita verificar si las credenciales corresponden a los valores de la base de datos' 
            If result.IsValid Then
                'Verificamos si los valores ingresados por el usuario son validos'
                'Si los valores de email, nombre y contrasena son iguales a los que la base de datos me entrego, entonces el usaurio es valido'
                'Este usuario tiene un roll de empleado lo que significa que esta restringido en algunas cosas'
                If txtEmail.Text = emailDeUsuario And txtPassword.Text = contrasenaDeUsuario And txtUsuario.Text = nombreDeUsuario Then
                    'Si los datos ingresados por el usuario son correctos entonces mostramos el formulario que contiene los registros de los clientes'
                    formListarClientes.Show()
                    'Despues ocultamos el formulario de autenticacion'
                    Me.Hide()
                End If
            Else
                Dim errorActual As String = ""
                'Recorremos los errores a la hora de autenticarce'
                For Each [err] As ValidationFailure In result.Errors
                    'Ingresamos los errores al objecto label llamado lblAlerta que le mostrara cual fue el problema a la hora de autenticarce'
                    lblAlerta.Text = [err].ErrorMessage
                    errorActual = [err].ErrorMessage
                Next
                CInteraccionGlobal.AddText(errorActual)
            End If
        Catch ex As Exception
            'Guardamos el error en un archivo.log para tener mas control de los errores y poder observarlos de forma que no interrumpa la operabilidad del usario'
            'Ademas llevar un registro de ellos ayuda a saber que problemas debes de solucionar para mejorar la funcionalidad del programa'
            CInteraccionGlobal.AddText(ex.Message)
        End Try
    End Sub

    Private Sub btnExpandirVentana_Click(sender As Object, e As EventArgs) Handles btnExpandirVentana.Click
        'Detectamos si la ventana del formulario esta en pantalla completa
        If Me.WindowState = FormWindowState.Maximized Then
            'Si esta en pantalla completa que me la convierta en una ventana normal'
            'Es decir por defecto cuando la configuramos a la hora de hacer el programa'
            Me.WindowState = FormWindowState.Normal
        Else
            'Si la ventana esta por defecto es decir normal, entonces que ocupe la pantalla completa'
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimizarVentana_Click(sender As Object, e As EventArgs) Handles btnMinimizarVentana.Click
        'Indicamos que se oculte el programa, eso no quiere decir que se cierre si no que no se muestre por mientras en la pantalla'
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        'Indicamos que queremos terminar el proceso del programa, es decir que cerremos el programa'
        Application.Exit()
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        'Antes que se enfoque o demos click al textbox simulamos un texto que haga referencia a un textbox que datos espera' 
        If txtUsuario.Text = "Usuario" Then
            'Una vez que le demos click al textbox si contiene el texto Usuario queremos borrarlo para que el usuario pueda darnos su nombre correspondiente
            txtUsuario.Text = ""
        End If
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        'Si le damos click a otro textbox o cualquier otro objecto se desenfoca haciendo que si tiene el dato dado por el usuario lo deje como esta'
        If txtUsuario.Text = "" Then
            'Pero si el textbox esta basio entonces que me lo agregue el texto Usuario'
            txtUsuario.Text = "Usuario"
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        'Antes que se enfoque o demos click al textbox simulamos un texto que haga referencia a un textbox que datos espera' 
        If txtPassword.Text = "Contrasena" Then
            'Una vez que le demos click al textbox si contiene el texto Contrasena queremos borrarlo para que el usuario pueda darnos su Contrasena correspondiente
            txtPassword.Text = ""
            'Indicamos que cuando el usuario ingrese su contrasena que no se miren las letras si no que en su lugar muestre *, esto para seguridad del usuario'
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        'Si le damos click a otro textbox o cualquier otro objecto se desenfoca haciendo que si tiene el dato dado por el usuario lo deje como esta'
        If txtPassword.Text = "" Then
            'Pero si el textbox esta basio entonces que me lo agregue el texto Usuario'
            txtPassword.Text = "Contrasena"
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        'Antes que se enfoque o demos click al textbox simulamos un texto que haga referencia a un textbox que datos espera' 
        If txtEmail.Text = "Email" Then
            'Una vez que le demos click al textbox si contiene el texto Email queremos borrarlo para que el usuario pueda darnos su Email correspondiente
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        'Antes que se enfoque o demos click al textbox simulamos un texto que haga referencia a un textbox que datos espera' 
        If txtEmail.Text = "" Then
            'Pero si el textbox esta basio entonces que me lo agregue el texto Usuario'
            txtEmail.Text = "Email"
        End If
    End Sub
End Class
