Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.btn_agregarU, "Agregar un usuario")
        Me.ToolTip1.SetToolTip(Me.btn_eliminarU, "Eliminar un usuario")
        Me.ToolTip1.SetToolTip(Me.btn_modificarU, "Modificar datos de usuario")

        Dim usuarios As New ClaseUsuarios

        usuarios.PoblarDataGridUsuarios(DGVUsuarios)
        dgv = DGVUsuarios
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminarU.Click
        Dim usuario As New ClaseUsuarios
        If matricula <> vbNull Then
            usuario.getSetLamatricula = matricula
            If usuario.esAdmin Then
                If usuario.contarAdmins Then
                    If MessageBox.Show("¿Esta seguro de eliminarlo?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        usuario.eliminarUsuario()
                        usuario.PoblarDataGridUsuarios(DGVUsuarios)
                        conexion.Close()
                    End If
                Else
                    MsgBox("NO PUEDE ELIMINAR ESTE USUARIO ADMINISTRADOR!!" & vbCrLf &
                            "Tiene que haber al menos dos administradores", Title:="Laboratorio ITS")
                End If
            Else
                If MessageBox.Show("¿Esta seguro de eliminarlo?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    usuario.eliminarUsuario()
                    usuario.PoblarDataGridUsuarios(DGVUsuarios)
                    conexion.Close()
                End If
            End If
        Else
            MsgBox("NO HA SELECCIONADO UN USUARIO A ELIMINAR!!", Title:="Laboratorio ITS")
        End If

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregarU.Click
        'valor para que el boton guardar del form AMUsuario sepa que es un insert
        AMUsuario.moa = 1
        AMUsuario.Show()
    End Sub

    Private Sub btn_modificarU_Click(sender As Object, e As EventArgs) Handles btn_modificarU.Click
        Dim usuario As New ClaseUsuarios
        Dim renglon As Integer
        'al seleccionar un renglon, guardamos los datos del usuario a modificar
        renglon = DGVUsuarios.CurrentCellAddress.Y
        If matricula <> vbNull Then
            AMUsuario.txt_matricula.Text = DGVUsuarios.Rows(renglon).Cells(0).Value
            AMUsuario.txt_nombre.Text = DGVUsuarios.Rows(renglon).Cells(1).Value
            AMUsuario.txt_paterno.Text = DGVUsuarios.Rows(renglon).Cells(2).Value
            AMUsuario.txt_materno.Text = DGVUsuarios.Rows(renglon).Cells(3).Value
            AMUsuario.txt_telefono.Text = DGVUsuarios.Rows(renglon).Cells(6).Value
            AMUsuario.txt_contraseña.Text = DGVUsuarios.Rows(renglon).Cells(4).Value
            If DGVUsuarios.Rows(renglon).Cells(5).Value.Equals("Administrador") Then
                AMUsuario.rbtn_usuarioA.Checked = True
            Else
                AMUsuario.rbtn_usuarioN.Checked = True
            End If
            AMUsuario.txt_telefono.Text = DGVUsuarios.Rows(renglon).Cells(6).Value
            AMUsuario.txt_matricula.Enabled = False

            'valor para que el boton guardar del form AMUsuario sepa que es un update
            AMUsuario.moa = 2
            AMUsuario.Show()
        Else
            MsgBox("NO HA SELECCIONADO UN USUARIO A MODIFICAR!!", Title:="Laboratorio ITS")
        End If
    End Sub

    Private Sub DGVUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellClick
        Dim renglon As Integer
        'al seleccionar un renglon, guardamos la matricula del usuario en caso de eliminar o modificar
        renglon = DGVUsuarios.CurrentCellAddress.Y
        Try
            matricula = DGVUsuarios.Rows(renglon).Cells(0).Value
        Catch ex As Exception
            matricula = vbNull
        End Try
    End Sub

    Private Sub txt_buscarU_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarU.TextChanged
        Dim usuarios As New ClaseUsuarios
        usuarios.pdgvU = 2
        usuarios.buscar = txt_buscarU.Text
        usuarios.buscar = usuarios.buscar.Replace(" "c, String.Empty)
        usuarios.PoblarDataGridUsuarios(DGVUsuarios)
        conexion.Close()
    End Sub
End Class