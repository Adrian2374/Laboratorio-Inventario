Imports Oracle.DataAccess.Client
Public Class AgregarModificarMaterial
    Public modificar As Byte


    Private Sub AgregarModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '//Desde aqui tengo que mandar llamar los inserts etc etc
        'verificar que los campos esten llenos 
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto
        If txtIdMaterial.Text.Equals(String.Empty) Then
            MessageBox.Show("Capturar el id del Material !!")
        ElseIf txtNombMaterial.Text = "" Then
            MessageBox.Show("Capturar nombre del material!!")
        ElseIf txtDescMaterial.Text = "" Then
            MessageBox.Show("Capturar la descripcion del material !!")
        Else

            Dim materiales As New ClaseMateriales(txtIdMaterial.Text, txtNombMaterial.Text, txtDescMaterial.Text)

            materiales.getSetElIdMaterial = txtIdMaterial.Text
            materiales.getSetElNombreDeMAterial = txtNombMaterial.Text
            materiales.getSetLaDescDelMaterial = txtDescMaterial.Text


            'Si el material no está registrado, la inserta como una nuevo y sino, solo lo actualiza
            Dim RePoblar As New ClaseMateriales
            If modificar = 2 Then
                materiales.actualizaMaterial()


                materiales.PoblarDataGridMateriales(dgvRegistroDeMat)
            Else
                materiales.insertaMaterial()
                MsgBox("Registro Insertado ...")

                'Dim RePoblar As New ClaseMateriales
                materiales.PoblarDataGridMateriales(dgvRegistroDeMat)

            End If




            Me.Close()


        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide() 'Close()
    End Sub
End Class
