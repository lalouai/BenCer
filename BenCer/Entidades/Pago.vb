Public Class Pago

    Private _cod_pago As Integer
    Private _cod_certificado As Integer
    Private _fecha_pago As Date
    Private _estado As String
    Private _forma_pago As String
    Private _cod_estado As Integer
    Private _cod_forma_pago As Integer
    Private _cheque_cta As String
    Private _monto As Decimal
    Private _fecha_orden As Date

    Public Sub New()

    End Sub

    Public Sub New(_cod_pago As Integer, _cod_certificado As Integer, _fecha_pago As Date, _estado As String, _forma_pago As String,
                   _cod_estado As Integer, _cod_forma_pago As Integer, _cheque_cta As String, _monto As Decimal, _fecha_orden As Date)
        Me.cod_pago = _cod_pago
        Me.cod_certificado = _cod_certificado
        Me.fecha_pago = _fecha_pago
        Me.estado = _estado
        Me.forma_pago = _forma_pago
        Me.cheque_cta = _cheque_cta
        Me.monto = _monto
        Me.cod_estado = _cod_estado
        Me.cod_forma_pago = _cod_forma_pago
        Me.Fecha_orden = _fecha_orden

    End Sub

    Public Sub New(_cod_certificado As Integer, _estado As Integer)
        Me.cod_pago = _cod_pago
        Me.cod_certificado = _cod_certificado
        Me.fecha_pago = _fecha_pago
        Me.estado = _estado
        Me.forma_pago = _forma_pago
        Me.cheque_cta = _cheque_cta
    End Sub

    Public Property cod_pago As Integer
        Get
            Return _cod_pago
        End Get
        Set(value As Integer)
            _cod_pago = value
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

    Public Property fecha_pago As Date
        Get
            Return _fecha_pago
        End Get
        Set(value As Date)
            _fecha_pago = value
        End Set
    End Property

    Public Property estado As String
        Get
            Dim hoy As Date = Date.Now
            Dim fecha As Date
            Date.TryParse(fecha_orden, fecha)
            If (hoy - fecha).TotalDays > 30 Then
                Return "vencida"
            Else
                Return _estado
            End If
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property forma_pago As String
        Get
            Return _forma_pago
        End Get
        Set(value As String)
            _forma_pago = value
        End Set
    End Property
    Public Property cod_estado As Integer
        Get
            Return _cod_estado
        End Get
        Set(value As Integer)
            _cod_estado = value
        End Set
    End Property

    Public Property cod_forma_pago As Integer
        Get
            Return _cod_forma_pago
        End Get
        Set(value As Integer)
            _cod_forma_pago = value
        End Set
    End Property
    Public Property cheque_cta As String
        Get
            Return _cheque_cta
        End Get
        Set(value As String)
            _cheque_cta = value
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

    Public Property fecha_orden As Date
        Get
            Return _fecha_orden
        End Get
        Set(value As Date)
            _fecha_orden = value
        End Set
    End Property

End Class
