Public Class ClaseSalidas
    Public NumeroSalida As Integer
    Public nombreMaterial As String
    Public MatriculaSolicitante As Integer
    Public IdMaterial As Integer
    Public cantidadDeseada As Integer
    Public cantidadDisponible As Integer
    Public nuevaCantidad As Integer



    'Constructor vacio
    Public Sub New()

    End Sub



    'Constructor de DetallesSalidas
    Public Sub New(ByVal idMateriales As Integer,
                   ByVal cantidad As Integer)

    End Sub



    '
    Public Function obtenerCantidad()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT cantidad
                  FROM Almacen 
                  WHERE idMaterial= " & IdMaterial
        obtenerCantidad = xCnx.objetoScalar(strSQL)
    End Function



    '
    Public Function sacarMateriales()
        Dim xCnx As New ConexionBD
        strSQL = "UPDATE Almacen
                    SET cantidad= " & nuevaCantidad & " 
                    WHERE idMaterial= " & IdMaterial
        xCnx.objetoCommand(strSQL)
    End Function



    'Crea la salida con los datos del solicitante y el usuario que entrega los materiales
    Public Function crearSalida()
        Dim xCnx As New ConexionBD
        strSQL = "INSERT INTO Salidas VALUES (" & NumeroSalida & ", 1, " & NuevaSalida.txt_Matricula.Text & ", '" & Today & "')"
        xCnx.objetoCommand(strSQL)
    End Function



    'Insert que ingresa un material y la cantidad del carrito
    Public Function detallesSalida()
        Dim xCnx As New ConexionBD

        strSQL = "INSERT INTO DetallesSalidas VALUES (" & NumeroSalida & ", " & IdMaterial & ", " & cantidadDeseada & ")"
        xCnx.objetoCommand(strSQL)
    End Function



    'Lista de materiales de la base de datos
    Public Function consultarMateriales()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT nombreMaterial as Material, cantidad as Cantidad 
                  FROM Materiales, Almacen 
                  WHERE Almacen.idMaterial = Materiales.idMaterial ORDER BY 1"
        consultarMateriales = xCnx.objetoDataAdapter(strSQL)
    End Function



    'Busqueda de un material en especifico segun su nombre
    Public Function buscarMaterial()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT nombreMaterial as Material, cantidad as Cantidad 
                  FROM Materiales, Almacen 
                  WHERE Almacen.idMaterial = Materiales.idMaterial AND nombreMaterial LIKE '%" & nombreMaterial & "%' ORDER BY 1"
        buscarMaterial = xCnx.objetoDataAdapter(strSQL)
    End Function



    'Obtencion del ID de un material en concreto segun su nombre
    Public Function getIdMat()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT idMaterial
                 FROM Materiales
                 WHERE nombreMaterial= '" & nombreMaterial & "'" 'RTrim(NuevaSalida.DGVCarrito.Rows(Vi).Cells(0).Value) & "'"
        getIdMat = xCnx.objetoScalar(strSQL)
    End Function



    'Consulta de los detalles de una salida (lista de materiales y la cantidad)
    Public Function consultarPedido()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT Materiales.nombreMaterial as Materiales, DetallesSalidas.cantidad as Cantidad
                FROM Salidas, Materiales, Almacen, DetallesSalidas
                WHERE Salidas.idSalida= " & NumeroSalida & " AND 
                      Salidas.idSalida = DetallesSalidas.idSalida AND 
                      DetallesSalidas.idMaterial = Almacen.idMaterial AND 
                      Almacen.idMaterial = Materiales.idMaterial"
        consultarPedido = xCnx.objetoDataAdapter(strSQL)
    End Function



    'Consulta del nombre del solicitante que pidió la salida en cuestion
    Public Function consultarSolicitante()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT Solicitantes.nombre||' '||Solicitantes.paterno||' '||Solicitantes.materno
                  FROM Solicitantes, Salidas 
                  WHERE idSalida = " & NumeroSalida & " AND Salidas.idSolicitante = Solicitantes.idSolicitante"
        consultarSolicitante = xCnx.objetoScalar(strSQL)
    End Function



    'Consulta del nombre del usuario que entregó la salida en cuestion
    Public Function consultarUsuario()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno
                  FROM Usuarios, Salidas 
                  WHERE idSalida = " & NumeroSalida & " AND Salidas.idUsuario = Usuarios.idUsuario"
        consultarUsuario = xCnx.objetoScalar(strSQL)
    End Function



    'Consulta de la fecha en que se entregó la salida en cuestion
    Public Function consultarFecha()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT fecha
                  FROM Salidas 
                  WHERE idSalida = " & NumeroSalida
        consultarFecha = xCnx.objetoScalar(strSQL)
    End Function



    'Obtencion del siguiente ID de salida
    Public Function obtenerIdSalida()
        Dim xCnx As New ConexionBD
        strSQL = "SELECT Salidas_Seq.NextVal from dual"
        obtenerIdSalida = xCnx.objetoScalar(strSQL)
    End Function



    'Metodo para mostrar la salida que el usuario busque
    Public Sub PoblarDGVSalidas(ByVal DGVSalidasLab As DataGridView)
        DGVSalidasLab.DataSource = consultarPedido()
        DGVSalidasLab.Refresh()
        DGVSalidasLab.Columns.Item(0).Width = 100
        DGVSalidasLab.Columns.Item(1).Width = 100
    End Sub



    'Metodo para mostrar la lista de materiales de la base de datos o para mostrar el material que el usuario esta buscando
    Public Sub PoblarDGVMateriales(ByVal DGVMat As DataGridView)
        If pdgv = 1 Then
            DGVMat.DataSource = consultarMateriales()
        Else
            DGVMat.DataSource = buscarMaterial()
        End If
        DGVMat.Refresh()
        DGVMat.Columns.Item(0).Width = 100
        DGVMat.Columns.Item(1).Width = 100
    End Sub

End Class
