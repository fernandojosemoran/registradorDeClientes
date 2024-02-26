Imports System.Threading
Imports FluentValidation.Results

Public Class EditorDeClientes
    'Declaramos dos variables que nos permitan calcular los ejes x y y de la ventana'
    'Esto sera de utilidad para despues poder arrastrar la ventana'
    Private xOffset As Integer
    Private yOffset As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        'Si el usuario da click al boton cerrar entonces cerramos el programa'
        Application.Exit()
    End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandirVentana.Click

        'Si la ventana emergente esta extendida en toda la pantalla'
        If Me.WindowState = FormWindowState.Maximized Then
            'Entonces la normalizamos al tamano asignado en el desarrollo'
            Me.WindowState = FormWindowState.Normal
        Else
            'si no esta expandida en toda la pantalla entonces la expandimos'
            Me.WindowState = FormWindowState.Maximized
            'pbvisualizador.size = new size(1050, 400)
            'btnbuscarimagen.location = new point(370, 415)
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizarVentana.Click
        'si no esta expandida en toda la pantalla entonces la expandimos'
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click
        'Declaramos una variable VentanaDeBusqueda que hace una instancia de  la clase OpenFileDialog'
        'Esta clase nos permite abrir una ventana  emergente de navegacion'
        Dim VentanaDeBusqueda As New OpenFileDialog()

        'Asignamos un inicio de partida para la ventana emergente, en esta caso asignamos la raiz del sistema C:\\'
        VentanaDeBusqueda.InitialDirectory = "C:\\"
        'Asignamos un filtro de extensiones de imagenes en esta caso solo queremos imagenes con extension .jpg y .png'
        VentanaDeBusqueda.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg|Todos los archivos (*.*)|*.*"
        'Asignamos cuantas imagenes poder seleccionar en este caso solo queremos seleccionar una imagen'
        VentanaDeBusqueda.FilterIndex = 1
        'Guardamos el ultimo directorio donde buscamos las imagenes'
        VentanaDeBusqueda.RestoreDirectory = True

        'Si la ventana emergente de busqueda ya estubo en uso y su estado es igual a que todo fue bien entonces:'
        If VentanaDeBusqueda.ShowDialog() = DialogResult.OK Then
            'Obtenemos la ruta del directorio y la guardamos en en la variable rutaDeArchivo la cual guardara un texto'
            Dim rutaDeArchivo As String = VentanaDeBusqueda.FileName

            'Guardamos en el pictureBox llamado pbVisualizador asignamos en su propiedad ImageLocation asignamos la ruta de la imagen que seleccionamos'
            pbVisualizador.ImageLocation = rutaDeArchivo
            'Asignamos como se mire la imagen en el pictureBox llamado pbVisualizador'
            pbVisualizador.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        'Instanciamos la clase ClientModel que contiene el modelo de filtros'
        Dim modeloDeCliente As New ClientModel()

        'Creamos un metodo que nos ayude a verificar si los textBox tienen el mismo texto, de ser ese el caso es un texto de relleno'
        'Echo unicamente para ayudar al usuario que datos ingresar en cada textbox'
        Dim verificarRelleno = Function(textActual As String, indicador As String) As String
                                   If textActual = indicador Then
                                       Return ""
                                   Else
                                       Return textActual
                                   End If
                               End Function

        'Llamamos a la clase modeloDeCliente que contiene los setters que son metodos de cada propiedad la cual nos ayudaran cambiar sus valores a por nuevos valores'
        'Tambien hacemos uso del metodo verificarRelleno() anteriormente explicado que resive dos valores el valor del textbox actual y el valor de comprobacion del relleno'
        'Estos nos ayudara a observar si tiene un relleno por defecto y si lo tiene eliminarlo y si el textbox tiene contenido insertado por el usuario no hacer nada pero si esta basio ayadirle un relleno'
        modeloDeCliente.SetNombre = verificarRelleno(txtNombre.Text, "Nombre")
        modeloDeCliente.SetApellido = verificarRelleno(txtApellido.Text, "Apellido")
        modeloDeCliente.SetEmail = verificarRelleno(txtEmail.Text, "Email")
        modeloDeCliente.SetNumero = verificarRelleno(txtTelefono.Text, "Telefono")
        modeloDeCliente.SetDireccion = verificarRelleno(txtDireccion.Text, "Direccion")
        'Los siguientes datos no hacen uso del metodo verificarRelleno() por que como son datos muy selectivos por el programa se puede saber que el usuario no puede darnos valores erroneos'
        'Por ejemplo la eleccion del sexo, solo hay dos sexos hombre y mujer. Entonces como ya sabemos que el usuario solo puede insertar uno de esos datos no verificamos el relleno por que cualquiera'
        'De los dos datos es valido para guardar en la base de datos.'
        modeloDeCliente.SetEstadoCivil = cbEstadoCivil.Text
        modeloDeCliente.SetGenero = cbGenero.Text

        'Instanciamos la clase ValidationClientSchema que contiene los datos asignados mediante los setters que son metodos que modifican los valores de las propiedades'\
        'Esta clase contiene el validador de los datos que queremos filtrar para saber si son correctos y de esta forma el usuario no envie datos erroneos a la base de datos.'
        Dim validador As ValidationClientSchema = New ValidationClientSchema()
        Dim result As ValidationResult = validador.Validate(modeloDeCliente)

        'Si los valores dados por el usuario son validos entonces EditorDeClientes() que nos ayudara a crear un nuevo registro en la base de datos'
        If result.IsValid Then
            Try
                'Instanceamos una la clase DbClienteFuncionalidades que contiene metodos para comunicarnos con la base de datos'
                'En esta ocacion usaremos el metodo'
                Dim interactuarConBaseDeDatos As New DbClienteFuncionalidades()

                'Llamamos el metodo CrearCliente para crear un registro'
                interactuarConBaseDeDatos.ActualizarUnCliente(
                    nombre:=txtNombre.Text,
                    apellido:=txtApellido.Text,
                    email:=txtEmail.Text,
                    telefono:=txtTelefono.Text,
                    direccion:=txtDireccion.Text,
                    fechaNacimiento:=dtpFechaDeNacimiento.Value.Date.ToString("yyyy-MM-dd"), 'Guardamos la fecha con el orden de valores año/mes/dia por que es el orden que la base de datos acepta'
                    genero:=cbGenero.Text,
                    estadoCivil:=cbEstadoCivil.Text,
                    code:=lblCode.Text
                )

                'Mostramos el formulario de listadoDeClientes'
                ListadorDeClientes.Show()
                'Luego lo ocultamos pero no lo cerramos totalmente pero esto ayuda a que la aplicacion opere mas rapido los formularios ya que el formulario queda guardado en memoria'
                'Si quieres cerrar el formulario totalmente sin guardarlo en memoria y liberar espacio de tu RAM puedes usar Me.Close()'
                Me.Hide()
            Catch ex As Exception
                'Guardamos el error en un archivo.log para tener mas control de los errores y poder observarlos de forma que no interrumpa la operabilidad del usario'
                'Ademas llevar un registro de ellos ayuda a saber que problemas debes de solucionar para mejorar la funcionalidad del programa'
                MessageBox.Show($"Error al actualizar cliente: {ex.Message}")
            End Try
        Else
            For Each [err] As ValidationFailure In result.Errors
                'Mostramos los errores al usuario
                lblAlerts.Text = [err].ErrorMessage
            Next
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Luego lo ocultamos el formulario actual pero no lo cerramos de totalmente pero esto ayuda a que la aplicacion opere mas rapido los formularios ya que el formulario queda guardado en memoria'
        'Si quieres cerrar el formulario totalmente sin guardarlo en memoria y liberar espacio de tu RAM puedes usar Me.Close()'
        ListadorDeClientes.Show()
        Me.Hide()
    End Sub


    Private Sub EditorDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Usamos la variable consejo declara e inicializada anteriormente con una instancia de un controlador que nos ayudara dirigir al usuario de como usar el programa'
        Dim consejo As New ToolTip()

        consejo.SetToolTip(btnListo, "Aceptar")
        consejo.SetToolTip(btnRegresar, "Regresar a tabla de registro") 'Cuando el mouse pose encima del boton de Regresar entonces mostrar mensaje Regresar a tabla de registro'
        consejo.SetToolTip(txtApellido, "Ingrse su apellido") 'Cuando el mouse pose encima del textbox de apellido entonces mostrar mensaje Ingrse su apellido'
        consejo.SetToolTip(txtDireccion, "Ingrese su direccion, haga uso de lo siguiente: ciudad,barrio,aldea,pueblo,pais") 'Cuando el mouse pose encima del textbox de direccion entonces mostrar mensaje Ingrese su direccion, haga uso de lo siguiente: ciudad,barrio,aldea,pueblo,pais'
        consejo.SetToolTip(txtEmail, "Ingrese un correo electronico") 'Cuando el mouse pose encima del textbox de email entonces mostrar mensaje Ingrese un correo electronico'
        consejo.SetToolTip(txtTelefono, "Ingrese un numero de telefono") 'Cuando el mouse pose encima del textbox de telefono entonces mostrar mensaje Ingrese un numero de telefono'
        consejo.SetToolTip(cbEstadoCivil, "Seleccione un estado civil") 'Cuando el mouse pose encima del ComboBox de estadoCivil entonces mostrar mensaje Seleccione un estado civil'
        consejo.SetToolTip(cbGenero, "Seleccione un genero") 'Cuando el mouse pose encima del ComboBox de genero entonces mostrar mensaje Seleccione un genero'
        consejo.SetToolTip(dtpFechaDeNacimiento, "Seleccione su fecha de nacimiento") 'Cuando el mouse pose encima del DataTimePicker de fehca de nacimiento entonces mostrar mensaje Seleccione su fecha de nacimiento'
    End Sub

    Private Sub EditorDeClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub

    Private Sub EditorDeClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

    Private Sub txtNombre_GoFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus
        If txtNombre.Text = "Nombre" Then
            txtNombre.Text = ""
        End If
    End Sub

    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles txtNombre.LostFocus
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre"
        End If
    End Sub

    Private Sub txtApellido_GotFocus(sender As Object, e As EventArgs) Handles txtApellido.GotFocus
        If txtApellido.Text = "Apellido" Then
            txtApellido.Text = ""
        End If
    End Sub

    Private Sub txtApellido_LostFocus(sender As Object, e As EventArgs) Handles txtApellido.LostFocus
        If txtApellido.Text = "" Then
            txtApellido.Text = "Apellido"
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "Email"
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "Email" Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub txtTelefono_LostFocus(sender As Object, e As EventArgs) Handles txtTelefono.LostFocus
        If txtTelefono.Text = "" Then
            txtTelefono.Text = "Telefono"
        End If
    End Sub

    Private Sub txtTelefono_GotFocus(sender As Object, e As EventArgs) Handles txtTelefono.GotFocus
        If txtTelefono.Text = "Telefono" Then
            txtTelefono.Text = ""
        End If
    End Sub

    Private Sub txtDireccion_LostFocus(sender As Object, e As EventArgs) Handles txtDireccion.LostFocus
        If txtDireccion.Text = "" Then
            txtDireccion.Text = "Direccion"
        End If
    End Sub

    Private Sub txtDireccion_GotFocus(sender As Object, e As EventArgs) Handles txtDireccion.GotFocus
        If txtDireccion.Text = "Direccion" Then
            txtDireccion.Text = ""
        End If
    End Sub

    Private Sub FlowLayoutPanel7_MouseDown(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel7.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub

    Private Sub FlowLayoutPanel7_MouseMove(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel7.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

End Class