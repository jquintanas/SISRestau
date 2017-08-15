Public Class compras
    Private orden As String
    Private fecha As Date
    Private salida As String
    Public Sub New(ByVal orden As String, ByVal fecha As Date)
        Me.orden = orden
        Me.fecha = fecha
        Me.fecha = Today
        Me.salida = Me.orden + ", " + Me.fecha.ToString("dddd, d MMM yyyy")
    End Sub

    Public Overrides Function toString() As String
        Return salida
    End Function
End Class
