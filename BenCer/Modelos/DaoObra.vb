Imports BenCer

Public Class DaoObra
    Inherits DataManager
    Implements InterfaceDao(Of Obra)

    Public Sub eliminar(cod As Integer) Implements InterfaceDao(Of Obra).eliminar
        Dim consulta As String
        consulta = "UPDATE dbo.OBRA SET activa = 0 WHERE cod_obra =" & cod
        Me.execnq(consulta)
    End Sub

    Public Function modificar(elemento As Obra, cod As Integer) As Integer Implements InterfaceDao(Of Obra).modificar
        Dim consulta As String
        consulta = "UPDATE dbo.OBRA SET " &
                   "cod_programa = " & elemento.cod_programa & ", " &
                   "cod_tipo_obra = " & elemento.cod_tipo_obra & ", " &
                   "cod_beneficiario = " & elemento.cod_beneficiario & ", " &
                   "cod_constructor = " & elemento.cod_constructor & ", " &
                   "fecha_inicio = '" & elemento.fecha_inicio & "', " &
                   "fecha_fin = '" & elemento.fecha_fin & "' " &
                   "cod_ppto = '" & elemento.cod_ppto & "' " &
                   " WHERE cod_obra =" & cod
        Return Me.execnq(consulta)
    End Function

    Public Function guardar(elemento As Obra) As Integer Implements InterfaceDao(Of Obra).guardar
        Dim consulta = "INSERT INTO dbo.OBRA " &
                       "(cod_programa ,cod_tipo_obra, cod_beneficiario, cod_constructor, cod_ppto, fecha_inicio) " &
                       "OUTPUT INSERTED.cod_obra VALUES " &
                       "(" & elemento.cod_programa & ", " & elemento.cod_tipo_obra & ", " & elemento.cod_beneficiario & ", " &
                       elemento.cod_constructor & ", " & elemento.cod_ppto & ", '" & elemento.fecha_inicio & "')"
        Return Me.ExecM(consulta)
    End Function

    Public Function listar() As List(Of Obra) Implements InterfaceDao(Of Obra).listar
        Dim lista As List(Of Obra) = New List(Of Obra)
        Dim consulta As String = "SELECT O.cod_obra as cod_obra, 
                                         O.cod_programa as cod_programa,
	                                     O.cod_beneficiario as cod_beneficiario,
	                                     O.cod_constructor as cod_constructor,
	                                     O.cod_tipo_obra as cod_tipo_obra,
                                         O.cod_ppto as cod_ppto,
	                                     P.nombre as programa,
	                                     CONCAT(Pe.apellido, ', ' ,Pe.nombre) as beneficiario,
	                                     C.nombre as constructor,
	                                     OT.descripcion as prototipo,
	                                     O.fecha_inicio as fecha_inicio,
	                                     O.fecha_fin as fecha_fin " &
                                 "FROM dbo.OBRA as O " &
                                 "INNER JOIN PROGRAMA as P ON O.cod_programa = P.cod_programa " &
                                 "INNER JOIN TIPO_OBRA as OT ON O.cod_tipo_obra = OT.cod_tipo_obra " &
                                 "LEFT JOIN CONSTRUCTOR as C ON O.cod_constructor = C.cod_constructor " &
                                 "INNER JOIN BENEFICIARIO as B ON O.cod_beneficiario = B.cod_beneficiario " &
                                 "INNER JOIN PERSONA as Pe ON B.cod_persona = Pe.cod_persona " &
                                 "WHERE activa = 1"
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each row In ds.Tables(0).Rows
                Dim aux As Obra = New Obra
                With aux
                    .cod_obra = row("cod_obra")
                    .cod_programa = row("cod_programa")
                    .programa = row("programa")
                    .cod_beneficiario = row("cod_beneficiario")
                    .beneficiario = row("beneficiario")
                    .cod_constructor = row("cod_constructor")
                    .cod_tipo_obra = row("cod_tipo_obra")
                    .constructor = If(IsDBNull(row("constructor")), Nothing, row("constructor"))
                    .tipo_obra = row("prototipo")
                    .fecha_inicio = If(IsDBNull(row("fecha_inicio")), Nothing, row("fecha_inicio"))
                    .fecha_fin = If(IsDBNull(row("fecha_fin")), Nothing, row("fecha_inicio"))
                    .cod_ppto = row("cod_ppto")
                End With
                lista.Add(aux)
            Next
        End If
        Return lista
    End Function

    Public Function obtener(cod As Integer) As Obra Implements InterfaceDao(Of Obra).obtener
        Dim obra As Obra = New Obra

        Dim consulta As String = "SELECT O.cod_obra as cod_obra, 
                                         O.cod_programa as cod_programa,
	                                     O.cod_beneficiario as cod_beneficiario,
	                                     O.cod_constructor as cod_constructor,
	                                     O.cod_tipo_obra as cod_tipo_obra,
                                         O.cod_ppto as cod_ppto,
	                                     P.nombre as programa,
	                                     CONCAT(Pe.apellido, ', ' ,Pe.nombre) as beneficiario,
	                                     C.nombre as constructor,
	                                     OT.descripcion as prototipo,
	                                     O.fecha_inicio as fecha_inicio,
	                                     O.fecha_fin as fecha_fin " &
                                 "FROM dbo.OBRA as O " &
                                 "INNER JOIN PROGRAMA as P ON O.cod_programa = P.cod_programa " &
                                 "INNER JOIN TIPO_OBRA as OT ON O.cod_tipo_obra = OT.cod_tipo_obra " &
                                 "LEFT JOIN CONSTRUCTOR as C ON O.cod_constructor = C.cod_constructor " &
                                 "INNER JOIN BENEFICIARIO as B ON O.cod_beneficiario = B.cod_beneficiario " &
                                 "INNER JOIN PERSONA as Pe ON B.cod_persona = Pe.cod_persona " &
                                 "WHERE activa = 1 AND cod_obra = " & cod
        Dim ds As Data.DataSet = Me.Exec(consulta)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim row = ds.Tables(0).Rows(0)
            With obra
                .cod_obra = row("cod_obra")
                .cod_programa = row("cod_programa")
                .programa = row("programa")
                .cod_beneficiario = row("cod_beneficiario")
                .beneficiario = row("beneficiario")
                .cod_constructor = row("cod_constructor")
                .cod_tipo_obra = row("cod_tipo_obra")
                .constructor = If(IsDBNull(row("constructor")), Nothing, row("constructor"))
                .tipo_obra = row("prototipo")
                .fecha_inicio = If(IsDBNull(row("fecha_inicio")), Nothing, row("fecha_inicio"))
                .fecha_fin = If(IsDBNull(row("fecha_fin")), Nothing, row("fecha_inicio"))
                .cod_ppto = row("cod_ppto")
            End With

        End If
        Return obra
    End Function
End Class
