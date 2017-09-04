<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerUpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerUpdateForm))
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.UpdateGridView = New System.Windows.Forms.DataGridView()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblUpdate = New System.Windows.Forms.Label()
        CType(Me.UpdateGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.ForeColor = System.Drawing.Color.Blue
        Me.BtnClear.Location = New System.Drawing.Point(348, 166)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 31)
        Me.BtnClear.TabIndex = 34
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'UpdateGridView
        '
        Me.UpdateGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UpdateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UpdateGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UpdateGridView.Location = New System.Drawing.Point(12, 244)
        Me.UpdateGridView.Name = "UpdateGridView"
        Me.UpdateGridView.Size = New System.Drawing.Size(412, 150)
        Me.UpdateGridView.TabIndex = 33
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.ForeColor = System.Drawing.Color.Red
        Me.BtnCancel.Location = New System.Drawing.Point(348, 128)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 31)
        Me.BtnCancel.TabIndex = 32
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Green
        Me.BtnUpdate.Location = New System.Drawing.Point(348, 88)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 31)
        Me.BtnUpdate.TabIndex = 31
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'TxtGender
        '
        Me.TxtGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtGender.Location = New System.Drawing.Point(104, 208)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(227, 26)
        Me.TxtGender.TabIndex = 30
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPhone.Location = New System.Drawing.Point(104, 176)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(227, 26)
        Me.TxtPhone.TabIndex = 29
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAddress.Location = New System.Drawing.Point(104, 144)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(227, 26)
        Me.TxtAddress.TabIndex = 28
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(104, 112)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(227, 26)
        Me.TxtName.TabIndex = 27
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(104, 77)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(227, 26)
        Me.TxtPassword.TabIndex = 26
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtID.Location = New System.Drawing.Point(104, 45)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(227, 26)
        Me.TxtID.TabIndex = 25
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.ForeColor = System.Drawing.Color.White
        Me.LblPassword.Location = New System.Drawing.Point(21, 81)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(81, 19)
        Me.LblPassword.TabIndex = 24
        Me.LblPassword.Text = "Password:"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.BackColor = System.Drawing.Color.Transparent
        Me.LblGender.ForeColor = System.Drawing.Color.White
        Me.LblGender.Location = New System.Drawing.Point(37, 211)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(64, 19)
        Me.LblGender.TabIndex = 23
        Me.LblGender.Text = "Gender:"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.ForeColor = System.Drawing.Color.White
        Me.LblPhone.Location = New System.Drawing.Point(43, 179)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(57, 19)
        Me.LblPhone.TabIndex = 22
        Me.LblPhone.Text = "Phone:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.Color.Transparent
        Me.LblAddress.ForeColor = System.Drawing.Color.White
        Me.LblAddress.Location = New System.Drawing.Point(30, 147)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(70, 19)
        Me.LblAddress.TabIndex = 21
        Me.LblAddress.Text = "Address:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(48, 116)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(53, 19)
        Me.LblName.TabIndex = 20
        Me.LblName.Text = "Name:"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.BackColor = System.Drawing.Color.Transparent
        Me.LblID.ForeColor = System.Drawing.Color.White
        Me.LblID.Location = New System.Drawing.Point(72, 48)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(29, 19)
        Me.LblID.TabIndex = 19
        Me.LblID.Text = "ID:"
        '
        'LblUpdate
        '
        Me.LblUpdate.AutoSize = True
        Me.LblUpdate.BackColor = System.Drawing.Color.Transparent
        Me.LblUpdate.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdate.ForeColor = System.Drawing.Color.Red
        Me.LblUpdate.Location = New System.Drawing.Point(152, 9)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(137, 28)
        Me.LblUpdate.TabIndex = 35
        Me.LblUpdate.Text = "Player Update"
        '
        'PlayerUpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 401)
        Me.Controls.Add(Me.LblUpdate)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.UpdateGridView)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnUpdate)
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
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlayerUpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.UpdateGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents UpdateGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtGender As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents LblUpdate As System.Windows.Forms.Label
End Class
