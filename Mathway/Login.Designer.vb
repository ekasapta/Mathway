<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFailedLog = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LoginGreen = New System.Windows.Forms.PictureBox()
        Me.LoginBlue = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("PF BeauSans Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(617, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("PF BeauSans Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(594, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ke Mathway"
        '
        'EmailText
        '
        Me.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailText.Font = New System.Drawing.Font("PF BeauSans Pro Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailText.Location = New System.Drawing.Point(545, 193)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(216, 20)
        Me.EmailText.TabIndex = 5
        '
        'PasswordText
        '
        Me.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordText.Font = New System.Drawing.Font("PF BeauSans Pro Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordText.Location = New System.Drawing.Point(545, 261)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordText.Size = New System.Drawing.Size(216, 20)
        Me.PasswordText.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("PF BeauSans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(536, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("PF BeauSans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(536, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email"
        '
        'LabelFailedLog
        '
        Me.LabelFailedLog.BackColor = System.Drawing.Color.Transparent
        Me.LabelFailedLog.Font = New System.Drawing.Font("PF BeauSans Pro Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFailedLog.ForeColor = System.Drawing.Color.Red
        Me.LabelFailedLog.Location = New System.Drawing.Point(538, 133)
        Me.LabelFailedLog.Name = "LabelFailedLog"
        Me.LabelFailedLog.Size = New System.Drawing.Size(228, 32)
        Me.LabelFailedLog.TabIndex = 10
        Me.LabelFailedLog.Text = "Email atau Password yang anda masukan salah."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("PF BeauSans Pro Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(604, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mathway  ©  2018"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("PF BeauSans Pro Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(386, 139)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "I must study politics and war that my sons may have liberty to study mathematics " &
    "and philosophy."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("PF BeauSans Pro Light", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(49, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "- John Adams"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Mathway.My.Resources.Resources.m_design_logo_09A5D82F03_seeklogo_com
        Me.PictureBox2.Location = New System.Drawing.Point(9, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'LoginGreen
        '
        Me.LoginGreen.BackColor = System.Drawing.Color.Transparent
        Me.LoginGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginGreen.Image = Global.Mathway.My.Resources.Resources.button_05
        Me.LoginGreen.Location = New System.Drawing.Point(541, 393)
        Me.LoginGreen.Name = "LoginGreen"
        Me.LoginGreen.Size = New System.Drawing.Size(225, 35)
        Me.LoginGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoginGreen.TabIndex = 2
        Me.LoginGreen.TabStop = False
        '
        'LoginBlue
        '
        Me.LoginBlue.BackColor = System.Drawing.Color.Transparent
        Me.LoginBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBlue.Image = Global.Mathway.My.Resources.Resources.button_04
        Me.LoginBlue.Location = New System.Drawing.Point(541, 304)
        Me.LoginBlue.Name = "LoginBlue"
        Me.LoginBlue.Size = New System.Drawing.Size(225, 35)
        Me.LoginBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoginBlue.TabIndex = 1
        Me.LoginBlue.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mathway.My.Resources.Resources.login_01
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(826, 540)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("PF BeauSans Pro Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(39, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mathway"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 539)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelFailedLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginGreen)
        Me.Controls.Add(Me.LoginBlue)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginBlue As PictureBox
    Friend WithEvents LoginGreen As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmailText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelFailedLog As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
End Class
