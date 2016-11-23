Public Class Certificaciones

    Private controlador As ControladorCertificaciones

    Public Sub New(cod_ben As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorCertificaciones(cod_ben)

        dgv_cert_beneficiario.AutoGenerateColumns = False
        dgv_cert_certificados.AutoGenerateColumns = False

        dgv_cert_beneficiario.DataSource = controlador.listaBeneficiarios
        dgv_cert_certificados.DataSource = controlador.listaCertificados

    End Sub

    Private Sub dgv_cert_beneficiario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cert_beneficiario.CellContentClick
        dgv_cert_certificados.DataSource = controlador.buscar_certificados_by_ben(sender.Rows(0).DataBoundItem.cod_beneficiario)
    End Sub

    Private Sub btn_cert_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cert_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_cert_certificados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cert_certificados.CellContentClick
        ' TODO
    End Sub

    Private Sub btn_cert_ver_Click(sender As Object, e As EventArgs) Handles btn_cert_ver.Click
        If dgv_cert_certificados.SelectedRows.Count > 0 Then
            Dim certificado As Certificado = dgv_cert_certificados.SelectedRows(0).DataBoundItem

            Dim ver As CertificadoAlta = New CertificadoAlta(certificado.cod_obra, controlador.cod_ppto(certificado.cod_obra))

            ver.ShowDialog()

        End If
    End Sub

    Private Sub txt_cert_filtrar_ben_TextChanged(sender As Object, e As EventArgs) Handles txt_cert_filtrar_ben.TextChanged
        dgv_cert_beneficiario.DataSource = controlador.Filtrar(txt_cert_filtrar_ben.Text.ToLower)
    End Sub
End Class