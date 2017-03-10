Public Class ControladorCertificacionesAlta

    Private daoPresupuesto As DaoPresupuesto
    Private daoObra As DaoObra
    Private daoRenglonPpto As DaoRenglonPpto
    Private daoCertificado As DaoCertificado
    Private ppto As Presupuesto
    Private itemsPpto As List(Of RenglonPpto)
    Private itemsCertificado As List(Of RenglonCertificado)
    Private listaAutoComplete As New AutoCompleteStringCollection
    Private _obra As Obra
    Private _certificado As Certificado
    Private _num_orden As Integer
    Private _propio As Boolean

    Public Sub New(ByVal cod_obra As Integer, ByVal cod_ppto As Integer, Optional cod_certificado As Integer = Nothing)
        daoObra = New DaoObra
        daoPresupuesto = New DaoPresupuesto
        daoRenglonPpto = New DaoRenglonPpto
        daoCertificado = New DaoCertificado
        _obra = daoObra.obtener(cod_obra)
        ppto = daoPresupuesto.obtener(cod_ppto)
        itemsPpto = daoRenglonPpto.listar_ppto(cod_ppto)
        listaAutoComplete = New AutoCompleteStringCollection()

        For Each item As RenglonPpto In itemsPpto
            listaAutoComplete.Add(item.descripcion)
        Next

        _certificado = daoCertificado.ultimo_certificado(obra.cod_obra)
        _num_orden = daoCertificado.proximo_numero(obra.cod_obra)


        If _certificado Is Nothing Then
            _propio = True
            _certificado = New Certificado
            With _certificado
                .cod_certificado = cod_certificado
                .cod_obra = cod_obra
                .cod_estado = 1
                .fecha_alta = DateTime.Now.ToString("yyyy-MM-dd")
                .numero = _num_orden
                .monto = 0
            End With
            _certificado.cod_certificado = daoCertificado.guardar(_certificado)
        ElseIf _certificado IsNot Nothing Then
            If _certificado.cod_estado = 1 Then
                RaiseEvent bloquear()
            ElseIf _certificado.cod_estado = 3 Then
                _propio = True
                _certificado = New Certificado
                With _certificado
                    .cod_certificado = cod_certificado
                    .cod_obra = cod_obra
                    .cod_estado = 1
                    .fecha_alta = DateTime.Now.ToString("yyyy-MM-dd")
                    .numero = _num_orden
                    .monto = 0
                End With
                _certificado.cod_certificado = daoCertificado.guardar(_certificado)
            End If
        End If

        itemsCertificado = daoCertificado.listarRenglones(cod_obra, _certificado.cod_certificado)

    End Sub

    Public Sub eliminar()
        daoCertificado.eliminar(_certificado.cod_certificado)
    End Sub

    Public ReadOnly Property estado As Integer
        Get
            Return If(_propio, 2, _certificado.cod_estado)
        End Get
    End Property

    Public ReadOnly Property listaAC As AutoCompleteStringCollection
        Get
            Return listaAutoComplete
        End Get
    End Property

    Public ReadOnly Property listaRCert As List(Of RenglonCertificado)
        Get
            Return itemsCertificado
        End Get
    End Property

    Public ReadOnly Property obra As Obra
        Get
            Return _obra
        End Get
    End Property

    Public ReadOnly Property total_certificado As Decimal
        Get
            Return itemsCertificado.Sum(Function(p) p.subtotal)
        End Get
    End Property

    Public ReadOnly Property total As Decimal
        Get
            Return itemsPpto.Sum(Function(p) p.costo)
        End Get
    End Property

    Public ReadOnly Property porcentaje_avance As Decimal
        Get
            Return total_certificado / total
        End Get
    End Property

    Public ReadOnly Property num_orden As Integer
        Get
            Return _certificado.numero
        End Get
    End Property

    Public Function avanceAnterior(text As String) As String
        Dim item_ppto As RenglonPpto = itemsPpto.Find(Function(e) e.descripcion = text)
        Return daoCertificado.avance_anterior(item_ppto.cod_r_ppto, _obra.cod_obra)
    End Function

    Public Function costo(ByVal item As String) As Decimal
        Return itemsPpto.Find(Function(e) e.descripcion.ToLower = item.ToLower).costo
    End Function

    Public Sub CrearRenglon(descripcion As String, avance As String, anterior As String)

        Dim renglon = New RenglonCertificado

        With renglon
            .cod_r_ppto = itemsPpto.Find(Function(p) p.descripcion = descripcion).cod_r_ppto
            .cod_certificado = _certificado.cod_certificado
            .avance_anterior = anterior
            .avance = avance * 100
        End With

        If daoCertificado.insertarRenglon(renglon) > 0 Then
            itemsCertificado = daoCertificado.listarRenglones(_obra.cod_obra, _certificado.cod_certificado)
            RaiseEvent InsertedRenglon()
        End If

    End Sub

    Event bloquear()
    Event InsertedRenglon()

    Public Function guardar(monto As Decimal) As Integer
        _certificado.monto = monto
        _certificado.cod_estado = 2
        Return daoCertificado.modificar(_certificado, _certificado.cod_certificado)
    End Function

    Public Function consolidar() As Integer
        Return daoCertificado.consolidar(_certificado.cod_certificado)
    End Function

End Class
