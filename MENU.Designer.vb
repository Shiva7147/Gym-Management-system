<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(296, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 44)
        Label1.TabIndex = 0
        Label1.Text = "DASBOARD"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(90, 122)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 61)
        Button1.TabIndex = 1
        Button1.Text = "REGISTERATION"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(441, 122)
        Button2.Name = "Button2"
        Button2.Size = New Size(224, 61)
        Button2.TabIndex = 2
        Button2.Text = "MEMBERS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(90, 232)
        Button3.Name = "Button3"
        Button3.Size = New Size(224, 61)
        Button3.TabIndex = 3
        Button3.Text = "DIET CHART"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(441, 232)
        Button4.Name = "Button4"
        Button4.Size = New Size(224, 61)
        Button4.TabIndex = 4
        Button4.Text = "BMI CALCULATOR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(90, 352)
        Button5.Name = "Button5"
        Button5.Size = New Size(224, 61)
        Button5.TabIndex = 5
        Button5.Text = "GYM PLANS"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(441, 344)
        Button6.Name = "Button6"
        Button6.Size = New Size(224, 79)
        Button6.TabIndex = 6
        Button6.Tag = "EQUIPMENTS MANAGEMENTS"
        Button6.Text = "EQUIPMENTS MANAGEMENTS"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' MENU
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "MENU"
        Text = "MENU"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
