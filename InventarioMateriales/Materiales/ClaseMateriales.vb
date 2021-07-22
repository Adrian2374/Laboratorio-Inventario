Imports Oracle.DataAccess.Client
Public Class ClaseMateriales

    'Variables de instancia de la Clase
    Private ElIdMaterial As Integer
    Private ElNombreDeMAterial As String
    Private LaDescDelMaterial As String
    Public aux As Integer


    'Método constructor inicializa variables
    Public Sub New()

        ElIdMaterial = 0
        ElNombreDeMAterial = ""
        LaDescDelMaterial = ""

    End Sub

    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal txtIdMaterial As Integer,
                   ByVal txtNombMaterial As String, ByVal txtDescMaterial As String)
        'En estas variables recibimos los datos del formulario
        ElIdMaterial = txtIdMaterial
        ElNombreDeMAterial = txtNombMaterial
        LaDescDelMaterial = txtDescMaterial



    End Sub

    'Metodos get y set
    Public Property getSetElIdMaterial() As Integer
        Get
            Return ElIdMaterial
        End Get
        Set(ByVal Value As Integer)
            ElIdMaterial = Value
        End Set
    End Property

    Public Property getSetElNombreDeMAterial() As String
        Get
            Return ElNombreDeMAterial
        End Get
        Set(ByVal Value As String)
            ElNombreDeMAterial = Value
        End Set
    End Property

    Public Property getSetLaDescDelMaterial() As String
        Get
            Return LaDescDelMaterial
        End Get
        Set(ByVal Value As String)
            LaDescDelMaterial = Value
        End Set
    End Property

    Public Sub insertaMaterial()
        Dim strSql As String
        Dim xCnx As New ConexionBD
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If ElIdMaterial <> 0 And ElNombreDeMAterial <> "" And LaDescDelMaterial <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO materiales VALUES('" & ElIdMaterial & "', '" &
                                                      ElNombreDeMAterial & "', '" &
                                                      LaDescDelMaterial & "')"
            MsgBox("Estaoy en el medtodo insertaMaterial ...")
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos para el usuario, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub


    Public Sub actualizaMaterial()
        Dim strSql As String
        Dim xCnx As New ConexionBD
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el Update
        If ElIdMaterial <> 0 And ElNombreDeMAterial <> "" And
           LaDescDelMaterial <> "" Then
            ' Preparamos el query para modificar el registro
            strSql = "UPDATE materiales set idMaterial ='" & ElIdMaterial & "', " &
                     " nombreMaterial ='" & ElNombreDeMAterial & "', " &
                     " descMaterial = '" & LaDescDelMaterial & "' " &
            "where idMaterial = " & ElIdMaterial

            MsgBox("Estaoy en el medtodo actualizaMaterial ...")
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos del material !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub


    'Consulta datos de todas las carreras registradas
    Public Function consultaTodosLosMateriales() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New ConexionBD
        'Preparamos el query para listar a los usuarios registrados
        'en la base de datos, incluyendo el nombre del país,
        'del estado, de la ciudad y de la colonia en el DGV
        strSQL = "SELECT idMaterial as ID_Material, nombreMaterial  as Nombre_de_Material, descMaterial as Descripcion_de_Material
                 From materiales "
        consultaTodosLosMateriales = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub PoblarDataGridMateriales(ByVal dgvRegistroDeMateriales As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        dgvRegistroDeMateriales.DataSource = consultaTodosLosMateriales()
        dgvRegistroDeMateriales.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        dgvRegistroDeMateriales.Columns.Item(0).Width = 120
        dgvRegistroDeMateriales.Columns.Item(1).Width = 190
        dgvRegistroDeMateriales.Columns.Item(2).Width = 220

    End Sub



End Class
