Public Class ControladorPrototipos
    Private daoPrototipo As DaoTipoObra
    Private daoPpto As DaoPresupuesto

    Public Sub New()
        daoPrototipo = New DaoTipoObra
        daoPpto = New DaoPresupuesto
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
            RaiseEvent mostrarError("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        Return cod
    End Function

    Public Sub eliminarItem(cod As Integer)
        If Not daoPrototipo.verificarPpto(cod) Then
            daoPrototipo.eliminar(cod)
            RaiseEvent mostrarError("Eliminando...")
        Else
            RaiseEvent mostrarError("Lo siento, este prototipo no puede ser eliminado, posee un presupuesto consolidado" &
                                    vbCrLf & "Elimine primero el presupuesto asociado y vuelva a intentarlo")
        End If

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

    Public Function pptoAsociado(cod_proto As Integer) As Boolean
        If daoPpto.pptoAsociado(cod_proto) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub eliminarPptoAsociado(cod_proto As Object)
        If daoPrototipo.verificarPpto(cod_proto) Then
            RaiseEvent mostrarError("Eliminando el presupuesto asociado...")
            daoPpto.eliminarPptoCompleto(cod_proto)
        Else
            RaiseEvent mostrarError("El prototipo seleccionado no tiene un presupuesto asociado" &
                                    vbCrLf &
                                    "Seleccione otro para elimiar el presupuesto asociado o" &
                                    vbCrLf &
                                    "elimínelo directamente")
        End If
    End Sub


    Public Event mostrarError(txt As String)
    Public Event dismissError()


End Class
