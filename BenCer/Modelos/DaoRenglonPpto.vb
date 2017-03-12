Imports BenCer

Public Class DaoRenglonPpto
    Inherits DataManager
    Implements InterfaceDao(Of RenglonPpto)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of RenglonPpto).eliminar
        Dim consulta As String
        consulta = "DELETE FROM dbo.R_PRESUPUESTO OUTPUT DELETED.cod_ppto WHERE cod_r_ppto =" & cod
        Dim cod_ppto As Integer = Me.ExecM(consulta)
        Me.execSp("dbo.actualizar_incidencia", cod_ppto)
    End Sub

    Public Sub eliminarPpto(ppto As Integer)
        Dim consulta As String
        consulta = "DELETE FROM dbo.R_PRESUPUESTO WHERE cod_ppto =" & ppto
        Me.ExecM(consulta)
    End Sub

    Public Function modificar(elemento As RenglonPpto, cod As Integer) As Integer Implements InterfaceDao(Of RenglonPpto).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.R_PRESUPUESTO SET cod_ppto = " & elemento.cod_ppto & ", item = '" & elemento.item & "',costo = " & elemento.costo.ToString.Replace(",", ".") &
            ", descripcion = '" & elemento.descripcion & "' WHERE cod_r_ppto =" & cod
        Dim sal As Integer = Me.execnq(consulta)
        If elemento.costo > 0 Then
            Me.execSp("dbo.actualizar_incidencia", elemento.cod_ppto)
        End If
        Return sal
    End Function

    Public Function guardar(elemento As RenglonPpto) As Integer Implements InterfaceDao(Of RenglonPpto).guardar
        Dim consulta As String
        consulta = "INSERT INTO dbo.R_PRESUPUESTO (cod_ppto ,item ,costo ,descripcion) OUTPUT INSERTED.COD_R_PPTO " &
                   "VALUES (" & elemento.cod_ppto & ",'" & elemento.item & "'," & elemento.costo.ToString.Replace(",", ".") & ",'" & elemento.descripcion & "')"
        Dim sal As Integer = Me.ExecM(consulta)
        If elemento.costo > 0 Then
            Me.execSp("dbo.actualizar_incidencia", elemento.cod_ppto)
        End If
        Return sal
    End Function

    Public Function listar() As List(Of RenglonPpto) Implements InterfaceDao(Of RenglonPpto).listar
        Throw New NotImplementedException()
    End Function

    Public Function listar_ppto(cod_ppto As Integer) As List(Of RenglonPpto)
        Dim lista As List(Of RenglonPpto) = New List(Of RenglonPpto)

        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.R_PRESUPUESTO WHERE cod_ppto = " & cod_ppto & " ORDER BY item ASC;")

        For Each row In ds.Tables(0).Rows
            Dim aux As RenglonPpto = New RenglonPpto

            aux.cod_ppto = If(Not IsDBNull(row("cod_ppto")), row("cod_ppto"), 0)
            aux.cod_r_ppto = If(Not IsDBNull(row("cod_r_ppto")), row("cod_r_ppto"), 0)
            aux.costo = If(Not IsDBNull(row("costo")), row("costo"), 0)
            aux.descripcion = If(Not IsDBNull(row("descripcion")), row("descripcion"), "")
            aux.item = If(Not IsDBNull(row("item")), row("item"), 0)
            aux.incidencia = If(Not IsDBNull(row("incidencia")), row("incidencia"), 0)

            lista.Add(aux)
        Next

        Return lista

    End Function

    Public Function obtener(cod As Integer) As RenglonPpto Implements InterfaceDao(Of RenglonPpto).obtener
        Throw New NotImplementedException()
    End Function
End Class
