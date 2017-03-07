Public Class Postulantes
    Dim WithEvents controlador As ControladorPersona
    Dim WithEvents alta As PostulantesAlta

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        controlador = New ControladorPersona()

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
    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        alta = New PostulantesAlta()
        alta.ShowDialog()
    End Sub

    Private Sub btn_pos_cerrar_Click(sender As Object, e As EventArgs) Handles btn_pos_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub actualizarLista() Handles alta.guardado, controlador.actualizar
        dgv_postulantes.DataSource = controlador.listaPostulantes
    End Sub

    Private Sub btn_pos_editar_Click(sender As Object, e As EventArgs) Handles btn_pos_editar.Click
        If dgv_postulantes.SelectedRows.Count = 1 Then
            Dim postu As Postulante = dgv_postulantes.SelectedRows(0).DataBoundItem
            If postu IsNot Nothing Then

                alta = New PostulantesAlta()

                With alta
                    .txtNombre.Text = postu.nombre
                    .txtApellido.Text = postu.apellido
                    .txt_pos_dni.Text = postu.nro_doc
                    .cmbTipoDoc.SelectedIndex = postu.cod_tipo_doc
                    .cmbEstado.SelectedIndex = postu.cod_estado_civil
                    .titulo.Text = "Editar"
                    .editar = True
                    .ShowDialog()
                End With
            End If
        End If

    End Sub

    Private Sub btn_pos_eliminar_Click(sender As Object, e As EventArgs) Handles btn_pos_eliminar.Click
        If dgv_postulantes.SelectedRows.Count = 1 Then
            Dim postu As Postulante = dgv_postulantes.SelectedRows(0).DataBoundItem
            If postu IsNot Nothing Then
                Dim result As Integer = MessageBox.Show("Esta seguro de eliminar a " + postu.apellido + ", " + postu.nombre, "Por favor confirme", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    controlador.eliminarPostulante(postu)
                End If
            Else
                MsgBox("Lo siento, pero para eliminar un registro primero debe seleccionarlo.")
            End If
        End If
    End Sub



End Class