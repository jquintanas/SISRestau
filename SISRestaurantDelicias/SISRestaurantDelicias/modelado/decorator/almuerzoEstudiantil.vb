Public Class almuerzoEstudiantil : Implements IAlmuerzo

    Protected Friend almuerzo As platillos
    Protected Friend precio As Double = 0

    Public Sub New(ByVal almuerzo As platillos)
        Me.almuerzo = almuerzo
    End Sub

    Public Sub crearAlmuerzo() Implements IAlmuerzo.crearAlmuerzo
        MsgBox("Usted tiene un almuerzo tiene un precio de: $" + Convert.ToString(Me.precio), MsgBoxStyle.Information)
    End Sub

    Public Sub aumentarPrecio(ByVal precio As Double) Implements IAlmuerzo.aumentarPrecio
        Me.precio = Me.precio + precio
    End Sub


    Public Function getPrecio() As Double Implements IAlmuerzo.getPrecio
        Return Me.precio
    End Function
End Class
