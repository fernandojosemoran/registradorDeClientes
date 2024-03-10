'Hacemos las importaciones de las librerias correspondientes'
Imports FluentValidation 'Esta libreria es la que nos ayudara a poder hacer las filtraciones de los valores ingresador por el usuario'

Public Class CAutenticacionValidacionSchema
    'Hacemos herencia de la clase AutenticacionModel para poder hacer uso de sus metodos y propiedades'
    Inherits AbstractValidator(Of CAutenticacionModelo)

    'Hacemos una secuencia de patrones que nos permita deducion si el usuario tiene malas intenciones he intenta inyectar caracteres maliciosos'
    Private NoInyeccionSQL As String = "^\([a-z]|[A-Z])\+$"

    'Creamos el constructor de la clase AutenticacionValidacionSchema'
    Public Sub New()
        'Llamamos una metodo qeu recibe un funcion que tiene un parametro llamado modelo que hace referencia a la clase de la cual heredamos sus propiedades y metodos'
        'Despues llamamos una de sus propiedades llamada usuario el cual es un texto, esta propiedad contentra los valores por el cual va a filtrar todos los requerimientos que nosotros queramos'
        RuleFor(Function(modelo) modelo.usuario).
        Length(8, 20). 'Asignamos un longitud de valores 8 caracteres o letras como minimo y 20 como maximo'
        WithMessage('Asignamos un mensaje de error el cual el usuario vera y le ayudara para que pueda saber en que campo se equivoco'
            "Alguno de los campos es incorrecto, por favor verifique que este ingresando correctamente los datos solicitados"
        )

        RuleFor(Function(modelo) modelo.email).
        EmailAddress().'Indicamos que solo aceptamos un correo electronico'
        WithMessage('Asignamos un mensaje de error el cual el usuario vera y le ayudara para que pueda saber en que campo se equivoco'
            "Alguno de los campos es incorrecto, por favor verifique que este ingresando correctamente los datos solicitados"
        )

        RuleFor(Function(modelo) modelo.contrasena).
        Length(2, 20).'Asignamos un longitud de valores 8 caracteres o letras como minimo y 20 como maximo'
        WithMessage('Asignamos un mensaje de error el cual el usuario vera y le ayudara para que pueda saber en que campo se equivoco'
            "Alguno de los campos es incorrecto, por favor verifique que este ingresando correctamente los datos solicitados"
        )

        'Matches(NoInyeccionSQL).'Indicamos que filtre el valor ingresado por el usuario y que detecte que no intente ingresar nada malicioso''
    End Sub
End Class
