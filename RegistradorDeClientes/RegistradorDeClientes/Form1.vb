Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formListarClientes As New ListadorDeClientes()
        formListarClientes.Show()
        Me.Hide()
    End Sub
End Class
