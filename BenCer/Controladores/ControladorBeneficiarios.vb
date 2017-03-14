Imports BenCer

Public Class ControladorBeneficiarios

    Private daoBeneficiario As DaoBeneficiario
    Private daoObra As DaoObra

    Private _beneficiarios As List(Of Beneficiario)
    Private _beneficiariosFinal As List(Of Beneficiario)

    Public Sub New()

        daoBeneficiario = New DaoBeneficiario
        daoObra = New DaoObra

    End Sub

    Public ReadOnly Property listaBEneficiarios As List(Of Beneficiario)
        Get
            _beneficiarios = daoBeneficiario.listar()
            Return _beneficiarios
        End Get
    End Property

    Public Function Filtrar(text As String) As List(Of Beneficiario)
        Return _beneficiarios.FindAll(Function(a) a.nro_doc.ToString.Contains(text) Or
                                          a.nombre.ToString.ToLower.Contains(text) Or a.apellido.ToString.ToLower.Contains(text))
    End Function

    Public Function obtenerObra(cod_beneficiario As Integer) As Obra
        Return daoObra.obtenerObraPorBen(cod_beneficiario)
    End Function

    Public Function listarBeneficiariosConFinal() As Object
        _beneficiarios = daoBeneficiario.listar_con_final
        Return _beneficiarios
    End Function
End Class
