Public Class ControladorConstructores

    Private daoConstructor As DaoConstructor
    Private daoCertificacion As DaoCertificado

    Private constructores As List(Of Constructor)

    Public Sub New()
        daoConstructor = New DaoConstructor
        daoCertificacion = New DaoCertificado

        constructores = daoConstructor.listar()

    End Sub

    Public ReadOnly Property listaConstructores As List(Of Constructor)
        Get
            Return constructores
        End Get
    End Property

    Public Function guardarItem(elemento As Constructor) As Integer
        Dim cod As Integer = 0
        cod = daoConstructor.guardar(elemento)
        If cod <= 0 Then
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        Return cod
    End Function

    Public Sub eliminarItem(cod As Integer)
        daoConstructor.eliminar(cod)
    End Sub

    Public Sub actualizarItem(elemento As Constructor)
        daoConstructor.modificar(elemento, elemento.cod_constructor)
    End Sub

    Public Function editar(formulario As Constructores, constructor As Constructor) As String
        If Not constructor Is Nothing Then
            formulario.txt_cons_cod_constructor.Text = constructor.cod_constructor
            formulario.txt_cons_nombre.Text = constructor.nombre
            formulario.txt_cons_cuit.Text = constructor.cuit
            Return "actualizar"
        End If
        Return "agregar"
    End Function

End Class
