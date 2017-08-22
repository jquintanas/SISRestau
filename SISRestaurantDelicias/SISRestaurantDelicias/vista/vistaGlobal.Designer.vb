<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaGlobal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vistaGlobal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picBoxlogoSis = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pictBoxlogoR = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxlogoSis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBoxlogoR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.picBoxlogoSis)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pictBoxlogoR)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 520)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(257, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(730, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'picBoxlogoSis
        '
        Me.picBoxlogoSis.Image = CType(resources.GetObject("picBoxlogoSis.Image"), System.Drawing.Image)
        Me.picBoxlogoSis.Location = New System.Drawing.Point(10, 10)
        Me.picBoxlogoSis.Name = "picBoxlogoSis"
        Me.picBoxlogoSis.Size = New System.Drawing.Size(189, 203)
        Me.picBoxlogoSis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxlogoSis.TabIndex = 1
        Me.picBoxlogoSis.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'pictBoxlogoR
        '
        Me.pictBoxlogoR.Image = Global.SISRestaurantDelicias.My.Resources.Resources.Chef_2_icon
        Me.pictBoxlogoR.Location = New System.Drawing.Point(10, 313)
        Me.pictBoxlogoR.Name = "pictBoxlogoR"
        Me.pictBoxlogoR.Size = New System.Drawing.Size(189, 192)
        Me.pictBoxlogoR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictBoxlogoR.TabIndex = 0
        Me.pictBoxlogoR.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(205, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 445)
        Me.Panel2.TabIndex = 0
        '
        'vistaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "vistaGlobal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxlogoSis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBoxlogoR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxlogoSis As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pictBoxlogoR As System.Windows.Forms.PictureBox
End Class
