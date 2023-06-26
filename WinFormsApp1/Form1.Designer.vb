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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Label5 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 23)
        Label1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(214, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveBorder
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(367, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 37)
        Label3.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(226, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Вычислить"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = SystemColors.Control
        CheckBox1.Location = New Point(17, 132)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(55, 30)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Reset"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(17, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(191, 23)
        Label5.TabIndex = 9
        Label5.Text = "Элемент треугольника:"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(682, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 20)
        Label7.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Сторона а", "Высота h", "Площадь S", "r радиус вписанной окружности", "R радиус описанной окружности"})
        ComboBox1.Location = New Point(214, 47)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(17, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 23)
        Label2.TabIndex = 9
        Label2.Text = "Значение:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(17, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 23)
        Label4.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(556, 20)
        Label6.TabIndex = 11
        Label6.Text = "Равносторонний треугольник. Примечание: высота = медиана = биссектриса." ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(438, 50)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 12
        Label8.Text = "Параметры: "' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        ClientSize = New Size(637, 173)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
