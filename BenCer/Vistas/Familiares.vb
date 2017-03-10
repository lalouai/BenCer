Public Class Familiares

    Private controladorF As ControladorFamiliares
    Private WithEvents controlador As ControladorPersona
    Private cod_persona As Integer
    Private edit As Boolean

    Public Sub New(cod_persona As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        controladorF = New ControladorFamiliares(cod_persona)
        controlador = New ControladorPersona()

        Me.cod_persona = cod_persona
        edit = False

        txt_fam_apellido.Enabled = False
        txt_fam_nombre.Enabled = False
        cmb_fam_estado_civil.Enabled = False
        cmb_fam_parentezco.Enabled = False
        btn_fam_agregar.Enabled = False

        lbl_fam_persona_nombre.Text = StrConv(controladorF.jefe_flia, VbStrConv.ProperCase)

        cmb_fam_estado_civil.Items.Insert(0, "Seleccione")
        For Each item In controladorF.listaEstadosCivil.ToArray
            cmb_fam_estado_civil.Items.Insert(item.cod_estado_civil, item.estado_civil)
        Next
        cmb_fam_estado_civil.SelectedIndex = 0
        cmb_fam_parentezco.Items.Insert(0, "Seleccione")
        For Each item In controladorF.listaParentezcos.ToArray
            cmb_fam_parentezco.Items.Insert(item.cod_parentezco, item.descripcion)
        Next
        cmb_fam_parentezco.SelectedIndex = 0

        cmb_fam_tipo_doc.Items.Insert(0, "Seleccione")
        For Each item In controladorF.listaTipoDoc.ToArray
            cmb_fam_tipo_doc.Items.Insert(item.cod_tipo_doc, item.descripcion)
        Next
        cmb_fam_tipo_doc.SelectedIndex = 0

        dgv_familiares.AutoGenerateColumns = False
        dgv_familiares.DataSource = controladorF.listaFamiliares



    End Sub

    Private Sub habilitar(estado As Boolean)
        txt_fam_apellido.Enabled = estado
        txt_fam_nombre.Enabled = estado
        cmb_fam_estado_civil.Enabled = estado
        cmb_fam_parentezco.Enabled = estado
        btn_fam_agregar.Enabled = estado
    End Sub


    Private Sub btn_fam_agregar_Click(sender As Object, e As EventArgs) Handles btn_fam_agregar.Click

        If cmb_fam_tipo_doc.SelectedIndex = 0 Then
            texto_error("Seleccione el tipo de documento por favor")
            Exit Sub
        End If

        If cmb_fam_estado_civil.SelectedIndex = 0 Then
                texto_error("Seleccione el estado civil por favor")
                Exit Sub
            End If

            If cmb_fam_parentezco.SelectedIndex = 0 Then
                texto_error("Seleccione el parentezco por favor")
                Exit Sub
            End If

            If txt_fam_nombre.Text.Trim.Length > 50 Then
                texto_error("El nombre no puede ser mayor que 50 caracteres, por favor utilice iniciales")
                Exit Sub
            End If

            If txt_fam_apellido.Text.Trim.Length > 50 Then
                texto_error("El apellido no puede ser mayor que 50 caracteres, por favor utilice iniciales")
                Exit Sub
            End If

            If txt_fam_nombre.Text.Trim() IsNot "" Then
                If txt_fam_apellido.Text.Trim() IsNot "" And txt_fam_apellido.Text.Trim.Length > 2 Then

                If Not edit Then

                    controlador.crearFamiliar(txt_fam_dni.Text,
                                              txt_fam_nombre.Text,
                                              txt_fam_apellido.Text,
                                              cmb_fam_tipo_doc.SelectedIndex,
                                              cmb_fam_estado_civil.SelectedIndex,
                                              cmb_fam_parentezco.SelectedIndex,
                                              Me.cod_persona)
                Else

                    controlador.actualizarFamiliar(txt_fam_dni.Text,
                                              txt_fam_nombre.Text,
                                              txt_fam_apellido.Text,
                                              cmb_fam_tipo_doc.SelectedIndex,
                                              cmb_fam_estado_civil.SelectedIndex,
                                              cmb_fam_parentezco.SelectedIndex,
                                              Me.cod_persona)

                    edit = False
                    habilitar(edit)

                End If
            Else
                    texto_error("Lo siento, el apellido no puede ser vacío")
                End If
            Else
                texto_error("Lo siento, el nombre no puede ser vacío")
            End If


    End Sub

    Private Sub actualizar_lista() Handles controlador.cerrar
        txt_fam_dni.Text = ""
        txt_fam_nombre.Text = ""
        txt_fam_apellido.Text = ""
        cmb_fam_tipo_doc.SelectedIndex = 0
        cmb_fam_estado_civil.SelectedIndex = 0
        cmb_fam_parentezco.SelectedIndex = 0
        dgv_familiares.DataSource = controladorF.listaFamiliares
    End Sub

    Private Sub btn_fam_editar_Click(sender As Object, e As EventArgs) Handles btn_fam_editar.Click

        If dgv_familiares.SelectedRows.Count = 1 Then
            Dim famil As Familiar = dgv_familiares.SelectedRows(0).DataBoundItem
            If famil IsNot Nothing Then
                edit = True
                habilitar(edit)
                btn_fam_agregar.Text = "Actualizar"

                txt_fam_nombre.Text = famil.nombre
                txt_fam_apellido.Text = famil.apellido
                txt_fam_dni.Text = famil.nro_doc
                cmb_fam_tipo_doc.SelectedIndex = famil.cod_tipo_doc
                cmb_fam_estado_civil.SelectedIndex = famil.cod_estado_civil
                cmb_fam_parentezco.SelectedIndex = famil.cod_parentezco

            End If
        Else
            MsgBox("Seleccione un pariente para editar")
        End If
    End Sub

    Private Sub btn_fam_eliminar_Click(sender As Object, e As EventArgs) Handles btn_fam_eliminar.Click
        If dgv_familiares.SelectedRows.Count = 1 Then
            Dim famil As Familiar = dgv_familiares.SelectedRows(0).DataBoundItem
            If famil IsNot Nothing Then
                controlador.eliminarFamiliar(famil.cod_persona)
            End If
        Else
            MsgBox("Seleccione un pariente para eliminar")
        End If
    End Sub

    Private Sub btn_fam_cerrar_Click(sender As Object, e As EventArgs) Handles btn_fam_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_fam_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_fam_dni.TextChanged
        If Not edit Then
            If Not controlador.checkDni(txt_fam_dni.Text) Then
                habilitar(False)
            Else
                habilitar(True)
            End If
        End If
    End Sub

    Private Sub texto_error(ByVal texto_error As String) Handles controlador.error_persona
        txt_fam_dni.BackColor = Color.LightCoral
        lbl_fam_error.Text = texto_error
        lbl_fam_error.Visible = True
    End Sub

    Private Sub dismiss_error() Handles controlador.error_dismiss
        txt_fam_dni.BackColor = Color.White
        lbl_fam_error.Visible = False
        lbl_fam_error.Text = ""
    End Sub

    Private Sub cmbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fam_tipo_doc.SelectedIndexChanged
        If cmb_fam_tipo_doc.SelectedIndex > 0 Then
            txt_fam_dni.Focus()
        End If
    End Sub

    Private Sub actualizar() Handles controlador.actualizar
        dgv_familiares.DataSource = controladorF.listaFamiliares()
    End Sub
End Class