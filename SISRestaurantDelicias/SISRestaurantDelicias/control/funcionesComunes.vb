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

    Public Function crearTarjeta() As tarjetaCreditoAdapter
        Dim id As String = InputBox("Ingrese el numero de la tarjeta")
        Dim cvc As Integer = Convert.ToInt64(InputBox("Ingrese el cvc de su tarjeta"))
        Dim caduca As String = InputBox("Ingrese la fecha de caducidad de su tarjeta")
        Return New tarjetaCreditoAdapter(id, cvc, caduca)
    End Function

    Public Function crearCarnetInteligente(ByVal user As basicUser) As carnetInteligente
        MsgBox("Se le asignara un monto aleatorio de salgo", MsgBoxStyle.Information)
        Randomize()
        Dim saldo As Double = CDbl(Int((10 * Rnd()) + 5))
        Return New carnetInteligente(user.id, saldo)
    End Function

    Public Function seleccionarFormaPago(ByVal user As basicUser) As IFormaDePago2
        Dim mensaje As String = MsgBox("Desea pagar con tarjeta de credito?", MsgBoxStyle.YesNo)
        If mensaje = vbYes Then
            Return crearTarjeta()
        Else
            Return crearCarnetInteligente(user)
        End If
    End Function

    Public Function login(ByVal luser As List(Of basicUser), ByVal user As String, ByVal pas As String) As Collection
        Dim bandera As Boolean = False
        Dim retorno As New Collection
        Dim userL As basicUser
        For Each us As basicUser In luser
            If us.id = user Then
                If us.pasword = pas Then
                    bandera = True
                    userL = us
                Else
                    MsgBox("La contraseña ingresa es invalida", MsgBoxStyle.Critical)
                End If
            End If
        Next
        retorno.Add(userL)
        retorno.Add(bandera)
        Return retorno
    End Function


End Module
