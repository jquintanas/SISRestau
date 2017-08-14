Public Class mostrarPlato
    Private plato As platillos
    Private user As estudiante
    Public Sub New(ByVal plat As platillos, ByVal user As basicUser)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.plato = plat
        Me.user = user
    End Sub
    Private Sub mostrarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescripcion.Text = Me.plato.toString
    End Sub
End Class