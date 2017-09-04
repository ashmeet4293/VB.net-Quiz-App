<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLoginForm))
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PbarLoading = New System.Windows.Forms.ProgressBar()
        Me.PboxPassword = New System.Windows.Forms.PictureBox()
        Me.PboxUsername = New System.Windows.Forms.PictureBox()
        Me.PboxLock = New System.Windows.Forms.PictureBox()
        Me.LblAdmin = New System.Windows.Forms.Label()
        CType(Me.PboxPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.White
        Me.LblUsername.Location = New System.Drawing.Point(41, 42)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(92, 22)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "User Name:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(43, 75)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(80, 22)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password:"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsername.Location = New System.Drawing.Point(136, 41)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(154, 26)
        Me.TxtUsername.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(136, 74)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(154, 26)
        Me.TxtPassword.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogin.Location = New System.Drawing.Point(7, 106)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 30)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Location = New System.Drawing.Point(215, 106)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 30)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'PbarLoading
        '
        Me.PbarLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PbarLoading.Location = New System.Drawing.Point(88, 106)
        Me.PbarLoading.Name = "PbarLoading"
        Me.PbarLoading.Size = New System.Drawing.Size(121, 31)
        Me.PbarLoading.TabIndex = 6
        '
        'PboxPassword
        '
        Me.PboxPassword.BackColor = System.Drawing.Color.Transparent
        Me.PboxPassword.Image = Global.QuizProject.My.Resources.Resources.Lock
        Me.PboxPassword.Location = New System.Drawing.Point(7, 68)
        Me.PboxPassword.Name = "PboxPassword"
        Me.PboxPassword.Size = New System.Drawing.Size(38, 32)
        Me.PboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxPassword.TabIndex = 8
        Me.PboxPassword.TabStop = False
        '
        'PboxUsername
        '
        Me.PboxUsername.BackColor = System.Drawing.Color.Transparent
        Me.PboxUsername.Image = Global.QuizProject.My.Resources.Resources.User
        Me.PboxUsername.Location = New System.Drawing.Point(7, 36)
        Me.PboxUsername.Name = "PboxUsername"
        Me.PboxUsername.Size = New System.Drawing.Size(38, 32)
        Me.PboxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxUsername.TabIndex = 9
        Me.PboxUsername.TabStop = False
        '
        'PboxLock
        '
        Me.PboxLock.BackColor = System.Drawing.Color.Transparent
        Me.PboxLock.Image = Global.QuizProject.My.Resources.Resources.Key
        Me.PboxLock.Location = New System.Drawing.Point(296, 41)
        Me.PboxLock.Name = "PboxLock"
        Me.PboxLock.Size = New System.Drawing.Size(60, 95)
        Me.PboxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxLock.TabIndex = 10
        Me.PboxLock.TabStop = False
        '
        'LblAdmin
        '
        Me.LblAdmin.AutoSize = True
        Me.LblAdmin.BackColor = System.Drawing.Color.Transparent
        Me.LblAdmin.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmin.ForeColor = System.Drawing.Color.Red
        Me.LblAdmin.Location = New System.Drawing.Point(131, 9)
        Me.LblAdmin.Name = "LblAdmin"
        Me.LblAdmin.Size = New System.Drawing.Size(110, 25)
        Me.LblAdmin.TabIndex = 11
        Me.LblAdmin.Text = "Admin Login"
        '
        'AdminLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(362, 145)
        Me.Controls.Add(Me.LblAdmin)
        Me.Controls.Add(Me.PboxLock)
        Me.Controls.Add(Me.PboxUsername)
        Me.Controls.Add(Me.PboxPassword)
        Me.Controls.Add(Me.PbarLoading)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PboxPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents PbarLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents PboxPassword As System.Windows.Forms.PictureBox
    Friend WithEvents PboxUsername As System.Windows.Forms.PictureBox
    Friend WithEvents PboxLock As System.Windows.Forms.PictureBox
    Friend WithEvents LblAdmin As System.Windows.Forms.Label
End Class
