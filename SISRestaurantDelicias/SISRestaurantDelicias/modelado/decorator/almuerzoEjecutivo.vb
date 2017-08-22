Public MustInherit Class almuerzoEjecutivo : Implements IAlmuerzo



    Protected almuerzo As IAlmuerzo


    Public Sub New(ByVal alm As IAlmuerzo)
        Me.almuerzo = alm
    End Sub

    Public MustOverride Sub aumentarPrecio(ByVal precio As Double) Implements IAlmuerzo.aumentarPrecio


    Public MustOverride Function crearAlmuerzo() As String Implements IAlmuerzo.crearAlmuerzo

    Public MustOverride Function getPrecio() As Double Implements IAlmuerzo.getPrecio

End Class
