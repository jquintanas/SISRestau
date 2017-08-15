Public Class creadorDePlatillos : Implements factoryCreator
    Private nombre As String
    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre
    End Sub

    Public Function CrearListaRestaurantes() As System.Collections.Generic.List(Of platillos) Implements factoryCreator.CrearListaRestaurantes
        Dim malicia As New platilloConcretoNuevaMalicia("dataAccess/nuevamalicia.txt")
        Dim otro As New platillosConcretoOtroRestaurante("dataAccess/otroRestau.txt")
        If Me.nombre = "nuevaMalicia" Then
            malicia.crearListaPlatillos()
            Return malicia.getLista
        Else
            otro.crearListaPlatillos()
            Return otro.getLista()
        End If
    End Function
End Class
