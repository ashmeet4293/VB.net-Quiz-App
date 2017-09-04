Public Class UserSelectionForm

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        If CboxUsertype.Text = "Admin" Then
            AdminLoginForm.Show()
        ElseIf CboxUsertype.Text = "Contestant" Then
            ContestantLoginForm.show()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
