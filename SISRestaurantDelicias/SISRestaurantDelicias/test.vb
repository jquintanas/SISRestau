Imports System.Threading
Public Class test
    Public Shared Property DateString As String

    Public Function lanzar() As String
        Randomize()
        Dim iDormir As Integer = CInt(3000 * Rnd())
        Return Convert.ToString(iDormir)
    End Function
    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim factory As factoryCreator
        'Dim nombre As String = InputBox("nombre")
        'factory = New creadorDePlatillos(nombre)
        'Dim lista As List(Of platillos) = factory.CrearListaRestaurantes
        'For Each pla As platillos In lista
        '    MsgBox(pla.Fullnombre)
        'Next
        'MsgBox("The formatted date is " & Format(Now, "dddd, d MMM yyyy"))
        'Dim f As String = "#8/2/2020#"

        'Dim date1 As Date = f
        'Dim date2 As Date = Today
        'MsgBox(date2)
        'Dim result As Integer = DateTime.Compare(date1, date2)
        'MsgBox(result)

        Dim hilo1 As New Thread(AddressOf lanzar) 'Crear el hilo 1
        Dim hilo2 As New Thread(AddressOf lanzar) 'Crear el hilo 2




    End Sub
End Class