Public Class Postulante
    Inherits Persona

    Private _cod_postulante As Integer
    Private _fecha_alta As Date

    Public Sub Postuante()

    End Sub

    Public Property cod_postulante As Integer
        Get
            Return _cod_postulante
        End Get
        Set(value As Integer)
            _cod_postulante = value
        End Set
    End Property


    Public Property fecha_alta As Date
        Get
            Return fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

End Class
