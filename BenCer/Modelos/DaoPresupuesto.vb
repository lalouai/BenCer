﻿Imports BenCer

Public Class DaoPresupuesto
    Inherits DataManager
    Implements InterfaceDao(Of Presupuesto)


    Private daoRenglones As DaoRenglonPpto

    Public Sub New()
        daoRenglones = New DaoRenglonPpto
    End Sub


    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Presupuesto).eliminar
        Dim consulta As String
        consulta = "DELETE FROM dbo.PRESUPUESTO WHERE cod_ppto =" & cod
        Dim cod_ppto As Integer = Me.ExecM(consulta)
    End Sub

    Public Function modificar(elemento As Presupuesto, cod As Integer) As Integer Implements InterfaceDao(Of Presupuesto).modificar
        Return Nothing
    End Function

    Public Function guardar(elemento As Presupuesto) As Integer Implements InterfaceDao(Of Presupuesto).guardar
        Dim consulta As String = "INSERT INTO dbo.PRESUPUESTO (cod_tipo_obra, fecha_alta, estado) OUTPUT INSERTED.cod_ppto " &
                                 "VALUES (" & elemento.codTipoObra & ", '" & DateTime.Now.ToString("yyyy-MM-dd") & "', 0 )"
        Return ExecM(consulta)
    End Function

    Public Function listar() As List(Of Presupuesto) Implements InterfaceDao(Of Presupuesto).listar
        Return Nothing
    End Function

    Public Function obtener(cod As Integer) As Presupuesto Implements InterfaceDao(Of Presupuesto).obtener

        Dim presu As Presupuesto = New Presupuesto

        Dim ds As Data.DataSet = Me.Exec("SELECT P.cod_ppto as cod_ppto, OT.descripcion as descripcion, P.cod_tipo_obra as cod_tipo_obra, P.estado as estado" &
                                         " FROM dbo.PRESUPUESTO AS P INNER JOIN TIPO_OBRA AS OT ON P.cod_tipo_obra = OT.cod_tipo_obra " &
                                         "WHERE P.cod_ppto = " & cod & ";")

        If ds.Tables(0).Rows.Count > 0 Then
            Dim aux = ds.Tables(0).Rows(0)
        presu.cod_ppto = aux("cod_ppto")
        presu.codTipoObra = aux("cod_tipo_obra")
        presu.tipo_obra = aux("descripcion")
        presu.estado = aux("estado")
        presu.items = daoRenglones.listar_ppto(presu.cod_ppto)
            Return presu
        End If
        Return Nothing
    End Function

    Public Function pptoAsociado(cod_proto As Integer) As Integer
        Dim consulta As String = "select count(cod_obra) as cantidad_obras from presupuesto as pe " &
                                 "inner join OBRA as ob on pe.cod_ppto = ob.cod_ppto " &
                                 "where pe.cod_ppto = " & cod_proto
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count = 1 Then
            Dim aux = ds.Tables(0).Rows(0)
            Debug.Print("Cantidad de Obras " & aux("cantidad_obras"))
            Return aux("cantidad_obras")
        End If

        Return 0
    End Function

    Public Sub eliminarPptoCompleto(cod_proto As Object)
        Dim ppto As Presupuesto = obtener_ppto_cod_tipo(cod_proto)
        daoRenglones.eliminarPpto(ppto.cod_ppto)
        eliminar(ppto.cod_ppto)
    End Sub

    Public Function obtener_ppto_cod_tipo(ByVal cod As Integer) As Presupuesto
        Dim presu As Presupuesto = New Presupuesto

        Dim ds As Data.DataSet = Me.Exec("SELECT P.cod_ppto as cod_ppto, OT.descripcion as descripcion, P.cod_tipo_obra as cod_tipo_obra, P.estado as estado" &
                                         " FROM dbo.PRESUPUESTO AS P INNER JOIN TIPO_OBRA AS OT ON P.cod_tipo_obra = OT.cod_tipo_obra " &
                                         "WHERE P.cod_ppto = " & cod & ";")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim aux = ds.Tables(0).Rows(0)
            presu.cod_ppto = aux("cod_ppto")
            presu.codTipoObra = aux("cod_tipo_obra")
            presu.tipo_obra = aux("descripcion")
            presu.estado = aux("estado")
            presu.items = daoRenglones.listar_ppto(presu.cod_ppto)
        Else
            presu = Nothing
        End If

        Return presu
    End Function

    Public Function consolidar(cod_ppto) As Integer
        ' último recalculo de incidencias
        Me.execSp("dbo.actualizar_incidencia", cod_ppto)
        ' consolido el ppto
        Dim consulta As String = "UPDATE dbo.PRESUPUESTO SET estado = 1 WHERE cod_ppto = " & cod_ppto
        Return Me.execnq(consulta)
    End Function

End Class
