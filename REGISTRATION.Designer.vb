Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(412, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 50)
        Button1.TabIndex = 5
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(201, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 50)
        Button2.TabIndex = 6
        Button2.Text = "Go Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 36.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(175, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 72)
        Label1.TabIndex = 7
        Label1.Text = "REGISTERATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(213, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 33)
        Label2.TabIndex = 8
        Label2.Text = "NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(128, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 33)
        Label3.TabIndex = 9
        Label3.Text = "PHONE NUMBER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(213, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 33)
        Label4.TabIndex = 10
        Label4.Text = "AGE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(175, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 33)
        Label5.TabIndex = 11
        Label5.Text = "GYM PLAN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(138, 322)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 33)
        Label6.TabIndex = 12
        Label6.Text = "TRAINER NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(396, 114)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(396, 163)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(396, 216)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(396, 267)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 17
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(396, 322)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 18
        ' 
        ' RegistrationForm
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(766, 470)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "RegistrationForm"
        Text = "Gym Registration Form"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
