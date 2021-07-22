<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaEntrada
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
        Me.txt_materialNE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refreshNE = New System.Windows.Forms.Button()
        Me.DGVMaterialesNE = New System.Windows.Forms.DataGridView()
        Me.DGVCarritoNE = New System.Windows.Forms.DataGridView()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidadNE = New System.Windows.Forms.TextBox()
        Me.btn_agregarNE = New System.Windows.Forms.Button()
        Me.btn_cancelarNE = New System.Windows.Forms.Button()
        Me.btn_aceptarNE = New System.Windows.Forms.Button()
        Me.btn_modificarNE = New System.Windows.Forms.Button()
        Me.btn_eliminarNE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVMaterialesNE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCarritoNE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_materialNE
        '
        Me.txt_materialNE.Location = New System.Drawing.Point(94, 31)
        Me.txt_materialNE.Name = "txt_materialNE"
        Me.txt_materialNE.Size = New System.Drawing.Size(100, 20)
        Me.txt_materialNE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar material"
        '
        'btn_refreshNE
        '
        Me.btn_refreshNE.Location = New System.Drawing.Point(281, 29)
        Me.btn_refreshNE.Name = "btn_refreshNE"
        Me.btn_refreshNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_refreshNE.TabIndex = 3
        Me.btn_refreshNE.Text = "Refresh"
        Me.btn_refreshNE.UseVisualStyleBackColor = True
        '
        'DGVMaterialesNE
        '
        Me.DGVMaterialesNE.AllowUserToAddRows = False
        Me.DGVMaterialesNE.AllowUserToDeleteRows = False
        Me.DGVMaterialesNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaterialesNE.Location = New System.Drawing.Point(76, 58)
        Me.DGVMaterialesNE.Name = "DGVMaterialesNE"
        Me.DGVMaterialesNE.ReadOnly = True
        Me.DGVMaterialesNE.Size = New System.Drawing.Size(243, 150)
        Me.DGVMaterialesNE.TabIndex = 4
        '
        'DGVCarritoNE
        '
        Me.DGVCarritoNE.AllowUserToDeleteRows = False
        Me.DGVCarritoNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCarritoNE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Material, Me.Cantidad})
        Me.DGVCarritoNE.Location = New System.Drawing.Point(76, 283)
        Me.DGVCarritoNE.Name = "DGVCarritoNE"
        Me.DGVCarritoNE.ReadOnly = True
        Me.DGVCarritoNE.Size = New System.Drawing.Size(243, 150)
        Me.DGVCarritoNE.TabIndex = 5
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad:"
        '
        'txt_cantidadNE
        '
        Me.txt_cantidadNE.Location = New System.Drawing.Point(157, 234)
        Me.txt_cantidadNE.Name = "txt_cantidadNE"
        Me.txt_cantidadNE.Size = New System.Drawing.Size(46, 20)
        Me.txt_cantidadNE.TabIndex = 7
        '
        'btn_agregarNE
        '
        Me.btn_agregarNE.Location = New System.Drawing.Point(218, 232)
        Me.btn_agregarNE.Name = "btn_agregarNE"
        Me.btn_agregarNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarNE.TabIndex = 8
        Me.btn_agregarNE.Text = "Agregar"
        Me.btn_agregarNE.UseVisualStyleBackColor = True
        '
        'btn_cancelarNE
        '
        Me.btn_cancelarNE.Location = New System.Drawing.Point(218, 451)
        Me.btn_cancelarNE.Name = "btn_cancelarNE"
        Me.btn_cancelarNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelarNE.TabIndex = 10
        Me.btn_cancelarNE.Text = "Cancelar"
        Me.btn_cancelarNE.UseVisualStyleBackColor = True
        '
        'btn_aceptarNE
        '
        Me.btn_aceptarNE.Location = New System.Drawing.Point(119, 451)
        Me.btn_aceptarNE.Name = "btn_aceptarNE"
        Me.btn_aceptarNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptarNE.TabIndex = 9
        Me.btn_aceptarNE.Text = "Aceptar"
        Me.btn_aceptarNE.UseVisualStyleBackColor = True
        '
        'btn_modificarNE
        '
        Me.btn_modificarNE.Location = New System.Drawing.Point(325, 283)
        Me.btn_modificarNE.Name = "btn_modificarNE"
        Me.btn_modificarNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificarNE.TabIndex = 11
        Me.btn_modificarNE.Text = "Modificar"
        Me.btn_modificarNE.UseVisualStyleBackColor = True
        '
        'btn_eliminarNE
        '
        Me.btn_eliminarNE.Location = New System.Drawing.Point(325, 329)
        Me.btn_eliminarNE.Name = "btn_eliminarNE"
        Me.btn_eliminarNE.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminarNE.TabIndex = 12
        Me.btn_eliminarNE.Text = "Eliminar"
        Me.btn_eliminarNE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Materiales a guardar"
        '
        'NuevaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 497)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_eliminarNE)
        Me.Controls.Add(Me.btn_modificarNE)
        Me.Controls.Add(Me.btn_cancelarNE)
        Me.Controls.Add(Me.btn_aceptarNE)
        Me.Controls.Add(Me.btn_agregarNE)
        Me.Controls.Add(Me.txt_cantidadNE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVCarritoNE)
        Me.Controls.Add(Me.DGVMaterialesNE)
        Me.Controls.Add(Me.btn_refreshNE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_materialNE)
        Me.Name = "NuevaEntrada"
        Me.Text = "NuevaEntrada"
        CType(Me.DGVMaterialesNE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCarritoNE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_materialNE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_refreshNE As Button
    Friend WithEvents DGVMaterialesNE As DataGridView
    Friend WithEvents DGVCarritoNE As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidadNE As TextBox
    Friend WithEvents btn_agregarNE As Button
    Friend WithEvents btn_cancelarNE As Button
    Friend WithEvents btn_aceptarNE As Button
    Friend WithEvents btn_modificarNE As Button
    Friend WithEvents btn_eliminarNE As Button
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
