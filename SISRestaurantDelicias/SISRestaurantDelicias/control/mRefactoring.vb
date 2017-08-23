Module mRefactoring
    Public Sub construirMalicia(ByRef factoryPlato As creadorDePlatillos, ByRef listPlatos As List(Of platillos), ByRef claves As List(Of String),
                                ByRef rest As restaurante)
        factoryPlato = New creadorDePlatillos(constantes.malicia)
        listPlatos = factoryPlato.CrearListaRestaurantes()
        For Each pla As platillos In listPlatos
            claves.Add(pla.Fullid)
        Next
        rest = New restaurante(constantes.malicia, "Estoy en la fen", 123456, "El dueño", listPlatos)
    End Sub

    Public Sub contruirOtroRestaurante(ByRef factoryPlato As creadorDePlatillos, ByRef listPlatos As List(Of platillos), ByRef claves As List(Of String),
                                ByRef rest As restaurante)
        factoryPlato = New creadorDePlatillos(constantes.celex)
        listPlatos = factoryPlato.CrearListaRestaurantes()
        For Each pla As platillos In listPlatos
            claves.Add(pla.Fullid)
        Next
        rest = New restaurante(constantes.celex, "Estoy en el celex", 123456, "El dueño", listPlatos)
    End Sub

    Public Sub construirMaliciaUsuario(ByRef factoryPlato As creadorDePlatillos, ByRef listPlatos As List(Of platillos), ByRef claves As List(Of String))
        factoryPlato = New creadorDePlatillos(constantes.malicia)
        listPlatos = factoryPlato.CrearListaRestaurantes()
        For Each pla As platillos In listPlatos
            claves.Add(pla.Fullid)
        Next
    End Sub

    Public Sub construirOtroRestauranteUsuario(ByRef factoryPlato As creadorDePlatillos, ByRef listPlatos As List(Of platillos), ByRef claves As List(Of String))
        factoryPlato = New creadorDePlatillos(constantes.celex)
        listPlatos = factoryPlato.CrearListaRestaurantes()
        For Each pla As platillos In listPlatos
            claves.Add(pla.Fullid)
        Next
    End Sub

    Public Function construirListaRestaurants() As List(Of restaurante)
        Dim lrest As New List(Of restaurante)
        lrest.Add(New restaurante(constantes.celex, "Estoy en el celex", 123456, "El dueño", New List(Of platillos)))
        lrest.Add(New restaurante(constantes.malicia, "Estoy en la fen", 123456, "El dueño", New List(Of platillos)))
        Return lrest
    End Function

    Public Sub decoratorAlmuerzo(ByRef Idecorator As IAlmuerzo, ByRef precio As Double, ByRef txtcosto As TextBox,
                                      ByRef user As estudiante, ByRef bMsg As Boolean)
        Idecorator.aumentarPrecio(precio)
        txtcosto.Text = Idecorator.crearAlmuerzo()
        bMsg = user.carnetInteligente.pagar(Idecorator.getPrecio)
    End Sub

    Public Sub cotizarAlmuerzo(ByRef Idecorator As IAlmuerzo, ByRef precio As Double, ByRef txtcosto As TextBox,
                                      ByRef user As estudiante, ByRef bMsg As Boolean)
        decoratorAlmuerzo(Idecorator, precio, txtcosto, user, bMsg)
        funcionesComunes.mostrarMensaje(bMsg)
    End Sub

    Public Sub borrarCajasTexto(ByRef caja1 As TextBox, ByRef caja2 As TextBox)
        caja1.Clear()
        caja2.Clear()
    End Sub

    Public Sub crearRestaurantes(ByRef userl As basicUser, ByRef factoryPlato As creadorDePlatillos, ByRef listPlatos As List(Of platillos), ByRef claves As List(Of String),
                                ByRef rest As restaurante)
        If userl.restaurante = constantes.malicia Then
            construirMalicia(factoryPlato, listPlatos, claves, rest)
        Else
            contruirOtroRestaurante(factoryPlato, listPlatos, claves, rest)
        End If
    End Sub

    Public Sub crearIVista(ByRef userL As basicUser, ByRef meVista As IVista, ByRef bpago As Boolean)
        If userL.restaurante = constantes.malicia Then
            meVista = New IVista(userL, bpago, constantes.malicia, Color.Black)
        Else
            meVista = New IVista(userL, bpago, constantes.celex, Color.Red)
        End If
    End Sub

    Public Sub crearVistaEstudiante(ByRef cmbresta As ComboBox, ByRef factoryPlato As creadorDePlatillos,
                                    ByRef listPlatos As List(Of platillos), ByVal claves As List(Of String))
        If cmbresta.SelectedItem = constantes.malicia Then
            construirMaliciaUsuario(factoryPlato, listPlatos, claves)
        Else
            construirOtroRestauranteUsuario(factoryPlato, listPlatos, claves)
        End If
    End Sub

    Public Sub determinarTipoFormaDePago(ByRef IPago As IFormaDePago2, ByRef bpago As Boolean)
        If TypeName(IPago) = "carnetInteligente" Then
            bpago = True
        Else
            bpago = False
        End If
    End Sub

    Public Sub ocultarLogin(ByRef cmbresta As ComboBox, ByRef Label3 As Label)
        cmbresta.Visible = False
        Label3.Visible = False
    End Sub

    

End Module
