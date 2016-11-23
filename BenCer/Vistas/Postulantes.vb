Public Class Postulantes
    Dim WithEvents controlador As ControladorPersona

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

        dgv_postulantes.AutoGenerateColumns = False
        dgv_postulantes.DataSource = controlador.listaPostulantes

        Dim btn As New DataGridViewButtonColumn()
        dgv_postulantes.Columns.Add(btn)
        btn.HeaderText = "Familiares"
        btn.Text = "Cargar Grupo"
        btn.Name = "btn"
        btn.Width = 100
        btn.UseColumnTextForButtonValue = True


    End Sub

    Private Sub cargarFlia(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_postulantes.CellClick
        If e.ColumnIndex = 4 Then
            Dim postu As Postulante = dgv_postulantes.Rows(e.RowIndex).DataBoundItem
            Dim cargasFamiliares As Familiares = New Familiares(postu.cod_persona)
            cargasFamiliares.ShowDialog()
        End If
    End Sub


    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_pos_dni.TextChanged
        If Not controlador.checkDni(txt_pos_dni.Text) Then
            txt_pos_dni.BackColor = Color.Red
        Else
            txt_pos_dni.BackColor = Color.White
        End If
    End Sub

    Private Sub texto_error(ByVal texto_error As String) Handles controlador.error_persona
        lbl_error.Text = texto_error
        lbl_error.Visible = True
    End Sub

    Private Sub dismiss_error() Handles controlador.error_dismiss
        lbl_error.Visible = False
        lbl_error.Text = ""
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        If txt_pos_dni.Text.Trim() IsNot "" And txtNombre.Text.Trim() IsNot "" And txtApellido.Text.Trim() IsNot "" Then
            controlador.crearPersona(txt_pos_dni.Text, txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedIndex, cmbEstado.SelectedIndex)
        End If
    End Sub

    Private Sub cerrar() Handles controlador.cerrar
        Me.Close()
    End Sub

    Private Sub cmbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoDoc.SelectedIndexChanged
        txt_pos_dni.Focus()
    End Sub



    Private Sub txt_dni_valida(sender As Object, e As EventArgs) Handles txt_pos_dni.LostFocus
        If Not controlador.existeDni(txt_pos_dni.Text) Then
            txt_pos_dni.BackColor = Color.LightCoral
        Else
            txt_pos_dni.BackColor = Color.White
        End If
    End Sub

    Private Sub btn_pos_cerrar_Click(sender As Object, e As EventArgs) Handles btn_pos_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_pos_editar_Click(sender As Object, e As EventArgs) Handles btn_pos_editar.Click

    End Sub

    Private Sub btn_pos_eliminar_Click(sender As Object, e As EventArgs) Handles btn_pos_eliminar.Click

    End Sub
End Class