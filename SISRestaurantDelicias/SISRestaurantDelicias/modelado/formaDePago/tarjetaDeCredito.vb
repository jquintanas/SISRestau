Public Class tarjetaDeCredito

    Protected Friend numeroTarjeta As String
    Protected Friend cvc As Integer
    Protected Friend fechaExpiracion As String
    Public Sub New(ByVal numero As String, ByVal cvc As Integer, ByVal fecha As String)
        Me.numeroTarjeta = numero
        Me.cvc = cvc
        Me.fechaExpiracion = fecha
    End Sub

    Private Sub generarOrden()
        Randomize()
        Dim value As Integer = CInt(Int((100 * Rnd()) + 1))
        MsgBox("Su compra se realizo con exito, el numero de orden es: " + Convert.ToString(value), MsgBoxStyle.Information)

    End Sub

    Public Function pagar(ByVal monto As Double) As Boolean
        Randomize()
        Dim value As Integer = CInt(Int((2 * Rnd()) + 1))
        If value = 1 Then
            generarOrden()
            Return True
        Else
            MsgBox("La tarjeta no tiene fondos", MsgBoxStyle.Critical)
            Return False
        End If
    End Function
End Class
