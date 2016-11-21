Imports BenCer



Public Class DaoPresupuesto
    Inherits DataManager
    Implements InterfaceDao(Of Presupuesto)


    Private daoRenglones As DaoRenglonPpto

    Public Sub New()
        daoRenglones = New DaoRenglonPpto
    End Sub


    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Presupuesto).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function modificar(elemento As Presupuesto, cod As Integer) As Integer Implements InterfaceDao(Of Presupuesto).modificar
        Throw New NotImplementedException()
    End Function

    Public Function guardar(elemento As Presupuesto) As Integer Implements InterfaceDao(Of Presupuesto).guardar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of Presupuesto) Implements InterfaceDao(Of Presupuesto).listar
        Throw New NotImplementedException()
    End Function

    Public Function obtener(cod As Integer) As Presupuesto Implements InterfaceDao(Of Presupuesto).obtener

        Dim presu As Presupuesto = New Presupuesto

        Dim ds As Data.DataSet = Me.Exec("SELECT P.cod_ppto as cod_ppto, OT.descripcion as descripcion, P.cod_tipo_obra as cod_tipo_obra" &
                                         " FROM dbo.PRESUPUESTO AS P INNER JOIN TIPO_OBRA AS OT ON P.cod_tipo_obra = OT.cod_tipo_obra " &
                                         "WHERE P.cod_ppto = " & cod & ";")

        Dim aux = ds.Tables(0).Rows(0)
        presu.cod_ppto = aux("cod_ppto")
        presu.codTipoObra = aux("descripcion")
        presu.tipo_obra = aux("cod_tipo_obra")
        presu.items = daoRenglones.listar_ppto(presu.cod_ppto)

        Return presu

    End Function

    Public Function obtener_ppto_cod_tipo(ByVal cod As Integer) As Presupuesto
        Dim presu As Presupuesto = New Presupuesto


        Dim ds As Data.DataSet = Me.Exec("SELECT P.cod_ppto as cod_ppto, OT.descripcion as descripcion, P.cod_tipo_obra as cod_tipo_obra" &
                                         " FROM dbo.PRESUPUESTO AS P INNER JOIN TIPO_OBRA AS OT ON P.cod_tipo_obra = OT.cod_tipo_obra " &
                                         "WHERE P.cod_ppto = " & cod & ";")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim aux = ds.Tables(0).Rows(0)
            presu.cod_ppto = aux("cod_ppto")
            presu.codTipoObra = aux("cod_tipo_obra")
            presu.tipo_obra = aux("descripcion")
            presu.items = daoRenglones.listar_ppto(presu.cod_ppto)
        Else
            presu = Nothing
        End If


        Return presu
    End Function
End Class
