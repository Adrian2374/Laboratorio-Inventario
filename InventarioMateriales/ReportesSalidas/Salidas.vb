Public Class Salidas

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Me.Hide()
        NuevaSalida.Show()
    End Sub


    Private Sub btn_BuscarSalida_Click(sender As Object, e As EventArgs) Handles btn_BuscarSalida.Click
        Dim objSal As New ClaseSalidas()

        txt_datoRequerido.Text = txt_datoRequerido.Text.Replace(" "c, String.Empty)
        If txt_datoRequerido.Text <> vbNullString Then

            If searchOption = 1 Then
                objSal.NumeroSalida = txt_datoRequerido.Text
                txt_Solicitante.Text = CStr(objSal.consultarSolicitante)
                If txt_Solicitante.Text <> String.Empty Then
                    txt_Usuario.Text = CStr(objSal.consultarUsuario)
                    txt_Fecha.Text = CStr(objSal.consultarFecha)

                    objSal.PoblarDGVSalidas(DGVSalidas)
                Else
                    MsgBox("La salida que buscas no existe.")
                End If
            ElseIf searchOption = 2 Then
                objSal.NombreSolicitante = txt_datoRequerido.Text
                objSal.PaternoSolicitante = txt_fecha2.Text
                objSal.MaternoSolicitante = txt_materno.Text
                objSal.PoblarDGVRequerimientos(DGVRequerimientos)


            ElseIf searchOption = 3 Then
                objSal.MatriculaSolicitante = txt_datoRequerido.Text
                objSal.PoblarDGVRequerimientos(DGVRequerimientos)

            ElseIf searchOption = 4 Then
                objSal.fecha1 = txt_datoRequerido.Text
                objSal.fecha2 = txt_fecha2.Text
                objSal.PoblarDGVRequerimientos(DGVRequerimientos)

            End If


        Else
                MsgBox("No has especificado el campo de la salida que deseas buscar.")
        End If

    End Sub



    Private Sub Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSal As New ClaseSalidas()
        objSal.PoblarDGVSalidas(DGVSalidas)
        searchOption = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoptionsSalidas.SelectedIndexChanged
        If CBoptionsSalidas.SelectedItem = "Numero de salida" Then
            searchOption = 1
            NoOrden.Visible = True
            txt_datoRequerido.Visible = True
            Solicitante.Visible = True
            txt_Solicitante.Visible = True
            Usuario.Visible = True
            txt_Usuario.Visible = True
            Fecha.Visible = True
            txt_Fecha.Visible = True
            btn_BuscarSalida.Visible = True
            DGVRequerimientos.Visible = False
            DGVSalidas.Visible = True
            DGVSalidas.Width = 240
            fecha2.Visible = False
            txt_fecha2.Visible = False
            formato1.Visible = False
            formato2.Visible = False
            materno.Visible = False

            txt_datoRequerido.Text = String.Empty
            txt_Fecha.Text = String.Empty
            txt_fecha2.Text = String.Empty
            txt_materno.Text = String.Empty
            txt_Solicitante.Text = String.Empty
            txt_Usuario.Text = String.Empty

        ElseIf CBoptionsSalidas.SelectedItem = "Nombre del solcitante" Then
            searchOption = 2
            NoOrden.Text = "Nombre"
            NoOrden.Visible = True
            fecha2.Text = "Paterno"
            materno.Visible = True
            txt_materno.Visible = True
            DGVSalidas.Width = 420
            txt_datoRequerido.Visible = True
            Solicitante.Visible = False
            txt_Solicitante.Visible = False
            Usuario.Visible = False
            txt_Usuario.Visible = False
            Fecha.Visible = False
            txt_Fecha.Visible = False
            btn_BuscarSalida.Visible = True
            DGVRequerimientos.Visible = True
            DGVSalidas.Visible = False
            fecha2.Visible = True
            txt_fecha2.Visible = True
            formato1.Visible = False
            formato2.Visible = False

            txt_datoRequerido.Text = String.Empty
            txt_Fecha.Text = String.Empty
            txt_fecha2.Text = String.Empty
            txt_materno.Text = String.Empty
            txt_Solicitante.Text = String.Empty
            txt_Usuario.Text = String.Empty

        ElseIf CBoptionsSalidas.SelectedItem = "Matricula" Then
            searchOption = 3
            NoOrden.Text = "Matricula"
            DGVSalidas.Width = 420
            txt_datoRequerido.Visible = True
            Solicitante.Visible = False
            txt_Solicitante.Visible = False
            Usuario.Visible = False
            txt_Usuario.Visible = False
            Fecha.Visible = False
            txt_Fecha.Visible = False
            btn_BuscarSalida.Visible = True
            DGVRequerimientos.Visible = True
            DGVSalidas.Visible = False
            fecha2.Visible = False
            txt_fecha2.Visible = False
            formato1.Visible = False
            formato2.Visible = False
            materno.Visible = False
            txt_materno.Visible = False

            txt_datoRequerido.Text = String.Empty
            txt_Fecha.Text = String.Empty
            txt_fecha2.Text = String.Empty
            txt_materno.Text = String.Empty
            txt_Solicitante.Text = String.Empty
            txt_Usuario.Text = String.Empty

        ElseIf CBoptionsSalidas.SelectedItem = "Fechas" Then
            searchOption = 4
            NoOrden.Text = "Entre el dia"
            fecha2.Visible = True
            fecha2.Text = "y el"
            txt_fecha2.Visible = True
            DGVSalidas.Width = 420
            txt_datoRequerido.Visible = True
            Solicitante.Visible = False
            txt_Solicitante.Visible = False
            Usuario.Visible = False
            txt_Usuario.Visible = False
            Fecha.Visible = False
            txt_Fecha.Visible = False
            btn_BuscarSalida.Visible = True
            DGVSalidas.Visible = False
            DGVRequerimientos.Visible = True
            formato1.Visible = True
            formato2.Visible = True
            materno.Visible = False
            txt_materno.Visible = False

            txt_datoRequerido.Text = String.Empty
            txt_Fecha.Text = String.Empty
            txt_fecha2.Text = String.Empty
            txt_materno.Text = String.Empty
            txt_Solicitante.Text = String.Empty
            txt_Usuario.Text = String.Empty
        End If
    End Sub
End Class