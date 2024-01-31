Public Class ClientModel
    Public id As Integer
    Public code As String
    Public nombre As String
    Public apellido As String
    Public email As String
    Public numero As Integer
    Public direccion As String
    Public fechaNacimiento As String
    Public genero As String
    Public estadoCivil As String
    Public fechaRegistro As String
    Public fechaCreacion As String
    Public fechaActualizacion As String
    Public ReadOnly Property GetNombre As String
        Get
            Return nombre
        End Get
    End Property
    Public ReadOnly Property GetApellido As String
        Get
            Return apellido
        End Get
    End Property
    Public ReadOnly Property GetEmail As String
        Get
            Return email
        End Get
    End Property
    Public ReadOnly Property GetNumero As String
        Get
            Return numero
        End Get
    End Property

    Public ReadOnly Property GetDireccion As String
        Get
            Return direccion
        End Get
    End Property





    Public WriteOnly Property SetEmail As String
        Set(value As String)
            email = value
        End Set
    End Property

    Public WriteOnly Property SetDireccion As String
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public WriteOnly Property SetNumero As String
        Set(value As String)
            numero = value
        End Set
    End Property
    Public WriteOnly Property SetNombre As String
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public WriteOnly Property SetApellido As String
        Set(value As String)
            apellido = value
        End Set
    End Property
End Class