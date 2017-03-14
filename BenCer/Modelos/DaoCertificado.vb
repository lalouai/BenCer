Imports BenCer

Public Class DaoCertificado
    Inherits DataManager
    Implements InterfaceDao(Of Certificado)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Certificado).eliminar
        Dim consulta As String
        consulta = "DELETE FROM R_CERTIFICADO WHERE  cod_certificado = " & cod
        Me.execnq(consulta)
        consulta = "DELETE FROM CERTIFICADO WHERE cod_certificado = " & cod
        Me.execnq(consulta)
    End Sub

    Public Function modificar(elemento As Certificado, cod As Integer) As Integer Implements InterfaceDao(Of Certificado).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.CERTIFICADO SET cod_estado_certificacion = " & elemento.cod_estado & ", monto = " & elemento.monto.ToString.Replace(",", ".") & " WHERE cod_certificado =" & cod
        Debug.Print(consulta)
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As Certificado) As Integer Implements InterfaceDao(Of Certificado).guardar
        Dim consulta As String = "INSERT INTO dbo.CERTIFICADO (cod_obra, fecha_alta, cod_estado_certificacion ,numero) " &
                                 "OUTPUT INSERTED.cod_certificado VALUES (" & elemento.cod_obra & ", '" & DateTime.Now.ToString("yyyy-MM-dd") &
                                 "', " & elemento.cod_estado & ", " & elemento.numero & ")"
        Return ExecM(consulta)
    End Function

    Public Function listar() As List(Of Certificado) Implements InterfaceDao(Of Certificado).listar
        Return Nothing
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
        Return Nothing
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

    Public Function avance_anterior(cod_r_ppto As Integer, cod_obra As Integer) As Decimal
        Dim consulta As String = "SELECT sum(RC.avance) as avance_previo FROM CERTIFICADO C " &
                                 "INNER JOIN R_CERTIFICADO As RC On C.cod_certificado = RC.cod_certificado	" &
                                 "INNER JOIN OBRA As O On C.cod_obra = O.cod_obra " &
                                 "WHERE O.cod_obra = " & cod_obra & " And RC.cod_r_ppto = " & cod_r_ppto

        Dim ds As Data.DataSet = Me.Exec(consulta)
        Dim salida As Decimal
        If ds.Tables(0).Rows.Count = 1 Then
            Decimal.TryParse(If(IsDBNull(ds.Tables(0).Rows(0)("avance_previo")), 0, ds.Tables(0).Rows(0)("avance_previo")), salida)
        Else
            salida = 0D
        End If
        Return salida
    End Function

    Public Function ultimo_certificado(cod_obra As Integer) As Certificado

        Dim consulta As String = "Select TOP 1 * " &
                                  "From CERTIFICADO As C " &
                                  "INNER JOIN ESTADO_CERTIFICACION As EC On C.cod_estado_certificacion = EC.cod_estado " &
                                  "Where c.activo = 1 And cod_obra = " & cod_obra &
                                  " ORDER by numero desc"
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
        Dim consulta As String = "UPDATE dbo.CERTIFICADO Set cod_estado_certificacion = 3 WHERE cod_certificado = " & cod_certificado
        Debug.Print(consulta)
        Return Me.execnq(consulta)
    End Function

    Public Function listarRenglones(cod_obra As Integer, cod_certificado As Integer) As List(Of RenglonCertificado)
        Dim lista As List(Of RenglonCertificado) = New List(Of RenglonCertificado)
        Dim consulta As String = "Select * " &
                                 "FROM dbo.CERTIFICADO As C " &
                                 "INNER JOIN R_CERTIFICADO As RC On C.cod_certificado = RC.cod_certificado " &
                                 "INNER JOIN R_PRESUPUESTO As RP On Rc.cod_r_ppto = RP.cod_r_ppto " &
                                 "WHERE C.activo = 1 And C.cod_certificado =" & cod_certificado

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

    Public Function certificadosSinOrden() As List(Of CertificadoSinOrden)
        Dim lista As List(Of CertificadoSinOrden) = New List(Of CertificadoSinOrden)
        Dim consulta As String = "Select c.cod_certificado As cod_certificado, " &
                                 "       c.numero As certificado, " &
                                 "       c.fecha_alta As fecha, " &
                                 "	     c.monto As monto, " &
                                 "       cons.nombre As constructor, " &
                                 "       cons.cuit As cuit, " &
                                 "	     concat(p.nombre, ' ', p.apellido) as beneficiario" &
                                 " From CERTIFICADO As c" &
                                 " inner join OBRA as o on c.cod_obra = o.cod_obra" &
                                 " inner Join CONSTRUCTOR As cons On o.cod_constructor = cons.cod_constructor" &
                                 " inner join BENEFICIARIO as b on o.cod_beneficiario = b.cod_beneficiario" &
                                 " inner Join PERSONA as p on b.cod_persona = p.cod_persona" &
                                 " where c.cod_certificado not in (select cod_certificado from PAGO) and c.cod_estado_certificacion = 3" &
                                 " order by fecha ASC"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                lista.Add(New CertificadoSinOrden(row("cod_certificado"), row("certificado"), row("fecha"), row("monto"), row("constructor"), row("beneficiario"), row("cuit")))
            Next
        End If
        Return lista
    End Function

    Public Function costos(cod_obra As Integer) As Costos
        Dim costs As Costos = New Costos()

        Dim consulta As String = "select (SELECT ISNULL(sum(RPE.costo),0) FROM PRESUPUESTO AS PRE " &
                                 "INNER JOIN R_PRESUPUESTO As RPE On PRE.cod_ppto = RPE.cod_ppto " &
                                 "INNER JOIN OBRA AS OB ON PRE.cod_ppto = OB.cod_ppto " &
                                 "WHERE OB.cod_obra = " & cod_obra & ") AS COSTO, " &
                                 "(SELECT ISNULL(sum(monto),0) AS costo from CERTIFICADO as CERTI " &
                                 "WHERE CERTI.cod_obra = " & cod_obra & " And CERTI.cod_certificado Not IN (SELECT COD_CERTIFICADO FROM PAGO) ) AS CERTIFICADO, " &
                                 "(SELECT ISNULL(SUM(CERTI.monto),0) AS costo FROM PAGO AS PA " &
                                 "INNER Join CERTIFICADO AS CERTI ON PA.cod_certificado = CERTI.cod_certificado " &
                                 "WHERE CERTI.cod_obra = " & cod_obra & ") AS PAGADO"
        Debug.Print(consulta)

        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count = 1 Then
            Dim row = ds.Tables(0).Rows(0)
            costs.total = row("costo")
            costs.certificado = row("certificado")
            costs.pagado = row("pagado")

        End If
        Return costs
    End Function

    Public Function total_certificado(cod_obra As Integer) As Decimal
        Dim consulta As String = "SELECT SUM(monto) as monto FROM CERTIFICADO WHERE cod_obra = " & cod_obra
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count = 1 Then
            Dim row = ds.Tables(0).Rows(0)
            Return row("monto")
        End If
        Return 0
    End Function



End Class
