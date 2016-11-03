Public Class Certificado
    Private _cod_certificado As Integer
    Private _cod_tipo_obra As Integer
    Private _fecha_alta As Date
    Private _monto As Decimal

    Public Sub Certificado()

    End Sub
    Public Property cod_certificado As Integer
        Get
            Return _cod_certificado
        End Get
        Set(value As Integer)
            _cod_certificado = value
        End Set
    End Property

    Public Property cod_tipo_obra As Integer
        Get
            Return _cod_tipo_obra
        End Get
        Set(value As Integer)
            _cod_tipo_obra = value
        End Set
    End Property

    Public Property fecha_alta As Date
        Get
            Return _fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
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
End Class
