Public Class nuevoPlatillo
    Private usuario As Asistente
    Private Sub nuevoPlatillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tmp As New Dictionary(Of String, Collection)
        tmp = lecturaDeArchivo.leerArchivo("dataAccess/categorias.txt")
        For Each col As Collection In tmp.Values
            cmbCate.Items.Add(col.Item(1).Item(1))
        Next
    End Sub

    Public Sub New(ByVal user As Asistente)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.usuario = user

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim platillo As New platillos(txtKey.Text, txtnombre.Text, cmbCate.SelectedItem, txtingredientes.Text, txtimagenes.Text,
                                      txtdescrip.Text, cmbTipo.SelectedItem, cmbServido.SelectedItem, Me.usuario.rest.fullNombre)
        Me.usuario.platillos.Add(platillo)
        MsgBox("Platillo Agregado")
        Me.Close()

    End Sub

    Private Sub btnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseHover
        Dim litBandera As New List(Of Boolean)
        Dim ban As Integer = 0
        litBandera.Add(verificarVacio(cmbCate.SelectedItem))
        litBandera.Add(verificarVacio(cmbServido.SelectedItem))
        litBandera.Add(verificarVacio(cmbTipo.SelectedItem))
        litBandera.Add(verificarVacio(txtdescrip.Text))
        litBandera.Add(verificarVacio(txtimagenes.Text))
        litBandera.Add(verificarVacio(txtingredientes.Text))
        litBandera.Add(verificarVacio(txtnombre.Text))
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

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        habilitarMouse(btnSave)

    End Sub

    Private Sub cmbServido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbServido.SelectedIndexChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub cmbCate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCate.SelectedIndexChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtingredientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtingredientes.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtdescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescrip.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub txtimagenes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtimagenes.TextChanged
        habilitarMouse(btnSave)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
End Class