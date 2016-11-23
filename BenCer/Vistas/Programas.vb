Public Class Programas

    Private controlador As ControladorProgramas
    Dim modo As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorProgramas
        dgv_prg.AutoGenerateColumns = False
        dgv_prg.DataSource = controlador.listaProgramas
        Me.modo = "agregar"
        txt_prg_anio.Text = Date.Now.Year

    End Sub


    Private Sub btn_cons_editar_Click(sender As Object, e As EventArgs) Handles btn_prg_editar.Click
        If dgv_prg.SelectedRows.Count = 1 Then
            modo = controlador.editar(Me, dgv_prg.SelectedRows(0).DataBoundItem)
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        btn_prg_agregar.Text = modo
    End Sub

    Private Sub btn_cons_eliminar_Click(sender As Object, e As EventArgs) Handles btn_prg_eliminar.Click
        Dim prog As Programa
        Dim dt As List(Of Programa)
        If dgv_prg.SelectedRows.Count = 1 Then
            prog = dgv_prg.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Desea eliminar el programa " & prog.nombre & " del registro?", "Por favor confirme", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            dt = DirectCast(dgv_prg.DataSource, List(Of Programa))
            controlador.eliminarItem(prog.cod_programa)
            dgv_prg.DataSource = Nothing
            dgv_prg.DataSource = controlador.listaProgramas
        End If

    End Sub

    Private Sub btn_cons_agregar_Click(sender As Object, e As EventArgs) Handles btn_prg_agregar.Click
        Dim cod_programa As String
        Dim nombre As String
        Dim expediente As String
        Dim anio As String

        Dim error_msg As String = ""

        If txt_prg_nombre.Text = "" Then
            error_msg += "nombre ,"
        End If

        If txt_prg_expediente.Text = "" Then
            error_msg += "expediente ,"
        End If

        If txt_prg_anio.Text = "" Then
            error_msg += "año ,"
        End If

        If Not error_msg = "" Then
            MsgBox("Lo siento pero " & error_msg & " no puede ser vacio")
            Exit Sub
        End If

        cod_programa = txt_prg_cod_programa.Text.Trim
        nombre = txt_prg_nombre.Text.Trim
        expediente = txt_prg_expediente.Text.Trim
        anio = txt_prg_anio.Text.Trim

        Dim fila As Programa = New Programa
        With fila
            .nombre = nombre
            .expediente = expediente & "-" & anio
        End With

        Dim dt As List(Of Programa) = DirectCast(dgv_prg.DataSource, List(Of Programa))
        If modo.Equals("agregar") Then
            fila.cod_programa = controlador.guardarItem(fila)
            dt.Add(fila)
        ElseIf modo.Equals("actualizar") Then
            fila.cod_programa = cod_programa
            Dim programa As Programa = dt.Find(Function(el) el.cod_programa = fila.cod_programa)
            dt.Remove(programa)
            dt.Add(fila)
            controlador.actualizarItem(fila)
            modo = "agregar"
        End If

        dgv_prg.DataSource = Nothing
        dgv_prg.DataSource = dt

        txt_prg_nombre.Text = ""
        txt_prg_expediente.Text = ""
        txt_prg_cod_programa.Text = ""
        txt_prg_anio.Text = Date.Now.Year

        btn_prg_agregar.Text = modo

    End Sub

    Private Sub btn_prg_cerrar_Click(sender As Object, e As EventArgs) Handles btn_prg_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class