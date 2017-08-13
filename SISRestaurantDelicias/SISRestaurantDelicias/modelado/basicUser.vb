Public Class basicUser
    Protected Friend id As String
    Protected Friend nombre As String
    Protected Friend pasword As String
    Protected Friend rol As String
    Protected Friend restaurante As String

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal pass As String, ByVal rol As String, ByVal rest As String)
        Me.id = id
        Me.nombre = nombre
        Me.rol = rol
        Me.pasword = pass
        Me.restaurante = rest
    End Sub
End Class
