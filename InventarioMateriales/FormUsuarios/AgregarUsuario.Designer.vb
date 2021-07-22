<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AMUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.btn_guardarAU = New System.Windows.Forms.Button()
        Me.btn_cancelarAU = New System.Windows.Forms.Button()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbtn_usuarioA = New System.Windows.Forms.RadioButton()
        Me.rbtn_usuarioN = New System.Windows.Forms.RadioButton()
        Me.txt_alerta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informacion del usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Matricula:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(12, 45)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_paterno
        '
        Me.txt_paterno.Location = New System.Drawing.Point(12, 101)
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(100, 20)
        Me.txt_paterno.TabIndex = 7
        '
        'txt_materno
        '
        Me.txt_materno.Location = New System.Drawing.Point(12, 155)
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(100, 20)
        Me.txt_materno.TabIndex = 8
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(12, 210)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(100, 20)
        Me.txt_matricula.TabIndex = 9
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(12, 266)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 10
        '
        'btn_guardarAU
        '
        Me.btn_guardarAU.Location = New System.Drawing.Point(151, 266)
        Me.btn_guardarAU.Name = "btn_guardarAU"
        Me.btn_guardarAU.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardarAU.TabIndex = 11
        Me.btn_guardarAU.Text = "Guardar"
        Me.btn_guardarAU.UseVisualStyleBackColor = True
        '
        'btn_cancelarAU
        '
        Me.btn_cancelarAU.Location = New System.Drawing.Point(151, 322)
        Me.btn_cancelarAU.Name = "btn_cancelarAU"
        Me.btn_cancelarAU.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelarAU.TabIndex = 12
        Me.btn_cancelarAU.Text = "Cancelar"
        Me.btn_cancelarAU.UseVisualStyleBackColor = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(12, 320)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(100, 20)
        Me.txt_contraseña.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Contraseña:"
        '
        'rbtn_usuarioA
        '
        Me.rbtn_usuarioA.AutoSize = True
        Me.rbtn_usuarioA.Location = New System.Drawing.Point(151, 126)
        Me.rbtn_usuarioA.Name = "rbtn_usuarioA"
        Me.rbtn_usuarioA.Size = New System.Drawing.Size(127, 17)
        Me.rbtn_usuarioA.TabIndex = 15
        Me.rbtn_usuarioA.TabStop = True
        Me.rbtn_usuarioA.Text = "Usuario Administrador"
        Me.rbtn_usuarioA.UseVisualStyleBackColor = True
        '
        'rbtn_usuarioN
        '
        Me.rbtn_usuarioN.AutoSize = True
        Me.rbtn_usuarioN.Location = New System.Drawing.Point(151, 160)
        Me.rbtn_usuarioN.Name = "rbtn_usuarioN"
        Me.rbtn_usuarioN.Size = New System.Drawing.Size(97, 17)
        Me.rbtn_usuarioN.TabIndex = 16
        Me.rbtn_usuarioN.TabStop = True
        Me.rbtn_usuarioN.Text = "Usuario Normal"
        Me.rbtn_usuarioN.UseVisualStyleBackColor = True
        '
        'txt_alerta
        '
        Me.txt_alerta.AutoSize = True
        Me.txt_alerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alerta.ForeColor = System.Drawing.Color.Red
        Me.txt_alerta.Location = New System.Drawing.Point(148, 39)
        Me.txt_alerta.Name = "txt_alerta"
        Me.txt_alerta.Size = New System.Drawing.Size(122, 26)
        Me.txt_alerta.TabIndex = 17
        Me.txt_alerta.Text = "Ya existe un usuario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "con esa matricula!!"
        '
        'AMUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 364)
        Me.Controls.Add(Me.txt_alerta)
        Me.Controls.Add(Me.rbtn_usuarioN)
        Me.Controls.Add(Me.rbtn_usuarioA)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancelarAU)
        Me.Controls.Add(Me.btn_guardarAU)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.txt_materno)
        Me.Controls.Add(Me.txt_paterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AMUsuario"
        Me.Text = "Agregar-Modificar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents btn_guardarAU As Button
    Friend WithEvents btn_cancelarAU As Button
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbtn_usuarioA As RadioButton
    Friend WithEvents rbtn_usuarioN As RadioButton
    Friend WithEvents txt_alerta As Label
End Class
