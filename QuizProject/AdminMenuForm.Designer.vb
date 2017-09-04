<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenuForm))
        Me.AdminMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWRESULTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminMenuStrip
        '
        Me.AdminMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.AdminMenuStrip.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.AdminMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem, Me.QuestionToolStripMenuItem, Me.ResultToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.AdminMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AdminMenuStrip.Name = "AdminMenuStrip"
        Me.AdminMenuStrip.Size = New System.Drawing.Size(537, 27)
        Me.AdminMenuStrip.TabIndex = 0
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.UPDATEToolStripMenuItem})
        Me.PlayerToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PlayerToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Player
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(92, 23)
        Me.PlayerToolStripMenuItem.Text = "PLAYER"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ADDToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.AddPlayer
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ADDToolStripMenuItem.Text = "ADD PLAYER"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DELETEToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.DeletePlayers
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.DELETEToolStripMenuItem.Text = "DELETE PLAYER"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UPDATEToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.UpdatePlayers
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE PLAYER"
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem1, Me.DELETEToolStripMenuItem1, Me.UPDATEToolStripMenuItem1})
        Me.QuestionToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.QuestionToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Questions
        Me.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem"
        Me.QuestionToolStripMenuItem.Size = New System.Drawing.Size(109, 23)
        Me.QuestionToolStripMenuItem.Text = "QUESTION"
        '
        'ADDToolStripMenuItem1
        '
        Me.ADDToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ADDToolStripMenuItem1.Image = Global.QuizProject.My.Resources.Resources.AddQuestion
        Me.ADDToolStripMenuItem1.Name = "ADDToolStripMenuItem1"
        Me.ADDToolStripMenuItem1.Size = New System.Drawing.Size(215, 24)
        Me.ADDToolStripMenuItem1.Text = "ADD QUESTION"
        '
        'DELETEToolStripMenuItem1
        '
        Me.DELETEToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DELETEToolStripMenuItem1.Image = Global.QuizProject.My.Resources.Resources.DeleteQuestions
        Me.DELETEToolStripMenuItem1.Name = "DELETEToolStripMenuItem1"
        Me.DELETEToolStripMenuItem1.Size = New System.Drawing.Size(215, 24)
        Me.DELETEToolStripMenuItem1.Text = "DELETE QUESTION"
        '
        'UPDATEToolStripMenuItem1
        '
        Me.UPDATEToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UPDATEToolStripMenuItem1.Image = Global.QuizProject.My.Resources.Resources.UpdateQuestions
        Me.UPDATEToolStripMenuItem1.Name = "UPDATEToolStripMenuItem1"
        Me.UPDATEToolStripMenuItem1.Size = New System.Drawing.Size(215, 24)
        Me.UPDATEToolStripMenuItem1.Text = "UPDATE QUESTION"
        '
        'ResultToolStripMenuItem
        '
        Me.ResultToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWRESULTToolStripMenuItem, Me.VIEWREPORTToolStripMenuItem})
        Me.ResultToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ResultToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Result
        Me.ResultToolStripMenuItem.Name = "ResultToolStripMenuItem"
        Me.ResultToolStripMenuItem.Size = New System.Drawing.Size(90, 23)
        Me.ResultToolStripMenuItem.Text = "RESULT"
        '
        'VIEWRESULTToolStripMenuItem
        '
        Me.VIEWRESULTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VIEWRESULTToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Result
        Me.VIEWRESULTToolStripMenuItem.Name = "VIEWRESULTToolStripMenuItem"
        Me.VIEWRESULTToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.VIEWRESULTToolStripMenuItem.Text = "VIEW RESULT"
        '
        'VIEWREPORTToolStripMenuItem
        '
        Me.VIEWREPORTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VIEWREPORTToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Report
        Me.VIEWREPORTToolStripMenuItem.Name = "VIEWREPORTToolStripMenuItem"
        Me.VIEWREPORTToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.VIEWREPORTToolStripMenuItem.Text = "VIEW REPORT"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHANGEPASSWORDToolStripMenuItem})
        Me.PasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.PasswordToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Key
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(117, 23)
        Me.PasswordToolStripMenuItem.Text = "PASSWORD"
        '
        'CHANGEPASSWORDToolStripMenuItem
        '
        Me.CHANGEPASSWORDToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CHANGEPASSWORDToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Lock
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.EXITToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources._Exit
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'AdminMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 360)
        Me.Controls.Add(Me.AdminMenuStrip)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AdminMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.AdminMenuStrip.ResumeLayout(False)
        Me.AdminMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents PlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWRESULTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
