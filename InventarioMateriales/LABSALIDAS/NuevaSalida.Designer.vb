<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaSalida
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_BuscarMat = New System.Windows.Forms.TextBox()
        Me.LabelNuSalMat = New System.Windows.Forms.Label()
        Me.LabelNuSalCant = New System.Windows.Forms.Label()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.btn_AgregarACarrito = New System.Windows.Forms.Button()
        Me.AceptarNuSal = New System.Windows.Forms.Button()
        Me.CancelarNuSal = New System.Windows.Forms.Button()
        Me.DGVMateriales = New System.Windows.Forms.DataGridView()
        Me.LabelNuSalNom = New System.Windows.Forms.Label()
        Me.txt_Matricula = New System.Windows.Forms.TextBox()
        Me.DGVCarrito = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarNS = New System.Windows.Forms.Label()
        Me.btn_ModificarCarrito = New System.Windows.Forms.Button()
        Me.btn_BorrarMatCarrito = New System.Windows.Forms.Button()
        CType(Me.DGVMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_BuscarMat
        '
        Me.txt_BuscarMat.Location = New System.Drawing.Point(190, 33)
        Me.txt_BuscarMat.Name = "txt_BuscarMat"
        Me.txt_BuscarMat.Size = New System.Drawing.Size(100, 20)
        Me.txt_BuscarMat.TabIndex = 1
        '
        'LabelNuSalMat
        '
        Me.LabelNuSalMat.AutoSize = True
        Me.LabelNuSalMat.Location = New System.Drawing.Point(81, 9)
        Me.LabelNuSalMat.Name = "LabelNuSalMat"
        Me.LabelNuSalMat.Size = New System.Drawing.Size(166, 13)
        Me.LabelNuSalMat.TabIndex = 4
        Me.LabelNuSalMat.Text = "Seleccione el material que desea."
        '
        'LabelNuSalCant
        '
        Me.LabelNuSalCant.AutoSize = True
        Me.LabelNuSalCant.Location = New System.Drawing.Point(44, 201)
        Me.LabelNuSalCant.Name = "LabelNuSalCant"
        Me.LabelNuSalCant.Size = New System.Drawing.Size(96, 13)
        Me.LabelNuSalCant.TabIndex = 5
        Me.LabelNuSalCant.Text = "Cantidad deseada."
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(164, 199)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(33, 20)
        Me.txt_Cantidad.TabIndex = 6
        '
        'btn_AgregarACarrito
        '
        Me.btn_AgregarACarrito.Location = New System.Drawing.Point(215, 197)
        Me.btn_AgregarACarrito.Name = "btn_AgregarACarrito"
        Me.btn_AgregarACarrito.Size = New System.Drawing.Size(75, 23)
        Me.btn_AgregarACarrito.TabIndex = 7
        Me.btn_AgregarACarrito.Text = "Agregar"
        Me.btn_AgregarACarrito.UseVisualStyleBackColor = True
        '
        'AceptarNuSal
        '
        Me.AceptarNuSal.Location = New System.Drawing.Point(92, 437)
        Me.AceptarNuSal.Name = "AceptarNuSal"
        Me.AceptarNuSal.Size = New System.Drawing.Size(75, 23)
        Me.AceptarNuSal.TabIndex = 8
        Me.AceptarNuSal.Text = "Aceptar"
        Me.AceptarNuSal.UseVisualStyleBackColor = True
        '
        'CancelarNuSal
        '
        Me.CancelarNuSal.Location = New System.Drawing.Point(219, 437)
        Me.CancelarNuSal.Name = "CancelarNuSal"
        Me.CancelarNuSal.Size = New System.Drawing.Size(75, 23)
        Me.CancelarNuSal.TabIndex = 9
        Me.CancelarNuSal.Text = "Cancelar"
        Me.CancelarNuSal.UseVisualStyleBackColor = True
        '
        'DGVMateriales
        '
        Me.DGVMateriales.AllowUserToAddRows = False
        Me.DGVMateriales.AllowUserToDeleteRows = False
        Me.DGVMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMateriales.Location = New System.Drawing.Point(47, 60)
        Me.DGVMateriales.Name = "DGVMateriales"
        Me.DGVMateriales.ReadOnly = True
        Me.DGVMateriales.Size = New System.Drawing.Size(243, 114)
        Me.DGVMateriales.TabIndex = 10
        '
        'LabelNuSalNom
        '
        Me.LabelNuSalNom.AutoSize = True
        Me.LabelNuSalNom.Location = New System.Drawing.Point(120, 372)
        Me.LabelNuSalNom.Name = "LabelNuSalNom"
        Me.LabelNuSalNom.Size = New System.Drawing.Size(170, 13)
        Me.LabelNuSalNom.TabIndex = 12
        Me.LabelNuSalNom.Text = "Ingrese la matrícula del solicitante."
        '
        'txt_Matricula
        '
        Me.txt_Matricula.Location = New System.Drawing.Point(142, 398)
        Me.txt_Matricula.MaxLength = 8
        Me.txt_Matricula.Name = "txt_Matricula"
        Me.txt_Matricula.Size = New System.Drawing.Size(100, 20)
        Me.txt_Matricula.TabIndex = 11
        '
        'DGVCarrito
        '
        Me.DGVCarrito.AllowUserToAddRows = False
        Me.DGVCarrito.AllowUserToDeleteRows = False
        Me.DGVCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGVCarrito.Location = New System.Drawing.Point(47, 239)
        Me.DGVCarrito.Name = "DGVCarrito"
        Me.DGVCarrito.ReadOnly = True
        Me.DGVCarrito.Size = New System.Drawing.Size(243, 114)
        Me.DGVCarrito.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'BuscarNS
        '
        Me.BuscarNS.AutoSize = True
        Me.BuscarNS.Location = New System.Drawing.Point(37, 36)
        Me.BuscarNS.Name = "BuscarNS"
        Me.BuscarNS.Size = New System.Drawing.Size(147, 13)
        Me.BuscarNS.TabIndex = 17
        Me.BuscarNS.Text = "Nombre del material a buscar:"
        '
        'btn_ModificarCarrito
        '
        Me.btn_ModificarCarrito.Location = New System.Drawing.Point(302, 262)
        Me.btn_ModificarCarrito.Name = "btn_ModificarCarrito"
        Me.btn_ModificarCarrito.Size = New System.Drawing.Size(75, 23)
        Me.btn_ModificarCarrito.TabIndex = 18
        Me.btn_ModificarCarrito.Text = "Modificar"
        Me.btn_ModificarCarrito.UseVisualStyleBackColor = True
        '
        'btn_BorrarMatCarrito
        '
        Me.btn_BorrarMatCarrito.Location = New System.Drawing.Point(301, 306)
        Me.btn_BorrarMatCarrito.Name = "btn_BorrarMatCarrito"
        Me.btn_BorrarMatCarrito.Size = New System.Drawing.Size(75, 23)
        Me.btn_BorrarMatCarrito.TabIndex = 19
        Me.btn_BorrarMatCarrito.Text = "Borrar"
        Me.btn_BorrarMatCarrito.UseVisualStyleBackColor = True
        '
        'NuevaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 503)
        Me.Controls.Add(Me.btn_BorrarMatCarrito)
        Me.Controls.Add(Me.btn_ModificarCarrito)
        Me.Controls.Add(Me.BuscarNS)
        Me.Controls.Add(Me.DGVCarrito)
        Me.Controls.Add(Me.LabelNuSalNom)
        Me.Controls.Add(Me.txt_Matricula)
        Me.Controls.Add(Me.DGVMateriales)
        Me.Controls.Add(Me.CancelarNuSal)
        Me.Controls.Add(Me.AceptarNuSal)
        Me.Controls.Add(Me.btn_AgregarACarrito)
        Me.Controls.Add(Me.txt_Cantidad)
        Me.Controls.Add(Me.LabelNuSalCant)
        Me.Controls.Add(Me.LabelNuSalMat)
        Me.Controls.Add(Me.txt_BuscarMat)
        Me.Name = "NuevaSalida"
        Me.Text = "NuevaSalida"
        CType(Me.DGVMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_BuscarMat As TextBox
    Friend WithEvents LabelNuSalMat As Label
    Friend WithEvents LabelNuSalCant As Label
    Friend WithEvents txt_Cantidad As TextBox
    Friend WithEvents btn_AgregarACarrito As Button
    Friend WithEvents AceptarNuSal As Button
    Friend WithEvents CancelarNuSal As Button
    Friend WithEvents DGVMateriales As DataGridView
    Friend WithEvents LabelNuSalNom As Label
    Friend WithEvents txt_Matricula As TextBox
    Public WithEvents DGVCarrito As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BuscarNS As Label
    Friend WithEvents btn_ModificarCarrito As Button
    Friend WithEvents btn_BorrarMatCarrito As Button
End Class
