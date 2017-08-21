<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.cmbresta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmbresta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 445)
        Me.Panel1.TabIndex = 0
        '
        'cmbresta
        '
        Me.cmbresta.FormattingEnabled = True
        Me.cmbresta.Items.AddRange(New Object() {"Nueva Malisia", "Comerdor Celex"})
        Me.cmbresta.Location = New System.Drawing.Point(298, 307)
        Me.cmbresta.Name = "cmbresta"
        Me.cmbresta.Size = New System.Drawing.Size(222, 21)
        Me.cmbresta.TabIndex = 6
        Me.cmbresta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(190, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Restaurante"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(196, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(298, 274)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(222, 20)
        Me.txtPass.TabIndex = 2
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(298, 237)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(222, 20)
        Me.txtuser.TabIndex = 2
        Me.txtuser.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(221, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SISRestaurantDelicias.My.Resources.Resources.btnexit
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(409, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BackgroundImage = Global.SISRestaurantDelicias.My.Resources.Resources.btnlogin
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Location = New System.Drawing.Point(288, 349)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(100, 45)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISRestaurantDelicias.My.Resources.Resources.userLogo
        Me.PictureBox1.Location = New System.Drawing.Point(298, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 455)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbresta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
