Public Class mostrarPlato
    Private plato As platillos
    Private user As estudiante
    Private IAlmu As IAlmuerzo
    Private precio As Double

    Public Sub New(ByVal plat As platillos, ByVal user As basicUser)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.plato = plat
        Me.user = user
    End Sub
    Private Sub mostrarPlato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDescripcion.Text = Me.plato.toString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String
        Dim pas As String
        Dim bMsg As Boolean
        user = InputBox("Ingrese su usuario")
        pas = InputBox("Ingrese su contraseña")
        If user = Me.user.id And pas = Me.user.pasword Then
            If checkbebida.Checked = True And checpos.Checked = False Then
                Dim m2 As New decoratorBebida(New almuerzoEstudiantil(Me.plato))
                m2.aumentarPrecio(Me.precio)
                m2.crearAlmuerzo()
                bMsg = Me.user.carnetInteligente.pagar(m2.getPrecio)
                funcionesComunes.mostrarMensaje(bMsg)
            ElseIf checkbebida.Checked = True And checpos.Checked = True Then
                Dim m4 As New decoratorBebida(New decoratorPostre(New almuerzoEstudiantil(Me.plato)))
                m4.aumentarPrecio(Me.precio)
                m4.crearAlmuerzo()
                bMsg = Me.user.carnetInteligente.pagar(m4.getPrecio)
                funcionesComunes.mostrarMensaje(bMsg)
            ElseIf checkbebida.Checked = False And checpos.Checked = True Then
                Dim m3 As New decoratorPostre(New almuerzoEstudiantil(Me.plato))
                m3.aumentarPrecio(Me.precio)
                m3.crearAlmuerzo()
                bMsg = Me.user.carnetInteligente.pagar(m3.getPrecio)
                funcionesComunes.mostrarMensaje(bMsg)
            Else
                Dim m1 As New almuerzoEstudiantil(Me.plato)
                m1.aumentarPrecio(Me.precio)
                m1.crearAlmuerzo()
                bMsg = Me.user.carnetInteligente.pagar(m1.getPrecio)
                funcionesComunes.mostrarMensaje(bMsg)
            End If
        Else
            MsgBox("Datos Erronos no se realizo la compra", MsgBoxStyle.Critical)
        End If
        Me.Close()
        
    End Sub

   
    Private Sub rbEje_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEje.CheckedChanged
        GroupBox2.Visible = True
        Me.IAlmu = New almuerzoEstudiantil(Me.plato)
        Me.IAlmu.aumentarPrecio(constantes.ejecutivo)
        Me.IAlmu.crearAlmuerzo()
        Me.precio = constantes.ejecutivo


    End Sub

    Private Sub rBEstu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBEstu.CheckedChanged
        GroupBox2.Visible = False
        Me.IAlmu = New almuerzoEstudiantil(Me.plato)
        Me.IAlmu.aumentarPrecio(constantes.estudiantil)
        Me.IAlmu.crearAlmuerzo()
        Me.precio = constantes.estudiantil
    End Sub
End Class