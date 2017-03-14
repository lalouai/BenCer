Public Class ControladorProgramaDetalle
    Private daoObra As DaoObra
    Private daoPrograma As DaoPrograma
    Private _listaObras As List(Of Obra)

    Public Sub New()
        daoObra = New DaoObra
        daoPrograma = New DaoPrograma
        _listaObras = New List(Of Obra)
    End Sub

    Public ReadOnly Property listaProgramas As List(Of Programa)
        Get
            Dim lista As List(Of Programa) = New List(Of Programa)
            lista.Add(New Programa(0, "Seleccione un programa"))
            For Each _prg As Programa In daoPrograma.listar
                lista.Add(_prg)
            Next
            Return lista
        End Get
    End Property

    Public Function listaObras(cod_prg As Integer) As List(Of Obra)
        _listaObras = daoObra.listarObrasPorPrograma(cod_prg)
        Return _listaObras
    End Function

    Public ReadOnly Property cantEnEjecucion As String
        Get
            If _listaObras.Count > 0 Then
                Return _listaObras.Where(Function(x) x.fecha_fin Is Nothing).Count
            Else
                Return "Sin Datos"
            End If
        End Get
    End Property

    Public ReadOnly Property cantEnTerminada As String
        Get
            If _listaObras.Count > 0 Then
                Return _listaObras.Where(Function(x) x.fecha_fin IsNot Nothing).Count
            Else
                Return "Sin Datos"
            End If
        End Get
    End Property

End Class
