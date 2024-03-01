Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open = New Form5
        Dim tt As Double
        Dim a1 As Double
        Dim a2 As Double
        Dim a3 As Double
        Dim a4 As Double
        Dim a5 As Double
        Dim a6 As Double
        a1 = 0
        a2 = 0
        a3 = 0
        a4 = 0
        a5 = 0
        a6 = 0
        If Popcorn.Checked Then
            open.ListBox1.Items.Add("Popcorn = 10.20")
            a1 = 10.2
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
        End If
        If Hotdog.Checked Then
            open.ListBox1.Items.Add("Hotdog = 5.20")
            a2 = 5.2
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If Corndog.Checked Then
            open.ListBox1.Items.Add("Hotdog = 8.20")
            a3 = 8.2
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If Nacho.Checked Then
            open.ListBox1.Items.Add("nachos = 9.20")
            a4 = 8.2
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If Hershey.Checked Then
            open.ListBox1.Items.Add("Hershey = 1.20")
            a5 = 1.2
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If

        If RadioButton1.Checked Then
            open.ListBox1.Items.Add("Coca Cola 1.00")
            a6 = 1
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If RadioButton2.Checked Then
            open.ListBox1.Items.Add("Mugs Root Beer 1.00")
            a6 = 1
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If RadioButton3.Checked Then
            open.ListBox1.Items.Add("Fanta Orange 1.00")
            a6 = 1
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If
        If RadioButton4.Checked Then
            open.ListBox1.Items.Add("Sprite 1.00")
            a6 = 1
            tt = a1 + a2 + a3 + a4 + a5 + a6
            open.Label4.Text = tt
            open.Show()
            Me.Close()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d1 = New Form1
        d1.Show()
        Me.Close()
    End Sub
End Class