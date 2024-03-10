Imports System.IO
Imports System.Text

Public Class CInteraccionGlobal

    'C:\Users\MombreDeUsuario\AppData\Local\Registros\logs'
    Private Shared _localizacionDeArchivoLog As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Registros", "logs", "errors.log")

    Public Shared Function Get_localizacionDeArchivoLog() As String
        Return _localizacionDeArchivoLog
    End Function

    Public Shared Sub AddText(text As String)
        Using fs As New FileStream(_localizacionDeArchivoLog, FileMode.Append)
            Using w As New StreamWriter(fs)
                w.WriteLine($"{text} {DateTime.Now}")
                w.Close()
            End Using
        End Using
    End Sub

    Public ReadOnly Property GetLocalizacionDeArchivoLog As String
        Get
            Return _localizacionDeArchivoLog
        End Get
    End Property
End Class
