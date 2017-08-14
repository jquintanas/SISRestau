Public Class main
    Private mid As New Dictionary(Of String, Collection)
    Private user As basicUser
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mid = lecturaDeArchivo.leerArchivo("dataAccess/platillos.txt")
        Dim plato As New platillos("1", "hamburguesa", "Plato Fuerte", "pan lechuga queso tomate", "image/img2.jpg", "esta es una hamburguesa rica", "Aperitivo", "Caliente", "celex")
        Dim lisp As New List(Of platillos)
        lisp.Add(plato)
        Dim claves As New List(Of String)
        claves.Add("1")
        Dim pago As New IFormaDePago
        Me.user = New estudiante("123", "jonathan", "000360", constantes.estudiante, lisp, claves, pago)
        Me.Panel1.Controls.Clear()
        Dim frm1 As New panelDeVista(Me.user)
        Me.Panel1.Controls.Add(frm1.Panel1)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
    End Sub
End Class