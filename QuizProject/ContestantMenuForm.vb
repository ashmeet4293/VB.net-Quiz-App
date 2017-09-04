Public Class ContestantMenuForm
    Private Sub ViewResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResultToolStripMenuItem.Click
        ResultForm.Show()
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        ContestantChangePasswordForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        GamingForm.Show()
    End Sub
End Class