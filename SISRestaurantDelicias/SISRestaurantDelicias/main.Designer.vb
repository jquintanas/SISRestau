<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Location = New System.Drawing.Point(5, 4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(839, 445)
        Me.MainPanel.TabIndex = 0
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SISRestaurantDelicias.My.Resources.Resources.fondo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
End Class
