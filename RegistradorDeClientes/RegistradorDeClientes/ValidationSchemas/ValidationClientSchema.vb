Imports FluentValidation
Public Class ValidationClientSchema
    Inherits AbstractValidator(Of ClientModel)
    Private Function PersonalizarMensaje(errorDeCampo As String, complementoMensaje As String) As String
        Return $"Error en el campo {errorDeCampo}: {complementoMensaje}"
    End Function

    Private NoSQL As String = "^\([a-z]|[A-Z])\+$"
    Private SoloNumeros As String = "^\d+$"

    Public Sub New()
        RuleFor(Function(client) client.nombre).
            Length(8, 20).
            WithMessage(
                PersonalizarMensaje(
                    "Nombre",
                    "Nombre no es valido o esta vacio, solo se aceptan letras con un minimo de 8 caracteres y un maximo de 20"
                )
            )


        RuleFor(Function(client) client.apellido).
            Length(8, 30).
            WithMessage(
                PersonalizarMensaje(
                    "Apellido",
                    "Apellido no es valido o esta vacio, solo se aceptan letras con un minimo de 8 caracteres y un maximo de 30"
                )
            )


        RuleFor(Function(client) client.email).
            NotEmpty().
            EmailAddress().
            WithMessage(
                PersonalizarMensaje(
                    "Email",
                    "Email no es valido o esta vacio"
                )
            )


        RuleFor(Function(client) client.numero).
            NotEmpty().
            Length(8).
            Matches(SoloNumeros).
            WithMessage(
                PersonalizarMensaje(
                    "Telefono",
                    "Telefono no es valido o esta vacio, solo se aceptan numeros con una longitud de 8 numeros"
                )
            )

        RuleFor(Function(client) client.direccion).
            NotEmpty().
            Length(6, 50).
            WithMessage(
                PersonalizarMensaje(
                    "Direccion",
                    "La direccion no es valida o esta vacia, solo se aceptan letras con una minimo de 6 caracteres y un maximo de 50"
                )
           )

        RuleFor(Function(client) client.estadoCivil).
            NotEmpty().
            WithMessage(
                PersonalizarMensaje(
                    "Estado civil",
                    "Seleccione un estado civil"
                )
            )

        RuleFor(Function(client) client.genero).
            NotEmpty().
            WithMessage(
                PersonalizarMensaje(
                    "Genero",
                    "Seleccione un genero"
                )
            )
    End Sub
End Class
