Imports FluentValidation.Results

Public Class CreateClient
    Private xOffset As Integer
    Private yOffset As Integer
    Private Sub CreateClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        'Dim cbEstadoCivilItems As String() = {
        '    "Soltero",
        '    "Casado"
        '}

        'cbEstadoCivil.Items.Add(cbEstadoCivilItems)

        'Me.cbEstadoCivil.Location = New System.Drawing.Point(628, 264)
        'Me.cbEstadoCivil.IntegralHeight = False
        'Me.cbEstadoCivil.MaxDropDownItems = 5
        'Me.cbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList
        'Me.cbEstadoCivil.Name = "cbEstadoCivil"
        'Me.cbEstadoCivil.Size = New System.Drawing.Size(173, 24)
        'Me.cbEstadoCivil.TabIndex = 0
        'Me.Controls.Add(Me.cbEstadoCivil)
    End Sub

    Private Sub CreateClient_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub

    Private Sub CreateClient_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnExpandir_Click(sender As Object, e As EventArgs) Handles btnExpandir.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
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
        Me.Hide()
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

        Dim modeloDeCliente As New ClientModel()
        Dim validator As ValidationClientSchema = New ValidationClientSchema()
        Dim result As ValidationResult = validator.Validate(modeloDeCliente)
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
End Class