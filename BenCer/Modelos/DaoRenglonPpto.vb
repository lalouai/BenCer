Imports BenCer

Public Class DaoRenglonPpto
    Inherits DataManager
    Implements InterfaceDao(Of RenglonPpto)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of RenglonPpto).eliminar
        Dim consulta As String
        consulta = "DELETE FROM dbo.R_PRESUPUESTO OUTPUT DELETED.cod_ppto WHERE cod_r_ppto =" & cod
        Dim cod_ppto As Integer = Me.ExecM(consulta)
        'Me.execSp("dbo.actualizar_incidencia", cod_ppto)
    End Sub

    Public Function modificar(elemento As RenglonPpto, cod As Integer) As Integer Implements InterfaceDao(Of RenglonPpto).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.R_PRESUPUESTO SET cod_ppto = " & elemento.cod_ppto & ", item = '" & elemento.item & "',costo = " & elemento.costo.ToString.Replace(",", ".") &
            ", descripcion = '" & elemento.descripcion & "' WHERE cod_r_ppto =" & cod
        Dim sal As Integer = Me.execnq(consulta)
        MsgBox(elemento.cod_ppto)
        'Me.execSp("dbo.actualizar_incidencia", elemento.cod_ppto)
        Return sal
    End Function

    Public Function guardar(elemento As RenglonPpto) As Integer Implements InterfaceDao(Of RenglonPpto).guardar
        Dim consulta As String
        consulta = "INSERT INTO dbo.R_PRESUPUESTO (cod_ppto ,item ,costo ,descripcion) OUTPUT INSERTED.COD_R_PPTO " &
                   "VALUES (" & elemento.cod_ppto & ",'" & elemento.item & "'," & elemento.costo.ToString.Replace(",", ".") & ",'" & elemento.descripcion & "')"
        Dim sal As Integer = Me.ExecM(consulta)
        Me.execSp("dbo.actualizar_incidencia", elemento.cod_ppto)
    End Function

    Public Function listar() As List(Of RenglonPpto) Implements InterfaceDao(Of RenglonPpto).listar
        Throw New NotImplementedException()
    End Function

    Public Function listar_ppto(cod_ppto As Integer) As List(Of RenglonPpto)
        Dim lista As List(Of RenglonPpto) = New List(Of RenglonPpto)

        Dim ds As Data.DataSet = Me.Exec("SELECT * FROM dbo.R_PRESUPUESTO WHERE cod_ppto = " & cod_ppto & " ORDER BY item ASC;")

        For Each row In ds.Tables(0).Rows
            Dim aux As RenglonPpto = New RenglonPpto

            aux.cod_ppto = row("cod_ppto")
            aux.cod_r_ppto = row("cod_r_ppto")
            aux.costo = row("costo")
            aux.descripcion = row("descripcion")
            aux.item = row("item")
            aux.incidencia = row("incidencia")

            lista.Add(aux)
        Next

        Return lista

    End Function

    Public Function obtener(cod As Integer) As RenglonPpto Implements InterfaceDao(Of RenglonPpto).obtener
        Throw New NotImplementedException()
    End Function
End Class
