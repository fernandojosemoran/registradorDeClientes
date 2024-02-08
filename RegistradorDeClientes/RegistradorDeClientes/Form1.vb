

Imports System.Data.SqlClient

Public Class Form1
    Private xOffset As Integer
    Private yOffset As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Almacenar la posición del mouse al hacer clic en la ventana
            xOffset = e.X
            yOffset = e.Y
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            ' Mover la ventana según la posición del mouse actual y la posición donde se hizo clic inicialmente
            Me.Location = New Point(Me.Left + e.X - xOffset, Me.Top + e.Y - yOffset)
        End If
    End Sub

    Private Sub txtAceptar_Click(sender As Object, e As EventArgs) Handles txtAceptar.Click
        Dim formListarClientes As New ListadorDeClientes()
        formListarClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnExpandirVentana_Click(sender As Object, e As EventArgs) Handles btnExpandirVentana.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimizarVentana_Click(sender As Object, e As EventArgs) Handles btnMinimizarVentana.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Application.Exit()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        If txtUsuario.Text = "Usuario" Then
            txtUsuario.Text = ""
        End If
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Usuario"
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Contrasena" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Contrasena"
            txtPassword.PasswordChar = ""
        End If
    End Sub
End Class
