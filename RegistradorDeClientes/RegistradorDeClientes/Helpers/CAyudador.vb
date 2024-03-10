Public Class CAyudador
    Public Sub EsconderColumnas(dgListaDeUsuarios As Object)
        'Hay columnas que nos devuelve la base de datos que no nos interesa mostrar, como el ID, CreadoEn y ActualizadoEn'
        dgListaDeUsuarios.Columns("Id").Visible = False
        dgListaDeUsuarios.Columns("CreadoEn").Visible = False
        dgListaDeUsuarios.Columns("ActualizadoEn").Visible = False
    End Sub
End Class
