<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GYM_EQUIPMENTS
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(797, 219)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Bernard MT Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(411, 336)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 61)
        Button1.TabIndex = 1
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(32, 273)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(291, 273)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(213, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(561, 273)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 222)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 36)
        Label1.TabIndex = 5
        Label1.Text = "EQUIPMENTS NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(587, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 36)
        Label2.TabIndex = 6
        Label2.Text = "CONDITION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(325, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 36)
        Label3.TabIndex = 7
        Label3.Text = " QUANTITY"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Bernard MT Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(221, 336)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 61)
        Button2.TabIndex = 8
        Button2.Text = "MENU"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GYM_EQUIPMENTS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "GYM_EQUIPMENTS"
        Text = "GYM_EQUIPMENTS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
