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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBoxCategorias = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.ListBoxCategorias)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 445)
        Me.Panel1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"12345"})
        Me.ListBox1.Location = New System.Drawing.Point(7, 8)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 134)
        Me.ListBox1.TabIndex = 0
        '
        'ListBoxCategorias
        '
        Me.ListBoxCategorias.FormattingEnabled = True
        Me.ListBoxCategorias.Location = New System.Drawing.Point(232, 8)
        Me.ListBoxCategorias.Name = "ListBoxCategorias"
        Me.ListBoxCategorias.Size = New System.Drawing.Size(152, 134)
        Me.ListBoxCategorias.TabIndex = 1
        '
        'panelDeVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "panelDeVista"
        Me.Text = "panelDeVista"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxCategorias As System.Windows.Forms.ListBox
End Class
