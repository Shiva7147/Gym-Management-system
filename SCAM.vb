Imports System.Data.SqlClient
Public Class SCAM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim phoneNumber As String = TextBox2.Text
        Dim gymPlan As String = TextBox4.Text
        Dim trainerName As String = TextBox5.Text

        ' Connection string
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shiva\Documents\OML.mdf;Integrated Security=True;Connect Timeout=30;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO Registrations (Name, PhoneNumber, GymPlan, TrainerName) VALUES (@Name, @PhoneNumber, @GymPlan, @TrainerName)"

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", name)
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
            command.Parameters.AddWithValue("@GymPlan", gymPlan)
            command.Parameters.AddWithValue("@TrainerName", trainerName)

            ' Execute the command
            command.ExecuteNonQuery()

            connection.Close()
        End Using

        ' Clear the form fields
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        ' Optionally, display a success message
        MessageBox.Show("Registration successful!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
        ' Show the Members form
        Me.Hide()
    End Sub
End Class