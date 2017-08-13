Public Class mostrarPlato
    Dim descrip As String
    Public Sub New(ByVal desc As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.descrip = desc
    End Sub
    Private Sub mostrarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class