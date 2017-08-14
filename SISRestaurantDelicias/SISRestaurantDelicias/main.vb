Public Class main
    Private mid As New Dictionary(Of String, Collection)
    Private user As basicUser
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mid = lecturaDeArchivo.leerArchivo("dataAccess/platillos.txt")
        Dim plato As New platillos("1", "hamburguesa", "Plato Fuerte", "pan lechuga queso tomate", "image/img2.jpg", "esta es una hamburguesa rica", "Aperitivo", "Caliente", "celex")
        Dim plato2 As New platillos("2", "hamburguesa2", "comida feetness", "pan lechuga queso tomate", "image/img2.jpg", "esta es una hamburguesa rica", "Aperitivo", "Caliente", "celex")
        Dim lisp As New List(Of platillos)
        lisp.Add(plato)
        lisp.Add(plato2)
        Dim claves As New List(Of String)
        claves.Add("1")
        claves.Add("2")
        Dim restaurant As New restaurante("celex", "midirec", 1234567, "soy el dueno", lisp)
        Dim pago As New IFormaDePago
        'Me.user = New estudiante("123", "jonathan", "000360", constantes.estudiante, lisp, claves, pago)
        Me.user = New Asistente("123", "jonathan", "000360", constantes.asistenteR, lisp, claves, restaurant)
        Me.Panel1.Controls.Clear()
        'Dim frm1 As New panelDeVistaAsistente(Me.user)
        Dim listU As New List(Of basicUser)
        listU.Add(Me.user)
        Dim frm1 As New login(listU)
        Me.Panel1.Controls.Add(frm1.Panel1)
    End Sub

End Class