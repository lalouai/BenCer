Public Class ControladorFamiliares

    Private daoFamiliar As DaoFamiliar
    Private daoParentezco As DaoParentezco
    Private daoEstadoCivil As DaoEstadoCivil
    Private daoPersona As DaoPersona
    Private daoTipoDoc As DaoTipoDoc

    Private parentezcos As List(Of Parentezco)
    Private estados_civil As List(Of EstadoCivil)
    Private jefe_familia As Persona

    Public Sub New(cod_persona As Integer)
        daoFamiliar = New DaoFamiliar
        daoParentezco = New DaoParentezco
        daoEstadoCivil = New DaoEstadoCivil
        daoTipoDoc = New DaoTipoDoc
        daoPersona = New DaoPersona

        jefe_familia = daoPersona.obtener(cod_persona)

        Dim listaFamiliares As List(Of Familiar) = daoFamiliar.listar_por_persona(cod_persona)

    End Sub

    Public ReadOnly Property listaParentezcos As List(Of Parentezco)
        Get
            Return daoParentezco.listar()
        End Get
    End Property

    Public ReadOnly Property listaEstadosCivil As List(Of EstadoCivil)
        Get
            Return daoEstadoCivil.listar()
        End Get
    End Property

    Public ReadOnly Property jefe_flia As String
        Get
            Return jefe_familia.apellido & ", " & jefe_familia.nombre
        End Get
    End Property

    Public ReadOnly Property listaTipoDoc As List(Of TipoDocumento)
        Get
            Return daoTipoDoc.listar
        End Get
    End Property

    Public ReadOnly Property listaFamiliares As List(Of Familiar)
        Get
            Return daoFamiliar.listar_por_persona(jefe_familia.cod_persona)
        End Get
    End Property

End Class
