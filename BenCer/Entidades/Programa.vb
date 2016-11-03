Public Class Programa
    Private _cod_programa As Integer
    Private _nombre As String
    Private _expediente As String

    Public Property cod_programa As Integer
        Get
            Return _cod_programa
        End Get
        Set(value As Integer)
            _cod_programa = value
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

    Public Property expediente As String
        Get
            Return _expediente
        End Get
        Set(value As String)
            _expediente = value
        End Set
    End Property

    Public Sub Programa()

    End Sub
End Class
