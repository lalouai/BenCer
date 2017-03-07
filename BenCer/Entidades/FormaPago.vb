Public Class FormaPago
    Private _cod_forma_pago As Integer
    Private _forma_pago As String

    Public Sub New(_cod_forma_pago As Integer, _forma_pago As String)
        Me.cod_forma_pago = _cod_forma_pago
        Me.forma_pago = _forma_pago
    End Sub

    Public Property cod_forma_pago As Integer
        Get
            Return _cod_forma_pago
        End Get
        Set(value As Integer)
            _cod_forma_pago = value
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
End Class
