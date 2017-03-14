Imports System.Text.RegularExpressions
Public Class Presupuestos

    Private WithEvents controlador As ControladorPresupuestos
    Private daoTipoObra As DaoTipoObra
    Private cod_r_ppto As Integer

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
            btn_ppto_imprimir_foja.Enabled = True
            btn_presu_cerrar.Enabled = True
        End If
        dvg_presupuesto.AutoGenerateColumns = False
        dvg_presupuesto.DataSource = controlador.listaItems
    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_presu_cerrar.Click

        Dim pregunta As String = ""

        If controlador.estado = 1 Then
            pregunta = "Está seguro que desea salir?"
        Else
            pregunta = "Está seguro que desea salir?" & vbCrLf & "Puede perder los cambios no guardados"
        End If

        Dim resultado As Integer = MessageBox.Show(pregunta, "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_presu_agregar_Click(sender As Object, e As EventArgs) Handles btn_presu_agregar.Click

        Dim item As String = txt_presu_item.Text.Trim
        Dim subitem As String = txt_presu_subitem.Text.Trim
        Dim descripcion As String = txt_presu_descripcion.Text.Trim
        Dim costo As Decimal
        Decimal.TryParse(If(txt_presu_costo_m_obra.Text.Equals(""), 0D, txt_presu_costo_m_obra.Text.Replace(".", ",")), costo)



        If item.Length = 0 Or Not Regex.IsMatch(item, "^[0-9]{1,3}$") Then
            mostrar_error("Lo siento el ítem no puede ser ni alfabético ni vacio ni tener símbolos")
            Exit Sub
        End If

        If subitem.Length = 0 Or Not Regex.IsMatch(subitem, "^[0-9]{1,3}$") Then
            mostrar_error("Lo siento el subítem no puede ser ni alfabético, ni vacio ni tener símbolos")
            Exit Sub
        End If

        If descripcion.Length = 0 Then
            mostrar_error("Lo siento la descripción no puede ser vacia")
            Exit Sub
        End If


        If btn_presu_agregar.Text.Equals("Agregar") Then
            If controlador.guardarItem(item, subitem, descripcion, costo) <= 0 Then
                mostrar_error("Lo siento ha ocurrido un error, por favor vuelva a intentar")
                Exit Sub
            End If
            txt_presu_item.Focus()
        ElseIf btn_presu_agregar.Text.Equals("Actualizar") Then
            If controlador.actualizarItem(item, subitem, descripcion, costo, cod_r_ppto) < 0 Then
                mostrar_error("Lo siento no he podido actualizar el registro, por favor vuelva a intentar")
                cod_r_ppto = Nothing
                Exit Sub
            End If
        End If
        actualizarLista()
    End Sub

    Private Sub btn_presu_consolidar_Click(sender As Object, e As EventArgs) Handles btn_presu_consolidar.Click
        If dvg_presupuesto.RowCount = 0 Then
            mostrar_error("Lo siento para consolidar un presupuesto al menos debe haber 1 item presupuestado")
            Exit Sub
        End If
        Dim resultado As Integer = MessageBox.Show("Está seguro que desea consolidarlo." & vbCrLf & "Una vez aceptado ya no podrá modificarlo.", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            If controlador.consolidar() > 0 Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btn_presu_eliminar_Click(sender As Object, e As EventArgs) Handles btn_presu_eliminar.Click
        If dvg_presupuesto.SelectedRows.Count = 1 Then
            controlador.eliminarItem(DirectCast(dvg_presupuesto.SelectedRows(0).DataBoundItem, RenglonPpto).cod_r_ppto)
            actualizarLista()
            dismiss_error()
        Else
            mostrar_error("Por favor, seleccione una fila para eliminar")
        End If
    End Sub

    Private Sub btn_presu_editar_Click(sender As Object, e As EventArgs) Handles btn_presu_editar.Click
        If dvg_presupuesto.SelectedRows.Count = 1 Then
            Dim r_ppto As RenglonPpto = New RenglonPpto
            r_ppto = dvg_presupuesto.SelectedRows(0).DataBoundItem
            txt_presu_item.Text = r_ppto.item.Split(".")(0)
            txt_presu_subitem.Text = r_ppto.item.Split(".")(1)
            txt_presu_descripcion.Text = r_ppto.descripcion
            txt_presu_costo_m_obra.Text = r_ppto.costo
            cod_r_ppto = r_ppto.cod_r_ppto
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
        Dim total As Double
        For index As Integer = 0 To dvg_presupuesto.RowCount - 1
            total += Convert.ToDouble(dvg_presupuesto.Rows(index).Cells(2).Value)
        Next
        lbl_presu_costo.Text = total.ToString("C2")

    End Sub

    Private Sub formateo(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dvg_presupuesto.CellFormatting
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            If e.Value = 0 Then
                e.Value = ""
            End If
        End If
    End Sub


    Private Sub mostrar_error(txt_error As String)
        lbl_presupuesto_error.Text = txt_error
        lbl_presupuesto_error.Visible = True
        dismisser.Enabled = True
    End Sub

    Private Sub dismiss_error() Handles dismisser.Tick
        dismisser.Enabled = False
        lbl_presupuesto_error.Visible = False
        lbl_presupuesto_error.Text = ""
    End Sub

    Private Sub item_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_presu_item.KeyDown, txt_presu_subitem.KeyDown
        If e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.OemPeriod Then
            e.SuppressKeyPress = True
            txt_presu_subitem.Focus()
        End If
    End Sub

    Private Sub btn_ppto_imprimir_foja_Click(sender As Object, e As EventArgs) Handles btn_ppto_imprimir_foja.Click
        Dim imprime As foja = New foja
        With imprime
            .lbl_imp_foja_tipo_obra.Text = controlador.tipoObra
            .dgv_imp_foja.AutoGenerateColumns = False
            .dgv_imp_foja.DataSource = controlador.listaItems
            .Show()
            .imprimir()
            .cerrar()
        End With
    End Sub

End Class