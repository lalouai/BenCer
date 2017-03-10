Public Class Obras
    Private controlador As ControladorObras
    Dim modo As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorObras
        dgv_obras.AutoGenerateColumns = False
        dgv_obras.DataSource = controlador.listaObras
        Me.modo = "agregar"

    End Sub

    Private Sub btn_obra_editar_Click(sender As Object, e As EventArgs) Handles btn_obra_editar.Click
        Dim obra As Obra
        obra = Nothing
        If dgv_obras.SelectedRows.Count = 1 Then
            obra = dgv_obras.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If

        If obra IsNot Nothing Then
            controlador.editar(obra)
        End If

        actualizar()

    End Sub


    Private Sub btn_obra_certificar_Click(sender As Object, e As EventArgs) Handles btn_obra_certificar.Click
        Dim obra As Obra
        obra = Nothing
        If dgv_obras.SelectedRows.Count = 1 Then
            obra = dgv_obras.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        If obra IsNot Nothing Then
            Dim certAlta As CertificadoAlta = New CertificadoAlta(obra.cod_obra, obra.cod_ppto)
            With certAlta
                .Show()
            End With
        End If
    End Sub

    Private Sub btn_obra_cerrar_Click(sender As Object, e As EventArgs) Handles btn_obra_cerrar.Click
        Dim result As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo de Obras?", "Por favor confirme", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_obra_ver_Click(sender As Object, e As EventArgs) Handles btn_obra_ver.Click
        Dim obra As Obra
        obra = Nothing
        If dgv_obras.SelectedRows.Count = 1 Then
            obra = dgv_obras.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If

        If obra IsNot Nothing Then
            controlador.ver(obra)
        End If
    End Sub

    Public Sub actualizar()
        dgv_obras.DataSource = controlador.listaObras
    End Sub
End Class