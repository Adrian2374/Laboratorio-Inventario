Public Class AgregarLab

    Private Sub btn_CancelarAgLab_Click(sender As Object, e As EventArgs) Handles btn_CancelarAgLab.Click
        Me.Close()
    End Sub



    Private Sub btn_AceptarAgLab_Click(sender As Object, e As EventArgs) Handles btn_AceptarAgLab.Click
        Dim objLab As New ClaseLaboratorios()

        If txt_nombreLab.Text <> String.Empty Then
            If accion = 1 Then
                objLab.nombreLab = txt_nombreLab.Text
                objLab.AgregarLab()
                objLab.PoblarDGVLab(Laboratorios.DGVLab)
                MsgBox("Laboratorio ingresado exitosamente.", Title:="Laboratorios ITS")
            Else
                objLab.nombreLab = txt_nombreLab.Text
                objLab.ModificarLab()
                objLab.PoblarDGVLab(Laboratorios.DGVLab)
                MsgBox("Laboratorio modificado exitosamente.", Title:="Laboratorios ITS")
            End If
            Me.Close()
        Else
            MsgBox("Debes escribir un nombre para el laboratorio.")
        End If
    End Sub

    Private Sub AgregarLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class