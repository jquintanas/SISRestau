Public Class panelDeVista
    Private user As estudiante
    Private lcat As List(Of categoria)
    Private lplatos As List(Of platillos)
    Private panelve1 As estudianteP1
    Private panelve2 As estudianteP2
    Public Sub New(ByVal user As userLogin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        Me.panelve1 = New estudianteP1(Me.user)
    End Sub
    Private Sub panelDeVista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub PorNombreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorNombreToolStripMenuItem.Click
        Dim busq As String
        busq = InputBox("Ingrese el nombre del plato")
        Dim colt As New Collection
        colt = user.buscarPlatoN(busq)
        If colt.Item(1) = 1 Then
            Me.panelve2 = New estudianteP2(Me.user, colt.Item(2))
            Me.Panel2.Controls.Clear()
            Me.Panel2.Controls.Add(panelve2.Panel1)
        Else
            MsgBox("No Existe ningun plato con este nombre", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub PorDescripciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorDescripciónToolStripMenuItem.Click
        Dim busq As String
        busq = InputBox("Ingrese la descripción del plato")
        Dim colt As New Collection
        colt = user.buscarPlatoD(busq)
        If colt.Item(1) = 1 Then
            Me.panelve2 = New estudianteP2(Me.user, colt.Item(2))
            Me.Panel2.Controls.Clear()
            Me.Panel2.Controls.Add(panelve2.Panel1)
        Else
            MsgBox("No Existe ningun plato con este nombre", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ListarCategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarCategoriasToolStripMenuItem.Click
        Me.Panel2.Controls.Clear()
        Me.Panel2.Controls.Add(panelve1.Panel1)
    End Sub
End Class