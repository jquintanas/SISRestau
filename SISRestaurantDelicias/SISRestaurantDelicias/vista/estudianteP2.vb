Public Class estudianteP2
    Private user As estudiante
    Private plato As List(Of platillos)
    Public Sub New(ByVal user As basicUser, ByVal listPlatos As List(Of platillos))
        InitializeComponent()
        Me.user = user
        Me.plato = listPlatos
    End Sub
    Private Sub estudianteP2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.ListBox1.Items.Clear()
        For Each plat As platillos In Me.plato
            ListBox1.Items.Add(plat.toString1)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim op As Integer
        op = ListBox1.SelectedIndex
        If (op >= 0) And (op < Me.plato.Count) Then
            Dim datosMostrar As New mostrarPlato(Me.plato.Item(op), Me.user)
            datosMostrar.Show()
        Else
            MsgBox("Plato invalido no selecciono uno existente")
        End If
    End Sub
End Class