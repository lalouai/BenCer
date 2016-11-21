Imports BenCer

Public Class ControladorObras
    Private daoObra As DaoObra
    Private daoBeneficiario As DaoBeneficiario
    Private daoPrograma As DaoPrograma
    Private daoTipoObra As DaoTipoObra
    Private daoConstructor As DaoConstructor
    Private obras As List(Of Obra)

    Public Sub New()
        daoObra = New DaoObra()
        daoBeneficiario = New DaoBeneficiario()
        daoPrograma = New DaoPrograma()
        daoTipoObra = New DaoTipoObra()
        daoConstructor = New DaoConstructor()
        obras = daoObra.listar()
    End Sub


    Public ReadOnly Property listaObras As List(Of Obra)
        Get
            Return daoObra.listar()
        End Get
    End Property


    Public Sub editar(obra As Obra)



        Dim beneficiario As Beneficiario = daoBeneficiario.obtener(obra.cod_beneficiario)

        Dim formulario As ObraAlta = New ObraAlta()
        With formulario


            .cod_obra = obra.cod_obra
            .Size = New Size(660, 585)
            .lbl_obra_alta_titulo.Text = "Editar Obra"
            .btn_obra_alta_crear.Text = "Guardar"
            .txt_obra_alta_dni.Text = beneficiario.nro_doc
            .txt_obra_alta_dni.Enabled = False
            .txt_obra_alta_nombre.Text = beneficiario.nombre
            .txt_obra_alta_nombre.Enabled = False
            .txt_obra_alta_apellido.Text = beneficiario.apellido
            .txt_obra_alta_apellido.Enabled = False

            .txt_obra_alta_cod_persona.Text = beneficiario.cod_beneficiario

            .cmb_obra_alta_programa.DataSource = daoPrograma.listar()
            .cmb_obra_alta_programa.DisplayMember = "nombre"
            .cmb_obra_alta_programa.ValueMember = "cod_programa"
            .cmb_obra_alta_programa.SelectedValue = obra.cod_programa

            .cmb_obra_alta_prototipo.DataSource = daoTipoObra.listar()
            .cmb_obra_alta_prototipo.DisplayMember = "descripcion"
            .cmb_obra_alta_prototipo.ValueMember = "cod_tipo_obra"
            .cmb_obra_alta_prototipo.SelectedValue = obra.cod_tipo_obra


            Dim listaConstructores As List(Of Constructor) = daoConstructor.listar()
            listaConstructores.Insert(0, New Constructor("Seleccione un constructor", 0))

            .cmb_obra_alta_constructor.DataSource = listaConstructores
            .cmb_obra_alta_constructor.DisplayMember = "nombre"
            .cmb_obra_alta_constructor.ValueMember = "cod_constructor"
            .cmb_obra_alta_constructor.Enabled = True

        End With

        formulario.ShowDialog()
    End Sub

    Public Sub eliminarItem(cod As Integer)
        daoObra.eliminar(cod)
        obras = daoObra.listar()
    End Sub

    Public Function guardarItem(fila As Obra) As Integer
        Dim cod As Integer = 0
        cod = daoObra.guardar(fila)
        If cod <= 0 Then
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        Return cod
    End Function

    Public Sub actualizarItem(fila As Obra)
        daoObra.modificar(fila, fila.cod_programa)
    End Sub


End Class
