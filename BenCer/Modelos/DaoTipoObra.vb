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
        consulta = "UPDATE dbo.TIPO_OBRA SET descripcion = '" & elemento.descripcion & "' WHERE cod_tipo_obra =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As TipoObra) As Integer Implements InterfaceDao(Of TipoObra).guardar
        Dim consulta = "INSERT INTO dbo.TIPO_OBRA (descripcion, fecha_alta) OUTPUT INSERTED.COD_TIPO_OBRA VALUES ('" &
                       elemento.descripcion & "','" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of TipoObra) Implements InterfaceDao(Of TipoObra).listar
        Dim lista As New List(Of TipoObra)
        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.TIPO_OBRA WHERE ACTIVO = 1")
        For Each row In ds.Tables(0).Rows
            Dim aux As New TipoObra()
            aux.cod_tipo_obra = row("cod_tipo_obra")
            aux.descripcion = row("descripcion")
            aux.fecha_alta = row("fecha_alta")
            lista.Add(aux)
        Next
        Return lista
    End Function
    Public Function listarValidas() As List(Of TipoObra)
        Dim lista As New List(Of TipoObra)
        Dim ds As Data.DataSet = Me.Exec("select ot.cod_tipo_obra as cod_tipo_obra, ot.descripcion as descripcion, " &
                                         "ot.fecha_alta as fecha_alta from TIPO_OBRA as ot " &
                                         "inner join PRESUPUESTO as pe on ot.cod_tipo_obra = pe.cod_tipo_obra " &
                                         "where ot.activo = 1 and pe.estado = 1")
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
