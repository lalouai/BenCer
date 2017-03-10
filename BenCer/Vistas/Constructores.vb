Public Class Constructores

    Private WithEvents controlador As ControladorConstructores
    Dim modo As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorConstructores
        dvg_cons.AutoGenerateColumns = False
        dvg_cons.DataSource = controlador.listaConstructores
        Me.modo = "agregar"

    End Sub

    Private Sub btn_cons_editar_Click(sender As Object, e As EventArgs) Handles btn_cons_editar.Click
        If dvg_cons.SelectedRows.Count = 1 Then
            dismissError()
            modo = controlador.editar(Me, dvg_cons.SelectedRows(0).DataBoundItem)
        Else
            mostrarError("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If
        btn_cons_agregar.Text = modo
    End Sub


    Private Sub btn_cons_eliminar_Click(sender As Object, e As EventArgs) Handles btn_cons_eliminar.Click
        Dim cons As Constructor
        If dvg_cons.SelectedRows.Count = 1 Then
            cons = dvg_cons.SelectedRows(0).DataBoundItem
            dismissError()
        Else
            mostrarError("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Desea eliminar el constructor " & cons.nombre & " del registro?", "Por favor confirme", MessageBoxButtons.YesNo)


        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            controlador.eliminarItem(cons.cod_constructor)
            actualizar()
        End If

    End Sub

    Private Sub btn_cons_agregar_Click(sender As Object, e As EventArgs) Handles btn_cons_agregar.Click
        Dim cod_constructor As String
        Dim nombre As String
        Dim cuit As String = txt_cons_cuit.Text.Trim

        Dim error_msg As List(Of String) = New List(Of String)

        If txt_cons_nombre.Text.Trim.Length = 0 Then
            error_msg.Add("Lo siento pero nombre , no puede ser vacio")
        End If

        If cuit.Length = 0 Then
            error_msg.Add("Lo siento pero cuit , no puede ser vacio")
        End If

        If Not IsNumeric(cuit) Or cuit.Length <> 11 Then
            error_msg.Add("Lo siento pero cuit mal formado, recuerde que " & vbCrLf & "el cuit incluye 11 cifras y debe escribirlo sin guiones")
        End If

        If Not error_msg.Count = 0 Then
            mostrarError(String.Join(vbCrLf, error_msg.ToArray))
            Exit Sub
        End If
        dismissError()
        cod_constructor = txt_cons_cod_constructor.Text.Trim
        nombre = txt_cons_nombre.Text.Trim
        cuit = txt_cons_cuit.Text.Trim

        Dim fila As Constructor = New Constructor
        With fila
            .nombre = nombre
            .cuit = cuit
        End With

        'Dim dt As List(Of Constructor) = DirectCast(dvg_cons.DataSource, List(Of Constructor))
        If modo.Equals("agregar") Then
            fila.cod_constructor = controlador.guardarItem(fila)
            '    dt.Add(fila)
        ElseIf modo.Equals("actualizar") Then
            fila.cod_constructor = cod_constructor
            '    Dim constructor As Constructor = dt.Find(Function(el) el.cod_constructor = fila.cod_constructor)
            '    dt.Remove(constructor)
            '    dt.Add(fila)
            controlador.actualizarItem(fila)
            modo = "agregar"
        End If

        txt_cons_nombre.Text = ""
        txt_cons_cuit.Text = ""
        txt_cons_cod_constructor.Text = ""

        btn_cons_agregar.Text = modo

        actualizar()

    End Sub

    Private Sub btn_cons_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cons_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mostrarError(txt As String) Handles controlador.mostrarError
        lbl_cons_error.Text = txt
        lbl_cons_error.Visible = True
    End Sub

    Private Sub dismissError() Handles controlador.dismissError
        lbl_cons_error.Visible = False
        lbl_cons_error.Text = ""
    End Sub

    Private Sub actualizar()
        dvg_cons.DataSource = controlador.listaConstructores
    End Sub


End Class



