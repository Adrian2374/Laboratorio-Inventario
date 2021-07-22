Public Class ClaseLogin
    Private cuenta As String
    Private clave As String
    'Constructores de la clase
    Public Sub New()
        cuenta = ""
        clave = ""
    End Sub
    Public Sub New(ByVal idCuenta As String, ByVal idClave As String)
        cuenta = idCuenta
        clave = idClave
    End Sub
    'Metodos Get y Set
    Public Property getSetidCuenta As String
        Get
            Return cuenta
        End Get
        Set(value As String)
            cuenta = value
        End Set
    End Property
    Public Property getSetidClave As String
        Get
            Return clave
        End Get
        Set(value As String)
            clave = value
        End Set
    End Property
    'Metodo de consulta si existe el usuario
    Public Function consultaUsuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New ConexionBD
        Dim xDT As DataTable
        strSQL = "select * from usuarios " &
                 "where idusuario ='" & cuenta & "' and contrasena ='" & clave & "'"
        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("idusuario")) Then
                cuenta = ""
            Else
                cuenta = CStr(xDT.Rows(0)("idusuario"))
                usuarioConectado = CStr(xDT.Rows(0)("idusuario")) & " " & CStr(xDT.Rows(0)("contrasena"))
            End If
            consultaUsuario = True
        End If
    End Function
End Class
