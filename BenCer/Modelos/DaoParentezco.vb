Imports BenCer

Public Class DaoParentezco
    Inherits DataManager
    Implements InterfaceDao(Of Parentezco)

    Public Function guardar(elemento As Parentezco) As Integer Implements InterfaceDao(Of Parentezco).guardar
        Throw New NotImplementedException()
    End Function

    Public Function modificar(elemento As Parentezco, cod As Integer) As Integer Implements InterfaceDao(Of Parentezco).modificar
        Throw New NotImplementedException()
    End Function

    Private Sub eliminar(cod As Integer) Implements InterfaceDao(Of Parentezco).eliminar
        Throw New NotImplementedException()
    End Sub

    Private Function obtener(cod As Integer) As Parentezco Implements InterfaceDao(Of Parentezco).obtener
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of Parentezco) Implements InterfaceDao(Of Parentezco).listar
        Dim lista As New List(Of Parentezco)

        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.Parentezco")

        For Each row In ds.Tables(0).Rows
            Dim aux As New Parentezco(row("cod_parentezco"), row("descripción"))
            lista.Add(aux)
        Next
        Return lista
    End Function
End Class
