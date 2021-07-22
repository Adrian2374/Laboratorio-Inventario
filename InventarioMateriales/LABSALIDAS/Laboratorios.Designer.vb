<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laboratorios
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
        Me.DGVLab = New System.Windows.Forms.DataGridView()
        Me.btn_ModificarLab = New System.Windows.Forms.Button()
        Me.btn_AgregarLab = New System.Windows.Forms.Button()
        Me.btn_BorrarLab = New System.Windows.Forms.Button()
        CType(Me.DGVLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVLab
        '
        Me.DGVLab.AllowUserToAddRows = False
        Me.DGVLab.AllowUserToDeleteRows = False
        Me.DGVLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLab.Location = New System.Drawing.Point(12, 72)
        Me.DGVLab.Name = "DGVLab"
        Me.DGVLab.ReadOnly = True
        Me.DGVLab.Size = New System.Drawing.Size(245, 163)
        Me.DGVLab.TabIndex = 6
        '
        'btn_ModificarLab
        '
        Me.btn_ModificarLab.Location = New System.Drawing.Point(202, 26)
        Me.btn_ModificarLab.Name = "btn_ModificarLab"
        Me.btn_ModificarLab.Size = New System.Drawing.Size(75, 23)
        Me.btn_ModificarLab.TabIndex = 8
        Me.btn_ModificarLab.Text = "Modificar"
        Me.btn_ModificarLab.UseVisualStyleBackColor = True
        '
        'btn_AgregarLab
        '
        Me.btn_AgregarLab.Location = New System.Drawing.Point(12, 26)
        Me.btn_AgregarLab.Name = "btn_AgregarLab"
        Me.btn_AgregarLab.Size = New System.Drawing.Size(75, 23)
        Me.btn_AgregarLab.TabIndex = 9
        Me.btn_AgregarLab.Text = "Agregar"
        Me.btn_AgregarLab.UseVisualStyleBackColor = True
        '
        'btn_BorrarLab
        '
        Me.btn_BorrarLab.Location = New System.Drawing.Point(109, 26)
        Me.btn_BorrarLab.Name = "btn_BorrarLab"
        Me.btn_BorrarLab.Size = New System.Drawing.Size(75, 23)
        Me.btn_BorrarLab.TabIndex = 10
        Me.btn_BorrarLab.Text = "Borrar"
        Me.btn_BorrarLab.UseVisualStyleBackColor = True
        '
        'Laboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 247)
        Me.Controls.Add(Me.btn_BorrarLab)
        Me.Controls.Add(Me.btn_AgregarLab)
        Me.Controls.Add(Me.btn_ModificarLab)
        Me.Controls.Add(Me.DGVLab)
        Me.Name = "Laboratorios"
        Me.Text = "Laboratorios"
        CType(Me.DGVLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVLab As DataGridView
    Friend WithEvents btn_ModificarLab As Button
    Friend WithEvents btn_AgregarLab As Button
    Friend WithEvents btn_BorrarLab As Button
End Class
