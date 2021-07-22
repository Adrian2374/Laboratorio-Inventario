Imports Usuarios
Public Class AMUsuario
    Public moa As Byte
    Public nivel As Byte
    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_alerta.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelarAU.Click
        Close()
    End Sub

    Private Sub btn_guardarAU_Click(sender As Object, e As EventArgs) Handles btn_guardarAU.Click
        txt_paterno.Text = txt_paterno.Text.Replace(" "c, String.Empty)
        txt_materno.Text = txt_materno.Text.Replace(" "c, String.Empty)
        txt_matricula.Text = txt_matricula.Text.Replace(" "c, String.Empty)
        txt_telefono.Text = txt_telefono.Text.Replace(" "c, String.Empty)
        txt_contraseña.Text = txt_contraseña.Text.Replace(" "c, String.Empty)
        If txt_nombre.Text = String.Empty Then
            MessageBox.Show("Capturar nombre personal del usuario !!")
        ElseIf txt_paterno.Text = String.Empty Then
            MessageBox.Show("Capturar apellido paterno del usuario !!")
        ElseIf txt_materno.Text = String.Empty Then
            MessageBox.Show("Capturar apellido materno del usuario !!")
        ElseIf txt_matricula.Text = vbNullString Then
            MessageBox.Show("Capturar la matricula del usuario !!")
        ElseIf txt_contraseña.Text = String.Empty Then
            MessageBox.Show("Capturar la contraseña del usuario !!")
        ElseIf nivel = 0 Then
            MessageBox.Show("Seleccione el tipo de usuario !!")
        Else
            Dim usuarios As New ClaseUsuarios(txt_matricula.Text, txt_nombre.Text, txt_paterno.Text, txt_materno.Text,
                                                txt_contraseña.Text, nivel, txt_telefono.Text)
            If moa = 1 Then
                'usuarios.getSetLamatricula = txt_matricula.Text
                'usuarios.getSetElnombre = txt_nombre.Text
                'usuarios.getSetElpaterno = txt_paterno.Text
                'usuarios.getSetElmaterno = txt_materno.Text
                'usuarios.getSetLacontraseña = txt_contraseña.Text
                'usuarios.getSetEltelefono = txt_telefono.Text
                If usuarios.buscaUsuario Then
                    txt_alerta.Visible = True
                Else
                    usuarios.insertarUsuario()
                    usuarios.PoblarDataGridUsuarios(dgv)
                    Me.Close()
                End If


            Else
                If usuarios.esAdmin Then
                    If usuarios.contarAdmins Or rbtn_usuarioN.Checked = False Then
                        usuarios.modificarUsuario()
                        usuarios.PoblarDataGridUsuarios(dgv)
                        Me.Close()
                    Else
                        MsgBox("NO PUEDE CAMBIAR DE NIVEL A ESTE USUARIO ADMINISTRADOR!!" & vbCrLf &
                            "Tiene que haber al menos dos administradores", Title:="Laboratorio ITS")
                        Me.Close()
                    End If
                Else
                    usuarios.modificarUsuario()
                    usuarios.PoblarDataGridUsuarios(dgv)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub rbtn_usuarioA_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_usuarioA.CheckedChanged
        nivel = 1
    End Sub

    Private Sub rbtn_usuarioN_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_usuarioN.CheckedChanged
        nivel = 2
    End Sub

    Private Sub txt_matricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_matricula.KeyPress
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

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
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