Public Class vbUnitTest
    Private platilloTest As platillos
    Private valorEsperado As Double
    Private valorObtenido As Double
    Private respuesta As Boolean

    Private Sub vbUnitTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.platilloTest = New platillos("1", "platillo test name", "categoria test", "ingredientes test 1 2 3 4....", "imagenes test 1 2 3...", "descripcion test ", "tipo test", "servido test", "restaurante test")
    End Sub

    Private Sub btnTestEstudiantil_Click(sender As Object, e As EventArgs) Handles btnTestEstudiantil.Click
        Dim m1 As New almuerzoEstudiantil(Me.platilloTest)
        vbUnitAlmuerzo.realizarVBUnitTest(m1, Me.valorObtenido, Me.valorEsperado, txtVEsperadoEstudiantil, txtVObtenidoEstudiantil,
txtRespuestaEstudiantil, Me.respuesta, constantes.estudiantil)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m3 As New almuerzoEstudiantil(Me.platilloTest)
        vbUnitAlmuerzo.realizarVBUnitTest(m3, Me.valorObtenido, Me.valorEsperado, txtVEsperadoEjecutivo, txtVObtenidoEjecutivo, txtRespuestaEjecutivo,
                                          Me.respuesta, constantes.ejecutivo)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m2 As New decoratorBebida(New almuerzoEstudiantil(Me.platilloTest))
        vbUnitAlmuerzo.realizarVBUnitTest(m2, Me.valorObtenido, Me.valorEsperado, txtVEEBebida, txtVOEBebida,
                                          txtVOETestBebida, Me.respuesta, constantes.ejecutivo)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim m4 As New decoratorPostre(New almuerzoEstudiantil(Me.platilloTest))
        vbUnitAlmuerzo.realizarVBUnitTest(m4, Me.valorObtenido, Me.valorEsperado, txtVEEPostre, txtVOEPostre,
                                          txtVOETestPostre, Me.respuesta, constantes.ejecutivo)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim m5 As New decoratorPostre(New decoratorBebida(New almuerzoEstudiantil(Me.platilloTest)))
        vbUnitAlmuerzo.realizarVBUnitTest(m5, Me.valorObtenido, Me.valorEsperado, txtVEEAmbos, txtVOEAmbos,
                                          txtVOETestAmbos, Me.respuesta, constantes.ejecutivo)
    End Sub
End Class