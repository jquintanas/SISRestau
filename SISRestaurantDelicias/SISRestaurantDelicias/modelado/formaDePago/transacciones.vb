Public Class transacciones
    Private descripcion As String
    Private fecha As Date
    Private salida As String
    Public Sub New(ByVal descripcion As String, ByVal fecha As Date)
        Me.descripcion = descripcion
        Me.fecha = fecha
        Me.fecha = Today
        Me.salida = Me.descripcion + ", " + Me.fecha.ToString("dddd, d MMM yyyy")
    End Sub

    Public Overrides Function ToString() As String
        Return Me.salida
    End Function

End Class
