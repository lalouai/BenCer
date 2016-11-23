Imports BenCer

Public Class DaoCertificado
    Inherits DataManager
    Implements InterfaceDao(Of Certificado)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Certificado).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function modificar(elemento As Certificado, cod As Integer) As Integer Implements InterfaceDao(Of Certificado).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.CERTIFICADO SET monto = " & elemento.monto.ToString.Replace(",", ".") & " WHERE cod_certificado =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As Certificado) As Integer Implements InterfaceDao(Of Certificado).guardar
        Dim consulta As String = "INSERT INTO dbo.CERTIFICADO (cod_obra, fecha_alta, cod_estado_certificacion ,numero) " &
                                 "OUTPUT INSERTED.cod_certificado VALUES (" & elemento.cod_obra & ", '" & DateTime.Now.ToString("yyyy-MM-dd") &
                                 "', " & elemento.cod_estado & ", " & elemento.numero & ")"
        Return ExecM(consulta)
    End Function

    Public Function listar() As List(Of Certificado) Implements InterfaceDao(Of Certificado).listar
        Throw New NotImplementedException()

    End Function

    Friend Function listar_by_ben(cod_ben As Integer) As List(Of Certificado)
        Dim lista As List(Of Certificado) = New List(Of Certificado)
        Dim consulta As String = "SELECT * " &
                                 "FROM dbo.CERTIFICADO as C " &
                                 "INNER JOIN ESTADO_CERTIFICACION as EC ON C.cod_estado_certificacion = EC.cod_estado " &
                                 "INNER JOIN OBRA as O ON C.cod_obra = O.cod_obra " &
                                 "WHERE C.activo = 1 AND O.cod_beneficiario =" & cod_ben



        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Certificado = New Certificado

                With aux
                    .cod_certificado = row("cod_certificado")
                    .cod_estado = row("cod_estado")
                    .cod_obra = row("cod_obra")
                    .estado = row("descripcion")
                    .fecha_alta = row("fecha_alta")
                    .monto = If(IsDBNull(row("monto")), 0, row("monto"))
                    .numero = row("numero")
                End With
                lista.Add(aux)
            Next
        End If
        Return lista
    End Function

    Public Function obtener(cod As Integer) As Certificado Implements InterfaceDao(Of Certificado).obtener
        Throw New NotImplementedException()
    End Function

    Public Function proximo_numero(cod_obra) As Integer
        Dim consulta As String = "SELECT TOP 1 numero FROM CERTIFICADO WHERE cod_obra = " & cod_obra & " ORDER BY numero DESC"
        Dim salida As Integer = 1

        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            salida = ds.Tables(0).Rows(0)("numero") + 1
        End If
        Return salida
    End Function

    Public Function avance_anterior(cod_r_ppto As Integer) As Integer
        Return 0
    End Function

    Public Function ultimo_certificado(cod_obra As Integer) As Certificado

        Dim consulta As String = "SELECT TOP 1 *
                                  FROM CERTIFICADO as C
                                  INNER JOIN ESTADO_CERTIFICACION as EC On C.cod_estado_certificacion = EC.cod_estado
                                  WHERE c.activo = 1 AND cod_obra = " & cod_obra & "
                                  ORDER by numero desc"
        Dim salida As Certificado = Nothing
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow = ds.Tables(0).Rows(0)
            salida = New Certificado
            With salida
                .cod_certificado = fila("cod_certificado")
                .cod_obra = fila("cod_obra")
                .cod_estado = fila("cod_estado")
                .numero = fila("numero")
                .estado = fila("descripcion")
                .monto = If(IsDBNull(fila("monto")), 0, fila("monto"))
                .fecha_alta = fila("fecha_alta")
            End With
        End If
        Return salida
    End Function

    Public Function consolidar(cod_certificado As Integer) As Integer
        Dim consulta As String
        consulta = "UPDATE dbo.CERTIFICADO SET cod_estado_certificacion = 3 WHERE cod_certificado =" & cod_certificado
        Return Me.execnq(consulta)
    End Function

    Public Function listarRenglones(cod_obra As Integer, cod_certificado As Integer) As List(Of RenglonCertificado)
        Dim lista As List(Of RenglonCertificado) = New List(Of RenglonCertificado)
        Dim consulta As String = "SELECT * " &
                                 "FROM dbo.CERTIFICADO as C " &
                                 "INNER JOIN R_CERTIFICADO as RC ON C.cod_certificado = RC.cod_certificado " &
                                 "INNER JOIN R_PRESUPUESTO as RP ON Rc.cod_r_ppto = RP.cod_r_ppto " &
                                 "WHERE C.activo = 1 AND C.cod_certificado =" & cod_certificado



        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As RenglonCertificado = New RenglonCertificado

                Dim rppto As RenglonPpto = New RenglonPpto
                rppto.cod_r_ppto = row("cod_r_ppto")
                rppto.cod_ppto = row("cod_ppto")
                rppto.costo = row("costo")
                rppto.descripcion = row("descripcion")
                rppto.item = row("item")

                With aux
                    .cod_r_certificado = row("cod_r_certificado")
                    .cod_certificado = row("cod_certificado")
                    .cod_r_ppto = row("cod_r_ppto")
                    .avance_anterior = row("avance_anterior")
                    .avance = row("avance")
                    .renglon_ppto = rppto
                End With
                lista.Add(aux)
            Next
        End If
        Return lista
    End Function

    Public Function porcentaje_total_avance(cod_obra As Integer) As Decimal
        Return 0
    End Function

    Public Function insertarRenglon(renglon As RenglonCertificado) As Integer
        Dim consulta As String = "INSERT INTO dbo.R_CERTIFICADO (cod_certificado, cod_r_ppto, avance, avance_anterior) " &
                                 "OUTPUT INSERTED.cod_r_certificado VALUES(" & renglon.cod_certificado & ", " & renglon.cod_r_ppto &
                                 ", " & renglon.avance.ToString.Replace(",", ".") & ", " & renglon.avance_anterior.ToString.Replace(",", ".") & " )"
        Return ExecM(consulta)
    End Function
End Class
