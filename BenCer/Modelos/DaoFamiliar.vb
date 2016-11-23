Imports BenCer

Public Class DaoFamiliar
    Inherits DaoPersona
    Implements InterfaceDao(Of Familiar)

    Public Function modificar(elemento As Familiar, cod As Integer) As Integer Implements InterfaceDao(Of Familiar).modificar
        Throw New NotImplementedException()
    End Function

    Friend Function listar_por_persona(cod_persona As Integer) As List(Of Familiar)
        Dim lista As List(Of Familiar) = New List(Of Familiar)
        Dim consulta As String
        consulta = "SELECT * FROM dbo.FAMILIAR AS FAM" &
                   " INNER JOIN PERSONA as P ON FAM.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " INNER JOIN PARENTEZCO as Pa ON FAM.cod_parentezco = Pa.cod_parentezco" &
                   " WHERE FAM.cod_jefe_flia = " & cod_persona

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim familiar As Familiar = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                familiar = New Familiar
                With familiar
                    .cod_persona = row("cod_persona")
                    .nombre = row("nombre")
                    .apellido = row("apellido")
                    .estado_civil = row("estado")
                    .cod_estado_civil = row("cod_estado_civil")
                    .cod_tipo_doc = row("cod_tipo_doc")
                    .tipo_doc = row("tipo")
                    .nro_doc = row("nro_doc")
                End With
                lista.Add(familiar)
            Next
        End If
        Return lista
    End Function

    Private Sub InterfaceDao_eliminar(cod As Integer) Implements InterfaceDao(Of Familiar).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As Familiar) As Integer Implements InterfaceDao(Of Familiar).guardar

        Dim consulta As String = "INSERT INTO dbo.FAMILIAR (cod_persona, fecha_alta, cod_parentezco, cod_jefe_flia) OUTPUT INSERTED.cod_familiar" &
                                 " VALUES (" & MyBase.guardar(elemento) & ", '" & DateTime.Now.ToString("yyyy-MM-dd") &
                                 "', " & elemento.cod_parentezco & "," & elemento.cod_jefe_flia & ")"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of Familiar) Implements InterfaceDao(Of Familiar).listar
        Throw New NotImplementedException()
    End Function

    Public Function obtener(cod As Integer) As Familiar Implements InterfaceDao(Of Familiar).obtener
        Throw New NotImplementedException()
    End Function

    Public Function obtener_por_persona(ByVal persona As Integer) As Familiar
        Dim consulta As String
        consulta = "SELECT * FROM dbo.FAMILIAR AS FAM" &
                   " INNER JOIN PERSONA as P ON FAM.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " WHERE FAM.cod_jefe_flia = " & persona

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim familiar As Familiar = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                familiar = New Familiar
                With familiar
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
        Return familiar
    End Function


End Class
