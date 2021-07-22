Public Class ClaseReportes
    Public usuario As String
    Public Function consultaFecha() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "SELECT Entradas.idEntrada as Entrada, Usuarios.nombre||' '||Usuarios.paterno||' '||Usuarios.materno as Usuario, nombreMaterial as Material, DetallesEntradas.cantidad as Cantidad " &
                  "FROM Entradas, Usuarios, DetallesEntradas, Almacen, Materiales " &
                  "WHERE Entradas.idUsuario = Usuarios.idUsuario AND " &
                  "Entradas.identrada = DetallesEntradas.identrada AND " &
                  "DetallesEntradas.idMaterial = Almacen.idMaterial AND " &
                  "Almacen.idMaterial = Materiales.idMaterial AND " &
                  "fecha Like '" & ReportesEntradas.MonthCalendar1.SelectionStart.ToString("dd/MM/yy") & "%' ORDER BY 1"
        consultaFecha = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Function consultaReporteU() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xconexion As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "Select e.identrada as Entrada, nombreMaterial as Material, d.cantidad as Cantidad, " &
            "to_char(fecha, 'DD-MM-YYYY') as Fecha from materiales m, almacen a, entradas e, detallesEntradas d where " &
            "d.identrada = e.identrada and d.idmaterial = a.idmaterial and a.idmaterial = m.idmaterial " &
             "and idusuario = " & usuario & " order by e.identrada asc"
        consultaReporteU = xconexion.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridReportesEUsuarios(ByVal DGVReportes As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVReportes.DataSource = consultaReporteU()
        DGVReportes.Refresh()
        DGVReportes.Columns.Item(0).Width = 150
        DGVReportes.Columns.Item(1).Width = 100
        DGVReportes.Columns.Item(2).Width = 100
        DGVReportes.Columns.Item(3).Width = 100

    End Sub

    Public Sub PoblarDataGridReportesFechas(ByVal DGVReportes As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVReportes.DataSource = consultaFecha()
        DGVReportes.Refresh()
        DGVReportes.Columns.Item(0).Width = 150
        DGVReportes.Columns.Item(1).Width = 100
        DGVReportes.Columns.Item(2).Width = 100
        DGVReportes.Columns.Item(3).Width = 100

    End Sub
End Class
