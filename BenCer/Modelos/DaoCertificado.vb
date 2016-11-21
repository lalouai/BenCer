Imports BenCer

Public Class DaoCertificado
    Inherits DataManager
    Implements InterfaceDao(Of Certificado)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Certificado).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function modificar(elemento As Certificado, cod As Integer) As Integer Implements InterfaceDao(Of Certificado).modificar
        Throw New NotImplementedException()
    End Function

    Public Function guardar(elemento As Certificado) As Integer Implements InterfaceDao(Of Certificado).guardar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of Certificado) Implements InterfaceDao(Of Certificado).listar
        Throw New NotImplementedException()
    End Function

    Public Function obtener(cod As Integer) As Certificado Implements InterfaceDao(Of Certificado).obtener
        Throw New NotImplementedException()
    End Function
End Class
