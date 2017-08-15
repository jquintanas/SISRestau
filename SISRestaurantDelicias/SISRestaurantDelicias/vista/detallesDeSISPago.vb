Public Class detallesDeSISPago
    Private transac As List(Of transacciones)
    Private compras As List(Of compras)
    Private item As Boolean

    Public Sub cargarCompras(ByVal comp As List(Of compras), ByVal band As Boolean)
        'item verdadero
        Me.compras = comp
        Me.item = band
    End Sub

    Public Sub cargarTransacciones(ByVal transac As List(Of transacciones), ByVal band As Boolean)
        'item = false
        Me.transac = transac
        Me.item = band
    End Sub
    Private Sub detallesDeSISPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        If Me.item Then
            For Each comp As compras In Me.compras
                ListBox1.Items.Add(comp.toString)
            Next
        Else
            For Each tran As transacciones In Me.transac
                ListBox1.Items.Add(tran.ToString)
            Next
        End If
    End Sub
End Class