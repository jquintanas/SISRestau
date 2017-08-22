Public Class userAdmin : Inherits basicUser
    Protected Friend restaurantes As List(Of restaurante)
    Protected Friend listUser As List(Of basicUser)
    Protected Friend listCat As List(Of categoria)


    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal restaurantes As List(Of restaurante), ByVal rest As String, ByVal user As List(Of basicUser), ByVal listCat As List(Of categoria))
        MyBase.New(id, nombre, password, rol, rest)
        Me.restaurantes = restaurantes
        Me.listUser = user
        Me.listCat = listCat

    End Sub

    Public Sub addUser()
        Dim NewUser As New nuevoUsuario(Me)
        NewUser.Show()
    End Sub

    Public Sub addCategoria()
        Dim nombre As String = InputBox("Ingrese el nombre de la categoria: ")
        Dim catN As New categoria(Me.listCat.Count + 1, nombre)
        Me.listCat.Add(catN)
    End Sub

    Public Sub addRestaurant()
        Dim nuevoRE As New nuevoRestaurante(Me)
        nuevoRE.Show()

    End Sub

    Public Function mostraPlatillos(ByVal rest As restaurante) As List(Of platillos)
        Return rest.platillos
    End Function

    Public Function mostrarRest() As List(Of restaurante)
        Return Me.restaurantes
    End Function
End Class
