Imports BenCer

Public Class DaoTipoDoc
    Inherits DataManager
    Implements InterfaceDao(Of TipoDocumento)

    Public Sub New()
    End Sub


    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of TipoDocumento).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As TipoDocumento) As Integer Implements InterfaceDao(Of TipoDocumento).guardar
        Throw New NotImplementedException()
    End Function

    Public Function modificar(elemento As TipoDocumento, cod As Integer) As Integer Implements InterfaceDao(Of TipoDocumento).modificar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of TipoDocumento) Implements InterfaceDao(Of TipoDocumento).listar
        Dim lista As New List(Of TipoDocumento)

        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.TIPO_DOC")

        For Each row In ds.Tables(0).Rows
            Dim aux As New TipoDocumento(row("cod_tipo_doc"), row("tipo"))
            lista.Add(aux)
        Next
        Return lista
    End Function

    Public Function obtener(cod As Integer) As TipoDocumento Implements InterfaceDao(Of TipoDocumento).obtener
        Throw New NotImplementedException()
    End Function

End Class
