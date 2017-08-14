Public Class mostrarPlato
    Private plato As platillos
    Public Sub New(ByVal plat As platillos)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.plato = plat
    End Sub
    Private Sub mostrarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescripcion.Text = Me.plato.toString
    End Sub
End Class