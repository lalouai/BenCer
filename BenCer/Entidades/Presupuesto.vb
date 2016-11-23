Public Class Presupuesto

    Private _cod_ppto As Integer
    Private _tipo_obra As String
    Private _cod_tipo_obra As Integer
    Private _fecha_alta As Date
    Private _items As List(Of RenglonPpto)
    Private _estado As Integer


    Public Sub Presupuesto()

    End Sub

    Public Property cod_ppto As Integer
        Get
            Return _cod_ppto
        End Get
        Set(value As Integer)
            _cod_ppto = value
        End Set
    End Property

    Public Property tipo_obra As String
        Get
            Return _tipo_obra
        End Get
        Set(value As String)
            _tipo_obra = value
        End Set
    End Property

    Public Property codTipoObra As Integer
        Get
            Return _cod_tipo_obra
        End Get
        Set(value As Integer)
            _cod_tipo_obra = value
        End Set
    End Property

    Public Sub agregarRenglon(ByVal renglon As RenglonPpto)
        _items.Add(renglon)
    End Sub

    Public Function obtenerRenglon(ByVal idx As Integer) As RenglonPpto
        Return _items(idx)
    End Function

    Public Property items As List(Of RenglonPpto)
        Get
            Return _items
        End Get
        Set(value As List(Of RenglonPpto))
            _items = value
        End Set
    End Property

    Public Property estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
End Class
