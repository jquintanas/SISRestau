Public Class vistaAsistente

    Private admin As userAdmin

    Public Sub New(ByVal admin As userAdmin)
        InitializeComponent()
        Me.admin = admin

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub AgregarRestauranteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarRestauranteToolStripMenuItem.Click
        Dim addR As New nuevoRestaurante(Me.admin)
        addR.Show()
    End Sub


    Private Sub AgregarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        Dim addU As New nuevoUsuario(Me.admin)
        addU.Show()
    End Sub

    Private Sub AgregarCategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCategoriaToolStripMenuItem.Click
        Me.admin.addCategoria()
    End Sub

End Class