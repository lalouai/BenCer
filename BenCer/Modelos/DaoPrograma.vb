Imports BenCer

Public Class DaoPrograma
    Inherits DataManager
    Implements InterfaceDao(Of Programa)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Programa).eliminar
        Dim consulta As String
        consulta = "UPDATE dbo.PROGRAMA SET activo = 0 WHERE cod_programa =" & cod
        Me.execnq(consulta)
    End Sub

    Public Function modificar(elemento As Programa, cod As Integer) As Integer Implements InterfaceDao(Of Programa).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.PROGRAMA SET nombre = '" & elemento.nombre & "', expediente = '" & elemento.expediente & "' WHERE cod_programa =" & cod
        Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As Programa) As Integer Implements InterfaceDao(Of Programa).guardar
        Dim consulta = "INSERT INTO dbo.PROGRAMA (nombre, expediente) OUTPUT INSERTED.COD_PROGRAMA VALUES ('" & elemento.nombre & "','" & elemento.expediente & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of Programa) Implements InterfaceDao(Of Programa).listar
        Dim lista As List(Of Programa) = New List(Of Programa)
        Dim consulta As String = "SELECT * FROM dbo.PROGRAMA WHERE activo = 1"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Programa = New Programa
                With aux
                    aux.cod_programa = row("cod_programa")
                    aux.nombre = row("nombre")
                    aux.expediente = row("expediente")
                End With
                lista.Add(aux)
            Next
        End If
        Return lista
    End Function

    Public Function obtener(cod As Integer) As Programa Implements InterfaceDao(Of Programa).obtener
        Throw New NotImplementedException()
    End Function
End Class
