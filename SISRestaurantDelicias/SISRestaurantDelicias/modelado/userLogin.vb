Imports System.Text.RegularExpressions

Public Class userLogin : Inherits basicUser
    Protected Friend diccionarioCategoria As New List(Of String)
    Protected Friend keyC As List(Of String)
    Protected Friend keyCSinRepeticiones As List(Of String)
    Protected Friend platillos As List(Of platillos)
    Protected Friend clavesPlatillos As List(Of String)

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String), ByVal rest As String)
        MyBase.New(id, nombre, password, rol, rest)
        Me.platillos = platillos
        Me.clavesPlatillos = clavesPlatillos
    End Sub

    Public Function transformarClave(ByVal op As Integer) As String
        For i = 0 To Me.keyC.Count
            If Me.keyCSinRepeticiones.Contains(Me.keyC(i)) = False Then
                Me.keyCSinRepeticiones.Add(Me.keyC(i))
            End If
        Next
        Dim bandera As Boolean = True
        While bandera
            If (op - 1) < Me.keyCSinRepeticiones.Count Then
                bandera = False
            Else
                op = Convert.ToInt32(InputBox("Categoria erronea ", "seleccione una opcion correcta"))

            End If
        End While
        Return Me.keyCSinRepeticiones(op - 1)
    End Function

    

    Public Sub listarCategoria()
        For Each plato As platillos In Me.platillos
            If Me.diccionarioCategoria.Contains(plato.FullCategoria) = False Then
                Me.diccionarioCategoria.Add(plato.FullCategoria)
            End If
        Next
    End Sub

    Private Function yesNoInput() As Boolean
        Dim choice As String
        choice = InputBox("Desea mostrar la imagen y/n ", "Seleccione")
        Dim opciones As Regex = New Regex("[yY(yes)(Yes)(YES)(Si)(SI)]")
        Dim m As Match = opciones.Match(choice)
        If m.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrarPlatillo(ByVal id As String) As Collection
        Dim retorno As Integer
        Dim colR As Collection
        For Each plato As platillos In Me.platillos
            If plato.Fullid = id Then
                colR.Add(plato)
            End If
            If Me.rol = constantes.estudiante Then
                Dim opc As Boolean = yesNoInput()
                If opc = True Then
                    retorno = 1
                Else
                    retorno = 0
                End If
            End If
        Next
        colR.Add(retorno)
        Return colR
    End Function

    Public Function mostrarPlatillos(ByVal categoria As categoria) As Collection
        Dim listTmp As New List(Of String)
        Dim listPlatos As New List(Of platillos)
        Dim retorno As New Collection
        For Each plato As platillos In Me.platillos
            If plato.FullCategoria = categoria.Fullnombre Then
                listTmp.Add(plato.Fullnombre)
                listPlatos.Add(plato)
            End If
        Next
        retorno.Add(listPlatos)
        retorno.Add(listTmp)
        Return retorno
    End Function


End Class
