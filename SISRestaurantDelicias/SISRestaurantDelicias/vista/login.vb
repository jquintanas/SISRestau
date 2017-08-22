Public Class login
    Private user As List(Of basicUser)
    Private userL As basicUser
    Private factoryPlato As creadorDePlatillos
    Private listPlatos As New List(Of platillos)
    Private IPago As IFormaDePago2
    Private claves As New List(Of String)
    Private rest As restaurante
    Private bpago As Boolean

    Public Sub New(ByVal use As List(Of basicUser))
        InitializeComponent()
        Me.user = use
        txtuser.Select()

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim bandera As Boolean = False
        Dim colr As Collection
        colr = funcionesComunes.login(Me.user, txtuser.Text, txtPass.Text)
        bandera = colr.Item(2)
        If bandera = True Then
            Me.userL = colr.Item(1)
            MsgBox("Bienvenido al sistema de reservas de restaurantes Delicias", MsgBoxStyle.Information)
            If Me.userL.rol = constantes.estudiante Then
                cmbresta.Visible = True
                Label3.Visible = True
            ElseIf Me.userL.rol = constantes.asistenteR Then

                If cmbresta.SelectedItem = constantes.malicia Then
                    'Me.factoryPlato = New creadorDePlatillos(constantes.malicia)
                    'Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    'For Each pla As platillos In Me.listPlatos
                    '    Me.claves.Add(pla.Fullid)
                    'Next
                    'Me.rest = New restaurante(constantes.malicia, "Estoy en la fen", 123456, "El dueño", Me.listPlatos)
                    mRefactoring.construirMalicia(Me.factoryPlato, Me.listPlatos, Me.claves, Me.rest)

                Else
                    'Me.factoryPlato = New creadorDePlatillos(constantes.celex)
                    'Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
                    'For Each pla As platillos In Me.listPlatos
                    '    Me.claves.Add(pla.Fullid)
                    'Next
                    'Me.rest = New restaurante(constantes.celex, "Estoy en el celex", 123456, "El dueño", Me.listPlatos)
                    mRefactoring.contruirOtroRestaurante(Me.factoryPlato, Me.listPlatos, Me.claves, Me.rest)
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


    Private Sub cmbresta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbresta.SelectedIndexChanged
        If cmbresta.SelectedItem = constantes.malicia Then
            Me.factoryPlato = New creadorDePlatillos(constantes.malicia)
            Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
            For Each pla As platillos In Me.listPlatos
                Me.claves.Add(pla.Fullid)
            Next
        Else
            Me.factoryPlato = New creadorDePlatillos(constantes.celex)
            Me.listPlatos = Me.factoryPlato.CrearListaRestaurantes()
            For Each pla As platillos In Me.listPlatos
                Me.claves.Add(pla.Fullid)
            Next
        End If
        Me.IPago = funcionesComunes.seleccionarFormaPago(Me.userL)
        If TypeName(Me.IPago) = "carnetInteligente" Then
            Me.bpago = True
        Else
            Me.bpago = False
        End If

        Me.userL = New estudiante(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol,
                                    Me.listPlatos, claves, Me.IPago)
        Me.Panel1.Controls.Clear()
        Dim frm1 As New panelDeVista(Me.userL, Me.bpago)
        Me.Panel1.Controls.Add(frm1.Panel1)
        Dim meVista As New IVista(Me.userL, Me.bpago, "Malicia", Color.Aqua)
        Dim vistaT As New vistaGlobal(meVista)
        vistaT.construir()
        vistaT.Show()
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main.Close()

    End Sub

    

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtPass.Select()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnlogin.Select()
        End If
    End Sub
End Class