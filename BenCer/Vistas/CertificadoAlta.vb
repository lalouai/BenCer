Public Class CertificadoAlta
    Private WithEvents controlador As ControladorCertificacionesAlta

    Public Sub New(ByVal cod_obra As Integer, ByVal cod_ppto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorCertificacionesAlta(cod_obra, cod_ppto)

        With txt_cert_alta_item
            .AutoCompleteCustomSource = controlador.listaAC
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .Visible = True
        End With

        lbl_cert_alta_beneficiario.Text = controlador.obra.beneficiario
        lbl_cert_alta_tipo_obra.Text = controlador.obra.tipo_obra
        lbl_cert_alta_programa.Text = controlador.obra.programa

        lbl_cert_alta_monto_total.Text = controlador.total.ToString("C2")
        lbl_cert_alta_monto.Text = controlador.total_certificado.ToString("C2")
        lbl_cert_alta_porc_cert.Text = controlador.porcentaje_avance.ToString("P")
        lbl_cert_alta_numero.Text = controlador.num_orden




        dgv_cert_alta_renglones.AutoGenerateColumns = False
        dgv_cert_alta_renglones.DataSource = controlador.listaRCert

        If controlador.estado = 1 Then
            bloquear()
        End If

    End Sub

    Private Sub btn_cert_alta_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_cancelar.Click
        Dim resultado As Integer = MessageBox.Show("Si cierra va a perder todo el trabajo, desea cerrar?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        ElseIf resultado = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub txt_cert_alta_item_Lost_Focus(sender As Object, e As EventArgs) Handles txt_cert_alta_item.LostFocus
        txt_cert_alta_avance_ant.Text = controlador.avanceAnterior(txt_cert_alta_item.Text)
    End Sub

    Private Sub txt_cert_alta_avance_Lost_Focus(sender As Object, e As EventArgs) Handles txt_cert_alta_avance.LostFocus

    End Sub

    Private Sub calcularSubTotal(sender As Object, e As EventArgs) Handles txt_cert_alta_avance.TextChanged
        If txt_cert_alta_avance.Text.Length > 0 Then

            Dim subtotal As Decimal = txt_cert_alta_avance_ant.Text + txt_cert_alta_avance.Text

            If subtotal > 100 Then
                lbl_cert_alta_error.Text = "La suma entre el avance anterior y el actual no puede superar el 100%"
                lbl_cert_alta_error.Visible = True
                btn_cert_alta_add_item.Enabled = False

            Else
                btn_cert_alta_add_item.Enabled = True
                lbl_cert_alta_error.Visible = False
            End If

            txt_cert_alta_subtotal.Text = controlador.costo(txt_cert_alta_item.Text) * txt_cert_alta_avance.Text / 100

        End If

    End Sub

    Public Sub bloquear() Handles controlador.bloquear
        btn_cert_alta_add_item.Enabled = False
        btn_cert_alta_guardar.Enabled = False
        btn_cert_alta_consolidar.Enabled = False
        txt_cert_alta_item.Enabled = False
        txt_cert_alta_avance.Enabled = False
        btn_cert_alta_cancelar.Text = "Cerrar"
    End Sub

    Private Sub btn_cert_alta_add_item_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_add_item.Click
        If txt_cert_alta_item.Text.Length > 0 And txt_cert_alta_avance.Text.Length > 0 Then
            controlador.CrearRenglon(txt_cert_alta_item.Text, txt_cert_alta_avance.Text, txt_cert_alta_avance_ant.Text)
        End If
    End Sub

    Private Sub actualizarLista() Handles controlador.InsertedRenglon
        dgv_cert_alta_renglones.DataSource = Nothing
        dgv_cert_alta_renglones.DataSource = controlador.listaRCert
    End Sub

    Private Sub btn_cert_alta_del_item_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_del_item.Click
        ' TODO
    End Sub

    Private Sub dgv_cert_alta_renglones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cert_alta_renglones.CellContentDoubleClick
        If dgv_cert_alta_renglones.SelectedRows.Count = 1 Then
            btn_cert_alta_add_item.Text = "Actualizar"
            btn_cert_alta_del_item.Visible = True

            Dim renglon As RenglonCertificado = dgv_cert_alta_renglones.SelectedRows(0).DataBoundItem

            txt_cert_alta_item.Text = renglon.denominacion
            txt_cert_alta_avance.Text = renglon.avance
            txt_cert_alta_avance_ant.Text = renglon.avance_anterior

        End If


    End Sub

    Private Sub btn_cert_alta_guardar_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_guardar.Click
        controlador.guardar(lbl_cert_alta_monto.Text)
    End Sub

    Private Sub btn_cert_alta_consolidar_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_consolidar.Click

        If btn_cert_alta_cancelar.Text.Equals("Cerrar") Then
            Me.Close()
            Exit Sub
        End If

        Dim resultado = MessageBox.Show("Esta seguro que desea consolidar la certificacion?" & vbCrLf & "Una vez consolidada ya no podra modificarla",
                                        "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            If controlador.consolidar() > 0 Then
                Me.Close()
            End If
        End If

    End Sub
End Class