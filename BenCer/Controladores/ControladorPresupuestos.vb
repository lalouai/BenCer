Imports BenCer

Public Class ControladorPresupuestos

    Private daoTipoObra As DaoTipoObra
    Private daoPresupuesto As DaoPresupuesto
    Private daoRenglonPresupuesto As DaoRenglonPpto

    Private listaTipoObra As List(Of TipoObra)
    Private _ppto As Presupuesto

    Public Sub New(cod_tipo_obra As Integer)

        daoTipoObra = New DaoTipoObra
        daoPresupuesto = New DaoPresupuesto
        daoRenglonPresupuesto = New DaoRenglonPpto

        listaTipoObra = daoTipoObra.listar()

        _ppto = daoPresupuesto.obtener_ppto_cod_tipo(cod_tipo_obra)

        If _ppto Is Nothing Then
            _ppto = New Presupuesto
            With _ppto
                .codTipoObra = cod_tipo_obra
                .tipo_obra = listaTipoObra.Find(Function(p) p.cod_tipo_obra = cod_tipo_obra).descripcion
                .estado = 0
            End With
            _ppto.cod_ppto = daoPresupuesto.guardar(_ppto)

        End If

    End Sub

    Public ReadOnly Property tipoObra
        Get
            Return _ppto.tipo_obra
        End Get
    End Property

    Public ReadOnly Property pptoObra(cod_tipo_obra As Integer) As Presupuesto
        Get
            Return daoPresupuesto.obtener_ppto_cod_tipo(cod_tipo_obra)
        End Get
    End Property

    Public ReadOnly Property estado As Integer
        Get
            Return _ppto.estado
        End Get
    End Property

    Public ReadOnly Property total As Decimal
        Get
            Return _ppto.items.Sum(Function(p) p.costo)
        End Get
    End Property

    Public ReadOnly Property listaItems As List(Of RenglonPpto)
        Get
            _ppto.items = daoRenglonPresupuesto.listar_ppto(_ppto.cod_ppto)
            Return _ppto.items
        End Get
    End Property

    Public Function guardarItem(item As String, subitem As String, descripcion As String, costo_m_obra As Decimal) As Integer

        Dim r_ppto As RenglonPpto = New RenglonPpto

        r_ppto.item = item & "," & subitem
        r_ppto.descripcion = descripcion
        r_ppto.costo = costo_m_obra
        r_ppto.cod_ppto = _ppto.cod_ppto

        Dim id As Integer = daoRenglonPresupuesto.guardar(r_ppto)

        If id > 0 Then
            Return id
        Else
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If

        Return 0

    End Function

    Public Function consolidar() As Integer
        Return daoPresupuesto.consolidar(_ppto.cod_ppto)
    End Function

    Public Sub eliminarItem(cod As Integer)
        daoRenglonPresupuesto.eliminar(cod)
    End Sub

    Public Function actualizarItem(item As String, subitem As String, descripcion As String, costo_m_obra As Decimal) As Integer
        Dim r_ppto As RenglonPpto = New RenglonPpto

        r_ppto.item = item & "," & subitem
        r_ppto.cod_r_ppto = listaItems.Find(Function(p) p.item = r_ppto.item).cod_r_ppto
        r_ppto.descripcion = descripcion
        r_ppto.costo = costo_m_obra
        r_ppto.cod_ppto = _ppto.cod_ppto

        Return daoRenglonPresupuesto.modificar(r_ppto, r_ppto.cod_r_ppto)
    End Function
End Class