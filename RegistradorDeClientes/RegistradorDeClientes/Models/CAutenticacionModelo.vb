Public Class CAutenticacionModelo
    Public usuario As String
    Public email As String
    Public contrasena As String

    Public ReadOnly Property GetUsuario As String
        Get
            Return usuario
        End Get
    End Property

    Public ReadOnly Property GetEmail As String
        Get
            Return email
        End Get
    End Property
    Public ReadOnly Property GetContrasena As String
        Get
            Return contrasena
        End Get
    End Property



    Public WriteOnly Property SetUsuario As String
        Set(value As String)
            usuario = value
        End Set
    End Property


    Public WriteOnly Property SetContrasena As String
        Set(value As String)
            contrasena = value
        End Set
    End Property


    Public WriteOnly Property SetEmail As String
        Set(value As String)
            email = value
        End Set
    End Property

End Class
