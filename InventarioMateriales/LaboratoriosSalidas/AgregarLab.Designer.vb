<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLab
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
        Me.LabelAgLab = New System.Windows.Forms.Label()
        Me.txt_nombreLab = New System.Windows.Forms.TextBox()
        Me.btn_AceptarAgLab = New System.Windows.Forms.Button()
        Me.btn_CancelarAgLab = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelAgLab
        '
        Me.LabelAgLab.AutoSize = True
        Me.LabelAgLab.Location = New System.Drawing.Point(28, 9)
        Me.LabelAgLab.Name = "LabelAgLab"
        Me.LabelAgLab.Size = New System.Drawing.Size(163, 26)
        Me.LabelAgLab.TabIndex = 0
        Me.LabelAgLab.Text = "Ingrese el nombre del laboratorio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que desea agregar."
        '
        'txt_nombreLab
        '
        Me.txt_nombreLab.Location = New System.Drawing.Point(62, 51)
        Me.txt_nombreLab.Name = "txt_nombreLab"
        Me.txt_nombreLab.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombreLab.TabIndex = 1
        '
        'btn_AceptarAgLab
        '
        Me.btn_AceptarAgLab.Location = New System.Drawing.Point(31, 82)
        Me.btn_AceptarAgLab.Name = "btn_AceptarAgLab"
        Me.btn_AceptarAgLab.Size = New System.Drawing.Size(75, 23)
        Me.btn_AceptarAgLab.TabIndex = 5
        Me.btn_AceptarAgLab.Text = "Aceptar"
        Me.btn_AceptarAgLab.UseVisualStyleBackColor = True
        '
        'btn_CancelarAgLab
        '
        Me.btn_CancelarAgLab.Location = New System.Drawing.Point(116, 82)
        Me.btn_CancelarAgLab.Name = "btn_CancelarAgLab"
        Me.btn_CancelarAgLab.Size = New System.Drawing.Size(75, 23)
        Me.btn_CancelarAgLab.TabIndex = 6
        Me.btn_CancelarAgLab.Text = "Cancelar"
        Me.btn_CancelarAgLab.UseVisualStyleBackColor = True
        '
        'AgregarLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 123)
        Me.Controls.Add(Me.btn_CancelarAgLab)
        Me.Controls.Add(Me.btn_AceptarAgLab)
        Me.Controls.Add(Me.txt_nombreLab)
        Me.Controls.Add(Me.LabelAgLab)
        Me.Name = "AgregarLab"
        Me.Text = "AgregarLab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAgLab As Label
    Friend WithEvents txt_nombreLab As TextBox
    Friend WithEvents btn_AceptarAgLab As Button
    Friend WithEvents btn_CancelarAgLab As Button
End Class
