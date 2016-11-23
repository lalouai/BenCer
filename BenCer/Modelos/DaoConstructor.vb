Imports BenCer

Public Class DaoConstructor
    Inherits DataManager
    Implements InterfaceDao(Of Constructor)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Constructor).eliminar
        Dim consulta As String
        consulta = "UPDATE dbo.CONSTRUCTOR SET activo = 0 WHERE cod_constructor =" & cod
        Me.execnq(consulta)
    End Sub

    Public Function modificar(elemento As Constructor, cod As Integer) As Integer Implements InterfaceDao(Of Constructor).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.CONSTRUCTOR SET nombre = '" & elemento.nombre & "', cuit = '" & elemento.cuit & "' WHERE cod_constructor =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As Constructor) As Integer Implements InterfaceDao(Of Constructor).guardar
        Dim consulta = "INSERT INTO dbo.CONSTRUCTOR (nombre, cuit) OUTPUT INSERTED.COD_CONSTRUCTOR VALUES ('" & elemento.nombre & "','" & elemento.cuit & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of Constructor) Implements InterfaceDao(Of Constructor).listar
        Dim lista As List(Of Constructor) = New List(Of Constructor)
        Dim consulta As String = "SELECT * FROM dbo.CONSTRUCTOR"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Constructor = New Constructor
                With aux
                    aux.cod_constructor = row("cod_constructor")
                    aux.nombre = row("nombre")
                    aux.cuit = row("cuit")
                End With
                lista.Add(aux)
            Next
        End If
        Return lista
    End Function

    Public Function obtener(cod As Integer) As Constructor Implements InterfaceDao(Of Constructor).obtener
        Throw New NotImplementedException()
    End Function
End Class
