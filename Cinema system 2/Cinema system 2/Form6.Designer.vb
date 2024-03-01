<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        MM = New TextBox()
        YY = New TextBox()
        ccv = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(387, 253)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 33)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(228, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 21)
        Label1.TabIndex = 1
        Label1.Text = "Please input you credit card info"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(190, 168)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(325, 23)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Visa", "MasterCard"})
        ComboBox1.Location = New Point(291, 110)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(133, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(291, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 15)
        Label2.TabIndex = 4
        Label2.Text = "Card company name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(291, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 21)
        Label3.TabIndex = 5
        Label3.Text = "Card number"
        ' 
        ' MM
        ' 
        MM.Location = New Point(204, 219)
        MM.Margin = New Padding(3, 2, 3, 2)
        MM.Name = "MM"
        MM.Size = New Size(65, 23)
        MM.TabIndex = 6
        MM.Text = "mm"
        ' 
        ' YY
        ' 
        YY.Location = New Point(291, 219)
        YY.Margin = New Padding(3, 2, 3, 2)
        YY.Name = "YY"
        YY.Size = New Size(82, 23)
        YY.TabIndex = 7
        YY.Text = "yyyy"
        ' 
        ' ccv
        ' 
        ccv.Location = New Point(456, 219)
        ccv.Margin = New Padding(3, 2, 3, 2)
        ccv.Name = "ccv"
        ccv.Size = New Size(59, 23)
        ccv.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(204, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 15)
        Label4.TabIndex = 9
        Label4.Text = "Expiration Date: MM/YYYY"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(466, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 10
        Label5.Text = "CCV"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(190, 253)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 35)
        Button2.TabIndex = 11
        Button2.Text = "Return"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(700, 338)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ccv)
        Controls.Add(YY)
        Controls.Add(MM)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MM As TextBox
    Friend WithEvents YY As TextBox
    Friend WithEvents ccv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
