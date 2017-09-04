<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContestantLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContestantLoginForm))
        Me.PboxLock = New System.Windows.Forms.PictureBox()
        Me.PboxUsername = New System.Windows.Forms.PictureBox()
        Me.PboxPassword = New System.Windows.Forms.PictureBox()
        Me.PbarLoading = New System.Windows.Forms.ProgressBar()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PboxLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboxLock
        '
        Me.PboxLock.BackColor = System.Drawing.Color.Transparent
        Me.PboxLock.Image = Global.QuizProject.My.Resources.Resources.Key
        Me.PboxLock.Location = New System.Drawing.Point(298, 41)
        Me.PboxLock.Name = "PboxLock"
        Me.PboxLock.Size = New System.Drawing.Size(60, 95)
        Me.PboxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxLock.TabIndex = 20
        Me.PboxLock.TabStop = False
        '
        'PboxUsername
        '
        Me.PboxUsername.BackColor = System.Drawing.Color.Transparent
        Me.PboxUsername.Image = Global.QuizProject.My.Resources.Resources.User
        Me.PboxUsername.Location = New System.Drawing.Point(5, 36)
        Me.PboxUsername.Name = "PboxUsername"
        Me.PboxUsername.Size = New System.Drawing.Size(38, 32)
        Me.PboxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxUsername.TabIndex = 19
        Me.PboxUsername.TabStop = False
        '
        'PboxPassword
        '
        Me.PboxPassword.BackColor = System.Drawing.Color.Transparent
        Me.PboxPassword.Image = Global.QuizProject.My.Resources.Resources.Lock
        Me.PboxPassword.Location = New System.Drawing.Point(5, 68)
        Me.PboxPassword.Name = "PboxPassword"
        Me.PboxPassword.Size = New System.Drawing.Size(38, 32)
        Me.PboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxPassword.TabIndex = 18
        Me.PboxPassword.TabStop = False
        '
        'PbarLoading
        '
        Me.PbarLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PbarLoading.Location = New System.Drawing.Point(86, 108)
        Me.PbarLoading.Name = "PbarLoading"
        Me.PbarLoading.Size = New System.Drawing.Size(125, 31)
        Me.PbarLoading.TabIndex = 17
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Location = New System.Drawing.Point(217, 108)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 31)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogin.Location = New System.Drawing.Point(5, 108)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 31)
        Me.BtnLogin.TabIndex = 15
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(134, 74)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(158, 26)
        Me.TxtPassword.TabIndex = 14
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsername.Location = New System.Drawing.Point(134, 41)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(158, 26)
        Me.TxtUsername.TabIndex = 13
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.Blue
        Me.LblPassword.Location = New System.Drawing.Point(41, 75)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(80, 22)
        Me.LblPassword.TabIndex = 12
        Me.LblPassword.Text = "Password:"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.ForeColor = System.Drawing.Color.Blue
        Me.LblUsername.Location = New System.Drawing.Point(39, 42)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(92, 22)
        Me.LblUsername.TabIndex = 11
        Me.LblUsername.Text = "User Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Contestant Login"
        '
        'ContestantLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(366, 149)
        Me.Controls.Add(Me.Label1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContestantLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PboxLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PboxLock As System.Windows.Forms.PictureBox
    Friend WithEvents PboxUsername As System.Windows.Forms.PictureBox
    Friend WithEvents PboxPassword As System.Windows.Forms.PictureBox
    Friend WithEvents PbarLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
