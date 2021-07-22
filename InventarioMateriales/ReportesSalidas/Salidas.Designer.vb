<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Salidas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NoOrden = New System.Windows.Forms.Label()
        Me.txt_datoRequerido = New System.Windows.Forms.TextBox()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.DGVSalidas = New System.Windows.Forms.DataGridView()
        Me.txt_Fecha = New System.Windows.Forms.TextBox()
        Me.txt_Solicitante = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Solicitante = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.btn_BuscarSalida = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoptionsSalidas = New System.Windows.Forms.ComboBox()
        Me.txt_fecha2 = New System.Windows.Forms.TextBox()
        Me.fecha2 = New System.Windows.Forms.Label()
        Me.DGVRequerimientos = New System.Windows.Forms.DataGridView()
        Me.formato1 = New System.Windows.Forms.Label()
        Me.formato2 = New System.Windows.Forms.Label()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.materno = New System.Windows.Forms.Label()
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoOrden
        '
        Me.NoOrden.AutoSize = True
        Me.NoOrden.Location = New System.Drawing.Point(8, 90)
        Me.NoOrden.Name = "NoOrden"
        Me.NoOrden.Size = New System.Drawing.Size(64, 13)
        Me.NoOrden.TabIndex = 0
        Me.NoOrden.Text = "N° de salida"
        Me.NoOrden.Visible = False
        '
        'txt_datoRequerido
        '
        Me.txt_datoRequerido.Location = New System.Drawing.Point(78, 87)
        Me.txt_datoRequerido.Name = "txt_datoRequerido"
        Me.txt_datoRequerido.Size = New System.Drawing.Size(53, 20)
        Me.txt_datoRequerido.TabIndex = 1
        Me.txt_datoRequerido.Visible = False
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(357, 17)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva.TabIndex = 2
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'DGVSalidas
        '
        Me.DGVSalidas.AllowUserToAddRows = False
        Me.DGVSalidas.AllowUserToDeleteRows = False
        Me.DGVSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSalidas.Location = New System.Drawing.Point(192, 128)
        Me.DGVSalidas.Name = "DGVSalidas"
        Me.DGVSalidas.ReadOnly = True
        Me.DGVSalidas.Size = New System.Drawing.Size(240, 185)
        Me.DGVSalidas.TabIndex = 3
        Me.DGVSalidas.Visible = False
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(86, 293)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.ReadOnly = True
        Me.txt_Fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_Fecha.TabIndex = 4
        Me.txt_Fecha.Visible = False
        '
        'txt_Solicitante
        '
        Me.txt_Solicitante.Location = New System.Drawing.Point(86, 177)
        Me.txt_Solicitante.Name = "txt_Solicitante"
        Me.txt_Solicitante.ReadOnly = True
        Me.txt_Solicitante.Size = New System.Drawing.Size(100, 20)
        Me.txt_Solicitante.TabIndex = 5
        Me.txt_Solicitante.Visible = False
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(86, 235)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.ReadOnly = True
        Me.txt_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_Usuario.TabIndex = 6
        Me.txt_Usuario.Visible = False
        '
        'Solicitante
        '
        Me.Solicitante.AutoSize = True
        Me.Solicitante.Location = New System.Drawing.Point(16, 180)
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.Size = New System.Drawing.Size(56, 13)
        Me.Solicitante.TabIndex = 7
        Me.Solicitante.Text = "Solicitante"
        Me.Solicitante.Visible = False
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(16, 296)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Fecha.TabIndex = 8
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Visible = False
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Location = New System.Drawing.Point(16, 238)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(44, 13)
        Me.Usuario.TabIndex = 9
        Me.Usuario.Text = "Entregó"
        Me.Usuario.Visible = False
        '
        'btn_BuscarSalida
        '
        Me.btn_BuscarSalida.Location = New System.Drawing.Point(357, 85)
        Me.btn_BuscarSalida.Name = "btn_BuscarSalida"
        Me.btn_BuscarSalida.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarSalida.TabIndex = 10
        Me.btn_BuscarSalida.Text = "Buscar"
        Me.btn_BuscarSalida.UseVisualStyleBackColor = True
        Me.btn_BuscarSalida.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Buscar por: "
        '
        'CBoptionsSalidas
        '
        Me.CBoptionsSalidas.FormattingEnabled = True
        Me.CBoptionsSalidas.Items.AddRange(New Object() {"Numero de salida", "Nombre del solcitante", "Matricula", "Fechas"})
        Me.CBoptionsSalidas.Location = New System.Drawing.Point(86, 19)
        Me.CBoptionsSalidas.Name = "CBoptionsSalidas"
        Me.CBoptionsSalidas.Size = New System.Drawing.Size(141, 21)
        Me.CBoptionsSalidas.TabIndex = 12
        Me.CBoptionsSalidas.Text = "Selecciona una opción"
        '
        'txt_fecha2
        '
        Me.txt_fecha2.Location = New System.Drawing.Point(183, 87)
        Me.txt_fecha2.Name = "txt_fecha2"
        Me.txt_fecha2.Size = New System.Drawing.Size(53, 20)
        Me.txt_fecha2.TabIndex = 14
        Me.txt_fecha2.Visible = False
        '
        'fecha2
        '
        Me.fecha2.AutoSize = True
        Me.fecha2.Location = New System.Drawing.Point(137, 90)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(40, 13)
        Me.fecha2.TabIndex = 13
        Me.fecha2.Text = "y el dia"
        Me.fecha2.Visible = False
        '
        'DGVRequerimientos
        '
        Me.DGVRequerimientos.AllowUserToAddRows = False
        Me.DGVRequerimientos.AllowUserToDeleteRows = False
        Me.DGVRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRequerimientos.Location = New System.Drawing.Point(4, 129)
        Me.DGVRequerimientos.Name = "DGVRequerimientos"
        Me.DGVRequerimientos.ReadOnly = True
        Me.DGVRequerimientos.Size = New System.Drawing.Size(428, 185)
        Me.DGVRequerimientos.TabIndex = 15
        Me.DGVRequerimientos.Visible = False
        '
        'formato1
        '
        Me.formato1.AutoSize = True
        Me.formato1.Location = New System.Drawing.Point(83, 71)
        Me.formato1.Name = "formato1"
        Me.formato1.Size = New System.Drawing.Size(69, 13)
        Me.formato1.TabIndex = 16
        Me.formato1.Text = "dd/mm/aaaa"
        Me.formato1.Visible = False
        '
        'formato2
        '
        Me.formato2.AutoSize = True
        Me.formato2.Location = New System.Drawing.Point(188, 71)
        Me.formato2.Name = "formato2"
        Me.formato2.Size = New System.Drawing.Size(69, 13)
        Me.formato2.TabIndex = 17
        Me.formato2.Text = "dd/mm/aaaa"
        Me.formato2.Visible = False
        '
        'txt_materno
        '
        Me.txt_materno.Location = New System.Drawing.Point(294, 87)
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(53, 20)
        Me.txt_materno.TabIndex = 18
        Me.txt_materno.Visible = False
        '
        'materno
        '
        Me.materno.AutoSize = True
        Me.materno.Location = New System.Drawing.Point(242, 90)
        Me.materno.Name = "materno"
        Me.materno.Size = New System.Drawing.Size(46, 13)
        Me.materno.TabIndex = 19
        Me.materno.Text = "Materno"
        Me.materno.Visible = False
        '
        'Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 326)
        Me.Controls.Add(Me.materno)
        Me.Controls.Add(Me.txt_materno)
        Me.Controls.Add(Me.formato2)
        Me.Controls.Add(Me.formato1)
        Me.Controls.Add(Me.DGVRequerimientos)
        Me.Controls.Add(Me.txt_fecha2)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.CBoptionsSalidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_BuscarSalida)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Solicitante)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.txt_Solicitante)
        Me.Controls.Add(Me.txt_Fecha)
        Me.Controls.Add(Me.DGVSalidas)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.txt_datoRequerido)
        Me.Controls.Add(Me.NoOrden)
        Me.Name = "Salidas"
        Me.Text = "Salidas"
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoOrden As Label
    Friend WithEvents txt_datoRequerido As TextBox
    Friend WithEvents btnNueva As Button
    Friend WithEvents DGVSalidas As DataGridView
    Friend WithEvents txt_Fecha As TextBox
    Friend WithEvents txt_Solicitante As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Solicitante As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents btn_BuscarSalida As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBoptionsSalidas As ComboBox
    Friend WithEvents txt_fecha2 As TextBox
    Friend WithEvents fecha2 As Label
    Friend WithEvents DGVRequerimientos As DataGridView
    Friend WithEvents formato1 As Label
    Friend WithEvents formato2 As Label
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents materno As Label
End Class
