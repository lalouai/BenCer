Public Class Pagos

    Private Const REESTABLECER As String = "Reestablecer"
    Private Const PAGAR As String = "Pagar"


    Private WithEvents controlador As ControladorPagos

    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        controlador = New ControladorPagos()

        dgv_s_orden.AutoGenerateColumns = False
        dgv_pay_orden.AutoGenerateColumns = False
        dgv_pay_pagados.AutoGenerateColumns = False

        dgv_s_orden.DataSource = controlador.listaSinOrden
        dgv_pay_orden.DataSource = controlador.listaConOrden
        lbl_pay_total.Text = controlador.total.ToString("C2")

        dgv_pay_pagados.DataSource = controlador.listaPagados
        lbl_pagados_total.Text = controlador.sumaPagados.ToString("C2")

    End Sub

    Private Sub filtro(sender As Object, e As EventArgs) Handles tb_pay_filtro_sin.TextChanged
        dgv_s_orden.DataSource = controlador.filtrar(tb_pay_filtro_sin.Text)
        lbl_pay_total.Text = controlador.total.ToString("C2")
    End Sub

    Private Sub btn_gen_o_pago_Click(sender As Object, e As EventArgs) Handles btn_gen_o_pago.Click
        If dgv_s_orden.SelectedRows.Count = 1 Then
            controlador.generarOrdenPago(dgv_s_orden.SelectedRows(0).DataBoundItem)
        ElseIf dgv_s_orden.SelectedRows.Count > 1 Then
            MsgBox("Lo siento, sólo puedo procesar un certificdo a la vez" & vbCrLf & "Seleccione solo uno y vuelva a intentar")
        Else
            MsgBox("Por favor seleccione un certificado para generar la Orden de Pago")
        End If
    End Sub

    Private Sub actualizarLista() Handles controlador.actualizarLista
        dgv_s_orden.DataSource = controlador.listaSinOrden
        dgv_pay_orden.DataSource = controlador.listaConOrden
        dgv_pay_pagados.DataSource = controlador.listaPagados
    End Sub

    Private Sub dgv_Vencidas(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_pay_orden.RowPostPaint
        If e.RowIndex <= Me.dgv_pay_orden.RowCount - 1 Then
            Dim dgvRow As DataGridViewRow = Me.dgv_pay_orden.Rows(e.RowIndex)
            If dgvRow.DataBoundItem.estado = "vencida" Then
                dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54)
                dgvRow.Cells("accion").Value = REESTABLECER
            Else
                dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(129, 199, 132)
                dgvRow.Cells("accion").Value = PAGAR
            End If
        End If
    End Sub

    Private Sub botonClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles dgv_pay_orden.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If dgv_pay_orden.Rows(e.RowIndex).Cells("accion").Value = REESTABLECER Then
                If controlador.actualizarOrden(dgv_pay_orden.Rows(e.RowIndex).DataBoundItem) Then
                    dgv_pay_orden.DataSource = controlador.listaConOrden
                End If
            ElseIf dgv_pay_orden.Rows(e.RowIndex).Cells("accion").Value = PAGAR Then
                Dim modoPago As ModoPago = New ModoPago()
                If modoPago.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    If controlador.pagarOrden(dgv_pay_orden.Rows(e.RowIndex).DataBoundItem,
                                           modoPago.forma_pago, modoPago.num_cta_cheque) Then
                        actualizarLista()
                    End If
                End If
            Else
                MsgBox("Lo siento, no entiendo ese comando")
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles filtrar_pagados.TextChanged
        dgv_pay_pagados.DataSource = controlador.filtrarPagados(filtrar_pagados.Text)
        If filtrar_pagados.Text.Length > 0 Then
            lbl_titulo_total.Text = "SubTotal"
            Dim listaFiltrada = DirectCast(dgv_pay_pagados.DataSource, List(Of PagoConOrden))
            lbl_pagados_total.Text = listaFiltrada.Sum(Function(s) s.monto).ToString("C2")
        Else
            lbl_titulo_total.Text = "Total"
            lbl_pagados_total.Text = controlador.sumaPagados
        End If
    End Sub
End Class