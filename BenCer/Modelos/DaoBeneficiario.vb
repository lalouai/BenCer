Imports BenCer

Public Class DaoBeneficiario
    Inherits DataManager
    Implements InterfaceDao(Of Beneficiario)


    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Beneficiario).eliminar
    End Sub

    Public Function modificar(elemento As Beneficiario, cod As Integer) As Integer Implements InterfaceDao(Of Beneficiario).modificar
        Return Nothing
    End Function

    Public Function guardar(elemento As Beneficiario) As Integer Implements InterfaceDao(Of Beneficiario).guardar
        Return Nothing
    End Function

    Public Function guardar(cod_persona As Integer) As Integer
        Dim consulta As String = "INSERT INTO dbo.BENEFICIARIO (cod_persona, fecha_alta) OUTPUT INSERTED.cod_beneficiario VALUES (" &
                                  cod_persona & ", '" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
        Return ExecM(consulta)
    End Function

    Public Function listar() As List(Of Beneficiario) Implements InterfaceDao(Of Beneficiario).listar
        Dim lista As List(Of Beneficiario) = New List(Of Beneficiario)
        Dim consulta As String
        consulta = "SELECT * FROM dbo.BENEFICIARIO AS BEN" &
                   " INNER JOIN PERSONA as P ON BEN.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " WHERE BEN.activo = 1"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim beneficiario As Beneficiario = Nothing
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                beneficiario = New Beneficiario
                With beneficiario
                    .cod_beneficiario = row("cod_beneficiario")
                    .cod_persona = row("cod_persona")
                    .nombre = row("nombre")
                    .apellido = row("apellido")
                    .estado_civil = row("estado")
                    .cod_estado_civil = row("cod_estado_civil")
                    .cod_tipo_doc = row("cod_tipo_doc")
                    .tipo_doc = row("tipo")
                    .nro_doc = row("nro_doc")
                End With
                lista.Add(beneficiario)
            Next
        End If
        Return lista
    End Function

    Public Function obtener(cod As Integer) As Beneficiario Implements InterfaceDao(Of Beneficiario).obtener
        Dim consulta As String
        consulta = "SELECT * FROM dbo.BENEFICIARIO AS BEN" &
                   " INNER JOIN PERSONA as P ON BEN.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " WHERE BEN.cod_beneficiario = " & cod

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim beneficiario As Beneficiario = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                beneficiario = New Beneficiario
                With beneficiario
                    .cod_beneficiario = row("cod_beneficiario")
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
        Return beneficiario
    End Function

    Public Function obtener_por_persona(ByVal persona As Integer) As Beneficiario
        Dim consulta As String
        consulta = "SELECT * FROM dbo.BENEFICIARIO AS BEN" &
                   " INNER JOIN PERSONA as P ON BEN.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " WHERE BEN.cod_persona = " & persona

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim beneficiario As Beneficiario = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                beneficiario = New Beneficiario
                With beneficiario
                    .cod_beneficiario = row("cod_beneficiario")
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
        Return beneficiario
    End Function

    Public Sub final_obra(cod_beneficiario As Integer)

        Me.execnq("UPDATE beneficiario SET activo = 0 WHERE cod_beneficiario =" & cod_beneficiario)
    End Sub

    Public Function listar_con_final() As List(Of Beneficiario)
        Dim lista As List(Of Beneficiario) = New List(Of Beneficiario)
        Dim consulta As String
        consulta = "SELECT * FROM dbo.BENEFICIARIO AS BEN" &
                   " INNER JOIN PERSONA as P ON BEN.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " INNER JOIN OBRA as OB ON BEN.cod_beneficiario = OB.cod_beneficiario" &
                   " WHERE BEN.activo = 0 AND OB.activa = 0 AND OB.fecha_fin IS NOT NULL"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim beneficiario As Beneficiario = Nothing
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                beneficiario = New Beneficiario
                With beneficiario
                    .cod_beneficiario = row("cod_beneficiario")
                    .cod_persona = row("cod_persona")
                    .nombre = row("nombre")
                    .apellido = row("apellido")
                    .estado_civil = row("estado")
                    .cod_estado_civil = row("cod_estado_civil")
                    .cod_tipo_doc = row("cod_tipo_doc")
                    .tipo_doc = row("tipo")
                    .nro_doc = row("nro_doc")
                End With
                lista.Add(beneficiario)
            Next
        End If
        Return lista
    End Function

End Class
