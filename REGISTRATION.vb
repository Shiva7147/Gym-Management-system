Imports System.Data.SqlClient

Public Class RegistrationForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim age As Integer
        If Not Integer.TryParse(TextBox2.Text, age) Then
            MessageBox.Show("Please enter a valid age.")
            Return
        End If
        Dim phoneNumber As String = TextBox3.Text
        Dim gymPlan As String = TextBox4.Text
        Dim trainerName As String = TextBox5.Text

        ' Connection string
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shiva\Documents\REGISTERATION.mdf;Integrated Security=True;Connect Timeout=30"

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Registrations (Name, Age, PhoneNumber, GymPlan, TrainerName) VALUES (@Name, @Age, @PhoneNumber, @GymPlan, @TrainerName)"

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", name)
            command.Parameters.AddWithValue("@Age", age)
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
            command.Parameters.AddWithValue("@GymPlan", gymPlan)
            command.Parameters.AddWithValue("@TrainerName", trainerName)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        End Using

        ' Clear the form fields
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        ' Optionally, display a success message
        MessageBox.Show("Registration successful!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Navigate back to the previous form or close the current form
        Me.Close()
    End Sub
End Class
