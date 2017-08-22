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

End Module
