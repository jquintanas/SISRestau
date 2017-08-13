Public Class platillos

    Private id As String
    Private nombre As String
    Private categoria As String
    Private ingredientes As String
    Private imagenes As String
    Private descripcion As String
    Private tipo As String
    Private servido As String
    Private restaurante As String

    Public Sub New(ByVal id As String, ByVal nombre As String, ByVal categoria As String, ByVal ingredientes As String, ByVal imagenes As String, ByVal descripcion As String, ByVal tipo As String, ByVal servido As String, ByVal restaurant As String)
        Me.id = id
        Me.nombre = nombre
        Me.categoria = categoria
        Me.ingredientes = ingredientes
        Me.imagenes = imagenes
        Me.descripcion = descripcion
        Me.tipo = tipo
        Me.servido = servido
        Me.restaurante = restaurant
    End Sub

    Public Property Fullid() As String
        Get
            Return Me.id
        End Get
        Set(ByVal value As String)
            Me.id = value
        End Set
    End Property

    Public Property Fullnombre() As String
        Get
            Return Me.nombre
        End Get
        Set(ByVal value As String)
            Me.nombre = value

        End Set
    End Property

    Public Property FullCategoria() As String
        Get
            Return Me.categoria
        End Get
        Set(ByVal value As String)
            Me.categoria = value
        End Set
    End Property

    Public Property FullIngredientes() As String
        Get
            Return Me.ingredientes
        End Get
        Set(ByVal value As String)
            Me.ingredientes = value
        End Set
    End Property

    Public Property FullImagenes() As String
        Get
            Return Me.imagenes
        End Get
        Set(ByVal value As String)
            Me.imagenes = value
        End Set
    End Property

    Public Property Fulldescripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(ByVal value As String)
            Me.descripcion = value
        End Set
    End Property

    Public Property Fulltipo() As String
        Get
            Return Me.tipo
        End Get
        Set(ByVal value As String)
            Me.tipo = value
        End Set
    End Property

    Public Property Fullservido() As String
        Get
            Return Me.servido
        End Get
        Set(ByVal value As String)
            Me.servido = value
        End Set
    End Property

    Public Property FullRestaurant() As String
        Get
            Return Me.restaurante
        End Get
        Set(ByVal value As String)
            Me.restaurante = value
        End Set
    End Property

    Public Function toString1() As String
        Return Me.nombre + " su servido es: " + Me.servido + " es de tipo: " + Me.tipo + " se encuentra en el restaurante: " + Me.restaurante
    End Function

    Public Overrides Function toString() As String
        Return "Su seleccion es: " + Me.nombre + " es de servido: " + Me.servido + " lo encuentra en el restaurante: " + Me.restaurante + " la categoria es: " + Me.categoria +
            " los ingredientes son: " + Me.ingredientes + " Descripción: " + Me.descripcion
    End Function

End Class
