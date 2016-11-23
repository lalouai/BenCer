Public Class Presupuestos

    Private WithEvents controlador As ControladorPresupuestos
    Private daoTipoObra As DaoTipoObra
    Sub New(cod_tipo_obra As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorPresupuestos(cod_tipo_obra)

        lbl_presu_prototipo.Text = controlador.tipoObra
        lbl_presu_costo.Text = controlador.total.ToString("C2")
        If controlador.estado = 1 Then
            Dim ctrl As Control
            For Each ctrl In Me.Controls
                ctrl.Enabled = False
            Next
            lbl_presu_costo.Enabled = True
            lbl_presu_prototipo.Enabled = True
            lbl_presu_titulo.Enabled = True
            btn_presu_cerrar.Enabled = True
        End If
        dvg_presupuesto.AutoGenerateColumns = False
        dvg_presupuesto.DataSource = controlador.listaItems
    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_presu_cerrar.Click

        Dim resultado As Integer = MessageBox.Show("Está seguro que desea salir?" & vbCrLf & "Puede perder los cambios no guardados", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_presu_agregar_Click(sender As Object, e As EventArgs) Handles btn_presu_agregar.Click
        If txt_presu_item.Text.Length > 0 And
           txt_presu_subitem.Text.Length > 0 And
           txt_presu_descripcion.Text.Length > 0 And
           txt_presu_costo_m_obra.Text.Length > 0 Then

            If btn_presu_agregar.Text.Equals("Agregar") Then
                If controlador.guardarItem(txt_presu_item.Text, txt_presu_subitem.Text, txt_presu_descripcion.Text, txt_presu_costo_m_obra.Text) <= 0 Then
                    MsgBox("Lo siento ha ocurrido un error, por favor vuelva a intentar")
                    Exit Sub
                End If
            ElseIf btn_presu_agregar.Text.Equals("Actualizar") Then
                If controlador.actualizarItem(txt_presu_item.Text, txt_presu_subitem.Text, txt_presu_descripcion.Text, txt_presu_costo_m_obra.Text) <= 0 Then
                    MsgBox("Lo siento no he podido actualizar el registro, por favor vuelva a intentar")
                    Exit Sub
                End If
            End If
            actualizarLista()
        End If

    End Sub

    Private Sub btn_presu_consolidar_Click(sender As Object, e As EventArgs) Handles btn_presu_consolidar.Click
        Dim resultado As Integer = MessageBox.Show("Está seguro que desea consolidarlo." & vbCrLf & "Una vez aceptado ya no podrá modificarlo.", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            If controlador.consolidar() > 0 Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btn_presu_eliminar_Click(sender As Object, e As EventArgs) Handles btn_presu_eliminar.Click
        If dvg_presupuesto.SelectedRows.Count = 1 Then
            controlador.eliminarItem(DirectCast(dvg_presupuesto.SelectedRows(0).DataBoundItem, RenglonPpto).cod_ppto)
            actualizarLista()
        Else
            MsgBox("Por favor, seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub btn_presu_editar_Click(sender As Object, e As EventArgs) Handles btn_presu_editar.Click
        If dvg_presupuesto.SelectedRows.Count = 1 Then
            Dim r_ppto As RenglonPpto = New RenglonPpto
            r_ppto = dvg_presupuesto.SelectedRows(0).DataBoundItem
            txt_presu_item.Text = r_ppto.item.Split(",")(0)
            txt_presu_subitem.Text = r_ppto.item.Split(",")(1)
            txt_presu_descripcion.Text = r_ppto.descripcion
            txt_presu_costo_m_obra.Text = r_ppto.costo
            btn_presu_agregar.Text = "Actualizar"
        End If
    End Sub

    Private Sub actualizarLista()

        txt_presu_item.Text = ""
        txt_presu_subitem.Text = ""
        txt_presu_descripcion.Text = ""
        txt_presu_costo_m_obra.Text = ""

        dvg_presupuesto.DataSource = Nothing
        dvg_presupuesto.DataSource = controlador.listaItems
    End Sub

End Class