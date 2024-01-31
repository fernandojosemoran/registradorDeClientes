Public Class CreateClient
    Private xOffset As Integer
    Private yOffset As Integer
    Private Sub CreateClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class