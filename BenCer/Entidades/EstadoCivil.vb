Public Class EstadoCivil

    Private _cod_estado_civil As Integer
    Private _estado_civil As String

    Public Sub New(_cod_estado_civil As Integer, _estado_civil As String)
        Me._cod_estado_civil = _cod_estado_civil
        Me._estado_civil = _estado_civil
    End Sub

    Public ReadOnly Property cod_estado_civil
        Get
            Return _cod_estado_civil
        End Get
    End Property

    Public ReadOnly Property estado_civil
        Get
            Return _estado_civil
        End Get
    End Property

End Class
