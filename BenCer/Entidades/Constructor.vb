Public Class Constructor
    Private _cod_constructor As Integer
    Private _nombre As String
    Private _cuit As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, cod_constructor As Integer)
        _cod_constructor = cod_constructor
        _nombre = nombre
    End Sub

    Public Property cod_constructor As Integer
        Get
            Return _cod_constructor
        End Get
        Set(value As Integer)
            _cod_constructor = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    Public Sub Constructor()

    End Sub
End Class
