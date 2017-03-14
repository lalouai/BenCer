Public Class PostulantesAlta
    Dim WithEvents controlador As ControladorPersona
    Private _editar As Boolean
    Public Property editar As Boolean
        Get
            Return _editar
        End Get
        Set(value As Boolean)
            _editar = value
        End Set
    End Property

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorPersona()
        cmbTipoDoc.Items.Insert(0, "Seleccione")
        For Each item In controlador.listaTipos.ToArray
            cmbTipoDoc.Items.Insert(item.cod_tipo_doc, item.descripcion)
        Next
        cmbTipoDoc.SelectedIndex = 0
        cmbEstado.Items.Insert(0, "Seleccione")
        For Each item In controlador.listaEstados.ToArray
            cmbEstado.Items.Insert(item.cod_estado_civil, item.estado_civil)
        Next
        cmbEstado.SelectedIndex = 0
        editar = False

        Dim btn As New DataGridViewButtonColumn()
        btn.HeaderText = "Eliminar"
        btn.Text = "x"
        btn.Name = "btn_eliminar_familiar"
        btn.UseColumnTextForButtonValue = True

        With dgv_familiares
            .ColumnCount = 3
            .Columns(0).Name = "DNI"
            .Columns(0).Width = 75
            .Columns(1).Name = "Apellido"
            .Columns(2).Name = "Nombre"
            .Columns.Add(btn)
            .Columns(3).Width = 20
        End With
    End Sub

    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_pos_dni.TextChanged
        If Not controlador.checkDni(txt_pos_dni.Text) Then
            habilitarCampos(False)
        Else
            habilitarCampos(True)
        End If
    End Sub

    Private Sub habilitarCampos(validez As Boolean)
        txtApellido.Enabled = validez
        txtNombre.Enabled = validez
        cmbEstado.Enabled = validez
        btn_guardar.Enabled = validez
    End Sub

    Private Sub texto_error(ByVal texto_error As String) Handles controlador.error_persona
        txt_pos_dni.BackColor = Color.LightCoral
        lbl_error.Text = texto_error
        lbl_error.Visible = True
    End Sub

    Private Sub dismiss_error() Handles controlador.error_dismiss
        txt_pos_dni.BackColor = Color.White
        lbl_error.Visible = False
        lbl_error.Text = ""
    End Sub

    Private Sub cmbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs)
        txt_pos_dni.Focus()
    End Sub

    Private Sub btn_guardar_click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If editar Then
            If txt_pos_dni.Text.Trim() IsNot "" And txtNombre.Text.Trim() IsNot "" And txtApellido.Text.Trim() IsNot "" Then
                controlador.actualizarPersona(txt_pos_dni.Text, txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedIndex, cmbEstado.SelectedIndex)
                RaiseEvent guardado()
            Else
                texto_error("No pude actualizar, verifique la información e intente nuevamente")
            End If
        Else
            If cmbTipoDoc.SelectedIndex = 0 Then
                texto_error("Seleccione el tipo de documento por favor")
                Exit Sub
            End If


            If cmbEstado.SelectedIndex = 0 Then
                texto_error("Seleccione el estado civil por favor")
                Exit Sub
            End If

            If txtNombre.Text.Trim.Length > 50 Then
                texto_error("El nombre no puede ser mayor que 50 caracteres, por favor utilice iniciales")
                Exit Sub
            End If

            If txtApellido.Text.Trim.Length > 50 Then
                texto_error("El apellido no puede ser mayor que 50 caracteres, por favor utilice iniciales")
                Exit Sub
            End If

            If txtNombre.Text.Trim() IsNot "" Then
                If txtApellido.Text.Trim() IsNot "" And txtApellido.Text.Trim.Length > 2 Then
                    controlador.crearPostulante(txt_pos_dni.Text, txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedIndex, cmbEstado.SelectedIndex)
                    RaiseEvent guardado()
                Else
                    texto_error("Lo siento, el apellido no puede ser vacío")
                    End If
                Else
                    texto_error("Lo siento, el nombre no puede ser vacío")
                End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta seguro que desea salir? Perdera todos los cambios.", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_grupo_fliar_Click(sender As Object, e As EventArgs) Handles btn_grupo_fliar.Click
        If Me.Width = 560 Then
            Me.Width = 880
        Else
            Me.Width = 560
        End If
    End Sub

    Public Event guardado()
    Private Sub cerrar() Handles controlador.cerrar
        Me.Close()
    End Sub

    Private Sub dgv_familiares_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_familiares.CellValueChanged
        If e.ColumnIndex = 0 Then
            Dim fila = dgv_familiares.Rows().Item(e.RowIndex)
            If controlador.existeDni(fila.Cells(e.ColumnIndex).Value) Then
                fila.DefaultCellStyle.BackColor = Color.LightCoral
            Else
                fila.DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub dgv_familiares_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_familiares.CellClick
        If e.ColumnIndex = 3 Then
            If dgv_familiares.Rows(e.RowIndex).Cells(0).Value IsNot Nothing Then
                dgv_familiares.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub cmbTipoDoc_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbTipoDoc.SelectedIndexChanged
        If cmbTipoDoc.SelectedIndex > 0 Then
            txt_pos_dni.Focus()
        End If
    End Sub
End Class