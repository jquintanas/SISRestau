Public Class otraFormaDePagoAdapter : Implements IFormaDePago2
    Private otra As otraFormaDePago
    Public Sub New(ByVal p As String, ByVal p2 As String)
        Me.otra = New otraFormaDePago(p, p2)
    End Sub

    Public Sub generarOrden() Implements IFormaDePago2.generarOrden
        Me.generarOrden()

    End Sub

    Public Sub pagar(ByVal monto As Double) Implements IFormaDePago2.pagar
        Me.pagar(monto)

    End Sub
End Class
