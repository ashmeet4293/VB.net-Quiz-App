<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminChangePasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminChangePasswordForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblCurrentPassword = New System.Windows.Forms.Label()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.LblConfirmPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(89, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Location = New System.Drawing.Point(52, 43)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(89, 19)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "User Name:"
        '
        'LblCurrentPassword
        '
        Me.LblCurrentPassword.AutoSize = True
        Me.LblCurrentPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblCurrentPassword.Location = New System.Drawing.Point(2, 72)
        Me.LblCurrentPassword.Name = "LblCurrentPassword"
        Me.LblCurrentPassword.Size = New System.Drawing.Size(139, 19)
        Me.LblCurrentPassword.TabIndex = 2
        Me.LblCurrentPassword.Text = "Current Password:"
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblNewPassword.Location = New System.Drawing.Point(25, 103)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(116, 19)
        Me.LblNewPassword.TabIndex = 3
        Me.LblNewPassword.Text = "New Password:"
        '
        'LblConfirmPassword
        '
        Me.LblConfirmPassword.AutoSize = True
        Me.LblConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblConfirmPassword.Location = New System.Drawing.Point(0, 135)
        Me.LblConfirmPassword.Name = "LblConfirmPassword"
        Me.LblConfirmPassword.Size = New System.Drawing.Size(141, 19)
        Me.LblConfirmPassword.TabIndex = 4
        Me.LblConfirmPassword.Text = "Confirm Password:"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsername.Location = New System.Drawing.Point(144, 39)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(182, 26)
        Me.TxtUsername.TabIndex = 5
        '
        'TxtCurrentPassword
        '
        Me.TxtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCurrentPassword.Location = New System.Drawing.Point(144, 68)
        Me.TxtCurrentPassword.Name = "TxtCurrentPassword"
        Me.TxtCurrentPassword.Size = New System.Drawing.Size(182, 26)
        Me.TxtCurrentPassword.TabIndex = 6
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNewPassword.Location = New System.Drawing.Point(144, 100)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(182, 26)
        Me.TxtNewPassword.TabIndex = 7
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(144, 132)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(182, 26)
        Me.TxtConfirmPassword.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(79, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Okay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(176, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AdminChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 208)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.TxtCurrentPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblConfirmPassword)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.LblCurrentPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents LblNewPassword As System.Windows.Forms.Label
    Friend WithEvents LblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
