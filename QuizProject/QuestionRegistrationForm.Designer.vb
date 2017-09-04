<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuestionRegistrationForm))
        Me.LblQuestionRegistration = New System.Windows.Forms.Label()
        Me.LblQuestionNumber = New System.Windows.Forms.Label()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.GboxQuestion = New System.Windows.Forms.GroupBox()
        Me.CboxQuestionType = New System.Windows.Forms.ComboBox()
        Me.LblQuestionType = New System.Windows.Forms.Label()
        Me.RichTxtQuestion = New System.Windows.Forms.RichTextBox()
        Me.TxtQuestionNumber = New System.Windows.Forms.TextBox()
        Me.GboxOption = New System.Windows.Forms.GroupBox()
        Me.TxtAnswer = New System.Windows.Forms.TextBox()
        Me.TxtOptionD = New System.Windows.Forms.TextBox()
        Me.TxtOptionC = New System.Windows.Forms.TextBox()
        Me.TxtOptionB = New System.Windows.Forms.TextBox()
        Me.TxtOptionA = New System.Windows.Forms.TextBox()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.LblOptionD = New System.Windows.Forms.Label()
        Me.LblOptionC = New System.Windows.Forms.Label()
        Me.LblOptionB = New System.Windows.Forms.Label()
        Me.LblOptionA = New System.Windows.Forms.Label()
        Me.BtnAddQuestion = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GboxQuestion.SuspendLayout()
        Me.GboxOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblQuestionRegistration
        '
        Me.LblQuestionRegistration.AutoSize = True
        Me.LblQuestionRegistration.BackColor = System.Drawing.Color.Transparent
        Me.LblQuestionRegistration.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestionRegistration.ForeColor = System.Drawing.Color.Red
        Me.LblQuestionRegistration.Location = New System.Drawing.Point(116, 8)
        Me.LblQuestionRegistration.Name = "LblQuestionRegistration"
        Me.LblQuestionRegistration.Size = New System.Drawing.Size(199, 28)
        Me.LblQuestionRegistration.TabIndex = 0
        Me.LblQuestionRegistration.Text = "Question Registration"
        '
        'LblQuestionNumber
        '
        Me.LblQuestionNumber.AutoSize = True
        Me.LblQuestionNumber.BackColor = System.Drawing.Color.Transparent
        Me.LblQuestionNumber.ForeColor = System.Drawing.Color.Black
        Me.LblQuestionNumber.Location = New System.Drawing.Point(140, 16)
        Me.LblQuestionNumber.Name = "LblQuestionNumber"
        Me.LblQuestionNumber.Size = New System.Drawing.Size(135, 19)
        Me.LblQuestionNumber.TabIndex = 1
        Me.LblQuestionNumber.Text = "Question Number:"
        '
        'LblQuestion
        '
        Me.LblQuestion.AutoSize = True
        Me.LblQuestion.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.ForeColor = System.Drawing.Color.White
        Me.LblQuestion.Location = New System.Drawing.Point(11, 50)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(79, 19)
        Me.LblQuestion.TabIndex = 2
        Me.LblQuestion.Text = "Question:"
        '
        'GboxQuestion
        '
        Me.GboxQuestion.BackColor = System.Drawing.Color.Transparent
        Me.GboxQuestion.Controls.Add(Me.CboxQuestionType)
        Me.GboxQuestion.Controls.Add(Me.LblQuestionType)
        Me.GboxQuestion.Controls.Add(Me.RichTxtQuestion)
        Me.GboxQuestion.Controls.Add(Me.TxtQuestionNumber)
        Me.GboxQuestion.Controls.Add(Me.LblQuestionNumber)
        Me.GboxQuestion.Controls.Add(Me.LblQuestion)
        Me.GboxQuestion.Location = New System.Drawing.Point(12, 39)
        Me.GboxQuestion.Name = "GboxQuestion"
        Me.GboxQuestion.Size = New System.Drawing.Size(412, 135)
        Me.GboxQuestion.TabIndex = 3
        Me.GboxQuestion.TabStop = False
        Me.GboxQuestion.Text = "Question Details"
        '
        'CboxQuestionType
        '
        Me.CboxQuestionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboxQuestionType.FormattingEnabled = True
        Me.CboxQuestionType.Items.AddRange(New Object() {"Mathematics", "Computer", "Science", "Sports", "Logical"})
        Me.CboxQuestionType.Location = New System.Drawing.Point(277, 42)
        Me.CboxQuestionType.Name = "CboxQuestionType"
        Me.CboxQuestionType.Size = New System.Drawing.Size(128, 27)
        Me.CboxQuestionType.TabIndex = 6
        '
        'LblQuestionType
        '
        Me.LblQuestionType.AutoSize = True
        Me.LblQuestionType.Location = New System.Drawing.Point(163, 46)
        Me.LblQuestionType.Name = "LblQuestionType"
        Me.LblQuestionType.Size = New System.Drawing.Size(112, 19)
        Me.LblQuestionType.TabIndex = 5
        Me.LblQuestionType.Text = "Question Type:"
        '
        'RichTxtQuestion
        '
        Me.RichTxtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTxtQuestion.Location = New System.Drawing.Point(10, 72)
        Me.RichTxtQuestion.Name = "RichTxtQuestion"
        Me.RichTxtQuestion.Size = New System.Drawing.Size(396, 51)
        Me.RichTxtQuestion.TabIndex = 4
        Me.RichTxtQuestion.Text = ""
        '
        'TxtQuestionNumber
        '
        Me.TxtQuestionNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQuestionNumber.Location = New System.Drawing.Point(277, 13)
        Me.TxtQuestionNumber.Name = "TxtQuestionNumber"
        Me.TxtQuestionNumber.Size = New System.Drawing.Size(67, 26)
        Me.TxtQuestionNumber.TabIndex = 3
        '
        'GboxOption
        '
        Me.GboxOption.BackColor = System.Drawing.Color.Transparent
        Me.GboxOption.Controls.Add(Me.TxtAnswer)
        Me.GboxOption.Controls.Add(Me.TxtOptionD)
        Me.GboxOption.Controls.Add(Me.TxtOptionC)
        Me.GboxOption.Controls.Add(Me.TxtOptionB)
        Me.GboxOption.Controls.Add(Me.TxtOptionA)
        Me.GboxOption.Controls.Add(Me.LblAnswer)
        Me.GboxOption.Controls.Add(Me.LblOptionD)
        Me.GboxOption.Controls.Add(Me.LblOptionC)
        Me.GboxOption.Controls.Add(Me.LblOptionB)
        Me.GboxOption.Controls.Add(Me.LblOptionA)
        Me.GboxOption.Location = New System.Drawing.Point(12, 180)
        Me.GboxOption.Name = "GboxOption"
        Me.GboxOption.Size = New System.Drawing.Size(412, 121)
        Me.GboxOption.TabIndex = 4
        Me.GboxOption.TabStop = False
        Me.GboxOption.Text = "Options"
        '
        'TxtAnswer
        '
        Me.TxtAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAnswer.Location = New System.Drawing.Point(160, 87)
        Me.TxtAnswer.Name = "TxtAnswer"
        Me.TxtAnswer.Size = New System.Drawing.Size(171, 26)
        Me.TxtAnswer.TabIndex = 9
        '
        'TxtOptionD
        '
        Me.TxtOptionD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOptionD.Location = New System.Drawing.Point(236, 55)
        Me.TxtOptionD.Name = "TxtOptionD"
        Me.TxtOptionD.Size = New System.Drawing.Size(171, 26)
        Me.TxtOptionD.TabIndex = 8
        '
        'TxtOptionC
        '
        Me.TxtOptionC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOptionC.Location = New System.Drawing.Point(34, 55)
        Me.TxtOptionC.Name = "TxtOptionC"
        Me.TxtOptionC.Size = New System.Drawing.Size(171, 26)
        Me.TxtOptionC.TabIndex = 7
        '
        'TxtOptionB
        '
        Me.TxtOptionB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOptionB.Location = New System.Drawing.Point(235, 19)
        Me.TxtOptionB.Name = "TxtOptionB"
        Me.TxtOptionB.Size = New System.Drawing.Size(171, 26)
        Me.TxtOptionB.TabIndex = 6
        '
        'TxtOptionA
        '
        Me.TxtOptionA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOptionA.Location = New System.Drawing.Point(34, 19)
        Me.TxtOptionA.Name = "TxtOptionA"
        Me.TxtOptionA.Size = New System.Drawing.Size(171, 26)
        Me.TxtOptionA.TabIndex = 5
        '
        'LblAnswer
        '
        Me.LblAnswer.AutoSize = True
        Me.LblAnswer.Location = New System.Drawing.Point(91, 90)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(66, 19)
        Me.LblAnswer.TabIndex = 4
        Me.LblAnswer.Text = "Answer:"
        '
        'LblOptionD
        '
        Me.LblOptionD.AutoSize = True
        Me.LblOptionD.Location = New System.Drawing.Point(211, 62)
        Me.LblOptionD.Name = "LblOptionD"
        Me.LblOptionD.Size = New System.Drawing.Size(23, 19)
        Me.LblOptionD.TabIndex = 3
        Me.LblOptionD.Text = "D."
        '
        'LblOptionC
        '
        Me.LblOptionC.AutoSize = True
        Me.LblOptionC.Location = New System.Drawing.Point(11, 62)
        Me.LblOptionC.Name = "LblOptionC"
        Me.LblOptionC.Size = New System.Drawing.Size(21, 19)
        Me.LblOptionC.TabIndex = 2
        Me.LblOptionC.Text = "C."
        '
        'LblOptionB
        '
        Me.LblOptionB.AutoSize = True
        Me.LblOptionB.Location = New System.Drawing.Point(212, 22)
        Me.LblOptionB.Name = "LblOptionB"
        Me.LblOptionB.Size = New System.Drawing.Size(22, 19)
        Me.LblOptionB.TabIndex = 1
        Me.LblOptionB.Text = "B."
        '
        'LblOptionA
        '
        Me.LblOptionA.AutoSize = True
        Me.LblOptionA.Location = New System.Drawing.Point(11, 22)
        Me.LblOptionA.Name = "LblOptionA"
        Me.LblOptionA.Size = New System.Drawing.Size(22, 19)
        Me.LblOptionA.TabIndex = 0
        Me.LblOptionA.Text = "A."
        '
        'BtnAddQuestion
        '
        Me.BtnAddQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAddQuestion.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddQuestion.ForeColor = System.Drawing.Color.Green
        Me.BtnAddQuestion.Location = New System.Drawing.Point(145, 310)
        Me.BtnAddQuestion.Name = "BtnAddQuestion"
        Me.BtnAddQuestion.Size = New System.Drawing.Size(82, 30)
        Me.BtnAddQuestion.TabIndex = 5
        Me.BtnAddQuestion.Text = "Add"
        Me.BtnAddQuestion.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(243, 310)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(82, 30)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'QuestionRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 349)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAddQuestion)
        Me.Controls.Add(Me.GboxOption)
        Me.Controls.Add(Me.GboxQuestion)
        Me.Controls.Add(Me.LblQuestionRegistration)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "QuestionRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GboxQuestion.ResumeLayout(False)
        Me.GboxQuestion.PerformLayout()
        Me.GboxOption.ResumeLayout(False)
        Me.GboxOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblQuestionRegistration As System.Windows.Forms.Label
    Friend WithEvents LblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents LblQuestion As System.Windows.Forms.Label
    Friend WithEvents GboxQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents RichTxtQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtQuestionNumber As System.Windows.Forms.TextBox
    Friend WithEvents GboxOption As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents TxtOptionD As System.Windows.Forms.TextBox
    Friend WithEvents TxtOptionC As System.Windows.Forms.TextBox
    Friend WithEvents TxtOptionB As System.Windows.Forms.TextBox
    Friend WithEvents TxtOptionA As System.Windows.Forms.TextBox
    Friend WithEvents LblAnswer As System.Windows.Forms.Label
    Friend WithEvents LblOptionD As System.Windows.Forms.Label
    Friend WithEvents LblOptionC As System.Windows.Forms.Label
    Friend WithEvents LblOptionB As System.Windows.Forms.Label
    Friend WithEvents LblOptionA As System.Windows.Forms.Label
    Friend WithEvents BtnAddQuestion As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CboxQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents LblQuestionType As System.Windows.Forms.Label
End Class
