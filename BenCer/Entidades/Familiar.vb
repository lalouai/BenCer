Public Class Familiar
    Inherits Persona

    Private _fecha_alta As Date
    Private _cod_parentezco As Integer
    Private _parentezco As String

    Public Sub Familiar()
    End Sub

    Public Property fecha_alta As Date
        Get
            Return _fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

    Public Property cod_parentezco As Integer
        Get
            Return _cod_parentezco
        End Get
        Set(value As Integer)
            _cod_parentezco = value
        End Set
    End Property

    Public Property parentezco As String
        Get
            Return _parentezco
        End Get
        Set(value As String)
            _parentezco = value
        End Set
    End Property

End Class
