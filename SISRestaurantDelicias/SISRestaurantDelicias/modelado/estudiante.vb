Imports System.Text.RegularExpressions

Public Class estudiante : Inherits userLogin
    Protected Friend carnetInteligente As IFormaDePago

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String), ByVal carnetInteligente As IFormaDePago)
        MyBase.New(id, nombre, password, rol, platillos, clavesPlatillos, "no")
        Me.carnetInteligente = carnetInteligente
    End Sub
    Public Function buscarPlatoN(ByVal nombre As String) As Collection
        Dim bandera As Integer = 0
        Dim op1 As String
        Dim colR As New Collection
        Dim lip As New List(Of platillos)
        op1 = ".*" + nombre + ".*"
        Dim nombrePlatilloRegex As Regex = New Regex(op1)
        For i = 0 To Me.platillos.Count - 1
            Dim m As Match = nombrePlatilloRegex.Match(Me.platillos(i).Fullnombre)
            If m.Success Then
                bandera = 1
                lip.Add(Me.platillos(i))
            End If
        Next
        colR.Add(bandera)
        colR.Add(lip)
        Return colR
    End Function

    Public Function buscarPlatoD(ByVal nombre As String) As Collection
        Dim bandera As Integer = 0
        Dim op1 As String
        Dim colR As New Collection
        Dim lip As New List(Of platillos)
        op1 = ".*" + nombre + ".*"
        Dim nombrePlatilloRegex As Regex = New Regex(op1)
        For i = 0 To Me.platillos.Count - 1
            Dim m As Match = nombrePlatilloRegex.Match(Me.platillos(i).Fulldescripcion)
            If m.Success Then
                bandera = 1
                lip.Add(Me.platillos(i))
            End If
        Next
        colR.Add(bandera)
        colR.Add(lip)
        Return colR
    End Function

End Class
