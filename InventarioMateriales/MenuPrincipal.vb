Public Class MenuPrincipal
    Private Sub imagenUsuarios_Click(sender As Object, e As EventArgs) Handles imagenUsuarios.Click
        Usuarios.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imagenEntrada.Click
        ReportesEntradas.Show()
    End Sub

    Private Sub btn_salirMP_Click(sender As Object, e As EventArgs) Handles btn_salirMP.Click
        End
    End Sub

    Private Sub btn_cerrarSesionMP_Click(sender As Object, e As EventArgs) Handles btn_cerrarSesionMP.Click
        Me.Close()
        LoginUsuario.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xcnx As New ConexionBD
        usuarioConectadoMP.Text = "Usuario conectado: " &
                                    xcnx.objetoScalar("Select nombre ||' ' || paterno ||' '|| materno " &
                                                       "from usuarios where idusuario = " & usuarioConnect)
    End Sub

    Private Sub imagenSalida_Click(sender As Object, e As EventArgs) Handles imagenSalida.Click
        Salidas.Show()
    End Sub

    Private Sub imagenLab_Click(sender As Object, e As EventArgs) Handles imagenLab.Click
        Laboratorios.Show()
    End Sub

    Private Sub imagenMateriales_Click(sender As Object, e As EventArgs) Handles imagenMateriales.Click
        RegistroMateriales.Show()
    End Sub
End Class
