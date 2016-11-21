Imports BenCer


Public Class ControladorProgramas

    Private daoPrograma As DaoPrograma
    Private programas As List(Of Programa)

    Public Sub New()
        daoPrograma = New DaoPrograma
        programas = daoPrograma.listar()
    End Sub


    Public ReadOnly Property listaProgramas As List(Of Programa)
        Get
            Return programas
        End Get
    End Property


    Public Function editar(formulario As Programas, programa As Programa) As String
        If Not programa Is Nothing Then
            formulario.txt_prg_cod_programa.Text = programa.cod_programa
            formulario.txt_prg_nombre.Text = programa.nombre
            formulario.txt_prg_expediente.Text = programa.expediente.Split("-")(0)
            formulario.txt_prg_anio.Text = programa.expediente.Split("-")(1)
            Return "actualizar"
        End If
        Return "agregar"
    End Function

    Public Sub eliminarItem(cod As Integer)
        daoPrograma.eliminar(cod)
        programas = daoPrograma.listar()
    End Sub

    Public Function guardarItem(fila As Programa) As Integer
        Dim cod As Integer = 0
        cod = daoPrograma.guardar(fila)
        If cod <= 0 Then
            MsgBox("Lo siento ha ocurrido un error al guardar el ítem")
        End If
        Return cod
    End Function

    Public Sub actualizarItem(fila As Programa)
        daoPrograma.modificar(fila, fila.cod_programa)
    End Sub
End Class
