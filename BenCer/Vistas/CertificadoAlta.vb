Public Class CertificadoAlta
    Private WithEvents controlador As ControladorCertificacionesAlta
    Private inicio As Inicio

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
        If btn_cert_alta_cancelar.Text.Equals("Cancelar") Then
            Dim resultado As Integer = MessageBox.Show("Si cierra va a perder todo el trabajo, desea cerrar?", "Por favor confirme", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                controlador.eliminar()
                Me.Close()
            ElseIf resultado = DialogResult.No Then
                Exit Sub
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub txt_cert_alta_item_Lost_Focus(sender As Object, e As EventArgs) Handles txt_cert_alta_item.LostFocus
        txt_cert_alta_avance_ant.Text = controlador.avanceAnterior(txt_cert_alta_item.Text)
    End Sub

    Private Sub calcularSubTotal(sender As Object, e As EventArgs) Handles txt_cert_alta_avance.TextChanged
        If txt_cert_alta_avance.Text.Length > 0 Then

            Dim avPre As Decimal
            Dim av As Decimal

            Decimal.TryParse(txt_cert_alta_avance_ant.Text, avPre)
            Decimal.TryParse(txt_cert_alta_avance.Text, av)


            Dim subtotal As Decimal = avPre + av

            If subtotal > 100 Then
                lbl_cert_alta_error.Text = "La suma entre el avance anterior y el actual no puede superar el 100%"
                lbl_cert_alta_error.Visible = True
                btn_cert_alta_add_item.Enabled = False
                txt_cert_alta_subtotal.Text = ""

            Else
                btn_cert_alta_add_item.Enabled = True
                lbl_cert_alta_error.Visible = False
                txt_cert_alta_subtotal.Text = controlador.costo(txt_cert_alta_item.Text) * txt_cert_alta_avance.Text / 100
            End If
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

    Private Sub actualizar() Handles controlador.InsertedRenglon
        dgv_cert_alta_renglones.DataSource = Nothing
        dgv_cert_alta_renglones.DataSource = controlador.listaRCert
        lbl_cert_alta_monto_total.Text = controlador.total.ToString("C2")
        lbl_cert_alta_monto.Text = controlador.total_certificado.ToString("C2")
        lbl_cert_alta_porc_cert.Text = controlador.porcentaje_avance.ToString("P")
        limpiarFrom()
    End Sub

    Private Sub limpiarFrom()
        txt_cert_alta_avance.Text = ""
        txt_cert_alta_avance_ant.Text = ""
        txt_cert_alta_item.Text = ""
        txt_cert_alta_subtotal.Text = ""
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
        Dim monto As Decimal = CDec(lbl_cert_alta_monto.Text)
        If controlador.guardar(monto) > 0 Then
            If MessageBox.Show("Desea cerrar?", "Confirme", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_cert_alta_consolidar_Click(sender As Object, e As EventArgs) Handles btn_cert_alta_consolidar.Click
        If btn_cert_alta_cancelar.Text.Equals("Cerrar") Then
            Me.Close()
            Exit Sub
        End If
        Dim resultado = MessageBox.Show("Esta seguro que desea consolidar la certificacion?" & vbCrLf & "Una vez consolidada ya no podra modificarla",
                                        "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Dim monto As Decimal = CDec(lbl_cert_alta_monto.Text)
            controlador.guardar(monto)
            If controlador.consolidar() > 0 Then
                If MessageBox.Show("Desea imprimirlo ahora?", "Impresión", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    imprimir()
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub imprimir()
        Dim imprime As Imp_cert = New Imp_cert
        With imprime
            .lbl_imp_beneficiario.Text = lbl_cert_alta_beneficiario.Text
            .lbl_imp_monto.Text = lbl_cert_alta_monto.Text
            .lbl_imp_numero.Text = lbl_cert_alta_numero.Text
            .lbl_imp_porc_cert.Text = lbl_cert_alta_porc_cert.Text
            .lbl_imp_programa.Text = lbl_cert_alta_programa.Text
            .lbl_imp_tipo_obra.Text = lbl_cert_alta_tipo_obra.Text
            .lbl_imp_total.Text = lbl_cert_alta_monto_total.Text
            .dgv_imp_renglones.AutoGenerateColumns = False
            .dgv_imp_renglones.DataSource = dgv_cert_alta_renglones.DataSource
            .Show()
            .imprimir()
            .cerrar()
        End With
    End Sub
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim monto As Decimal = CDec(lbl_cert_alta_monto.Text)
        controlador.guardar(monto)
    End Sub
End Class