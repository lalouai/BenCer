Public Class CertificadoSinOrden

    Private _cod_certificado As Integer
    Private _certificado As Integer
    Private _fecha As Date
    Private _monto As Decimal
    Private _constructor As String
    Private _beneficiario As String
    Private _cuit As String

    Public ReadOnly Property cod_certificado As Integer
        Get
            Return _cod_certificado
        End Get
    End Property

    Public Property certificado As Integer
        Get
            Return _certificado
        End Get
        Set(value As Integer)
            _certificado = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property monto As Decimal
        Get
            Return _monto
        End Get
        Set(value As Decimal)
            _monto = value
        End Set
    End Property

    Public Property constructor As String
        Get
            Return _constructor
        End Get
        Set(value As String)
            _constructor = value
        End Set
    End Property

    Public Property beneficiario As String
        Get
            Return _beneficiario
        End Get
        Set(value As String)
            _beneficiario = value
        End Set
    End Property

    Public Property cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property

    Public Sub New(_cod_certificado As Integer, _certificado As Integer, _fecha As Date, _monto As Decimal, _constructor As String, _beneficiario As String, _cuit As String)
        Me._cod_certificado = _cod_certificado
        Me._certificado = _certificado
        Me._fecha = _fecha
        Me._monto = _monto
        Me._constructor = _constructor
        Me._beneficiario = _beneficiario
        Me._cuit = _cuit
    End Sub

    Public Sub New()

    End Sub


End Class
