Public Class decoratorPostre : Inherits almuerzoEjecutivo


    Private precio As Double = constantes.postre

    Public Sub New(ByVal pla As IAlmuerzo)
        MyBase.New(pla)
    End Sub


    Public Overrides Sub aumentarPrecio(ByVal precio As Double)
        MyBase.almuerzo.aumentarPrecio(Me.precio + precio)
    End Sub

    Public Overrides Function crearAlmuerzo() As String
        Return MyBase.almuerzo.crearAlmuerzo()
    End Function

    Public Overrides Function getPrecio() As Double
        Return MyBase.almuerzo.getPrecio
    End Function
End Class
