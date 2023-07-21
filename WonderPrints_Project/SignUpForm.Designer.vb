<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtusernameS = New System.Windows.Forms.TextBox()
        Me.txtC_number = New System.Windows.Forms.TextBox()
        Me.txtpassS = New System.Windows.Forms.TextBox()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(72, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Plum
        Me.Label2.Location = New System.Drawing.Point(72, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Plum
        Me.Label3.Location = New System.Drawing.Point(72, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Heebo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Plum
        Me.Label4.Location = New System.Drawing.Point(72, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtname.Location = New System.Drawing.Point(226, 208)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(151, 22)
        Me.txtname.TabIndex = 4
        '
        'txtusernameS
        '
        Me.txtusernameS.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtusernameS.Location = New System.Drawing.Point(226, 257)
        Me.txtusernameS.Name = "txtusernameS"
        Me.txtusernameS.Size = New System.Drawing.Size(151, 22)
        Me.txtusernameS.TabIndex = 5
        '
        'txtC_number
        '
        Me.txtC_number.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtC_number.Location = New System.Drawing.Point(226, 316)
        Me.txtC_number.Name = "txtC_number"
        Me.txtC_number.Size = New System.Drawing.Size(151, 22)
        Me.txtC_number.TabIndex = 6
        '
        'txtpassS
        '
        Me.txtpassS.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtpassS.Location = New System.Drawing.Point(226, 377)
        Me.txtpassS.Name = "txtpassS"
        Me.txtpassS.Size = New System.Drawing.Size(151, 22)
        Me.txtpassS.TabIndex = 7
        '
        'SignUp
        '
        Me.SignUp.BackColor = System.Drawing.Color.Plum
        Me.SignUp.Font = New System.Drawing.Font("Heebo", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SignUp.Location = New System.Drawing.Point(180, 455)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(106, 41)
        Me.SignUp.TabIndex = 8
        Me.SignUp.Text = "Sign Up"
        Me.SignUp.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WonderPrints_Project.My.Resources.Resources.wonderprints_logo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(157, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 131)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(460, 580)
        Me.Controls.Add(Me.SignUp)
        Me.Controls.Add(Me.txtpassS)
        Me.Controls.Add(Me.txtC_number)
        Me.Controls.Add(Me.txtusernameS)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Name = "SignUpForm"
        Me.Text = "Sign Up"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtusernameS As TextBox
    Friend WithEvents txtC_number As TextBox
    Friend WithEvents txtpassS As TextBox
    Friend WithEvents SignUp As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
