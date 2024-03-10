Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class MaterialUI
    Public Sub LoadMaterial(ActualizarVentana As MaterialForm)
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(ActualizarVentana)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT

        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Blue400,
            Primary.Blue500,
            Primary.Amber500,
            Accent.LightBlue200,
            TextShade.WHITE
        )

    End Sub

End Class
