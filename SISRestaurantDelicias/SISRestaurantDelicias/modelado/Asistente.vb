Public Class Asistente : Inherits userLogin

    Protected Friend rest As restaurante

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String), ByVal restaurant As restaurante)
        MyBase.New(id, nombre, password, rol, platillos, clavesPlatillos, restaurant.fullNombre)
        Me.rest = restaurant
    End Sub

    Public Function obtenerID(ByVal nombre As String) As Integer
        Dim retorno As Integer = 0

        For Each plato As platillos In Me.platillos
            If plato.Fullnombre = nombre Then
                retorno = Convert.ToInt32(plato.Fullid)
            End If
        Next
        Return retorno
    End Function

    Public Function generarKey() As Integer
        Return Me.platillos.Count + 1
    End Function

    Public Sub addPlatillo()
        Dim nuevoPlatilloF As New nuevoPlatillo(Me, True)
        nuevoPlatilloF.txtKey.Text = Convert.ToString(generarKey())
        nuevoPlatilloF.Show()
    End Sub

    Public Function getPlatillo(ByVal id As Integer) As platillos
        Return Me.platillos.Item(id - 1)
    End Function

    Public Sub modificarPlatillo(ByVal id As Integer)
        Dim platillo As platillos
        platillo = getPlatillo(id)
        Dim nuevoPlatilloModificar As New nuevoPlatillo(Me, False)
        nuevoPlatilloModificar.txtnombre.Text = platillo.Fullnombre
        nuevoPlatilloModificar.txtKey.Text = platillo.Fullid
        nuevoPlatilloModificar.txtdescrip.Text = platillo.Fulldescripcion
        nuevoPlatilloModificar.txtimagenes.Text = platillo.FullImagenes
        nuevoPlatilloModificar.txtingredientes.Text = platillo.FullIngredientes
        nuevoPlatilloModificar.cmbCate.SelectedItem = platillo.FullCategoria
        nuevoPlatilloModificar.cmbServido.SelectedItem = platillo.Fullservido
        nuevoPlatilloModificar.cmbTipo.SelectedItem = platillo.Fulltipo
        nuevoPlatilloModificar.Show()
    End Sub

    Public Property listarPlatillos() As List(Of platillos)
        Get
            Return Me.platillos
        End Get
        Set(ByVal value As List(Of platillos))
            Me.platillos = value
        End Set
    End Property
End Class
