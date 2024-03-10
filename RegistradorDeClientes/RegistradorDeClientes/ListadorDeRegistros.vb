Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ListadorDeRegistros

    'Declaramos dos variables que nos permitan calcular los ejes x y y de la ventana'
    'Esto sera de utilidad para despues poder arrastrar la ventana'
    Private _xOffset As Integer
    Private _yOffset As Integer
    Private _Ayudar As New CAyudador()

    'Instnaciamos un temporizador para poder hacer operaciones o ejecutar codigo dentro de un tiempo determinado'
    Private WithEvents timer As New Timer()
    Private Sub ListadorDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centramos el programa al centro de la pantalla'
        Me.CenterToScreen()
        'Asignamos un texto temporal al ComboBox de filtro para que el usuario pueda saber cual es su funcionalidad'
        cbFiltrador.Text = "Filtro"

        'Hacemos una instancia de la clase DbClienteFuncionalidades que contiene funcionalidades para comunicarse con la base de datos'
        Dim ObtenerClientes As New CDbRegistroFuncionalidades()

        'Obtenemos todos los datos de la base de datos, en este caso son los registros de los clientes'
        Dim data = ObtenerClientes.ObtenerTodosLosRegistros()

        'Le asignamos los datos devueltos por la base de datos al elemento DataGridView que es la tabla donde se mostrarán los registros'
        dgListaDeRegistros.DataSource = data

        'Hay columnas que nos devuelve la base de datos que no nos interesa mostrar, como el ID, CreadoEn y ActualizadoEn'
        _Ayudar.EsconderColumnas(dgListaDeRegistros)

        'Usamos la variable consejo declara e inicializada anteriormente con una instancia de un controlador que nos ayudara dirigir al usuario de como usar el programa'
        toolTip.SetToolTip(btnAgregarCliente, "Agregar Un registro") 'Cuando el mouse pose encima del boton de cerrar entonces mostrar Cerrar Ventana Emergente'
        toolTip.SetToolTip(btnCerrar, "Cerrar Ventana Emergente") 'Cuando el mouse pose encima del boton de cerrar mostrara el mensaje Agregar Un registro'
        toolTip.SetToolTip(btnExpandir, "Expandir Ventana Emergente") 'Cuando el mouse pose encima del boton de expandir entonces mostrar mensaje Expandir Ventana Emergente'
        toolTip.SetToolTip(btnMinimizar, "Minimizar Ventana Emergente") 'Cuando el mouse pose encima del boton de Minimizar entonces mostrar un mensaje Minimizar Ventana Emergente'
        toolTip.SetToolTip(txtBuscar, "Buscar clientes") 'Cuando el mouse pose encima del textbox de Buscar entonces mostrar mensaje Buscar clientes'
        toolTip.SetToolTip(cbFiltrador, "Filtrar Clientes Por Categoria") 'Cuando el mouse pose encima del ComboBox Filtrador entonces mostrar Filtrar Clientes Por Categoria'
        toolTip.SetToolTip(cbxSeleccionar, "Activar Opcion Para Eliminar Clientes") 'Cuando el mouse pose encima del ComboBox de seleccionar entonces mostrar mensaje Activar Opcion Para Eliminar Clientes'
        toolTip.SetToolTip(dgListaDeRegistros, "Tabla De Clientes") 'Cuando el mouse pose encima de la tabla de registro entonces mostrar mensaje Tabla De Clientes'
        toolTip.SetToolTip(btnReload, "Recargar registro") 'Cuando el mouse pose encima del boton entonces mostrar mensaje recargar registro'

        'Indicamos al formulario que habilite el uso de eventos de teclado'
        Me.KeyPreview = True

        'dgListaDeUsuarios.Columns.Add("Codigo", Guid.NewGuid().ToString())
        'dgListaDeUsuarios.Columns.Add("Nombre", txtNombre.Text)
        'dgListaDeUsuarios.Columns.Add("Apellido", txtApellido.Text)
        'dgListaDeUsuarios.Columns.Add("Email", txtEmail.Text)
        'dgListaDeUsuarios.Columns.Add("Numero", txtTelefono.Text)
        'dgListaDeUsuarios.Columns.Add("Direccion", txtDireccion.Text)
        'dgListaDeUsuarios.Columns.Add("FechaNacimiento", dtpFechaDeNacimiento.Text)
        'dgListaDeUsuarios.Columns.Add("Genero", cbGenero.Text)
        'dgListaDeUsuarios.Columns.Add("EstadoCivil", cbEstadoCivil.Text)
        'dgListaDeUsuarios.Columns.Add("FechaNacimiento", dtpFechaDeRegistro.Text)
    End Sub


    'Asignamos un evento de teclado que se activara cuando la tecla sea pulsada'
    Private Sub ListadorDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'cuando pulsemos la tecla "ctrl" y la tecla "d" entonces ejecutar el codigo interno'
        If e.Control AndAlso e.KeyCode = Keys.D Then
            'Mostramos el formulario de crear un registro'
            CreateRegistro.Show()
            'Despues cerramos el formulario actual es decir el formulario de listado de registros'
            Me.Close()
        End If

        'cuando pulsemos la tecla "ctrl" y la tecla "j" entonces ejecutar el codigo interno'
        If e.Control AndAlso e.KeyCode = Keys.J Then
            'Desactivamos el checkbox como deseleccionado, de esta forma desaparecemos la columna Acciones que muestra los checkbox que permiten eliminar registros
            'Pero si el checkbox esta seleccionado 
            If cbxSeleccionar.Checked Then
                'Entonces queremos deseleccionarlo'
                cbxSeleccionar.Checked = False
            Else
                'Pero si esta deseleccionado entonces lo seleccionamos'
                'Activamos el checkbox como seleccionado, de esta forma se habilita la columna Acciones al inicio de la tabla de registro para que podamos eliminas registros
                cbxSeleccionar.Checked = True
            End If
        End If
    End Sub
    Private Sub ListadorDeClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            _xOffset = e.X
            _yOffset = e.Y
        End If
    End Sub
    Private Sub ListadorDeClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - _xOffset, Me.Top + e.Y - _yOffset)
        End If
    End Sub

    'Usaremos el evento click para el boton agregar un registro'
    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        'Instanciamos e inicializamos la variable formCreateClient y hacemos un instancia del formulario CreateClient'
        Dim formCreateClient As New CreateRegistro()
        'Entonces mostramos el formulario CreateClient'
        formCreateClient.Show()
        'Escondemos el formulario actual es decir el listado de los registros o clientes'
        Me.Close()
    End Sub

    'Usamos el evento click para el boton cerrar'
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        'Si el usuario da click al boton cerrar entonces cerramos el programa'
        Application.Exit()
    End Sub

    'usamos el evento click para el boton expandir'
    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandirVentana.Click
        'Si la ventana emergente esta extendida en toda la pantalla'
        If Me.WindowState = FormWindowState.Maximized Then
            'Entonces la normalizamos al tamano asignado en el desarrollo'
            Me.WindowState = FormWindowState.Normal
        Else
            'si no esta expandida en toda la pantalla entonces la expandimos'
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    'usamos el evento click para el boton Minimizar'
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizarVentana.Click
        'Si el usuario da click al boton de minimizar entonces escondemos la ventana'
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Usamos el evento textchanged'
    Private Sub Text_buscarChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Usamos un try catch para manejar futuros errores imprevistos'
        Try
            'Intanciamos la clase DbClienteFuncionalidades que contiene los metodos para comunicarse con la base de datos'
            Dim db As New CDbRegistroFuncionalidades()
            'Obtenemos todos los registros de clientes y la guardamos en la variable todosLosDatos'
            Dim todosLosDatos As DataTable = db.ObtenerTodosLosRegistros()

            'Si el textbox buscar esta basio entonces'
            If txtBuscar.Text = "" Then
                'Mostramos todos los datos devueltos de la base de datos en la tabla de registro pero con la busqueda de usuarios'
                'escrita y filtrada mediante la categoria seleccionada por el usuario'
                dgListaDeRegistros.DataSource = todosLosDatos
                'Hay columnas que nos devuelve la base de datos que no nos interesa mostrar por ejemplo el ID,CreadoEn,ActualizadoEn'
                _Ayudar.EsconderColumnas(dgListaDeRegistros)
            Else
                'Obtenemos el filtro actual mediante el cual el usuario quiere buscar el registro'
                Dim filtro As String = cbFiltrador.Text

                'Si el filtro seleccionado por el usuario es diferente a Nombre,Apellido,Email,Telefono,EstadoCivil'
                If filtro <> "Nombre" And filtro <> "Apellido" And filtro <> "Email" And filtro <> "Telefono" And filtro <> "EstadoCivil" Then
                    'Entonces asignamos una categoria predeterminada o por defecto'
                    filtro = "Nombre"
                End If

                'Obtenemos los datos de la base de datos usando el metodo EncontrarUnCliente el cual nos devuelve el registro o clientes que coincidan'
                'Con lo que el usuario esta buscando'
                Dim datos As DataTable = db.EncontrarUnRegistro(
                    txtBuscar.Text, 'Enviamos los datos que el usuario esta escribiendo en el textbox buscar'
                    filtro 'Tambien le enviamos el filtro por el cual el usuario quiere filtrar'
                )

                'dgListaDeUsuarios.Rows.Clear()

                'Mostramos los datos o registros que el usuario esta buscando'
                dgListaDeRegistros.DataSource = datos
                'Hay columnas que nos devuelve la base de datos que no nos interesa mostrar por ejemplo el ID,CreadoEn,ActualizadoEn'
                _Ayudar.EsconderColumnas(dgListaDeRegistros)
            End If
        Catch ex As Exception
            'Guardamos el error en un archivo.log para tener mas control de los errores y poder observarlos de forma que no interrumpa la operabilidad del usario'
            'Ademas llevar un registro de ellos ayuda a saber que problemas debes de solucionar para mejorar la funcionalidad del programa'
            CInteraccionGlobal.AddText(ex.Message)
        End Try

    End Sub

    Private Sub cbxSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSeleccionar.CheckedChanged
        Try
            'Intanciamos un elemento o controlador DataGridViewCheckBoxColumn que nos ayudara a crear un columna individual para'
            'El controlador DataTable y poder insertar al inicio la columna'
            Dim ColumnaAcciones As New DataGridViewCheckBoxColumn()
            'Asignamos un variable que contiene el nombre que tendra la columna'
            Dim nombreDeColumna As String = "Acciones"

            'If el checkbox cbxSeleccionar esta seleccionado que se ejecute el codigo de su interior'
            If cbxSeleccionar.Checked Then
                ' Crear una cabezera para la columna DataGridViewCheckBoxColumn llamada Acciones
                ColumnaAcciones.HeaderText = nombreDeColumna
                'Adignamos un identificador de la columna con el mismo nombre de la cabezera de la columna'
                ColumnaAcciones.Name = nombreDeColumna

                'Insertar la nueva columna en la posicion 0 es decir al incio de la tabla de registro
                dgListaDeRegistros.Columns.Insert(0, ColumnaAcciones)

                'Recorremos cada fila de la tabla de registro'
                For Each row As DataGridViewRow In dgListaDeRegistros.Rows
                    'instanciamos un objecto DataGridViewCheckBoxCell que obtendra la fila que estamos recorriendo'
                    Dim cell As New DataGridViewCheckBoxCell()
                    'Si la celda seleccionada esta basia'
                    cell.Value = False
                    'agregamos la fila dentro de la columna Acciones con el checkbox'
                    row.Cells(nombreDeColumna) = cell
                Next

            Else
                'Instanciamos la clase DbClienteFuncionalidades la cual contiene metodos para comunicarnos con la base de datos'
                Dim db As New CDbRegistroFuncionalidades()
                'Obtenemos todos los registros mediante el metodo ObtenerTodosLosRegistros'
                Dim todosLosDatos As DataTable = db.ObtenerTodosLosRegistros()
                'Recorrer las filas y eliminar las que tengan el checkbox seleccionado
                For i As Integer = dgListaDeRegistros.Rows.Count - 1 To 0 Step -1
                    'Obtenemos un fila de las que existen en la tabla registro'
                    Dim fila As DataGridViewRow = dgListaDeRegistros.Rows(i)
                    'Hacemos un conversion de tipo DataGridViewRow a DataGridViewCheckBoxCell'
                    Dim columnaDeCheckbox As DataGridViewCheckBoxCell = TryCast(fila.Cells(nombreDeColumna), DataGridViewCheckBoxCell)
                    'Si la fila no esta basia y ademas tiene un valor boleano es decir verdadero o falso entonces'
                    If columnaDeCheckbox IsNot Nothing AndAlso Convert.ToBoolean(columnaDeCheckbox.Value) Then
                        'Obtenemos el valor de la fila actual y de todas sus propiedades quiero de la celda email su correo electronico'
                        Dim email As String = fila.Cells("Email").Value
                        'Llamamos el metod EliminarUnRegistro para eliminar un registro mediante su correo electronico que es unico'
                        'Lo cual significa que nadie mas puede tener ese correo electronico esto es util por que no queremos eliminar'
                        'El registro de otra persona que no sea la actual'
                        db.EliminarUnRegistro(email)
                        'Removemos la fila actual para que aparezca que se borro'
                        dgListaDeRegistros.Rows.Remove(fila)
                    End If
                Next
                'Una vez eliminado las filas seleccionadas con el checkbox volver a cargar los registros de la base de datos'
                'Pero con los usuarios eliminados'
                dgListaDeRegistros.DataSource = db.ObtenerTodosLosRegistros()

                'Eliminar la columna si no esta basia
                If ColumnaAcciones IsNot Nothing Then
                    'eliminamos la columna'
                    dgListaDeRegistros.Columns.Remove(nombreDeColumna)
                    'Asignamos el valor nada para que cuando seleccione el checkbox que habilita la columna Acciones no lo haga mas por que no hay registros'
                    'En otras palabras esto sirve para que cuando todos los registros esten borrados no funcione el checkbox ya, hasta que tenga almenos un usuario'
                    ColumnaAcciones = Nothing
                End If
            End If
        Catch ex As Exception
            'Guardamos el error en un archivo.log para tener mas control de los errores y poder observarlos de forma que no interrumpa la operabilidad del usario'
            'Ademas llevar un registro de ellos ayuda a saber que problemas debes de solucionar para mejorar la funcionalidad del programa'
            CInteraccionGlobal.AddText(ex.Message)
        End Try
    End Sub

    Private Sub dgListaDeUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaDeRegistros.CellClick
        'Aquí colocas tu lógica actual para el evento CellClick

        'Llama al método que maneja el evento KeyDown
        dgListaDeUsuarios_KeyDown(sender, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub dgListaDeUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles dgListaDeRegistros.KeyDown
        'Creamos un espesie de estado que nos permitira saber si el checkbox esta seleccionado'
        Dim estado As Boolean = False

        'Asignamos un atajo de teclado para seleccionar y deseleccionar automaticamente el checkbox'
        If e.KeyCode = Keys.N Then
            'Si el estado es falso quiere decir que el DataGridView no tiene ninguna fila, columna ni cabezera en la tabla.'
            'Es decir esta basia y hay que agregarle valores'
            If estado = False Then
                'Verificar si hay una celda seleccionada
                'Si las celdas o filas son mayores a 0 cero quiere decir que hay datos en el DataGridView es decir la tabla.'
                If dgListaDeRegistros.SelectedCells.Count > 0 Then

                    'Inicializamos una variable que contendra un numero llamada rowIndex la cual servira de indece para recorrer las diferentes celdas de la tabla'
                    'Esto nos permitira saber que celda fue seleccionada, dandonos la capacidad de poder extraer los valores de cada celda'
                    Dim rowIndex As Integer = dgListaDeRegistros.SelectedCells(0).RowIndex
                    'Extraemos el correo electronico de la fila que se selecciono'
                    Dim email As String = dgListaDeRegistros.Rows(rowIndex).Cells("Email").Value.ToString()
                    'Extraemos el telefono electronico de la fila que se selecciono'
                    Dim telefono As String = dgListaDeRegistros.Rows(rowIndex).Cells("Telefono").Value.ToString()
                    'Extraemos el estado civil electronico de la fila que se selecciono'
                    Dim estadoCivil As String = dgListaDeRegistros.Rows(rowIndex).Cells("EstadoCivil").Value.ToString()
                    'Extraemos el genero electronico de la fila que se selecciono'
                    Dim genero As String = dgListaDeRegistros.Rows(rowIndex).Cells("Genero").Value.ToString()
                    'Extraemos el fecha de nacimiento de la fila que se selecciono'
                    Dim fechaNacimiento As String = dgListaDeRegistros.Rows(rowIndex).Cells("FechaNacimiento").Value.ToString()
                    'Extraemos el apellido de la fila que se selecciono'
                    Dim apellido As String = dgListaDeRegistros.Rows(rowIndex).Cells("Apellido").Value.ToString()
                    'Extraemos el nombre de la fila que se selecciono'
                    Dim nombre As String = dgListaDeRegistros.Rows(rowIndex).Cells("Nombre").Value.ToString()
                    'Extraemos el direccion de la fila que se selecciono'
                    Dim direccion As String = dgListaDeRegistros.Rows(rowIndex).Cells("Direccion").Value.ToString()
                    'Extraemos el code de la fila que se selecciono'
                    Dim code As String = dgListaDeRegistros.Rows(rowIndex).Cells("Code").Value.ToString()

                    'Establecer los valores predeterminados en los campos del formulario EditorDeClientes
                    'Para eso instanciamos la clase EditorDeClientes que contiene todos los datos del formulario de editar'
                    Dim EditorDeRegistro As New EditorDeRegistros()
                    'Asignamos al textbox con el nombre txtApellido el valor seleccionado en la tabla'
                    EditorDeRegistro.txtApellido.Text = apellido
                    'Asignamos al textbox con el nombre txtEmail el valor seleccionado en la tabla'
                    EditorDeRegistro.txtEmail.Text = email
                    'Asignamos al textbox con el nombre txtNombre el valor seleccionado en la tabla'
                    EditorDeRegistro.txtNombre.Text = nombre
                    'Asignamos al textbox con el nombre txtDireccion el valor seleccionado en la tabla'
                    EditorDeRegistro.txtDireccion.Text = direccion
                    'Asignamos al textbox con el nombre txtTelefono el valor seleccionado en la tabla'
                    EditorDeRegistro.txtTelefono.Text = telefono
                    'Asignamos al comboBox con el nombre cbEstadoCivil el valor seleccionado en la tabla'
                    EditorDeRegistro.cbEstadoCivil.SelectedItem = estadoCivil
                    'Asignamos al comboBox con el nombre cbGenero el valor seleccionado en la tabla'
                    EditorDeRegistro.cbGenero.SelectedItem = genero
                    'Asignamos al DataTimePicket con el dtpFechaDeNacimiento el valor seleccionado en la tabla'
                    EditorDeRegistro.dtpFechaDeNacimiento.Value = DateTime.Parse(fechaNacimiento)
                    'Asignamos al label con el nombre lblCode el valor seleccionado en la tabla'
                    EditorDeRegistro.lblCode.Text = code
                    'Todo los valores extraidos del registro seleccionado se mostrara en la ventana del formulario Edtitar Registro'
                    'Nomas se muestre el formulario, dandonos una base la cual ver que valores podemos cambiar, es decir actualizar o editar'

                    'Mostrar el formulario EditorDeClientes
                    EditorDeRegistro.Show()

                    'Ocultar el formulario actual
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

        timer.Interval = 300 '300 milisegundos'
        timer.Enabled = False 'Indicamos que no se ejecute enseguida'
        'Iniciamos el timer de 300 milisegundos'
        timer.Start()


        'Asignamos un evento timer.Tick que nos ayudara a manejar el timer y que esto se ejecute dentro de 300 milisegundos cada vez que damos click en el btnReload'
        AddHandler timer.Tick, Sub()
                                   ' Hacemos una instancia de la clase DbClienteFuncionalidades que contiene funcionalidades para comunicarse con la base de datos'
                                   Dim ObtenerClientes As New CDbRegistroFuncionalidades()

                                   ' Obtenemos todos los datos de la base de datos, en este caso son los registros de los clientes'
                                   Dim data = ObtenerClientes.ObtenerTodosLosRegistros()

                                   ' Le asignamos los datos devueltos por la base de datos al elemento DataGridView que es la tabla donde se mostrarán los registros'
                                   dgListaDeRegistros.DataSource = data

                                   ' Hay columnas que nos devuelve la base de datos que no nos interesa mostrar, como el ID, CreadoEn y ActualizadoEn'
                                   dgListaDeRegistros.Columns("Id").Visible = False
                                   dgListaDeRegistros.Columns("CreadoEn").Visible = False
                                   dgListaDeRegistros.Columns("ActualizadoEn").Visible = False

                                   ' Detenemos el temporizador después de que se ha ejecutado una vez
                                   timer.Stop()
                                   timer.Dispose() ' Liberamos recursos del temporizador
                               End Sub

    End Sub
End Class