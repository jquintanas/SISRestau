Public Class otraFormaDePago
    Private par1 As String
    Private par2 As String
    Public Sub New(ByVal p As String, ByVal p2 As String)
        Me.par1 = p
        Me.par2 = p2
    End Sub
    Public Sub generarOrden()
        MsgBox("mi orden")
    End Sub

    Public Sub pagar(ByVal monto As Double)
        MsgBox("se cobro: " + monto, MsgBoxStyle.Information)
    End Sub
End Class
