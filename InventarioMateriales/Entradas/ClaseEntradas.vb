Public Class ClaseEntradas
    Private elIdMaterial As Integer
    Private laCantidad As Integer
    Private elUsuario As Integer
    Public nombreMat As String
    Public pdgvNE As Byte
    Public secuencia As Integer

    Public Sub New(ByVal idMaterial As Integer,
                   ByVal cantidad As Integer,
                   ByVal usuario As String)
        elIdMaterial = idMaterial
        laCantidad = cantidad
        elUsuario = usuario
    End Sub

    Public Sub New()

    End Sub

    Public Sub insertarEntrada()
        Dim strSQL As String
        Dim xconexion As New ConexionBD

        secuencia = xconexion.objetoScalar("Select Entradas_Seq.nextval from dual")

        strSQL = "INSERT INTO entradas VALUES(" & secuencia & ", " & usuarioConnect & ", (Select sysdate from dual))"
        xconexion.objetoCommand(strSQL)
    End Sub

    Public Sub insertarDetallesEntrada(ByVal idMat As Integer, ByVal cantidad As Integer)
        Dim strSQL As String
        Dim xconexion As New ConexionBD

        strSQL = "INSERT INTO detallesentradas VALUES(" & secuencia & ", " & idMat & ", " & cantidad & ")"
        xconexion.objetoCommand(strSQL)
        xconexion.objetoCommand("update almacen set cantidad = " &
                                "((select cantidad from almacen where idmaterial = " & idMat & ") + " & cantidad & ")" &
                                "where idmaterial = " & idMat)
    End Sub

    Public Function buscarMaterial() As Object
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        strSQL = "SELECT nombrematerial As Material, cantidad As Cantidad FROM MATERIALES, ALMACEN " &
            "WHERE MATERIALES.IDMATERIAL = ALMACEN.IDMATERIAL And nombrematerial Like '" & nombreMat & "%' " &
            "ORDER BY NOMBREMATERIAL ASC"
        buscarMaterial = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Function consultaTodosMateriales() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "SELECT nombrematerial As Material, cantidad As Cantidad FROM MATERIALES, ALMACEN " &
            "WHERE MATERIALES.IDMATERIAL = ALMACEN.IDMATERIAL ORDER BY NOMBREMATERIAL ASC"
        consultaTodosMateriales = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Function consultaDetallesE(ByVal idEntrada As Integer) As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "SELECT nombrematerial As Material, DetallesEntradas.cantidad As Cantidad FROM MATERIALES, ALMACEN, DetallesEntradas " &
            "WHERE DetallesEntradas.IDMATERIAL = ALMACEN.IDMATERIAL " &
        "and MATERIALES.IDMATERIAL = ALMACEN.IDMATERIAL and identrada = " & idEntrada & " ORDER BY NOMBREMATERIAL ASC"
        consultaDetallesE = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridMateriales(ByVal DGVMaterial As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        If pdgvNE <> 2 Then
            DGVMaterial.DataSource = consultaTodosMateriales()
        Else
            DGVMaterial.DataSource = buscarMaterial()
        End If
        DGVMaterial.Refresh()
        DGVMaterial.Columns.Item(0).Width = 100
        DGVMaterial.Columns.Item(1).Width = 100

    End Sub

    Public Sub PoblarDataGridDetallesE(ByVal DGVMaterial As DataGridView, ByVal idEntrada As Integer)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVMaterial.DataSource = consultaDetallesE(idEntrada)
        DGVMaterial.Refresh()
        DGVMaterial.Columns.Item(0).Width = 100
        DGVMaterial.Columns.Item(1).Width = 100

    End Sub
End Class
