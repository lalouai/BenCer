Public Class Costos
    Private _total As Decimal
    Private _certificado As Decimal
    Private _pagado As Decimal

    Public Sub New()

    End Sub

    Public Property total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property certificado As Decimal
        Get
            Return _certificado
        End Get
        Set(value As Decimal)
            _certificado = value
        End Set
    End Property

    Public Property pagado As Decimal
        Get
            Return _pagado
        End Get
        Set(value As Decimal)
            _pagado = value
        End Set
    End Property
End Class
