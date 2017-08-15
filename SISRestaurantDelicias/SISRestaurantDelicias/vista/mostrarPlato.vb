Public Class mostrarPlato
    Private plato As platillos
    Private user As estudiante
    Private IAlmu As IAlmuerzo

    Public Sub New(ByVal plat As platillos, ByVal user As basicUser)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.plato = plat
        Me.user = user
    End Sub
    Private Sub mostrarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescripcion.Text = Me.plato.toString
        Me.IAlmu = New almuerzoEstudiantil(Me.plato)
        Me.IAlmu.aumentarPrecio(2.0)
        Me.IAlmu.crearAlmuerzo()
        checkestu.Checked = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String
        Dim pas As String
        user = InputBox("Ingrese su usuario")
        pas = InputBox("Ingrese su contraseña")
        If user = Me.user.id And pas = Me.user.pasword Then
            If checkbebida.Checked = True And checpos.Checked = False Then
                Dim m2 As New decoratorBebida(New almuerzoEstudiantil(Me.plato))
                m2.aumentarPrecio(2.0)
                m2.crearAlmuerzo()
                Me.user.carnetInteligente.pagar(m2.getPrecio)
                funcionesComunes.horarioDeRetiro()
                MsgBox("Gracias por su compra")
            ElseIf checkbebida.Checked = True And checpos.Checked = True Then
                Dim m4 As New decoratorBebida(New decoratorPostre(New almuerzoEstudiantil(Me.plato)))
                m4.aumentarPrecio(2.0)
                m4.crearAlmuerzo()

                Me.user.carnetInteligente.pagar(m4.getPrecio)
                funcionesComunes.horarioDeRetiro()
                MsgBox("Gracias por su compra")
            ElseIf checkbebida.Checked = False And checpos.Checked = True Then
                Dim m3 As New decoratorPostre(New almuerzoEstudiantil(Me.plato))
                m3.aumentarPrecio(2.0)
                m3.crearAlmuerzo()

                Me.user.carnetInteligente.pagar(m3.getPrecio)
                funcionesComunes.horarioDeRetiro()
                MsgBox("Gracias por su compra")
            Else
                Dim m1 As New almuerzoEstudiantil(Me.plato)

                m1.aumentarPrecio(2.0)
                m1.crearAlmuerzo()

                Me.user.carnetInteligente.pagar(m1.getPrecio)
                funcionesComunes.horarioDeRetiro()
                MsgBox("Gracias por su compra")
            End If
        Else
            MsgBox("Datos Erronos no se realizo la compra", MsgBoxStyle.Critical)
        End If
        Me.Close()
        
    End Sub
End Class