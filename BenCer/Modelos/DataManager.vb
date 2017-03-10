Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Diagnostics
Imports System.Configuration
Public Class DataManager
    Private m_Conn As SqlConnection
    Private m_Trans As SqlTransaction
    Private TIMEOUT As Integer = 3000

    Protected Sub Begin()

        Try
            If Not m_Conn Is Nothing Then
                If m_Conn.State <> ConnectionState.Open Then
                    m_Conn.Open()
                End If
            Else

                Dim constr As String
                constr = "Data Source=.\SQLEXPRESS;Initial Catalog=bencer;Integrated Security=True"

                m_Conn = New SqlConnection
                m_Conn.ConnectionString = constr
                m_Conn.Open()
                m_Trans = m_Conn.BeginTransaction
            End If

        Catch exc As Exception
            'Throw New Exception("Sub Begin() Failed " & exc.Message, exc)
            Debug.Print("Sub Begin() Failed " & exc.Message, exc)
        End Try
    End Sub
    Protected Sub Commit()

        Try
            m_Trans.Commit()
            m_Trans.Dispose()
            m_Trans = Nothing
            m_Conn.Close()
            m_Conn.Dispose()
            m_Conn = Nothing
        Catch exc As Exception
            Try
                m_Trans.Rollback()
            Catch ex As Exception
                Debug.Print("Sub Commit() Failed " & exc.Message, exc)
            End Try

            Debug.Print("Sub Commit() Failed " & exc.Message, exc)
        End Try

    End Sub



    Public Function Exec(ByVal query As String) As DataSet
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim Index As Integer = 0
        Begin()
        Dim cmd As New SqlCommand(query, m_Conn, m_Trans)
        Try
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
            da.Dispose()
            da = Nothing
            Return ds
        Catch ex As Exception
            m_Trans.Rollback()
            Debug.Print("Execute Failed - Exec " & ex.Message, ex)
        End Try
        Commit()

    End Function

    Public Function ExecM(ByVal query As String) As Int32
        Try
            Dim codigo As Int32 = 0
            Begin()
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = query
            cmd.Connection = m_Conn
            cmd.Transaction = m_Trans
            codigo = cmd.ExecuteScalar()
            Commit()
            cmd.Dispose()
            cmd = Nothing
            Return codigo
        Catch ex As Exception
            Debug.Print("Execute Failed - ExecM " & ex.Message, ex)
            Return -1
        End Try

    End Function

    Public Function execnq(ByVal query As String) As Integer
        Try


            Begin()
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = query
            cmd.Connection = m_Conn
            cmd.Transaction = m_Trans
            Dim affectedRows As Integer = cmd.ExecuteNonQuery()
            Commit()
            cmd.Dispose()
            cmd = Nothing
            Return affectedRows
        Catch ex As Exception
            Debug.Print("Execute Failed - exeqn" & ex.Message, ex)
        End Try
        Return -1
    End Function


    Public Function execSp(ByVal sp As String, cod_ppto As Integer) As Integer
        Dim resultado As Integer = 0
        Try
            Begin()
            Dim cmd As New SqlCommand
            cmd.Connection = m_Conn
            cmd.CommandTimeout = TIMEOUT
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            Dim parametros As SqlParameter = cmd.Parameters.Add("@cod_presu", SqlDbType.Int)
            parametros.Value = cod_ppto
            cmd.Transaction = m_Trans
            resultado = cmd.ExecuteNonQuery()
            Commit()
            cmd.Dispose()
            cmd = Nothing
        Catch ex As Exception
            'Throw New ValidacionesExcepcion("Lo siento no he podido actualizar las incidencias")
            resultado = 1
            MsgBox("Lo siento no he podido actualizar las incidencias")
        End Try
        Return resultado
    End Function

End Class
