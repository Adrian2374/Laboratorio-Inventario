Public Class Laboratorios
    Private nombreLaboratorio As String
    Public idLaboratorio As Integer

    Private Sub btn_AgregarLab_Click(sender As Object, e As EventArgs) Handles btn_AgregarLab.Click
        accion = 1
        AgregarLab.Show()
        'AgregarLab.AceptarAgLab.PerformClick()
    End Sub

    Private Sub btn_BorrarLab_Click(sender As Object, e As EventArgs) Handles btn_BorrarLab.Click
        Dim objLab As New ClaseLaboratorios()

        If MessageBox.Show("Está seguro que desea eliminar el laboratorio '" & RTrim(nombreLaboratorio) & "'?", "Borrar laboratorio", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            objLab.BorrarLab(idLaboratorio)
            MsgBox("Laboratorio borrado exitosamente", Title:="Laboratorio ITS")
            objLab.PoblarDGVLab(DGVLab)
        End If
    End Sub




    Private Sub btn_ModificarLab_Click(sender As Object, e As EventArgs) Handles btn_ModificarLab.Click
        Dim objLab As New ClaseLaboratorios()
        Dim renglon As Integer

        renglon = DGVLab.CurrentCellAddress.Y
        accion = 2

        idLaboratorio = DGVLab.Rows(renglon).Cells(0).Value
        AgregarLab.txt_nombreLab.Text = RTrim(DGVLab.Rows(renglon).Cells(1).Value)

        AgregarLab.Show()
    End Sub

    Private Sub Laboratorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objLab As New ClaseLaboratorios()
        objLab.PoblarDGVLab(DGVLab)
    End Sub

    Private Sub DGVLab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLab.CellClick
        Dim renglon As Integer
        renglon = DGVLab.CurrentCellAddress.Y
        idLaboratorio = DGVLab.Rows(renglon).Cells(0).Value
        nombreLaboratorio = DGVLab.Rows(renglon).Cells(1).Value
    End Sub
End Class