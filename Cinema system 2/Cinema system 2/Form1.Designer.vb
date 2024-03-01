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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close = New System.Windows.Forms.Button()
        Me.tickets = New System.Windows.Forms.Button()
        Me.food = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(245, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome to Alejandro Cinemas!"
        '
        'close
        '
        Me.close.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.close.Location = New System.Drawing.Point(303, 151)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(180, 68)
        Me.close.TabIndex = 6
        Me.close.Text = "Exit"
        Me.close.UseVisualStyleBackColor = True
        '
        'tickets
        '
        Me.tickets.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tickets.Location = New System.Drawing.Point(117, 70)
        Me.tickets.Name = "tickets"
        Me.tickets.Size = New System.Drawing.Size(180, 68)
        Me.tickets.TabIndex = 5
        Me.tickets.Text = "Movie Tickets"
        Me.tickets.UseVisualStyleBackColor = True
        '
        'food
        '
        Me.food.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.food.Location = New System.Drawing.Point(495, 70)
        Me.food.Name = "food"
        Me.food.Size = New System.Drawing.Size(180, 68)
        Me.food.TabIndex = 4
        Me.food.Text = "Food"
        Me.food.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(799, 250)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.tickets)
        Me.Controls.Add(Me.food)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents close As Button
    Friend WithEvents tickets As Button
    Friend WithEvents food As Button
End Class
