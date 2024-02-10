Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ListadorDeClientes
    Private xOffset As Integer
    Private yOffset As Integer
    Private Sub ListadorDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFiltrador.Text = "Filtro"
        Dim ObtenerClientes As New DbClienteFuncionalidades()
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

    Private Sub Text_buscarChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim conexion As New DbClienteFuncionalidades()
        Dim todosLosDatos As DataTable = conexion.ObtenerTodosLosClientes()

        If txtBuscar.Text = "" Then
            cbFiltrador.Text = "Filtro"
            dgListaDeUsuarios.DataSource = todosLosDatos
            dgListaDeUsuarios.Columns("Id").Visible = False
            dgListaDeUsuarios.Columns("CreadoEn").Visible = False
            dgListaDeUsuarios.Columns("ActualizadoEn").Visible = False
        Else
            Dim filtro As String = cbFiltrador.Text

            If filtro <> "Nombre" And filtro <> "Apellido" And filtro <> "Email" And filtro <> "Telefono" And filtro <> "EstadoCivil" Then
                filtro = "Nombre"
            End If

            Dim data As DataTable = conexion.EncontrarUnCliente(
                txtBuscar.Text,
                filtro
            )

            'dgListaDeUsuarios.Rows.Clear()
            dgListaDeUsuarios.DataSource = data
            dgListaDeUsuarios.Columns("Id").Visible = False
            dgListaDeUsuarios.Columns("CreadoEn").Visible = False
            dgListaDeUsuarios.Columns("ActualizadoEn").Visible = False
        End If

    End Sub
End Class