Public Class Beneficiario
    Inherits Persona

    Private _cod_beneficiario As Integer
    Private _fecha_alta As Date

    Public Sub Beneficiario()
    End Sub

    Public Property cod_beneficiario As Integer
        Get
            Return _cod_beneficiario
        End Get
        Set(value As Integer)
            _cod_beneficiario = value
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
