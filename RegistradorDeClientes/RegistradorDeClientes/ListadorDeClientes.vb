Public Class ListadorDeClientes
    Private xOffset As Integer
    Private yOffset As Integer
    Private Sub ListadorDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ObtenerClientes As New DbClientContextSchema()
        Dim data = ObtenerClientes.ObtenerTodosLosClientes()


        dgListaDeUsuarios.DataSource = data
        dgListaDeUsuarios.Columns("Id").Visible = False
        dgListaDeUsuarios.Columns("CreadoEn").Visible = False
        dgListaDeUsuarios.Columns("ActualizadoEn").Visible = False
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
    Private Sub ListadorDeClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub
    Private Sub ListadorDeClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim formCreateClient As New CreateClient()
        formCreateClient.Show()
        Me.Hide()
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

    Private Sub dgListaDeUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaDeUsuarios.CellContentClick

    End Sub
End Class