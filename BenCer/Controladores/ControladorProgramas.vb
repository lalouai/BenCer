Imports BenCer


Public Class ControladorProgramas

    Private daoPrograma As DaoPrograma

    Public Sub New()
        daoPrograma = New DaoPrograma

    End Sub


    Public ReadOnly Property listaProgramas As List(Of Programa)
        Get
            Return daoPrograma.listar()
        End Get
    End Property

    Public Function editar(programa As Programa) As String
        If Not programa Is Nothing Then
            Return "Actualizar"
        End If
        Return "Agregar"
    End Function

    Public Sub eliminarItem(cod As Integer)
        daoPrograma.eliminar(cod)
        RaiseEvent actualizar()
    End Sub

    Public Function guardarItem(fila As Programa) As Integer
        Dim cod = daoPrograma.guardar(fila)
        If cod < 0 Then
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        RaiseEvent actualizar()
        Return cod
    End Function

    Public Sub actualizarItem(fila As Programa)
        daoPrograma.modificar(fila, fila.cod_programa)
        RaiseEvent actualizar()
    End Sub

    Public Function programaAsignado(cod As Integer) As Integer
        Return daoPrograma.asignado(cod)
    End Function

    Public Event actualizar()
End Class
