Public Class ControladorPrototipos
    Private daoPrototipo As DaoTipoObra

    Public Sub New()
        daoPrototipo = New DaoTipoObra
    End Sub

    Public ReadOnly Property listaPrototipos As List(Of TipoObra)
        Get
            Return daoPrototipo.listar()
        End Get
    End Property

    Public Function guardarItem(elemento As TipoObra) As Integer
        Dim cod As Integer = 0
        cod = daoPrototipo.guardar(elemento)
        If cod <= 0 Then
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        Return cod
    End Function

    Public Sub eliminarItem(cod As Integer)

        daoPrototipo.eliminar(cod)
    End Sub

    Public Sub actualizarItem(elemento As TipoObra)
        daoPrototipo.modificar(elemento, elemento.cod_tipo_obra)
    End Sub

    Public Function editar(formulario As Prototipos, prototipo As TipoObra) As String
        If Not prototipo Is Nothing Then
            formulario.txt_prototipo_cod_prototipo.Text = prototipo.cod_tipo_obra
            formulario.txt_prototipo_nombre.Text = prototipo.descripcion
            Return "Actualizar"
        End If
        Return "Agregar"
    End Function

    Public Event mostrarError(txt As String)
    Public Event dismissError()

End Class
