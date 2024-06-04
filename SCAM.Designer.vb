<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCAM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCAM))
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(437, 266)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 31
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(437, 211)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 30
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(437, 160)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 29
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(431, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 27
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(179, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 33)
        Label6.TabIndex = 26
        Label6.Text = "TRAINER NAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(216, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 33)
        Label5.TabIndex = 25
        Label5.Text = "GYM PLAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(179, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 33)
        Label3.TabIndex = 23
        Label3.Text = "PHONE NUMBER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(248, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 33)
        Label2.TabIndex = 22
        Label2.Text = "NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(210, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 72)
        Label1.TabIndex = 21
        Label1.Text = "REGISTERATION"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(242, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 50)
        Button2.TabIndex = 20
        Button2.Text = "Go Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(453, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 50)
        Button1.TabIndex = 19
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SCAM
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(829, 510)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "SCAM"
        Text = "SCAM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
