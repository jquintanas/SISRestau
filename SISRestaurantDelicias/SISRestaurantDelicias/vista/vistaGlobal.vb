Public Class vistaGlobal
    Private vista As IVista

    Public Sub New(ByVal vista As IVista)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.vista = vista
    End Sub

    Public Sub construir()
        Panel1.BackColor = Me.vista.fullColor
        Label1.Text = Me.vista.fullNameR
        Me.Panel2.Controls.Clear()
        Dim frm1 As New panelDeVista(Me.vista.fullUser, Me.vista.fullPago)
        Me.Panel2.Controls.Add(frm1.Panel1)
    End Sub
End Class