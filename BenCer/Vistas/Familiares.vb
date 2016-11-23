Public Class Familiares

    Private controlador As ControladorFamiliares

    Public Sub New(cod_persona As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        controlador = New ControladorFamiliares(cod_persona)

        cmb_fam_parentezco.DataSource = controlador.listaParentezcos
        cmb_fam_parentezco.ValueMember = "cod_parentezco"
        cmb_fam_parentezco.DisplayMember = "descripcion"


        cmb_fam_estado_civil.DataSource = controlador.listaEstadosCivil
        cmb_fam_estado_civil.ValueMember = "cod_estado_civil"
        cmb_fam_estado_civil.DisplayMember = "descripcion"


    End Sub

    Private Sub btn_fam_agregar_Click(sender As Object, e As EventArgs) Handles btn_fam_agregar.Click

    End Sub

    Private Sub btn_fam_editar_Click(sender As Object, e As EventArgs) Handles btn_fam_editar.Click

    End Sub

    Private Sub btn_fam_eliminar_Click(sender As Object, e As EventArgs) Handles btn_fam_eliminar.Click

    End Sub

    Private Sub btn_fam_cerrar_Click(sender As Object, e As EventArgs) Handles btn_fam_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class