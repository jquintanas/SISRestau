Public Class decoratorPostre : Inherits almuerzoEjecutivo


    Private precio As Double = 0.5

    Public Sub New(ByVal pla As IAlmuerzo)
        MyBase.New(pla)
    End Sub


    Public Overrides Sub aumentarPrecio(ByVal precio As Double)
        MyBase.almuerzo.aumentarPrecio(Me.precio + precio)
    End Sub

    Public Overrides Sub crearAlmuerzo()
        MyBase.almuerzo.crearAlmuerzo()

    End Sub

    Public Overrides Function getPrecio() As Double
        Return MyBase.almuerzo.getPrecio
    End Function
End Class
