Imports BenCer

Public Class DaoEstadoCivil
    Inherits DataManager
    Implements InterfaceDao(Of EstadoCivil)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of EstadoCivil).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As EstadoCivil) As Integer Implements InterfaceDao(Of EstadoCivil).guardar
        Throw New NotImplementedException()
    End Function

    Public Function modificar(elemento As EstadoCivil, cod As Integer) As Integer Implements InterfaceDao(Of EstadoCivil).modificar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of EstadoCivil) Implements InterfaceDao(Of EstadoCivil).listar

        Dim lista As New List(Of EstadoCivil)

        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.ESTADO_CIVIL")

        For Each row In ds.Tables(0).Rows
            Dim aux As New EstadoCivil(row("cod_estado_civil"), row("estado"))
            lista.Add(aux)
        Next
        Return lista

    End Function

    Public Function obtener(cod As Integer) As EstadoCivil Implements InterfaceDao(Of EstadoCivil).obtener
        Throw New NotImplementedException()
    End Function
End Class
