<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label1 = New Label()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button5 = New Button()
        ListBox1 = New ListBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(545, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 21)
        Label1.TabIndex = 0
        Label1.Text = "Summary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(156, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 21)
        Label2.TabIndex = 2
        Label2.Text = "Select payment"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(97, 160)
        RadioButton1.Margin = New Padding(3, 2, 3, 2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 19)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Credit Card"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(246, 160)
        RadioButton2.Margin = New Padding(3, 2, 3, 2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(51, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Cash"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(457, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 21)
        Label3.TabIndex = 5
        Label3.Text = "Total Amount:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(579, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 21)
        Label4.TabIndex = 6
        Label4.Text = "Where the total will be"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(457, 323)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 42)
        Button1.TabIndex = 7
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(97, 267)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(141, 42)
        Button5.TabIndex = 16
        Button5.Text = "Return"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(457, 66)
        ListBox1.Margin = New Padding(3, 2, 3, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(274, 169)
        ListBox1.TabIndex = 19
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(97, 323)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 42)
        Button2.TabIndex = 20
        Button2.Text = "Return to Food section"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(780, 382)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
End Class
