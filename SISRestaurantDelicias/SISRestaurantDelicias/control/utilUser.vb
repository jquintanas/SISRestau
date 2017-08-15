Module utilUser
    Public Function crearUsuarios(ByVal ruta As String) As List(Of basicUser)
        Dim usersL As New List(Of basicUser)
        Dim dicT As New Dictionary(Of String, Collection)
        dicT = lecturaDeArchivo.leerArchivo(ruta)
        Dim i As Integer = 0
        For Each col As Collection In dicT.Values
            usersL.Add(New basicUser(col.Item(1).Item(0), col.Item(1).Item(1), col.Item(1).Item(2),
                                     col.Item(1).Item(3), col.Item(1).Item(4)))

        Next
        Return usersL
    End Function
End Module
