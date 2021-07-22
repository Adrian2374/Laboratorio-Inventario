<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregarU = New System.Windows.Forms.Button()
        Me.btn_eliminarU = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_buscarU = New System.Windows.Forms.TextBox()
        Me.btn_modificarU = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuarios Registrados"
        '
        'btn_agregarU
        '
        Me.btn_agregarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregarU.Location = New System.Drawing.Point(15, 490)
        Me.btn_agregarU.Name = "btn_agregarU"
        Me.btn_agregarU.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarU.TabIndex = 2
        Me.btn_agregarU.Text = "Agregar"
        Me.btn_agregarU.UseVisualStyleBackColor = True
        '
        'btn_eliminarU
        '
        Me.btn_eliminarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminarU.Location = New System.Drawing.Point(107, 490)
        Me.btn_eliminarU.Name = "btn_eliminarU"
        Me.btn_eliminarU.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminarU.TabIndex = 3
        Me.btn_eliminarU.Text = "Eliminar"
        Me.btn_eliminarU.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Opciones de usuario:"
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuarios.Location = New System.Drawing.Point(12, 142)
        Me.DGVUsuarios.Name = "DGVUsuarios"
        Me.DGVUsuarios.Size = New System.Drawing.Size(597, 320)
        Me.DGVUsuarios.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Buscar Usuario:"
        '
        'txt_buscarU
        '
        Me.txt_buscarU.Location = New System.Drawing.Point(12, 79)
        Me.txt_buscarU.Name = "txt_buscarU"
        Me.txt_buscarU.Size = New System.Drawing.Size(170, 20)
        Me.txt_buscarU.TabIndex = 7
        Me.txt_buscarU.Tag = ""
        '
        'btn_modificarU
        '
        Me.btn_modificarU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modificarU.Location = New System.Drawing.Point(204, 490)
        Me.btn_modificarU.Name = "btn_modificarU"
        Me.btn_modificarU.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificarU.TabIndex = 8
        Me.btn_modificarU.Text = "Modificar"
        Me.btn_modificarU.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(621, 536)
        Me.Controls.Add(Me.btn_modificarU)
        Me.Controls.Add(Me.txt_buscarU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVUsuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_eliminarU)
        Me.Controls.Add(Me.btn_agregarU)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Usuarios"
        Me.Tag = ""
        Me.Text = "Usuarios"
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregarU As Button
    Friend WithEvents btn_eliminarU As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVUsuarios As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_buscarU As TextBox
    Friend WithEvents btn_modificarU As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
