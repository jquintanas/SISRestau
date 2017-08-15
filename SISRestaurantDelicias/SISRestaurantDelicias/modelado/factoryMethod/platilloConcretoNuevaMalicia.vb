Public Class platilloConcretoNuevaMalicia : Inherits listaPlatillos
    Public Sub New(ByVal ruta As String)
        MyBase.New(ruta)
    End Sub

    Public Overrides Sub crearListaPlatillos()
        Me.listaPlatillos = utilPlatillos.crearPlatos(Me.ruta)
    End Sub
End Class
