Imports BenCer

Public Class ControladorPresupuestos

    Private daoTipoObra As DaoTipoObra
    Private daoPresupuesto As DaoPresupuesto
    Private daoRenglonPresupuesto As DaoRenglonPpto

    Private listaTipoObra As List(Of TipoObra)

    Public Sub New()

        daoTipoObra = New DaoTipoObra
        daoPresupuesto = New DaoPresupuesto
        daoRenglonPresupuesto = New DaoRenglonPpto
        listaTipoObra = daoTipoObra.listar()

    End Sub

    Public ReadOnly Property tiposObra
        Get
            Return listaTipoObra
        End Get
    End Property

    Public ReadOnly Property pptoObra(cod_tipo_obra As Integer) As Presupuesto
        Get
            Return daoPresupuesto.obtener_ppto_cod_tipo(cod_tipo_obra)
        End Get
    End Property

    Public Sub guardarItem(r_ppto As RenglonPpto)
        If daoRenglonPresupuesto.guardar(r_ppto) > 0 Then
            RaiseEvent confirmaGuardado()
        Else
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
    End Sub

    Public Event confirmaGuardado()

    Public Sub eliminarItem(cod As Integer)
        daoRenglonPresupuesto.eliminar(cod)
    End Sub

    Public Sub actualizarItem(r_ppto As RenglonPpto)
        daoRenglonPresupuesto.modificar(r_ppto, r_ppto.cod_r_ppto)
    End Sub
End Class
