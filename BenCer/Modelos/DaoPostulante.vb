Imports BenCer

Public Class DaoPostulante
    Inherits DaoPersona
    Implements InterfaceDao(Of Postulante)

    Public Overloads Function guardar(elemento As Postulante) As Integer Implements InterfaceDao(Of Postulante).guardar
        Throw New NotImplementedException()
    End Function

    Public Overloads Function guardar(elemento As Persona) As Integer
        Dim consulta As String = "INSERT INTO dbo.POSTULANTE (cod_persona, fecha_alta) OUTPUT INSERTED.cod_postulante" &
                                 " VALUES (" & MyBase.guardar(elemento) & ", '" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Overloads Function modificar(elemento As Postulante, cod As Integer) As Integer Implements InterfaceDao(Of Postulante).modificar
        Throw New NotImplementedException()
    End Function

    Public Function listar_by(ByVal campo As String, ByVal termino As String) As List(Of Postulante)
        Dim lista As List(Of Postulante) = New List(Of Postulante)

        Dim consulta As String = "SELECT P.cod_persona, nombre, apellido, nro_doc " &
                                 "FROM dbo.POSTULANTE as POS" &
                                 " INNER JOIN PERSONA as P ON POS.cod_persona = P.cod_PERSONA" &
                                 " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                                 " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                                 " WHERE " & campo & " Like '%" & termino & "%'"

        Dim ds As Data.DataSet = Me.Exec(consulta)

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Postulante = New Postulante

                'aux.cod_postulante = row("cod_postulante")
                aux.cod_persona = row("cod_persona")
                aux.nombre = row("nombre")
                aux.apellido = row("apellido")
                'aux.estado_civil = row("estado")
                'aux.cod_estado_civil = row("cod_estado_civil")
                'aux.cod_tipo_doc = row("cod_tipo_doc")
                'aux.tipo_doc = row("tipo")
                'aux.fecha_alta = row("fecha_alta")
                aux.nro_doc = row("nro_doc")

                lista.Add(aux)
            Next
        End If

        Return lista
    End Function

    Public Overloads Sub eliminar(cod As Integer) Implements InterfaceDao(Of Postulante).eliminar
        Dim consulta As String = "DELETE FROM POSTULANTE WHERE cod_persona = " & cod
        execnq(consulta)
        consulta = "DELETE FROM dbo.PERSONA WHERE cod_persona=" & cod
        execnq(consulta)
    End Sub

    Public Overloads Sub eliminarPostulante(cod As Integer)
        Dim consulta As String = "DELETE FROM POSTULANTE WHERE cod_persona = " & cod
        execnq(consulta)
    End Sub

    Public Overloads Function listar() As List(Of Postulante) Implements InterfaceDao(Of Postulante).listar
        Dim lista As List(Of Postulante) = New List(Of Postulante)

        Dim consulta As String = "SELECT * FROM dbo.POSTULANTE as POS" &
                                 " INNER JOIN PERSONA as P ON POS.cod_persona = P.cod_PERSONA" &
                                 " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                                 " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                                 " WHERE pos.ACTIVO = 1"

        Dim ds As Data.DataSet = Me.Exec(consulta)

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Postulante = New Postulante

                aux.cod_postulante = row("cod_postulante")
                aux.cod_persona = row("cod_persona")
                aux.nombre = row("nombre")
                aux.apellido = row("apellido")
                aux.estado_civil = row("estado")
                aux.cod_estado_civil = row("cod_estado_civil")
                aux.cod_tipo_doc = row("cod_tipo_doc")
                aux.tipo_doc = row("tipo")
                aux.fecha_alta = row("fecha_alta")
                aux.nro_doc = row("nro_doc")

                lista.Add(aux)
            Next
        End If

        Return lista
    End Function

    Public Overloads Function obtener(cod As Integer) As Postulante Implements InterfaceDao(Of Postulante).obtener
        Throw New NotImplementedException()
    End Function

    Public Function obtener_por_persona(ByVal persona As Integer) As Postulante
        Dim consulta As String
        consulta = "SELECT * FROM dbo.POSTULANTE AS POS" &
                   " INNER JOIN PERSONA as P ON POS.cod_persona = P.cod_PERSONA" &
                   " INNER JOIN ESTADO_CIVIL as EC ON P.cod_estado_civil = EC.cod_estado_civil" &
                   " INNER JOIN TIPO_DOC as TD ON P.cod_tipo_doc = TD.cod_tipo_doc" &
                   " WHERE POS.cod_persona = " & persona

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim postulante As Postulante = Nothing

        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                postulante = New Postulante
                With postulante
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
        Return postulante
    End Function

End Class
