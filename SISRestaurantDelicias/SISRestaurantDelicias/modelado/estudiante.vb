Public Class estudiante : Inherits userLogin
    Protected Friend carnetInteligente As IFormaDePago

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String), ByVal carnetInteligente As IFormaDePago)
        MyBase.New(id, nombre, password, rol, platillos, clavesPlatillos, "no")
        Me.carnetInteligente = carnetInteligente
    End Sub


End Class
