Public Class RegistroMateriales
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarModificarMaterial.Show()

        AgregarModificarMaterial.modificar = 1


    End Sub

    'Private Sub btnRefresca_Click(sender As Object, e As EventArgs) Handles btnRefresca.Click

    'MsgBox("Regrese de Insertar ...")
    'Dim materialesUno As New ClaseMateriales()

    '   materialesUno.PoblarDataGridMateriales(dgvRegistroDeMateriales)

    'End Sub

    Private Sub RegistroMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRegistroDeMateriales.ReadOnly = False
        dgvRegistroDeMateriales.Refresh()


        Dim Materiales As New ClaseMateriales
        Materiales.PoblarDataGridMateriales(dgvRegistroDeMateriales)
        dgvRegistroDeMat = dgvRegistroDeMateriales


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub



    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Private Sub dgvRegistroDeMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistroDeMateriales.CellClick
        AgregarModificarMaterial.Show()
        Dim renglon As Integer
        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvRegistroDeMateriales.CurrentCellAddress.Y
        AgregarModificarMaterial.txtIdMaterial.Text = dgvRegistroDeMateriales.Rows(renglon).Cells(0).Value
        AgregarModificarMaterial.txtNombMaterial.Text = dgvRegistroDeMateriales.Rows(renglon).Cells(1).Value
        AgregarModificarMaterial.txtDescMaterial.Text = dgvRegistroDeMateriales.Rows(renglon).Cells(2).Value

        AgregarModificarMaterial.modificar = 2

        AgregarModificarMaterial.txtIdMaterial.Enabled = False





    End Sub









End Class
