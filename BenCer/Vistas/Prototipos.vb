Public Class Prototipos

    Private controlador As ControladorPrototipos
    Dim modo As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorPrototipos
        dvg_prototipo.AutoGenerateColumns = False
        dvg_prototipo.DataSource = controlador.listaPrototipos()
        Me.modo = "agregar"

    End Sub

    Private Sub btn_prototipo_editar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_editar.Click
        If dvg_prototipo.SelectedRows.Count = 1 Then
            modo = controlador.editar(Me, dvg_prototipo.SelectedRows(0).DataBoundItem)
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        btn_prototipo_agregar.Text = modo
    End Sub

    Private Sub btn_prototipo_eliminar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_eliminar.Click
        Dim proto As TipoObra
        If dvg_prototipo.SelectedRows.Count = 1 Then
            proto = dvg_prototipo.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Desea eliminar el Prototipo " & proto.descripcion & " del registro?", "Por favor confirme", MessageBoxButtons.YesNo)


        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Dim dt As List(Of TipoObra) = DirectCast(dvg_prototipo.DataSource, List(Of TipoObra))
            dt.Remove(dt.Find(Function(el) el.cod_tipo_obra = proto.cod_tipo_obra))
            controlador.eliminarItem(proto.cod_tipo_obra)

        End If

    End Sub

    Private Sub btn_cons_agregar_Click(sender As Object, e As EventArgs) Handles btn_prototipo_agregar.Click
        Dim cod_prototipo As String
        Dim nombre As String

        Dim error_msg As String = ""

        If txt_prototipo_nombre.Text = "" Then
            error_msg += "nombre ,"
        End If

        If Not error_msg = "" Then
            MsgBox("Lo siento pero " & error_msg & " no puede ser vacio")
            Exit Sub
        End If

        cod_prototipo = txt_prototipo_cod_prototipo.Text.Trim
        nombre = txt_prototipo_nombre.Text.Trim

        Dim fila As TipoObra = New TipoObra
        With fila
            .descripcion = nombre
        End With

        Dim dt As List(Of TipoObra) = DirectCast(dvg_prototipo.DataSource, List(Of TipoObra))
        If modo.Equals("agregar") Then
            fila.cod_tipo_obra = controlador.guardarItem(fila)
            dt.Add(fila)
        ElseIf modo.Equals("actualizar") Then
            fila.cod_tipo_obra = cod_prototipo
            Dim prototipo As TipoObra = dt.Find(Function(el) el.cod_tipo_obra = fila.cod_tipo_obra)
            dt.Remove(prototipo)
            dt.Add(fila)
            controlador.actualizarItem(fila)
            modo = "agregar"
        End If

        dvg_prototipo.DataSource = Nothing
        dvg_prototipo.DataSource = dt

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
        Dim cod_prototipo As Integer = DirectCast(dvg_prototipo.SelectedRows(0).DataBoundItem, TipoObra).cod_tipo_obra
        Dim presupuestador As Presupuestos = New Presupuestos(cod_prototipo)
        presupuestador.ShowDialog()
    End Sub
End Class