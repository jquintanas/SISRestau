﻿Public Class panelDeVistaAsistente
    Private user As Asistente
    Private vista As vistaGlobal
    Public Sub New(ByVal user As basicUser, ByVal vista As vistaGlobal)
        InitializeComponent()
        Me.user = user
        Me.vista = vista
    End Sub


    Private Sub AgregarPlatilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPlatilloToolStripMenuItem.Click
        Me.user.addPlatillo()
    End Sub

    Private Sub ListarPlatillosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarPlatillosToolStripMenuItem.Click
        Me.ListBox1.Items.Clear()
        For Each plat As platillos In Me.user.listarPlatillos
            Me.ListBox1.Items.Add(plat.toString1)
        Next
    End Sub


    Private Sub ListarCategoríasDePlatillosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarCategoríasDePlatillosToolStripMenuItem.Click
        Me.ListBox2.Items.Clear()
        Me.user.listarCategoria()
        For Each cat As String In Me.user.diccionarioCategoria
            ListBox2.Items.Add(cat)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim op As Integer
        op = ListBox1.SelectedIndex
        If (op >= 0) And (op < Me.user.platillos.Count) Then
            Dim mensaje As String = MsgBox("Desea modificar el platillo", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If mensaje = vbNo Then
                MsgBox("El platillo no sera modificado, gracias")
            Else
                MsgBox("Se va a modificar el platillo")
                Me.user.modificarPlatillo(Convert.ToInt64(Me.user.platillos.Item(op).Fullid))
            End If
        Else
            MsgBox("Plato invalido no selecciono uno existente")
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        main.Show()
        Me.vista.Close()
    End Sub
End Class