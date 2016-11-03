Public Class Postulante
    Inherits Persona

    Private _fecha_alta As Date

    Public Sub Postuante()

    End Sub

    Public Property fecha_alta As Date
        Get
            Return fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

End Class
