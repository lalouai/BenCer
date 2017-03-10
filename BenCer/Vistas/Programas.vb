Public Class Programas

    Private WithEvents controlador As ControladorProgramas
    Dim modo As String
    Dim years As List(Of String)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorProgramas
        dgv_prg.AutoGenerateColumns = False
        dgv_prg.DataSource = controlador.listaProgramas
        Me.modo = "Agregar"
        years = New List(Of String)
        Dim anio = Date.Now.Year
        years.Add(anio - 1)
        years.Add(anio)
        years.Add(anio + 1)

        txt_prg_anio.Text = Date.Now.Year

    End Sub


    Private Sub btn_cons_editar_Click(sender As Object, e As EventArgs) Handles btn_prg_editar.Click
        If dgv_prg.SelectedRows.Count = 1 Then
            dismiss()
            Dim programa As Programa = dgv_prg.SelectedRows(0).DataBoundItem
            txt_prg_cod_programa.Text = programa.cod_programa
            txt_prg_nombre.Text = programa.nombre
            txt_prg_expediente.Text = programa.expediente.Split("-")(0)
            txt_prg_anio.Text = programa.expediente.Split("-")(1)
            modo = controlador.editar(programa)
        Else
            mostrarError("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        btn_prg_agregar.Text = modo
    End Sub

    Private Sub btn_cons_eliminar_Click(sender As Object, e As EventArgs) Handles btn_prg_eliminar.Click
        Dim prog As Programa
        Dim dt As List(Of Programa)
        If dgv_prg.SelectedRows.Count = 1 Then
            prog = dgv_prg.SelectedRows(0).DataBoundItem
        Else
            mostrarError("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim asignadas As Integer = controlador.programaAsignado(prog.cod_programa)

        If asignadas > 0 Then
            mostrarError("Lo siento, este programa tiene " & asignadas & " viviendas asociadas, no puede ser eliminado")
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

        Dim error_msg As List(Of String) = New List(Of String)

        If txt_prg_nombre.Text.Trim = "" Then
            error_msg.Add("nombre")
        End If

        If txt_prg_expediente.Text.Trim = "" Then
            error_msg.Add("expediente")
        End If

        If txt_prg_anio.Text.Trim = "" Then
            error_msg.Add("año")
        End If

        If Not IsNumeric(txt_prg_expediente.Text.Trim) Then
            error_msg.Add("NUM")
        End If


        If error_msg.Count > 0 Then
            Dim fin As String
            If error_msg.Count = 1 Then
                If error_msg(0).Equals("NUM") Then
                    fin = "expediente debe ser numérico"
                    error_msg.Clear()
                Else
                    fin = " no puede ser vacio"
                End If
            Else
                If error_msg(error_msg.Count - 1).Equals("NUM") Then
                    error_msg.Remove("NUM")
                    fin = " no pueden ser vacios y expediente debe ser numérico"
                Else
                    fin = " no pueden ser vacios"
                End If

            End If
            mostrarError("Lo siento pero " & String.Join(",", error_msg.ToArray()) & "," & fin)
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

        If modo.Equals("Agregar") Then
            fila.cod_programa = controlador.guardarItem(fila)
        ElseIf modo.Equals("Actualizar") Then

            If dgv_prg.SelectedRows.Count = 1 Then
                fila = dgv_prg.SelectedRows(0).DataBoundItem
                fila.nombre = nombre
                fila.expediente = expediente & "-" & anio
                controlador.actualizarItem(fila)
                modo = "Agregar"
            End If
        End If

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

    Private Sub actualizar() Handles controlador.actualizar
        dgv_prg.DataSource = controlador.listaProgramas
    End Sub

    Private Sub txt_prg_anio_TextChanged(sender As Object, e As EventArgs) Handles txt_prg_anio.TextChanged
        If txt_prg_anio.Text.Trim.Length = 4 Then
            If years.IndexOf(txt_prg_anio.Text.Trim) < 0 Then
                mostrarError("Lo siento, el año del expediente sólo puede ser el anterior, el corriente o el próximo" & vbCrLf &
                             "(" & String.Join(",", years.ToArray()) & ")")
            Else
                dismiss()
            End If
        Else
            dismiss()
        End If
    End Sub

    Private Sub mostrarError(texto As String)
        lbl_prg_error.Text = texto
        lbl_prg_error.Visible = True
    End Sub

    Private Sub dismiss()
        lbl_prg_error.Text = ""
        lbl_prg_error.Visible = False
    End Sub

    Private Sub dgv_seleccion() Handles dgv_prg.RowLeave
        Me.dismiss()
    End Sub

End Class