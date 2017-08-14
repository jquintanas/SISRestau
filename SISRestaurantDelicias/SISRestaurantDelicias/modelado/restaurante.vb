Public Class restaurante
    Private nombre As String
    Private direccion As String
    Private telefono As Integer
    Private dueno As String
    Protected Friend platillos As List(Of platillos)

    Public Sub New(ByVal nombre As String, ByVal direcci As String, ByVal telefono As Integer, ByVal dueno As String, ByVal platos As List(Of platillos))
        Me.nombre = nombre
        Me.direccion = direcci
        Me.telefono = telefono
        Me.dueno = dueno
        Me.platillos = platos
    End Sub

    Public Property fullDireccion() As String
        Get
            Return Me.direccion
        End Get
        Set(ByVal value As String)
            Me.direccion = value
        End Set
    End Property

    Public Property fullTelefono() As Integer
        Get
            Return Me.telefono
        End Get
        Set(ByVal value As Integer)
            Me.telefono = value
        End Set
    End Property
    Public Property fullDueno() As String
        Get
            Return Me.dueno
        End Get
        Set(ByVal value As String)
            Me.dueno = value
        End Set
    End Property

    Public Property fullPlatos() As List(Of platillos)
        Get
            Return Me.platillos
        End Get
        Set(ByVal value As List(Of platillos))
            Me.platillos = value
        End Set
    End Property


    Public Property fullNombre() As String
        Get
            Return Me.nombre
        End Get
        Set(ByVal value As String)
            Me.nombre = value
        End Set
    End Property

End Class
