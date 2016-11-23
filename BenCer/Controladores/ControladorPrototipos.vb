Public Class ControladorPrototipos
    Private daoPrototipo As DaoTipoObra

    Private prototipos As List(Of TipoObra)

    Public Sub New()
        daoPrototipo = New DaoTipoObra

        prototipos = daoPrototipo.listar()

    End Sub

    Public ReadOnly Property listaPrototipos As List(Of TipoObra)
        Get
            Return prototipos
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
            Return "actualizar"
        End If
        Return "agregar"
    End Function
End Class
