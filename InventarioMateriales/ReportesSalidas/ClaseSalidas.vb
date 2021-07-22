Public Class ClaseSalidas
    Public NumeroSalida As Integer
    Public nombreMaterial As String
    Public MatriculaSolicitante As Integer
    Public IdMaterial As Integer
    Public cantidadDeseada As Integer
    Public cantidadDisponible As Integer
    Public nuevaCantidad As Integer
    Public NombreSolicitante, PaternoSolicitante, MaternoSolicitante, fecha1, fecha2 As String



    'Constructor vacio
    Public Sub New()

    End Sub



    'Constructor de DetallesSalidas
    Public Sub New(ByVal idMateriales As Integer,
                   ByVal cantidad As Integer)

    End Sub



    '
    Public Function salidaXNombre()
        Dim xCnx As New ConexionBD
        str = "SELECT Salidas.idSalida as Salida, Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno as Entregó, nombreMaterial as Material, DetallesSalidas.cantidad as Cantidad
                  FROM Salidas, Usuarios, DetallesSalidas, Almacen, Materiales, Solicitantes
                  WHERE Solicitantes.nombre like '" & NombreSolicitante & "%' AND
                  Solicitantes.paterno like '" & PaternoSolicitante & "%' AND
                  Solicitantes.materno like '" & MaternoSolicitante & "%' AND
                  Salidas.idUsuario = Usuarios.idUsuario AND
                  Salidas.idSalida = DetallesSalidas.idSalida AND
                  DetallesSalidas.idMaterial = Almacen.idMaterial AND
                  Almacen.idMaterial = Materiales.idMaterial AND
                  Salidas.idSolicitante = Solicitantes.idSolicitante"
        salidaXNombre = xCnx.objetoDataAdapter(str)
    End Function



    '
    Public Function salidaXNumCtrl()
        Dim xCnx As New ConexionBD
        str = "SELECT Salidas.idSalida as Salida, Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno as Entregó, nombreMaterial as Material, DetallesSalidas.cantidad as Cantidad
                  FROM Salidas, Usuarios, DetallesSalidas, Almacen, Materiales
                  WHERE idSolicitante= " & MatriculaSolicitante & " AND
                  Salidas.idUsuario = Usuarios.idUsuario AND
                  Salidas.idSalida = DetallesSalidas.idSalida AND
                  DetallesSalidas.idMaterial = Almacen.idMaterial AND
                  Almacen.idMaterial = Materiales.idMaterial ORDER BY 1"
        salidaXNumCtrl = xCnx.objetoDataAdapter(str)
    End Function



    '
    Public Function salidaXFechas()
        Dim xCnx As New ConexionBD
        str = "SELECT Salidas.idSalida as Salida, Solicitantes.nombre||' '||Solicitantes.paterno||' '||Solicitantes.materno as Solicitante, Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno as Entregó, nombreMaterial as Material, DetallesSalidas.cantidad as Cantidad
                  FROM Salidas, Usuarios, Solicitantes, DetallesSalidas, Almacen, Materiales
                  WHERE Salidas.idUsuario = Usuarios.idUsuario AND
                  Salidas.idSolicitante = Solicitantes.idSolicitante AND
                  Salidas.idSalida = DetallesSalidas.idSalida AND
                  DetallesSalidas.idMaterial = Almacen.idMaterial AND
                  Almacen.idMaterial = Materiales.idMaterial AND
                  Salidas.fecha BETWEEN '" & fecha1 & "' AND '" & fecha2 & "' ORDER BY 1"
        salidaXFechas = xCnx.objetoDataAdapter(str)
    End Function



    '
    Public Function obtenerCantidad()
        Dim xCnx As New ConexionBD
        str = "SELECT cantidad
                  FROM Almacen 
                  WHERE idMaterial= " & IdMaterial
        obtenerCantidad = xCnx.objetoScalar(str)
    End Function



    '
    Public Function sacarMateriales()
        Dim xCnx As New ConexionBD
        str = "UPDATE Almacen
                    SET cantidad= " & nuevaCantidad & " 
                    WHERE idMaterial= " & IdMaterial
        xCnx.objetoCommand(str)
    End Function



    'Crea la salida con los datos del solicitante y el usuario que entrega los materiales
    Public Function crearSalida()
        Dim xCnx As New ConexionBD
        str = "INSERT INTO Salidas VALUES (" & NumeroSalida & ", 1, " & NuevaSalida.txt_Matricula.Text & ", '" & Today & "')"
        xCnx.objetoCommand(str)
    End Function



    'Insert que ingresa un material y la cantidad del carrito
    Public Function detallesSalida()
        Dim xCnx As New ConexionBD

        str = "INSERT INTO DetallesSalidas VALUES (" & NumeroSalida & ", " & IdMaterial & ", " & cantidadDeseada & ")"
        xCnx.objetoCommand(str)
    End Function



    'Lista de materiales de la base de datos
    Public Function consultarMateriales()
        Dim xCnx As New ConexionBD
        str = "SELECT nombreMaterial as Material, cantidad as Cantidad 
                  FROM Materiales, Almacen 
                  WHERE Almacen.idMaterial = Materiales.idMaterial ORDER BY 1"
        consultarMateriales = xCnx.objetoDataAdapter(str)
    End Function



    'Busqueda de un material en especifico segun su nombre
    Public Function buscarMaterial()
        Dim xCnx As New ConexionBD
        str = "SELECT nombreMaterial as Material, cantidad as Cantidad 
                  FROM Materiales, Almacen 
                  WHERE Almacen.idMaterial = Materiales.idMaterial AND nombreMaterial LIKE '%" & nombreMaterial & "%' ORDER BY 1"
        buscarMaterial = xCnx.objetoDataAdapter(str)
    End Function



    'Obtencion del ID de un material en concreto segun su nombre
    Public Function getIdMat()
        Dim xCnx As New ConexionBD
        str = "SELECT idMaterial
                 FROM Materiales
                 WHERE nombreMaterial= '" & nombreMaterial & "'" 'RTrim(NuevaSalida.DGVCarrito.Rows(Vi).Cells(0).Value) & "'"
        getIdMat = xCnx.objetoScalar(str)
    End Function



    'Consulta de los detalles de una salida (lista de materiales y la cantidad)
    Public Function consultarPedido()
        Dim xCnx As New ConexionBD
        str = "SELECT Materiales.nombreMaterial as Materiales, DetallesSalidas.cantidad as Cantidad
                FROM Salidas, Materiales, Almacen, DetallesSalidas
                WHERE Salidas.idSalida= " & NumeroSalida & " AND 
                      Salidas.idSalida = DetallesSalidas.idSalida AND 
                      DetallesSalidas.idMaterial = Almacen.idMaterial AND 
                      Almacen.idMaterial = Materiales.idMaterial"
        consultarPedido = xCnx.objetoDataAdapter(str)
    End Function



    'Consulta del nombre del solicitante que pidió la salida en cuestion
    Public Function consultarSolicitante()
        Dim xCnx As New ConexionBD
        str = "SELECT Solicitantes.nombre||' '||Solicitantes.paterno||' '||Solicitantes.materno
                  FROM Solicitantes, Salidas 
                  WHERE idSalida = " & NumeroSalida & " AND Salidas.idSolicitante = Solicitantes.idSolicitante"
        consultarSolicitante = xCnx.objetoScalar(str)
    End Function



    'Consulta del nombre del usuario que entregó la salida en cuestion
    Public Function consultarUsuario()
        Dim xCnx As New ConexionBD
        str = "SELECT Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno
                  FROM Usuarios, Salidas 
                  WHERE idSalida = " & NumeroSalida & " AND Salidas.idUsuario = Usuarios.idUsuario"
        consultarUsuario = xCnx.objetoScalar(str)
    End Function



    'Consulta de la fecha en que se entregó la salida en cuestion
    Public Function consultarFecha()
        Dim xCnx As New ConexionBD
        str = "SELECT fecha
                  FROM Salidas 
                  WHERE idSalida = " & NumeroSalida
        consultarFecha = xCnx.objetoScalar(str)
    End Function



    'Obtencion del siguiente ID de salida
    Public Function obtenerIdSalida()
        Dim xCnx As New ConexionBD
        str = "SELECT Salidas_Seq.NextVal from dual"
        obtenerIdSalida = xCnx.objetoScalar(str)
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


    Public Sub PoblarDGVRequerimientos(ByVal DGVRequerimientos As DataGridView)
        If searchOption = 1 Then
            DGVRequerimientos.DataSource = consultarPedido()
            DGVRequerimientos.Refresh()
            DGVRequerimientos.Columns.Item(0).Width = 100
            DGVRequerimientos.Columns.Item(1).Width = 100

        ElseIf searchOption = 2 Then
            DGVRequerimientos.DataSource = salidaXNombre()
            DGVRequerimientos.Refresh()
            DGVRequerimientos.Columns.Item(0).Width = 70
            DGVRequerimientos.Columns.Item(1).Width = 125
            DGVRequerimientos.Columns.Item(2).Width = 125
            DGVRequerimientos.Columns.Item(3).Width = 70

        ElseIf searchOption = 3 Then
            DGVRequerimientos.DataSource = salidaXNumCtrl()
            DGVRequerimientos.Refresh()
            DGVRequerimientos.Columns.Item(0).Width = 70
            DGVRequerimientos.Columns.Item(1).Width = 120
            DGVRequerimientos.Columns.Item(2).Width = 120
            DGVRequerimientos.Columns.Item(3).Width = 70

        ElseIf searchOption = 4 Then
            DGVRequerimientos.DataSource = salidaXFechas()
            DGVRequerimientos.Refresh()
            DGVRequerimientos.Columns.Item(0).Width = 70
            DGVRequerimientos.Columns.Item(1).Width = 82
            DGVRequerimientos.Columns.Item(2).Width = 82
            DGVRequerimientos.Columns.Item(3).Width = 70
            DGVRequerimientos.Columns.Item(4).Width = 70
        End If

    End Sub

End Class
