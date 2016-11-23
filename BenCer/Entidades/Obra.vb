Public Class Obra

    Private _cod_obra As Integer
    Private _cod_programa As Integer
    Private _cod_tipo_obra As Integer
    Private _cod_beneficiario As Integer
    Private _cod_constructor As Integer
    Private _cod_ppto As Integer
    Private _fecha_inicio As String
    Private _fecha_fin As String
    Private _programa As String
    Private _tipo_obra As String
    Private _beneficiario As String
    Private _constructor As String

    Public Property cod_obra As Integer
        Get
            Return _cod_obra
        End Get
        Set(value As Integer)
            _cod_obra = value
        End Set
    End Property

    Public Property cod_programa As Integer
        Get
            Return _cod_programa
        End Get
        Set(value As Integer)
            _cod_programa = value
        End Set
    End Property

    Public Property cod_tipo_obra As Integer
        Get
            Return _cod_tipo_obra
        End Get
        Set(value As Integer)
            _cod_tipo_obra = value
        End Set
    End Property

    Public Property cod_beneficiario As Integer
        Get
            Return _cod_beneficiario
        End Get
        Set(value As Integer)
            _cod_beneficiario = value
        End Set
    End Property

    Public Property cod_constructor As Integer
        Get
            Return _cod_constructor
        End Get
        Set(value As Integer)
            _cod_constructor = value
        End Set
    End Property

    Public Property programa As String
        Get
            Return _programa
        End Get
        Set(value As String)
            _programa = value
        End Set
    End Property

    Public Property tipo_obra As String
        Get
            Return _tipo_obra
        End Get
        Set(value As String)
            _tipo_obra = value
        End Set
    End Property

    Public Property beneficiario As String
        Get
            Return _beneficiario
        End Get
        Set(value As String)
            _beneficiario = value
        End Set
    End Property

    Public Property constructor As String
        Get
            Return _constructor
        End Get
        Set(value As String)
            _constructor = value
        End Set
    End Property

    Public Property fecha_inicio As String
        Get
            Return _fecha_inicio
        End Get
        Set(value As String)
            _fecha_inicio = value
        End Set
    End Property

    Public Property fecha_fin As String
        Get
            Return _fecha_fin
        End Get
        Set(value As String)
            _fecha_fin = value
        End Set
    End Property

    Public ReadOnly Property estado As String
        Get
            If fecha_inicio Is Nothing Then
                Return "S/Inicio"
            ElseIf fecha_inicio IsNot Nothing And fecha_fin Is Nothing Then
                Return "En curso"
            ElseIf fecha_inicio IsNot Nothing And fecha_fin IsNot Nothing Then
                Return "Terminada"
            End If
        End Get
    End Property

    Public Property cod_ppto As Integer
        Get
            Return _cod_ppto
        End Get
        Set(value As Integer)
            _cod_ppto = value
        End Set
    End Property
End Class
