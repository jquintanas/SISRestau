Public Class main
    Private listU As New List(Of basicUser)
    Private frm1 As login

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim listU As New List(Of basicUser)
        listU = utilUser.crearUsuarios("dataAccess/usuarios.txt")
        Dim frm1 As New login(listU)
        Me.MainPanel.Controls.Add(frm1.Panel1)
    End Sub

End Class