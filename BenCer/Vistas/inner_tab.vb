Public Class inner_tab

    Dim cod_ppto As Integer
    Dim modo As String


    Public Sub New(listado As List(Of RenglonPpto), cod_ppto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.cod_ppto = cod_ppto
        Me.modo = "agregar"
        With grilla
            .DataSource = listado
            .Columns("item").DataPropertyName = "item"
            .Columns("descripcion").DataPropertyName = "descripcion"
            .Columns("costo").DataPropertyName = "costo"
            .AutoGenerateColumns = False
        End With
        ordenar()
        actualizarTotal()

    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Dim item As String
        Dim subitem As String
        Dim descripcion As String
        Dim costo As Decimal
        Dim error_msg As String = ""

        If txt_costo.Text = "" Then
            error_msg += "costo ,"
        End If

        If txt_descripcion.Text = "" Then
            error_msg += "descripcion ,"
        End If

        If txt_item.Text = "" Then
            error_msg += "item ,"
        End If

        If txt_subitem.Text = "" Then
            error_msg += "subitem ,"
        End If

        If Not error_msg = "" Then
            MsgBox("Lo siento pero " & error_msg & " no puede ser vacio")
            Exit Sub
        End If

        item = txt_item.Text
        subitem = txt_subitem.Text
        descripcion = txt_descripcion.Text
        costo = txt_costo.Text
        Dim fila As RenglonPpto = New RenglonPpto
        With fila
            .cod_ppto = cod_ppto
            .item = item & "," & subitem
            .descripcion = descripcion
            .costo = costo
        End With
        Dim dt As List(Of RenglonPpto) = DirectCast(grilla.DataSource, List(Of RenglonPpto))
        If modo.Equals("agregar") Then
            dt.Add(fila)
            RaiseEvent nuevo_item(fila)
        ElseIf modo.Equals("actualizar") Then
            Dim r_ppto As RenglonPpto = dt.Find(Function(el) el.item = fila.item)
            dt.Remove(r_ppto)
            fila.cod_r_ppto = r_ppto.cod_r_ppto
            dt.Add(fila)
            RaiseEvent actualizar_item(fila)
        End If
        grilla.DataSource = Nothing
        grilla.DataSource = dt

        txt_item.Text = ""
        txt_subitem.Text = ""
        txt_descripcion.Text = ""
        txt_costo.Text = ""

        btn_agregar.Text = modo

        ordenar()
        actualizarTotal()

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        Dim r_ppto As RenglonPpto
        r_ppto = Nothing
        If grilla.SelectedRows.Count = 1 Then
            r_ppto = grilla.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder editarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
        End If

        If Not r_ppto Is Nothing Then
            txt_item.Text = r_ppto.item.Split(",")(0)
            txt_subitem.Text = r_ppto.item.Split(",")(1)
            txt_descripcion.Text = r_ppto.descripcion
            txt_costo.Text = r_ppto.costo
            txt_item.Enabled = False
            txt_subitem.Enabled = False
            Me.modo = "actualizar"
            btn_agregar.Text = modo
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim r_ppto As RenglonPpto
        If grilla.SelectedRows.Count = 1 Then
            r_ppto = grilla.SelectedRows(0).DataBoundItem
        Else
            MsgBox("Debe seleccionar una fila para poder eliminarla." & vbCrLf & "Por favor,seleccione una y vuelva a intentarlo.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Desea eliminar el ítem " & r_ppto.item & " del presupuesto?", "Por favor confirme", MessageBoxButtons.YesNo)


        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            Dim dt As List(Of RenglonPpto) = DirectCast(grilla.DataSource, List(Of RenglonPpto))
            dt.Remove(dt.Find(Function(el) el.item = r_ppto.item))
            RaiseEvent eliminar_item(r_ppto.cod_r_ppto)
            actualizarTotal()
            ordenar()
        End If

    End Sub

    Private Sub ordenar()
        Dim lista As List(Of RenglonPpto) = DirectCast(grilla.DataSource, List(Of RenglonPpto))
        lista.Sort(Function(x As RenglonPpto, y As RenglonPpto)
                       If x.item Is Nothing AndAlso y.item Is Nothing Then
                           Return 0
                       ElseIf x.item Is Nothing Then
                           Return -1
                       ElseIf y.item Is Nothing Then
                           Return 1
                       Else
                           Return x.item.CompareTo(y.item)
                       End If
                   End Function)
        grilla.DataSource = Nothing
        grilla.DataSource = lista
    End Sub

    Private Sub actualizarTotal()
        Dim lista As List(Of RenglonPpto) = DirectCast(grilla.DataSource, List(Of RenglonPpto))
        Dim total = lista.Sum(Function(renglon) renglon.costo)
        lbl_costo.Text = total
    End Sub

    '
    ' EVENTOS
    '

    Public Event nuevo_item(ByVal r_ppto As RenglonPpto)
    Public Event actualizar_item(ByVal r_ppto As RenglonPpto)
    Public Event eliminar_item(ByVal cod_r_ppto As Integer)


End Class