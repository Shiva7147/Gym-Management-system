﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIET_CHART
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DIET_CHART))
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.No
        Label1.Font = New Font("Bernard MT Condensed", 25.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(227, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(369, 52)
        Label1.TabIndex = 0
        Label1.Text = "SAMPLE DIET CHART"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(404, 324)
        Button1.Name = "Button1"
        Button1.Size = New Size(192, 51)
        Button1.TabIndex = 1
        Button1.Text = "GET SAMPLE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.No
        Label2.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(146, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 33)
        Label2.TabIndex = 2
        Label2.Text = "TYPE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.No
        Label3.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(348, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 33)
        Label3.TabIndex = 3
        Label3.Text = "WEIGHT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Cursor = Cursors.No
        Label4.Font = New Font("Bernard MT Condensed", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(575, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 33)
        Label4.TabIndex = 4
        Label4.Text = "GOAL"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(105, 217)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(325, 211)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 6
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(529, 211)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(183, 324)
        Button2.Name = "Button2"
        Button2.Size = New Size(192, 51)
        Button2.TabIndex = 8
        Button2.Text = "GO BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DIET_CHART
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "DIET_CHART"
        Text = "DIET_CHART"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button2 As Button
End Class
