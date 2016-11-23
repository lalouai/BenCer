Imports BenCer

Public Class DaoPersona
    Inherits DataManager
    Implements InterfaceDao(Of Persona)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Persona).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As Persona) As Integer Implements InterfaceDao(Of Persona).guardar
        Dim consulta As String
        consulta = "INSERT INTO dbo.PERSONA (cod_tipo_doc, nro_doc, nombre, apellido, cod_estado_civil) OUTPUT INSERTED.COD_PERSONA" &
                   " VALUES (" & elemento.cod_tipo_doc & ", " & elemento.nro_doc & ", '" & elemento.nombre &
                   "', '" & elemento.apellido & "', " & elemento.cod_estado_civil & ")"
        Return Me.ExecM(consulta)
    End Function

    Public Function modificar(elemento As Persona, cod As Integer) As Integer Implements InterfaceDao(Of Persona).modificar
        Throw New NotImplementedException()
    End Function

    Public Function listar() As List(Of Persona) Implements InterfaceDao(Of Persona).listar
        Throw New NotImplementedException()

    End Function

    Public Function obtener(cod As Integer) As Persona Implements InterfaceDao(Of Persona).obtener
        Dim consulta As String
        consulta = "SELECT * FROM dbo.PERSONA AS P " &
                   "INNER JOIN ESTADO_CIVIL AS EC ON P.cod_estado_civil = EC.cod_estado_civil " &
                   "INNER JOIN TIPO_DOC AS TD ON P.cod_tipo_doc = TD.cod_tipo_doc " &
                   "WHERE cod_persona = " & cod
        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim persona As Persona = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                persona = New Persona
                With persona
                    .cod_persona = row("cod_persona")
                    .nombre = row("nombre")
                    .apellido = row("apellido")
                    .estado_civil = row("estado")
                    .cod_estado_civil = row("cod_estado_civil")
                    .cod_tipo_doc = row("cod_tipo_doc")
                    .tipo_doc = row("tipo")
                    .nro_doc = row("nro_doc")
                End With
            Next
        End If
        Return persona
    End Function

    Public Function existe(ByVal nro_doc As String) As Persona
        Dim consulta As String
        consulta = "SELECT * FROM dbo.PERSONA AS P " &
                   "INNER JOIN ESTADO_CIVIL AS EC ON P.cod_estado_civil = EC.cod_estado_civil " &
                   "INNER JOIN TIPO_DOC AS TD ON P.cod_tipo_doc = TD.cod_tipo_doc " &
                   "WHERE nro_doc = " & nro_doc

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim persona As Persona = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                persona = New Persona
                With persona
                    .cod_persona = row("cod_persona")
                    .nombre = row("nombre")
                    .apellido = row("apellido")
                    .estado_civil = row("estado")
                    .cod_estado_civil = row("cod_estado_civil")
                    .cod_tipo_doc = row("cod_tipo_doc")
                    .tipo_doc = row("tipo")
                    .nro_doc = row("nro_doc")
                End With
            Next
        End If
        Return persona
    End Function

End Class
