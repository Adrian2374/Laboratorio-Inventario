Public Class Salidas

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Me.Hide()
        NuevaSalida.Show()
    End Sub


    Private Sub btn_BuscarSalida_Click(sender As Object, e As EventArgs) Handles btn_BuscarSalida.Click
        Dim objSal As New ClaseSalidas()

        txt_NumSalida.Text = txt_NumSalida.Text.Replace(" "c, String.Empty)
        If txt_NumSalida.Text <> vbNullString Then
            objSal.NumeroSalida = txt_NumSalida.Text
            txt_Solicitante.Text = CStr(objSal.consultarSolicitante)
            If txt_Solicitante.Text <> String.Empty Then
                txt_Usuario.Text = CStr(objSal.consultarUsuario)
                txt_Fecha.Text = CStr(objSal.consultarFecha)

                objSal.PoblarDGVSalidas(DGVSalidas)
            Else
                MsgBox("La salida que buscas no existe.")
            End If
        Else
            MsgBox("No has especificado el numero de salida que deseas buscar.")
        End If

    End Sub



    Private Sub Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSal As New ClaseSalidas()
        objSal.PoblarDGVSalidas(DGVSalidas)
    End Sub
End Class