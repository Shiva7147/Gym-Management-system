Imports System.Data.SqlClient


Public Class GYM_EQUIPMENTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name = TextBox1.Text
        Dim quantity = TextBox2.Text
        Dim condition = TextBox3.Text

        ' Connection string
        Dim connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shiva\Documents\OML.mdf;Integrated Security=True;Connect Timeout=30;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query = "INSERT INTO EQMANAGE (Name, quantity, condition) VALUES (@Name, @quantity, @condition)"

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", name)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@condition", condition)
            ' Execute the command
            command.ExecuteNonQuery()
            connection.Close()
        End Using

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        ' Optionally, display a success message
        MessageBox.Show("added successful!")
    End Sub

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shiva\Documents\OML.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GYM_EQUIPMENTS()
        Con.Open()
        Dim query = "select * from EQMANAGE"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub GYM_EQUIPMENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GYM_EQUIPMENTS()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
        ' Show the Members form
        Me.Hide()
    End Sub
End Class