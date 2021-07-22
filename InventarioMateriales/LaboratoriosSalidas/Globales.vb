Imports Oracle.DataAccess.Client

Module Globales
    'Con la palabra Public oracle va a entender que es una variable global
    Public cnx As OracleConnection

    Public UsuarioConectado As String

    Public accion As Integer
    Public strSQL As String
    Public pdgv As Integer
    Public dgv As New DataGridView
    Public matricula As Integer
    Public conexion As OracleConnection
    'Public UsuarioConectado As Integer

End Module

