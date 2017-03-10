Public Class ControladorCertificaciones
    Private daoCertificado As DaoCertificado
    Private daoBeneficirario As DaoBeneficiario
    Private daoRenglonPpto As DaoRenglonPpto
    Private daoObra As DaoObra

    Private _certificados As List(Of Certificado)
    Private _beneficiarios As List(Of Beneficiario)

    Private _obra As Obra
    Private _ppto As Presupuesto
    Private _renglonesCertificado As List(Of RenglonCertificado)
    Private _items_ppto As List(Of RenglonPpto)

    Public Sub New(cod_ben As Integer)
        daoCertificado = New DaoCertificado
        daoBeneficirario = New DaoBeneficiario
        daoObra = New DaoObra
        daoRenglonPpto = New DaoRenglonPpto
        If cod_ben = 0 Then
            _beneficiarios = daoBeneficirario.listar()
        ElseIf cod_ben > 0 Then
            _beneficiarios = New List(Of Beneficiario)
            _beneficiarios.Add(daoBeneficirario.obtener(cod_ben))
        End If
        _certificados = daoCertificado.listar_by_ben(cod_ben)

        _obra = Nothing
        _ppto = Nothing
        _renglonesCertificado = Nothing
        _items_ppto = Nothing

    End Sub

    Public ReadOnly Property listaBeneficiarios As List(Of Beneficiario)
        Get
            Return _beneficiarios
        End Get
    End Property

    Public ReadOnly Property listaCertificados As List(Of Certificado)
        Get
            Return _certificados
        End Get
    End Property

    Public Function buscar_certificados_by_ben(cod_ben As Integer) As List(Of Certificado)
        _certificados = daoCertificado.listar_by_ben(cod_ben)
        Return _certificados
    End Function

    Public Function cod_ppto(cod_obra) As Integer
        Return daoObra.obtener(cod_obra).cod_ppto
    End Function

    Public Function Filtrar(Text As String) As List(Of Beneficiario)
        Return _beneficiarios.FindAll(Function(a) a.nro_doc.ToString.Contains(Text) Or
                                          a.nombre.ToString.ToLower.Contains(Text) Or a.apellido.ToString.ToLower.Contains(Text))
    End Function

    Public Function getObraImprimir(cod_obra As Integer) As Obra
        _obra = daoObra.obtener(cod_obra)
        _items_ppto = daoRenglonPpto.listar_ppto(_obra.cod_ppto)
        Return _obra
    End Function

    Public Function listarRenglonesCert(cod_obra As Integer, cod_cert As Integer) As List(Of RenglonCertificado)
        _renglonesCertificado = daoCertificado.listarRenglones(cod_obra, cod_cert)
        Return _renglonesCertificado
    End Function

    Public ReadOnly Property total_certificado As Decimal
        Get
            If _renglonesCertificado IsNot Nothing Then
                Return _renglonesCertificado.Sum(Function(p) p.subtotal)
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property total As Decimal
        Get
            If _items_ppto IsNot Nothing Then
                Return _items_ppto.Sum(Function(p) p.costo)
            Else
                Return 0
            End If
        End Get
    End Property

    Public Function porcentaje_avance(monto As Decimal) As Decimal
        If total <> 0 Then
            Return monto / total
        Else
            Return 0
        End If


    End Function

End Class
