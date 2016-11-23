Imports BenCer

Public Class DaoTipoObra
    Inherits DataManager
    Implements InterfaceDao(Of TipoObra)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of TipoObra).eliminar
        Dim consulta As String
        consulta = "UPDATE dbo.TIPO_OBRA SET activo = 0 WHERE cod_tipo_obra =" & cod
        Me.execnq(consulta)
    End Sub

    Public Function modificar(elemento As TipoObra, cod As Integer) As Integer Implements InterfaceDao(Of TipoObra).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.TIPO_OBRA SET descripcion = '" & elemento.descripcion & "' WHERE cod_constructor =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As TipoObra) As Integer Implements InterfaceDao(Of TipoObra).guardar
        Dim consulta = "INSERT INTO dbo.TIPO_OBRA (descripcion, fecha_alta) OUTPUT INSERTED.COD_TIPO_OBRA VALUES ('" &
                       elemento.descripcion & "','" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of TipoObra) Implements InterfaceDao(Of TipoObra).listar
        Dim lista As New List(Of TipoObra)
        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.TIPO_OBRA")
        For Each row In ds.Tables(0).Rows
            Dim aux As New TipoObra()
            aux.cod_tipo_obra = row("cod_tipo_obra")
            aux.descripcion = row("descripcion")
            aux.fecha_alta = row("fecha_alta")
            lista.Add(aux)
        Next
        Return lista
    End Function

    Public Function obtener(cod As Integer) As TipoObra Implements InterfaceDao(Of TipoObra).obtener
        Throw New NotImplementedException()
    End Function
End Class
