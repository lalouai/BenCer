Public Class TipoObra

    Private _cod_tipo_obra As Integer
    Private _descripcion As String
    Private _fecha_alta As Date

    Public Sub TipoObra()
    End Sub

    Public Property cod_tipo_obra As Integer
        Get
            Return _cod_tipo_obra
        End Get
        Set(value As Integer)
            _cod_tipo_obra = value
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

    Public Property fecha_alta As Date
        Get
            Return _fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

End Class
