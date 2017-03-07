Public Class ControladorCertificaciones
    Private daoCertificado As DaoCertificado
    Private daoBeneficirario As DaoBeneficiario
    Private daoObra As DaoObra

    Private _certificados As List(Of Certificado)
    Private _beneficiarios As List(Of Beneficiario)

    Public Sub New(cod_ben As Integer)
        daoCertificado = New DaoCertificado
        daoBeneficirario = New DaoBeneficiario
        daoObra = New DaoObra
        If cod_ben = 0 Then
            _beneficiarios = daoBeneficirario.listar()
        ElseIf cod_ben > 0 Then
            _beneficiarios = New List(Of Beneficiario)
            _beneficiarios.Add(daoBeneficirario.obtener(cod_ben))
        End If
        _certificados = daoCertificado.listar_by_ben(cod_ben)
    End Sub

    Public ReadOnly Property listaBeneficiarios As List(Of Beneficiario)
        Get
            Return _beneficiarios
        End Get
    End Property

    Public ReadOnly Property listaCertificados As List(Of Certificado)
        Get
            Return _certificados
        End Get
    End Property

    Public Function buscar_certificados_by_ben(cod_ben As Integer) As List(Of Certificado)
        _certificados = daoCertificado.listar_by_ben(cod_ben)
        Return _certificados
    End Function

    Public Function cod_ppto(cod_obra) As Integer
        Return daoObra.obtener(cod_obra).cod_ppto
    End Function

    Public Function Filtrar(Text As String) As List(Of Beneficiario)
        Return _beneficiarios.FindAll(Function(a) a.nro_doc.ToString.Contains(Text) Or
                                          a.nombre.ToString.ToLower.Contains(Text) Or a.apellido.ToString.ToLower.Contains(Text))
    End Function
End Class
