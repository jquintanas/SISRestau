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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBEstu = New System.Windows.Forms.RadioButton()
        Me.rbEje = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.rbEje)
        Me.GroupBox1.Controls.Add(Me.rBEstu)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 83)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Almuerzo"
        '
        'checpos
        '
        Me.checpos.AutoSize = True
        Me.checpos.Location = New System.Drawing.Point(6, 43)
        Me.checpos.Name = "checpos"
        Me.checpos.Size = New System.Drawing.Size(56, 17)
        Me.checpos.TabIndex = 1
        Me.checpos.Text = "Postre"
        Me.checpos.UseVisualStyleBackColor = True
        '
        'checkbebida
        '
        Me.checkbebida.AutoSize = True
        Me.checkbebida.Location = New System.Drawing.Point(6, 20)
        Me.checkbebida.Name = "checkbebida"
        Me.checkbebida.Size = New System.Drawing.Size(59, 17)
        Me.checkbebida.TabIndex = 0
        Me.checkbebida.Text = "Bebida"
        Me.checkbebida.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comprar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkbebida)
        Me.GroupBox2.Controls.Add(Me.checpos)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 86)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adicionales"
        Me.GroupBox2.Visible = False
        '
        'rBEstu
        '
        Me.rBEstu.AutoSize = True
        Me.rBEstu.Location = New System.Drawing.Point(6, 20)
        Me.rBEstu.Name = "rBEstu"
        Me.rBEstu.Size = New System.Drawing.Size(73, 17)
        Me.rBEstu.TabIndex = 0
        Me.rBEstu.TabStop = True
        Me.rBEstu.Text = "Estudiantil"
        Me.rBEstu.UseVisualStyleBackColor = True
        '
        'rbEje
        '
        Me.rbEje.AutoSize = True
        Me.rbEje.Location = New System.Drawing.Point(6, 47)
        Me.rbEje.Name = "rbEje"
        Me.rbEje.Size = New System.Drawing.Size(69, 17)
        Me.rbEje.TabIndex = 1
        Me.rbEje.TabStop = True
        Me.rbEje.Text = "Ejecutivo"
        Me.rbEje.UseVisualStyleBackColor = True
        '
        'mostrarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 278)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "mostrarPlato"
        Me.Text = "mostrarPlato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checpos As System.Windows.Forms.CheckBox
    Friend WithEvents checkbebida As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEje As System.Windows.Forms.RadioButton
    Friend WithEvents rBEstu As System.Windows.Forms.RadioButton
End Class
