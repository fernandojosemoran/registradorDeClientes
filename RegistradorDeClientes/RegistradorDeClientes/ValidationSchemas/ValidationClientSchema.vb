Imports FluentValidation
Public Class ValidationClientSchema
    Inherits AbstractValidator(Of ClientModel)

    Private Function PersonalizarMensaje(errorDeCampo As String, complementoMensaje As String) As String
        Return $"Error en campo {errorDeCampo}: {complementoMensaje}"

    End Function

    Private NoSQL As String = "^\s+([a-z]|[A-Z])\s+$"
    Private SoloNumeros As String = "^\d+$"

    Public Sub nombrePropertyValidation()
        RuleFor(Function(client) client.nombre.ToString()).NotNull().Length(20, 8).Matches(NoSQL).WithMessage(PersonalizarMensaje("Nombre", "Nombre no es valido, por favor solo usar letras")).ToString().Trim()
    End Sub

    Public Sub apellidoPropertyValidation()
        RuleFor(Function(client) client.apellido.ToString()).NotNull().Length(50, 8).Matches(NoSQL).WithMessage(PersonalizarMensaje("Apellido", "Apellido no es valido, por favor solo usar letras")).ToString().Trim()
    End Sub
    Public Sub amailPropertyValidation()
        RuleFor(Function(client) client.email).NotNull().NotEmpty().EmailAddress()
    End Sub
    Public Sub numeroPropertyValidation()
        RuleFor(Function(client) client.numero.ToString()).NotNull().NotEmpty().Length(8, 8).Matches(SoloNumeros).WithMessage(PersonalizarMensaje("Telefono", "Telefono no es valido")).ToString().Trim()
    End Sub
    Public Sub direccionPropertyValidation()
        RuleFor(Function(client) client.direccion.ToString()).NotNull().NotEmpty().Length(6, 30).Matches(NoSQL).WithMessage(PersonalizarMensaje("Direccion", "La direccion no es valida")).ToString().Trim()
    End Sub
End Class
