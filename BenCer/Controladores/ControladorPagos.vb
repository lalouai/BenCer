Public Class ControladorPagos

    Private daoPagos As DaoPago
    Private daoCertificados As DaoCertificado
    Private listaCertSinOrden As List(Of CertificadoSinOrden)
    Private listaCertConOrden As List(Of PagoConOrden)
    Private listaCertPagados As List(Of PagoConOrden)

    Sub New()

        daoPagos = New DaoPago()
        daoCertificados = New DaoCertificado()


    End Sub

    Public ReadOnly Property listaSinOrden As List(Of CertificadoSinOrden)
        Get
            listaCertSinOrden = daoCertificados.certificadosSinOrden()
            Return listaCertSinOrden
        End Get
    End Property

    Public ReadOnly Property listaConOrden As List(Of PagoConOrden)
        Get
            listaCertConOrden = daoPagos.listar_por_estado(1)
            Return listaCertConOrden
        End Get
    End Property
    Public ReadOnly Property listaPagados As List(Of PagoConOrden)
        Get
            listaCertPagados = daoPagos.listar_por_estado(2)
            Return listaCertPagados

        End Get
    End Property

    Public ReadOnly Property total As Decimal
        Get
            Return listaCertSinOrden.Sum(Function(s) s.monto)
        End Get
    End Property

    Public Function filtrar(filtro As String) As List(Of CertificadoSinOrden)
        Return listaCertSinOrden.FindAll(Function(c) c.constructor.ToLower().Contains(filtro))
    End Function

    Public Sub generarOrdenPago(certificado As CertificadoSinOrden)
        If certificado IsNot Nothing Then
            If daoPagos.guardar(New Pago(certificado.cod_certificado, 1)) > 0 Then
                RaiseEvent actualizarLista()
            End If
        End If
    End Sub


    Public Event actualizarLista()

    Public Function actualizarOrden(pago As PagoConOrden) As Boolean
        pago.fecha_orden = Date.Now
        If daoPagos.modificar(pago, pago.cod_pago) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function pagarOrden(pago As PagoConOrden, forma_pago As Integer, num_cta_cheque As String) As Boolean
        pago.cod_forma_pago = forma_pago
        pago.cheque_cta = num_cta_cheque
        pago.fecha_pago = Date.Now
        pago.cod_estado = 2
        If daoPagos.modificar(pago, pago.cod_pago) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public ReadOnly Property sumaPagados As Decimal
        Get
            Return listaCertPagados.Sum(Function(s) s.monto)
        End Get
    End Property

    Public Function filtrarPagados(filtro As String) As List(Of PagoConOrden)
        Return listaCertPagados.FindAll(Function(c) c.constructor.ToLower().Contains(filtro))
    End Function
End Class
