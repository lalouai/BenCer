Public Class TipoDocumento
    Private _cod_tipo_doc As Integer
    Private _descripcion As String

    Public Sub New(ByVal cod_tipo_doc As Integer, ByVal descripcion As String)
        Me._cod_tipo_doc = cod_tipo_doc
        Me._descripcion = descripcion
    End Sub

    Public Property cod_tipo_doc As Integer
        Get
            Return _cod_tipo_doc
        End Get
        Set(value As Integer)
            _cod_tipo_doc = value
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
End Class
