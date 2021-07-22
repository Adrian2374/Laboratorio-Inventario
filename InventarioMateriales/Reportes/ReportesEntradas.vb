Public Class ReportesEntradas
    Private Sub CBReportesE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBReportesE.SelectedIndexChanged
        If CBReportesE.SelectedItem = "No. de entrada" Then
            label_noEn.Visible = True
            label_usuarioE.Visible = True
            label_fechaE.Visible = True
            txt_noEntradaE.Visible = True
            txt_usuarioE.Visible = True
            txt_fechaE.Visible = True
            btn_buscarE.Visible = True
            DGVEntradaM.Visible = True

            label_matriculaU.Visible = False
            txt_reporteU.Visible = False
            DGVReportesEU.Visible = False
            btn_buscarMatE.Visible = False
            labelU.Visible = False

            MonthCalendar1.Visible = False
            DGVFecha.Visible = False

        ElseIf CBReportesE.SelectedItem = "Usuario" Then
            label_matriculaU.Visible = True
            txt_reporteU.Visible = True
            DGVReportesEU.Visible = True
            btn_buscarMatE.Visible = True
            labelU.Visible = True

            label_noEn.Visible = False
            label_usuarioE.Visible = False
            label_fechaE.Visible = False
            txt_noEntradaE.Visible = False
            txt_usuarioE.Visible = False
            txt_fechaE.Visible = False
            btn_buscarE.Visible = False
            DGVEntradaM.Visible = False

            MonthCalendar1.Visible = False
            DGVFecha.Visible = False

        ElseIf CBReportesE.SelectedItem = "Fecha" Then
            MonthCalendar1.Visible = True
            DGVFecha.Visible = True

            label_noEn.Visible = False
            label_usuarioE.Visible = False
            label_fechaE.Visible = False
            txt_noEntradaE.Visible = False
            txt_usuarioE.Visible = False
            txt_fechaE.Visible = False
            btn_buscarE.Visible = False
            DGVEntradaM.Visible = False

            label_matriculaU.Visible = False
            txt_reporteU.Visible = False
            DGVReportesEU.Visible = False
            btn_buscarMatE.Visible = False
            labelU.Visible = False
        End If
    End Sub

    Private Sub txt_noEntradaE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_noEntradaE.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_buscarE_Click(sender As Object, e As EventArgs) Handles btn_buscarE.Click
        Dim xconexion As New ConexionBD
        Dim entradas As New ClaseEntradas
        If txt_noEntradaE.Text <> vbNullString Then
            txt_noEntradaE.Text = txt_noEntradaE.Text.Replace(" "c, String.Empty)
            txt_usuarioE.Text = xconexion.objetoScalar("Select nombre ||' '|| paterno ||' '|| materno from usuarios " &
                                                   "where idusuario = (Select idusuario from entradas " &
                                                   "where identrada = " & Trim(txt_noEntradaE.Text) & ")")

            txt_fechaE.Text = xconexion.objetoScalar("Select to_char(fecha, 'DD-MM-YYYY') from entradas where identrada = " & Trim(txt_noEntradaE.Text))
            entradas.PoblarDataGridDetallesE(DGVEntradaM, Trim(txt_noEntradaE.Text))
        Else
            MsgBox("Introduzca un numero de entrada!!", Title:="Laboratorio ITS")
        End If
    End Sub

    Private Sub btn_buscarMatE_Click(sender As Object, e As EventArgs) Handles btn_buscarMatE.Click
        Dim xcnx As New ConexionBD
        Dim reporte As New ClaseReportes
        reporte.usuario = txt_reporteU.Text
        reporte.usuario = reporte.usuario.Replace(" "c, String.Empty)
        labelU.Text = "Usuario: " & xcnx.objetoScalar("Select nombre ||' '|| paterno ||' '|| materno from usuarios " &
                                                      "where idusuario = " & txt_reporteU.Text)
        reporte.PoblarDataGridReportesEUsuarios(DGVReportesEU)
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim reporte As New ClaseReportes
        reporte.PoblarDataGridReportesFechas(DGVFecha)

    End Sub

    Private Sub btn_nuevaEntradaE_Click(sender As Object, e As EventArgs) Handles btn_nuevaEntradaE.Click
        NuevaEntrada.Show()
    End Sub
End Class