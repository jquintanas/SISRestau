Public Class almuerzoEstudiantil : Implements IAlmuerzo

    Protected Friend almuerzo As platillos
    Protected Friend precio As Double = 0

    Public Sub New(ByVal almuerzo As platillos)
        Me.almuerzo = almuerzo
    End Sub

    Public Function crearAlmuerzo() As String Implements IAlmuerzo.crearAlmuerzo
        Return Convert.ToString(Me.precio)
    End Function

    Public Sub aumentarPrecio(ByVal precio As Double) Implements IAlmuerzo.aumentarPrecio
        Me.precio = Me.precio + precio
    End Sub


    Public Function getPrecio() As Double Implements IAlmuerzo.getPrecio
        Return Me.precio
    End Function
End Class
