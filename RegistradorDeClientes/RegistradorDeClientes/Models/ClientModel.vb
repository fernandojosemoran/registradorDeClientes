Public Class ClientModel
    Public id As Integer
    Public code As String
    Public nombre As String
    Public apellido As String
    Public email As String
    Public numero As String
    Public direccion As String
    Public fechaNacimiento As String
    Public genero As String
    Public estadoCivil As String
    Public fechaRegistro As String
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

    Public ReadOnly Property GetEstadoCivil As String
        Get
            Return estadoCivil
        End Get
    End Property

    Public ReadOnly Property GetGenero As String
        Get
            Return genero
        End Get
    End Property

    Public ReadOnly Property GetFechaDeNacimiento As String
        Get
            Return fechaNacimiento
        End Get
    End Property

    Public ReadOnly Property GetFechaDeRegistro As String
        Get
            Return fechaRegistro
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
    Public WriteOnly Property SetEstadoCivil As String
        Set(value As String)
            estadoCivil = value
        End Set
    End Property
    Public WriteOnly Property SetGenero As String
        Set(value As String)
            genero = value
        End Set
    End Property

    Public WriteOnly Property SetFechaDeNacimiento As String
        Set(value As String)
            fechaNacimiento = value
        End Set
    End Property

    Public WriteOnly Property SetFechaDeRegistro As String
        Set(value As String)
            fechaRegistro = value
        End Set
    End Property

End Class