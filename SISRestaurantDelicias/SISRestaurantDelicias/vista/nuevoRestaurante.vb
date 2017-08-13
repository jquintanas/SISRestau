Public Class nuevoRestaurante
    Private user As userAdmin
    Private asis As Asistente
    Public Sub New(ByVal administrador As userAdmin)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = administrador

    End Sub

    Private Sub nuevoRestaurante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each userT As userLogin In Me.user.listUser
            cmbAsis.Items.Add(userT.id)
        Next
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        For Each us As userLogin In Me.user.listUser
            If us.id = cmbAsis.SelectedItem Then
                Me.asis = us
            End If
        Next
        Dim res As New restaurante(txtNombre.Text, Me.asis, txtDirec.Text, Convert.ToInt64(txtNombre.Text), txtDuen.Text, New List(Of platillos))
        Me.user.restaurantes.Add(res)
    End Sub

    Private Sub btnsave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.MouseHover
        Dim litBandera As New List(Of Boolean)
        Dim ban As Integer = 0
        litBandera.Add(verificarVacio(cmbAsis.SelectedItem))
        litBandera.Add(verificarVacio(txtDirec.Text))
        litBandera.Add(verificarVacio(txtDuen.Text))
        litBandera.Add(verificarVacio(txtNombre.Text))
        litBandera.Add(verificarVacio(txtTele.Text))
        For Each tmp As Boolean In litBandera
            If tmp Then
                btnsave.Enabled = False
                ban = 1
            End If
        Next
        If ban = 1 Then
            MsgBox("Complete todos los campos..", MsgBoxStyle.Critical, "SIS restaurante delicias")
        End If
    End Sub

    Private Sub cmbAsis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAsis.SelectedIndexChanged
        habilitarMouse(btnsave)
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        habilitarMouse(btnsave)
    End Sub

    Private Sub txtDirec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirec.TextChanged
        habilitarMouse(btnsave)
    End Sub

    Private Sub txtTele_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTele.TextChanged
        habilitarMouse(btnsave)
    End Sub

    Private Sub txtDuen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDuen.TextChanged
        habilitarMouse(btnsave)
    End Sub
End Class