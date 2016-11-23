Public Class RenglonCertificado

    Private _cod_r_certificado As Integer
    Private _cod_certificado As Integer
    Private _renglon_ppto As RenglonPpto
    Private _cod_r_ppto As Integer
    Private _avance As Decimal
    Private _avance_anterior As Decimal


    Public Sub RenglonCertificado()

    End Sub

    Public Property cod_r_certificado As Integer
        Get
            Return _cod_r_certificado
        End Get
        Set(value As Integer)
            _cod_r_certificado = value
        End Set
    End Property

    Public Property cod_certificado As Integer
        Get
            Return _cod_certificado
        End Get
        Set(value As Integer)
            _cod_certificado = value
        End Set
    End Property

    Public WriteOnly Property renglon_ppto As RenglonPpto
        Set(value As RenglonPpto)
            _renglon_ppto = value
        End Set
    End Property

    Public ReadOnly Property denominacion As String
        Get
            Return _renglon_ppto.descripcion
        End Get
    End Property

    Public ReadOnly Property item As String
        Get
            Return _renglon_ppto.item
        End Get
    End Property
    Public ReadOnly Property cod_item_ppto As Integer
        Get
            Return _renglon_ppto.cod_r_ppto
        End Get
    End Property

    Public Property avance_anterior As Decimal
        Get
            Return _avance_anterior
        End Get
        Set(value As Decimal)
            _avance_anterior = value
        End Set
    End Property

    Public Property avance As Decimal
        Get
            Return _avance / 100
        End Get
        Set(value As Decimal)
            _avance = value
        End Set
    End Property

    Public Property cod_r_ppto As Integer
        Get
            Return _cod_r_ppto
        End Get
        Set(value As Integer)
            _cod_r_ppto = value
        End Set
    End Property

    Public ReadOnly Property subtotal As Decimal
        Get
            Return _avance * _renglon_ppto.costo / 100
        End Get
    End Property

    Public ReadOnly Property avance_total As Decimal
        Get
            Return avance + avance_anterior
        End Get
    End Property
End Class
