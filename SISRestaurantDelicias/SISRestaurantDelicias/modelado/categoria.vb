Public Class categoria
    Private id As String
    Private nombre As String

    Public Sub New(ByVal id As String, ByVal nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub

    Public Property Fullnombre() As String
        Get
            Return Me.nombre
        End Get
        Set(ByVal value As String)
            Me.nombre = value

        End Set
    End Property

    Public Property FullId() As String
        Get
            Return Me.id
        End Get
        Set(ByVal value As String)
            Me.id = value
        End Set
    End Property


End Class
