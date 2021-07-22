Imports Oracle.DataAccess.Client
Public Class ClaseUsuarios
    Private Lamatricula As String
    Private Elnombre As String
    Private Elpaterno As String
    Private Elmaterno As String
    Private Lacontraseña As String
    Private Elnivel As Integer
    Private Eltelefono As Long
    Public pdgvU As Integer
    Public buscar As String

    Public Sub New(ByVal txt_matricula As Integer,
                   ByVal txt_nombre As String,
                   ByVal txt_paterno As String,
                   ByVal txt_materno As String,
                   ByVal txt_contraseña As String,
                   ByVal nivel As Integer,
                   ByVal txt_telefono As Long)

        Lamatricula = txt_matricula
        Elnombre = txt_nombre
        Elpaterno = txt_paterno
        Elmaterno = txt_materno
        Lacontraseña = txt_contraseña
        Elnivel = nivel
        Eltelefono = txt_telefono

    End Sub

    Public Sub New()

    End Sub

    Public Property getSetLamatricula() As Integer
        Get
            Return Lamatricula
        End Get
        Set(ByVal Value As Integer)
            Lamatricula = Value
        End Set
    End Property

    Public Property getSetElnombre() As String
        Get
            Return Elnombre
        End Get
        Set(ByVal Value As String)
            Elnombre = Value
        End Set
    End Property

    Public Property getSetElpaterno() As String
        Get
            Return Elpaterno
        End Get
        Set(ByVal Value As String)
            Elpaterno = Value
        End Set
    End Property

    Public Property getSetElmaterno() As String
        Get
            Return Elmaterno
        End Get
        Set(ByVal Value As String)
            Elmaterno = Value
        End Set
    End Property

    Public Property getSetLacontraseña() As String
        Get
            Return Lacontraseña
        End Get
        Set(ByVal Values As String)
            Lacontraseña = Values
        End Set
    End Property

    Public Property getSetEltelefono() As Long
        Get
            Return Eltelefono
        End Get
        Set(ByVal Values As Long)
            Eltelefono = Values
        End Set
    End Property

    Public Property getSetElnivel() As Byte
        Get
            Return Elnivel
        End Get
        Set(ByVal Values As Byte)
            Elnivel = Values
        End Set
    End Property

    'metodo para insertar un usuario al momento de agregarlo
    Public Sub insertarUsuario()
        Dim strSql As String
        Dim xconexion As New ConexionBD

        'verificamos que los campos no esten vacios
        If Lamatricula <> "" And Elnombre <> "" And Elpaterno <> "" And
        Elmaterno <> "" And Lacontraseña <> "" Then

            strSql = "insert into usuarios values('" & Lamatricula & "', '" &
                                                  Elnombre & "', '" &
                                                  Elpaterno & "', '" &
                                                  Elmaterno & "', '" &
                                                  Lacontraseña & "', '" &
                                                  Elnivel & "', '" &
                                                  Eltelefono & "')"
            xconexion.objetoCommand(strSql)
            MsgBox("El usuario se ha guardado correctamente", Title:="Laboratorio ITS")
        Else
            MsgBox("Faltan campos por llenar!!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarUsuario()
        Dim strSql As String
        Dim xconexion As New ConexionBD

        strSql = "DELETE FROM USUARIOS WHERE IDUSUARIO =" & Lamatricula
        xconexion.objetoCommand(strSql)
        MsgBox("Registro Eliminado", Title:="Laboratorio ITS")
    End Sub

    Public Sub modificarUsuario()
        Dim strSql As String
        Dim xconexion As New ConexionBD

        strSql = "UPDATE USUARIOS SET NOMBRE = '" & Elnombre & "', PATERNO = '" & Elpaterno & "', MATERNO = '" & Elmaterno &
                 "', CONTRASENA = '" & Lacontraseña & "', NIVEL = '" & Elnivel & "', TELEFONO = " & Eltelefono &
                 " WHERE IDUSUARIO = " & Lamatricula

        xconexion.objetoCommand(strSql)
        MsgBox("El usuario de ha modificado", Title:="Laboratorio ITS")
    End Sub

    Public Function busquedaDeUsuario() As Object
        Dim strSql As String
        Dim xconexion As New ConexionBD

        strSql = "SELECT idusuario as Matricula, nombre as Nombre, paterno as Paterno, materno as Materno," &
                 "contrasena as Contraseña, descnivel as Nivel, telefono as Telefono" &
                 " From usuarios, nivelusuario where usuarios.nivel = nivelusuario.nivel " &
                 "and IDUSUARIO LIKE '" & buscar & "%' order by nombre asc"
        'or NOMBRE LIKE '" & Usuarios.txt_buscarU.Text & "%'"
        busquedaDeUsuario = xconexion.objetoDataAdapter(strSql)
    End Function

    Public Function buscaUsuario() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New ConexionBD
        Dim xDT As DataTable
        '
        strSQL = "SELECT * FROM usuarios " &
                 "WHERE idusuario='" & Lamatricula & "'"
        buscaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            buscaUsuario = True
        End If

    End Function

    Public Function contarAdmins() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New ConexionBD
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM usuarios, nivelusuario " &
                 "WHERE usuarios.nivel = nivelusuario.nivel and nivelusuario.descnivel='Administrador'"
        contarAdmins = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 2 Then
            contarAdmins = True
        End If

    End Function

    Public Function esAdmin() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New ConexionBD
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM usuarios, nivelusuario where usuarios.nivel = nivelusuario.nivel and " &
                 "nivelusuario.descnivel='Administrador' and idusuario =" & Lamatricula
        esAdmin = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            esAdmin = True
        End If

    End Function

    Public Function consultaTodosUsuarios() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "SELECT idusuario as Matricula, nombre as Nombre, paterno as Paterno, materno as Materno, contrasena as Contraseña, descnivel as Nivel, telefono as Telefono" &
                 " From usuarios, nivelusuario where usuarios.nivel = nivelusuario.nivel order by nombre asc"
        consultaTodosUsuarios = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridUsuarios(ByVal DGVUsuarios As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        If pdgvU <> 2 Then
            DGVUsuarios.DataSource = consultaTodosUsuarios()
        Else
            DGVUsuarios.DataSource = busquedaDeUsuario()
        End If
        DGVUsuarios.Refresh()
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(1).Width = 100
        DGVUsuarios.Columns.Item(2).Width = 100
        DGVUsuarios.Columns.Item(3).Width = 100
        DGVUsuarios.Columns.Item(4).Width = 100
        DGVUsuarios.Columns.Item(5).Width = 100
        DGVUsuarios.Columns.Item(6).Width = 100

    End Sub
End Class
