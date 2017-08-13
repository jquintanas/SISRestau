Public Class main

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Panel1.Controls.Clear()
        Dim frm1 As New panelDeVista
        frm1.ListBox1.Items.Add("hello")
        frm1.ListBox1.Items.Add("hello1")
        Me.Panel1.Controls.Add(frm1.Panel1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        panelDeVista.Show()

    End Sub
End Class