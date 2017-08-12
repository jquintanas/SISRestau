Imports System.Text.RegularExpressions

Public Class userLogin
    Protected Friend id As String
    Protected Friend nombre As String
    Protected Friend pasword As String
    Protected Friend rol As String
    Protected Friend diccionarioCategoria As List(Of String)
    Protected Friend keyC As List(Of String)
    Protected Friend keyCSinRepeticiones As List(Of String)
    Protected Friend platillos As List(Of platillos)
    Protected Friend clavesPlatillos As List(Of String)

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal password As String, ByVal rol As String, ByVal platillos As List(Of platillos), ByVal clavesPlatillos As List(Of String))
        Me.id = id
        Me.nombre = nombre
        Me.pasword = password
        Me.rol = rol
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

    Public Function buscarPlato(ByVal nombre As String) As Integer
        Dim bandera As Integer = 0
        Dim op1 As String
        op1 = ".*" + nombre + ".*"
        Dim nombrePlatilloRegex As Regex = New Regex(op1)
        For i = 0 To Me.platillos.Count
            Dim m As Match = nombrePlatilloRegex.Match(Me.platillos(i).Fullnombre)
            If m.Success Then
                bandera = 1
                Dim salida As String
                salida = "nombre: " + Me.platillos(1).Fullnombre + " servido: " + Me.platillos(2).Fullservido + " tipo: " + Me.platillos(3).Fulltipo + " restaurante: " + Me.platillos(4).FullRestaurant
                panelDeVista.ListBox1.Items.Add(salida)
            End If
        Next
        Return bandera
    End Function

    Public Sub listarCategoria()
        Dim I As Integer = 1
        For Each plato As platillos In Me.platillos
            If Me.diccionarioCategoria.Contains(plato.FullCategoria) = False Then
                Me.diccionarioCategoria.Add(plato.FullCategoria)
            End If
        Next
        For Each cate As String In Me.diccionarioCategoria
            panelDeVista.ListBoxCategorias.Items.Add(cate)
            I = I + 1
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

    Public Function mostrarPlatillo(ByVal id As String) As Integer
        Dim retorno As Integer
        For Each plato As platillos In Me.platillos
            If plato.Fullid = id Then
                panelDeVista.ListBox1.Items.Clear()
                panelDeVista.ListBox1.Items.Add("Su seleccion es: " + plato.Fullnombre)
                panelDeVista.ListBox1.Items.Add("Es de servido: " + plato.Fullservido)
                panelDeVista.ListBox1.Items.Add("Es de tipo: " + plato.Fulltipo)
                panelDeVista.ListBox1.Items.Add("Lo encuentra en el restaurante: " + plato.FullRestaurant)
                panelDeVista.ListBox1.Items.Add("La categoria es: " + plato.FullCategoria)
                panelDeVista.ListBox1.Items.Add("Los ingredientes son: " + plato.FullIngredientes)
                panelDeVista.ListBox1.Items.Add("Imagenes: " + plato.FullImagenes)
                panelDeVista.ListBox1.Items.Add("Descripción: " + plato.Fulldescripcion)
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
        Return retorno
    End Function

    Public Function mostrarPlatillos(ByVal categoria As categoria) As List(Of String)
        Dim I As Integer = 1
        Dim listTmp As List(Of String)
        panelDeVista.ListBox1.Items.Clear()
        For Each plato As platillos In Me.platillos
            If plato.FullCategoria = categoria.Fullnombre Then
                panelDeVista.ListBox1.Items.Add(I + ".- " + plato.Fullnombre + " su servido es: " + plato.Fullservido +
                                                " es de tipo: " + plato.Fulltipo + " se encuentra en el restaurante: " + plato.FullRestaurant)
                listTmp.Add(plato.Fullnombre)
                I = I + 1
            End If
        Next
        Return listTmp
    End Function
    

End Class
