<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarPlato
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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checpos = New System.Windows.Forms.CheckBox()
        Me.checkbebida = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkestu = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(18, 21)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(254, 98)
        Me.txtDescripcion.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkestu)
        Me.GroupBox1.Controls.Add(Me.checpos)
        Me.GroupBox1.Controls.Add(Me.checkbebida)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione su orden"
        '
        'checpos
        '
        Me.checpos.AutoSize = True
        Me.checpos.Location = New System.Drawing.Point(17, 77)
        Me.checpos.Name = "checpos"
        Me.checpos.Size = New System.Drawing.Size(56, 17)
        Me.checpos.TabIndex = 1
        Me.checpos.Text = "Postre"
        Me.checpos.UseVisualStyleBackColor = True
        '
        'checkbebida
        '
        Me.checkbebida.AutoSize = True
        Me.checkbebida.Location = New System.Drawing.Point(17, 54)
        Me.checkbebida.Name = "checkbebida"
        Me.checkbebida.Size = New System.Drawing.Size(59, 17)
        Me.checkbebida.TabIndex = 0
        Me.checkbebida.Text = "Bebida"
        Me.checkbebida.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comprar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkestu
        '
        Me.checkestu.AutoSize = True
        Me.checkestu.Location = New System.Drawing.Point(17, 28)
        Me.checkestu.Name = "checkestu"
        Me.checkestu.Size = New System.Drawing.Size(119, 17)
        Me.checkestu.TabIndex = 2
        Me.checkestu.Text = "Almuerzo estudiantil"
        Me.checkestu.UseVisualStyleBackColor = True
        '
        'mostrarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "mostrarPlato"
        Me.Text = "mostrarPlato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checpos As System.Windows.Forms.CheckBox
    Friend WithEvents checkbebida As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents checkestu As System.Windows.Forms.CheckBox
End Class
