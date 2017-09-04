<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GamingForm))
        Me.LblQuiz = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblUserID = New System.Windows.Forms.Label()
        Me.GboxDetails = New System.Windows.Forms.GroupBox()
        Me.CboxQuestionType = New System.Windows.Forms.ComboBox()
        Me.CboxNumberofQuestions = New System.Windows.Forms.ComboBox()
        Me.LblNumberofQuestions = New System.Windows.Forms.Label()
        Me.LblQuestionType = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.RichTxtQuestion = New System.Windows.Forms.RichTextBox()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.GboxOptions = New System.Windows.Forms.GroupBox()
        Me.RBtnOptionA = New System.Windows.Forms.RadioButton()
        Me.RBtnOptionB = New System.Windows.Forms.RadioButton()
        Me.RBtnOptionC = New System.Windows.Forms.RadioButton()
        Me.RBtnOptionD = New System.Windows.Forms.RadioButton()
        Me.LblCorrectAnswer = New System.Windows.Forms.Label()
        Me.PboxDirection = New System.Windows.Forms.PictureBox()
        Me.TxtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.BtnCheckAnswer = New System.Windows.Forms.Button()
        Me.BtnNextQuestion = New System.Windows.Forms.Button()
        Me.BtnStartGame = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.GboxDetails.SuspendLayout()
        Me.GboxOptions.SuspendLayout()
        CType(Me.PboxDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblQuiz
        '
        Me.LblQuiz.AutoSize = True
        Me.LblQuiz.BackColor = System.Drawing.Color.Transparent
        Me.LblQuiz.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuiz.ForeColor = System.Drawing.Color.Red
        Me.LblQuiz.Location = New System.Drawing.Point(224, 9)
        Me.LblQuiz.Name = "LblQuiz"
        Me.LblQuiz.Size = New System.Drawing.Size(58, 28)
        Me.LblQuiz.TabIndex = 0
        Me.LblQuiz.Text = "Quiz"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.BackColor = System.Drawing.Color.Transparent
        Me.LblUsername.Location = New System.Drawing.Point(197, 60)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(89, 19)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "User Name:"
        '
        'LblUserID
        '
        Me.LblUserID.AutoSize = True
        Me.LblUserID.BackColor = System.Drawing.Color.Transparent
        Me.LblUserID.Location = New System.Drawing.Point(4, 57)
        Me.LblUserID.Name = "LblUserID"
        Me.LblUserID.Size = New System.Drawing.Size(65, 19)
        Me.LblUserID.TabIndex = 2
        Me.LblUserID.Text = "User ID:"
        '
        'GboxDetails
        '
        Me.GboxDetails.BackColor = System.Drawing.Color.Transparent
        Me.GboxDetails.Controls.Add(Me.CboxQuestionType)
        Me.GboxDetails.Controls.Add(Me.CboxNumberofQuestions)
        Me.GboxDetails.Controls.Add(Me.LblNumberofQuestions)
        Me.GboxDetails.Controls.Add(Me.LblQuestionType)
        Me.GboxDetails.Controls.Add(Me.TxtUsername)
        Me.GboxDetails.Controls.Add(Me.TxtUserID)
        Me.GboxDetails.Controls.Add(Me.RichTxtQuestion)
        Me.GboxDetails.Controls.Add(Me.LblQuestion)
        Me.GboxDetails.Controls.Add(Me.LblUserID)
        Me.GboxDetails.Controls.Add(Me.LblUsername)
        Me.GboxDetails.Location = New System.Drawing.Point(12, 40)
        Me.GboxDetails.Name = "GboxDetails"
        Me.GboxDetails.Size = New System.Drawing.Size(484, 170)
        Me.GboxDetails.TabIndex = 3
        Me.GboxDetails.TabStop = False
        '
        'CboxQuestionType
        '
        Me.CboxQuestionType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboxQuestionType.FormattingEnabled = True
        Me.CboxQuestionType.Items.AddRange(New Object() {"Mathematics", "Computer", "Science", "Sports", "Logical"})
        Me.CboxQuestionType.Location = New System.Drawing.Point(343, 19)
        Me.CboxQuestionType.Name = "CboxQuestionType"
        Me.CboxQuestionType.Size = New System.Drawing.Size(132, 27)
        Me.CboxQuestionType.TabIndex = 10
        '
        'CboxNumberofQuestions
        '
        Me.CboxNumberofQuestions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboxNumberofQuestions.FormattingEnabled = True
        Me.CboxNumberofQuestions.Items.AddRange(New Object() {"10", "15", "20", "25", "30"})
        Me.CboxNumberofQuestions.Location = New System.Drawing.Point(163, 19)
        Me.CboxNumberofQuestions.Name = "CboxNumberofQuestions"
        Me.CboxNumberofQuestions.Size = New System.Drawing.Size(61, 27)
        Me.CboxNumberofQuestions.TabIndex = 9
        '
        'LblNumberofQuestions
        '
        Me.LblNumberofQuestions.AutoSize = True
        Me.LblNumberofQuestions.BackColor = System.Drawing.Color.Transparent
        Me.LblNumberofQuestions.Location = New System.Drawing.Point(4, 22)
        Me.LblNumberofQuestions.Name = "LblNumberofQuestions"
        Me.LblNumberofQuestions.Size = New System.Drawing.Size(160, 19)
        Me.LblNumberofQuestions.TabIndex = 8
        Me.LblNumberofQuestions.Text = "Number of Questions:"
        '
        'LblQuestionType
        '
        Me.LblQuestionType.AutoSize = True
        Me.LblQuestionType.BackColor = System.Drawing.Color.Transparent
        Me.LblQuestionType.Location = New System.Drawing.Point(230, 22)
        Me.LblQuestionType.Name = "LblQuestionType"
        Me.LblQuestionType.Size = New System.Drawing.Size(112, 19)
        Me.LblQuestionType.TabIndex = 7
        Me.LblQuestionType.Text = "Question Type:"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsername.Location = New System.Drawing.Point(288, 57)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(187, 26)
        Me.TxtUsername.TabIndex = 6
        '
        'TxtUserID
        '
        Me.TxtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserID.Location = New System.Drawing.Point(71, 54)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(114, 26)
        Me.TxtUserID.TabIndex = 5
        '
        'RichTxtQuestion
        '
        Me.RichTxtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTxtQuestion.Location = New System.Drawing.Point(6, 110)
        Me.RichTxtQuestion.Name = "RichTxtQuestion"
        Me.RichTxtQuestion.Size = New System.Drawing.Size(472, 52)
        Me.RichTxtQuestion.TabIndex = 4
        Me.RichTxtQuestion.Text = ""
        '
        'LblQuestion
        '
        Me.LblQuestion.AutoSize = True
        Me.LblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LblQuestion.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.ForeColor = System.Drawing.Color.Blue
        Me.LblQuestion.Location = New System.Drawing.Point(195, 88)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(75, 19)
        Me.LblQuestion.TabIndex = 3
        Me.LblQuestion.Text = "Question"
        '
        'GboxOptions
        '
        Me.GboxOptions.BackColor = System.Drawing.Color.Transparent
        Me.GboxOptions.Controls.Add(Me.RBtnOptionA)
        Me.GboxOptions.Controls.Add(Me.RBtnOptionB)
        Me.GboxOptions.Controls.Add(Me.RBtnOptionC)
        Me.GboxOptions.Controls.Add(Me.RBtnOptionD)
        Me.GboxOptions.Location = New System.Drawing.Point(12, 216)
        Me.GboxOptions.Name = "GboxOptions"
        Me.GboxOptions.Size = New System.Drawing.Size(131, 141)
        Me.GboxOptions.TabIndex = 4
        Me.GboxOptions.TabStop = False
        Me.GboxOptions.Text = "Options"
        '
        'RBtnOptionA
        '
        Me.RBtnOptionA.AutoSize = True
        Me.RBtnOptionA.Location = New System.Drawing.Point(26, 25)
        Me.RBtnOptionA.Name = "RBtnOptionA"
        Me.RBtnOptionA.Size = New System.Drawing.Size(87, 23)
        Me.RBtnOptionA.TabIndex = 5
        Me.RBtnOptionA.TabStop = True
        Me.RBtnOptionA.Text = "Option A"
        Me.RBtnOptionA.UseVisualStyleBackColor = True
        '
        'RBtnOptionB
        '
        Me.RBtnOptionB.AutoSize = True
        Me.RBtnOptionB.Location = New System.Drawing.Point(26, 49)
        Me.RBtnOptionB.Name = "RBtnOptionB"
        Me.RBtnOptionB.Size = New System.Drawing.Size(87, 23)
        Me.RBtnOptionB.TabIndex = 6
        Me.RBtnOptionB.TabStop = True
        Me.RBtnOptionB.Text = "Option B"
        Me.RBtnOptionB.UseVisualStyleBackColor = True
        '
        'RBtnOptionC
        '
        Me.RBtnOptionC.AutoSize = True
        Me.RBtnOptionC.Location = New System.Drawing.Point(26, 78)
        Me.RBtnOptionC.Name = "RBtnOptionC"
        Me.RBtnOptionC.Size = New System.Drawing.Size(86, 23)
        Me.RBtnOptionC.TabIndex = 7
        Me.RBtnOptionC.TabStop = True
        Me.RBtnOptionC.Text = "Option C"
        Me.RBtnOptionC.UseVisualStyleBackColor = True
        '
        'RBtnOptionD
        '
        Me.RBtnOptionD.AutoSize = True
        Me.RBtnOptionD.Location = New System.Drawing.Point(26, 107)
        Me.RBtnOptionD.Name = "RBtnOptionD"
        Me.RBtnOptionD.Size = New System.Drawing.Size(88, 23)
        Me.RBtnOptionD.TabIndex = 8
        Me.RBtnOptionD.TabStop = True
        Me.RBtnOptionD.Text = "Option D"
        Me.RBtnOptionD.UseVisualStyleBackColor = True
        '
        'LblCorrectAnswer
        '
        Me.LblCorrectAnswer.AutoSize = True
        Me.LblCorrectAnswer.BackColor = System.Drawing.Color.Transparent
        Me.LblCorrectAnswer.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorrectAnswer.ForeColor = System.Drawing.Color.Yellow
        Me.LblCorrectAnswer.Location = New System.Drawing.Point(335, 227)
        Me.LblCorrectAnswer.Name = "LblCorrectAnswer"
        Me.LblCorrectAnswer.Size = New System.Drawing.Size(127, 21)
        Me.LblCorrectAnswer.TabIndex = 11
        Me.LblCorrectAnswer.Text = "Correct Answer"
        '
        'PboxDirection
        '
        Me.PboxDirection.BackColor = System.Drawing.Color.Transparent
        Me.PboxDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PboxDirection.Image = Global.QuizProject.My.Resources.Resources.CorrectAnswer
        Me.PboxDirection.Location = New System.Drawing.Point(167, 225)
        Me.PboxDirection.Name = "PboxDirection"
        Me.PboxDirection.Size = New System.Drawing.Size(115, 128)
        Me.PboxDirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxDirection.TabIndex = 6
        Me.PboxDirection.TabStop = False
        '
        'TxtCorrectAnswer
        '
        Me.TxtCorrectAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCorrectAnswer.Location = New System.Drawing.Point(300, 251)
        Me.TxtCorrectAnswer.Name = "TxtCorrectAnswer"
        Me.TxtCorrectAnswer.Size = New System.Drawing.Size(196, 26)
        Me.TxtCorrectAnswer.TabIndex = 7
        Me.TxtCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCheckAnswer
        '
        Me.BtnCheckAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCheckAnswer.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCheckAnswer.Location = New System.Drawing.Point(411, 288)
        Me.BtnCheckAnswer.Name = "BtnCheckAnswer"
        Me.BtnCheckAnswer.Size = New System.Drawing.Size(85, 29)
        Me.BtnCheckAnswer.TabIndex = 5
        Me.BtnCheckAnswer.Text = "Check"
        Me.BtnCheckAnswer.UseVisualStyleBackColor = False
        '
        'BtnNextQuestion
        '
        Me.BtnNextQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNextQuestion.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNextQuestion.ForeColor = System.Drawing.Color.Blue
        Me.BtnNextQuestion.Location = New System.Drawing.Point(412, 324)
        Me.BtnNextQuestion.Name = "BtnNextQuestion"
        Me.BtnNextQuestion.Size = New System.Drawing.Size(84, 29)
        Me.BtnNextQuestion.TabIndex = 12
        Me.BtnNextQuestion.Text = "Next >>"
        Me.BtnNextQuestion.UseVisualStyleBackColor = False
        '
        'BtnStartGame
        '
        Me.BtnStartGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnStartGame.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartGame.ForeColor = System.Drawing.Color.Green
        Me.BtnStartGame.Location = New System.Drawing.Point(300, 289)
        Me.BtnStartGame.Name = "BtnStartGame"
        Me.BtnStartGame.Size = New System.Drawing.Size(105, 29)
        Me.BtnStartGame.TabIndex = 13
        Me.BtnStartGame.Text = "Start Game"
        Me.BtnStartGame.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrevious.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrevious.Location = New System.Drawing.Point(300, 324)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(105, 29)
        Me.BtnPrevious.TabIndex = 14
        Me.BtnPrevious.Text = "<< Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'GamingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 365)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnStartGame)
        Me.Controls.Add(Me.LblCorrectAnswer)
        Me.Controls.Add(Me.GboxOptions)
        Me.Controls.Add(Me.TxtCorrectAnswer)
        Me.Controls.Add(Me.BtnNextQuestion)
        Me.Controls.Add(Me.PboxDirection)
        Me.Controls.Add(Me.GboxDetails)
        Me.Controls.Add(Me.LblQuiz)
        Me.Controls.Add(Me.BtnCheckAnswer)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GamingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GboxDetails.ResumeLayout(False)
        Me.GboxDetails.PerformLayout()
        Me.GboxOptions.ResumeLayout(False)
        Me.GboxOptions.PerformLayout()
        CType(Me.PboxDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblQuiz As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblUserID As System.Windows.Forms.Label
    Friend WithEvents GboxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblCorrectAnswer As System.Windows.Forms.Label
    Friend WithEvents CboxQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents CboxNumberofQuestions As System.Windows.Forms.ComboBox
    Friend WithEvents LblNumberofQuestions As System.Windows.Forms.Label
    Friend WithEvents LblQuestionType As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserID As System.Windows.Forms.TextBox
    Friend WithEvents RichTxtQuestion As System.Windows.Forms.RichTextBox
    Friend WithEvents LblQuestion As System.Windows.Forms.Label
    Friend WithEvents GboxOptions As System.Windows.Forms.GroupBox
    Friend WithEvents PboxDirection As System.Windows.Forms.PictureBox
    Friend WithEvents RBtnOptionA As System.Windows.Forms.RadioButton
    Friend WithEvents TxtCorrectAnswer As System.Windows.Forms.TextBox
    Friend WithEvents RBtnOptionB As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnOptionC As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnOptionD As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents BtnNextQuestion As System.Windows.Forms.Button
    Friend WithEvents BtnStartGame As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
End Class
