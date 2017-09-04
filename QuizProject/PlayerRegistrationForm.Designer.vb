<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerRegistrationForm))
        Me.LblRegistration = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RegistrationGridView = New System.Windows.Forms.DataGridView()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.RegistrationGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblRegistration
        '
        Me.LblRegistration.AutoSize = True
        Me.LblRegistration.BackColor = System.Drawing.Color.Transparent
        Me.LblRegistration.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistration.ForeColor = System.Drawing.Color.Red
        Me.LblRegistration.Location = New System.Drawing.Point(140, 9)
        Me.LblRegistration.Name = "LblRegistration"
        Me.LblRegistration.Size = New System.Drawing.Size(177, 28)
        Me.LblRegistration.TabIndex = 0
        Me.LblRegistration.Text = "Player Registration"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.BackColor = System.Drawing.Color.Transparent
        Me.LblID.ForeColor = System.Drawing.Color.White
        Me.LblID.Location = New System.Drawing.Point(72, 43)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(29, 19)
        Me.LblID.TabIndex = 1
        Me.LblID.Text = "ID:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(48, 111)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(53, 19)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.Color.Transparent
        Me.LblAddress.ForeColor = System.Drawing.Color.White
        Me.LblAddress.Location = New System.Drawing.Point(30, 142)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(70, 19)
        Me.LblAddress.TabIndex = 3
        Me.LblAddress.Text = "Address:"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.ForeColor = System.Drawing.Color.White
        Me.LblPhone.Location = New System.Drawing.Point(43, 174)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(57, 19)
        Me.LblPhone.TabIndex = 4
        Me.LblPhone.Text = "Phone:"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.BackColor = System.Drawing.Color.Transparent
        Me.LblGender.ForeColor = System.Drawing.Color.White
        Me.LblGender.Location = New System.Drawing.Point(37, 206)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(64, 19)
        Me.LblGender.TabIndex = 5
        Me.LblGender.Text = "Gender:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.ForeColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(21, 76)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(81, 19)
        Me.LblPassword.TabIndex = 6
        Me.LblPassword.Text = "Password:"
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtID.Location = New System.Drawing.Point(104, 40)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(227, 26)
        Me.TxtID.TabIndex = 7
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(104, 72)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(227, 26)
        Me.TxtPassword.TabIndex = 8
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(104, 107)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(227, 26)
        Me.TxtName.TabIndex = 9
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAddress.Location = New System.Drawing.Point(104, 139)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(227, 26)
        Me.TxtAddress.TabIndex = 10
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPhone.Location = New System.Drawing.Point(104, 171)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(227, 26)
        Me.TxtPhone.TabIndex = 11
        '
        'TxtGender
        '
        Me.TxtGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtGender.Location = New System.Drawing.Point(104, 203)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(227, 26)
        Me.TxtGender.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(348, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(348, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 31)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RegistrationGridView
        '
        Me.RegistrationGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegistrationGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrationGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RegistrationGridView.Location = New System.Drawing.Point(12, 239)
        Me.RegistrationGridView.Name = "RegistrationGridView"
        Me.RegistrationGridView.Size = New System.Drawing.Size(412, 150)
        Me.RegistrationGridView.TabIndex = 17
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.ForeColor = System.Drawing.Color.Blue
        Me.BtnClear.Location = New System.Drawing.Point(348, 161)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 31)
        Me.BtnClear.TabIndex = 18
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'PlayerRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 401)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.RegistrationGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtGender)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblGender)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.LblRegistration)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlayerRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.RegistrationGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblRegistration As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtGender As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RegistrationGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClear As System.Windows.Forms.Button
End Class
