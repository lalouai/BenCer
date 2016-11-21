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

            Throw New Exception("Sub Begin() Failed " & exc.Message, exc)

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
            m_Trans.Rollback()
            Throw New Exception("Sub Commit() Failed " & exc.Message, exc)
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
            Throw New Exception("Execute Failed - Rollback called " & ex.Message, ex)
        End Try

        Commit()

    End Function

    Public Function ExecM(ByVal query As String) As Int32
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
    End Function

    Public Function execnq(ByVal query As String) As Integer
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
    End Function

End Class
