<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarModificarMaterial
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
        Me.labelIdMaterial = New System.Windows.Forms.Label()
        Me.txtIdMaterial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombMaterial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescMaterial = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelIdMaterial
        '
        Me.labelIdMaterial.AutoSize = True
        Me.labelIdMaterial.Location = New System.Drawing.Point(12, 31)
        Me.labelIdMaterial.Name = "labelIdMaterial"
        Me.labelIdMaterial.Size = New System.Drawing.Size(58, 13)
        Me.labelIdMaterial.TabIndex = 0
        Me.labelIdMaterial.Text = "ID Material"
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.Location = New System.Drawing.Point(134, 31)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.Size = New System.Drawing.Size(198, 20)
        Me.txtIdMaterial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de Material"
        '
        'txtNombMaterial
        '
        Me.txtNombMaterial.Location = New System.Drawing.Point(134, 86)
        Me.txtNombMaterial.Name = "txtNombMaterial"
        Me.txtNombMaterial.Size = New System.Drawing.Size(198, 20)
        Me.txtNombMaterial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion de Material"
        '
        'txtDescMaterial
        '
        Me.txtDescMaterial.Location = New System.Drawing.Point(134, 153)
        Me.txtDescMaterial.Name = "txtDescMaterial"
        Me.txtDescMaterial.Size = New System.Drawing.Size(198, 20)
        Me.txtDescMaterial.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(158, 235)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(257, 235)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarModificarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 268)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescMaterial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombMaterial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdMaterial)
        Me.Controls.Add(Me.labelIdMaterial)
        Me.Name = "AgregarModificarMaterial"
        Me.Text = "Agregar-Modificar Material"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelIdMaterial As Label
    Friend WithEvents txtIdMaterial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombMaterial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescMaterial As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
