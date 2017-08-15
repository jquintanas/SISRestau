Public Class administradorDeSaldos
    Private carnet As carnetInteligente

    Public Sub New(ByVal carnet As carnetInteligente)
        Me.carnet = carnet
    End Sub

    Public Sub ingresoNotaDeCredito(ByVal monto As Double)
        Me.carnet.getMontoDeCuenta = monto
        Me.carnet.addTransaccion(New transacciones("Se recargo la cuenta", New Date))
    End Sub

    Public Sub ingresoNoraDeDebito(ByVal monto As Double)
        Me.carnet.pagar(monto)
    End Sub

    Public Sub consultarSaldoDeCuenta()
        MsgBox("Su saldo actual es: " + Convert.ToString(Me.carnet.getMontoDeCuenta), MsgBoxStyle.Information)

    End Sub

    Public Sub consultaMovimientos()
        Dim form As New detallesDeSISPago
        form.cargarTransacciones(Me.carnet.getTransacciones, False)
        form.Show()
    End Sub

    Public Sub consulaDECompras()
        Dim form As New detallesDeSISPago
        form.cargarTransacciones(Me.carnet.getCompras, True)
        form.Show()
    End Sub

    Public Function nuevoCarnet() As carnetInteligente
        Dim id As String = InputBox("Ingrese el id del carnet")
        Dim monto As Double = Convert.ToDouble(InputBox("Ingrese el monto de la cuenta"))
        Return New carnetInteligente(id, monto)
    End Function
End Class
