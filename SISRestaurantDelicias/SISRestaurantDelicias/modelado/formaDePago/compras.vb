Public Class compras
    Private orden As String
    Private fecha As Date
    Public Sub New(ByVal orden As String, ByVal fecha As Date)
        Me.orden = orden
        Me.fecha = fecha
    End Sub

    Public Overrides Function toString() As String
        Return Me.orden + ", " + Me.fecha.ToString("dd/mm/yyyy")
    End Function
End Class
