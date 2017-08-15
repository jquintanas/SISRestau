Module utilPlatillos

    Public Function crearPlatos(ByVal ruta As String) As List(Of platillos)
        'ByVal platos As List(Of List(Of platillos))
        Dim lrest As New List(Of platillos)
        Dim dicT As New Dictionary(Of String, Collection)
        dicT = lecturaDeArchivo.leerArchivo(ruta)
        Dim i As Integer = 0
        For Each col As Collection In dicT.Values
            lrest.Add(New platillos(col.Item(1).Item(0), col.Item(1).Item(1), col.Item(1).Item(2), col.Item(1).Item(3),
                                     col.Item(1).Item(4), col.Item(1).Item(5), col.Item(1).Item(6), col.Item(1).Item(7),
                                     col.Item(1).Item(8)))
        Next
        Return lrest

    End Function

End Module
