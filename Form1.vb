Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if the username and password are valid
        Dim username = TextBox1.Text
        Dim password = TextBox2.Text

        ' For simplicity, let's assume the username is "admin" and password is "password"
        If username = "SHIVA" AndAlso password = "1234" Then
            ' If credentials are correct, show the menu form
            Dim menuForm As New MENU
            menuForm.Show()
            Hide() ' Hide the login form
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button1_Click(e As EventArgs, sender As Object) Handles Button1.Click
        ' Clear the text in the textboxes
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class