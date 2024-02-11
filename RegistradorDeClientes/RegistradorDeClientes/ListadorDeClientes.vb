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

        toolTip.SetToolTip(btnAgregarCliente, "Agregar Un Cliente")
        toolTip.SetToolTip(btnCerrar, "Cerrar Ventana Emergente")
        toolTip.SetToolTip(btnExpandir, "Expandir Ventana Emergente")
        toolTip.SetToolTip(btnMinimizar, "Minimizar Ventana Emergente")
        toolTip.SetToolTip(txtBuscar, "Buscar clientes")
        toolTip.SetToolTip(cbFiltrador, "Filtrar Clientes Por Categoria")
        toolTip.SetToolTip(cbxSeleccionar, "Activar Opcion Para Eliminar Clientes")
        toolTip.SetToolTip(dgListaDeUsuarios, "Tabla De Clientes")

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

    Private Sub ListadorDeClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.D Then
            ' Realiza alguna acción cuando se presiona Ctrl + D
            CreateClient.Show()
            Me.Hide()
        End If

        If e.Control AndAlso e.KeyCode = Keys.J Then
            ' Realiza alguna acción cuando se presiona Ctrl + J
            If cbxSeleccionar.Checked Then
                cbxSeleccionar.Checked = False
            Else
                cbxSeleccionar.Checked = True
            End If
        End If
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

    Private Sub cbxSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSeleccionar.CheckedChanged

        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        Dim nombreDeColumna As String = "Acciones"

        If cbxSeleccionar.Checked Then
            ' Crear la columna de DataGridViewCheckBoxColumn
            checkBoxColumn.HeaderText = nombreDeColumna
            checkBoxColumn.Name = nombreDeColumna

            ' Insertar la nueva columna en la posición 0
            dgListaDeUsuarios.Columns.Insert(0, checkBoxColumn)

            For Each row As DataGridViewRow In dgListaDeUsuarios.Rows
                Dim cell As New DataGridViewCheckBoxCell()
                cell.Value = False ' o True según sea necesario
                row.Cells(nombreDeColumna) = cell
            Next

        Else
            Dim db As New DbClienteFuncionalidades()
            Dim todosLosDatos As DataTable = db.ObtenerTodosLosClientes()
            ' Recorrer las filas y eliminar las que tengan el checkbox seleccionado
            For i As Integer = dgListaDeUsuarios.Rows.Count - 1 To 0 Step -1
                Dim fila As DataGridViewRow = dgListaDeUsuarios.Rows(i)
                Dim checkBoxDeColumna As DataGridViewCheckBoxCell = TryCast(fila.Cells(nombreDeColumna), DataGridViewCheckBoxCell)
                If checkBoxDeColumna IsNot Nothing AndAlso Convert.ToBoolean(checkBoxDeColumna.Value) Then
                    Dim email As String = fila.Cells("Email").Value
                    db.EliminarCliente(email)
                    dgListaDeUsuarios.Rows.Remove(fila)
                End If
            Next

            dgListaDeUsuarios.DataSource = db.ObtenerTodosLosClientes()

            ' Eliminar la columna si existe
            If checkBoxColumn IsNot Nothing Then
                dgListaDeUsuarios.Columns.Remove(nombreDeColumna)
                checkBoxColumn = Nothing
            End If
        End If
    End Sub
End Class