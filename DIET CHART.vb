Public Class DIET_CHART
    Private Sub DIET_CHART_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange({"Vegetarian", "Non-Vegetarian"})
        ' Add weight range options
        ComboBox2.Items.AddRange({"50-60", "60-70", "70-80"})
        ComboBox3.Items.AddRange({"Lose Weight", "Gain Weight", "Muscle Gain"})
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vegetarianChoice = ComboBox1.SelectedItem.ToString
        ' Extracting weight range
        Dim weightRange = ComboBox2.SelectedItem.ToString.Split("-"c)
        Dim weightLowerBound = Integer.Parse(weightRange(0))
        Dim weightUpperBound = Integer.Parse(weightRange(1))
        Dim bodyGoal = ComboBox3.SelectedItem.ToString

        ' Average weight in the range
        Dim weight = (weightLowerBound + weightUpperBound) / 2

        Dim proteinRequirement = CalculateProteinRequirement(weight, bodyGoal)
        Dim sampleDietChart = GenerateDietChart(vegetarianChoice, weight, bodyGoal, proteinRequirement)

        MessageBox.Show(sampleDietChart, "Sample Diet Chart")


    End Sub

    Private Function CalculateProteinRequirement(weight As Integer, bodyGoal As String) As Double
        Dim proteinRequirement As Double
        Select Case bodyGoal
            Case "Lose Weight"
                proteinRequirement = weight * 1.2 ' For weight loss
            Case "Gain Weight"
                proteinRequirement = weight * 1.5 ' For weight gain
            Case "Muscle Gain"
                proteinRequirement = weight * 1.8 ' For muscle gain
        End Select
        Return proteinRequirement
    End Function

    Private Function GenerateDietChart(vegetarianChoice As String, weight As Integer, bodyGoal As String, proteinRequirement As Double) As String
        Dim dietChart As String = "Sample diet chart:" & Environment.NewLine
        dietChart &= "Your daily protein requirement is " & proteinRequirement.ToString() & " grams." & Environment.NewLine

        ' Generating a sample diet based on user preferences
        dietChart &= "Sample Diet:" & Environment.NewLine
        If vegetarianChoice = "Vegetarian" Then
            dietChart &= "Breakfast: Oatmeal with fruits" & Environment.NewLine
            dietChart &= "Lunch: Quinoa salad with chickpeas" & Environment.NewLine
            dietChart &= "Dinner: Grilled tofu with vegetables" & Environment.NewLine
        Else
            dietChart &= "Breakfast: Scrambled eggs with whole wheat toast" & Environment.NewLine
            dietChart &= "Lunch: Grilled chicken breast with brown rice" & Environment.NewLine
            dietChart &= "Dinner: Baked salmon with sweet potato" & Environment.NewLine
        End If

        ' Adjustments based on body goals
        Select Case bodyGoal
            Case "Lose Weight"
                dietChart &= "Snacks: Mixed nuts, fruits" & Environment.NewLine
                dietChart &= "Drink plenty of water throughout the day."
            Case "Gain Weight"
                dietChart &= "Snacks: Greek yogurt with honey, protein shake" & Environment.NewLine
                dietChart &= "Drink milk or protein shakes between meals."
            Case "Muscle Gain"
                dietChart &= "Snacks: Protein bars, cottage cheese" & Environment.NewLine
                dietChart &= "Ensure a protein source with each meal."
        End Select
        Return dietChart

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
    End Sub
End Class
