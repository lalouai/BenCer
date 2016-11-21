Public Class Presupuestos

    Private WithEvents controlador As ControladorPresupuestos
    Private daoTipoObra As DaoTipoObra
    Private grillas As List(Of DataGridView)
    Private WithEvents formulario As inner_tab
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorPresupuestos()
        Dim tab As TabPage
        TC.Alignment = TabAlignment.Left
        TC.ItemSize = New Size(150, 50)
        TC.SizeMode = TabSizeMode.Fixed

        grillas = New List(Of DataGridView)

        TC.TabPages.Clear()
        Dim indice As Integer = 0

        For Each obra As TipoObra In controlador.tiposObra
            tab = New TabPage
            indice = obra.cod_tipo_obra
            tab.Text = obra.descripcion
            tab.Tag = indice
            TC.TabPages.Add(tab)
            Dim ppto = controlador.pptoObra(obra.cod_tipo_obra)
            If Not ppto Is Nothing Then
                formulario = New inner_tab(ppto.items, ppto.cod_ppto)
                formulario.TopLevel = False
                formulario.Visible = True
                formulario.FormBorderStyle = FormBorderStyle.None

                TC.TabPages(indice - 1).Controls.Add(formulario)
            End If

        Next

        tab = New TabPage
        tab.Text = "Prototipos"
        TC.TabPages.Add(tab)
        TC.TabPages(TC.TabCount - 1).Controls.Add(crearGrilla())

    End Sub

    Private Function crearGrilla() As DataGridView

        Dim prototipos As DataGridView = New DataGridView()
        prototipos.Location = New Point(50, 50)
        prototipos.AutoGenerateColumns = True
        prototipos.AutoSize = True
        prototipos.DataSource = controlador.tiposObra

        Return prototipos
    End Function

    Private Sub guardarItem(ByVal r_ppto As RenglonPpto) Handles formulario.nuevo_item
        If Not r_ppto Is Nothing Then
            controlador.guardarItem(r_ppto)
        End If
    End Sub

    Private Sub modificarItem(ByVal r_ppto As RenglonPpto) Handles formulario.actualizar_item
        If Not r_ppto Is Nothing Then
            controlador.actualizarItem(r_ppto)
        End If
    End Sub

    Private Sub eliminarItem(ByVal cod As Integer) Handles formulario.eliminar_item
        If Not (cod = 0 Or cod = Nothing) Then
            controlador.eliminarItem(cod)
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

End Class