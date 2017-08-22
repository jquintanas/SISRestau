<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaAsistente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vistaAsistente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListarPlatillosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarPlatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarRestauranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarPlatillosToolStripMenuItem, Me.ListarCategoriasToolStripMenuItem, Me.AgregarUsuarioToolStripMenuItem, Me.AgregarRestauranteToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListarPlatillosToolStripMenuItem
        '
        Me.ListarPlatillosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListarPlatillosToolStripMenuItem.Name = "ListarPlatillosToolStripMenuItem"
        Me.ListarPlatillosToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ListarPlatillosToolStripMenuItem.Text = "Listar Platillos"
        '
        'ListarCategoriasToolStripMenuItem
        '
        Me.ListarCategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarPlatosToolStripMenuItem, Me.AgregarCategoriaToolStripMenuItem, Me.ModificarCategoriaToolStripMenuItem})
        Me.ListarCategoriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ListarCategoriasToolStripMenuItem.Name = "ListarCategoriasToolStripMenuItem"
        Me.ListarCategoriasToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ListarCategoriasToolStripMenuItem.Text = "Listar Categorias"
        '
        'MostrarPlatosToolStripMenuItem
        '
        Me.MostrarPlatosToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.MostrarPlatosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MostrarPlatosToolStripMenuItem.Name = "MostrarPlatosToolStripMenuItem"
        Me.MostrarPlatosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MostrarPlatosToolStripMenuItem.Text = "Mostrar Platos"
        '
        'AgregarCategoriaToolStripMenuItem
        '
        Me.AgregarCategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.AgregarCategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarCategoriaToolStripMenuItem.Name = "AgregarCategoriaToolStripMenuItem"
        Me.AgregarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarCategoriaToolStripMenuItem.Text = "Agregar Categoria"
        '
        'ModificarCategoriaToolStripMenuItem
        '
        Me.ModificarCategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ModificarCategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ModificarCategoriaToolStripMenuItem.Name = "ModificarCategoriaToolStripMenuItem"
        Me.ModificarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarCategoriaToolStripMenuItem.Text = "Modificar Categoria"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        '
        'AgregarRestauranteToolStripMenuItem
        '
        Me.AgregarRestauranteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarRestauranteToolStripMenuItem.Name = "AgregarRestauranteToolStripMenuItem"
        Me.AgregarRestauranteToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.AgregarRestauranteToolStripMenuItem.Text = "Agregar Restaurante"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SISRestaurantDelicias.My.Resources.Resources.coming_soon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 407)
        Me.Panel1.TabIndex = 1
        '
        'vistaAsistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(750, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "vistaAsistente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ListarPlatillosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarPlatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarRestauranteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
