Public Class carnetInteligente : Implements IFormaDePago2

    Protected Friend id As String
    Private montoDeCuenta As Double
    Private notaDeCredito As Double = 0
    Private listaDeTransacciones As New List(Of transacciones)
    Private listaCompras As New List(Of compras)
    Private orden As String

    Public Sub New(ByVal id As String, ByVal monto As Double)
        Me.id = id
        Me.montoDeCuenta = monto

    End Sub


    Private Sub generarOrden() Implements IFormaDePago2.generarOrden
        Randomize()
        Dim value As Integer = CInt(Int((100 * Rnd()) + 1))
        Me.orden = "Su compra se realizo con exito, el numero de orden es: " + Convert.ToString(value)
        MsgBox("Su compra se realizo con exito, el numero de orden es: " + Convert.ToString(value), MsgBoxStyle.Information)
    End Sub

    Public Function pagar(ByVal monto As Double) As Boolean Implements IFormaDePago2.pagar
        If Me.montoDeCuenta > monto Then
            Me.montoDeCuenta = Me.montoDeCuenta - monto
            generarOrden()
            Me.listaDeTransacciones.Add(New transacciones("Se realiza un debito de la cuenta", New Date))
            Me.listaCompras.Add(New compras(Me.orden, New Date))

        Else
            Dim respuesta As String
            Dim monT As Double = monto - Me.montoDeCuenta
            respuesta = MsgBox("Desea Cargar el monto $" + monT + " a su nota de credito", MsgBoxStyle.YesNo)
            If respuesta = vbYes Then
                Me.montoDeCuenta = 0
                Me.notaDeCredito = monT
                generarOrden()
                Me.listaDeTransacciones.Add(New transacciones("Se realiza un debito de la cuenta", New Date))
                Me.listaDeTransacciones.Add(New transacciones("Se realizo una nota de credito", New Date))
                Me.listaCompras.Add(New compras(Me.orden, New Date))


            End If
        End If
        Return True
    End Function

    Public Property getMontoDeCuenta As Double
        Get
            Return Me.montoDeCuenta
        End Get
        Set(ByVal value As Double)
            Me.montoDeCuenta = Me.montoDeCuenta + value
        End Set
    End Property

    Public Property fullNotaDeCredito As Double
        Get
            Return Me.notaDeCredito
        End Get
        Set(ByVal value As Double)
            Me.notaDeCredito = Me.notaDeCredito + value
        End Set
    End Property

    Public Sub addTransaccion(ByVal transac As transacciones)
        Me.listaDeTransacciones.Add(transac)
    End Sub

    Public ReadOnly Property getCompras()
        Get
            Return Me.listaCompras
        End Get
    End Property
    Public ReadOnly Property getTransacciones()
        Get
            Return Me.listaDeTransacciones
        End Get
    End Property


End Class
