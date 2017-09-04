<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSelectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSelectionForm))
        Me.LblUsertype = New System.Windows.Forms.Label()
        Me.CboxUsertype = New System.Windows.Forms.ComboBox()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.PboxUsertype = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.PboxUsertype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsertype
        '
        Me.LblUsertype.AutoSize = True
        Me.LblUsertype.BackColor = System.Drawing.Color.Transparent
        Me.LblUsertype.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsertype.ForeColor = System.Drawing.Color.White
        Me.LblUsertype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblUsertype.Location = New System.Drawing.Point(50, 24)
        Me.LblUsertype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsertype.Name = "LblUsertype"
        Me.LblUsertype.Size = New System.Drawing.Size(103, 25)
        Me.LblUsertype.TabIndex = 0
        Me.LblUsertype.Text = "User Type:"
        '
        'CboxUsertype
        '
        Me.CboxUsertype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboxUsertype.FormattingEnabled = True
        Me.CboxUsertype.Items.AddRange(New Object() {"Admin", "Contestant"})
        Me.CboxUsertype.Location = New System.Drawing.Point(154, 24)
        Me.CboxUsertype.Margin = New System.Windows.Forms.Padding(4)
        Me.CboxUsertype.Name = "CboxUsertype"
        Me.CboxUsertype.Size = New System.Drawing.Size(180, 27)
        Me.CboxUsertype.TabIndex = 1
        '
        'BtnGo
        '
        Me.BtnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGo.Location = New System.Drawing.Point(154, 68)
        Me.BtnGo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(86, 35)
        Me.BtnGo.TabIndex = 2
        Me.BtnGo.Text = "Go >>>"
        Me.BtnGo.UseVisualStyleBackColor = False
        '
        'PboxUsertype
        '
        Me.PboxUsertype.BackColor = System.Drawing.Color.Transparent
        Me.PboxUsertype.Image = Global.QuizProject.My.Resources.Resources.UserType
        Me.PboxUsertype.Location = New System.Drawing.Point(5, 7)
        Me.PboxUsertype.Name = "PboxUsertype"
        Me.PboxUsertype.Size = New System.Drawing.Size(51, 56)
        Me.PboxUsertype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxUsertype.TabIndex = 3
        Me.PboxUsertype.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(248, 68)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(86, 35)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'UserSelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(354, 116)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PboxUsertype)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.CboxUsertype)
        Me.Controls.Add(Me.LblUsertype)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserSelectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PboxUsertype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsertype As System.Windows.Forms.Label
    Friend WithEvents CboxUsertype As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents PboxUsertype As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

End Class
