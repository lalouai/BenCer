Public Class Beneficiarios

    Private WithEvents controlador As ControladorBeneficiarios


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorBeneficiarios
        dvg_ben.AutoGenerateColumns = False

        dvg_ben.DataSource = controlador.listaBEneficiarios

        Dim btn_cert As New DataGridViewButtonColumn()
        dvg_ben.Columns.Add(btn_cert)
        btn_cert.HeaderText = "Certificar"
        btn_cert.Text = "Certificar"
        btn_cert.Name = "btn"
        btn_cert.Width = 100
        btn_cert.UseColumnTextForButtonValue = True

        Dim btn_obra As New DataGridViewButtonColumn()
        dvg_ben.Columns.Add(btn_obra)
        btn_obra.HeaderText = "Obra"
        btn_obra.Text = "Ver Obra"
        btn_obra.Name = "btn"
        btn_obra.Width = 100
        btn_obra.UseColumnTextForButtonValue = True

    End Sub
    Private Sub btn_ben_cerrar_Click(sender As Object, e As EventArgs) Handles btn_ben_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_ben_filtrar_TextChanged(sender As Object, e As EventArgs) Handles txt_ben_filtrar.TextChanged
        dvg_ben.DataSource = controlador.Filtrar(txt_ben_filtrar.Text.ToLower)
    End Sub

    Private Sub manejadorBotones(sender As System.Object, e As DataGridViewCellEventArgs) Handles dvg_ben.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        Dim ben As Beneficiario = dvg_ben.Rows(e.RowIndex).DataBoundItem
        Dim obra As Obra
        obra = controlador.obtenerObra(ben.cod_beneficiario)



        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                mostrarError("Certificar")

                If obra IsNot Nothing Then
                    Dim certAlta As CertificadoAlta = New CertificadoAlta(obra.cod_obra, obra.cod_ppto)
                    With certAlta
                        .Show()
                    End With
                End If
            ElseIf e.ColumnIndex = 4 Then
                mostrarError("Ver obra")

                If obra IsNot Nothing Then

                    Dim dCert As DaoCertificado = New DaoCertificado
                    Dim costos As Costos = New Costos
                    Dim formulario As ObraAlta = New ObraAlta()
                    Dim dPagos As DaoPago = New DaoPago()

                    With formulario
                        .dgv_obra_alta_pagos.AutoGenerateColumns = False
                        .cod_obra = obra.cod_obra
                        .Size = New Size(1100, 585)
                        .lbl_obra_alta_titulo.Text = "Ver Obra"
                        .btn_obra_alta_crear.Text = "Imprimir"
                        .btn_obra_alta_cancelar.Text = "Cerrar"
                        .txt_obra_alta_dni.Text = ben.nro_doc
                        .txt_obra_alta_dni.ReadOnly = True
                        .txt_obra_alta_nombre.Text = ben.nombre
                        .txt_obra_alta_nombre.ReadOnly = True
                        .txt_obra_alta_apellido.Text = ben.apellido
                        .txt_obra_alta_apellido.ReadOnly = True
                        .txt_obra_alta_cod_persona.Text = ben.cod_beneficiario
                        .cmb_obra_alta_programa.DataSource = New DaoPrograma().listar()
                        .cmb_obra_alta_programa.DisplayMember = "nombre"
                        .cmb_obra_alta_programa.ValueMember = "cod_programa"
                        .cmb_obra_alta_programa.SelectedValue = obra.cod_programa
                        .cmb_obra_alta_prototipo.DataSource = New DaoTipoObra().listar()
                        .cmb_obra_alta_prototipo.DisplayMember = "descripcion"
                        .cmb_obra_alta_prototipo.ValueMember = "cod_tipo_obra"
                        .cmb_obra_alta_prototipo.SelectedValue = obra.cod_tipo_obra

                        Dim listaConstructores As List(Of Constructor) = New DaoConstructor().listar()

                        .cmb_obra_alta_constructor.DataSource = listaConstructores
                        .cmb_obra_alta_constructor.DisplayMember = "nombre"
                        .cmb_obra_alta_constructor.ValueMember = "cod_constructor"
                        .cmb_obra_alta_constructor.Enabled = False
                        .dtp_obra_alta_fecha_inicio.Text = obra.fecha_inicio

                        .obra_avance.Visible = True
                        .grp_postulantes.Visible = False
                        .btn_obra_alta_crear.Visible = False

                        costos = dCert.costos(obra.cod_obra)

                        .obra_alta_costo_total.Text = costos.total.ToString("C2")
                        .obra_alta_avance_financiero.Text = costos.pagado.ToString("C2")
                        .obra_alta_avance_porcentual.Text = (costos.pagado / costos.total).ToString("P")

                        .grafico(costos.total, costos.pagado, costos.certificado)

                        .dgv_obra_alta_pagos.DataSource = dPagos.listar_por_obra(obra.cod_obra)

                    End With

                    formulario.ShowDialog()
                End If
            End If
        End If

    End Sub

    Private Sub mostrarError(txt As String)
        lbl_error_ben.Text = txt
        lbl_error_ben.Visible = True
        dismisser.Enabled = True
    End Sub

    Private Sub dismissError()
        lbl_error_ben.Visible = False
        lbl_error_ben.Text = ""
    End Sub

    Private Sub dismisserError() Handles dismisser.Tick
        dismisser.Enabled = False
        dismissError()
    End Sub

End Class