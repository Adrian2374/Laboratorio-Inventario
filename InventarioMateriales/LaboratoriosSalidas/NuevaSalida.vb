Public Class NuevaSalida
    Dim operacion As Integer
    Dim primerMaterial = True
    Public i As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelarNuSal.Click
        Me.Close()

    End Sub



    'La ventana carga de manera predeterminada la lista de materiales de la base de datos
    Private Sub NuevaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSal As New ClaseSalidas()
        'DGVCarrito.AllowUserToAddRows = False
        pdgv = 1
        objSal.PoblarDGVMateriales(DGVMateriales)
    End Sub



    'Agrega al carrito el material seleccionado con la cantidad que fué especificada, verificando que haya suficiente material en el almacen 
    Private Sub btn_AgregarACarrito_Click(sender As Object, e As EventArgs) Handles btn_AgregarACarrito.Click
        Dim renglon As Integer
        renglon = DGVMateriales.CurrentCellAddress.Y
        operacion = 1
        txt_Cantidad.Text = txt_Cantidad.Text.Replace(" "c, String.Empty)
        If txt_Cantidad.Text <> vbNullString Then

            If suficienteMaterial() Then
                If materialRepetido() Then
                    'Sumar cantidades
                    If suficienteMaterial() Then
                        'If DGVMateriales.Rows(renglon).Cells(1).Value >= DGVCarrito.Rows(i - 1).Cells(1).Value + CInt(txt_Cantidad.Text) Then

                        DGVCarrito.Rows(i - 1).Cells(1).Value = DGVCarrito.Rows(i - 1).Cells(1).Value + CInt(txt_Cantidad.Text)
                            DGVMateriales.Rows(renglon).Cells(1).Value = DGVMateriales.Rows(renglon).Cells(1).Value - CInt(txt_Cantidad.Text)
                            MsgBox(RTrim(DGVMateriales.Rows(renglon).Cells(0).Value) & " ingresado al carrito exitosamente")
                        'Else
                        'MsgBox("No hay suficiente material disponible.")
                        'End If
                    End If
                Else
                    'Agregar al carrito
                    DGVCarrito.Rows.Add(DGVMateriales.Rows(renglon).Cells(0).Value, txt_Cantidad.Text)
                    DGVMateriales.Rows(renglon).Cells(1).Value = DGVMateriales.Rows(renglon).Cells(1).Value - CInt(txt_Cantidad.Text)
                    primerMaterial = False
                    MsgBox(RTrim(DGVMateriales.Rows(renglon).Cells(0).Value) & " ingresado al carrito exitosamente")
                End If

            End If
        Else
            MsgBox("No has especificado la cantidad que deseas.")
        End If
    End Sub



    ''Crea la salida en la base de dato insertando los datos generales de la salida y los materiales solicitados con su respectiva cantidad
    Private Sub AceptarNuSal_Click(sender As Object, e As EventArgs) Handles AceptarNuSal.Click
        Dim objSal As New ClaseSalidas()
        i = 0
        'Debo hacer el insert de la salida y luego tomar el valor del ultimo idSalida por medio de un query y guardarlo en una variable para usarla con el insert de DetallesSalidas, ademas, hacer un bloque try catch para capturar el error que pueda darse por ingresar una matricula de solicitante no existente
        'Separar los if de si hay datos en el carrito y el de si hay un dato en la matricula de solicitante para poder mandar un mensaje respectivo a cada error
        Try
            'If DGVCarrito.Rows(0).Cells(0).Value <> String.Empty Then
            If DGVCarrito.RowCount > 0 Then
                txt_Matricula.Text = txt_Matricula.Text.Replace(" "c, String.Empty)
                If txt_Matricula.Text <> vbNullString Then
                    objSal.NumeroSalida = objSal.obtenerIdSalida()
                    objSal.crearSalida()
                    Do
                        objSal.nombreMaterial = RTrim(DGVCarrito.Rows(i).Cells(0).Value)
                        objSal.IdMaterial = objSal.getIdMat()
                        objSal.cantidadDeseada = DGVCarrito.Rows(i).Cells(1).Value
                        objSal.cantidadDisponible = objSal.obtenerCantidad()
                        objSal.nuevaCantidad = objSal.cantidadDisponible - objSal.cantidadDeseada
                        objSal.detallesSalida()
                        objSal.sacarMateriales()
                        i = i + 1
                    Loop While i <= DGVCarrito.RowCount - 1
                    Me.Hide()
                    Salidas.Show()
                    MsgBox("Salida ingresada exitosamente. Su numero de salida es: " & objSal.NumeroSalida)
                Else
                    MsgBox("No has ingresado la matricula del solicitante.")
                End If
            Else
                MsgBox("No has ingresado ningun material al carrito.")
            End If

        Catch ex As Exception
            MsgBox("La matricula que ingresaste no esta registrada.")
        End Try
    End Sub



    'Elimina un material del carrito, devolviendo la cantidad que fué extraida temporalmente del almacen
    Private Sub btn_BorrarMatCarrito_Click(sender As Object, e As EventArgs) Handles btn_BorrarMatCarrito.Click
        Dim renglon2 As DataGridViewRow
        renglon2 = DGVCarrito.CurrentRow

        Dim renglon As Integer
        renglon = DGVCarrito.CurrentCellAddress.Y

        Dim renglon3 As Integer
        renglon3 = DGVMateriales.CurrentCellAddress.Y

        If renglon > -1 Then
            If DGVCarrito.Rows(renglon).Cells(0).Value <> String.Empty Then
                If DGVCarrito.Rows(renglon).Cells(0).Value = DGVMateriales.Rows(renglon3).Cells(0).Value Then
                    If MessageBox.Show("Está seguro que desea eliminar el material '" & RTrim(DGVCarrito.Rows(renglon).Cells(0).Value) & "' del carrito?", "Borrar material", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        DGVMateriales.Rows(renglon3).Cells(1).Value = DGVMateriales.Rows(renglon3).Cells(1).Value + DGVCarrito.Rows(renglon).Cells(1).Value
                        DGVCarrito.Rows.Remove(renglon2)
                    End If
                Else
                    MsgBox("¡Debes seleccionar el mismo material en ambas listas para eliminarlo!")
                End If
            Else
                    MsgBox("No has seleccionado ningun campo para borrar.")
            End If
        Else
            MsgBox("No hay elementos para borrar.")
        End If
    End Sub



    'Modifica la cantidad del material seleccionado
    Private Sub btn_ModificarCarrito_Click(sender As Object, e As EventArgs) Handles btn_ModificarCarrito.Click
        Dim renglon As Integer
        renglon = DGVCarrito.CurrentCellAddress.Y

        Dim renglon2 As Integer
        renglon2 = DGVMateriales.CurrentCellAddress.Y

        operacion = 2

        If renglon > -1 Then
            If DGVCarrito.Rows(renglon).Cells(0).Value <> String.Empty Then
                If DGVCarrito.Rows(renglon).Cells(0).Value = DGVMateriales.Rows(renglon2).Cells(0).Value Then
                    txt_Cantidad.Text = txt_Cantidad.Text.Replace(" "c, String.Empty)
                    If txt_Cantidad.Text <> vbNullString Then
                        If txt_Cantidad.Text <> 0 Then
                            If DGVCarrito.Rows(renglon).Cells(1).Value <> txt_Cantidad.Text Then
                                If suficienteMaterial() Then
                                    'DGVCarrito.Rows(renglon).Cells(1).Value = txt_Cantidad.Text
                                    'MsgBox("Cantidad modificada.")
                                    'Dim cant = txt_Cantidad.Text
                                    If DGVCarrito.Rows(renglon).Cells(1).Value > txt_Cantidad.Text Then
                                        DGVMateriales.Rows(renglon2).Cells(1).Value = DGVMateriales.Rows(renglon2).Cells(1).Value + DGVCarrito.Rows(renglon).Cells(1).Value - CInt(txt_Cantidad.Text)
                                        DGVCarrito.Rows(renglon).Cells(1).Value = txt_Cantidad.Text
                                        MsgBox("Cantidad modificada.")
                                    Else
                                        'DGVCarrito.Rows(renglon).Cells(1).Value = txt_Cantidad.Text
                                        DGVMateriales.Rows(renglon2).Cells(1).Value = DGVMateriales.Rows(renglon2).Cells(1).Value - CInt(txt_Cantidad.Text) + DGVCarrito.Rows(renglon).Cells(1).Value
                                        DGVCarrito.Rows(renglon).Cells(1).Value = txt_Cantidad.Text
                                        MsgBox("Cantidad modificada.")
                                    End If
                                End If
                            Else
                                MsgBox("La cantidad a modificar es la misma que la establecida.")
                            End If
                        Else
                            btn_BorrarMatCarrito.PerformClick()
                        End If
                    Else
                            MsgBox("No especificaste la cantidad deseada.")
                    End If
                Else
                    MsgBox("¡Debes seleccionar el mismo material en ambas listas para eliminarlo!")
                End If
            Else
                    MsgBox("No seleccionaste ningun campo para modificar.")
            End If
        Else
            MsgBox("No hay elementos para modificar.")
        End If
    End Sub



    'Sirve para tomar el/los valor(es) del renglon seleccionado
    Private Sub DGVMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMateriales.CellClick
        Dim renglon As Integer
        renglon = DGVMateriales.CurrentCellAddress.Y
    End Sub



    'Sirve para tomar el/los valor(es) del renglon seleccionado
    Private Sub DGVCarrito_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCarrito.CellClick
        Dim renglon As Integer
        renglon = DGVCarrito.CurrentCellAddress.Y
    End Sub



    'Verifica que haya suficiente material en el almacen
    Public Function suficienteMaterial()
        Dim renglon2 As Integer
        renglon2 = DGVMateriales.CurrentCellAddress.Y
        Dim valido = False

        If operacion = 1 Then
            If txt_Cantidad.Text <= DGVMateriales.Rows(renglon2).Cells(1).Value Then
                valido = True
            Else
                MsgBox("No hay suficiente material disponible.")
            End If
        Else
            Dim renglon As Integer
            renglon = DGVCarrito.CurrentCellAddress.Y

            If DGVCarrito.Rows(renglon).Cells(0).Value = DGVMateriales.Rows(renglon2).Cells(0).Value Then
                If txt_Cantidad.Text <= DGVMateriales.Rows(renglon2).Cells(1).Value Then
                    valido = True
                Else
                    MsgBox("No hay suficiente material disponible.")
                End If
            Else
                MsgBox("¡Debes seleccionar el mismo material en ambas listas para modificar la cantidad en el carrito!")
            End If
        End If

        suficienteMaterial = valido
    End Function



    'Checa si ya se habia agregado el mismo material previamente o no, para saber si agregarlo o sólo modificar la cantidad anteriormente establecida
    Public Function materialRepetido()
        Dim presencia As Boolean
        i = 0
        Dim renglon As Integer
        renglon = DGVMateriales.CurrentCellAddress.Y

        presencia = False

        If DGVCarrito.RowCount > 0 Then
            primerMaterial = False
        Else
            primerMaterial = True
        End If

        If primerMaterial <> True Then
            Do
                If DGVMateriales.Rows(renglon).Cells(0).Value = DGVCarrito.Rows(i).Cells(0).Value Then
                    presencia = True
                End If
                i = i + 1
            Loop While presencia = False And i <= DGVCarrito.RowCount - 1
        End If

        materialRepetido = presencia
    End Function



    'Obliga a que el usuairo solo pueda escribir numeros
    Private Sub txt_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cantidad.KeyPress
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



    'Realiza la busqueda del material que desea sin necesidad de oprimir el boton de buscar
    Private Sub txt_BuscarMat_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarMat.TextChanged
        Dim objSal As New ClaseSalidas()
        pdgv = 2
        objSal.nombreMaterial = txt_BuscarMat.Text
        objSal.nombreMaterial = objSal.nombreMaterial.Replace(" "c, String.Empty)
        objSal.PoblarDGVMateriales(DGVMateriales)
    End Sub



    Private Sub txt_Matricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Matricula.KeyPress
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