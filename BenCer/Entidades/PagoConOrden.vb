Public Class PagoConOrden
    Inherits Pago

    Private _constructor As String
    Private _cuit As String

    Sub New()
    End Sub

    Public Property constructor As String
        Get
            Return _constructor
        End Get
        Set(value As String)
            _constructor = value
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

    Public ReadOnly Property ver_forma As String
        Get
            Dim salida As String = Me.forma_pago
            If Me.cod_forma_pago = 1 Or Me.cod_forma_pago = 2 Then
                salida &= " ( "
                If Me.cod_forma_pago = 1 Then
                    salida &= "cta"
                ElseIf Me.cod_forma_pago = 2 Then
                    salida &= "cheque"
                End If
                salida &= " nro" & Me.cheque_cta & " )"
            End If
            Return salida
        End Get
    End Property

End Class
