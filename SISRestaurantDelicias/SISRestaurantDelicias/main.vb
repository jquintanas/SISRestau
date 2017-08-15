Public Class main
    Private mid As New Dictionary(Of String, Collection)
    Private user As basicUser
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim listU As New List(Of basicUser)
        listU = utilUser.crearUsuarios("dataAccess/usuarios.txt")
        Dim frm1 As New login(listU)
        Me.Panel1.Controls.Add(frm1.Panel1)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim listU As New List(Of basicUser)
        listU = utilUser.crearUsuarios("dataAccess/usuarios.txt")
        Dim frm1 As New login(listU)
        Me.Panel1.Controls.Add(frm1.Panel1)
    End Sub
End Class