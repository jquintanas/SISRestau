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
        Me.ListBoxCategorias = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorDescripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.ListBoxCategorias)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 445)
        Me.Panel1.TabIndex = 0
        '
        'ListBoxCategorias
        '
        Me.ListBoxCategorias.FormattingEnabled = True
        Me.ListBoxCategorias.Location = New System.Drawing.Point(681, 53)
        Me.ListBoxCategorias.Name = "ListBoxCategorias"
        Me.ListBoxCategorias.Size = New System.Drawing.Size(152, 381)
        Me.ListBoxCategorias.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(668, 381)
        Me.ListBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPlatoToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(839, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxCategorias As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BuscarPlatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorDescripciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
