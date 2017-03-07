Public Class RenglonPpto

    Private _cod_r_ppto As Integer
    Private _cod_ppto As Integer
    Private _item As String
    Private _costo As Decimal
    Private _descripcion As String
    Private _incidencia As Decimal

    Public Sub RenglonPpto()
    End Sub

    Public Property cod_r_ppto As Integer
        Get
            Return _cod_r_ppto
        End Get
        Set(value As Integer)
            _cod_r_ppto = value
        End Set
    End Property

    Public Property cod_ppto As Integer
        Get
            Return _cod_ppto
        End Get
        Set(value As Integer)
            _cod_ppto = value
        End Set
    End Property

    Public Property item As String
        Get
            Return _item
        End Get
        Set(value As String)
            _item = value
        End Set
    End Property

    Public Property costo As Decimal
        Get
            Return _costo
        End Get
        Set(value As Decimal)
            _costo = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property incidencia As Decimal
        Get
            Return _incidencia / 100
        End Get
        Set(value As Decimal)
            _incidencia = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "cod_r_ppto->" & _cod_r_ppto & vbCrLf &
               "cod_ppto->" & _cod_ppto & vbCrLf &
               "item->" & _item & vbCrLf &
               "descripion->" & _descripcion & vbCrLf &
               "costo->" & _costo & vbCrLf
    End Function

End Class
