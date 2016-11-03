Public Class Persona

    Private _cod_persona As Integer
    Private _cod_estado_civil As Integer
    Private _cod_tipo_doc As Integer

    Private _nro_doc As String
    Private _tipo_doc As String
    Private _nombre As String
    Private _apellido As String
    Private _estado_civil As String

    Public Sub Persona(ByVal cod_persona As Integer,
                       ByVal cod_estado_civil As Integer,
                       ByVal cod_tipo_doc As Integer,
                       ByVal nro_doc As String,
                       ByVal tipo_doc As String,
                       ByVal nombre As String,
                       ByVal apellido As String,
                       ByVal estado_civil As String)
        _cod_persona = cod_persona
        _cod_estado_civil = cod_estado_civil
        _cod_tipo_doc = cod_tipo_doc
        _tipo_doc = tipo_doc
        _nro_doc = nro_doc
        _nombre = nombre
        _apellido = apellido
        _estado_civil = estado_civil
    End Sub

    Public Sub Persona()

    End Sub


    Public Property cod_persona As Integer
        Get
            Return _cod_persona
        End Get
        Set(value As Integer)
            _cod_persona = value
        End Set
    End Property

    Public Property cod_estado_civil As Integer
        Get
            Return _cod_estado_civil
        End Get
        Set(value As Integer)
            _cod_estado_civil = value
        End Set
    End Property

    Public Property cod_tipo_doc As Integer
        Get
            Return _cod_tipo_doc
        End Get
        Set(value As Integer)
            _cod_tipo_doc = value
        End Set
    End Property

    Public Property tipo_doc As Integer
        Get
            Return _cod_persona
        End Get
        Set(value As Integer)
            _cod_persona = value
        End Set
    End Property

    Public Property nro_doc As Integer
        Get
            Return _nro_doc
        End Get
        Set(value As Integer)
            _nro_doc = value
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

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property estado_civil As String
        Get
            Return _estado_civil
        End Get
        Set(value As String)
            _estado_civil = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _nombre & " " & _apellido & ", " & _tipo_doc & " : " & _nro_doc
    End Function

End Class
