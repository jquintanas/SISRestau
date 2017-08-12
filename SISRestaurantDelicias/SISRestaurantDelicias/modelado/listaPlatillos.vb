Public Class listaPlatillos
    Private key As List(Of String)
    Private platillos As List(Of platillos)

    Public Property fullPlatillos() As List(Of platillos)
        Get
            Return Me.platillos
        End Get
        Set(ByVal value As List(Of platillos))
            Me.platillos = value
        End Set
    End Property

    Public Property fullKey() As List(Of String)
        Get
            Return Me.key
        End Get
        Set(ByVal value As List(Of String))
            Me.key = value

        End Set

    End Property



End Class
