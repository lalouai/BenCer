Public Class ProgramasDetalle

    Private WithEvents controlador As ControladorProgramaDetalle

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        controlador = New ControladorProgramaDetalle

        dvg_prg_det.AutoGenerateColumns = False

        cmb_prg_det_prog.DataSource = controlador.listaProgramas
        cmb_prg_det_prog.DisplayMember = "nombre"
        cmb_prg_det_prog.ValueMember = "cod_programa"

        lbl_prg_det_eje.Text = controlador.cantEnEjecucion
        lbl_prg_det_ter.Text = controlador.cantEnTerminada


    End Sub

    Private Sub cmb_prg_det_prog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_prg_det_prog.SelectedIndexChanged
        If cmb_prg_det_prog.SelectedIndex <> 0 Then
            dvg_prg_det.DataSource = controlador.listaObras(cmb_prg_det_prog.SelectedItem.cod_programa)
            lbl_prg_det_eje.Text = controlador.cantEnEjecucion
            lbl_prg_det_ter.Text = controlador.cantEnTerminada
        End If
    End Sub

    Private Sub btn_prg_det_Click(sender As Object, e As EventArgs) Handles btn_prg_det.Click
        Me.Close()
    End Sub
End Class