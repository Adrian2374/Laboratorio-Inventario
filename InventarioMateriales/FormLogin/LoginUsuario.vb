Public Class LoginUsuario

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        UsernameTextBox.Text = UsernameTextBox.Text.Replace(" "c, String.Empty)
        Dim login As New ClaseLogin(UsernameTextBox.Text, PasswordTextBox.Text)
        Dim xcnx As New ConexionBD
        If login.consultaUsuario() Then
            If xcnx.objetoScalar("Select nivel from usuarios where idusuario = " & UsernameTextBox.Text) = 2 Then
                MenuPrincipal.imagenUsuarios.Enabled = False
                MenuPrincipal.imagenUsuarios.Load("C:\Users\cesar\Desktop\Tec\Admin de Base de Datos\Proyecto\imagenes\usuariosN.png")

                MenuPrincipal.imagenLab.Enabled = False
                MenuPrincipal.imagenLab.Load("C:\Users\cesar\Desktop\Tec\Admin de Base de Datos\Proyecto\imagenes\principalN.jpg")

                MenuPrincipal.imagenMateriales.Enabled = False
                'MenuPrincipal.imagenMateriales.Load("C:\Users\cesar\Desktop\Tec\Admin de Base de Datos\Proyecto\imagenes\")

                MenuPrincipal.imagenReportes.Enabled = False
                MenuPrincipal.imagenReportes.Load("C:\Users\cesar\Desktop\Tec\Admin de Base de Datos\Proyecto\imagenes\reportesN.jpg")

            End If
            usuarioConnect = UsernameTextBox.Text
            MenuPrincipal.Show()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            Me.Hide()
        Else
            MsgBox("El usuario o contrase�a son incorrectos", Title:="Laboratorio ITS")
        End If
        conexion.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(Me.UsernameTextBox, "Matricula del usuario")
        Me.ToolTip1.SetToolTip(Me.PasswordTextBox, "Contrase�a del usuario")
        Me.ToolTip1.SetToolTip(Me.AcceptButton, "Iniciar sesi�n")
        Me.ToolTip1.SetToolTip(Me.CancelButton, "Cancelar inicio de sesi�n")
    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
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
