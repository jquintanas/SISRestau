Public Class transacciones
    Private descripcion As String
    Private fecha As Date
    Public Sub New(ByVal descripcion As String, ByVal fecha As Date)
        Me.descripcion = descripcion
        Me.fecha = fecha
    End Sub

    Public Overrides Function ToString() As String
        Return Me.descripcion + ", " + Me.fecha.ToString("dd/mm/yyyy")
    End Function

End Class
