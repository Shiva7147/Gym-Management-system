<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        BindingSource1 = New BindingSource(components)
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Stencil", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(268, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 35)
        Label1.TabIndex = 0
        Label1.Text = "FIT NATION GYM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Stencil", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(123, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 35)
        Label3.TabIndex = 2
        Label3.Text = "USER NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Stencil", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(132, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 35)
        Label2.TabIndex = 3
        Label2.Text = "PASSWORD"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(221, 312)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 48)
        Button1.TabIndex = 6
        Button1.Text = "CANCEL"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(388, 130)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(222, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(388, 217)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(215, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(425, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 48)
        Button2.TabIndex = 9
        Button2.Text = "LOGIN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "LOGIN"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
