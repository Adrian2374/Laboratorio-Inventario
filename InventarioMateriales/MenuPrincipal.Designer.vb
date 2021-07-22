<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.imagenUsuarios = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imagenMateriales = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imagenEntrada = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.imagenSalida = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imagenLab = New System.Windows.Forms.PictureBox()
        Me.btn_cerrarSesionMP = New System.Windows.Forms.Button()
        Me.btn_salirMP = New System.Windows.Forms.Button()
        Me.usuarioConectadoMP = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.imagenReportes = New System.Windows.Forms.PictureBox()
        CType(Me.imagenUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenUsuarios
        '
        Me.imagenUsuarios.BackColor = System.Drawing.SystemColors.Control
        Me.imagenUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenUsuarios.Image = CType(resources.GetObject("imagenUsuarios.Image"), System.Drawing.Image)
        Me.imagenUsuarios.Location = New System.Drawing.Point(32, 144)
        Me.imagenUsuarios.Name = "imagenUsuarios"
        Me.imagenUsuarios.Size = New System.Drawing.Size(60, 59)
        Me.imagenUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenUsuarios.TabIndex = 0
        Me.imagenUsuarios.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Materiales"
        '
        'imagenMateriales
        '
        Me.imagenMateriales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenMateriales.Image = CType(resources.GetObject("imagenMateriales.Image"), System.Drawing.Image)
        Me.imagenMateriales.Location = New System.Drawing.Point(32, 220)
        Me.imagenMateriales.Name = "imagenMateriales"
        Me.imagenMateriales.Size = New System.Drawing.Size(60, 59)
        Me.imagenMateriales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenMateriales.TabIndex = 2
        Me.imagenMateriales.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 54)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entrada de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Material"
        '
        'imagenEntrada
        '
        Me.imagenEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenEntrada.Image = CType(resources.GetObject("imagenEntrada.Image"), System.Drawing.Image)
        Me.imagenEntrada.Location = New System.Drawing.Point(32, 294)
        Me.imagenEntrada.Name = "imagenEntrada"
        Me.imagenEntrada.Size = New System.Drawing.Size(60, 59)
        Me.imagenEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenEntrada.TabIndex = 4
        Me.imagenEntrada.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 54)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Salida de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Material"
        '
        'imagenSalida
        '
        Me.imagenSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenSalida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenSalida.Image = CType(resources.GetObject("imagenSalida.Image"), System.Drawing.Image)
        Me.imagenSalida.Location = New System.Drawing.Point(278, 294)
        Me.imagenSalida.Name = "imagenSalida"
        Me.imagenSalida.Size = New System.Drawing.Size(60, 59)
        Me.imagenSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenSalida.TabIndex = 10
        Me.imagenSalida.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Laboratorios"
        '
        'imagenLab
        '
        Me.imagenLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenLab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenLab.Image = CType(resources.GetObject("imagenLab.Image"), System.Drawing.Image)
        Me.imagenLab.Location = New System.Drawing.Point(278, 144)
        Me.imagenLab.Name = "imagenLab"
        Me.imagenLab.Size = New System.Drawing.Size(60, 59)
        Me.imagenLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenLab.TabIndex = 6
        Me.imagenLab.TabStop = False
        '
        'btn_cerrarSesionMP
        '
        Me.btn_cerrarSesionMP.Location = New System.Drawing.Point(19, 472)
        Me.btn_cerrarSesionMP.Name = "btn_cerrarSesionMP"
        Me.btn_cerrarSesionMP.Size = New System.Drawing.Size(103, 23)
        Me.btn_cerrarSesionMP.TabIndex = 12
        Me.btn_cerrarSesionMP.Text = "Cerrar sesión"
        Me.btn_cerrarSesionMP.UseVisualStyleBackColor = True
        '
        'btn_salirMP
        '
        Me.btn_salirMP.Location = New System.Drawing.Point(128, 472)
        Me.btn_salirMP.Name = "btn_salirMP"
        Me.btn_salirMP.Size = New System.Drawing.Size(75, 23)
        Me.btn_salirMP.TabIndex = 13
        Me.btn_salirMP.Text = "Salir"
        Me.btn_salirMP.UseVisualStyleBackColor = True
        '
        'usuarioConectadoMP
        '
        Me.usuarioConectadoMP.AutoSize = True
        Me.usuarioConectadoMP.Location = New System.Drawing.Point(9, 89)
        Me.usuarioConectadoMP.Name = "usuarioConectadoMP"
        Me.usuarioConectadoMP.Size = New System.Drawing.Size(100, 13)
        Me.usuarioConectadoMP.TabIndex = 14
        Me.usuarioConectadoMP.Text = "Usuario conectado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 27)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Instituto Tecnologico de Saltillo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 27)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Reportes"
        '
        'imagenReportes
        '
        Me.imagenReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagenReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagenReportes.Image = CType(resources.GetObject("imagenReportes.Image"), System.Drawing.Image)
        Me.imagenReportes.Location = New System.Drawing.Point(278, 220)
        Me.imagenReportes.Name = "imagenReportes"
        Me.imagenReportes.Size = New System.Drawing.Size(60, 59)
        Me.imagenReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenReportes.TabIndex = 17
        Me.imagenReportes.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(553, 507)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.imagenReportes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.usuarioConectadoMP)
        Me.Controls.Add(Me.btn_salirMP)
        Me.Controls.Add(Me.btn_cerrarSesionMP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.imagenSalida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.imagenLab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.imagenEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.imagenMateriales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imagenUsuarios)
        Me.DoubleBuffered = True
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        CType(Me.imagenUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagenUsuarios As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imagenMateriales As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents imagenEntrada As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents imagenSalida As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents imagenLab As PictureBox
    Friend WithEvents btn_cerrarSesionMP As Button
    Friend WithEvents btn_salirMP As Button
    Friend WithEvents usuarioConectadoMP As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents imagenReportes As PictureBox
End Class
