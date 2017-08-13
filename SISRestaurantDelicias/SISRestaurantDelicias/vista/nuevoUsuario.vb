Public Class nuevoUsuario
    Private restau As List(Of restaurante)
    Private listU As List(Of basicUser)
    Private Sub nuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each restaurant As restaurante In restau
            cmbRestau.Items.Add(restaurant.fullNombre)
        Next
        cmbRol.Items.Add(constantes.administradorSis)
        cmbRol.Items.Add(constantes.asistenteR)
        cmbRol.Items.Add(constantes.estudiante)
    End Sub

    Public Sub New(ByVal restaurantes As List(Of restaurante), ByVal users As List(Of basicUser))
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.restau = restaurantes
        Me.listU = users

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtRePass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRePass.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCI.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub cmbRol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRol.SelectedIndexChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub cmbRestau_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRestau.SelectedIndexChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtPass.Text = txtRePass.Text Then
            Dim basicU As New basicUser(txtCI.Text, txtNombre.Text, txtPass.Text, cmbRol.SelectedItem, cmbRestau.SelectedItem)
            Me.listU.Add(basicU)
        Else
            MsgBox("Contraseñas no coinciden", MsgBoxStyle.Critical, "SIS Restaurant Delicias")
            txtPass.Select
        End If


    End Sub

    Private Sub btnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseHover
        Dim litBandera As New List(Of Boolean)
        Dim ban As Integer = 0
        litBandera.Add(verificarVacio(cmbRestau.SelectedItem))
        litBandera.Add(verificarVacio(cmbRol.SelectedItem))
        litBandera.Add(verificarVacio(txtCI.Text))
        litBandera.Add(verificarVacio(txtNombre.Text))
        litBandera.Add(verificarVacio(txtPass.Text))
        litBandera.Add(verificarVacio(txtRePass.Text))
        For Each tmp As Boolean In litBandera
            If tmp Then
                btnSave.Enabled = False
                ban = 1
            End If
        Next
        If ban = 1 Then
            MsgBox("Complete todos los campos..", MsgBoxStyle.Critical, "SIS restaurante delicias")
        End If
    End Sub
End Class