﻿Public Class test

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim factory As factoryCreator
        Dim nombre As String = InputBox("nombre")
        factory = New creadorDePlatillos(nombre)
        Dim lista As List(Of platillos) = factory.CrearListaRestaurantes
        For Each pla As platillos In lista
            MsgBox(pla.Fullnombre)
        Next
    End Sub
End Class