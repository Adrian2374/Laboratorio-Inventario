Public Class ClaseLaboratorios
    Public nombreLab As String
    Public idLab As Integer



    Public Sub New(ByVal numeroLab As Integer, ByVal txt_nombreLab As String)
        idLab = numeroLab
        nombreLab = txt_nombreLab
    End Sub



    Public Sub New()

    End Sub



    Public Sub AgregarLab()
        Dim xCnx As New ConexionBD
        str = "INSERT INTO Laboratorios VALUES (Lab_Seq.nextval, '" & nombreLab & "')                                                   "
        xCnx.objetoCommand(str)
    End Sub



    Public Sub BorrarLab(ByVal idLab)
        Dim xCnx As New ConexionBD
        str = "DELETE FROM Laboratorios WHERE idLaboratorio=" & idLab
        xCnx.objetoCommand(str)
    End Sub



    Public Sub ModificarLab()
        Dim xCnx As New ConexionBD
        str = "UPDATE Laboratorios SET nombreLab='" & nombreLab & "' WHERE idLaboratorio=" & Laboratorios.idLaboratorio
        xCnx.objetoCommand(str)
    End Sub



    Public Function ConsultarLabs()
        Dim xCnx As New ConexionBD

        str = "SELECT idLaboratorio as Identificador, nombreLab as Nombre FROM Laboratorios ORDER BY 1"
        ConsultarLabs = xCnx.objetoDataAdapter(str)
    End Function

    Public Sub PoblarDGVLab(ByVal DGVLab As DataGridView)
        DGVLab.DataSource = ConsultarLabs()
        DGVLab.Refresh()
        DGVLab.Columns.Item(0).Width = 100
        DGVLab.Columns.Item(1).Width = 100
    End Sub
End Class
