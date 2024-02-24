Imports System.Threading
Imports FluentValidation.Results

Public Class EditorDeClientes
    Private xOffset As Integer
    Private yOffset As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Application.Exit()
    End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandirVentana.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
            'pbvisualizador.size = new size(1050, 400)
            'btnbuscarimagen.location = new point(370, 415)
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizarVentana.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click
        Dim VentanaDeBusqueda As New OpenFileDialog()

        VentanaDeBusqueda.InitialDirectory = "C:\\"
        VentanaDeBusqueda.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg|Todos los archivos (*.*)|*.*"
        VentanaDeBusqueda.FilterIndex = 1
        VentanaDeBusqueda.RestoreDirectory = True

        If VentanaDeBusqueda.ShowDialog() = DialogResult.OK Then
            Dim rutaDeArchivo As String = VentanaDeBusqueda.FileName
            pbVisualizador.ImageLocation = rutaDeArchivo
            pbVisualizador.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click

        Dim modeloDeCliente As New ClientModel()

        Dim verificarRelleno = Function(textActual As String, indicador As String)
                                   If textActual = indicador Then
                                       Return ""
                                   Else
                                       Return textActual
                                   End If
                               End Function

        modeloDeCliente.SetNombre = verificarRelleno(txtNombre.Text, "Nombre")
        modeloDeCliente.SetApellido = verificarRelleno(txtApellido.Text, "Apellido")
        modeloDeCliente.SetEmail = verificarRelleno(txtEmail.Text, "Email")
        modeloDeCliente.SetNumero = verificarRelleno(txtTelefono.Text, "Telefono")
        modeloDeCliente.SetDireccion = verificarRelleno(txtDireccion.Text, "Direccion")
        modeloDeCliente.SetEstadoCivil = cbEstadoCivil.Text
        modeloDeCliente.SetGenero = cbGenero.Text

        Dim validador As ValidationClientSchema = New ValidationClientSchema()
        Dim result As ValidationResult = validador.Validate(modeloDeCliente)

        If result.IsValid Then

            Try
                Dim interactuarConBaseDeDatos As New DbClienteFuncionalidades()
                interactuarConBaseDeDatos.ActualizarUnCliente(
                    nombre:=txtNombre.Text,
                    apellido:=txtApellido.Text,
                    email:=txtEmail.Text,
                    telefono:=txtTelefono.Text,
                    direccion:=txtDireccion.Text,
                    fechaNacimiento:=dtpFechaDeNacimiento.Value.Date.ToString("yyyy-MM-dd"),
                    genero:=cbGenero.Text,
                    estadoCivil:=cbEstadoCivil.Text,
                    code:=lblCode.Text
                )

                ListadorDeClientes.Show()

                Me.Hide()
            Catch ex As Exception
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
        ListadorDeClientes.Show()
        Me.Hide()
    End Sub


    Private Sub EditorDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim consejo As New ToolTip()

        consejo.SetToolTip(btnListo, "Aceptar")
        consejo.SetToolTip(btnRegresar, "Regresar a tabla de registro")
        consejo.SetToolTip(txtApellido, "Ingrse su apellido")
        consejo.SetToolTip(txtDireccion, "Ingrese su direccion, haga uso de lo siguiente: ciudad,barrio,aldea,pueblo,pais")
        consejo.SetToolTip(txtEmail, "Ingrese un correo electronico")
        consejo.SetToolTip(txtTelefono, "Ingrese un numero de telefono")
        consejo.SetToolTip(cbEstadoCivil, "Seleccione un estado civil")
        consejo.SetToolTip(cbGenero, "Seleccione un genero")
        consejo.SetToolTip(dtpFechaDeNacimiento, "Seleccione su fecha de nacimiento")
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