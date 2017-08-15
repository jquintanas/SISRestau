Public Class tarjetaCreditoAdapter : Implements IFormaDePago2
    Protected tarjeta As tarjetaDeCredito
    Public Sub New(ByVal numero As String, ByVal cvc As Integer, ByVal expi As String)
        Me.tarjeta = New tarjetaDeCredito(numero, cvc, expi)
    End Sub
    Private Sub generarOrden() Implements IFormaDePago2.generarOrden
        MsgBox("Orden Generada")
    End Sub

    Public Sub pagar(ByVal monto As Double) Implements IFormaDePago2.pagar
        Me.tarjeta.pagar(monto)

    End Sub
End Class
