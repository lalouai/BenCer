Public Class DaoFormaPago
    Inherits DataManager
    Implements InterfaceDao(Of FormaPago)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of FormaPago).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As FormaPago) As Integer Implements InterfaceDao(Of FormaPago).guardar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of FormaPago) Implements InterfaceDao(Of FormaPago).listar
        Dim lista As List(Of FormaPago) = New List(Of FormaPago)
        lista.Add(New FormaPago(0, "Seleccione por favor"))
        Dim consulta As String = "SELECT * FROM dbo.FORMA_PAGO"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                lista.Add(New FormaPago(row("cod_forma_pago"), row("descripcion")))
            Next
        End If
        Return lista
    End Function

    Public Function modificar(elemento As FormaPago, cod As Integer) As Integer Implements InterfaceDao(Of FormaPago).modificar
        Throw New NotImplementedException()
    End Function

    Public Function obtener(cod As Integer) As FormaPago Implements InterfaceDao(Of FormaPago).obtener
        Throw New NotImplementedException()
    End Function
End Class
