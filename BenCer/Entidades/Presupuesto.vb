Friend Class Presupuesto

    Private _cod_ppto As Integer
    Private _tipo_obra As TipoObra
    Private _fecha_alta As Date
    Private _items As List(Of RenglonPpto)

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

    Public WriteOnly Property tipo_obra As TipoObra
        Set(value As TipoObra)
            _tipo_obra = value
        End Set
    End Property

    Public ReadOnly Property tipoObra As String
        Get
            Return _tipo_obra.descripcion
        End Get
    End Property

    Public ReadOnly Property codTipoObra As Integer
        Get
            Return _tipo_obra.cod_tipo_obra
        End Get
    End Property

    Public Sub agregarRenglon(ByVal renglon As RenglonPpto)
        _items.Add(renglon)
    End Sub

    Public Function obtenerRenglon(ByVal idx As Integer) As RenglonPpto
        Return _items(idx)
    End Function



End Class
