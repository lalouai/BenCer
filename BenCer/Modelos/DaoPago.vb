Imports BenCer

Public Class DaoPago
    Inherits DataManager
    Implements InterfaceDao(Of Pago)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Pago).eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function guardar(elemento As Pago) As Integer Implements InterfaceDao(Of Pago).guardar
        Dim consulta As String = "INSERT INTO dbo.PAGO (cod_certificado, cod_estado, fecha_orden) " &
                                 "OUTPUT INSERTED.cod_pago VALUES (" & elemento.cod_certificado & ", " & elemento.estado & ", '" & DateTime.Now.ToString("yyyy-MM-dd") & "')"
        Return ExecM(consulta)
    End Function

    Public Function listar() As List(Of Pago) Implements InterfaceDao(Of Pago).listar
        Throw New NotImplementedException()
    End Function

    Public Function modificar(elemento As Pago, cod As Integer) As Integer Implements InterfaceDao(Of Pago).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.PAGO SET cod_certificado = " & elemento.cod_certificado &
      " ,fecha_pago = '" & elemento.fecha_pago.ToString("yyyy-MM-dd") &
      "' ,cod_estado = " & elemento.cod_estado &
      " ,cod_forma_pago = " & elemento.cod_forma_pago &
      " ,cheque_cta = '" & elemento.cheque_cta &
      "' ,fecha_orden = '" & elemento.fecha_orden.ToString("yyyy-MM-dd") &
      "' WHERE cod_pago =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function obtener(cod As Integer) As Pago Implements InterfaceDao(Of Pago).obtener
        Throw New NotImplementedException()
    End Function

    Public Function listar_por_estado(estado As Integer) As List(Of PagoConOrden)
        Dim lista As List(Of PagoConOrden) = New List(Of PagoConOrden)
        Dim consulta As String = "SELECT P.cod_pago AS cod_pago,
                                   	     C.cod_certificado as cod_certificado,
	                                     P.fecha_pago as fecha_pago,
	                                     EP.descripcion as estado,
	                                     EP.cod_estado_pago as cod_estado_pago,
	                                     FP.descripcion as forma_pago,
	                                     FP.cod_forma_pago as cod_forma_pago,
	                                     P.cheque_cta as cheque_cta,
	                                     C.monto as monto,
                                         CONS.nombre as constructor,
                                         CONS.cuit as cuit,
                                         P.fecha_orden as fecha
                                  FROM PAGO AS P
                                  INNER JOIN CERTIFICADO AS C ON P.cod_certificado = C.cod_certificado
                                  INNER JOIN ESTADO_PAGO AS EP ON P.cod_estado = ep.cod_estado_pago
                                  INNER JOIN OBRA AS O ON C.cod_obra = O.cod_obra
                                  INNER JOIN CONSTRUCTOR AS CONS ON O.cod_constructor = CONS.cod_constructor
                                  LEFT JOIN FORMA_PAGO AS FP ON P.cod_forma_pago = FP.cod_forma_pago " &
                                  "WHERE EP.cod_estado_pago = " & estado

        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows

                Dim pago As PagoConOrden = New PagoConOrden()

                With pago
                    .cod_pago = row("cod_pago")
                    .cod_certificado = row("cod_certificado")
                    .fecha_pago = If(IsDBNull(row("fecha_pago")), Nothing, row("fecha_pago"))
                    .estado = If(IsDBNull(row("estado")), Nothing, row("estado"))
                    .forma_pago = If(IsDBNull(row("forma_pago")), Nothing, row("forma_pago"))
                    .cod_estado = If(IsDBNull(row("cod_estado_pago")), Nothing, row("cod_estado_pago"))
                    .cod_forma_pago = If(IsDBNull(row("cod_forma_pago")), Nothing, row("cod_forma_pago"))
                    .cheque_cta = If(IsDBNull(row("cheque_cta")), Nothing, row("cheque_cta"))
                    .monto = If(IsDBNull(row("monto")), 0D, row("monto"))
                    .constructor = row("constructor")
                    .cuit = row("cuit")
                    .fecha_orden = row("fecha")
                End With

                lista.Add(pago)
            Next
        End If
        Return lista
    End Function

    Public Function listar_por_obra(cod_obra As Integer) As List(Of Pago)
        Dim lista As List(Of Pago) = New List(Of Pago)
        Dim consulta As String = "SELECT P.cod_pago AS cod_pago,
                                   	     C.cod_certificado as cod_certificado,
	                                     P.fecha_pago as fecha_pago,
	                                     C.monto as monto
                                  FROM PAGO AS P
                                  INNER JOIN CERTIFICADO AS C ON P.cod_certificado = C.cod_certificado
                                  INNER JOIN OBRA AS O ON C.cod_obra = O.cod_obra
                                  LEFT JOIN FORMA_PAGO AS FP ON P.cod_forma_pago = FP.cod_forma_pago " &
                                  "WHERE O.cod_obra = " & cod_obra

        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows

                Dim pago As Pago = New Pago()

                With pago
                    .cod_pago = row("cod_pago")
                    .cod_certificado = row("cod_certificado")
                    .fecha_pago = If(IsDBNull(row("fecha_pago")), Nothing, row("fecha_pago"))
                    .monto = If(IsDBNull(row("monto")), 0D, row("monto"))
                End With
                lista.Add(pago)
            Next
        End If
        Return lista
    End Function

End Class
