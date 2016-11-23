Public Class Parentezco

    Private _cod_parentezco As Integer
    Private _descripcion As String

    Public Sub New(_cod_parentezco As Integer, _descripcion As String)
        Me._cod_parentezco = _cod_parentezco
        Me._descripcion = _descripcion
    End Sub

    Public ReadOnly Property cod_parentezco As Integer
        Get
            Return _cod_parentezco
        End Get
    End Property

    Public ReadOnly Property descripcion As String
        Get
            Return _descripcion
        End Get
    End Property
End Class
