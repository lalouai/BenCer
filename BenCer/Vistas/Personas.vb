Public Class Personas

    Dim WithEvents controlador As ControladorPersona

    Public Sub New(ByVal tab As Integer)
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

        TC.SelectedIndex = tab

        inicializar_dgv_postulantes(controlador.listaPostulantes)

    End Sub

    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_dni.TextChanged
        If Not controlador.checkDni(txt_dni.Text) Then
            txt_dni.BackColor = Color.Red
        Else
            txt_dni.BackColor = Color.White
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
        If txt_dni.Text.Trim() IsNot "" And txtNombre.Text.Trim() IsNot "" And txtApellido.Text.Trim() IsNot "" Then
            controlador.crearPersona(txt_dni.Text, txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedIndex, cmbEstado.SelectedIndex)
        End If
    End Sub

    Private Sub cerrar() Handles controlador.cerrar
        Me.Close()
    End Sub

    Private Sub cmbTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs)
        txt_dni.Focus()
    End Sub

    Private Sub inicializar_dgv_postulantes(ByVal lista As List(Of Postulante))

        With dgv_postulantes

            .DataSource = lista
            .AutoGenerateColumns = False
            .Columns(0).Name = "DNI"
            .Columns(0).DataPropertyName = "nro_doc"
            .Columns(1).Name = "Apellido"
            .Columns(1).DataPropertyName = "apellido"
            .Columns(2).Name = "Nombre"
            .Columns(2).DataPropertyName = "nombre"
            .Columns(3).Name = "Est. Civil"
            .Columns(3).DataPropertyName = "estado_civil"

        End With
    End Sub

    Private Sub txt_dni_valida(sender As Object, e As EventArgs) Handles txt_dni.LostFocus
        If Not controlador.existeDni(txt_dni.Text) Then
            txt_dni.BackColor = Color.LightCoral
        Else
            txt_dni.BackColor = Color.White
        End If
    End Sub
End Class