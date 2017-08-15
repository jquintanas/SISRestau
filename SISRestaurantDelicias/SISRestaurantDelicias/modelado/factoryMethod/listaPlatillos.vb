Public MustInherit Class listaPlatillos
    Protected Friend listaPlatillos As List(Of platillos)
    Protected Friend ruta As String

    Public Sub New(ByVal ruta As String)
        Me.ruta = ruta
    End Sub

    Public Function getLista() As List(Of platillos)
        Return Me.listaPlatillos
    End Function

    Public MustOverride Sub crearListaPlatillos()

End Class
