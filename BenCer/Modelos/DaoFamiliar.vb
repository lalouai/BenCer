Imports BenCer

Public Class DaoFamiliar
    Inherits DaoPersona
    Implements InterfaceDao(Of Familiar)

    Public Function modificar(elemento As Familiar, cod As Integer) As Integer Implements InterfaceDao(Of Familiar).modificar
        Return Nothing
    End Function

    Public Function listar_por_persona(cod_persona As Integer) As List(Of Familiar)
        Dim lista As List(Of Familiar) = New List(Of Familiar)
        Dim consulta As String
        consulta = "SELECT FAM.cod_persona AS cod_persona, P.nombre as nombre, P.apellido as apellido, P.cod_estado_civil as cod_estado_civil," &
                   " EC.ESTADO as estado, P.cod_tipo_doc as cod_tipo_doc, TD.tipo as tipo, P.nro_doc as nro_doc," &
                   " FAM.cod_parentezco as cod_parentezco, PA.descripción as parentezco" &
                   " FROM dbo.FAMILIAR AS FAM" &
                   " INNER JOIN PERSONA as P ON FAM.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " INNER JOIN PARENTEZCO as PA ON FAM.cod_parentezco = PA.cod_parentezco" &
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
                    .cod_parentezco = row("cod_parentezco")
                    .parentezco = row("parentezco")
                End With
                lista.Add(familiar)
            Next
        End If
        Return lista
    End Function

    Private Sub eliminar(cod As Integer) Implements InterfaceDao(Of Familiar).eliminar
        Dim consulta = "DELETE FROM dbo.FAMILIAR WHERE cod_persona =" & cod
        Me.execnq(consulta)
        consulta = "DELETE FROM dbo.PERSONA WHERE cod_persona=" & cod
        Me.execnq(consulta)
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
                   " WHERE FAM.cod_persona = " & persona

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
