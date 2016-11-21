Imports System.Text.RegularExpressions

Public Class ControladorPersona

    Private daoEstadoCivil As DaoEstadoCivil
    Private daoPersona As DaoPersona
    Private daoPostulante As DaoPostulante
    Private daoBeneficiario As DaoBeneficiario
    Private daoFamiliar As DaoFamiliar
    Private daoTipoDoc As DaoTipoDoc
    Private tiposDoc As List(Of TipoDocumento)
    Private postulantes As List(Of Postulante)
    Private estadosCivil As List(Of EstadoCivil)

    Public Sub New()

        daoTipoDoc = New DaoTipoDoc()
        daoPersona = New DaoPersona()
        daoPostulante = New DaoPostulante()
        daoEstadoCivil = New DaoEstadoCivil()
        daoFamiliar = New DaoFamiliar()
        daoBeneficiario = New DaoBeneficiario()

        tiposDoc = daoTipoDoc.listar()
        estadosCivil = daoEstadoCivil.listar()
        postulantes = daoPostulante.listar()


    End Sub



    Public ReadOnly Property listaTipos As List(Of TipoDocumento)
        Get
            Return tiposDoc
        End Get
    End Property

    Public ReadOnly Property listaEstados As List(Of EstadoCivil)
        Get
            Return estadosCivil
        End Get
    End Property

    Public ReadOnly Property listaPostulantes As List(Of Postulante)
        Get
            Return postulantes
        End Get
    End Property

    Friend Function checkDni(text As String) As Boolean
        If Regex.IsMatch(text, "^[0-9 ]+$") Then
            RaiseEvent error_dismiss()
            Return True
        Else
            RaiseEvent error_persona("DNI Mal Formado")
            Return False
        End If
    End Function

    Friend Sub crearPersona(dni As String, nombre As String, apellido As String, tipoDoc As Integer, estadoCivil As Integer)

        Dim persona As New Persona

        persona.cod_tipo_doc = tipoDoc
        persona.nro_doc = dni
        persona.nombre = nombre
        persona.apellido = apellido
        persona.cod_estado_civil = estadoCivil

        daoPostulante.guardar(persona)

        RaiseEvent cerrar()

    End Sub

    Public Function existeDni(ByVal nro_doc As String) As Boolean

        Dim persona As Persona = daoPersona.existe(nro_doc)

        If persona IsNot Nothing Then

            Dim postulante As Postulante = Nothing
            Dim beneficiario As Beneficiario = Nothing
            Dim familiar As Familiar = Nothing

            postulante = daoPostulante.obtener_por_persona(persona.cod_persona)
            If postulante IsNot Nothing Then
                RaiseEvent error_persona("Lo siento el DNI que está tratando de ingresar" & vbCrLf & "ya se encuentra en el registro de postulantes")
                Return True
            End If

            beneficiario = daoBeneficiario.obtener_por_persona(persona.cod_persona)
            If beneficiario IsNot Nothing Then
                RaiseEvent error_persona("Lo siento el DNI que está tratando de ingresar" & vbCrLf & "ya es un beneficiario")
                Return True
            End If

            familiar = daoFamiliar.obtener_por_persona(persona.cod_persona)
            If familiar IsNot Nothing Then
                RaiseEvent error_persona("Lo siento el DNI que está tratando de ingresar" & vbCrLf & "es de una persona asociada a un grupo familiar" &
                                         vbCrLf & "por favor verifique su situación")
                Return True
            End If

        End If

        RaiseEvent error_dismiss()
        Return False

    End Function

    '''
    ''' EVENTOS
    ''' 

    Event error_persona(ByVal text As String)
    Event error_dismiss()
    Event cerrar()
End Class
