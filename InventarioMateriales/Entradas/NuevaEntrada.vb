Public Class NuevaEntrada
    Private Sub NuevaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entrada As New ClaseEntradas
        txt_cantidadNE.Text = txt_cantidadNE.Text.Replace(" "c, String.Empty)
        entrada.PoblarDataGridMateriales(DGVMaterialesNE)
    End Sub

    Private Sub btn_agregarNE_Click(sender As Object, e As EventArgs) Handles btn_agregarNE.Click
        Dim renglon As Integer
        renglon = DGVMaterialesNE.CurrentCellAddress.Y
        txt_cantidadNE.Text = txt_cantidadNE.Text.Replace(" "c, String.Empty)
        If txt_cantidadNE.Text <> String.Empty Then
            If CInt(txt_cantidadNE.Text) <> 0 Then
                For i = 0 To DGVCarritoNE.Rows.Count - 1
                    If DGVCarritoNE.Rows(i).Cells(0).Value = DGVMaterialesNE.Rows(renglon).Cells(0).Value Then
                        DGVCarritoNE.Rows(i).Cells(1).Value = CInt(txt_cantidadNE.Text) + CInt(DGVCarritoNE.Rows(i).Cells(1).Value)
                        DGVMaterialesNE.Rows(renglon).Cells(1).Value = DGVMaterialesNE.Rows(renglon).Cells(1).Value + txt_cantidadNE.Text
                        Exit For
                    ElseIf i = DGVCarritoNE.Rows.Count - 1 Then
                        DGVCarritoNE.Rows.Add(DGVMaterialesNE.Rows(renglon).Cells(0).Value, txt_cantidadNE.Text)
                        DGVMaterialesNE.Rows(renglon).Cells(1).Value = DGVMaterialesNE.Rows(renglon).Cells(1).Value + txt_cantidadNE.Text
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txt_materialNE_TextChanged(sender As Object, e As EventArgs) Handles txt_materialNE.TextChanged
        Dim entrada As New ClaseEntradas
        entrada.pdgvNE = 2
        entrada.nombreMat = txt_materialNE.Text
        entrada.nombreMat = entrada.nombreMat.Replace(" "c, String.Empty)
        entrada.PoblarDataGridMateriales(DGVMaterialesNE)
        conexion.Close()
    End Sub

    Private Sub btn_modificarNE_Click(sender As Object, e As EventArgs) Handles btn_modificarNE.Click
        Dim renglon As Integer
        renglon = DGVCarritoNE.CurrentCellAddress.Y
        If txt_cantidadNE.Text <> String.Empty Then
            If CInt(txt_cantidadNE.Text) <> 0 Then
                txt_cantidadNE.Text = txt_cantidadNE.Text.Replace(" "c, String.Empty)
                If txt_cantidadNE.Text > DGVCarritoNE.Rows(renglon).Cells(1).Value Then
                    For i = 0 To DGVMaterialesNE.Rows.Count - 1
                        If DGVCarritoNE.Rows(renglon).Cells(0).Value = DGVMaterialesNE.Rows(i).Cells(0).Value Then
                            DGVMaterialesNE.Rows(i).Cells(1).Value = DGVMaterialesNE.Rows(i).Cells(1).Value + (txt_cantidadNE.Text - DGVCarritoNE.Rows(renglon).Cells(1).Value)
                        End If
                    Next
                Else
                    For i = 0 To DGVMaterialesNE.Rows.Count - 1
                        If DGVCarritoNE.Rows(renglon).Cells(0).Value = DGVMaterialesNE.Rows(i).Cells(0).Value Then
                            DGVMaterialesNE.Rows(i).Cells(1).Value = DGVMaterialesNE.Rows(i).Cells(1).Value - (DGVCarritoNE.Rows(renglon).Cells(1).Value - txt_cantidadNE.Text)
                        End If
                    Next
                End If
                DGVCarritoNE.Rows(renglon).Cells(1).Value = txt_cantidadNE.Text
            End If
         End If
    End Sub

    Private Sub btn_eliminarNE_Click(sender As Object, e As EventArgs) Handles btn_eliminarNE.Click
        Dim renglon As Integer
        renglon = DGVCarritoNE.CurrentCellAddress.Y
        For i = 0 To DGVMaterialesNE.Rows.Count - 1
            If DGVCarritoNE.Rows(renglon).Cells(0).Value = DGVMaterialesNE.Rows(i).Cells(0).Value Then
                DGVMaterialesNE.Rows(i).Cells(1).Value = DGVMaterialesNE.Rows(i).Cells(1).Value - DGVCarritoNE.Rows(renglon).Cells(1).Value
            End If
        Next
        DGVCarritoNE.Rows.Remove(DGVCarritoNE.Rows(renglon))
    End Sub

    Private Sub btn_aceptarNE_Click(sender As Object, e As EventArgs) Handles btn_aceptarNE.Click
        Dim entrada As New ClaseEntradas
        Dim xconexion As New ConexionBD
        Dim idmat As Integer
        If DGVCarritoNE.Rows.Count > 1 Then
            entrada.insertarEntrada()

            For i = 0 To DGVCarritoNE.Rows.Count - 2
                idmat = xconexion.objetoScalar("Select idMaterial from materiales " &
            "where nombreMaterial = '" & DGVCarritoNE.Rows(i).Cells(0).Value & "'")
                entrada.insertarDetallesEntrada(idmat, DGVCarritoNE.Rows(i).Cells(1).Value)
            Next
            MsgBox("Entrada guardada correctamente, el #entrada es " & entrada.secuencia, Title:="Laboratorio ITS")
            conexion.Close()
            Me.Close()
        Else
            MsgBox("No hay nada agregado al carrito!!", Title:="Laboratorio ITS")
        End If
    End Sub

    Private Sub btn_cancelarNE_Click(sender As Object, e As EventArgs) Handles btn_cancelarNE.Click
        Me.Close()
    End Sub

    Private Sub btn_refreshNE_Click(sender As Object, e As EventArgs) Handles btn_refreshNE.Click
        Dim entrada As New ClaseEntradas

        entrada.PoblarDataGridMateriales(DGVMaterialesNE)
        conexion.Close()
    End Sub

    Private Sub txt_cantidadNE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadNE.KeyPress
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
End Class