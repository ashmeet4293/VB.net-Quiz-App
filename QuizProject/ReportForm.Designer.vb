<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.LblReportSheet = New System.Windows.Forms.Label()
        Me.LblSelectPlayersID = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblMathematics = New System.Windows.Forms.Label()
        Me.LblScience = New System.Windows.Forms.Label()
        Me.LblLogical = New System.Windows.Forms.Label()
        Me.LblSports = New System.Windows.Forms.Label()
        Me.LblComputer = New System.Windows.Forms.Label()
        Me.GboxPlayerInformation = New System.Windows.Forms.GroupBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.GboxScores = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIQTotal = New System.Windows.Forms.TextBox()
        Me.TxtSportsTotal = New System.Windows.Forms.TextBox()
        Me.TxtScienceTotal = New System.Windows.Forms.TextBox()
        Me.TxtComputerTotal = New System.Windows.Forms.TextBox()
        Me.TxtMathematicsTotal = New System.Windows.Forms.TextBox()
        Me.TxtIQ = New System.Windows.Forms.TextBox()
        Me.TxtSports = New System.Windows.Forms.TextBox()
        Me.TxtScience = New System.Windows.Forms.TextBox()
        Me.TxtComputer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMathematics = New System.Windows.Forms.TextBox()
        Me.CboxPlayerID = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.GboxPlayerInformation.SuspendLayout()
        Me.GboxScores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblReportSheet
        '
        Me.LblReportSheet.AutoSize = True
        Me.LblReportSheet.BackColor = System.Drawing.Color.Transparent
        Me.LblReportSheet.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportSheet.ForeColor = System.Drawing.Color.Red
        Me.LblReportSheet.Location = New System.Drawing.Point(197, 9)
        Me.LblReportSheet.Name = "LblReportSheet"
        Me.LblReportSheet.Size = New System.Drawing.Size(121, 28)
        Me.LblReportSheet.TabIndex = 0
        Me.LblReportSheet.Text = "Report Sheet"
        '
        'LblSelectPlayersID
        '
        Me.LblSelectPlayersID.AutoSize = True
        Me.LblSelectPlayersID.BackColor = System.Drawing.Color.Transparent
        Me.LblSelectPlayersID.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectPlayersID.ForeColor = System.Drawing.Color.White
        Me.LblSelectPlayersID.Location = New System.Drawing.Point(11, 56)
        Me.LblSelectPlayersID.Name = "LblSelectPlayersID"
        Me.LblSelectPlayersID.Size = New System.Drawing.Size(138, 19)
        Me.LblSelectPlayersID.TabIndex = 1
        Me.LblSelectPlayersID.Text = "Select Players' ID:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Location = New System.Drawing.Point(20, 22)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(53, 19)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.Color.Transparent
        Me.LblAddress.Location = New System.Drawing.Point(3, 55)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(70, 19)
        Me.LblAddress.TabIndex = 3
        Me.LblAddress.Text = "Address:"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.BackColor = System.Drawing.Color.Transparent
        Me.LblGender.Location = New System.Drawing.Point(265, 20)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(64, 19)
        Me.LblGender.TabIndex = 4
        Me.LblGender.Text = "Gender:"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Location = New System.Drawing.Point(272, 56)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(57, 19)
        Me.LblPhone.TabIndex = 5
        Me.LblPhone.Text = "Phone:"
        '
        'LblMathematics
        '
        Me.LblMathematics.AutoSize = True
        Me.LblMathematics.BackColor = System.Drawing.Color.Transparent
        Me.LblMathematics.Location = New System.Drawing.Point(18, 22)
        Me.LblMathematics.Name = "LblMathematics"
        Me.LblMathematics.Size = New System.Drawing.Size(100, 19)
        Me.LblMathematics.TabIndex = 7
        Me.LblMathematics.Text = "Mathematics:"
        '
        'LblScience
        '
        Me.LblScience.AutoSize = True
        Me.LblScience.BackColor = System.Drawing.Color.Transparent
        Me.LblScience.Location = New System.Drawing.Point(54, 84)
        Me.LblScience.Name = "LblScience"
        Me.LblScience.Size = New System.Drawing.Size(64, 19)
        Me.LblScience.TabIndex = 8
        Me.LblScience.Text = "Science:"
        '
        'LblLogical
        '
        Me.LblLogical.AutoSize = True
        Me.LblLogical.BackColor = System.Drawing.Color.Transparent
        Me.LblLogical.Location = New System.Drawing.Point(57, 149)
        Me.LblLogical.Name = "LblLogical"
        Me.LblLogical.Size = New System.Drawing.Size(62, 19)
        Me.LblLogical.TabIndex = 9
        Me.LblLogical.Text = "Logical:"
        '
        'LblSports
        '
        Me.LblSports.AutoSize = True
        Me.LblSports.BackColor = System.Drawing.Color.Transparent
        Me.LblSports.Location = New System.Drawing.Point(60, 116)
        Me.LblSports.Name = "LblSports"
        Me.LblSports.Size = New System.Drawing.Size(58, 19)
        Me.LblSports.TabIndex = 10
        Me.LblSports.Text = "Sports:"
        '
        'LblComputer
        '
        Me.LblComputer.AutoSize = True
        Me.LblComputer.BackColor = System.Drawing.Color.Transparent
        Me.LblComputer.Location = New System.Drawing.Point(36, 52)
        Me.LblComputer.Name = "LblComputer"
        Me.LblComputer.Size = New System.Drawing.Size(82, 19)
        Me.LblComputer.TabIndex = 11
        Me.LblComputer.Text = "Computer:"
        '
        'GboxPlayerInformation
        '
        Me.GboxPlayerInformation.BackColor = System.Drawing.Color.Transparent
        Me.GboxPlayerInformation.Controls.Add(Me.TxtPhone)
        Me.GboxPlayerInformation.Controls.Add(Me.TxtGender)
        Me.GboxPlayerInformation.Controls.Add(Me.TxtAddress)
        Me.GboxPlayerInformation.Controls.Add(Me.TxtName)
        Me.GboxPlayerInformation.Controls.Add(Me.LblName)
        Me.GboxPlayerInformation.Controls.Add(Me.LblAddress)
        Me.GboxPlayerInformation.Controls.Add(Me.LblGender)
        Me.GboxPlayerInformation.Controls.Add(Me.LblPhone)
        Me.GboxPlayerInformation.Location = New System.Drawing.Point(16, 92)
        Me.GboxPlayerInformation.Name = "GboxPlayerInformation"
        Me.GboxPlayerInformation.Size = New System.Drawing.Size(487, 85)
        Me.GboxPlayerInformation.TabIndex = 12
        Me.GboxPlayerInformation.TabStop = False
        Me.GboxPlayerInformation.Text = "Player Information"
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPhone.Location = New System.Drawing.Point(328, 54)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(153, 26)
        Me.TxtPhone.TabIndex = 9
        '
        'TxtGender
        '
        Me.TxtGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtGender.Location = New System.Drawing.Point(329, 18)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(152, 26)
        Me.TxtGender.TabIndex = 8
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAddress.Location = New System.Drawing.Point(74, 53)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(192, 26)
        Me.TxtAddress.TabIndex = 7
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(74, 20)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(192, 26)
        Me.TxtName.TabIndex = 6
        '
        'GboxScores
        '
        Me.GboxScores.BackColor = System.Drawing.Color.Transparent
        Me.GboxScores.Controls.Add(Me.PictureBox1)
        Me.GboxScores.Controls.Add(Me.Label5)
        Me.GboxScores.Controls.Add(Me.Label4)
        Me.GboxScores.Controls.Add(Me.Label3)
        Me.GboxScores.Controls.Add(Me.Label2)
        Me.GboxScores.Controls.Add(Me.TxtIQTotal)
        Me.GboxScores.Controls.Add(Me.TxtSportsTotal)
        Me.GboxScores.Controls.Add(Me.TxtScienceTotal)
        Me.GboxScores.Controls.Add(Me.TxtComputerTotal)
        Me.GboxScores.Controls.Add(Me.TxtMathematicsTotal)
        Me.GboxScores.Controls.Add(Me.TxtIQ)
        Me.GboxScores.Controls.Add(Me.TxtSports)
        Me.GboxScores.Controls.Add(Me.TxtScience)
        Me.GboxScores.Controls.Add(Me.TxtComputer)
        Me.GboxScores.Controls.Add(Me.Label1)
        Me.GboxScores.Controls.Add(Me.TxtMathematics)
        Me.GboxScores.Controls.Add(Me.LblMathematics)
        Me.GboxScores.Controls.Add(Me.LblComputer)
        Me.GboxScores.Controls.Add(Me.LblLogical)
        Me.GboxScores.Controls.Add(Me.LblSports)
        Me.GboxScores.Controls.Add(Me.LblScience)
        Me.GboxScores.Location = New System.Drawing.Point(16, 183)
        Me.GboxScores.Name = "GboxScores"
        Me.GboxScores.Size = New System.Drawing.Size(487, 180)
        Me.GboxScores.TabIndex = 6
        Me.GboxScores.TabStop = False
        Me.GboxScores.Text = "Scores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuizProject.My.Resources.Resources.Tulip
        Me.PictureBox1.Location = New System.Drawing.Point(295, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(178, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Out of"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(178, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Out of"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(178, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Out of"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(178, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Out of"
        '
        'TxtIQTotal
        '
        Me.TxtIQTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIQTotal.Location = New System.Drawing.Point(235, 145)
        Me.TxtIQTotal.Name = "TxtIQTotal"
        Me.TxtIQTotal.Size = New System.Drawing.Size(54, 26)
        Me.TxtIQTotal.TabIndex = 22
        '
        'TxtSportsTotal
        '
        Me.TxtSportsTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSportsTotal.Location = New System.Drawing.Point(235, 113)
        Me.TxtSportsTotal.Name = "TxtSportsTotal"
        Me.TxtSportsTotal.Size = New System.Drawing.Size(54, 26)
        Me.TxtSportsTotal.TabIndex = 21
        '
        'TxtScienceTotal
        '
        Me.TxtScienceTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtScienceTotal.Location = New System.Drawing.Point(235, 81)
        Me.TxtScienceTotal.Name = "TxtScienceTotal"
        Me.TxtScienceTotal.Size = New System.Drawing.Size(54, 26)
        Me.TxtScienceTotal.TabIndex = 20
        '
        'TxtComputerTotal
        '
        Me.TxtComputerTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtComputerTotal.Location = New System.Drawing.Point(235, 49)
        Me.TxtComputerTotal.Name = "TxtComputerTotal"
        Me.TxtComputerTotal.Size = New System.Drawing.Size(54, 26)
        Me.TxtComputerTotal.TabIndex = 19
        '
        'TxtMathematicsTotal
        '
        Me.TxtMathematicsTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMathematicsTotal.Location = New System.Drawing.Point(235, 19)
        Me.TxtMathematicsTotal.Name = "TxtMathematicsTotal"
        Me.TxtMathematicsTotal.Size = New System.Drawing.Size(54, 26)
        Me.TxtMathematicsTotal.TabIndex = 18
        '
        'TxtIQ
        '
        Me.TxtIQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIQ.Location = New System.Drawing.Point(121, 145)
        Me.TxtIQ.Name = "TxtIQ"
        Me.TxtIQ.Size = New System.Drawing.Size(54, 26)
        Me.TxtIQ.TabIndex = 17
        '
        'TxtSports
        '
        Me.TxtSports.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSports.Location = New System.Drawing.Point(121, 113)
        Me.TxtSports.Name = "TxtSports"
        Me.TxtSports.Size = New System.Drawing.Size(54, 26)
        Me.TxtSports.TabIndex = 16
        '
        'TxtScience
        '
        Me.TxtScience.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtScience.Location = New System.Drawing.Point(121, 81)
        Me.TxtScience.Name = "TxtScience"
        Me.TxtScience.Size = New System.Drawing.Size(54, 26)
        Me.TxtScience.TabIndex = 15
        '
        'TxtComputer
        '
        Me.TxtComputer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtComputer.Location = New System.Drawing.Point(121, 49)
        Me.TxtComputer.Name = "TxtComputer"
        Me.TxtComputer.Size = New System.Drawing.Size(54, 26)
        Me.TxtComputer.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(178, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Out of"
        '
        'TxtMathematics
        '
        Me.TxtMathematics.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMathematics.Location = New System.Drawing.Point(121, 19)
        Me.TxtMathematics.Name = "TxtMathematics"
        Me.TxtMathematics.Size = New System.Drawing.Size(54, 26)
        Me.TxtMathematics.TabIndex = 12
        '
        'CboxPlayerID
        '
        Me.CboxPlayerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboxPlayerID.FormattingEnabled = True
        Me.CboxPlayerID.Location = New System.Drawing.Point(151, 53)
        Me.CboxPlayerID.Name = "CboxPlayerID"
        Me.CboxPlayerID.Size = New System.Drawing.Size(140, 27)
        Me.CboxPlayerID.TabIndex = 13
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.ForeColor = System.Drawing.Color.Blue
        Me.BtnSearch.Location = New System.Drawing.Point(297, 52)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 28)
        Me.BtnSearch.TabIndex = 14
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 429)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CboxPlayerID)
        Me.Controls.Add(Me.GboxScores)
        Me.Controls.Add(Me.GboxPlayerInformation)
        Me.Controls.Add(Me.LblSelectPlayersID)
        Me.Controls.Add(Me.LblReportSheet)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GboxPlayerInformation.ResumeLayout(False)
        Me.GboxPlayerInformation.PerformLayout()
        Me.GboxScores.ResumeLayout(False)
        Me.GboxScores.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblReportSheet As System.Windows.Forms.Label
    Friend WithEvents LblSelectPlayersID As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents LblMathematics As System.Windows.Forms.Label
    Friend WithEvents LblScience As System.Windows.Forms.Label
    Friend WithEvents LblLogical As System.Windows.Forms.Label
    Friend WithEvents LblSports As System.Windows.Forms.Label
    Friend WithEvents LblComputer As System.Windows.Forms.Label
    Friend WithEvents GboxPlayerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GboxScores As System.Windows.Forms.GroupBox
    Friend WithEvents CboxPlayerID As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtGender As System.Windows.Forms.TextBox
    Friend WithEvents TxtMathematics As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtIQTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtSportsTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtScienceTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtComputerTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtMathematicsTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtIQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtSports As System.Windows.Forms.TextBox
    Friend WithEvents TxtScience As System.Windows.Forms.TextBox
    Friend WithEvents TxtComputer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
End Class
