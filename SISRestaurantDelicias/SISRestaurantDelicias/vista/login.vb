Public Class login
    Private user As List(Of basicUser)
    Public Sub New(ByVal use As List(Of basicUser))
        InitializeComponent()
        Me.user = use
    End Sub
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        txtuser.Select()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim bandera As Boolean = False
        For Each us As basicUser In Me.user
            If us.nombre = txtuser.Text Then
                If us.pasword = txtPass.Text Then
                    bandera = True
                Else
                    MsgBox("La contraseña ingresa es invalida", MsgBoxStyle.Critical)
                End If
            End If
        Next
        If bandera = True Then
            MsgBox("Bienvenido al sistema de reservas de restaurantes Delicias", MsgBoxStyle.Information)
        Else
            MsgBox("El usuario no existe, ingrese datos validos", MsgBoxStyle.Critical)
        End If
    End Sub
End Class