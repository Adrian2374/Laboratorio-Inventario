<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesEntradas
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
        Me.DGVEntradaM = New System.Windows.Forms.DataGridView()
        Me.label_fechaE = New System.Windows.Forms.Label()
        Me.txt_fechaE = New System.Windows.Forms.TextBox()
        Me.label_usuarioE = New System.Windows.Forms.Label()
        Me.txt_usuarioE = New System.Windows.Forms.TextBox()
        Me.label_noEn = New System.Windows.Forms.Label()
        Me.txt_noEntradaE = New System.Windows.Forms.TextBox()
        Me.btn_buscarE = New System.Windows.Forms.Button()
        Me.CBReportesE = New System.Windows.Forms.ComboBox()
        Me.label_matriculaU = New System.Windows.Forms.Label()
        Me.txt_reporteU = New System.Windows.Forms.TextBox()
        Me.btn_buscarMatE = New System.Windows.Forms.Button()
        Me.DGVReportesEU = New System.Windows.Forms.DataGridView()
        Me.labelU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DGVFecha = New System.Windows.Forms.DataGridView()
        Me.btn_nuevaEntradaE = New System.Windows.Forms.Button()
        CType(Me.DGVEntradaM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVReportesEU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVEntradaM
        '
        Me.DGVEntradaM.AllowUserToAddRows = False
        Me.DGVEntradaM.AllowUserToDeleteRows = False
        Me.DGVEntradaM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEntradaM.Location = New System.Drawing.Point(193, 156)
        Me.DGVEntradaM.Name = "DGVEntradaM"
        Me.DGVEntradaM.ReadOnly = True
        Me.DGVEntradaM.Size = New System.Drawing.Size(243, 256)
        Me.DGVEntradaM.TabIndex = 19
        Me.DGVEntradaM.Visible = False
        '
        'label_fechaE
        '
        Me.label_fechaE.AutoSize = True
        Me.label_fechaE.Location = New System.Drawing.Point(26, 187)
        Me.label_fechaE.Name = "label_fechaE"
        Me.label_fechaE.Size = New System.Drawing.Size(55, 26)
        Me.label_fechaE.TabIndex = 18
        Me.label_fechaE.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entrada:"
        Me.label_fechaE.Visible = False
        '
        'txt_fechaE
        '
        Me.txt_fechaE.Location = New System.Drawing.Point(87, 193)
        Me.txt_fechaE.Name = "txt_fechaE"
        Me.txt_fechaE.ReadOnly = True
        Me.txt_fechaE.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaE.TabIndex = 17
        Me.txt_fechaE.Visible = False
        '
        'label_usuarioE
        '
        Me.label_usuarioE.AutoSize = True
        Me.label_usuarioE.Location = New System.Drawing.Point(38, 159)
        Me.label_usuarioE.Name = "label_usuarioE"
        Me.label_usuarioE.Size = New System.Drawing.Size(46, 13)
        Me.label_usuarioE.TabIndex = 16
        Me.label_usuarioE.Text = "Usuario:"
        Me.label_usuarioE.Visible = False
        '
        'txt_usuarioE
        '
        Me.txt_usuarioE.Location = New System.Drawing.Point(87, 156)
        Me.txt_usuarioE.Name = "txt_usuarioE"
        Me.txt_usuarioE.ReadOnly = True
        Me.txt_usuarioE.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuarioE.TabIndex = 15
        Me.txt_usuarioE.Visible = False
        '
        'label_noEn
        '
        Me.label_noEn.AutoSize = True
        Me.label_noEn.Location = New System.Drawing.Point(8, 117)
        Me.label_noEn.Name = "label_noEn"
        Me.label_noEn.Size = New System.Drawing.Size(73, 13)
        Me.label_noEn.TabIndex = 13
        Me.label_noEn.Text = "N° de entrada"
        Me.label_noEn.Visible = False
        '
        'txt_noEntradaE
        '
        Me.txt_noEntradaE.Location = New System.Drawing.Point(87, 114)
        Me.txt_noEntradaE.Name = "txt_noEntradaE"
        Me.txt_noEntradaE.Size = New System.Drawing.Size(100, 20)
        Me.txt_noEntradaE.TabIndex = 12
        Me.txt_noEntradaE.Visible = False
        '
        'btn_buscarE
        '
        Me.btn_buscarE.Location = New System.Drawing.Point(193, 112)
        Me.btn_buscarE.Name = "btn_buscarE"
        Me.btn_buscarE.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarE.TabIndex = 11
        Me.btn_buscarE.Text = "Buscar"
        Me.btn_buscarE.UseVisualStyleBackColor = True
        Me.btn_buscarE.Visible = False
        '
        'CBReportesE
        '
        Me.CBReportesE.FormattingEnabled = True
        Me.CBReportesE.Items.AddRange(New Object() {"No. de entrada", "Usuario", "Fecha"})
        Me.CBReportesE.Location = New System.Drawing.Point(87, 22)
        Me.CBReportesE.Name = "CBReportesE"
        Me.CBReportesE.Size = New System.Drawing.Size(132, 21)
        Me.CBReportesE.TabIndex = 20
        Me.CBReportesE.Text = "Seleccione una opcion"
        '
        'label_matriculaU
        '
        Me.label_matriculaU.AutoSize = True
        Me.label_matriculaU.Location = New System.Drawing.Point(19, 75)
        Me.label_matriculaU.Name = "label_matriculaU"
        Me.label_matriculaU.Size = New System.Drawing.Size(65, 26)
        Me.label_matriculaU.TabIndex = 23
        Me.label_matriculaU.Text = "Matricula de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "usuario"
        Me.label_matriculaU.Visible = False
        '
        'txt_reporteU
        '
        Me.txt_reporteU.Location = New System.Drawing.Point(87, 77)
        Me.txt_reporteU.Name = "txt_reporteU"
        Me.txt_reporteU.Size = New System.Drawing.Size(100, 20)
        Me.txt_reporteU.TabIndex = 22
        Me.txt_reporteU.Visible = False
        '
        'btn_buscarMatE
        '
        Me.btn_buscarMatE.Location = New System.Drawing.Point(193, 75)
        Me.btn_buscarMatE.Name = "btn_buscarMatE"
        Me.btn_buscarMatE.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarMatE.TabIndex = 21
        Me.btn_buscarMatE.Text = "Buscar"
        Me.btn_buscarMatE.UseVisualStyleBackColor = True
        Me.btn_buscarMatE.Visible = False
        '
        'DGVReportesEU
        '
        Me.DGVReportesEU.AllowUserToAddRows = False
        Me.DGVReportesEU.AllowUserToDeleteRows = False
        Me.DGVReportesEU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReportesEU.Location = New System.Drawing.Point(22, 112)
        Me.DGVReportesEU.Name = "DGVReportesEU"
        Me.DGVReportesEU.ReadOnly = True
        Me.DGVReportesEU.Size = New System.Drawing.Size(464, 241)
        Me.DGVReportesEU.TabIndex = 24
        Me.DGVReportesEU.Visible = False
        '
        'labelU
        '
        Me.labelU.AutoSize = True
        Me.labelU.Location = New System.Drawing.Point(296, 80)
        Me.labelU.Name = "labelU"
        Me.labelU.Size = New System.Drawing.Size(46, 13)
        Me.labelU.TabIndex = 25
        Me.labelU.Text = "Usuario:"
        Me.labelU.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Buscar por:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(29, 55)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 27
        Me.MonthCalendar1.Visible = False
        '
        'DGVFecha
        '
        Me.DGVFecha.AllowUserToAddRows = False
        Me.DGVFecha.AllowUserToDeleteRows = False
        Me.DGVFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFecha.Location = New System.Drawing.Point(22, 229)
        Me.DGVFecha.Name = "DGVFecha"
        Me.DGVFecha.ReadOnly = True
        Me.DGVFecha.Size = New System.Drawing.Size(464, 209)
        Me.DGVFecha.TabIndex = 28
        Me.DGVFecha.Visible = False
        '
        'btn_nuevaEntradaE
        '
        Me.btn_nuevaEntradaE.Location = New System.Drawing.Point(379, 20)
        Me.btn_nuevaEntradaE.Name = "btn_nuevaEntradaE"
        Me.btn_nuevaEntradaE.Size = New System.Drawing.Size(107, 23)
        Me.btn_nuevaEntradaE.TabIndex = 29
        Me.btn_nuevaEntradaE.Text = "Nueva Entrada"
        Me.btn_nuevaEntradaE.UseVisualStyleBackColor = True
        '
        'ReportesEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 450)
        Me.Controls.Add(Me.btn_nuevaEntradaE)
        Me.Controls.Add(Me.DGVFecha)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelU)
        Me.Controls.Add(Me.DGVReportesEU)
        Me.Controls.Add(Me.label_matriculaU)
        Me.Controls.Add(Me.txt_reporteU)
        Me.Controls.Add(Me.btn_buscarMatE)
        Me.Controls.Add(Me.CBReportesE)
        Me.Controls.Add(Me.DGVEntradaM)
        Me.Controls.Add(Me.label_fechaE)
        Me.Controls.Add(Me.txt_fechaE)
        Me.Controls.Add(Me.label_usuarioE)
        Me.Controls.Add(Me.txt_usuarioE)
        Me.Controls.Add(Me.label_noEn)
        Me.Controls.Add(Me.txt_noEntradaE)
        Me.Controls.Add(Me.btn_buscarE)
        Me.Name = "ReportesEntradas"
        Me.Text = "ReportesEntradas"
        CType(Me.DGVEntradaM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVReportesEU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVEntradaM As DataGridView
    Friend WithEvents label_fechaE As Label
    Friend WithEvents txt_fechaE As TextBox
    Friend WithEvents label_usuarioE As Label
    Friend WithEvents txt_usuarioE As TextBox
    Friend WithEvents label_noEn As Label
    Friend WithEvents txt_noEntradaE As TextBox
    Friend WithEvents btn_buscarE As Button
    Friend WithEvents CBReportesE As ComboBox
    Friend WithEvents label_matriculaU As Label
    Friend WithEvents txt_reporteU As TextBox
    Friend WithEvents btn_buscarMatE As Button
    Friend WithEvents DGVReportesEU As DataGridView
    Friend WithEvents labelU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DGVFecha As DataGridView
    Friend WithEvents btn_nuevaEntradaE As Button
End Class
