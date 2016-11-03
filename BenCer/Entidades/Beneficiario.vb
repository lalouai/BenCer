Public Class Beneficiario
    Inherits Persona

    Private _fecha_alta As Date

    Public Sub Beneficiario()
    End Sub

    Public Property fecha_alta As Date
        Get
            Return _fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

End Class
