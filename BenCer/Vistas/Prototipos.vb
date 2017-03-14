Public Class Prototipos

    Private WithEvents controlador As ControladorPrototipos
    Dim modo As String

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorPrototipos
        dvg_prototipo.AutoGenerateColumns = False
        dvg_prototipo.DataSource = controlador.listaPrototipos()
        Me.modo = "Agregar"
    End Sub

    Private Sub btn_prototipo_editar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_editar.Click
        If dvg_prototipo.SelectedRows.Count = 1 Then
            modo = controlador.editar(Me, dvg_prototipo.SelectedRows(0).DataBoundItem)
        Else
            mostrarError("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        btn_prototipo_agregar.Text = modo
    End Sub

    Private Sub btn_prototipo_eliminar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_eliminar.Click
        Dim proto As TipoObra
        If dvg_prototipo.SelectedRows.Count = 1 Then
            proto = dvg_prototipo.SelectedRows(0).DataBoundItem
        Else
            mostrarError("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Desea eliminar el Prototipo " & proto.descripcion & " del registro?", "Por favor confirme", MessageBoxButtons.YesNo)


        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            controlador.eliminarItem(proto.cod_tipo_obra)
        End If
        actualizar()
    End Sub

    Private Sub btn_cons_agregar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_agregar.Click
        Dim cod_prototipo As String
        Dim nombre As String
        Dim error_msg As String = ""
        If txt_prototipo_nombre.Text.Trim = "" Then
            error_msg += "nombre ,"
        End If
        If Not error_msg = "" Then
            mostrarError("Lo siento pero " & error_msg & " no puede ser vacio")
            Exit Sub
        End If
        cod_prototipo = txt_prototipo_cod_prototipo.Text.Trim
        nombre = txt_prototipo_nombre.Text.Trim
        Dim fila As TipoObra = New TipoObra
        With fila
            .descripcion = nombre
        End With

        If modo.Equals("Agregar") Then
            fila.cod_tipo_obra = controlador.guardarItem(fila)
        ElseIf modo.Equals("Actualizar") Then
            fila = dvg_prototipo.SelectedRows(0).DataBoundItem
            fila.descripcion = txt_prototipo_nombre.Text
            controlador.actualizarItem(fila)
            modo = "Agregar"
        End If
        actualizar()
        txt_prototipo_nombre.Text = ""
        txt_prototipo_cod_prototipo.Text = ""
        btn_prototipo_agregar.Text = modo

    End Sub

    Private Sub btn_prototipo_cerrar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_proto_cargar_ppto_Click(sender As Object, e As EventArgs) Handles btn_proto_cargar_ppto.Click
        If dvg_prototipo.SelectedRows.Count > 0 Then
            Dim cod_prototipo As Integer = DirectCast(dvg_prototipo.SelectedRows(0).DataBoundItem, TipoObra).cod_tipo_obra
            Dim presupuestador As Presupuestos = New Presupuestos(cod_prototipo)
            presupuestador.ShowDialog()
        Else
            mostrarError("Debe seleccionar una fila para poder ver o crear un presupuesto." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
    End Sub

    Private Sub btn_proto_liberar_ppto_Click(sender As Object, e As EventArgs) Handles btn_proto_liberar_ppto.Click
        If dvg_prototipo.SelectedRows.Count > 0 Then

            Dim proto As TipoObra = dvg_prototipo.SelectedRows(0).DataBoundItem

            If Not controlador.pptoAsociado(proto.cod_tipo_obra) Then
                mostrarError("No tiene obras asociadas")
                Dim aviso As String = "Esta seguro que desea eliminar el presupuesto asociado a " & proto.descripcion & "?" &
                                  vbCrLf &
                                  "Recuerde que esta acción no se puede deshacer"
                Dim resultado As Integer = MessageBox.Show(aviso, "Por favor confirme", MessageBoxButtons.YesNo)
                If resultado = DialogResult.Yes Then
                    controlador.eliminarPptoAsociado(proto.cod_tipo_obra)
                End If
            Else
                mostrarError("Lo siento, este presupuesto ya tiene obras, no se puede eliminar")
            End If
        Else
            mostrarError("Seleccione un prototipo para continuar")
        End If
    End Sub

    Private Sub actualizar()
        dvg_prototipo.DataSource = controlador.listaPrototipos
    End Sub

    Private Sub mostrarError(txt As String) Handles controlador.mostrarError
        lbl_prototipo_error.Text = txt
        lbl_prototipo_error.Visible = True
        dismisser.Enabled = True
    End Sub

    Private Sub dismissError() Handles controlador.dismissError
        lbl_prototipo_error.Visible = False
        lbl_prototipo_error.Text = ""
        dismisser.Enabled = False
    End Sub

    Private Sub dismisserEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles dismisser.Tick
        dismissError()
    End Sub


End Class