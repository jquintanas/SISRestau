﻿Public Class decoratorBebida : Inherits almuerzoEjecutivo



    Private precio As Double = constantes.bebida
    Public Sub New(ByVal pla As IAlmuerzo)
        MyBase.new(pla)
    End Sub

    Public Overrides Sub aumentarPrecio(ByVal precio As Double)
        MyBase.almuerzo.aumentarPrecio(Me.precio + precio)
    End Sub

    Public Overrides Function crearAlmuerzo() As String
        Return MyBase.almuerzo.crearAlmuerzo()
    End Function

    Public Overrides Function getPrecio() As Double
        Return MyBase.almuerzo.getPrecio
    End Function
End Class
