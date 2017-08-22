Public Interface IAlmuerzo
    Function crearAlmuerzo() As String
    Sub aumentarPrecio(ByVal precio As Double)
    Function getPrecio() As Double
End Interface
