Imports Oracle.DataAccess.Client
Public Class ConexionBD

    Public Sub New()
        conexion = New OracleConnection("Data Source=XE; User Id = inventariomateriales; Password=materiales2")

        If conexion.State <> ConnectionState.Open Then
            Try
                conexion.Open() 'Abrir la base de datos en caso de que la conexión sea exitosa
            Catch ex As Exception
                Throw New Exception("No se puedo conectar a la Base de Datos, contacte al D.B.A.", ex)
            End Try
        End If
    End Sub

    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable

        Dim DA As OracleDataAdapter
        'Dim DA As OleDbConnection
        Dim DT As DataTable
        Try
            DA = New OracleDataAdapter(sqlcmd, conexion)
            'DA = New OleDbConnection(sqlcmd, cnx)

            DT = New DataTable
            DA.Fill(DT)
            Return DT 'retorna el conjunto de dato
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
            'Finally
        End Try
        DT.Dispose()

    End Function

    'Método que ejecuta un comando insert, update o delete a base de datos
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New OracleCommand(strcmd, conexion)

        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    Function objetoDataReader(ByVal strcmd As String) As OracleDataReader
        Dim sqlcmd As New OracleCommand(strcmd, conexion)
        Dim resultadoSQL As OracleDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    Public Function objetoScalar(ByVal strcmd As String) As Object
        Dim sqlcmd As New OracleCommand(strcmd, conexion)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class
