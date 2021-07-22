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
        Me.txt_NumSalida = New System.Windows.Forms.TextBox()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.DGVSalidas = New System.Windows.Forms.DataGridView()
        Me.txt_Fecha = New System.Windows.Forms.TextBox()
        Me.txt_Solicitante = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Solicitante = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.btn_BuscarSalida = New System.Windows.Forms.Button()
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoOrden
        '
        Me.NoOrden.AutoSize = True
        Me.NoOrden.Location = New System.Drawing.Point(16, 25)
        Me.NoOrden.Name = "NoOrden"
        Me.NoOrden.Size = New System.Drawing.Size(64, 13)
        Me.NoOrden.TabIndex = 0
        Me.NoOrden.Text = "N° de orden"
        '
        'txt_NumSalida
        '
        Me.txt_NumSalida.Location = New System.Drawing.Point(86, 23)
        Me.txt_NumSalida.Name = "txt_NumSalida"
        Me.txt_NumSalida.Size = New System.Drawing.Size(100, 20)
        Me.txt_NumSalida.TabIndex = 1
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(357, 21)
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
        Me.DGVSalidas.Location = New System.Drawing.Point(192, 64)
        Me.DGVSalidas.Name = "DGVSalidas"
        Me.DGVSalidas.ReadOnly = True
        Me.DGVSalidas.Size = New System.Drawing.Size(240, 185)
        Me.DGVSalidas.TabIndex = 3
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(86, 229)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.ReadOnly = True
        Me.txt_Fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_Fecha.TabIndex = 4
        '
        'txt_Solicitante
        '
        Me.txt_Solicitante.Location = New System.Drawing.Point(86, 113)
        Me.txt_Solicitante.Name = "txt_Solicitante"
        Me.txt_Solicitante.ReadOnly = True
        Me.txt_Solicitante.Size = New System.Drawing.Size(100, 20)
        Me.txt_Solicitante.TabIndex = 5
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(86, 171)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.ReadOnly = True
        Me.txt_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_Usuario.TabIndex = 6
        '
        'Solicitante
        '
        Me.Solicitante.AutoSize = True
        Me.Solicitante.Location = New System.Drawing.Point(16, 116)
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.Size = New System.Drawing.Size(56, 13)
        Me.Solicitante.TabIndex = 7
        Me.Solicitante.Text = "Solicitante"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(16, 232)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Fecha.TabIndex = 8
        Me.Fecha.Text = "Fecha"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Location = New System.Drawing.Point(16, 174)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(44, 13)
        Me.Usuario.TabIndex = 9
        Me.Usuario.Text = "Entregó"
        '
        'btn_BuscarSalida
        '
        Me.btn_BuscarSalida.Location = New System.Drawing.Point(192, 21)
        Me.btn_BuscarSalida.Name = "btn_BuscarSalida"
        Me.btn_BuscarSalida.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarSalida.TabIndex = 10
        Me.btn_BuscarSalida.Text = "Buscar"
        Me.btn_BuscarSalida.UseVisualStyleBackColor = True
        '
        'Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 266)
        Me.Controls.Add(Me.btn_BuscarSalida)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Solicitante)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.txt_Solicitante)
        Me.Controls.Add(Me.txt_Fecha)
        Me.Controls.Add(Me.DGVSalidas)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.txt_NumSalida)
        Me.Controls.Add(Me.NoOrden)
        Me.Name = "Salidas"
        Me.Text = "Salidas"
        CType(Me.DGVSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoOrden As Label
    Friend WithEvents txt_NumSalida As TextBox
    Friend WithEvents btnNueva As Button
    Friend WithEvents DGVSalidas As DataGridView
    Friend WithEvents txt_Fecha As TextBox
    Friend WithEvents txt_Solicitante As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Solicitante As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents btn_BuscarSalida As Button
End Class
