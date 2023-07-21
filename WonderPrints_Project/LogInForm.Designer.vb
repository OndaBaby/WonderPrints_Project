<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogIncmd = New System.Windows.Forms.Button()
        Me.cbshow = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtpass.Location = New System.Drawing.Point(183, 262)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(151, 22)
        Me.txtpass.TabIndex = 11
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtusername.Location = New System.Drawing.Point(183, 221)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(151, 22)
        Me.txtusername.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(67, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(67, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username"
        '
        'LogIncmd
        '
        Me.LogIncmd.BackColor = System.Drawing.Color.MintCream
        Me.LogIncmd.Font = New System.Drawing.Font("Heebo", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIncmd.ForeColor = System.Drawing.Color.Indigo
        Me.LogIncmd.Location = New System.Drawing.Point(72, 316)
        Me.LogIncmd.Name = "LogIncmd"
        Me.LogIncmd.Size = New System.Drawing.Size(84, 39)
        Me.LogIncmd.TabIndex = 12
        Me.LogIncmd.Text = "Log in"
        Me.LogIncmd.UseVisualStyleBackColor = False
        '
        'cbshow
        '
        Me.cbshow.AutoSize = True
        Me.cbshow.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbshow.Location = New System.Drawing.Point(340, 265)
        Me.cbshow.Name = "cbshow"
        Me.cbshow.Size = New System.Drawing.Size(18, 17)
        Me.cbshow.TabIndex = 13
        Me.cbshow.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WonderPrints_Project.My.Resources.Resources.wonderprints_logo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(115, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 171)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(420, 394)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbshow)
        Me.Controls.Add(Me.LogIncmd)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Name = "LogInForm"
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LogIncmd As Button
    Friend WithEvents cbshow As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
