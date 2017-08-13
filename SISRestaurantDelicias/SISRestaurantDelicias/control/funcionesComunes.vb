Module funcionesComunes
    Public Function verificarVacio(ByVal texto As String) As Boolean
        If texto = "" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub habilitarMouse(ByVal btnSave As Button)
        btnSave.Enabled = True
    End Sub

    Public Function listarCategoriasCreadas(ByVal ruta As String) As List(Of categoria)
        Dim dicT As New Dictionary(Of String, Collection)
        Dim listC As New List(Of categoria)
        dicT = lecturaDeArchivo.leerArchivo(ruta)
        For Each col As Collection In dicT.Values
            listC.Add(col.Item(1).Item(1))
        Next
        Return listC
    End Function
End Module
