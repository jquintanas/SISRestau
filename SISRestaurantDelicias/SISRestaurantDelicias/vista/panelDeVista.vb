Public Class panelDeVista
    Private user As estudiante
    Private lcat As List(Of categoria)
    Private lplatos As List(Of platillos)
    Private Sub panelDeVista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each cat As String In Me.user.diccionarioCategoria
            ListBoxCategorias.Items.Add(cat)
        Next
        lcat = funcionesComunes.listarCategoriasCreadas("dataAccess/categorias.ttxt")
    End Sub

    Private Sub PorNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorNombreToolStripMenuItem.Click

    End Sub

    Private Sub ListarCategoriasDePlatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarCategoriasDePlatosToolStripMenuItem.Click
        
    End Sub

    Private Sub ListBoxCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCategorias.SelectedIndexChanged
        Dim colTmp As New Collection
        For Each cat As categoria In Me.lcat
            If ListBoxCategorias.SelectedItem = cat.Fullnombre Then
                colTmp = user.mostrarPlatillos(cat)
            End If
        Next
        Me.lplatos = colTmp.Item(1)
        For Each pla As platillos In lplatos
            ListBox1.Items.Add(pla.toString1)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim op As Integer
        op = ListBox1.SelectedIndex
        Dim datosMostrar As New mostrarPlato(Me.lplatos.Item(op).toString)
        datosMostrar.Show()

    End Sub
End Class