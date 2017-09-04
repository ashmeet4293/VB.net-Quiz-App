<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContestantMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContestantMenuForm))
        Me.ContestantMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSTRUCTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContestantMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContestantMenuStrip
        '
        Me.ContestantMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.ContestantMenuStrip.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContestantMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.ContestantMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ResultToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContestantMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ContestantMenuStrip.Name = "ContestantMenuStrip"
        Me.ContestantMenuStrip.Padding = New System.Windows.Forms.Padding(4, 3, 0, 3)
        Me.ContestantMenuStrip.Size = New System.Drawing.Size(533, 29)
        Me.ContestantMenuStrip.TabIndex = 1
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem})
        Me.GameToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.GameToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Game
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(79, 23)
        Me.GameToolStripMenuItem.Text = "GAME"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartGameToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.GamePlay
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.StartGameToolStripMenuItem.Text = "START GAME"
        '
        'ResultToolStripMenuItem
        '
        Me.ResultToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewResultToolStripMenuItem})
        Me.ResultToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ResultToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Result
        Me.ResultToolStripMenuItem.Name = "ResultToolStripMenuItem"
        Me.ResultToolStripMenuItem.Size = New System.Drawing.Size(90, 23)
        Me.ResultToolStripMenuItem.Text = "RESULT"
        '
        'ViewResultToolStripMenuItem
        '
        Me.ViewResultToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewResultToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Result
        Me.ViewResultToolStripMenuItem.Name = "ViewResultToolStripMenuItem"
        Me.ViewResultToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.ViewResultToolStripMenuItem.Text = "VIEW RESULT"
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
        Me.CHANGEPASSWORDToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CHANGEPASSWORDToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Lock
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(226, 24)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "CHANGE PASSWORD"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSTRUCTIONToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.HelpToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Help
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.HelpToolStripMenuItem.Text = "HELP"
        '
        'INSTRUCTIONToolStripMenuItem
        '
        Me.INSTRUCTIONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.INSTRUCTIONToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.Instruction
        Me.INSTRUCTIONToolStripMenuItem.Name = "INSTRUCTIONToolStripMenuItem"
        Me.INSTRUCTIONToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.INSTRUCTIONToolStripMenuItem.Text = "INSTRUCTION"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AboutToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources.About
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.AboutToolStripMenuItem.Text = "ABOUT"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ExitToolStripMenuItem.Image = Global.QuizProject.My.Resources.Resources._Exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.ExitToolStripMenuItem.Text = "EXIT"
        '
        'ContestantMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizProject.My.Resources.Resources.Background7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(533, 356)
        Me.Controls.Add(Me.ContestantMenuStrip)
        Me.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ContestantMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContestantMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContestantMenuStrip.ResumeLayout(False)
        Me.ContestantMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContestantMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSTRUCTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
