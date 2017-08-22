Public Class main
    Private listU As New List(Of basicUser)
    Private frm1 As login

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.listU = utilUser.crearUsuarios("dataAccess/usuarios.txt")
        Me.frm1 = New login(listU)
        Me.MainPanel.Controls.Add(frm1.Panel1)
    End Sub

End Class