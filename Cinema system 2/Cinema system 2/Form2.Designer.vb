<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        a65 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        adm = New ComboBox()
        ma = New ComboBox()
        dnd1 = New ComboBox()
        creed3 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' a65
        ' 
        a65.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        a65.ForeColor = SystemColors.ActiveCaptionText
        a65.Location = New Point(965, 868)
        a65.Name = "a65"
        a65.Size = New Size(171, 67)
        a65.TabIndex = 25
        a65.Text = "Enter"
        a65.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(467, 188)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(248, 381)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1113, 188)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(278, 381)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(134, 188)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(302, 381)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(755, 188)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(315, 381)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(514, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(519, 28)
        Label1.TabIndex = 16
        Label1.Text = "Select the Movie you wish to see( can only chose 1 movie):"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(685, 868)
        Button3.Name = "Button3"
        Button3.Size = New Size(171, 67)
        Button3.TabIndex = 30
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(421, 868)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 67)
        Button2.TabIndex = 29
        Button2.Text = "Return"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' adm
        ' 
        adm.FormattingEnabled = True
        adm.Items.AddRange(New Object() {"1"})
        adm.Location = New Point(233, 669)
        adm.Name = "adm"
        adm.Size = New Size(63, 28)
        adm.TabIndex = 36
        ' 
        ' ma
        ' 
        ma.FormattingEnabled = True
        ma.Items.AddRange(New Object() {"1"})
        ma.Location = New Point(566, 669)
        ma.Name = "ma"
        ma.Size = New Size(63, 28)
        ma.TabIndex = 37
        ma.Text = "The Super Mario Movie"
        ' 
        ' dnd1
        ' 
        dnd1.FormattingEnabled = True
        dnd1.Items.AddRange(New Object() {"1"})
        dnd1.Location = New Point(890, 669)
        dnd1.Name = "dnd1"
        dnd1.Size = New Size(63, 28)
        dnd1.TabIndex = 38
        ' 
        ' creed3
        ' 
        creed3.FormattingEnabled = True
        creed3.Items.AddRange(New Object() {"1"})
        creed3.Location = New Point(1226, 669)
        creed3.Name = "creed3"
        creed3.Size = New Size(63, 28)
        creed3.TabIndex = 39
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5"})
        ComboBox2.Location = New Point(678, 817)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(161, 28)
        ComboBox2.TabIndex = 44
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(645, 755)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 28)
        Label3.TabIndex = 43
        Label3.Text = "Select the following seat"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1552, 987)
        ControlBox = False
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(creed3)
        Controls.Add(dnd1)
        Controls.Add(ma)
        Controls.Add(adm)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(a65)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents a65 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents adm As ComboBox
    Friend WithEvents ma As ComboBox
    Friend WithEvents dnd1 As ComboBox
    Friend WithEvents creed3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
End Class
