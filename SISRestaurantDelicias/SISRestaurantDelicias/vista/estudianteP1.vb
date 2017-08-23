Public Class estudianteP1
    Private user As estudiante
    Private lcat As List(Of categoria)
    Private lplatos As List(Of platillos)

    Public Sub New(ByVal user As basicUser)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
    End Sub

    Private Sub ListBoxCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCategorias.SelectedIndexChanged
        Me.ListBox1.Items.Clear()
        Dim op As Integer
        op = ListBoxCategorias.SelectedIndex
        Dim colTmp As New Collection
        For Each cat As categoria In Me.lcat
            If ListBoxCategorias.SelectedItem = cat.Fullnombre Then
                colTmp = user.mostrarPlatillos(cat)
            End If
        Next
        If ListBoxCategorias.SelectedIndex >= 0 Then
            Me.lplatos = colTmp.Item(1)
            For Each pla As platillos In lplatos
                ListBox1.Items.Add(pla.toString1)
            Next
        Else
            MsgBox("Seleccione una categoria valida")
        End If

        
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim op As Integer
        op = ListBox1.SelectedIndex
        If (op >= 0) And (op < Me.lplatos.Count) Then
            Dim datosMostrar As New mostrarPlato(Me.lplatos.Item(op), Me.user)
            datosMostrar.Show()
        Else
            MsgBox("Plato invalido no selecciono uno existente")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.ListBoxCategorias.Items.Clear()
        Me.user.listarCategoria()
        For Each cat As String In Me.user.diccionarioCategoria
            ListBoxCategorias.Items.Add(cat)
        Next
        lcat = funcionesComunes.listarCategoriasCreadas("dataAccess/categorias.txt")
    End Sub
End Class