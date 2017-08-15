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
            listC.Add(New categoria(col.Item(1).Item(0), col.Item(1).Item(1)))
        Next
        Return listC
    End Function

    Public Function horarioDeRetiro() As String
        Dim b As Boolean = True
        While b
            Dim op As String = InputBox("seleccione un horario: 1)11:00 - 11:30 2)11:30 - 12:00 3) 12:00 - 12:30 4) 12:30 - 13:00 5) 13:00 - 13:30 6) 13:30 - 14:00 7) 14:00 - 14:30  8)14:30 - 15:00")
            If Convert.ToInt64(op) < 9 And Convert.ToInt64(op) > 0 Then
                Select Case op
                    Case 1
                        Return "11:00 - 11:30"
                    Case 2
                        Return "11:30 - 12:00"
                    Case 3
                        Return "12:00 - 12:30"
                    Case 4
                        Return "12:30 - 13:00"
                    Case 5
                        Return "13:00 - 13:30"
                    Case 6
                        Return "13:30 - 14:00"
                    Case 7
                        Return "14:00 - 14:30"
                    Case 8
                        Return "14:30 - 15:00"
                End Select
                b = False
            End If
        End While
    End Function
End Module
