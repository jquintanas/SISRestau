Public Class panelDeVista
    Private user As estudiante
    Private lcat As List(Of categoria)
    Private lplatos As List(Of platillos)
    Public Sub New(ByVal user As userLogin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
    End Sub
    Private Sub panelDeVista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.user.listarCategoria()
        MsgBox("hola")
        For Each cat As String In Me.user.diccionarioCategoria
            ListBoxCategorias.Items.Add(cat)
        Next
        lcat = funcionesComunes.listarCategoriasCreadas("dataAccess/categorias.txt")
    End Sub

    Private Sub PorNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorNombreToolStripMenuItem.Click
        Dim busq As String
        busq = InputBox("Ingrese el nombre del plato")
        Dim colt As New Collection
        colt = user.buscarPlatoN(busq)
        If colt.Item(1) = 1 Then
            For Each pla As platillos In colt.Item(2)
                ListBox1.Items.Add(pla.toString1)
            Next
        Else
            MsgBox("No Existe ningun plato con este nombre", MsgBoxStyle.Information)
        End If

    End Sub


    Private Sub ListBoxCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCategorias.SelectedIndexChanged
        Dim colTmp As New Collection
        For Each cat As categoria In Me.lcat
            If ListBoxCategorias.SelectedItem = cat.Fullnombre Then
                colTmp = user.mostrarPlatillos(cat)
            End If
        Next
        Me.lplatos = colTmp.Item(1)
        For Each pla As platillos In lplatos
            ListBox1.Items.Add(pla.toString1)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim op As Integer
        op = ListBox1.SelectedIndex
        Dim datosMostrar As New mostrarPlato(Me.lplatos.Item(op))
        datosMostrar.Show()

    End Sub

    Private Sub PorDescripciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorDescripciónToolStripMenuItem.Click
        Dim busq As String
        busq = InputBox("Ingrese la descripción del plato")
        Dim colt As New Collection
        colt = user.buscarPlatoD(busq)
        If colt.Item(1) = 1 Then
            For Each pla As platillos In colt.Item(2)
                ListBox1.Items.Add(pla.toString1)
            Next
        Else
            MsgBox("No Existe ningun plato con este nombre", MsgBoxStyle.Information)
        End If
    End Sub


    
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.user.listarCategoria()
        For Each cat As String In Me.user.diccionarioCategoria
            ListBoxCategorias.Items.Add(cat)
        Next
        lcat = funcionesComunes.listarCategoriasCreadas("dataAccess/categorias.txt")
    End Sub
End Class