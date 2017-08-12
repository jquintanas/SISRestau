Public Class Asistente : Inherits userLogin

    Protected Friend rest As restaurante

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String), ByVal restaurant As restaurante)
        MyBase.New(id, nombre, password, rol, platillos, clavesPlatillos)
        Me.rest = restaurant
    End Sub

    

End Class
