Public Class IVista
    Private user As basicUser
    Private fPago As Boolean
    Private name_Restaurante As String
    Private colorR As Color

    Public Sub New(ByVal us As basicUser, ByVal pago As Boolean, ByVal name As String, ByVal col As Color)
        Me.user = us
        Me.fPago = pago
        Me.name_Restaurante = name
        Me.colorR = col
    End Sub

    Public ReadOnly Property fullUser()
        Get
            Return Me.user
        End Get
    End Property

    Public ReadOnly Property fullPago()
        Get
            Return Me.fPago
        End Get
    End Property

    Public ReadOnly Property fullNameR()
        Get
            Return Me.name_Restaurante
        End Get
    End Property

    Public ReadOnly Property fullColor()
        Get
            Return Me.colorR
        End Get
    End Property

End Class
