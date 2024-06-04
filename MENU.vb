Public Class MENU
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transformationForm As New SCAM()
        transformationForm.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MEMBERS()
        transformationForm.ShowDialog()
        ' Show the Members form
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim transformationForm As New DIET_CHART()
        transformationForm.ShowDialog()
        ' Show the GymPlans form
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim transformationForm As New BMI_CALCULATOR()
        transformationForm.ShowDialog()
        ' Show the Diet form
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim transformationForm As New GYM_PLAN()
        transformationForm.ShowDialog()
        ' Show the Diet form
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim transformationForm As New GYM_EQUIPMENTS()
        transformationForm.ShowDialog()
        ' Show the Diet form
        Me.Hide()
    End Sub
End Class