Public Class AdminMenuForm
    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        PlayerRegistrationForm.Show()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        PlayerDeletionForm.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        PlayerUpdateForm.Show()
    End Sub

    Private Sub ADDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem1.Click
        QuestionRegistrationForm.Show()
    End Sub

    Private Sub DELETEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem1.Click
        QuestionDeletionForm.Show()
    End Sub

    Private Sub UPDATEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem1.Click
        QuestionUpdateForm.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VIEWRESULTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWRESULTToolStripMenuItem.Click
        ResultForm.Show()
    End Sub

    Private Sub VIEWREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWREPORTToolStripMenuItem.Click
        ReportForm.Show()
    End Sub

    Private Sub CHANGEPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEPASSWORDToolStripMenuItem.Click
        AdminChangePasswordForm.Show()
    End Sub
End Class