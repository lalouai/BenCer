Public Class ObraAlta

    Private WithEvents controlador As ControladorObraAlta
    Private seleccionado As Boolean
    Private _cod_obra As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorObraAlta


        cmb_obra_alta_programa.Items.Insert(0, "Seleccione")
        For Each item In controlador.listaProgramas.ToArray
            cmb_obra_alta_programa.Items.Add(item.nombre)
        Next
        cmb_obra_alta_programa.SelectedIndex = 0

        cmb_obra_alta_prototipo.Items.Insert(0, "Seleccione")
        For Each item In controlador.listaTipoObra.ToArray
            cmb_obra_alta_prototipo.Items.Add(item.descripcion)
        Next
        cmb_obra_alta_prototipo.SelectedIndex = 0

        cmb_obra_alta_constructor.Items.Insert(0, "Seleccione")
        For Each item In controlador.listaConstructores.ToArray
            cmb_obra_alta_constructor.Items.Add(item.nombre)
        Next
        cmb_obra_alta_constructor.SelectedIndex = 0

        dgv_obra_alta_resultados.AutoGenerateColumns = False
        seleccionado = False

        Me.Width = 660

    End Sub

    Public WriteOnly Property cod_obra As Integer
        Set(value As Integer)
            _cod_obra = value
        End Set
    End Property


    Private Sub txt_obra_alta_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_obra_alta_dni.TextChanged

        lbl_obra_alta_ayuda.Visible = False
        dgv_obra_alta_resultados.DataSource = Nothing

        If txt_obra_alta_dni.Text = "" Then
            Me.Width = 660
        ElseIf txt_obra_alta_dni.Text.Length > 2 Then
            dgv_obra_alta_resultados.DataSource = controlador.listaPostulantes(sender.Text)
        End If

        If Not seleccionado And dgv_obra_alta_resultados.DataSource IsNot Nothing Then
            Me.Width = 1090
        Else
            Me.Width = 660
        End If


    End Sub



    Private Sub btn_obra_alta_cancelar_Click(sender As Object, e As EventArgs) Handles btn_obra_alta_cancelar.Click
        Dim result As Integer = MessageBox.Show("Desea cerrar y perder todas las modificaciones?", "Por favor confirme", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub dgv_obra_alta_resultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_obra_alta_resultados.CellContentClick

        Dim postulante As Postulante = dgv_obra_alta_resultados.SelectedRows(0).DataBoundItem
        txt_obra_alta_nombre.Text = postulante.nombre
        txt_obra_alta_apellido.Text = postulante.apellido
        txt_obra_alta_dni.Text = postulante.nro_doc
        txt_obra_alta_cod_persona.Text = postulante.cod_persona

        txt_obra_alta_dni.Enabled = False

        cmb_obra_alta_programa.Enabled = True
        cmb_obra_alta_prototipo.Enabled = True
        cmb_obra_alta_constructor.Enabled = True

        dgv_obra_alta_resultados.DataSource = Nothing

        Me.Width = 660

        btn_obra_alta_reiniciar.Visible = True

    End Sub

    Private Sub btn_obra_alta_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_obra_alta_reiniciar.Click
        txt_obra_alta_nombre.Text = ""
        txt_obra_alta_apellido.Text = ""
        txt_obra_alta_dni.Text = ""
        txt_obra_alta_cod_persona.Text = ""

        txt_obra_alta_dni.Enabled = True
        txt_obra_alta_dni.Focus()


        cmb_obra_alta_programa.Enabled = False
        cmb_obra_alta_prototipo.Enabled = False
        cmb_obra_alta_constructor.Enabled = False

        dgv_obra_alta_resultados.DataSource = Nothing
        btn_obra_alta_reiniciar.Visible = False
        Me.Width = 660
    End Sub

    Private Sub btn_obra_alta_crear_Click(sender As Object, e As EventArgs) Handles btn_obra_alta_crear.Click

        Dim programa = cmb_obra_alta_programa.SelectedItem.ToString
        Dim prototipo = cmb_obra_alta_prototipo.SelectedItem.ToString
        Dim constructor = cmb_obra_alta_constructor.SelectedItem.ToString
        Dim fecha_inicio = dtp_obra_alta_fecha_inicio.Value.ToString("yyyy-MM-dd")


        If btn_obra_alta_crear.Text.Equals("Crear") Then

            If cmb_obra_alta_prototipo.SelectedIndex > 0 And cmb_obra_alta_programa.SelectedIndex > 0 Then
                Dim cod_beneficiario = controlador.altaBeneficiario(txt_obra_alta_cod_persona.Text)
                If cod_beneficiario > 0 Then
                    If cmb_obra_alta_constructor.SelectedIndex = 0 Then
                        constructor = Nothing
                        fecha_inicio = Nothing
                    End If
                    If controlador.altaObra(cod_beneficiario, programa, prototipo, constructor, fecha_inicio) > 0 Then
                        Dim result As Integer = MessageBox.Show("La obra ha sido creada exitosamente." & vbCrLf & "Desea crear otra?", "Alta Exitosa!!", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            btn_obra_alta_reiniciar.PerformClick()
                        ElseIf result = DialogResult.No Then
                            Me.Close()
                        End If
                    End If
                End If
            Else
                MsgBox("Lo siento, pero tanto el programa" & vbCrLf &
                       "como el prototipo son datos requeridos" & vbCrLf &
                       "Por favor revise el formulario y vuelva a intentar")
                Exit Sub
            End If
        ElseIf btn_obra_alta_crear.Text.Equals("Guardar") Then

            programa = cmb_obra_alta_programa.SelectedValue
            prototipo = cmb_obra_alta_prototipo.SelectedValue
            constructor = cmb_obra_alta_constructor.SelectedValue

            If cmb_obra_alta_constructor.SelectedIndex > 0 Then
                controlador.actualizarObra(_cod_obra, txt_obra_alta_cod_persona.Text, programa, prototipo, constructor, fecha_inicio)
            End If
        End If

    End Sub

    Private Sub cmb_obra_alta_constructor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_obra_alta_constructor.SelectedIndexChanged

        If cmb_obra_alta_constructor.SelectedIndex > 0 Then
            dtp_obra_alta_fecha_inicio.Enabled = True
        Else
            dtp_obra_alta_fecha_inicio.Enabled = False
        End If
    End Sub

    Private Sub cerrar() Handles controlador.cerrarVentana
        Me.Close()
    End Sub
End Class