Module vbUnitAlmuerzo
    Public Function testPrecio(ByVal precioEsperado As Double, ByVal precioObtenido As Double) As Boolean
        If precioEsperado = precioObtenido Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub asignarValores(ByRef txtEsperado As TextBox, ByRef txtObtenido As TextBox, ByRef vEsperado As Double, ByVal vObtenido As Double)
        If IsNumeric(txtEsperado.Text) Then
            vEsperado = Convert.ToDouble(txtEsperado.Text)
            txtObtenido.Text = Convert.ToString(vObtenido)
        Else
            vEsperado = 0
            txtObtenido.Text = Convert.ToString(vObtenido)
        End If
    End Sub

    Public Sub asignarRespuesta(ByRef txtrespuesta As TextBox, ByVal respuesta As Boolean)
        If respuesta Then
            txtrespuesta.Text = "SI"
        Else
            txtrespuesta.Text = "NO"
        End If
    End Sub

    Public Sub realizarVBUnitTest(ByRef almuerzo As IAlmuerzo, ByRef valorObtenido As Double, ByRef valorEsperado As Double,
                                  ByRef text1 As TextBox, ByRef text2 As TextBox, ByRef text3 As TextBox,
                                  ByRef respuesta As Boolean, ByVal valor As Double)

        almuerzo.aumentarPrecio(valor)
        almuerzo.crearAlmuerzo()
        valorObtenido = almuerzo.getPrecio()
        asignarValores(text1, text2, valorEsperado, valorObtenido)
        respuesta = testPrecio(valorEsperado, valorObtenido)
        asignarRespuesta(text3, respuesta)
    End Sub

End Module
