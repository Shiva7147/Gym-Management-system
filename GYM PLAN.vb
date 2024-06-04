Public Class GYM_PLAN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transformationForm As New RegistrationForm()
        transformationForm.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
        Me.Hide()
    End Sub
End Class