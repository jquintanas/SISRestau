Public Class login
    Private user As List(Of basicUser)
    Private userL As basicUser
    Private factoryPlato As creadorDePlatillos
    Private listPlatos As New List(Of platillos)
    Private IPago As IFormaDePago2
    Private claves As New List(Of String)
    Private rest As restaurante
    Private bpago As Boolean = False

    Public Sub New(ByVal use As List(Of basicUser))
        InitializeComponent()
        Me.user = use
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim bandera As Boolean = False
        For Each us As basicUser In Me.user
            If us.id = txtuser.Text Then
                If us.pasword = txtPass.Text Then
                    bandera = True
                    Me.userL = us
                Else
                    MsgBox("La contraseña ingresa es invalida", MsgBoxStyle.Critical)
                End If
            End If
        Next
        If bandera = True Then
            MsgBox("Bienvenido al sistema de reservas de restaurantes Delicias", MsgBoxStyle.Information)
            If Me.userL.rol = constantes.estudiante Then
               
                If cmbresta.SelectedItem = constantes.malicia Then
                    Me.factoryPlato = New creadorDePlatillos(constantes.malicia)
                    Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    For Each pla As platillos In Me.listPlatos
                        Me.claves.Add(pla.Fullid)
                    Next
                    Dim mensaje As String = MsgBox("Desea pagar con tarjeta de credito?", MsgBoxStyle.YesNo)
                    If mensaje = vbYes Then
                        Me.IPago = New tarjetaCreditoAdapter("12345", 123, "25/2027")

                    Else
                        Me.bpago = True
                        Me.IPago = New carnetInteligente(Me.userL.id, 35.0)

                    End If
                   
                Else
                    Me.factoryPlato = New creadorDePlatillos(constantes.celex)
                    Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    For Each pla As platillos In Me.listPlatos
                        Me.claves.Add(pla.Fullid)
                    Next
                    Dim mensaje As String = MsgBox("Desea pagar con tarjeta de credito?", MsgBoxStyle.YesNo)
                    If mensaje = vbYes Then
                        Me.IPago = New tarjetaCreditoAdapter("12345", 123, "25/2027")
                    Else
                        Me.IPago = New carnetInteligente(Me.userL.id, 35.0)
                    End If
                End If
                Me.userL = New estudiante(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol,
                                            Me.listPlatos, claves, Me.IPago)
                Me.Panel1.Controls.Clear()
                Dim frm1 As New panelDeVista(Me.userL, Me.bpago)
                Me.Panel1.Controls.Add(frm1.Panel1)
            ElseIf Me.userL.rol = constantes.asistenteR Then

                If cmbresta.SelectedItem = constantes.malicia Then
                    Me.factoryPlato = New creadorDePlatillos(constantes.malicia)
                    Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    For Each pla As platillos In Me.listPlatos
                        Me.claves.Add(pla.Fullid)
                    Next
                    Me.rest = New restaurante(constantes.malicia, "Estoy en la fen", 123456, "El dueño", Me.listPlatos)


                Else
                    Me.factoryPlato = New creadorDePlatillos(constantes.celex)
                    Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    For Each pla As platillos In Me.listPlatos
                        Me.claves.Add(pla.Fullid)
                    Next
                    Me.rest = New restaurante(constantes.celex, "Estoy en el celex", 123456, "El dueño", Me.listPlatos)
                End If
                Me.userL = New Asistente(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol, Me.listPlatos, Me.claves, Me.rest)

                Me.Panel1.Controls.Clear()
                Dim frm1 As New panelDeVistaAsistente(Me.userL)
                Me.Panel1.Controls.Add(frm1.Panel1)
            Else
                MsgBox("En construccion")
            End If
        Else
            MsgBox("El usuario no existe, ingrese datos validos", MsgBoxStyle.Critical)
        End If
    End Sub
End Class