﻿Public Class login
    Private user As List(Of basicUser)
    Private userL As basicUser
    Private factoryPlato As creadorDePlatillos
    Private listPlatos As New List(Of platillos)
    Private IPago As IFormaDePago2
    Private claves As New List(Of String)
    Private rest As restaurante
    Private bpago As Boolean
    Private meVista As IVista

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
                mRefactoring.crearRestaurantes(Me.userL, Me.factoryPlato, Me.listPlatos, Me.claves, Me.rest)
                Me.userL = New Asistente(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol, Me.listPlatos, Me.claves, Me.rest)
                mRefactoring.crearIVista(Me.userL, Me.meVista, Me.bpago)
                mRefactoring.borrarCajasTexto(txtPass, txtuser)
                main.Hide()
                Dim vistaT As New vistaGlobal(Me.meVista)
                vistaT.construirAsistente()
                vistaT.Show()
            Else
                mRefactoring.borrarCajasTexto(txtPass, txtuser)
                Me.userL = New userAdmin(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol, mRefactoring.construirListaRestaurants, "ninguno",
                                         Me.user, funcionesComunes.listarCategoriasCreadas("dataAccess/categorias.txt"))
                Dim vAdmin = New vistaAsistente(Me.userL)
                Me.Hide()
                vAdmin.Show()
                main.Hide()
            End If
        Else
            MsgBox("El usuario no existe, ingrese datos validos", MsgBoxStyle.Critical)
        End If
        
    End Sub


    Private Sub cmbresta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbresta.SelectedIndexChanged
        mRefactoring.crearVistaEstudiante(cmbresta, Me.factoryPlato, Me.listPlatos, Me.claves)
        Me.IPago = funcionesComunes.seleccionarFormaPago(Me.userL)
        mRefactoring.determinarTipoFormaDePago(Me.IPago, Me.bpago)
        Me.userL = New estudiante(Me.userL.id, Me.userL.nombre, Me.userL.pasword, Me.userL.rol,
                                    Me.listPlatos, claves, Me.IPago)
        mRefactoring.borrarCajasTexto(txtPass, txtuser)
        mRefactoring.ocultarLogin(cmbresta, Label3)
        main.Hide()
        mRefactoring.crearIVistaEstudiante(Me.userL, Me.meVista, Me.bpago, cmbresta)

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