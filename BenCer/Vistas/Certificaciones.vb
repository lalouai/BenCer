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

    Private Sub imagen_en_boton(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgv_cert_certificados.CellPainting
        If dgv_cert_certificados.Columns(e.ColumnIndex).Name = "imprimir" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.ic_print_black_24dp_1x, CInt((e.CellBounds.Width / 2) - (My.Resources.ic_print_black_24dp_1x.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.ic_print_black_24dp_1x.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub dgv_cert_certificados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cert_certificados.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        Dim previo As Integer = e.ColumnIndex - 1
        Dim estado As String = dgv_cert_certificados.Rows(e.RowIndex).Cells(previo).Value
        If Not (String.IsNullOrEmpty(estado)) And estado.Equals("Consolidada") Then
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim imprime As Imp_cert = New Imp_cert

                Dim certificado As Certificado = senderGrid.Rows(e.RowIndex).DataBoundItem
                Dim _obra As Obra = controlador.getObraImprimir(certificado.cod_obra)

                With imprime
                    .lbl_imp_beneficiario.Text = _obra.beneficiario
                    .lbl_imp_monto.Text = certificado.monto.ToString("C2")
                    .lbl_imp_numero.Text = certificado.numero
                    .lbl_imp_porc_cert.Text = controlador.porcentaje_avance(certificado.monto).ToString("P")
                    .lbl_imp_programa.Text = _obra.programa
                    .lbl_imp_tipo_obra.Text = _obra.tipo_obra
                    .lbl_imp_total.Text = controlador.total.ToString("C2")
                    .dgv_imp_renglones.AutoGenerateColumns = False
                    .dgv_imp_renglones.DataSource = controlador.listarRenglonesCert(_obra.cod_obra, certificado.cod_certificado)
                    .Show()
                    .imprimir()
                    .cerrar()
                End With

            End If
        ElseIf Not (String.IsNullOrEmpty(estado)) And estado.Equals("En Proceso") Then
            Dim certificado As Certificado = dgv_cert_certificados.SelectedRows(0).DataBoundItem
            Dim ver As CertificadoAlta = New CertificadoAlta(certificado.cod_obra, controlador.cod_ppto(certificado.cod_obra))
            ver.ShowDialog()
        End If
    End Sub

    Private Sub btn_cert_ver_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_cert_filtrar_ben_TextChanged(sender As Object, e As EventArgs) Handles txt_cert_filtrar_ben.TextChanged
        dgv_cert_beneficiario.DataSource = controlador.Filtrar(txt_cert_filtrar_ben.Text.ToLower)
    End Sub
End Class