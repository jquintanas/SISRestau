<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelDeVista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListarCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorDescripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SISCarnetInteligenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDeCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDeDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeSaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaTransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 436)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Location = New System.Drawing.Point(3, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(835, 390)
        Me.Panel2.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarCategoriasToolStripMenuItem, Me.BuscarPlatoToolStripMenuItem, Me.SISCarnetInteligenteToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(839, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListarCategoriasToolStripMenuItem
        '
        Me.ListarCategoriasToolStripMenuItem.Name = "ListarCategoriasToolStripMenuItem"
        Me.ListarCategoriasToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ListarCategoriasToolStripMenuItem.Text = "Listar Categorias"
        '
        'BuscarPlatoToolStripMenuItem
        '
        Me.BuscarPlatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorNombreToolStripMenuItem, Me.PorDescripciónToolStripMenuItem})
        Me.BuscarPlatoToolStripMenuItem.Name = "BuscarPlatoToolStripMenuItem"
        Me.BuscarPlatoToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.BuscarPlatoToolStripMenuItem.Text = "Buscar Plato"
        '
        'PorNombreToolStripMenuItem
        '
        Me.PorNombreToolStripMenuItem.Name = "PorNombreToolStripMenuItem"
        Me.PorNombreToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PorNombreToolStripMenuItem.Text = "Por Nombre"
        '
        'PorDescripciónToolStripMenuItem
        '
        Me.PorDescripciónToolStripMenuItem.Name = "PorDescripciónToolStripMenuItem"
        Me.PorDescripciónToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PorDescripciónToolStripMenuItem.Text = "Por Descripción"
        '
        'SISCarnetInteligenteToolStripMenuItem
        '
        Me.SISCarnetInteligenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotaDeCreditoToolStripMenuItem, Me.NotaDeDebitoToolStripMenuItem, Me.ConsultaDeSaldoToolStripMenuItem, Me.ConsultaTransaccionesToolStripMenuItem})
        Me.SISCarnetInteligenteToolStripMenuItem.Name = "SISCarnetInteligenteToolStripMenuItem"
        Me.SISCarnetInteligenteToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.SISCarnetInteligenteToolStripMenuItem.Text = "SIS carnet Inteligente"
        '
        'NotaDeCreditoToolStripMenuItem
        '
        Me.NotaDeCreditoToolStripMenuItem.Name = "NotaDeCreditoToolStripMenuItem"
        Me.NotaDeCreditoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NotaDeCreditoToolStripMenuItem.Text = "Nota de credito"
        '
        'NotaDeDebitoToolStripMenuItem
        '
        Me.NotaDeDebitoToolStripMenuItem.Name = "NotaDeDebitoToolStripMenuItem"
        Me.NotaDeDebitoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NotaDeDebitoToolStripMenuItem.Text = "Nota de debito"
        '
        'ConsultaDeSaldoToolStripMenuItem
        '
        Me.ConsultaDeSaldoToolStripMenuItem.Name = "ConsultaDeSaldoToolStripMenuItem"
        Me.ConsultaDeSaldoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConsultaDeSaldoToolStripMenuItem.Text = "Consulta De Saldo"
        '
        'ConsultaTransaccionesToolStripMenuItem
        '
        Me.ConsultaTransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.CreditosToolStripMenuItem})
        Me.ConsultaTransaccionesToolStripMenuItem.Name = "ConsultaTransaccionesToolStripMenuItem"
        Me.ConsultaTransaccionesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConsultaTransaccionesToolStripMenuItem.Text = "Consulta transacciones"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ComprasToolStripMenuItem.Text = "compras"
        '
        'CreditosToolStripMenuItem
        '
        Me.CreditosToolStripMenuItem.Name = "CreditosToolStripMenuItem"
        Me.CreditosToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CreditosToolStripMenuItem.Text = "creditos"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'panelDeVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 452)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "panelDeVista"
        Me.Text = "panelDeVista"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ListarCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPlatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorDescripciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SISCarnetInteligenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeCreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeDebitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeSaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaTransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
