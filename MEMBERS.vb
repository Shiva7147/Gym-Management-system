Imports System.Data.SqlClient

Public Class MEMBERS
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shiva\Documents\OML.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub MEMBERS()
        Con.Open()
        Dim query = "select * from Registrations"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub MEMBERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MEMBERS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transformationForm As New MENU()
        transformationForm.ShowDialog()
        ' Show the Members form
        Me.Hide()
    End Sub
End Class