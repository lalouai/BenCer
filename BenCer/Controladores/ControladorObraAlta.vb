Imports BenCer

Public Class ControladorObraAlta

    Private daoPostulante As DaoPostulante
    Private daoBeneficiario As DaoBeneficiario
    Private daoPrograma As DaoPrograma
    Private daoTipoObra As DaoTipoObra
    Private daoConstructor As DaoConstructor
    Private daoObra As DaoObra


    Private postulantes As List(Of Postulante)
    Private programas As List(Of Programa)
    Private constructores As List(Of Constructor)
    Private tipoObra As List(Of TipoObra)

    Public Sub New()

        daoPostulante = New DaoPostulante
        daoBeneficiario = New DaoBeneficiario
        daoConstructor = New DaoConstructor
        daoPrograma = New DaoPrograma
        daoTipoObra = New DaoTipoObra
        daoObra = New DaoObra

        programas = daoPrograma.listar()
        tipoObra = daoTipoObra.listar()
        constructores = daoConstructor.listar()

    End Sub

    Public Function listaPostulantes(ByVal termino As String) As List(Of Postulante)
        Return daoPostulante.listar_by("nro_doc", termino)
    End Function

    Public ReadOnly Property listaProgramas As List(Of Programa)
        Get
            Return programas
        End Get
    End Property

    Public ReadOnly Property listaTipoObra As List(Of TipoObra)
        Get
            Return tipoObra
        End Get
    End Property

    Public ReadOnly Property listaConstructores As List(Of Constructor)
        Get
            Return constructores
        End Get
    End Property


    Public Function altaBeneficiario(cod_persona As String) As Integer

        daoPostulante.eliminar(cod_persona)

        Dim cod_beneficiario = daoBeneficiario.guardar(cod_persona)
        If cod_beneficiario > 0 Then
            Return cod_beneficiario
        End If
        Return 0
    End Function

    Public Function altaObra(cod_beneficiario As Integer,
                             programa As String,
                             prototipo As String,
                             constructor As String,
                             fecha_inicio As String) As Integer



        Dim obra As Obra = New Obra
        With obra
            .cod_beneficiario = cod_beneficiario
            .cod_programa = listaProgramas.Find(Function(p) p.nombre = programa).cod_programa
            .cod_tipo_obra = listaTipoObra.Find(Function(p) p.descripcion = prototipo).cod_tipo_obra
            .cod_constructor = If(constructor IsNot Nothing,
                                  listaConstructores.Find(Function(p) p.nombre = constructor).cod_constructor,
                                  Nothing)
            .fecha_inicio = fecha_inicio
        End With

        Return daoObra.guardar(obra)

    End Function

    Public Sub actualizarObra(cod_obra As Integer,
                              cod_beneficiario As Integer,
                              programa As String,
                              prototipo As String,
                              constructor As String,
                              fecha_inicio As String)
        Dim obra As Obra = New Obra
        With obra
            .cod_obra = cod_obra
            .cod_beneficiario = cod_beneficiario
            .cod_programa = programa
            .cod_tipo_obra = prototipo
            .cod_constructor = constructor
            .fecha_inicio = fecha_inicio
            .fecha_fin = Nothing
        End With

        If daoObra.modificar(obra, obra.cod_obra) = 1 Then
            RaiseEvent cerrarVentana()
        Else
            RaiseEvent error_()
        End If
    End Sub


    Public Event cerrarVentana()
    Public Event error_()


End Class
