Public Class BMI_CALCULATOR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height = TextBox1.Text / 100 ' Convert height from cm to meters
        Dim weight As Double = TextBox2.Text

        ' Calculate BMI
        Dim bmi = weight / (height * height)

        ' Display BMI in a message box
        MessageBox.Show("Your BMI: " & bmi.ToString("0.00"))

        ' Provide suggestions based on BMI
        Dim statusMessage As String

        If bmi < 18.5 Then
            statusMessage = "Underweight: You may need to gain some weight. Consult with a healthcare professional."
        ElseIf bmi >= 18.5 AndAlso bmi < 25 Then
            statusMessage = "Normal weight: Your weight is healthy. Keep up the good work!"
        ElseIf bmi >= 25 AndAlso bmi < 30 Then
            statusMessage = "Overweight: You may need to lose some weight. Consider a balanced diet and exercise."
        Else
            statusMessage = "Obese: It's important to focus on weight loss for your health. Consult with a healthcare professional."
        End If

        ' Display status message in a message box
        MessageBox.Show(statusMessage, "BMI Status")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
        Me.Hide()
    End Sub
End Class